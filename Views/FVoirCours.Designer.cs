
namespace Views
{
    partial class FVoirCours
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
            this.lbEleves = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.tbIdCours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEleves
            // 
            this.lbEleves.FormattingEnabled = true;
            this.lbEleves.ItemHeight = 16;
            this.lbEleves.Location = new System.Drawing.Point(148, 57);
            this.lbEleves.Name = "lbEleves";
            this.lbEleves.Size = new System.Drawing.Size(495, 244);
            this.lbEleves.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(148, 362);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(133, 32);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(332, 362);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(133, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(510, 362);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(133, 32);
            this.btnRafraichir.TabIndex = 4;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            // 
            // tbIdCours
            // 
            this.tbIdCours.Location = new System.Drawing.Point(27, 131);
            this.tbIdCours.Name = "tbIdCours";
            this.tbIdCours.Size = new System.Drawing.Size(100, 22);
            this.tbIdCours.TabIndex = 5;
            this.tbIdCours.Visible = false;
            // 
            // FVoirCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIdCours);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lbEleves);
            this.Name = "FVoirCours";
            this.Text = "Eleve d\'un cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEleves;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.TextBox tbIdCours;
    }
}