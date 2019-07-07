using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    public class Term
    {
        /// <summary>
        /// Левая граница терма
        /// </summary>
        public double X1 { get; set; }

        /// <summary>
        /// Начало отрезка толерантности
        /// </summary>
        public double X2 { get; set; }

        /// <summary>
        /// Конец отрезка толерантности
        /// </summary>
        public double X3 { get; set; }

        /// <summary>
        /// Правая граница терма
        /// </summary>
        public double X4 { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Рассчет степени принадлежности к терму для введенной точки
        /// </summary>
        /// <param name="arg">Введенная точка</param>
        /// <returns>Степень принадлежности</returns>
        public double CalculateDegree(double arg)
        {
            if (X1 < arg && arg < X2)
                return (arg - X1) / (X2 - X1);

            if (X2 <= arg && arg <= X3)
                return 1.0;

            if (X3 < arg && arg < X4)
                return 1.0 - ((arg - X1) / (X2 - X1));

            else
                return 0.0;

        }

        /// <summary>
        /// Получение обрезанного сверху терма
        /// </summary>
        /// <param name="arg">Степень принадлежности</param>
        public double[,] GetNewTerm(double arg)
        {
            try
            {
                var xr1 = arg * (X2 - X1) + X1;
                var xr2 = (1.0 - arg) * (X4 - X3) + X3;

                if (xr1 < 0)
                    xr1 = 0.0;

                if (xr2 > 1)
                    xr2 = 1.0;

                if (X1 < 0)
                    X1 = 0.0;

                if (X4 > 1)
                    X4 = 1.0;

                double[,] newTerm = new double[,] { { X1, 0.0 }, { xr1, arg }, { xr2, arg }, { X4, 0.0 } };

                return newTerm;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Term() { }

        public Term(double x1, double x2, double x3, double x4, string name)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.X3 = x3;
            this.X4 = x4;
            this.Name = name;
        }
    }
}
