namespace GestionPresence
{
    partial class SallesForme
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
            this.btnRetourSalle = new System.Windows.Forms.Button();
            this.dataGridViewSalle = new System.Windows.Forms.DataGridView();
            this.btnSupprimerSalle = new System.Windows.Forms.Button();
            this.btnModifierSalle = new System.Windows.Forms.Button();
            this.btnAjouterSalle = new System.Windows.Forms.Button();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerSalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourSalle
            // 
            this.btnRetourSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourSalle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourSalle.ForeColor = System.Drawing.Color.Blue;
            this.btnRetourSalle.Location = new System.Drawing.Point(685, 358);
            this.btnRetourSalle.Name = "btnRetourSalle";
            this.btnRetourSalle.Size = new System.Drawing.Size(112, 34);
            this.btnRetourSalle.TabIndex = 13;
            this.btnRetourSalle.Text = "Retour";
            this.btnRetourSalle.UseVisualStyleBackColor = false;
            this.btnRetourSalle.Click += new System.EventHandler(this.btnRetourSalle_Click);
            // 
            // dataGridViewSalle
            // 
            this.dataGridViewSalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalle.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalle.Location = new System.Drawing.Point(349, 12);
            this.dataGridViewSalle.Name = "dataGridViewSalle";
            this.dataGridViewSalle.RowHeadersWidth = 51;
            this.dataGridViewSalle.RowTemplate.Height = 24;
            this.dataGridViewSalle.Size = new System.Drawing.Size(448, 297);
            this.dataGridViewSalle.TabIndex = 12;
            this.dataGridViewSalle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSalle_MouseDoubleClick);
            // 
            // btnSupprimerSalle
            // 
            this.btnSupprimerSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSupprimerSalle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSalle.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerSalle.Location = new System.Drawing.Point(110, 275);
            this.btnSupprimerSalle.Name = "btnSupprimerSalle";
            this.btnSupprimerSalle.Size = new System.Drawing.Size(112, 34);
            this.btnSupprimerSalle.TabIndex = 11;
            this.btnSupprimerSalle.Text = "Supprimer";
            this.btnSupprimerSalle.UseVisualStyleBackColor = false;
            this.btnSupprimerSalle.Click += new System.EventHandler(this.btnSupprimerSalle_Click);
            // 
            // btnModifierSalle
            // 
            this.btnModifierSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnModifierSalle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSalle.ForeColor = System.Drawing.Color.Yellow;
            this.btnModifierSalle.Location = new System.Drawing.Point(191, 208);
            this.btnModifierSalle.Name = "btnModifierSalle";
            this.btnModifierSalle.Size = new System.Drawing.Size(112, 34);
            this.btnModifierSalle.TabIndex = 10;
            this.btnModifierSalle.Text = "Modifier";
            this.btnModifierSalle.UseVisualStyleBackColor = false;
            this.btnModifierSalle.Click += new System.EventHandler(this.btnModifierSalle_Click);
            // 
            // btnAjouterSalle
            // 
            this.btnAjouterSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterSalle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSalle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAjouterSalle.Location = new System.Drawing.Point(39, 208);
            this.btnAjouterSalle.Name = "btnAjouterSalle";
            this.btnAjouterSalle.Size = new System.Drawing.Size(112, 34);
            this.btnAjouterSalle.TabIndex = 9;
            this.btnAjouterSalle.Text = "Ajouter";
            this.btnAjouterSalle.UseVisualStyleBackColor = false;
            this.btnAjouterSalle.Click += new System.EventHandler(this.btnAjouterSalle_Click);
            // 
            // txtLibelle
            // 
            this.txtLibelle.BackColor = System.Drawing.Color.PeachPuff;
            this.txtLibelle.Location = new System.Drawing.Point(60, 92);
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(129, 34);
            this.txtLibelle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Libelle";
            // 
            // btnAnnulerSalle
            // 
            this.btnAnnulerSalle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerSalle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerSalle.ForeColor = System.Drawing.Color.Black;
            this.btnAnnulerSalle.Location = new System.Drawing.Point(467, 358);
            this.btnAnnulerSalle.Name = "btnAnnulerSalle";
            this.btnAnnulerSalle.Size = new System.Drawing.Size(112, 34);
            this.btnAnnulerSalle.TabIndex = 14;
            this.btnAnnulerSalle.Text = "Annuler";
            this.btnAnnulerSalle.UseVisualStyleBackColor = false;
            this.btnAnnulerSalle.Click += new System.EventHandler(this.btnAnnulerSalle_Click);
            // 
            // SallesForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.btnAnnulerSalle);
            this.Controls.Add(this.btnRetourSalle);
            this.Controls.Add(this.dataGridViewSalle);
            this.Controls.Add(this.btnSupprimerSalle);
            this.Controls.Add(this.btnModifierSalle);
            this.Controls.Add(this.btnAjouterSalle);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Name = "SallesForme";
            this.Text = "SallesForme";
            this.Load += new System.EventHandler(this.SallesForme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourSalle;
        private System.Windows.Forms.DataGridView dataGridViewSalle;
        private System.Windows.Forms.Button btnSupprimerSalle;
        private System.Windows.Forms.Button btnModifierSalle;
        private System.Windows.Forms.Button btnAjouterSalle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerSalle;
    }
}