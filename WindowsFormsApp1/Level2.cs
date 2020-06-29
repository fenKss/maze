using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level2 : Form
    {
        private Game _game;
        private Form _nextForm;

        public Level2()
        {
            InitializeComponent();
        }


        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            var eKeyCode = e.KeyCode;
            _game.TryMovePoint(eKeyCode);
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            this._nextForm = new Level3();
            this._game = new Game(panel1, pointer, win, this, this._nextForm);
            this.FormClosed += FormClose;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}