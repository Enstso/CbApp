namespace Views
{
    partial class Ffiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ffiche));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mail = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiche de l\'élève";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNom.Location = new System.Drawing.Point(157, 80);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 19);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(158, 120);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(0, 19);
            this.nom.TabIndex = 2;
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprenom.ForeColor = System.Drawing.Color.DarkGray;
            this.lblprenom.Location = new System.Drawing.Point(157, 155);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(63, 19);
            this.lblprenom.TabIndex = 3;
            this.lblprenom.Text = "Prénom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(159, 198);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(0, 19);
            this.prenom.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(476, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 141);
            this.panel1.TabIndex = 6;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkGray;
            this.lbluser.Location = new System.Drawing.Point(71, 100);
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
            this.pictureBox1.Location = new System.Drawing.Point(541, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(160, 274);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(0, 19);
            this.mail.TabIndex = 10;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmail.Location = new System.Drawing.Point(158, 229);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(39, 19);
            this.lblmail.TabIndex = 11;
            this.lblmail.Text = "Mail";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.ForeColor = System.Drawing.Color.DarkGray;
            this.lbltel.Location = new System.Drawing.Point(157, 312);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(80, 19);
            this.lbltel.TabIndex = 12;
            this.lbltel.Text = "Téléphone";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(158, 355);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(0, 19);
            this.tel.TabIndex = 13;
            // 
            // Ffiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 420);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.lblprenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ffiche";
            this.Text = "Fiche";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label tel;
    }
}