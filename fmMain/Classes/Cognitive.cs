using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmMain.Classes
{
    public class Cognitive
    {
        public List<Concept> ConceptList { get; set; }
        public List<Relative> RelativeList { get; set; }
        public int Steps { get; set; }
        public Cognitive()
        {
            this.ConceptList = new List<Concept>();
            this.RelativeList = new List<Relative>();
        }
        public Cognitive(List<Concept> _conceptList, List<Relative> _relativeList, int _steps)
        {
            this.ConceptList = _conceptList;
            this.RelativeList = _relativeList;
            this.Steps = _steps;
        }
        public string ShowConcept()
        {
            var str = "";
            foreach (var con in ConceptList)
            {
                var number = ConceptList.IndexOf(con) + 1;
                str = "Концепт " + number + ": " + con.Name + ": \n(";

                foreach (var term in con.TermList)
                {
                    str += con.TermList.IndexOf(term) + " - " + term.Name + ";\n";
                }
                str += "): " + con.DegreeOfBelonging + "\n\n";
            }
            return str;
        }
        public void ShowRelations()
        {
            foreach (var rel in RelativeList)
            {
                
            }
        }

    }
}
