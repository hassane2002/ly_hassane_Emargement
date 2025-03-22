namespace GestionPresence
{
    partial class ListesProfesseurs
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
            this.btnRetourListesProf = new System.Windows.Forms.Button();
            this.dataGridProfesseurs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourListesProf
            // 
            this.btnRetourListesProf.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourListesProf.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourListesProf.ForeColor = System.Drawing.Color.Blue;
            this.btnRetourListesProf.Location = new System.Drawing.Point(714, 454);
            this.btnRetourListesProf.Name = "btnRetourListesProf";
            this.btnRetourListesProf.Size = new System.Drawing.Size(107, 32);
            this.btnRetourListesProf.TabIndex = 24;
            this.btnRetourListesProf.Text = "Retour";
            this.btnRetourListesProf.UseVisualStyleBackColor = false;
            // 
            // dataGridProfesseurs
            // 
            this.dataGridProfesseurs.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesseurs.Location = new System.Drawing.Point(58, 82);
            this.dataGridProfesseurs.Name = "dataGridProfesseurs";
            this.dataGridProfesseurs.RowHeadersWidth = 51;
            this.dataGridProfesseurs.RowTemplate.Height = 24;
            this.dataGridProfesseurs.Size = new System.Drawing.Size(763, 346);
            this.dataGridProfesseurs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Liste des Professeurs ";
            // 
            // ListesProfesseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.btnRetourListesProf);
            this.Controls.Add(this.dataGridProfesseurs);
            this.Controls.Add(this.label1);
            this.Name = "ListesProfesseurs";
            this.Text = "ListesProfesseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourListesProf;
        private System.Windows.Forms.DataGridView dataGridProfesseurs;
        private System.Windows.Forms.Label label1;
    }
}