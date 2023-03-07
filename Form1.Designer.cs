
namespace Fitness4u__Project_
{
    partial class Form1
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
            this.btmNavBar_Line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btmNavBar_Line)).BeginInit();
            this.SuspendLayout();
            // 
            // btmNavBar_Line
            // 
            this.btmNavBar_Line.Image = global::Fitness4u__Project_.Properties.Resources._2560x1440_black_solid_color_background;
            this.btmNavBar_Line.Location = new System.Drawing.Point(-7, 599);
            this.btmNavBar_Line.Name = "btmNavBar_Line";
            this.btmNavBar_Line.Size = new System.Drawing.Size(400, 5);
            this.btmNavBar_Line.TabIndex = 0;
            this.btmNavBar_Line.TabStop = false;
            this.btmNavBar_Line.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.btmNavBar_Line);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btmNavBar_Line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btmNavBar_Line;
    }
}

