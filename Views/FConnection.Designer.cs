namespace Views
{
    partial class FConnection
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
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblErreurConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(195, 172);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(242, 22);
            this.tbPrenom.TabIndex = 0;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(195, 237);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(242, 22);
            this.tbMdp.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(70, 41);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(425, 51);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "CONNECTEZ-VOUS";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(64, 172);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(77, 17);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Identifiant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de Passe :";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(243, 332);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Se Connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // lblErreurConnection
            // 
            this.lblErreurConnection.AutoSize = true;
            this.lblErreurConnection.Location = new System.Drawing.Point(216, 287);
            this.lblErreurConnection.Name = "lblErreurConnection";
            this.lblErreurConnection.Size = new System.Drawing.Size(203, 17);
            this.lblErreurConnection.TabIndex = 6;
            this.lblErreurConnection.Text = "Mot de passe ou nom incorrect";
            this.lblErreurConnection.Visible = false;
            // 
            // FConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 399);
            this.Controls.Add(this.lblErreurConnection);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbPrenom);
            this.Name = "FConnection";
            this.Text = "Connectez-Vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblErreurConnection;
    }
}