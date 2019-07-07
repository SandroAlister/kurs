using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    /// <summary>
    /// Концепт (графическое отображение)
    /// </summary>
    public class Top
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public int Diameter { get { return 50; } }

        public Top(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Top()
        {
            X = 0;
            Y = 0;
        }
        public void DrawTop(string letter, Bitmap bmp)//Нарисовать круг стандартным диаметром в координатах x и y
        {
            Graphics Ver = Graphics.FromImage(bmp);
            SolidBrush drawBrush1 = new SolidBrush(Color.Aquamarine);

            Ver.FillEllipse(drawBrush1, X - Diameter / 2, Y - Diameter / 2, Diameter, Diameter);

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(X - 10, Y - 10);
            this.Name = letter;
            Ver.DrawString(letter, drawFont, drawBrush, drawPoint);
        }

        public void SelectTop(Bitmap bmp)//Выделить круг
        {
            Graphics Ver = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Aquamarine, 3);
            Ver.DrawEllipse(pen, X - (Diameter + 7) / 2, Y - (Diameter + 7) / 2, Diameter + 7, Diameter + 7);
            pen = new Pen(Color.Aquamarine, 2);
            Ver.DrawEllipse(pen, X - (Diameter + 17) / 2, Y - (Diameter + 17) / 2, Diameter + 17, Diameter + 17);
            pen = new Pen(Color.Aquamarine, 1);
            Ver.DrawEllipse(pen, X - (Diameter + 25) / 2, Y - (Diameter + 25) / 2, Diameter + 25, Diameter + 25);
        }

    }
}
