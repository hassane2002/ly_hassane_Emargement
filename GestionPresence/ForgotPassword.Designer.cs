namespace GestionPresence
{
    partial class ForgotPassword
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
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailForgot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnulerPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.btnResetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnResetPassword.Location = new System.Drawing.Point(86, 359);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(126, 31);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Réinitialiser";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txtEmailForgot
            // 
            this.txtEmailForgot.Location = new System.Drawing.Point(86, 217);
            this.txtEmailForgot.Multiline = true;
            this.txtEmailForgot.Name = "txtEmailForgot";
            this.txtEmailForgot.Size = new System.Drawing.Size(201, 36);
            this.txtEmailForgot.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Réinitialisation de Mot de Pass";
            // 
            // btnAnnulerPassword
            // 
            this.btnAnnulerPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerPassword.ForeColor = System.Drawing.Color.Crimson;
            this.btnAnnulerPassword.Location = new System.Drawing.Point(275, 359);
            this.btnAnnulerPassword.Name = "btnAnnulerPassword";
            this.btnAnnulerPassword.Size = new System.Drawing.Size(126, 31);
            this.btnAnnulerPassword.TabIndex = 4;
            this.btnAnnulerPassword.Text = "Annuler";
            this.btnAnnulerPassword.UseVisualStyleBackColor = false;
            this.btnAnnulerPassword.Click += new System.EventHandler(this.btnAnnulerPassword_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.btnAnnulerPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailForgot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetPassword);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailForgot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnulerPassword;
    }
}