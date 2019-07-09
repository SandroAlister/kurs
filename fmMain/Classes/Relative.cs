using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    public class Relative
    {
        public Concept _Concept1 { get; set; }
        public Concept _Concept2 { get; set; }
        public double Value { get; set; }

        public Relative() { }

        public Relative(Concept con1, Concept con2, double value)
        {
            _Concept1 = con1;
            _Concept2 = con2;
            Value = value;
        }

        //public double CalculateMu()
        //{
        //    var fuzzies = _Concept1.GiveFuzzy();
        //    var muX = fuzzies.Max();
        //    int id1 = (int)Math.Round(Matrix.Length * _Concept1.DegreeOfBelonging) - 1;
        //    int id2 = (int)Math.Round(Matrix.Length * _Concept2.DegreeOfBelonging) - 1;
        //    var muR = Matrix[id1, id2];
        //    return Math.Min(muX, muR);
        //}

        //public List<double> CalculateFuzzy()
        //{
        //    var muZ = CalculateMu();
        //    var mas = new double[4, 2];
        //    var arrayList = new List<double>();
        //    foreach (var term in _Concept2.TermList)
        //    {
        //        arrayList.AddRange(term.GetNewTerm(muZ).OfType<double>().ToList());
        //    }
        //    return arrayList;
        //}
    }
}
