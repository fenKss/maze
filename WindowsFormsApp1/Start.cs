using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Level1();
            this.Hide();
            form.Show();
            form.TopMost = true;
        }

        private void уровень1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Level1();
            this.Hide();
            form.Show();
            form.TopMost = true;
        }

        private void уровень2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Level2();
            this.Hide();
            form.Show();
            form.TopMost = true;
        }

        private void уровень3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Level3();
            this.Hide();
            form.Show();
            form.TopMost = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}