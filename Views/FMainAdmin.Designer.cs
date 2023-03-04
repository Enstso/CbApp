
namespace Views
{
    partial class FMainAdmin
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnVoirEleves = new System.Windows.Forms.Button();
            this.btnVoirCours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(62, 231);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(138, 47);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Voir les User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnVoirEleves
            // 
            this.btnVoirEleves.Location = new System.Drawing.Point(338, 231);
            this.btnVoirEleves.Name = "btnVoirEleves";
            this.btnVoirEleves.Size = new System.Drawing.Size(138, 47);
            this.btnVoirEleves.TabIndex = 1;
            this.btnVoirEleves.Text = "Voir les Eleves";
            this.btnVoirEleves.UseVisualStyleBackColor = true;
            // 
            // btnVoirCours
            // 
            this.btnVoirCours.Location = new System.Drawing.Point(612, 231);
            this.btnVoirCours.Name = "btnVoirCours";
            this.btnVoirCours.Size = new System.Drawing.Size(138, 47);
            this.btnVoirCours.TabIndex = 2;
            this.btnVoirCours.Text = "Voir les cours";
            this.btnVoirCours.UseVisualStyleBackColor = true;
            // 
            // FMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoirCours);
            this.Controls.Add(this.btnVoirEleves);
            this.Controls.Add(this.btnUser);
            this.Name = "FMainAdmin";
            this.Text = "FMainAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnVoirEleves;
        private System.Windows.Forms.Button btnVoirCours;
    }
}