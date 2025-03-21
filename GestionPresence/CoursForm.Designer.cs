namespace GestionPresence
{
    partial class CoursForm
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
            this.btnRetourCour = new System.Windows.Forms.Button();
            this.dtpHeureFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHeureDebut = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCours = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNomCour = new System.Windows.Forms.TextBox();
            this.cmbSalle = new System.Windows.Forms.ComboBox();
            this.btnSupprimeCour = new System.Windows.Forms.Button();
            this.btnModifierCour = new System.Windows.Forms.Button();
            this.btnAjouterCour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerCour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourCour
            // 
            this.btnRetourCour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourCour.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourCour.ForeColor = System.Drawing.Color.Blue;
            this.btnRetourCour.Location = new System.Drawing.Point(1087, 519);
            this.btnRetourCour.Name = "btnRetourCour";
            this.btnRetourCour.Size = new System.Drawing.Size(105, 36);
            this.btnRetourCour.TabIndex = 33;
            this.btnRetourCour.Text = "Retour";
            this.btnRetourCour.UseVisualStyleBackColor = false;
            this.btnRetourCour.Click += new System.EventHandler(this.btnRetourCour_Click);
            // 
            // dtpHeureFin
            // 
            this.dtpHeureFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeureFin.Location = new System.Drawing.Point(31, 507);
            this.dtpHeureFin.Name = "dtpHeureFin";
            this.dtpHeureFin.ShowUpDown = true;
            this.dtpHeureFin.Size = new System.Drawing.Size(76, 22);
            this.dtpHeureFin.TabIndex = 32;
            // 
            // dtpHeureDebut
            // 
            this.dtpHeureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeureDebut.Location = new System.Drawing.Point(31, 408);
            this.dtpHeureDebut.Name = "dtpHeureDebut";
            this.dtpHeureDebut.ShowUpDown = true;
            this.dtpHeureDebut.Size = new System.Drawing.Size(76, 22);
            this.dtpHeureDebut.TabIndex = 31;
            // 
            // dataGridViewCours
            // 
            this.dataGridViewCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCours.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCours.Location = new System.Drawing.Point(452, 131);
            this.dataGridViewCours.Name = "dataGridViewCours";
            this.dataGridViewCours.RowHeadersWidth = 51;
            this.dataGridViewCours.RowTemplate.Height = 24;
            this.dataGridViewCours.Size = new System.Drawing.Size(740, 353);
            this.dataGridViewCours.TabIndex = 30;
            this.dataGridViewCours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCours_CellContentClick);
            this.dataGridViewCours.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCours_MouseDoubleClick);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.PeachPuff;
            this.txtDescription.Location = new System.Drawing.Point(31, 269);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 79);
            this.txtDescription.TabIndex = 29;
            // 
            // txtNomCour
            // 
            this.txtNomCour.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNomCour.Location = new System.Drawing.Point(31, 169);
            this.txtNomCour.Multiline = true;
            this.txtNomCour.Name = "txtNomCour";
            this.txtNomCour.Size = new System.Drawing.Size(140, 30);
            this.txtNomCour.TabIndex = 28;
            // 
            // cmbSalle
            // 
            this.cmbSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbSalle.FormattingEnabled = true;
            this.cmbSalle.Location = new System.Drawing.Point(255, 169);
            this.cmbSalle.Name = "cmbSalle";
            this.cmbSalle.Size = new System.Drawing.Size(140, 24);
            this.cmbSalle.TabIndex = 27;
            // 
            // btnSupprimeCour
            // 
            this.btnSupprimeCour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSupprimeCour.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimeCour.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimeCour.Location = new System.Drawing.Point(788, 519);
            this.btnSupprimeCour.Name = "btnSupprimeCour";
            this.btnSupprimeCour.Size = new System.Drawing.Size(105, 36);
            this.btnSupprimeCour.TabIndex = 26;
            this.btnSupprimeCour.Text = "Supprimer";
            this.btnSupprimeCour.UseVisualStyleBackColor = false;
            this.btnSupprimeCour.Click += new System.EventHandler(this.btnSupprimeCour_Click);
            // 
            // btnModifierCour
            // 
            this.btnModifierCour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnModifierCour.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierCour.ForeColor = System.Drawing.Color.Yellow;
            this.btnModifierCour.Location = new System.Drawing.Point(615, 519);
            this.btnModifierCour.Name = "btnModifierCour";
            this.btnModifierCour.Size = new System.Drawing.Size(105, 36);
            this.btnModifierCour.TabIndex = 25;
            this.btnModifierCour.Text = "Modifier";
            this.btnModifierCour.UseVisualStyleBackColor = false;
            this.btnModifierCour.Click += new System.EventHandler(this.btnModifierCour_Click);
            // 
            // btnAjouterCour
            // 
            this.btnAjouterCour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterCour.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCour.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAjouterCour.Location = new System.Drawing.Point(452, 519);
            this.btnAjouterCour.Name = "btnAjouterCour";
            this.btnAjouterCour.Size = new System.Drawing.Size(105, 36);
            this.btnAjouterCour.TabIndex = 24;
            this.btnAjouterCour.Text = "Ajouter";
            this.btnAjouterCour.UseVisualStyleBackColor = false;
            this.btnAjouterCour.Click += new System.EventHandler(this.btnAjouterCour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Salle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Heure_Debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Heure_Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom";
            // 
            // btnAnnulerCour
            // 
            this.btnAnnulerCour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerCour.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerCour.ForeColor = System.Drawing.Color.Black;
            this.btnAnnulerCour.Location = new System.Drawing.Point(941, 519);
            this.btnAnnulerCour.Name = "btnAnnulerCour";
            this.btnAnnulerCour.Size = new System.Drawing.Size(105, 36);
            this.btnAnnulerCour.TabIndex = 34;
            this.btnAnnulerCour.Text = "Annuler";
            this.btnAnnulerCour.UseVisualStyleBackColor = false;
            this.btnAnnulerCour.Click += new System.EventHandler(this.btnAnnulerCour_Click);
            // 
            // CoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1204, 620);
            this.Controls.Add(this.btnAnnulerCour);
            this.Controls.Add(this.btnRetourCour);
            this.Controls.Add(this.dtpHeureFin);
            this.Controls.Add(this.dtpHeureDebut);
            this.Controls.Add(this.dataGridViewCours);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNomCour);
            this.Controls.Add(this.cmbSalle);
            this.Controls.Add(this.btnSupprimeCour);
            this.Controls.Add(this.btnModifierCour);
            this.Controls.Add(this.btnAjouterCour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoursForm";
            this.Text = "CoursForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourCour;
        private System.Windows.Forms.DateTimePicker dtpHeureFin;
        private System.Windows.Forms.DateTimePicker dtpHeureDebut;
        private System.Windows.Forms.DataGridView dataGridViewCours;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNomCour;
        private System.Windows.Forms.ComboBox cmbSalle;
        private System.Windows.Forms.Button btnSupprimeCour;
        private System.Windows.Forms.Button btnModifierCour;
        private System.Windows.Forms.Button btnAjouterCour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerCour;
    }
}