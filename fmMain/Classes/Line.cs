using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace fmMain.Classes
{
    public class Line
    {
        public Top V1;
        public Top V2;
        public double Weight = 0;
        public Line(Top v1, Top v2, double weight)
        {
            V1 = v1;
            V2 = v2;
            Weight = weight;
            //v1.degreeT++;
            //v2.degreeT++;
        }
        public void DrawLine(Bitmap bmp)//нарисовать дугу
        {
            Graphics Ln = Graphics.FromImage(bmp);

            Pen pen = new Pen(V1.Color);
            //Point point = new Point(V1.X, V1.Y);
            //pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = LineCap.RoundAnchor;
            Ln.DrawLine(pen, V1.X, V1.Y, V2.X, V2.Y);
            pen.Dispose();
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(V1.Color);
            //PointF drawPoint = new PointF(V1.X+10, V1.Y+10);
            //PointF drawPoint = new PointF(((V1.X + V2.X) / 2 + V1.X / 3), (V2.Y + V1.Y + 15) / 2);
            PointF drawPoint = new PointF((V1.X + V2.X) / 2, (V1.Y + V2.Y) / 2);
            Ln.DrawString(Weight.ToString(), drawFont, drawBrush, drawPoint);
        }

        public static bool operator ==(Line L1, Line L2)
        {
            if (((L1.V1 == L2.V1) && (L1.V2 == L2.V2)) || ((L1.V2 == L2.V1) && (L1.V1 == L2.V2)))//Дуги равны, если имеют одинаковые вершины
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(Line L1, Line L2)
        {
            if (!(((L1.V1 == L2.V1) && (L1.V2 == L2.V2)) || ((L1.V2 == L2.V1) && (L1.V1 == L2.V2))))
            {
                return true;
            }
            else return false;
        }
    }
}
