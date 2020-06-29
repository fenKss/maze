namespace WindowsFormsApp1
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборУровняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(296, 153);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лабиринт";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.выборУровняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборУровняToolStripMenuItem
            // 
            this.выборУровняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.уровень1ToolStripMenuItem, this.уровень2ToolStripMenuItem, this.уровень3ToolStripMenuItem});
            this.выборУровняToolStripMenuItem.Name = "выборУровняToolStripMenuItem";
            this.выборУровняToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.выборУровняToolStripMenuItem.Text = "Выбор уровня";
            // 
            // уровень1ToolStripMenuItem
            // 
            this.уровень1ToolStripMenuItem.Name = "уровень1ToolStripMenuItem";
            this.уровень1ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.уровень1ToolStripMenuItem.Text = "Уровень 1";
            this.уровень1ToolStripMenuItem.Click += new System.EventHandler(this.уровень1ToolStripMenuItem_Click);
            // 
            // уровень2ToolStripMenuItem
            // 
            this.уровень2ToolStripMenuItem.Name = "уровень2ToolStripMenuItem";
            this.уровень2ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.уровень2ToolStripMenuItem.Text = "Уровень 2";
            this.уровень2ToolStripMenuItem.Click += new System.EventHandler(this.уровень2ToolStripMenuItem_Click);
            // 
            // уровень3ToolStripMenuItem
            // 
            this.уровень3ToolStripMenuItem.Name = "уровень3ToolStripMenuItem";
            this.уровень3ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.уровень3ToolStripMenuItem.Text = "Уровень 3";
            this.уровень3ToolStripMenuItem.Click += new System.EventHandler(this.уровень3ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Лабиринт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборУровняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень3ToolStripMenuItem;

        #endregion
    }
}