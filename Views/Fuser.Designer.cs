namespace Views
{
    partial class FUser
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouterUser = new System.Windows.Forms.Button();
            this.btnSuppimerUser = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnVoirCours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(125, 97);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(529, 260);
            this.lbUsers.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(219, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(355, 55);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Liste des Users";
            // 
            // btnAjouterUser
            // 
            this.btnAjouterUser.Location = new System.Drawing.Point(125, 440);
            this.btnAjouterUser.Name = "btnAjouterUser";
            this.btnAjouterUser.Size = new System.Drawing.Size(128, 40);
            this.btnAjouterUser.TabIndex = 2;
            this.btnAjouterUser.Text = "Ajouter";
            this.btnAjouterUser.UseVisualStyleBackColor = true;
            // 
            // btnSuppimerUser
            // 
            this.btnSuppimerUser.Location = new System.Drawing.Point(324, 440);
            this.btnSuppimerUser.Name = "btnSuppimerUser";
            this.btnSuppimerUser.Size = new System.Drawing.Size(128, 40);
            this.btnSuppimerUser.TabIndex = 3;
            this.btnSuppimerUser.Text = "Supprimer";
            this.btnSuppimerUser.UseVisualStyleBackColor = true;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(526, 440);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(128, 40);
            this.btnRafraichir.TabIndex = 4;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            // 
            // btnVoirCours
            // 
            this.btnVoirCours.Location = new System.Drawing.Point(292, 377);
            this.btnVoirCours.Name = "btnVoirCours";
            this.btnVoirCours.Size = new System.Drawing.Size(184, 43);
            this.btnVoirCours.TabIndex = 5;
            this.btnVoirCours.Text = "Voir Les cours de l\'user";
            this.btnVoirCours.UseVisualStyleBackColor = true;
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnVoirCours);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.btnSuppimerUser);
            this.Controls.Add(this.btnAjouterUser);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lbUsers);
            this.Name = "FUser";
            this.Text = "Fuser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjouterUser;
        private System.Windows.Forms.Button btnSuppimerUser;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Button btnVoirCours;
    }
}