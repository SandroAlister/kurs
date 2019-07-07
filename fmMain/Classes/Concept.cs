using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    public class Concept
    {
        /// <summary>
        /// Список термов
        /// </summary>
        public List<Term> TermList { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// Степень пренадлежности
        /// </summary>
        public double DegreeOfBelonging { get; set; }

        public Concept(int id)
        {
            Id = id;
            TermList = new List<Term>();
        }

        public Concept(int id, string name, List<Term> termList)
        {
            //TermList = new List<Term>();
            TermList = termList;
            Name = name;
            DegreeOfBelonging = 0;
            Id = id;
        }

        /// <summary>
        /// Установление значения концепту
        /// </summary>
        /// <param name="degree"></param>
        public void SetDegree(double degree)
        {
            if (degree < 0)
                this.DegreeOfBelonging = 0;
            if (degree > 1)
                this.DegreeOfBelonging = 1;
            else
                this.DegreeOfBelonging = degree;
        }

        /// <summary>
        /// Вывод степени принадлежности ко всем термам
        /// </summary>
        public List<double> GiveFuzzy()
        {
            var result = new List<double>();
            foreach (var term in TermList)
            {
                var temp = term.CalculateDegree(DegreeOfBelonging);
                result.Add(temp);
            }

            return result;
        }
    }
}
