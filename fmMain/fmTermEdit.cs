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
    public partial class fmTermEdit : DevExpress.XtraEditors.XtraForm
    {
        public fmTermEdit()
        {
            InitializeComponent();
        }
        private Term _term { get; set; }

        public static bool Execute(Term term)
        {
            using (var frm = new fmTermEdit())
            {
                frm._term = term;

                return frm.ShowDialog() == DialogResult.OK;
            }
        }

        private void fmTermEdit_Load(object sender, EventArgs e)
        {
            try
            {
                teName.Text = _term.Name;
                seX1.EditValue = _term.X1;
                seX2.EditValue = _term.X2;
                seX3.EditValue = _term.X3;
                seX4.EditValue = _term.X4;

                sbOK.Enabled = ((Convert.ToDouble(seX1.EditValue) < Convert.ToDouble(seX2.EditValue)) &&
                           (Convert.ToDouble(seX2.EditValue) < Convert.ToDouble(seX3.EditValue)) &&
                           (Convert.ToDouble(seX3.EditValue) < Convert.ToDouble(seX4.EditValue)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            try
            {
                _term.Name = teName.Text;
                _term.X1 = Convert.ToDouble(seX1.EditValue);
                _term.X2 = Convert.ToDouble(seX2.EditValue);
                _term.X3 = Convert.ToDouble(seX3.EditValue);
                _term.X4 = Convert.ToDouble(seX4.EditValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {

        }

        private void seX1_EditValueChanged(object sender, EventArgs e)
        {
            sbOK.Enabled = ((Convert.ToDouble(seX1.EditValue) < Convert.ToDouble(seX2.EditValue)) &&
                           (Convert.ToDouble(seX2.EditValue) < Convert.ToDouble(seX3.EditValue)) &&
                           (Convert.ToDouble(seX3.EditValue) < Convert.ToDouble(seX4.EditValue)));
        }
    }
}