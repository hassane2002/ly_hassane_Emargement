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
    public partial class ForgotPassword: Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnAnnulerPassword_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmailForgot.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Veuillez entrer votre email.");
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
                    MessageBox.Show("Email introuvable.");
                    return;
                }

                // Rediriger vers le formulaire de changement de mot de passe
                ChangePassword changePassword = new ChangePassword();
                changePassword.Show();
                this.Hide();
            }
        }
    }
}

