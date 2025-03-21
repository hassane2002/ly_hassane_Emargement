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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkInscrire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscriptionsForm inscriptionForm = new InscriptionsForm();
            inscriptionForm.Show();
            this.Hide();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text;
            string password = txtPasswordLogin.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
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
                var user = db.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("Email incorrect.");
                    return;
                }

                if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    MessageBox.Show("Mot de passe incorrect.");
                    return;
                }

                MessageBox.Show("Connexion réussie !");
                AccueilForm accueilForm = new AccueilForm();
                accueilForm.Show();
                this.Hide();// Redirection vers la page d'accueil
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
