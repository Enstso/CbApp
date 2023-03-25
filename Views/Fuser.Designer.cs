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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUser));
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouterUser = new System.Windows.Forms.Button();
            this.btnSuppimerUser = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnVoirCours = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 19;
            this.lbUsers.Location = new System.Drawing.Point(197, 148);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(298, 251);
            this.lbUsers.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitre.Location = new System.Drawing.Point(259, 9);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(133, 24);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Liste des Users";
            // 
            // btnAjouterUser
            // 
            this.btnAjouterUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnAjouterUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUser.ForeColor = System.Drawing.Color.White;
            this.btnAjouterUser.Location = new System.Drawing.Point(0, 0);
            this.btnAjouterUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterUser.Name = "btnAjouterUser";
            this.btnAjouterUser.Size = new System.Drawing.Size(193, 119);
            this.btnAjouterUser.TabIndex = 2;
            this.btnAjouterUser.Text = "Ajouter";
            this.btnAjouterUser.UseVisualStyleBackColor = false;
            // 
            // btnSuppimerUser
            // 
            this.btnSuppimerUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnSuppimerUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppimerUser.ForeColor = System.Drawing.Color.White;
            this.btnSuppimerUser.Location = new System.Drawing.Point(0, 113);
            this.btnSuppimerUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppimerUser.Name = "btnSuppimerUser";
            this.btnSuppimerUser.Size = new System.Drawing.Size(193, 99);
            this.btnSuppimerUser.TabIndex = 3;
            this.btnSuppimerUser.Text = "Supprimer";
            this.btnSuppimerUser.UseVisualStyleBackColor = false;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.BackColor = System.Drawing.Color.DarkGray;
            this.btnRafraichir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.ForeColor = System.Drawing.Color.White;
            this.btnRafraichir.Location = new System.Drawing.Point(0, 312);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(2);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(193, 100);
            this.btnRafraichir.TabIndex = 4;
            this.btnRafraichir.Text = "Charger";
            this.btnRafraichir.UseVisualStyleBackColor = false;
            // 
            // btnVoirCours
            // 
            this.btnVoirCours.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoirCours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirCours.ForeColor = System.Drawing.Color.White;
            this.btnVoirCours.Location = new System.Drawing.Point(0, 207);
            this.btnVoirCours.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoirCours.Name = "btnVoirCours";
            this.btnVoirCours.Size = new System.Drawing.Size(193, 106);
            this.btnVoirCours.TabIndex = 5;
            this.btnVoirCours.Text = "Voir Les cours de l\'user";
            this.btnVoirCours.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 141);
            this.panel1.TabIndex = 6;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkGray;
            this.lbluser.Location = new System.Drawing.Point(72, 100);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 19);
            this.lbluser.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Views.Properties.Resources.logged;
            this.pictureBox2.Location = new System.Drawing.Point(62, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.LogoCA;
            this.pictureBox1.Location = new System.Drawing.Point(500, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoirCours);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.btnSuppimerUser);
            this.Controls.Add(this.btnAjouterUser);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lbUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FUser";
            this.Text = "Fuser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}