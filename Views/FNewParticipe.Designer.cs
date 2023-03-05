
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNewParticipe));
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
            this.cbEleve.Location = new System.Drawing.Point(77, 83);
            this.cbEleve.Margin = new System.Windows.Forms.Padding(2);
            this.cbEleve.Name = "cbEleve";
            this.cbEleve.Size = new System.Drawing.Size(175, 21);
            this.cbEleve.TabIndex = 1;
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleve.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEleve.Location = new System.Drawing.Point(73, 62);
            this.lblEleve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(53, 19);
            this.lblEleve.TabIndex = 2;
            this.lblEleve.Text = "Eleve :";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DarkGray;
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(77, 121);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 27);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // tbIdCours
            // 
            this.tbIdCours.Location = new System.Drawing.Point(77, 29);
            this.tbIdCours.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdCours.Name = "tbIdCours";
            this.tbIdCours.Size = new System.Drawing.Size(76, 20);
            this.tbIdCours.TabIndex = 4;
            this.tbIdCours.Visible = false;
            // 
            // FNewParticipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 175);
            this.Controls.Add(this.tbIdCours);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.cbEleve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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