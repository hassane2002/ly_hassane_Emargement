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
    public partial class AccueilForm: Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
        }

        private void labUtilisateurs_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void labAccueil_Click(object sender, EventArgs e)
        {
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
            this.Hide();
        }

        private void labCours_Click(object sender, EventArgs e)
        {
            CoursForm coursForm = new  CoursForm();
            coursForm.Show();
            this.Hide();
        }

        private void labSalles_Click(object sender, EventArgs e)
        {
            SallesForme sallesForme = new SallesForme();
            sallesForme.Show();
            this.Hide();
        }

        private void labEmargements_Click(object sender, EventArgs e)
        {
            EmargementForm emargementForm = new EmargementForm();
            emargementForm.Show();
            this.Hide();
        }

        private void labRapports_Click(object sender, EventArgs e)
        {
            RapportForm rapportForm = new RapportForm();
            rapportForm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
