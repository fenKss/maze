using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level2 : Form
    {
        private Game _game;

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
            this._game = new Game(panel1, pointer, win, Width, Height);
            _game.OnWin += Win;
        }

        public void Win()
        {
            Text = "u win";
        }
    }
}