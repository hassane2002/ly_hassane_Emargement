namespace GestionPresence
{
    partial class RapportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGraphiqueDoughnut = new System.Windows.Forms.Button();
            this.btnGraphiqueLigne = new System.Windows.Forms.Button();
            this.btnGraphiqueBarres = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGrapheLigne = new System.Windows.Forms.Button();
            this.btnGraphiqueBarre = new System.Windows.Forms.Button();
            this.btnGenererExcel = new System.Windows.Forms.Button();
            this.btnGenererPDF = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraphiqueDoughnut
            // 
            this.btnGraphiqueDoughnut.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphiqueDoughnut.Location = new System.Drawing.Point(707, 669);
            this.btnGraphiqueDoughnut.Name = "btnGraphiqueDoughnut";
            this.btnGraphiqueDoughnut.Size = new System.Drawing.Size(198, 31);
            this.btnGraphiqueDoughnut.TabIndex = 20;
            this.btnGraphiqueDoughnut.Text = "GraphiqueDoughnut";
            this.btnGraphiqueDoughnut.UseVisualStyleBackColor = true;
            // 
            // btnGraphiqueLigne
            // 
            this.btnGraphiqueLigne.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphiqueLigne.Location = new System.Drawing.Point(459, 669);
            this.btnGraphiqueLigne.Name = "btnGraphiqueLigne";
            this.btnGraphiqueLigne.Size = new System.Drawing.Size(161, 31);
            this.btnGraphiqueLigne.TabIndex = 19;
            this.btnGraphiqueLigne.Text = "GraphiqueLigne";
            this.btnGraphiqueLigne.UseVisualStyleBackColor = true;
            // 
            // btnGraphiqueBarres
            // 
            this.btnGraphiqueBarres.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphiqueBarres.Location = new System.Drawing.Point(207, 669);
            this.btnGraphiqueBarres.Name = "btnGraphiqueBarres";
            this.btnGraphiqueBarres.Size = new System.Drawing.Size(161, 31);
            this.btnGraphiqueBarres.TabIndex = 18;
            this.btnGraphiqueBarres.Text = "GraphiqueBarres";
            this.btnGraphiqueBarres.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(662, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "GraphiqueDoughnut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGrapheLigne
            // 
            this.btnGrapheLigne.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrapheLigne.Location = new System.Drawing.Point(414, 561);
            this.btnGrapheLigne.Name = "btnGrapheLigne";
            this.btnGrapheLigne.Size = new System.Drawing.Size(161, 31);
            this.btnGrapheLigne.TabIndex = 29;
            this.btnGrapheLigne.Text = "GraphiqueLigne";
            this.btnGrapheLigne.UseVisualStyleBackColor = true;
            // 
            // btnGraphiqueBarre
            // 
            this.btnGraphiqueBarre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphiqueBarre.Location = new System.Drawing.Point(162, 561);
            this.btnGraphiqueBarre.Name = "btnGraphiqueBarre";
            this.btnGraphiqueBarre.Size = new System.Drawing.Size(161, 31);
            this.btnGraphiqueBarre.TabIndex = 28;
            this.btnGraphiqueBarre.Text = "GraphiqueBarres";
            this.btnGraphiqueBarre.UseVisualStyleBackColor = true;
            // 
            // btnGenererExcel
            // 
            this.btnGenererExcel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenererExcel.Location = new System.Drawing.Point(463, 126);
            this.btnGenererExcel.Name = "btnGenererExcel";
            this.btnGenererExcel.Size = new System.Drawing.Size(161, 31);
            this.btnGenererExcel.TabIndex = 27;
            this.btnGenererExcel.Text = "Rapport en Excel";
            this.btnGenererExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenererPDF
            // 
            this.btnGenererPDF.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenererPDF.Location = new System.Drawing.Point(162, 126);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(161, 31);
            this.btnGenererPDF.TabIndex = 26;
            this.btnGenererPDF.Text = "Rapport en PDF";
            this.btnGenererPDF.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(424, 57);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 22);
            this.dtpDateFin.TabIndex = 25;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(162, 57);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDebut.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date Debut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, -56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Génération de rapports et statistiques ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(174, 201);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(686, 328);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // RapportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1016, 612);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrapheLigne);
            this.Controls.Add(this.btnGraphiqueBarre);
            this.Controls.Add(this.btnGenererExcel);
            this.Controls.Add(this.btnGenererPDF);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGraphiqueDoughnut);
            this.Controls.Add(this.btnGraphiqueLigne);
            this.Controls.Add(this.btnGraphiqueBarres);
            this.Name = "RapportForm";
            this.Text = "RapportForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraphiqueDoughnut;
        private System.Windows.Forms.Button btnGraphiqueLigne;
        private System.Windows.Forms.Button btnGraphiqueBarres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGrapheLigne;
        private System.Windows.Forms.Button btnGraphiqueBarre;
        private System.Windows.Forms.Button btnGenererExcel;
        private System.Windows.Forms.Button btnGenererPDF;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}