using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fmMain.Classes;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout.Utils;
using System.Threading;

namespace fmMain
{
    public partial class fmMain : DevExpress.XtraEditors.XtraForm
    {
        public fmMain()
        {
            InitializeComponent();
            _conceptList = new List<Concept>();
            _relativeList = new List<Relative>();
            VisibleDelta();
        }
        //public int Action { get; set; }

        public List<Concept> _conceptList { get; set; }
        public List<Relative> _relativeList { get; set; }
        private void sbStart_Click(object sender, EventArgs e)
        {
            try
            {
                InitData();


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

                var Id = _conceptList.Count > 0 ? _conceptList[_conceptList.Count - 1].Id + 1 : 1;
                var concept = new Concept(Id);

                if (!fmConceptEdit.Execute(concept))
                    return;

                _conceptList.Add(concept);
                gcConcept.DataSource = _conceptList;
                gvConcept.RefreshData();

                AddTop();
                SetMatrix();
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
                SetMatrix();
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

                RemoveLine(concept.Id);
                RemoveTop(concept.Id);

                _conceptList.Remove(concept);
                _relativeList.RemoveAll(g => (g._Concept1 == concept || g._Concept2 == concept));
                gcConcept.DataSource = _conceptList;
                gvConcept.RefreshData();
                SetMatrix();
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
        Random randColor = new Random();
        public void DrawAllGraph()//Нарисовать весь граф
        {
            Graphics Clear = Graphics.FromImage(bmp);
            Clear.Clear(Color.Black);
            DeleteNoose();

            //int colo = 0x7F000000 + 0xFFFFFF / (Lines.Count + 1);
            //colo += 0xFFFFFF / (Lines.Count + 1);
            //Color clr = Color.FromArgb(colo);
            for (int i = 0; i < Lines.Count; i++)
            {
                //if (randCol)
                //{
                //    clr = Color.FromArgb(rand.Next(50, 255), rand.Next(50, 255), rand.Next(50, 255));
                //}
                //else
                //{
                //    clr = Color.FromArgb(colo);
                //    colo += 0xFFFFFF / (Lines.Count + 1);
                //}
                Lines[i].DrawLine(bmp);
            }
            var name = "";
            for (int i = 0; i < Tops.Count; i++)
            {

                name = Tops[i].Name;
                if (String.IsNullOrEmpty(name))
                    Tops[i].DrawTop(_conceptList[i].Id.ToString(), bmp);
                else
                    Tops[i].DrawTop(name, bmp);
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

            Color clr = Color.FromArgb(randColor.Next(50, 255), randColor.Next(50, 255), randColor.Next(50, 255));
            var x = rndTop.Next(0, 300);
            var y = rndTop.Next(0, 300);
            Top T = new Top(x, y, clr);
            Tops.Add(T);//добавляем вершину в список вершин
            DrawAllGraph();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (top.Name == index.ToString())
                {
                    Tops.Remove(top);
                    DrawAllGraph();
                    return;
                }
            }
        }
        public void RemoveLine(int index)
        {
            Lines.RemoveAll(g => ((g.V1.Name == index.ToString()) || (g.V2.Name == index.ToString())));

        }
        private void InitData()
        {

            _conceptList = new List<Concept>();
            _relativeList = new List<Relative>();
            Lines = new List<Line>();
            Tops = new List<Top>();
            var t1 = new Term(0.0, 0.1, 0.2, 0.3, "Быстро");
            var t2 = new Term(0.4, 0.6, 0.8, 1.0, "Медленно");
            var tl1 = new List<Term>();
            tl1.Add(t1);
            tl1.Add(t2);
            var c1 = new Concept(1, "Скорость", 0.8, tl1);
            _conceptList.Add(c1);
            gcConcept.DataSource = _conceptList;
            gvConcept.RefreshData();

            AddTop();
            var t3 = new Term(0.0, 0.1, 0.2, 0.3, "Тяжело");
            var t4 = new Term(0.4, 0.6, 0.8, 1.0, "Легко");
            var tl2 = new List<Term>();
            tl2.Add(t3);
            tl2.Add(t4);
            var c2 = new Concept(2, "Сложность", 0.75, tl2);
            _conceptList.Add(c2);
            gcConcept.DataSource = _conceptList;
            gvConcept.RefreshData();

            AddTop();

            var t5 = new Term(0.0, 0.1, 0.2, 0.3, "Холодно");
            var t6 = new Term(0.4, 0.6, 0.8, 1.0, "Тепло");
            var tl3 = new List<Term>();
            tl3.Add(t5);
            tl3.Add(t6);
            var c3 = new Concept(3, "Температура", 0.9, tl3);
            _conceptList.Add(c3);
            gcConcept.DataSource = _conceptList;
            gvConcept.RefreshData();

            AddTop();

            var t7 = new Term(0.0, 0.1, 0.2, 0.3, "Дешево");
            var t8 = new Term(0.4, 0.6, 0.8, 1.0, "Дорого");
            var tl4 = new List<Term>();
            tl4.Add(t7);
            tl4.Add(t8);
            var c4 = new Concept(4, "Цена", 0.5, tl4);
            _conceptList.Add(c4);
            gcConcept.DataSource = _conceptList;
            gvConcept.RefreshData();

            AddTop();
            SetMatrix();

            var relative12 = new Relative(c1, c2, 0.2);
            _relativeList.Add(relative12);
            DrawLine(relative12);

            var relative23 = new Relative(c2, c3, 0.5);
            _relativeList.Add(relative23);
            DrawLine(relative23);

            var relative24 = new Relative(c2, c4, 0.4);
            _relativeList.Add(relative24);
            DrawLine(relative24);

            var relative31 = new Relative(c3, c1, 0.4);
            _relativeList.Add(relative31);
            DrawLine(relative31);

            var relative41 = new Relative(c4, c1, 0.3);
            _relativeList.Add(relative41);
            DrawLine(relative41);

            RefreshRelValue();
            DrawAllGraph();
        }
        private void SetMatrix()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = _conceptList.Count;
            dataGridView1.RowHeadersWidth = 50;

            for (int i = 0; i < _conceptList.Count; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                //dataGridView1.Columns[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.Columns[i].HeaderCell.Value = _conceptList[i].Id.ToString();
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < _conceptList.Count; i++)
            {
                dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.Rows[i].HeaderCell.Value = _conceptList[i].Id.ToString();
            }
            for (int i = 0; i < _conceptList.Count; i++)
            {
                dataGridView1[i, i].Value = 0;
            }
            RefreshRelValue();
        }
        private void RefreshRelValue()
        {
            //for(int i=0;i<_conceptList.Count;i++)
            //{
            //    for (int j = 0; j < _conceptList.Count; j++)
            //    {
            //        dataGridView1[rel._Concept1.Id - 1, rel._Concept2.Id - 1].Value = rel.Value;
            //    }
            //} dataGridView1.Rows[i].HeaderCell.Value
            foreach (var rel in _relativeList)
            {

                var colId = 0;
                var rowId = 0;

                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    if (rel._Concept1.Id == Convert.ToInt32(c.HeaderCell.Value))
                        colId = c.Index;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (rel._Concept2.Id == Convert.ToInt32(r.HeaderCell.Value))
                        rowId = r.Index;
                }

                dataGridView1[colId, rowId].Value = rel.Value != 0 ? rel.Value : (double?)null;
            }
        }

        private void sbAddRel_Click(object sender, EventArgs e)
        {
            try
            {
                //var relative = new Relative();
                //if (!fmRelativeEdit.Execute(relative, _conceptList))
                //    return;

                //_relativeList.Add(relative);
                //dataGridView1[relative._Concept1.Id - 1, relative._Concept2.Id - 1].Value = relative.Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                var concept1Id = 0;
                var concept2Id = 0;

                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    if (e.ColumnIndex == c.Index)
                        concept1Id = Convert.ToInt32(c.HeaderCell.Value);
                }
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (e.RowIndex == r.Index)
                        concept2Id = Convert.ToInt32(r.HeaderCell.Value);
                }


                var _oldRelative = _relativeList.FirstOrDefault(g => ((g._Concept1.Id == concept1Id) && (g._Concept2.Id == concept2Id)));

                if (_oldRelative == null)
                {
                    var relative = new Relative();

                    if (!fmRelativeEdit.Execute(relative, concept1Id, concept2Id, _conceptList))
                        return;

                    if (relative.Value == 0)
                        return;

                    _relativeList.Add(relative);
                    DrawLine(relative);

                }
                else
                {
                    if (!fmRelativeEdit.Execute(_oldRelative, _conceptList))
                        return;

                    if (_oldRelative.Value == 0)
                    {
                        Lines.Remove(Lines.FirstOrDefault(g => ((g.V1.Name == _oldRelative._Concept1.Id.ToString()) || (g.V2.Name == _oldRelative._Concept2.Id.ToString()))));
                        RefreshRelValue();
                        _relativeList.Remove(_oldRelative);
                        DrawAllGraph();
                        return;
                    }

                    foreach (var l in Lines)
                    {
                        if (l.V1.Name == _oldRelative._Concept1.Id.ToString() && l.V2.Name == _oldRelative._Concept2.Id.ToString())
                            l.Weight = _oldRelative.Value;
                    }
                }
                RefreshRelValue();
                DrawAllGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DrawLine(Relative relative)
        {
            Top top1 = new Top();
            Top top2 = new Top();
            foreach (var t in Tops)
            {
                if (t.Name == relative._Concept1.Id.ToString())
                    top1 = t;
                if (t.Name == relative._Concept2.Id.ToString())
                    top2 = t;
            }

            var line = new Line(top1, top2, relative.Value);
            Lines.Add(line);
        }

        private int Iteration { get { return Convert.ToInt32(seIteration.EditValue); } }
        private void sbStartSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                var mas = Dymanic();

                var conDelta = Convert.ToInt32(lueConceptDelta.EditValue);
                var stepIter = Convert.ToInt32(seStepDelta.EditValue);
                var delta = Convert.ToDouble(seDeltaConcept.EditValue);
                chartControl1.Series.Clear();
                var col = mas.GetLength(0);
                var row = mas.GetLength(1);
                dataGridView2.ColumnCount = col;
                dataGridView2.RowCount = row;
                for (int i = 0; i < col; i++)
                {
                    dataGridView2.Columns[i].HeaderCell.Value = i.ToString();
                    for (int j = 0; j < row; j++)
                    {
                        if (i == 0)
                        {
                            dataGridView2.Rows[j].HeaderCell.Value = _conceptList[j].Name;
                            dataGridView2.RowHeadersWidth = 110;
                            var seria = new Series(_conceptList[j].Name, ViewType.Line);
                            seria.View.Color = Tops[j].Color;
                            seria.Points.Add(new SeriesPoint(i, mas[i, j]));
                            chartControl1.Series.Add(seria);
                            seria.ArgumentScaleType = ScaleType.Numerical;

                            ((LineSeriesView)seria.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                            ((LineSeriesView)seria.View).LineMarkerOptions.Kind = MarkerKind.Star;
                            ((LineSeriesView)seria.View).LineStyle.DashStyle = DashStyle.Solid;
                        }
                        if (ceDelta.Checked && dataGridView2.Rows[j].HeaderCell.Value.ToString() == _conceptList.FirstOrDefault(g => g.Id == conDelta).Name && stepIter == i)
                        {
                            mas[i, j] += delta;

                        }

                        if (mas[i, j] > 1)
                            mas[i, j] = mas[i, j] * 0.1;
                        if (mas[i, j] < -1)
                            mas[i, j] = mas[i, j] * 0.1;
                        dataGridView2[i, j].Value = mas[i, j];
                        chartControl1.Series[j].Points.Add(new SeriesPoint(i, mas[i, j]));
                    }
                    //k = 0;
                    //while(k<1000)
                    //{
                    //    k++;
                    //}
                }
                

                //for (int j = 0; j < row; j++)
                //{
                //    var seria = new Series(_conceptList[j].Name, ViewType.Line);
                //    seria.View.Color = Tops[j].Color;
                //    for (int i = 0; i < col; i++)
                //    {
                //        seria.Points.Add(new SeriesPoint(i, mas[i, j]));
                //    }
                //    chartControl1.Series.Add(seria);
                //    seria.ArgumentScaleType = ScaleType.Numerical;
                    
                //    ((LineSeriesView)seria.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                //    ((LineSeriesView)seria.View).LineMarkerOptions.Kind = MarkerKind.Star;
                //    ((LineSeriesView)seria.View).LineStyle.DashStyle = DashStyle.Solid;
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double[,] Dymanic()
        {
            var matrixDegree = new double[Iteration, _conceptList.Count];


            for (int j = 0; j < _conceptList.Count; j++)
            {
                for (int i = 0; i < Iteration; i++)
                {
                    if (i == 0)
                    {
                        matrixDegree[i, j] = _conceptList[j].DegreeOfBelonging;
                        continue;
                    }



                    var _otherConceptValue = 0.0;
                    var inputList = _relativeList.Where(g => g._Concept2.Id == _conceptList[j].Id).ToList();
                    foreach (var con in inputList)
                    {
                        _otherConceptValue += con.Value * con._Concept1.DegreeOfBelonging;
                    }

                    var _myConceptValue = 0.0;
                    var outputList = _relativeList.Where(g => g._Concept1.Id == _conceptList[j].Id).ToList();
                    foreach (var con in outputList)
                    {
                        _myConceptValue += con.Value * con._Concept2.DegreeOfBelonging;
                    }
                    var temp = matrixDegree[i - 1, j] + _otherConceptValue - _myConceptValue;
                    matrixDegree[i, j] = ((temp < -1) || (temp > 1)) ? temp * 0.1 : temp;

                }
            }

            return matrixDegree;
        }

        private void seIteration_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueConceptDelta_EditValueChanged(object sender, EventArgs e)
        {


        }
        private void VisibleDelta()
        {
            if (ceDelta.Checked)
            {
                lciConceptDelta.Visibility = LayoutVisibility.Always;
                lciStepDelta.Visibility = LayoutVisibility.Always;
                lciDelta.Visibility = LayoutVisibility.Always;
                lueConceptDelta.Properties.DataSource = _conceptList;
            }
            else
            {
                lciConceptDelta.Visibility = LayoutVisibility.Never;
                lciStepDelta.Visibility = LayoutVisibility.Never;
                lciDelta.Visibility = LayoutVisibility.Never;
            }
        }
        private void ceDelta_CheckedChanged(object sender, EventArgs e)
        {
            VisibleDelta();
        }
    }
}
