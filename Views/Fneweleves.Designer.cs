namespace Views
{
    partial class FNewEleves
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(88, 157);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 17);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(68, 112);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 12;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(88, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom :";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(191, 152);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(268, 22);
            this.tbMail.TabIndex = 10;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(191, 109);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(268, 22);
            this.tbPrenom.TabIndex = 9;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(191, 64);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(268, 22);
            this.tbNom.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(240, 259);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(45, 201);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 17);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Telephone :";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(191, 201);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(268, 22);
            this.tbTelephone.TabIndex = 15;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(146, 24);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(268, 22);
            this.tbId.TabIndex = 17;
            // 
            // FNewEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnValider);
            this.Name = "FNewEleves";
            this.Text = "Fneweleves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbId;
    }
}