using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using fmMain.Classes;

namespace fmMain
{
    public partial class fmConceptEdit : DevExpress.XtraEditors.XtraForm
    {
        public fmConceptEdit()
        {
            InitializeComponent();
        }
        private Concept _concept { get; set; }
        private List<Term> _termList { get; set; }

        public static bool Execute(Concept concept)
        {
            using (var frm = new fmConceptEdit())
            {
                frm._concept = concept;

                return frm.ShowDialog() == DialogResult.OK;
            }
            
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbOK_Click(object sender, EventArgs e)
        {
            try
            {
                _concept.Name = teName.Text;
                _concept.DegreeOfBelonging = Convert.ToDouble(seDegree.EditValue);
                _concept.TermList = _termList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmConceptEdit_Load(object sender, EventArgs e)
        {
            try
            {
                
                seDegree.EditValue = _concept.DegreeOfBelonging;

                if (_concept.TermList == null)
                    _concept.TermList = new List<Term>();

                _termList = _concept.TermList;
                gcTerm.DataSource = _termList;

                Validate();
                teName.Text = _concept.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Добавление терма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbAddTerm_Click(object sender, EventArgs e)
        {
            try
            {
                var term = new Term();
                if (!fmTermEdit.Execute(term))
                    return;

                _termList.Add(term);
                gcTerm.DataSource = _termList;
                gvTerm.RefreshData();
                Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        
        /// <summary>
        /// Изменение терма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbEditTerm_Click(object sender, EventArgs e)
        {
            try
            {
                var term = this.gvTerm.GetFocusedRow() as Term;

                if (term == null)
                    return;

                if (!fmTermEdit.Execute(term))
                    return;

                var newterm = this.gvTerm.GetFocusedRow() as Term;
                
                foreach(var t in _termList)
                {
                    if(t.Name == newterm.Name && t.X1 == newterm.X1 && t.X2 == newterm.X2 && t.X3 == newterm.X3 && t.X4 == newterm.X4)
                    {
                        t.Name = term.Name;
                        t.X1 = term.X1;
                        t.X2 = term.X2;
                        t.X3 = term.X3;
                        t.X4 = term.X4;
                    }
                }

                gcTerm.DataSource = _termList;
                gvTerm.RefreshData();
                Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Удаление терма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbDeleteTerm_Click(object sender, EventArgs e)
        {
            try
            {
                var term = this.gvTerm.GetFocusedRow() as Term;

                if (term == null)
                    return;

                _termList.Remove(term);
                gcTerm.DataSource = _termList;
                gvTerm.RefreshData();
                Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teName_EditValueChanged(object sender, EventArgs e)
        {
            Validate();
        }
        private void Validate()
        {
            sbOK.Enabled = (teName.Text.Length > 0) && (_termList.Count > 0);
        }
    }
}