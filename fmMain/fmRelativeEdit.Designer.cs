namespace fmMain
{
    partial class fmRelativeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelativeEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.seValue = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.lciOK = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lueConcept1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lciConcept1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueConcept2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lciConcept2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueConcept1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcept1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueConcept2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcept2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueConcept2);
            this.layoutControl1.Controls.Add(this.lueConcept1);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.sbOK);
            this.layoutControl1.Controls.Add(this.seValue);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(499, 108);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCancel,
            this.lciOK,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.lciConcept1,
            this.lciConcept2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(499, 108);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(479, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // seValue
            // 
            this.seValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seValue.Location = new System.Drawing.Point(87, 12);
            this.seValue.Name = "seValue";
            this.seValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seValue.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seValue.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seValue.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.seValue.Size = new System.Drawing.Size(50, 20);
            this.seValue.StyleController = this.layoutControl1;
            this.seValue.TabIndex = 6;
            this.seValue.EditValueChanged += new System.EventHandler(this.lueConcept1_EditValueChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seValue;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Сила влияния";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // sbOK
            // 
            this.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOK.ImageOptions.Image = global::fmMain.Properties.Resources.Save;
            this.sbOK.Location = new System.Drawing.Point(283, 74);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(100, 22);
            this.sbOK.StyleController = this.layoutControl1;
            this.sbOK.TabIndex = 7;
            this.sbOK.Text = "Сохранить";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // lciOK
            // 
            this.lciOK.Control = this.sbOK;
            this.lciOK.Location = new System.Drawing.Point(271, 62);
            this.lciOK.MaxSize = new System.Drawing.Size(104, 26);
            this.lciOK.MinSize = new System.Drawing.Size(104, 26);
            this.lciOK.Name = "lciOK";
            this.lciOK.Size = new System.Drawing.Size(104, 26);
            this.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOK.TextSize = new System.Drawing.Size(0, 0);
            this.lciOK.TextVisible = false;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.ImageOptions.Image = global::fmMain.Properties.Resources.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(387, 74);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(100, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 8;
            this.sbCancel.Text = "Отменить";
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.Location = new System.Drawing.Point(375, 62);
            this.lciCancel.MaxSize = new System.Drawing.Size(104, 26);
            this.lciCancel.MinSize = new System.Drawing.Size(104, 26);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(104, 26);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 62);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(271, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lueConcept1
            // 
            this.lueConcept1.Enabled = false;
            this.lueConcept1.Location = new System.Drawing.Point(194, 12);
            this.lueConcept1.Name = "lueConcept1";
            this.lueConcept1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueConcept1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Концепт 1")});
            this.lueConcept1.Properties.DisplayMember = "Name";
            this.lueConcept1.Properties.ValueMember = "Id";
            this.lueConcept1.Size = new System.Drawing.Size(118, 20);
            this.lueConcept1.StyleController = this.layoutControl1;
            this.lueConcept1.TabIndex = 9;
            this.lueConcept1.EditValueChanged += new System.EventHandler(this.lueConcept1_EditValueChanged);
            // 
            // lciConcept1
            // 
            this.lciConcept1.Control = this.lueConcept1;
            this.lciConcept1.Location = new System.Drawing.Point(129, 0);
            this.lciConcept1.Name = "lciConcept1";
            this.lciConcept1.Size = new System.Drawing.Size(175, 24);
            this.lciConcept1.Text = "концепта";
            this.lciConcept1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciConcept1.TextSize = new System.Drawing.Size(48, 13);
            this.lciConcept1.TextToControlDistance = 5;
            // 
            // lueConcept2
            // 
            this.lueConcept2.Enabled = false;
            this.lueConcept2.Location = new System.Drawing.Point(378, 12);
            this.lueConcept2.Name = "lueConcept2";
            this.lueConcept2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueConcept2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Концепт 2")});
            this.lueConcept2.Properties.DisplayMember = "Name";
            this.lueConcept2.Properties.ValueMember = "Id";
            this.lueConcept2.Size = new System.Drawing.Size(109, 20);
            this.lueConcept2.StyleController = this.layoutControl1;
            this.lueConcept2.TabIndex = 10;
            this.lueConcept2.EditValueChanged += new System.EventHandler(this.lueConcept1_EditValueChanged);
            // 
            // lciConcept2
            // 
            this.lciConcept2.Control = this.lueConcept2;
            this.lciConcept2.Location = new System.Drawing.Point(304, 0);
            this.lciConcept2.Name = "lciConcept2";
            this.lciConcept2.Size = new System.Drawing.Size(175, 24);
            this.lciConcept2.Text = "на концепт";
            this.lciConcept2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciConcept2.TextSize = new System.Drawing.Size(57, 13);
            this.lciConcept2.TextToControlDistance = 5;
            // 
            // fmRelativeEdit
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(499, 108);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmRelativeEdit";
            this.Text = "Окно редактирования отношений между концептами";
            this.Load += new System.EventHandler(this.fmRelativeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueConcept1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcept1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueConcept2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcept2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.SpinEdit seValue;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciOK;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lueConcept2;
        private DevExpress.XtraEditors.LookUpEdit lueConcept1;
        private DevExpress.XtraLayout.LayoutControlItem lciConcept1;
        private DevExpress.XtraLayout.LayoutControlItem lciConcept2;
    }
}