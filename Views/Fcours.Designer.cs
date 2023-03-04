namespace Views
{
    partial class FCours
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
            this.lbCours = new System.Windows.Forms.ListBox();
            this.lblProchainCours = new System.Windows.Forms.Label();
            this.btnVoirEleves = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCours
            // 
            this.lbCours.FormattingEnabled = true;
            this.lbCours.ItemHeight = 16;
            this.lbCours.Location = new System.Drawing.Point(115, 86);
            this.lbCours.Name = "lbCours";
            this.lbCours.Size = new System.Drawing.Size(564, 260);
            this.lbCours.TabIndex = 0;
            // 
            // lblProchainCours
            // 
            this.lblProchainCours.AutoSize = true;
            this.lblProchainCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProchainCours.Location = new System.Drawing.Point(208, 21);
            this.lblProchainCours.Name = "lblProchainCours";
            this.lblProchainCours.Size = new System.Drawing.Size(392, 46);
            this.lblProchainCours.TabIndex = 1;
            this.lblProchainCours.Text = "Les Prochains Cours";
            // 
            // btnVoirEleves
            // 
            this.btnVoirEleves.Location = new System.Drawing.Point(340, 445);
            this.btnVoirEleves.Name = "btnVoirEleves";
            this.btnVoirEleves.Size = new System.Drawing.Size(160, 48);
            this.btnVoirEleves.TabIndex = 2;
            this.btnVoirEleves.Text = "Voir Les Eleves présents à ce cours";
            this.btnVoirEleves.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(245, 377);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(160, 48);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(440, 377);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(160, 48);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 377);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 48);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(628, 377);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(160, 48);
            this.btnCharger.TabIndex = 6;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            // 
            // FCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnVoirEleves);
            this.Controls.Add(this.lblProchainCours);
            this.Controls.Add(this.lbCours);
            this.Name = "FCours";
            this.Text = "Fcours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCours;
        private System.Windows.Forms.Label lblProchainCours;
        private System.Windows.Forms.Button btnVoirEleves;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnCharger;
    }
}