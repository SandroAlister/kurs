using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    public class Line
    {
        public Top V1;
        public Top V2;
        public int Weight = 0;
        public Line(Top v1, Top v2, int weight)
        {
            V1 = v1;
            V2 = v2;
            Weight = weight;
            //v1.degreeT++;
            //v2.degreeT++;
        }
        public void DrawLine(Bitmap bmp, Color clr)//нарисовать дугу
        {
            Graphics Ln = Graphics.FromImage(bmp);

            Pen pen = new Pen(clr);

            Ln.DrawLine(pen, V1.X, V1.Y, V2.X, V2.Y);

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(clr);
            PointF drawPoint = new PointF((V2.X + V1.X) / 2, (V2.Y + V1.Y) / 2);

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
