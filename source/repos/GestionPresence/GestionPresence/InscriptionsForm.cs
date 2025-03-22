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
    public partial class InscriptionsForm: Form
    {
        public InscriptionsForm()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
             string nom = txtNomInscrip.Text;
             string prenom = txtPrenomInscrip.Text;
             string email = txtEmailInscrip.Text;
             string password = txtPasswordInscrip.Text;
             string role = cmbRoleInscrip.SelectedItem?.ToString();

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
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();  // Retour à la page de connexion
        }
        }
    }
}
