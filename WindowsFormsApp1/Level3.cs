using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level3 : Form
    {
        private Game _game;

        public Level3()
        {
            InitializeComponent();
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            this._game = new Game(panel1, pointer, win, this, null);
            this.FormClosed += FormClose;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            var eKeyCode = e.KeyCode;
            _game.TryMovePoint(eKeyCode);
        }
    }
}