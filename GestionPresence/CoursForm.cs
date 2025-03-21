using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionPresence
{
    public partial class CoursForm: Form
    {
        public CoursForm()
        {
            InitializeComponent();
            LoadSalles();
            LoadCours();
        }

        private void LoadSalles()
        {
            using (var db = new DbPresence())
            {
                // Charger les salles dans le ComboBox
                cmbSalle.DataSource = db.Salles.ToList(); // Récupérer toutes les salles
                cmbSalle.DisplayMember = "Libelle"; // Afficher le libellé de la salle
                cmbSalle.ValueMember = "Id"; // Stocker l'ID de la salle
                cmbSalle.Refresh();
            }
        }

        private void LoadCours()
        {
            using (var db = new DbPresence())
            {
                // Charger les cours avec le nom de la salle
                var cour = db.Cours
                    .Join(db.Salles, // Jointure avec la table Salles
                        cours => cours.SalleId, // Clé étrangère dans Cours
                        salle => salle.Id, // Clé primaire dans Salles
                        (cours, salle) => new // Créer un objet anonyme pour l'affichage
                        {
                            cours.Id,
                            cours.Nom,
                            cours.Description,
                            cours.HeureDebut,
                            cours.HeureFin,
                            Salle = salle.Libelle // Afficher le libellé de la salle
                        })
                    .ToList();

                dataGridViewCours.DataSource = cour; // Lier les données au DataGridView

            }
        }
        private void Actualiser()
        {
            dataGridViewCours.DataSource = null;
            using (var db = new DbPresence())
            {
                dataGridViewCours.DataSource = db.Cours.Select(c => new CoursView { Id = c.Id, Nom = c.Nom, Description = c.Description, HeureDebut = c.HeureDebut, HeureFin = c.HeureFin, Salle = c.Salle}).ToList();

            }
        }

        private void effacer()
        {
            txtNomCour.Text = String.Empty;
            txtDescription.Text = String.Empty;
            cmbSalle.Text = "Selectionner";
        }
        private void btnAjouterCour_Click(object sender, EventArgs e)
        {
            string nom = txtNomCour.Text;
            string description = txtDescription.Text;
            int salleId = (int)cmbSalle.SelectedValue;
            DateTime heureDebut = dtpHeureDebut.Value;
            DateTime heureFin = dtpHeureFin.Value;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (heureDebut >= heureFin)
            {
                MessageBox.Show("L'heure de début doit être antérieure à l'heure de fin.");
                return;
            }

            using (var db = new DbPresence())
            {
                Cours cours = new Cours
                {
                    Nom = nom,
                    Description = description,
                    HeureDebut = heureDebut.TimeOfDay,
                    HeureFin = heureFin.TimeOfDay,
                    SalleId = salleId
                };

                db.Cours.Add(cours);
                db.SaveChanges();
                Actualiser();
                MessageBox.Show("Cours ajouté avec succès !");
                LoadCours(); // Recharger les cours dans le DataGridView

                // Rediriger vers le formulaire d'attribution
                this.Hide();
                 new AssignationForm(cours.Id).Show();
            }
        }

        private void dataGridViewCours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnModifierCour_Click(object sender, EventArgs e)
        {
            if (dataGridViewCours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours à modifier.");
                return;
            }

            int coursId = (int)dataGridViewCours.SelectedRows[0].Cells["Id"].Value;
            string nom = txtNomCour.Text;
            string description = txtDescription.Text;
            int salleId = (int)cmbSalle.SelectedValue;
            DateTime heureDebut = dtpHeureDebut.Value;
            DateTime heureFin = dtpHeureFin.Value;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (heureDebut >= heureFin)
            {
                MessageBox.Show("L'heure de début doit être antérieure à l'heure de fin.");
                return;
            }

            using (var db = new DbPresence())
            {
                var cours = db.Cours.FirstOrDefault(c => c.Id == coursId);

                if (cours == null)
                {
                    MessageBox.Show("Cours introuvable.");
                    return;
                }

                cours.Nom = nom;
                cours.Description = description;
                cours.HeureDebut = heureDebut.TimeOfDay;
                cours.HeureFin = heureFin.TimeOfDay;
                cours.SalleId = salleId;

                db.SaveChanges();
                MessageBox.Show("Cours modifié avec succès !");
                LoadCours(); // Recharger les cours dans le DataGridView
            }
        }

        private void dataGridViewCours_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewCours.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCours.SelectedRows[0];
                txtNomCour.Text = selectedRow.Cells["Nom"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                dtpHeureDebut.Value = DateTime.Today.Add((TimeSpan)selectedRow.Cells["HeureDebut"].Value);
                dtpHeureFin.Value = DateTime.Today.Add((TimeSpan)selectedRow.Cells["HeureFin"].Value);

                // Récupérer le nom de la salle sélectionnée
                string salleLibelle = selectedRow.Cells["Salle"].Value.ToString();

                // Trouver l'ID correspondant dans le ComboBox
                cmbSalle.SelectedIndex = cmbSalle.FindStringExact(salleLibelle);
            }    
        }

        private void btnSupprimeCour_Click(object sender, EventArgs e)
        {
            if (dataGridViewCours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours à supprimer.");
                return;
            }

            int coursId = (int)dataGridViewCours.SelectedRows[0].Cells["Id"].Value;

            using (var db = new DbPresence())
            {
                var cours = db.Cours.FirstOrDefault(c => c.Id == coursId);

                if (cours == null)
                {
                    MessageBox.Show("Cours introuvable.");
                    return;
                }

                db.Cours.Remove(cours);
                db.SaveChanges();
                MessageBox.Show("Cours supprimé avec succès !");
                LoadCours(); // Recharger les cours dans le DataGridView
            }
        }

        private void btnAnnulerCour_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void btnRetourCour_Click(object sender, EventArgs e)
        {
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
            this.Hide();
        }
    }
}
