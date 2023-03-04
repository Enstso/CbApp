namespace Views
{
    partial class FNewCours
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.tbProf = new System.Windows.Forms.TextBox();
            this.tbUNom = new System.Windows.Forms.TextBox();
            this.tbUAdmin = new System.Windows.Forms.TextBox();
            this.tbUMdp = new System.Windows.Forms.TextBox();
            this.tbUPrenom = new System.Windows.Forms.TextBox();
            this.tbUId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(94, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(94, 91);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom :";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(97, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(268, 22);
            this.tbId.TabIndex = 9;
            this.tbId.Visible = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(197, 91);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(268, 22);
            this.tbNom.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(197, 236);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(197, 181);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(268, 22);
            this.dtpDate.TabIndex = 14;
            // 
            // cbProf
            // 
            this.cbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Location = new System.Drawing.Point(197, 134);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(268, 24);
            this.cbProf.TabIndex = 15;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(54, 137);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(85, 17);
            this.lblProf.TabIndex = 16;
            this.lblProf.Text = "Professeur :";
            // 
            // tbProf
            // 
            this.tbProf.Location = new System.Drawing.Point(197, 134);
            this.tbProf.Name = "tbProf";
            this.tbProf.Size = new System.Drawing.Size(100, 22);
            this.tbProf.TabIndex = 17;
            // 
            // tbUNom
            // 
            this.tbUNom.Location = new System.Drawing.Point(97, 12);
            this.tbUNom.Name = "tbUNom";
            this.tbUNom.Size = new System.Drawing.Size(268, 22);
            this.tbUNom.TabIndex = 18;
            this.tbUNom.Visible = false;
            // 
            // tbUAdmin
            // 
            this.tbUAdmin.Location = new System.Drawing.Point(97, 12);
            this.tbUAdmin.Name = "tbUAdmin";
            this.tbUAdmin.Size = new System.Drawing.Size(268, 22);
            this.tbUAdmin.TabIndex = 19;
            this.tbUAdmin.Visible = false;
            // 
            // tbUMdp
            // 
            this.tbUMdp.Location = new System.Drawing.Point(97, 12);
            this.tbUMdp.Name = "tbUMdp";
            this.tbUMdp.Size = new System.Drawing.Size(268, 22);
            this.tbUMdp.TabIndex = 20;
            this.tbUMdp.Visible = false;
            // 
            // tbUPrenom
            // 
            this.tbUPrenom.Location = new System.Drawing.Point(97, 12);
            this.tbUPrenom.Name = "tbUPrenom";
            this.tbUPrenom.Size = new System.Drawing.Size(268, 22);
            this.tbUPrenom.TabIndex = 21;
            this.tbUPrenom.Visible = false;
            // 
            // tbUId
            // 
            this.tbUId.Location = new System.Drawing.Point(97, 12);
            this.tbUId.Name = "tbUId";
            this.tbUId.Size = new System.Drawing.Size(268, 22);
            this.tbUId.TabIndex = 22;
            this.tbUId.Visible = false;
            // 
            // FNewCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 284);
            this.Controls.Add(this.tbUId);
            this.Controls.Add(this.tbUPrenom);
            this.Controls.Add(this.tbUMdp);
            this.Controls.Add(this.tbUAdmin);
            this.Controls.Add(this.tbUNom);
            this.Controls.Add(this.tbProf);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.cbProf);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnValider);
            this.Name = "FNewCours";
            this.Text = "Fnewcours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.TextBox tbProf;
        private System.Windows.Forms.TextBox tbUNom;
        private System.Windows.Forms.TextBox tbUAdmin;
        private System.Windows.Forms.TextBox tbUMdp;
        private System.Windows.Forms.TextBox tbUPrenom;
        private System.Windows.Forms.TextBox tbUId;
    }
}