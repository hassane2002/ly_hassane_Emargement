namespace GestionPresence
{
    partial class AssignationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.btnValiderAssignation = new System.Windows.Forms.Button();
            this.btnAnnulerAssignation = new System.Windows.Forms.Button();
            this.cmbProfesseurAssignation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourAssignation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAssignation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignation)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Heure";
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(25, 378);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(76, 22);
            this.dtpHeure.TabIndex = 32;
            // 
            // btnValiderAssignation
            // 
            this.btnValiderAssignation.BackColor = System.Drawing.Color.PeachPuff;
            this.btnValiderAssignation.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderAssignation.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnValiderAssignation.Location = new System.Drawing.Point(25, 432);
            this.btnValiderAssignation.Name = "btnValiderAssignation";
            this.btnValiderAssignation.Size = new System.Drawing.Size(95, 33);
            this.btnValiderAssignation.TabIndex = 31;
            this.btnValiderAssignation.Text = "Valider";
            this.btnValiderAssignation.UseVisualStyleBackColor = false;
            this.btnValiderAssignation.Click += new System.EventHandler(this.btnValiderAssignation_Click);
            // 
            // btnAnnulerAssignation
            // 
            this.btnAnnulerAssignation.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerAssignation.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAssignation.ForeColor = System.Drawing.Color.Crimson;
            this.btnAnnulerAssignation.Location = new System.Drawing.Point(197, 432);
            this.btnAnnulerAssignation.Name = "btnAnnulerAssignation";
            this.btnAnnulerAssignation.Size = new System.Drawing.Size(92, 33);
            this.btnAnnulerAssignation.TabIndex = 30;
            this.btnAnnulerAssignation.Text = "Annuler";
            this.btnAnnulerAssignation.UseVisualStyleBackColor = false;
            // 
            // cmbProfesseurAssignation
            // 
            this.cmbProfesseurAssignation.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbProfesseurAssignation.FormattingEnabled = true;
            this.cmbProfesseurAssignation.Location = new System.Drawing.Point(25, 287);
            this.cmbProfesseurAssignation.Name = "cmbProfesseurAssignation";
            this.cmbProfesseurAssignation.Size = new System.Drawing.Size(140, 24);
            this.cmbProfesseurAssignation.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Professeur";
            // 
            // cmbCourAssignation
            // 
            this.cmbCourAssignation.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbCourAssignation.FormattingEnabled = true;
            this.cmbCourAssignation.Location = new System.Drawing.Point(25, 190);
            this.cmbCourAssignation.Name = "cmbCourAssignation";
            this.cmbCourAssignation.Size = new System.Drawing.Size(140, 24);
            this.cmbCourAssignation.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cour";
            // 
            // dataGridViewAssignation
            // 
            this.dataGridViewAssignation.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewAssignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignation.Location = new System.Drawing.Point(235, 190);
            this.dataGridViewAssignation.Name = "dataGridViewAssignation";
            this.dataGridViewAssignation.RowHeadersWidth = 51;
            this.dataGridViewAssignation.RowTemplate.Height = 24;
            this.dataGridViewAssignation.Size = new System.Drawing.Size(483, 210);
            this.dataGridViewAssignation.TabIndex = 34;
            // 
            // AssignationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(730, 487);
            this.Controls.Add(this.dataGridViewAssignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHeure);
            this.Controls.Add(this.btnValiderAssignation);
            this.Controls.Add(this.btnAnnulerAssignation);
            this.Controls.Add(this.cmbProfesseurAssignation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourAssignation);
            this.Controls.Add(this.label1);
            this.Name = "AssignationForm";
            this.Text = "AssignationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.Button btnValiderAssignation;
        private System.Windows.Forms.Button btnAnnulerAssignation;
        private System.Windows.Forms.ComboBox cmbProfesseurAssignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourAssignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAssignation;
    }
}