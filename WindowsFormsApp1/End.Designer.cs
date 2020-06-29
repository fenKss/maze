using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class End
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(289, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поздравляю!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(245, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вы прошли последний уровень за 10 секунд";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {"Вася", "Петя"});
            this.listBox1.Location = new System.Drawing.Point(21, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 68);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добавить свое имя в историю";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "История";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "End";
            this.Text = "End";
            this.Load += new System.EventHandler(this.End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}