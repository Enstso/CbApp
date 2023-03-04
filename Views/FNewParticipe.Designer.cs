
namespace Views
{
    partial class FNewParticipe
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
            this.cbEleve = new System.Windows.Forms.ComboBox();
            this.lblEleve = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbIdCours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEleve
            // 
            this.cbEleve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleve.FormattingEnabled = true;
            this.cbEleve.Location = new System.Drawing.Point(160, 76);
            this.cbEleve.Name = "cbEleve";
            this.cbEleve.Size = new System.Drawing.Size(232, 24);
            this.cbEleve.TabIndex = 1;
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Location = new System.Drawing.Point(43, 76);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(51, 17);
            this.lblEleve.TabIndex = 2;
            this.lblEleve.Text = "Eleve :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(160, 151);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // tbIdCours
            // 
            this.tbIdCours.Location = new System.Drawing.Point(190, 22);
            this.tbIdCours.Name = "tbIdCours";
            this.tbIdCours.Size = new System.Drawing.Size(100, 22);
            this.tbIdCours.TabIndex = 4;
            this.tbIdCours.Visible = false;
            // 
            // FNewParticipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 215);
            this.Controls.Add(this.tbIdCours);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.cbEleve);
            this.Name = "FNewParticipe";
            this.Text = "FNewParticipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEleve;
        private System.Windows.Forms.Label lblEleve;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbIdCours;
    }
}