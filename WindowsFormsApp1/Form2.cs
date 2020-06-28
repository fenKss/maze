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
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            var eKeyCode = e.KeyCode;
            for (int i = 0; i < 15; i++)
            {
                Point point = _game.CalculatePoint(eKeyCode);
                this.Text = _game.IsPointInBorder(point).ToString();
                if (_game.IsPointInBorder(point))
                {
                    _game.MovePoint(point);
                    
                    if (_game.IsWin())
                    {
                        this.Text = "u Winnner";
                        break;
                    }
                }
                else
                {
                    break;
                }

                
                
            }
            
        }


        
    }
}