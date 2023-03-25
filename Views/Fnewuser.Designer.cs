namespace Views
{
    partial class FNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNewUser));
            this.btnValider = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblverif = new System.Windows.Forms.Label();
            this.tbVerif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DarkGray;
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(127, 195);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(202, 29);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(126, 31);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(202, 20);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(126, 74);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(202, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(125, 117);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(2);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(202, 20);
            this.tbMdp.TabIndex = 3;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNom.Location = new System.Drawing.Point(123, 9);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 19);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.Silver;
            this.lblPrenom.Location = new System.Drawing.Point(123, 53);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(67, 19);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom ";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMdp.Location = new System.Drawing.Point(123, 96);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(104, 19);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "Mot de Passe ";
            // 
            // lblverif
            // 
            this.lblverif.AutoSize = true;
            this.lblverif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverif.ForeColor = System.Drawing.Color.DarkGray;
            this.lblverif.Location = new System.Drawing.Point(122, 139);
            this.lblverif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblverif.Name = "lblverif";
            this.lblverif.Size = new System.Drawing.Size(191, 19);
            this.lblverif.TabIndex = 8;
            this.lblverif.Text = "Comfirmer le mot de passe";
            // 
            // tbVerif
            // 
            this.tbVerif.Location = new System.Drawing.Point(125, 160);
            this.tbVerif.Margin = new System.Windows.Forms.Padding(2);
            this.tbVerif.Name = "tbVerif";
            this.tbVerif.Size = new System.Drawing.Size(202, 20);
            this.tbVerif.TabIndex = 7;
            this.tbVerif.UseSystemPasswordChar = true;
            // 
            // FNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 245);
            this.Controls.Add(this.lblverif);
            this.Controls.Add(this.tbVerif);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FNewUser";
            this.Text = "Ajout User";
            this.Load += new System.EventHandler(this.FNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblverif;
        private System.Windows.Forms.TextBox tbVerif;
    }
}