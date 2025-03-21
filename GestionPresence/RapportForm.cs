using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using OfficeOpenXml;

namespace GestionPresence
{
    public partial class RapportForm: Form
    {
        private Chart chartRapport;
        public RapportForm()
        {
            InitializeComponent();
            chartRapport = new Chart
            {
                Location = new System.Drawing.Point(50, 50),
                Width = 400,
                Height = 300
            };

            // Configurer le Chart
            ConfigureChart();
            this.Controls.Add(chartRapport);
        }

        private void ConfigureChart()
        {
            if (chartRapport == null)
            {
                MessageBox.Show("Le contrôle Chart n'est pas initialisé.");
                return;
            }

            // Ajouter une zone de graphique
            chartRapport.ChartAreas.Add(new ChartArea());

            // Ajouter une série de données
            Series series = new Series
            {
                Name = "Série1",
                ChartType = SeriesChartType.Column // Type de graphique en barres
            };

            // Ajouter des données à la série
            series.Points.AddXY("Professeur 1", 10);
            series.Points.AddXY("Professeur 2", 20);
            series.Points.AddXY("Professeur 3", 30);
            series.Points.AddXY("Professeur 4", 40);

            // Ajouter la série au graphique
            chartRapport.Series.Add(series);

            // Configurer les axes
            chartRapport.ChartAreas[0].AxisX.Title = "Professeurs";
            chartRapport.ChartAreas[0].AxisY.Title = "Nombre de présences";
        }
        


        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebutRapport.Value;
            DateTime dateFin = dtpDateFinRapport.Value;

            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                    .Where(em => em.Date >= dateDebut && em.Date <= dateFin)
                    .Join(db.Users,
                        emargement => emargement.ProfesseurId,
                        professeur => professeur.Id,
                        (emargement, professeur) => new { emargement, professeur })
                    .Join(db.Cours,
                        temp => temp.emargement.CoursId,
                        cours => cours.Id,
                        (temp, cours) => new
                        {
                            Professeur = temp.professeur.Nom,
                            Cours = cours.Nom,
                            temp.emargement.Date,
                            temp.emargement.Statut
                        })
                    .ToList();

                if (emargements.Count == 0)
                {
                    MessageBox.Show("Aucun émargement trouvé pour la période sélectionnée.");
                    return;
                }

                // Générer le PDF
                GeneratePDF(emargements, dateDebut, dateFin);
            }
        }

        private void GeneratePDF(dynamic emargements, DateTime dateDebut, DateTime dateFin)
        {
           try
    {
        // Définir le chemin du fichier PDF
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Rapport_Emargements_{dateDebut:yyyyMMdd}_to_{dateFin:yyyyMMdd}.pdf");

        // Vérifier les données des émargements
        foreach (var emargement in emargements)
        {
            if (emargement.Professeur == null || emargement.Cours == null || emargement.Date == null || emargement.Statut == null)
            {
                MessageBox.Show("Données d'émargement invalides.");
                return;
            }
        }

        // Créer le document PDF
        PdfWriter writer = new PdfWriter(filePath);
        PdfDocument pdf = new PdfDocument(writer);
        Document document = new Document(pdf);

        // Ajouter un titre
        document.Add(new Paragraph($"Rapport des Émargements du {dateDebut:dd/MM/yyyy} au {dateFin:dd/MM/yyyy}"));

        // Ajouter un tableau
        Table table = new Table(UnitValue.CreatePercentArray(4)).UseAllAvailableWidth();
        table.AddHeaderCell("Professeur");
        table.AddHeaderCell("Cours");
        table.AddHeaderCell("Date");
        table.AddHeaderCell("Statut");

        foreach (var emargement in emargements)
        {
            table.AddCell(emargement.Professeur);
            table.AddCell(emargement.Cours);
            table.AddCell(emargement.Date.ToString("dd/MM/yyyy HH:mm"));
            table.AddCell(emargement.Statut);
        }

        document.Add(table);
        document.Close();

        MessageBox.Show($"Rapport PDF généré : {filePath}");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erreur lors de la génération du PDF : {ex.GetType().Name} - {ex.Message}");
    }
        }

        private void btnGenererExcel_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebutRapport.Value;
            DateTime dateFin = dtpDateFinRapport.Value;

            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                    .Where(em => em.Date >= dateDebut && em.Date <= dateFin)
                    .Join(db.Users,
                        emargement => emargement.ProfesseurId,
                        professeur => professeur.Id,
                        (emargement, professeur) => new { emargement, professeur })
                    .Join(db.Cours,
                        temp => temp.emargement.CoursId,
                        cours => cours.Id,
                        (temp, cours) => new
                        {
                            Professeur = temp.professeur.Nom,
                            Cours = cours.Nom,
                            temp.emargement.Date,
                            temp.emargement.Statut
                        })
                    .ToList();

                if (emargements.Count == 0)
                {
                    MessageBox.Show("Aucun émargement trouvé pour la période sélectionnée.");
                    return;
                }

                // Générer le fichier Excel
                GenerateExcel(emargements, dateDebut, dateFin);
            }
        }

        private void GenerateExcel(dynamic emargements, DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                // Définir le chemin du fichier Excel
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Rapport_Emargements_{dateDebut:yyyyMMdd}_to_{dateFin:yyyyMMdd}.xlsx");

                // Créer le fichier Excel
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Émargements");

                    // Ajouter les en-têtes
                    worksheet.Cells[1, 1].Value = "Professeur";
                    worksheet.Cells[1, 2].Value = "Cours";
                    worksheet.Cells[1, 3].Value = "Date";
                    worksheet.Cells[1, 4].Value = "Statut";

                    // Ajouter les données
                    int row = 2;
                    foreach (var emargement in emargements)
                    {
                        worksheet.Cells[row, 1].Value = emargement.Professeur;
                        worksheet.Cells[row, 2].Value = emargement.Cours;
                        worksheet.Cells[row, 3].Value = emargement.Date.ToString("dd/MM/yyyy HH:mm");
                        worksheet.Cells[row, 4].Value = emargement.Statut;
                        row++;
                    }

                    // Enregistrer le fichier
                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show($"Rapport Excel généré : {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération du fichier Excel : {ex.Message}");
            }
        }

        private void btnGraphiqueBarre_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebutRapport.Value;
            DateTime dateFin = dtpDateFinRapport.Value;

            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                    .Where(em => em.Date >= dateDebut && em.Date <= dateFin)
                    .GroupBy(em => em.ProfesseurId)
                    .Select(g => new
                    {
                        Professeur = db.Users.FirstOrDefault(u => u.Id == g.Key).Nom,
                        Présences = g.Count(em => em.Statut == "Présent")
                    })
                    .ToList();

                if (emargements.Count == 0)
                {
                    MessageBox.Show("Aucun émargement trouvé pour la période sélectionnée.");
                    return;
                }

                // Afficher le graphique en barres
                chartRapport.Series[0].Points.Clear();
                chartRapport.Series[0].ChartType = SeriesChartType.Column;

                foreach (var emargement in emargements)
                {
                    chartRapport.Series[0].Points.AddXY(emargement.Professeur, emargement.Présences);
                }
            }
        }

        private void btnGrapheLigne_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebutRapport.Value;
            DateTime dateFin = dtpDateFinRapport.Value;

            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                   .Where(em => em.Date >= dateDebut && em.Date <= dateFin)
                   .GroupBy(em => em.ProfesseurId)
                   .Select(g => new
                   {
                       Professeur = db.Users.FirstOrDefault(u => u.Id == g.Key).Nom,
                       Présences = g.Count(em => em.Statut == "Présent")
                   })
                   .ToList();

                if (emargements.Count == 0)
                {
                    MessageBox.Show("Aucun émargement trouvé pour la période sélectionnée.");
                    return;
                }

                // Afficher le graphique en ligne
                chartRapport.Series[0].Points.Clear();
                chartRapport.Series[0].ChartType = SeriesChartType.Line;

                foreach (var emargement in emargements)
                {
                    chartRapport.Series[0].Points.AddXY(emargement.Professeur, emargement.Présences);
                }
            }
        }

        private void btnGrapheDoughnut_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebutRapport.Value;
            DateTime dateFin = dtpDateFinRapport.Value;

            using (var db = new DbPresence())
            {
                var emargements = db.Emargements
                   .Where(em => em.Date >= dateDebut && em.Date <= dateFin)
                   .GroupBy(em => em.ProfesseurId)
                   .Select(g => new
                   {
                       Professeur = db.Users.FirstOrDefault(u => u.Id == g.Key).Nom,
                       Présences = g.Count(em => em.Statut == "Présent")
                   })
                   .ToList();

                if (emargements.Count == 0)
                {
                    MessageBox.Show("Aucun émargement trouvé pour la période sélectionnée.");
                    return;
                }

                // Afficher le graphique en doughnut
                chartRapport.Series[0].Points.Clear();
                chartRapport.Series[0].ChartType = SeriesChartType.Doughnut;

                foreach (var emargement in emargements)
                {
                    chartRapport.Series[0].Points.AddXY(emargement.Professeur, emargement.Présences);
                }
            }
        }
    }

}

