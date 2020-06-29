using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Game _game;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this._game = new Game(panel1, pointer, win, Width, Height);
            _game.OnWin += Win;
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            var eKeyCode = e.KeyCode;
            _game.TryMovePoint(eKeyCode);
            
        }

        public void Win()
        {
            DialogResult result = MessageBox.Show(
                "Окрасить кнопку в красный цвет?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                Level2 form = new Level2();
                form.Show();
                this.Hide();
                form.TopMost = true;
                form.TopMost = false;
            }

            this.Text += 1;

            // button1.BackColor=Color.Red;
        }
    }
}