
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 253);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(246, 114);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Voir les Users";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnVoirEleves
            // 
            this.btnVoirEleves.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoirEleves.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirEleves.ForeColor = System.Drawing.Color.White;
            this.btnVoirEleves.Location = new System.Drawing.Point(0, 136);
            this.btnVoirEleves.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoirEleves.Name = "btnVoirEleves";
            this.btnVoirEleves.Size = new System.Drawing.Size(246, 120);
            this.btnVoirEleves.TabIndex = 1;
            this.btnVoirEleves.Text = "Voir les Eleves";
            this.btnVoirEleves.UseVisualStyleBackColor = false;
            // 
            // btnVoirCours
            // 
            this.btnVoirCours.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoirCours.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirCours.ForeColor = System.Drawing.Color.White;
            this.btnVoirCours.Location = new System.Drawing.Point(0, 2);
            this.btnVoirCours.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoirCours.Name = "btnVoirCours";
            this.btnVoirCours.Size = new System.Drawing.Size(246, 141);
            this.btnVoirCours.TabIndex = 2;
            this.btnVoirCours.Text = "Voir les cours";
            this.btnVoirCours.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(435, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 141);
            this.panel1.TabIndex = 4;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkGray;
            this.lbluser.Location = new System.Drawing.Point(71, 100);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 19);
            this.lbluser.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Views.Properties.Resources.logged;
            this.pictureBox2.Location = new System.Drawing.Point(62, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.LogoCA;
            this.pictureBox1.Location = new System.Drawing.Point(501, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoirCours);
            this.Controls.Add(this.btnVoirEleves);
            this.Controls.Add(this.btnUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMainAdmin";
            this.Text = "FMainAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnVoirEleves;
        private System.Windows.Forms.Button btnVoirCours;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbluser;
    }
}