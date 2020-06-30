using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Game
    {
        private List<PictureBox> _borders;
        private PictureBox pointer;
        private PictureBox win;
        private Form _thisForm;
        private Form _nextForm;
        private Label _timerLabel;
        private int sec = 0;
        private Panel _panel;

        public delegate void WinHandler();

        public event WinHandler OnWin;

        public Game(Panel panel, PictureBox pointer, PictureBox win, Form thisForm, Form nextForm)
        {
            this.pointer = pointer;
            this._thisForm = thisForm;
            this._nextForm = nextForm;
            this._panel = panel;
            this.win = win;
            
            string pattern = "border.+";
            this._borders = panel.Controls.Cast<PictureBox>()
                .Where(x => Regex.IsMatch(x.Name, pattern, RegexOptions.IgnoreCase)).ToList();
            ;
            this.OnWin += Win;

            InitTimer();
        }

        private void InitTimer()
        {
            int labelWidth = 40,
                labelHeight = 100;
            Timer timer = new Timer();
            _timerLabel = new Label();
            _timerLabel.Size = new Size(labelWidth,labelHeight);
            _timerLabel.Location = new Point(_thisForm.Width-labelWidth,0);
            // _timerLabel.Location = new Point(10,10);
            timer.Interval=1000;
            timer.Start();
            timer.Tick += this.TimerTick;
            this._panel.Controls.Add(_timerLabel);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.sec++;
            _timerLabel.Text = sec.ToString();
        }

       

        public Point CalculatePoint(Keys keyCode)
        {
            string eKeyCode = keyCode.ToString().ToUpper();
            Point point;
            int x = pointer.Location.X,
                y = pointer.Location.Y,
                width = 1, //pointer.Width,
                height = 1; //pointer.Height;
            switch (eKeyCode)
            {
                case "W":
                    point = new Point(x, y - height);
                    break;
                case "S":
                    point = new Point(x, y + height);
                    break;
                case "D":
                    point = new Point(x + width, y);
                    break;
                case "A":
                    point = new Point(x - width, y);
                    break;
                default:
                    point = pointer.Location;
                    break;
            }

            return point;
        }

        public bool IsPointInBorder(Point point)
        {
            int x = point.X,
                y = point.Y;
            return x >= 0 && x + pointer.Width <= _thisForm.Width && y >= 0 && y + pointer.Height <= _thisForm.Height;
        }

        public void TryMovePoint(Keys eKeyCode)
        {
            for (int i = 0; i < 15; i++)
            {
                Point point = this.CalculatePoint(eKeyCode);
                if (this.IsPointInBorder(point))
                {
                    this.MovePoint(point);

                    if (this.IsWin())
                    {
                        this.OnWin?.Invoke();
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void MovePoint(Point point)
        {
            PictureBox tempPicture = new PictureBox();

            tempPicture.Width = this.pointer.Width;
            tempPicture.Height = this.pointer.Height;
            tempPicture.Location = point;

            if (!IsIntersects(tempPicture)) this.pointer.Location = point;


            tempPicture.Dispose();
        }

        private bool IsIntersects(PictureBox pictureBox)
        {
            bool isIntersects = false;
            foreach (var border in this._borders)
            {
                if (pictureBox.Bounds.IntersectsWith(border.Bounds))
                {
                    isIntersects = true;
                    break;
                }
            }

            return isIntersects;
        }

        public bool IsWin()
        {
            return (this.pointer.Bounds.IntersectsWith(win.Bounds));
        }
        public void Win()
        {
            if (_nextForm != null)
            {
                DialogResult result = MessageBox.Show(
                    "Перейти на следующий уровень?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    _nextForm.Show();
                    _thisForm.Hide();
                    _nextForm.TopMost = true;
                    _nextForm.TopMost = false;
                }
                else
                {
                    Form form = new End(1);
                    _thisForm.Hide();
                    form.Show();
                }
            }
            else
            {
                Form form = new End(this.sec);
                _thisForm.Hide();
                form.Show();
            }
        }
    }
}