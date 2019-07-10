namespace fmMain
{
    partial class fmConceptEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConceptEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.seDegree = new DevExpress.XtraEditors.SpinEdit();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbDeleteTerm = new DevExpress.XtraEditors.SimpleButton();
            this.sbEditTerm = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddTerm = new DevExpress.XtraEditors.SimpleButton();
            this.gcTerm = new DevExpress.XtraGrid.GridControl();
            this.gvTerm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolX2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolX3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolX4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTermList = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOK = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDegree = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seDegree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTermList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.seDegree);
            this.layoutControl1.Controls.Add(this.sbOK);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.sbDeleteTerm);
            this.layoutControl1.Controls.Add(this.sbEditTerm);
            this.layoutControl1.Controls.Add(this.sbAddTerm);
            this.layoutControl1.Controls.Add(this.gcTerm);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgMain;
            this.layoutControl1.Size = new System.Drawing.Size(408, 339);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // seDegree
            // 
            this.seDegree.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDegree.Location = new System.Drawing.Point(147, 36);
            this.seDegree.Name = "seDegree";
            this.seDegree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDegree.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seDegree.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDegree.Size = new System.Drawing.Size(249, 20);
            this.seDegree.StyleController = this.layoutControl1;
            this.seDegree.TabIndex = 11;
            this.seDegree.EditValueChanged += new System.EventHandler(this.teName_EditValueChanged);
            // 
            // sbOK
            // 
            this.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOK.ImageOptions.Image = global::fmMain.Properties.Resources.Save;
            this.sbOK.Location = new System.Drawing.Point(192, 305);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(100, 22);
            this.sbOK.StyleController = this.layoutControl1;
            this.sbOK.TabIndex = 10;
            this.sbOK.Text = "Сохранить";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.ImageOptions.Image = global::fmMain.Properties.Resources.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(296, 305);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(100, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 9;
            this.sbCancel.Text = "Отменить";
            // 
            // sbDeleteTerm
            // 
            this.sbDeleteTerm.ImageOptions.Image = global::fmMain.Properties.Resources.Delete;
            this.sbDeleteTerm.Location = new System.Drawing.Point(220, 279);
            this.sbDeleteTerm.Name = "sbDeleteTerm";
            this.sbDeleteTerm.Size = new System.Drawing.Size(100, 22);
            this.sbDeleteTerm.StyleController = this.layoutControl1;
            this.sbDeleteTerm.TabIndex = 8;
            this.sbDeleteTerm.Text = "Удалить";
            this.sbDeleteTerm.Click += new System.EventHandler(this.sbDeleteTerm_Click);
            // 
            // sbEditTerm
            // 
            this.sbEditTerm.ImageOptions.Image = global::fmMain.Properties.Resources.Edit;
            this.sbEditTerm.Location = new System.Drawing.Point(116, 279);
            this.sbEditTerm.Name = "sbEditTerm";
            this.sbEditTerm.Size = new System.Drawing.Size(100, 22);
            this.sbEditTerm.StyleController = this.layoutControl1;
            this.sbEditTerm.TabIndex = 7;
            this.sbEditTerm.Text = "Изменить...";
            this.sbEditTerm.Click += new System.EventHandler(this.sbEditTerm_Click);
            // 
            // sbAddTerm
            // 
            this.sbAddTerm.ImageOptions.Image = global::fmMain.Properties.Resources.Add;
            this.sbAddTerm.Location = new System.Drawing.Point(12, 279);
            this.sbAddTerm.Name = "sbAddTerm";
            this.sbAddTerm.Size = new System.Drawing.Size(100, 22);
            this.sbAddTerm.StyleController = this.layoutControl1;
            this.sbAddTerm.TabIndex = 6;
            this.sbAddTerm.Text = "Добавить...";
            this.sbAddTerm.Click += new System.EventHandler(this.sbAddTerm_Click);
            // 
            // gcTerm
            // 
            this.gcTerm.Location = new System.Drawing.Point(12, 68);
            this.gcTerm.MainView = this.gvTerm;
            this.gcTerm.Name = "gcTerm";
            this.gcTerm.Size = new System.Drawing.Size(384, 207);
            this.gcTerm.TabIndex = 5;
            this.gcTerm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTerm});
            // 
            // gvTerm
            // 
            this.gvTerm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolName,
            this.gcolX1,
            this.gcolX2,
            this.gcolX3,
            this.gcolX4});
            this.gvTerm.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTerm.GridControl = this.gcTerm;
            this.gvTerm.Name = "gvTerm";
            this.gvTerm.OptionsView.ShowGroupPanel = false;
            this.gvTerm.OptionsView.ShowViewCaption = true;
            this.gvTerm.ViewCaption = "Список термов";
            // 
            // gcolName
            // 
            this.gcolName.AppearanceCell.Options.UseTextOptions = true;
            this.gcolName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolName.Caption = "Название";
            this.gcolName.FieldName = "Name";
            this.gcolName.Name = "gcolName";
            this.gcolName.OptionsColumn.AllowEdit = false;
            this.gcolName.OptionsColumn.AllowFocus = false;
            this.gcolName.OptionsColumn.ReadOnly = true;
            this.gcolName.Visible = true;
            this.gcolName.VisibleIndex = 0;
            // 
            // gcolX1
            // 
            this.gcolX1.AppearanceCell.Options.UseTextOptions = true;
            this.gcolX1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX1.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolX1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX1.Caption = "X1";
            this.gcolX1.FieldName = "X1";
            this.gcolX1.Name = "gcolX1";
            this.gcolX1.OptionsColumn.AllowEdit = false;
            this.gcolX1.OptionsColumn.AllowFocus = false;
            this.gcolX1.OptionsColumn.ReadOnly = true;
            this.gcolX1.Visible = true;
            this.gcolX1.VisibleIndex = 1;
            // 
            // gcolX2
            // 
            this.gcolX2.AppearanceCell.Options.UseTextOptions = true;
            this.gcolX2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX2.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolX2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX2.Caption = "X2";
            this.gcolX2.FieldName = "X2";
            this.gcolX2.Name = "gcolX2";
            this.gcolX2.OptionsColumn.AllowEdit = false;
            this.gcolX2.OptionsColumn.AllowFocus = false;
            this.gcolX2.OptionsColumn.ReadOnly = true;
            this.gcolX2.Visible = true;
            this.gcolX2.VisibleIndex = 2;
            // 
            // gcolX3
            // 
            this.gcolX3.AppearanceCell.Options.UseTextOptions = true;
            this.gcolX3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX3.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolX3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX3.Caption = "X3";
            this.gcolX3.FieldName = "X3";
            this.gcolX3.Name = "gcolX3";
            this.gcolX3.OptionsColumn.AllowEdit = false;
            this.gcolX3.OptionsColumn.AllowFocus = false;
            this.gcolX3.OptionsColumn.ReadOnly = true;
            this.gcolX3.Visible = true;
            this.gcolX3.VisibleIndex = 3;
            // 
            // gcolX4
            // 
            this.gcolX4.AppearanceCell.Options.UseTextOptions = true;
            this.gcolX4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX4.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolX4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolX4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolX4.Caption = "X4";
            this.gcolX4.FieldName = "X4";
            this.gcolX4.Name = "gcolX4";
            this.gcolX4.OptionsColumn.AllowEdit = false;
            this.gcolX4.OptionsColumn.AllowFocus = false;
            this.gcolX4.OptionsColumn.ReadOnly = true;
            this.gcolX4.Visible = true;
            this.gcolX4.VisibleIndex = 4;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(147, 12);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(249, 20);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 4;
            this.teName.EditValueChanged += new System.EventHandler(this.teName_EditValueChanged);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciName,
            this.lciTermList,
            this.emptySpaceItem1,
            this.lciAdd,
            this.lciEdit,
            this.lciDelete,
            this.emptySpaceItem2,
            this.lciCancel,
            this.lciOK,
            this.lciDegree});
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(408, 339);
            this.lcgMain.TextVisible = false;
            // 
            // lciName
            // 
            this.lciName.Control = this.teName;
            this.lciName.Location = new System.Drawing.Point(0, 0);
            this.lciName.Name = "lciName";
            this.lciName.Size = new System.Drawing.Size(388, 24);
            this.lciName.Text = "Название концепта";
            this.lciName.TextSize = new System.Drawing.Size(132, 13);
            // 
            // lciTermList
            // 
            this.lciTermList.Control = this.gcTerm;
            this.lciTermList.Location = new System.Drawing.Point(0, 48);
            this.lciTermList.Name = "lciTermList";
            this.lciTermList.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.lciTermList.Size = new System.Drawing.Size(388, 219);
            this.lciTermList.TextSize = new System.Drawing.Size(0, 0);
            this.lciTermList.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 293);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(180, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciAdd
            // 
            this.lciAdd.Control = this.sbAddTerm;
            this.lciAdd.Location = new System.Drawing.Point(0, 267);
            this.lciAdd.MaxSize = new System.Drawing.Size(104, 26);
            this.lciAdd.MinSize = new System.Drawing.Size(104, 26);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(104, 26);
            this.lciAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // lciEdit
            // 
            this.lciEdit.Control = this.sbEditTerm;
            this.lciEdit.Location = new System.Drawing.Point(104, 267);
            this.lciEdit.MaxSize = new System.Drawing.Size(104, 26);
            this.lciEdit.MinSize = new System.Drawing.Size(104, 26);
            this.lciEdit.Name = "lciEdit";
            this.lciEdit.Size = new System.Drawing.Size(104, 26);
            this.lciEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciEdit.TextVisible = false;
            // 
            // lciDelete
            // 
            this.lciDelete.Control = this.sbDeleteTerm;
            this.lciDelete.Location = new System.Drawing.Point(208, 267);
            this.lciDelete.MaxSize = new System.Drawing.Size(104, 26);
            this.lciDelete.MinSize = new System.Drawing.Size(104, 26);
            this.lciDelete.Name = "lciDelete";
            this.lciDelete.Size = new System.Drawing.Size(104, 26);
            this.lciDelete.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciDelete.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(312, 267);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(76, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.Location = new System.Drawing.Point(284, 293);
            this.lciCancel.MaxSize = new System.Drawing.Size(104, 26);
            this.lciCancel.MinSize = new System.Drawing.Size(104, 26);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(104, 26);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // lciOK
            // 
            this.lciOK.Control = this.sbOK;
            this.lciOK.Location = new System.Drawing.Point(180, 293);
            this.lciOK.MaxSize = new System.Drawing.Size(104, 26);
            this.lciOK.MinSize = new System.Drawing.Size(104, 26);
            this.lciOK.Name = "lciOK";
            this.lciOK.Size = new System.Drawing.Size(104, 26);
            this.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOK.TextSize = new System.Drawing.Size(0, 0);
            this.lciOK.TextVisible = false;
            // 
            // lciDegree
            // 
            this.lciDegree.Control = this.seDegree;
            this.lciDegree.Location = new System.Drawing.Point(0, 24);
            this.lciDegree.Name = "lciDegree";
            this.lciDegree.Size = new System.Drawing.Size(388, 24);
            this.lciDegree.Text = "Степень принадлежности";
            this.lciDegree.TextSize = new System.Drawing.Size(132, 13);
            // 
            // fmConceptEdit
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(408, 339);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmConceptEdit";
            this.Text = "Окно редактирования концепта";
            this.Load += new System.EventHandler(this.fmConceptEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seDegree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTermList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDegree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.SimpleButton sbDeleteTerm;
        private DevExpress.XtraEditors.SimpleButton sbEditTerm;
        private DevExpress.XtraEditors.SimpleButton sbAddTerm;
        private DevExpress.XtraGrid.GridControl gcTerm;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTerm;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem lciName;
        private DevExpress.XtraLayout.LayoutControlItem lciTermList;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciOK;
        private DevExpress.XtraGrid.Columns.GridColumn gcolName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolX1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolX2;
        private DevExpress.XtraGrid.Columns.GridColumn gcolX3;
        private DevExpress.XtraGrid.Columns.GridColumn gcolX4;
        private DevExpress.XtraEditors.SpinEdit seDegree;
        private DevExpress.XtraLayout.LayoutControlItem lciDegree;
    }
}