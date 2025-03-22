namespace GestionPresence
{
    partial class ChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnulerChange = new System.Windows.Forms.Button();
            this.btnEnregistrerChange = new System.Windows.Forms.Button();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Veuillez Changer Votre Mot de Passe";
            // 
            // btnAnnulerChange
            // 
            this.btnAnnulerChange.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerChange.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerChange.ForeColor = System.Drawing.Color.Red;
            this.btnAnnulerChange.Location = new System.Drawing.Point(235, 416);
            this.btnAnnulerChange.Name = "btnAnnulerChange";
            this.btnAnnulerChange.Size = new System.Drawing.Size(107, 32);
            this.btnAnnulerChange.TabIndex = 25;
            this.btnAnnulerChange.Text = "Annuler";
            this.btnAnnulerChange.UseVisualStyleBackColor = false;
            this.btnAnnulerChange.Click += new System.EventHandler(this.btnAnnulerChange_Click_1);
            // 
            // btnEnregistrerChange
            // 
            this.btnEnregistrerChange.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEnregistrerChange.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerChange.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEnregistrerChange.Location = new System.Drawing.Point(87, 416);
            this.btnEnregistrerChange.Name = "btnEnregistrerChange";
            this.btnEnregistrerChange.Size = new System.Drawing.Size(115, 32);
            this.btnEnregistrerChange.TabIndex = 23;
            this.btnEnregistrerChange.Text = "Enregistrer";
            this.btnEnregistrerChange.UseVisualStyleBackColor = false;
            this.btnEnregistrerChange.Click += new System.EventHandler(this.btnEnregistrerChange_Click);
            // 
            // txtNouveau
            // 
            this.txtNouveau.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNouveau.Location = new System.Drawing.Point(87, 170);
            this.txtNouveau.Multiline = true;
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(199, 30);
            this.txtNouveau.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nouveau Mot de Passe";
            // 
            // txtConfirmer
            // 
            this.txtConfirmer.BackColor = System.Drawing.Color.PeachPuff;
            this.txtConfirmer.Location = new System.Drawing.Point(87, 305);
            this.txtConfirmer.Multiline = true;
            this.txtConfirmer.Name = "txtConfirmer";
            this.txtConfirmer.Size = new System.Drawing.Size(199, 30);
            this.txtConfirmer.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirmer Mot de Passe";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(829, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnnulerChange);
            this.Controls.Add(this.btnEnregistrerChange);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmer);
            this.Controls.Add(this.label2);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnulerChange;
        private System.Windows.Forms.Button btnEnregistrerChange;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmer;
        private System.Windows.Forms.Label label2;
    }
}