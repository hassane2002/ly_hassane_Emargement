namespace GestionPresence
{
    partial class EmargementForm
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
            this.btnRetourEmerge = new System.Windows.Forms.Button();
            this.cmbProfesseur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCours = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbAbsent = new System.Windows.Forms.CheckBox();
            this.ckbPresent = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateEmerge = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerEmerge = new System.Windows.Forms.Button();
            this.btnValiderEmerge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourEmerge
            // 
            this.btnRetourEmerge.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourEmerge.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourEmerge.ForeColor = System.Drawing.Color.Blue;
            this.btnRetourEmerge.Location = new System.Drawing.Point(1052, 606);
            this.btnRetourEmerge.Name = "btnRetourEmerge";
            this.btnRetourEmerge.Size = new System.Drawing.Size(92, 33);
            this.btnRetourEmerge.TabIndex = 28;
            this.btnRetourEmerge.Text = "Retour";
            this.btnRetourEmerge.UseVisualStyleBackColor = false;
            // 
            // cmbProfesseur
            // 
            this.cmbProfesseur.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbProfesseur.FormattingEnabled = true;
            this.cmbProfesseur.Location = new System.Drawing.Point(26, 185);
            this.cmbProfesseur.Name = "cmbProfesseur";
            this.cmbProfesseur.Size = new System.Drawing.Size(157, 24);
            this.cmbProfesseur.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Professeurs";
            // 
            // cmbCours
            // 
            this.cmbCours.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbCours.FormattingEnabled = true;
            this.cmbCours.Location = new System.Drawing.Point(26, 289);
            this.cmbCours.Name = "cmbCours";
            this.cmbCours.Size = new System.Drawing.Size(157, 24);
            this.cmbCours.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cour";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 447);
            this.dataGridView1.TabIndex = 23;
            // 
            // ckbAbsent
            // 
            this.ckbAbsent.AutoSize = true;
            this.ckbAbsent.BackColor = System.Drawing.Color.PeachPuff;
            this.ckbAbsent.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAbsent.Location = new System.Drawing.Point(160, 503);
            this.ckbAbsent.Name = "ckbAbsent";
            this.ckbAbsent.Size = new System.Drawing.Size(89, 27);
            this.ckbAbsent.TabIndex = 22;
            this.ckbAbsent.Text = "Absent";
            this.ckbAbsent.UseVisualStyleBackColor = false;
            // 
            // ckbPresent
            // 
            this.ckbPresent.AutoSize = true;
            this.ckbPresent.BackColor = System.Drawing.Color.PeachPuff;
            this.ckbPresent.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPresent.Location = new System.Drawing.Point(26, 503);
            this.ckbPresent.Name = "ckbPresent";
            this.ckbPresent.Size = new System.Drawing.Size(95, 27);
            this.ckbPresent.TabIndex = 21;
            this.ckbPresent.Text = "Present";
            this.ckbPresent.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Statu";
            // 
            // dtpDateEmerge
            // 
            this.dtpDateEmerge.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtpDateEmerge.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtpDateEmerge.CalendarTrailingForeColor = System.Drawing.Color.PeachPuff;
            this.dtpDateEmerge.Location = new System.Drawing.Point(26, 388);
            this.dtpDateEmerge.Name = "dtpDateEmerge";
            this.dtpDateEmerge.Size = new System.Drawing.Size(204, 22);
            this.dtpDateEmerge.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date";
            // 
            // btnAnnulerEmerge
            // 
            this.btnAnnulerEmerge.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerEmerge.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerEmerge.ForeColor = System.Drawing.Color.Crimson;
            this.btnAnnulerEmerge.Location = new System.Drawing.Point(827, 606);
            this.btnAnnulerEmerge.Name = "btnAnnulerEmerge";
            this.btnAnnulerEmerge.Size = new System.Drawing.Size(92, 33);
            this.btnAnnulerEmerge.TabIndex = 17;
            this.btnAnnulerEmerge.Text = "Annuler";
            this.btnAnnulerEmerge.UseVisualStyleBackColor = false;
            // 
            // btnValiderEmerge
            // 
            this.btnValiderEmerge.BackColor = System.Drawing.Color.PeachPuff;
            this.btnValiderEmerge.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderEmerge.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnValiderEmerge.Location = new System.Drawing.Point(587, 606);
            this.btnValiderEmerge.Name = "btnValiderEmerge";
            this.btnValiderEmerge.Size = new System.Drawing.Size(95, 33);
            this.btnValiderEmerge.TabIndex = 16;
            this.btnValiderEmerge.Text = "Valider";
            this.btnValiderEmerge.UseVisualStyleBackColor = false;
            // 
            // EmargementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1277, 653);
            this.Controls.Add(this.btnRetourEmerge);
            this.Controls.Add(this.cmbProfesseur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ckbAbsent);
            this.Controls.Add(this.ckbPresent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateEmerge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnulerEmerge);
            this.Controls.Add(this.btnValiderEmerge);
            this.Name = "EmargementForm";
            this.Text = "EmargementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourEmerge;
        private System.Windows.Forms.ComboBox cmbProfesseur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbAbsent;
        private System.Windows.Forms.CheckBox ckbPresent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateEmerge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerEmerge;
        private System.Windows.Forms.Button btnValiderEmerge;
    }
}