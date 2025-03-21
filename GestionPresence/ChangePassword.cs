using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionPresence
{
    public partial class ChangePassword: Form
    {
        private string _email;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnEnregistrerChange_Click(object sender, EventArgs e)
        {
            string nouveauPassword = txtNouveau.Text;
            string confirmPassword = txtConfirmer.Text;

            if (string.IsNullOrEmpty(nouveauPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (nouveauPassword != confirmPassword)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            using (var db = new DbPresence())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == _email);

                if (user == null)
                {
                    MessageBox.Show("Utilisateur introuvable.");
                    return;
                }

                // Hacher le nouveau mot de passe
                user.Password = BCrypt.Net.BCrypt.HashPassword(nouveauPassword);
                db.SaveChanges();

                // Envoyer un email de confirmation
                SendPasswordResetEmail(user.Email);

                MessageBox.Show("Mot de passe réinitialisé avec succès !");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();  // Retour à la page de connexion
            }
        }

        private void btnAnnulerChange_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SendPasswordResetEmail(string email)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ISI Gestion des Présences", "votre-email@gmail.com"));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = "Réinitialisation de mot de passe";
                message.Body = new TextPart("plain")
                {
                    Text = "Votre mot de passe a été réinitialisé avec succès."
                };

                using (var utilisateur = new SmtpUtilisateur())
                {
                    utilisateur.Connect("smtp.gmail.com", 587, false);
                    utilisateur.Authenticate("votre-email@gmail.com", "votre-mot-de-passe");
                    utilisateur.Send(message);
                    utilisateur.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'email : " + ex.Message);
            }
        }

        private void btnAnnulerChange_Click_1(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
