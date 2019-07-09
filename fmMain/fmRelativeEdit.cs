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
    public partial class fmRelativeEdit : DevExpress.XtraEditors.XtraForm
    {
        public fmRelativeEdit()
        {
            InitializeComponent();
        }
        private Relative _relative { get; set; }
        private List<Concept> _conceptList { get; set; }
        public static bool Execute(Relative relative, int concept1Id,int concept2Id, List<Concept> conceptList)
        {
            using (var frm = new fmRelativeEdit())
            {
                relative._Concept1 = conceptList.FirstOrDefault(g => g.Id == concept1Id);
                relative._Concept2 = conceptList.FirstOrDefault(g => g.Id == concept2Id);
                frm._relative = relative;
                frm._conceptList = conceptList;
                if (conceptList == null)
                    frm._conceptList = new List<Concept>();

                return frm.ShowDialog() == DialogResult.OK;
            }
        }

        public static bool Execute(Relative relative,  List<Concept> conceptList)
        {
            using (var frm = new fmRelativeEdit())
            {
                frm._relative = relative;
                frm._conceptList = conceptList;
                if (conceptList == null)
                    frm._conceptList = new List<Concept>();

                return frm.ShowDialog() == DialogResult.OK;
            }
        }

        private void fmRelativeEdit_Load(object sender, EventArgs e)
        {
            try
            {
                seValue.EditValue = _relative.Value;
                lueConcept1.Properties.DataSource = _conceptList;
                lueConcept2.Properties.DataSource = _conceptList;
                lueConcept1.EditValue = _relative._Concept1.Id;
                lueConcept2.EditValue = _relative._Concept2.Id;
                Validate();
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
                _relative.Value = Convert.ToDouble(seValue.EditValue);
                _relative._Concept1 = _conceptList.FirstOrDefault(g=>g.Id == Convert.ToInt32(lueConcept1.EditValue));
                _relative._Concept2 = _conceptList.FirstOrDefault(g => g.Id == Convert.ToInt32(lueConcept2.EditValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Validate()
        {
            sbOK.Enabled = (lueConcept1.EditValue != null) && (lueConcept2.EditValue != null) &&
                            (lueConcept1.EditValue != lueConcept2.EditValue);
        }

        private void lueConcept1_EditValueChanged(object sender, EventArgs e)
        {
            Validate();
        }
    }
}