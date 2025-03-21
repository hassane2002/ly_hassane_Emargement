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
            this.btnGrapheDoughnut = new System.Windows.Forms.Button();
            this.btnGrapheLigne = new System.Windows.Forms.Button();
            this.btnGraphiqueBarre = new System.Windows.Forms.Button();
            this.btnGenererExcel = new System.Windows.Forms.Button();
            this.btnGenererPDF = new System.Windows.Forms.Button();
            this.dtpDateFinRapport = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebutRapport = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrapheDoughnut
            // 
            this.btnGrapheDoughnut.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrapheDoughnut.Location = new System.Drawing.Point(682, 676);
            this.btnGrapheDoughnut.Name = "btnGrapheDoughnut";
            this.btnGrapheDoughnut.Size = new System.Drawing.Size(198, 31);
            this.btnGrapheDoughnut.TabIndex = 30;
            this.btnGrapheDoughnut.Text = "GraphiqueDoughnut";
            this.btnGrapheDoughnut.UseVisualStyleBackColor = true;
            this.btnGrapheDoughnut.Click += new System.EventHandler(this.btnGrapheDoughnut_Click);
            // 
            // btnGrapheLigne
            // 
            this.btnGrapheLigne.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrapheLigne.Location = new System.Drawing.Point(424, 676);
            this.btnGrapheLigne.Name = "btnGrapheLigne";
            this.btnGrapheLigne.Size = new System.Drawing.Size(161, 31);
            this.btnGrapheLigne.TabIndex = 29;
            this.btnGrapheLigne.Text = "GraphiqueLigne";
            this.btnGrapheLigne.UseVisualStyleBackColor = true;
            this.btnGrapheLigne.Click += new System.EventHandler(this.btnGrapheLigne_Click);
            // 
            // btnGraphiqueBarre
            // 
            this.btnGraphiqueBarre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphiqueBarre.Location = new System.Drawing.Point(150, 676);
            this.btnGraphiqueBarre.Name = "btnGraphiqueBarre";
            this.btnGraphiqueBarre.Size = new System.Drawing.Size(161, 31);
            this.btnGraphiqueBarre.TabIndex = 28;
            this.btnGraphiqueBarre.Text = "GraphiqueBarres";
            this.btnGraphiqueBarre.UseVisualStyleBackColor = true;
            this.btnGraphiqueBarre.Click += new System.EventHandler(this.btnGraphiqueBarre_Click);
            // 
            // btnGenererExcel
            // 
            this.btnGenererExcel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenererExcel.Location = new System.Drawing.Point(463, 126);
            this.btnGenererExcel.Name = "btnGenererExcel";
            this.btnGenererExcel.Size = new System.Drawing.Size(230, 31);
            this.btnGenererExcel.TabIndex = 27;
            this.btnGenererExcel.Text = "Rapport en Excel";
            this.btnGenererExcel.UseVisualStyleBackColor = true;
            this.btnGenererExcel.Click += new System.EventHandler(this.btnGenererExcel_Click);
            // 
            // btnGenererPDF
            // 
            this.btnGenererPDF.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenererPDF.Location = new System.Drawing.Point(162, 126);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(200, 31);
            this.btnGenererPDF.TabIndex = 26;
            this.btnGenererPDF.Text = "Rapport en PDF";
            this.btnGenererPDF.UseVisualStyleBackColor = true;
            this.btnGenererPDF.Click += new System.EventHandler(this.btnGenererPDF_Click);
            // 
            // dtpDateFinRapport
            // 
            this.dtpDateFinRapport.Location = new System.Drawing.Point(424, 57);
            this.dtpDateFinRapport.Name = "dtpDateFinRapport";
            this.dtpDateFinRapport.Size = new System.Drawing.Size(200, 22);
            this.dtpDateFinRapport.TabIndex = 25;
            // 
            // dtpDateDebutRapport
            // 
            this.dtpDateDebutRapport.Location = new System.Drawing.Point(162, 57);
            this.dtpDateDebutRapport.Name = "dtpDateDebutRapport";
            this.dtpDateDebutRapport.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDebutRapport.TabIndex = 24;
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
            // RapportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1016, 719);
            this.Controls.Add(this.btnGrapheDoughnut);
            this.Controls.Add(this.btnGrapheLigne);
            this.Controls.Add(this.btnGraphiqueBarre);
            this.Controls.Add(this.btnGenererExcel);
            this.Controls.Add(this.btnGenererPDF);
            this.Controls.Add(this.dtpDateFinRapport);
            this.Controls.Add(this.dtpDateDebutRapport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RapportForm";
            this.Text = "RapportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGrapheDoughnut;
        private System.Windows.Forms.Button btnGrapheLigne;
        private System.Windows.Forms.Button btnGraphiqueBarre;
        private System.Windows.Forms.Button btnGenererExcel;
        private System.Windows.Forms.Button btnGenererPDF;
        private System.Windows.Forms.DateTimePicker dtpDateFinRapport;
        private System.Windows.Forms.DateTimePicker dtpDateDebutRapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}