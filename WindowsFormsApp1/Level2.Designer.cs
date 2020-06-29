using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Level2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pointer = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.win)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.win);
            this.panel1.Controls.Add(this.pointer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 454);
            this.panel1.TabIndex = 0;
            // 
            // pointer
            // 
            this.pointer.Image = ((System.Drawing.Image) (resources.GetObject("pointer.Image")));
            this.pointer.Location = new System.Drawing.Point(185, 136);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(30, 30);
            this.pointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pointer.TabIndex = 1;
            this.pointer.TabStop = false;
            // 
            // win
            // 
            this.win.Image = ((System.Drawing.Image) (resources.GetObject("win.Image")));
            this.win.Location = new System.Drawing.Point(342, 234);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(55, 55);
            this.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.win.TabIndex = 2;
            this.win.TabStop = false;
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Level2";
            this.Text = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.win)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pointer;
        private System.Windows.Forms.PictureBox win;

        #endregion
    }
}