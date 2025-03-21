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
    public partial class UsersForm: Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (var db = new DbPresence())
            {
                dataGridViewUser.DataSource = db.Users.ToList();
            }
        }

        private void btnAjouterUser_Click(object sender, EventArgs e)
        {
            string nom = txtNomUser.Text;
            string prenom = txtPrenomUser.Text;
            string email = txtEmailUser.Text;
            string password = txtPasswordUser.Text;
            string role = cmbRoleUser.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("L'email doit contenir le caractère '@'.");
                return;
            }

            using (var db = new DbPresence())
            {
                if (db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Cet email est déjà utilisé.");
                    return;
                }

                Users user = new Users
                {
                    Nom = nom,
                    Prenom = prenom,
                    Email = email,
                    Password = BCrypt.Net.BCrypt.HashPassword(password),
                    Role = role
                };

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Utilisateur ajouté avec succès !");
                LoadUsers(); // Recharger les utilisateurs dans le DataGridView
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            using (var db = new DbPresence())
            {
                dataGridViewUser.DataSource = db.Users.ToList();
            }
        }

        private void dataGridViewUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUser.SelectedRows[0];
                txtNomUser.Text = selectedRow.Cells["Nom"].Value.ToString();
                txtPrenomUser.Text = selectedRow.Cells["Prenom"].Value.ToString();
                txtEmailUser.Text = selectedRow.Cells["Email"].Value.ToString();
                cmbRoleUser.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
            }
        }

        private void effacer()
        {
            txtNomUser.Text = String.Empty;
            txtPrenomUser.Text = String.Empty;
            txtEmailUser.Text = String.Empty;
            txtPasswordUser.Text = String.Empty;
            cmbRoleUser.Text = "Selectionner";
        }
        private void btnModifierUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
                return;
            }

            int userId = (int)dataGridViewUser.SelectedRows[0].Cells["Id"].Value;

            string nom = txtNomUser.Text;
            string prenom = txtPrenomUser.Text;
            string email = txtEmailUser.Text;
            string password = txtPasswordUser.Text;
            string role = cmbRoleUser.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("L'email doit contenir le caractère '@'.");
                return;
            }

            using (var db = new DbPresence())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == userId);

                if (user == null)
                {
                    MessageBox.Show("Utilisateur introuvable.");
                    return;
                }

                user.Nom = nom;
                user.Prenom = prenom;
                user.Email = email;
                user.Role = role;

                if (!string.IsNullOrEmpty(password))
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(password);
                }

                db.SaveChanges();
                MessageBox.Show("Utilisateur modifié avec succès !");
                LoadUsers(); // Recharger les utilisateurs dans le DataGridView
            }
        }

        private void btnSupprimerUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
                return;
            }

            int userId = (int)dataGridViewUser.SelectedRows[0].Cells["Id"].Value;

            using (var db = new DbPresence())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == userId);

                if (user == null)
                {
                    MessageBox.Show("Utilisateur introuvable.");
                    return;
                }

                db.Users.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Utilisateur supprimé avec succès !");
                LoadUsers(); // Recharger les utilisateurs dans le DataGridView
            }
        }

        private void btnRetourUser_Click(object sender, EventArgs e)
        {
            effacer();
          
        }

        private void btnAnnulerUser_Click(object sender, EventArgs e)
        {
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
            this.Hide();
        }
    }
}
