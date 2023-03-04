namespace Views
{
    partial class FEleves
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
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnVoirCours = new System.Windows.Forms.Button();
            this.lblEleves = new System.Windows.Forms.Label();
            this.lbEleves = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(616, 365);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(160, 48);
            this.btnCharger.TabIndex = 13;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(28, 365);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 48);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(428, 365);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(160, 48);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(233, 365);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(160, 48);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnVoirCours
            // 
            this.btnVoirCours.Location = new System.Drawing.Point(328, 433);
            this.btnVoirCours.Name = "btnVoirCours";
            this.btnVoirCours.Size = new System.Drawing.Size(160, 48);
            this.btnVoirCours.TabIndex = 9;
            this.btnVoirCours.Text = "Voir Les Cours de l\'élève";
            this.btnVoirCours.UseVisualStyleBackColor = true;
            // 
            // lblEleves
            // 
            this.lblEleves.AutoSize = true;
            this.lblEleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleves.Location = new System.Drawing.Point(320, 9);
            this.lblEleves.Name = "lblEleves";
            this.lblEleves.Size = new System.Drawing.Size(139, 46);
            this.lblEleves.TabIndex = 8;
            this.lblEleves.Text = "Eleves";
            // 
            // lbEleves
            // 
            this.lbEleves.FormattingEnabled = true;
            this.lbEleves.ItemHeight = 16;
            this.lbEleves.Location = new System.Drawing.Point(103, 74);
            this.lbEleves.Name = "lbEleves";
            this.lbEleves.Size = new System.Drawing.Size(564, 260);
            this.lbEleves.TabIndex = 7;
            // 
            // FEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnVoirCours);
            this.Controls.Add(this.lblEleves);
            this.Controls.Add(this.lbEleves);
            this.Name = "FEleves";
            this.Text = "Feleves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnVoirCours;
        private System.Windows.Forms.Label lblEleves;
        private System.Windows.Forms.ListBox lbEleves;
    }
}