using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class End : Form
    {
        private int _sec;

        public End(int sec)
        {
            this._sec = sec;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void End_Load(object sender, EventArgs e)
        {
            this.label2.Text = "Вы прошли последний уровень за " + this._sec + " секунд";
            this.FormClosed += FormClose;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            listBox1.Items.Add(text);
        }
    }
}