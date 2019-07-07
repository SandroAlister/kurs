using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fmMain.Classes;

namespace fmMain
{
    public partial class fmMain : DevExpress.XtraEditors.XtraForm
    {
        public fmMain()
        {
            InitializeComponent();
            _conceptList = new List<Concept>();
        }
        //public int Action { get; set; }

        public List<Concept> _conceptList { get; set; }
        private void sbStart_Click(object sender, EventArgs e)
        {
            try
            {



                //PaintTerm();
                //Cognitive cognitive1 = new Cognitive();

                //var term1 = new Term(0.1,0.2,0.4,0.5);
                //var term2 = new Term(0.6, 0.6, 0.7, 0.9);
                //var termList = new List<Term>();
                //termList.Add(term1);
                //termList.Add(term2);
                //var conceptName = "Концепт1";
                //var concept = new Concept(conceptName,termList);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void sbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = _conceptList.Count + 1;
                var concept = new Concept(Id);

                if (!fmConceptEdit.Execute(concept))
                    return;

                _conceptList.Add(concept);
                gcConcept.DataSource = _conceptList;
                gvConcept.RefreshData();

                AddTop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var concept = this.gvConcept.GetFocusedRow() as Concept;

                if (concept == null)
                    return;

                if (!fmConceptEdit.Execute(concept))
                    return;

                var newconcept = this.gvConcept.GetFocusedRow() as Concept;

                foreach (var c in _conceptList)
                {
                    if (c.Name == newconcept.Name && c.DegreeOfBelonging == newconcept.DegreeOfBelonging && c.TermList == newconcept.TermList)
                    {
                        c.Name = concept.Name;
                        c.DegreeOfBelonging = concept.DegreeOfBelonging;
                        c.TermList = concept.TermList;
                    }
                }

                gcConcept.DataSource = _conceptList;
                gvConcept.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var concept = this.gvConcept.GetFocusedRow() as Concept;

                if (concept == null)
                    return;

                RemoveTop(concept.Id);
                _conceptList.Remove(concept);
                gcConcept.DataSource = _conceptList;
                gvConcept.RefreshData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public Bitmap bmp = new Bitmap(670, 554);
        List<Top> Tops = new List<Top>();
        List<Line> Lines = new List<Line>();
        byte action = 0;
        bool SelTop = false;//Флаг выделения вершины
        bool ExistLine = false;//Флаг существования дуги
        bool randCol = true;
        Random rndTop = new Random();
        public int k { get; set; }

        public void DrawAllGraph()//Нарисовать весь граф
        {
            Graphics Clear = Graphics.FromImage(bmp);
            Clear.Clear(Color.Black);
            DeleteNoose();
            Random rand = new Random();
            int colo = 0x7F000000 + 0xFFFFFF / (Lines.Count + 1);
            colo += 0xFFFFFF / (Lines.Count + 1);
            Color clr = Color.FromArgb(colo);
            for (int i = 0; i < Lines.Count; i++)
            {
                if (randCol)
                {
                    clr = Color.FromArgb(rand.Next(50, 255), rand.Next(50, 255), rand.Next(50, 255));
                }
                else
                {
                    clr = Color.FromArgb(colo);
                    colo += 0xFFFFFF / (Lines.Count + 1);
                }
                Lines[i].DrawLine(bmp, clr);
            }

            for (int i = 0; i < Tops.Count; i++)
            {
                Tops[i].DrawTop(_conceptList[i].Id.ToString(), bmp);
            }

            pictureBox1.Image = bmp;
        }
        public void DeleteNoose()
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].V1 == Lines[i].V2)
                {
                    Lines.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Отобразить новый концепт 
        /// </summary>
        public void AddTop()
        {
            var x = rndTop.Next(0, 300);
            var y = rndTop.Next(0, 300);
            Top T = new Top(x, y);
            Tops.Add(T);//добавляем вершину в список вершин
            DrawAllGraph();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Tops.Any())
            {
                if (!SelTop)//Если не выделена вершина, то ищем вершину на которую мы кликнули
                {
                    for (int i = 0; i < Tops.Count; i++)
                        if ((e.X - Tops[i].X) * (e.X - Tops[i].X) + (e.Y - Tops[i].Y)
                            * (e.Y - Tops[i].Y) <= (Tops[i].Diameter / 2) * (Tops[i].Diameter / 2))
                        {
                            Tops[i].SelectTop(bmp);
                            pictureBox1.Image = bmp;
                            k = i;
                            SelTop = true;
                            pictureBox1.Enabled = true;
                            return;
                        }
                }
                else
                {
                    Tops[k].X = e.X;
                    Tops[k].Y = e.Y;
                    DrawAllGraph();
                    SelTop = false;
                    pictureBox1.Enabled = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Удалить выбранный концепт
        /// </summary>
        /// <param name="index"></param>
        public void RemoveTop(int index)
        {
            foreach (var top in Tops)
            {
                if(top.Name == index.ToString())
                {
                    Tops.Remove(top);
                    DrawAllGraph();
                    return;
                }
            }
        }
    }
}
