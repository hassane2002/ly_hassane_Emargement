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
    public partial class SallesForme: Form
    {
        public SallesForme()
        {
            InitializeComponent();
        }

        private void LoadSalles()
        {
            using (var db = new DbPresence())
            {
                dataGridViewSalle.DataSource = db.Salles.ToList();
            }
        }
        private void btnAjouterSalle_Click(object sender, EventArgs e)
        {
            string libelle = txtLibelle.Text;
         

            if (string.IsNullOrEmpty(libelle))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            using (var db = new DbPresence())
            {

                Salle salle = new Salle
                {
                    Libelle = libelle
                };

                db.Salles.Add(salle);
                db.SaveChanges();
                MessageBox.Show("Salle ajouté avec succès !");
                LoadSalles(); // Recharger les utilisateurs dans le DataGridView
            }
        }
        

        private void SallesForme_Load(object sender, EventArgs e)
        {
            using (var db = new DbPresence())
            {
                dataGridViewSalle.DataSource = db.Salles.ToList();
            }
        }

        private void btnModifierSalle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une salle à modifier.");
                return;
            }

            int salleId = (int)dataGridViewSalle.SelectedRows[0].Cells["Id"].Value;
            string libelle = txtLibelle.Text;

            if (string.IsNullOrEmpty(libelle))
            {
                MessageBox.Show("Veuillez remplir le champ Libellé.");
                return;
            }

            using (var db = new DbPresence())
            {
                var salle = db.Salles.FirstOrDefault(s => s.Id == salleId);

                if (salle == null)
                {
                    MessageBox.Show("Salle introuvable.");
                    return;
                }

                salle.Libelle = libelle;
                db.SaveChanges();
                MessageBox.Show("Salle modifiée avec succès !");
                LoadSalles(); // Recharger les salles dans le DataGridView
            }
        }
        private void effacer()
        {
            txtLibelle.Text = String.Empty;
        }

        private void dataGridViewSalle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewSalle.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSalle.SelectedRows[0];
                txtLibelle.Text = selectedRow.Cells["Libelle"].Value.ToString();
            }
        }

        private void btnAnnulerSalle_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void btnRetourSalle_Click(object sender, EventArgs e)
        {
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
            this.Hide();
        }

        private void btnSupprimerSalle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une salle à supprimer.");
                return;
            }

            int salleId = (int)dataGridViewSalle.SelectedRows[0].Cells["Id"].Value;

            using (var db = new DbPresence())
            {
                var salle = db.Salles.FirstOrDefault(s => s.Id == salleId);

                if (salle == null)
                {
                    MessageBox.Show("Salle introuvable.");
                    return;
                }

                db.Salles.Remove(salle);
                db.SaveChanges();
                MessageBox.Show("Salle supprimée avec succès !");
                LoadSalles(); // Recharger les salles dans le DataGridView
            }
        }
    }
}
