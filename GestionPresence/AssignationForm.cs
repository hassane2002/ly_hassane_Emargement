using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace GestionPresence
{
    public partial class AssignationForm: Form
    {
        private int _coursId;
        public AssignationForm(int coursId)
        {
            _coursId = coursId;
            InitializeComponent();

            // Charger les cours et les professeurs dans les ComboBox
            LoadCours();
            LoadProfesseurs();
            LoadAssignations();
        }

        private void LoadCours()
        {
            using (var db = new DbPresence())
            {
                cmbCourAssignation.DataSource = db.Cours.ToList();
                cmbCourAssignation.DisplayMember = "Nom";
                cmbCourAssignation.ValueMember = "Id";
                cmbCourAssignation.SelectedValue = _coursId; // Sélectionner le cours ajouté
            }
        }

        private void LoadProfesseurs()
        {
            using (var db = new DbPresence())
            {
                cmbProfesseurAssignation.DataSource = db.Users.Where(u => u.Role == "Professeur").ToList();
                cmbProfesseurAssignation.DisplayMember = "Nom";
                cmbProfesseurAssignation.ValueMember = "Id";
            }
        }

        private void LoadAssignations()
        {
            using (var db = new DbPresence())
            {
                dataGridViewAssignation.DataSource = db.Assignation;
            }
        }

        private void btnValiderAssignation_Click(object sender, EventArgs e)
        {
            int coursId = (int)cmbCourAssignation.SelectedValue;
            int professeurId = (int)cmbProfesseurAssignation.SelectedValue;
            DateTime heure = dtpHeure.Value;

            using (var db = new DbPresence())
            {
                Assignation assignation = new Assignation
                {
                    CoursId = coursId,
                    ProfesseurId = professeurId,
                    Heure = heure
                };

                object value = db.Assignation;
                db.SaveChanges();
                MessageBox.Show("Attribution enregistrée avec succès !");

                // Envoyer un email au professeur
                var professeur = db.Users.FirstOrDefault(u => u.Id == professeurId);
                if (professeur != null)
                {
                    SendEmail(professeur.Email, "Nouveau cours attribué", $"Vous avez été attribué au cours {cmbCourAssignation.Text} à {heure:HH:mm}.");
                }

                LoadAssignations(); // Recharger les attributions dans le DataGridView
            }
        }



        private void SendEmail(string email, string subject, string body)
        {
            try
            {
                // Créer le message
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ISI Gestion des Présences", "votre-email@gmail.com")); // Remplacez par votre email
                message.To.Add(new MailboxAddress("", email)); // Email du destinataire
                message.Subject = subject; // Sujet de l'email
                message.Body = new TextPart("plain") { Text = body }; // Corps de l'email

                // Configurer le client SMTP
                using (var client = new SmtpClient())
                {
                    // Se connecter au serveur SMTP (exemple avec Gmail)
                    client.Connect("smtp.gmail.com", 587, false); // Serveur SMTP de Gmail

                    // Authentification (remplacez par votre email et mot de passe)
                    client.Authenticate("votre-email@gmail.com", "votre-mot-de-passe");

                    // Envoyer l'email
                    client.Send(message);

                    // Se déconnecter
                    client.Disconnect(true);
                }

                MessageBox.Show("Email envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'email : " + ex.Message);
            }
        }
    }
}
