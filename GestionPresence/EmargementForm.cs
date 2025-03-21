using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPresence
{
    public partial class EmargementForm: Form
    {
        public EmargementForm()
        {
            InitializeComponent();
            // Charger les professeurs et les cours dans les ComboBox
            LoadProfesseurs();
            LoadCours();
            LoadEmargements();
        }

        private void LoadProfesseurs()
        {
            using (var db = new DbPresence())
            {
                var professeurs = db.Users.Where(u => u.Role == "Professeur").ToList();
                if (professeurs.Count == 0)
                {
                    MessageBox.Show("Aucun professeur trouvé.");
                    return;
                }
                cmbProfesseurEmarge.DataSource = professeurs;
                cmbProfesseurEmarge.DisplayMember = "Nom";
                cmbProfesseurEmarge.ValueMember = "Id";
            }

        }

        private void LoadCours()
        {
            using (var db = new DbPresence())
            {
                var cours = db.Cours.ToList();
                if (cours.Count == 0)
                {
                    MessageBox.Show("Aucun cours trouvé.");
                    return;
                }
                cmbCoursEmarge.DataSource = cours;
                cmbCoursEmarge.DisplayMember = "Nom";
                cmbCoursEmarge.ValueMember = "Id";
            }
        }

        private void LoadEmargements()
        {
            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                    .Join(db.Users,
                        emargement => emargement.ProfesseurId,
                        professeur => professeur.Id,
                        (emargement, professeur) => new { emargement, professeur })
                    .Join(db.Cours,
                        temp => temp.emargement.CoursId,
                        cours => cours.Id,
                        (temp, cours) => new
                        {
                            temp.emargement.Id,
                            Professeur = temp.professeur.Nom,
                            Cours = cours.Nom,
                            temp.emargement.Date,
                            temp.emargement.Statut
                        })
                    .ToList();

                dataGridViewEmarge.DataSource = emargements;
            }
        }
        private void effacer()
        {
            cmbProfesseurEmarge.Text = "Selectionner";
            cmbCoursEmarge.Text = "Selectionner";
            ckbPresent.Checked = false;
            ckbAbsent.Checked = false;
        }
        private void btnValiderEmerge_Click(object sender, EventArgs e)
        {
            // Vérifier que les ComboBox ont une sélection valide
            if (cmbProfesseurEmarge.SelectedValue == null || cmbCoursEmarge.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un professeur et un cours.");
                return;
            }

            int professeurId = (int)cmbProfesseurEmarge.SelectedValue;
            int coursId = (int)cmbCoursEmarge.SelectedValue;
            DateTime date = dtpDateEmerge.Value;
            string statut = ckbPresent.Checked ? "Présent" : "Absent";

            // Vérifier les conflits d'horaire
            if (CheckConflitHoraire(professeurId, date))
            {
                MessageBox.Show("Conflit d'horaire : Le professeur est déjà occupé à cette heure.");
                return;
            }

            using (var db = new DbPresence())
            {
                // Vérifier que le professeur et le cours existent
                var professeur = db.Users.FirstOrDefault(u => u.Id == professeurId);
                var cours = db.Cours.FirstOrDefault(c => c.Id == coursId);

                if (professeur == null || cours == null)
                {
                    MessageBox.Show("Professeur ou cours introuvable.");
                    return;
                }

                Emargement emargement = new Emargement
                {
                    ProfesseurId = professeurId,
                    CoursId = coursId,
                    Date = date,
                    Statut = statut
                };

                db.Emargements.Add(emargement);
                db.SaveChanges();
                MessageBox.Show("Émargement enregistré avec succès !");
                LoadEmargements(); // Recharger les émargements dans le DataGridView
            }
        }

        private bool CheckConflitHoraire(int professeurId, DateTime date)
        {
            using (var db = new DbPresence())
            {
                // Vérifier si le professeur a déjà un émargement à la même heure
                var conflit = db.Emargements
                    .Any(e => e.ProfesseurId == professeurId && e.Date == date);

                return conflit;
            }
        }

        private void CkbPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPresent.Checked)
            {
                ckbAbsent.Checked = false;
            }
        }

        private void CkbAbsent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAbsent.Checked)
            {
                ckbPresent.Checked = false;
            }
        }

        private void btnRetourEmerge_Click(object sender, EventArgs e)
        {
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
            this.Hide();
        }

        private void btnAnnulerEmerge_Click(object sender, EventArgs e)
        {
            effacer();
        }
    }
}

