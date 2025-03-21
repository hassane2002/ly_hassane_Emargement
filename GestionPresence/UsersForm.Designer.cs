namespace GestionPresence
{
    partial class UsersForm
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
            this.btnRetourUser = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnModifierUser = new System.Windows.Forms.Button();
            this.btnSupprimerUser = new System.Windows.Forms.Button();
            this.btnAjouterUser = new System.Windows.Forms.Button();
            this.txtPrenomUser = new System.Windows.Forms.TextBox();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoleUser = new System.Windows.Forms.ComboBox();
            this.btnAnnulerUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourUser
            // 
            this.btnRetourUser.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourUser.ForeColor = System.Drawing.Color.Black;
            this.btnRetourUser.Location = new System.Drawing.Point(853, 571);
            this.btnRetourUser.Name = "btnRetourUser";
            this.btnRetourUser.Size = new System.Drawing.Size(107, 32);
            this.btnRetourUser.TabIndex = 37;
            this.btnRetourUser.Text = "Annuler";
            this.btnRetourUser.UseVisualStyleBackColor = false;
            this.btnRetourUser.Click += new System.EventHandler(this.btnRetourUser_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(430, 217);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(704, 307);
            this.dataGridViewUser.TabIndex = 36;
            this.dataGridViewUser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUser_MouseDoubleClick);
            // 
            // btnModifierUser
            // 
            this.btnModifierUser.BackColor = System.Drawing.Color.PeachPuff;
            this.btnModifierUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierUser.ForeColor = System.Drawing.Color.Yellow;
            this.btnModifierUser.Location = new System.Drawing.Point(182, 571);
            this.btnModifierUser.Name = "btnModifierUser";
            this.btnModifierUser.Size = new System.Drawing.Size(107, 32);
            this.btnModifierUser.TabIndex = 35;
            this.btnModifierUser.Text = "Modifier";
            this.btnModifierUser.UseVisualStyleBackColor = false;
            this.btnModifierUser.Click += new System.EventHandler(this.btnModifierUser_Click);
            // 
            // btnSupprimerUser
            // 
            this.btnSupprimerUser.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSupprimerUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerUser.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerUser.Location = new System.Drawing.Point(333, 571);
            this.btnSupprimerUser.Name = "btnSupprimerUser";
            this.btnSupprimerUser.Size = new System.Drawing.Size(107, 32);
            this.btnSupprimerUser.TabIndex = 34;
            this.btnSupprimerUser.Text = "Supprimer";
            this.btnSupprimerUser.UseVisualStyleBackColor = false;
            this.btnSupprimerUser.Click += new System.EventHandler(this.btnSupprimerUser_Click);
            // 
            // btnAjouterUser
            // 
            this.btnAjouterUser.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAjouterUser.Location = new System.Drawing.Point(34, 571);
            this.btnAjouterUser.Name = "btnAjouterUser";
            this.btnAjouterUser.Size = new System.Drawing.Size(107, 32);
            this.btnAjouterUser.TabIndex = 33;
            this.btnAjouterUser.Text = "Ajouter";
            this.btnAjouterUser.UseVisualStyleBackColor = false;
            this.btnAjouterUser.Click += new System.EventHandler(this.btnAjouterUser_Click);
            // 
            // txtPrenomUser
            // 
            this.txtPrenomUser.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPrenomUser.Location = new System.Drawing.Point(209, 217);
            this.txtPrenomUser.Multiline = true;
            this.txtPrenomUser.Name = "txtPrenomUser";
            this.txtPrenomUser.Size = new System.Drawing.Size(123, 30);
            this.txtPrenomUser.TabIndex = 32;
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.BackColor = System.Drawing.Color.PeachPuff;
            this.txtEmailUser.Location = new System.Drawing.Point(34, 314);
            this.txtEmailUser.Multiline = true;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(237, 30);
            this.txtEmailUser.TabIndex = 31;
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPasswordUser.Location = new System.Drawing.Point(34, 396);
            this.txtPasswordUser.Multiline = true;
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(159, 30);
            this.txtPasswordUser.TabIndex = 30;
            // 
            // txtNomUser
            // 
            this.txtNomUser.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNomUser.Location = new System.Drawing.Point(8, 217);
            this.txtNomUser.Multiline = true;
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(123, 30);
            this.txtNomUser.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mot de Passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nom";
            // 
            // cmbRoleUser
            // 
            this.cmbRoleUser.FormattingEnabled = true;
            this.cmbRoleUser.Items.AddRange(new object[] {
            "Administrateur",
            "Gestionnaire",
            "Professeur"});
            this.cmbRoleUser.Location = new System.Drawing.Point(34, 500);
            this.cmbRoleUser.Name = "cmbRoleUser";
            this.cmbRoleUser.Size = new System.Drawing.Size(159, 24);
            this.cmbRoleUser.TabIndex = 38;
            // 
            // btnAnnulerUser
            // 
            this.btnAnnulerUser.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnulerUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerUser.ForeColor = System.Drawing.Color.Blue;
            this.btnAnnulerUser.Location = new System.Drawing.Point(1027, 571);
            this.btnAnnulerUser.Name = "btnAnnulerUser";
            this.btnAnnulerUser.Size = new System.Drawing.Size(107, 32);
            this.btnAnnulerUser.TabIndex = 39;
            this.btnAnnulerUser.Text = "Retour";
            this.btnAnnulerUser.UseVisualStyleBackColor = false;
            this.btnAnnulerUser.Click += new System.EventHandler(this.btnAnnulerUser_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1147, 654);
            this.Controls.Add(this.btnAnnulerUser);
            this.Controls.Add(this.cmbRoleUser);
            this.Controls.Add(this.btnRetourUser);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btnModifierUser);
            this.Controls.Add(this.btnSupprimerUser);
            this.Controls.Add(this.btnAjouterUser);
            this.Controls.Add(this.txtPrenomUser);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.txtPasswordUser);
            this.Controls.Add(this.txtNomUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetourUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnModifierUser;
        private System.Windows.Forms.Button btnSupprimerUser;
        private System.Windows.Forms.Button btnAjouterUser;
        private System.Windows.Forms.TextBox txtPrenomUser;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoleUser;
        private System.Windows.Forms.Button btnAnnulerUser;
    }
}