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
        private int _formWidth;
        private int _formHeight;

        public Game(Panel panel, PictureBox pointer, PictureBox win, int width, int height)
        {
            this.pointer = pointer;
            this._formHeight = height;
            this._formWidth = width;
            this.win = win;
            string pattern = "border.+";
            this._borders = panel.Controls.Cast<PictureBox>()
                .Where(x => Regex.IsMatch(x.Name, pattern, RegexOptions.IgnoreCase)).ToList();
            ;
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
            return x >= 0 && x + pointer.Width <= _formWidth && y >= 0 && y + pointer.Height <= _formHeight;
        }

        public void MovePoint(Point point)
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
    }
}