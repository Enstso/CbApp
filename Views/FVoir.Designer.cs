
namespace Views
{
    partial class FVoir
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
            this.lbVoir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbVoir
            // 
            this.lbVoir.FormattingEnabled = true;
            this.lbVoir.ItemHeight = 16;
            this.lbVoir.Location = new System.Drawing.Point(141, 96);
            this.lbVoir.Name = "lbVoir";
            this.lbVoir.Size = new System.Drawing.Size(495, 244);
            this.lbVoir.TabIndex = 0;
            // 
            // FVoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVoir);
            this.Name = "FVoir";
            this.Text = "FVoir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVoir;
    }
}