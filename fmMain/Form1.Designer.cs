namespace fmMain
{
    partial class fmMain
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sbStart = new DevExpress.XtraEditors.SimpleButton();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciStartButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcConcept = new DevExpress.XtraGrid.GridControl();
            this.gvConcept = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDegree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gcolNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgInitConcept = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgChart = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInitConcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.pictureBox1);
            this.lcMain.Controls.Add(this.sbDelete);
            this.lcMain.Controls.Add(this.gcConcept);
            this.lcMain.Controls.Add(this.sbStart);
            this.lcMain.Controls.Add(this.sbEdit);
            this.lcMain.Controls.Add(this.sbAdd);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(410, 149, 650, 400);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(793, 449);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(24, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 353);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // sbStart
            // 
            this.sbStart.Location = new System.Drawing.Point(554, 415);
            this.sbStart.Name = "sbStart";
            this.sbStart.Size = new System.Drawing.Size(227, 22);
            this.sbStart.StyleController = this.lcMain;
            this.sbStart.TabIndex = 6;
            this.sbStart.Text = "Старт";
            this.sbStart.Click += new System.EventHandler(this.sbStart_Click);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciStartButton,
            this.tabbedControlGroup1,
            this.emptySpaceItem1});
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(793, 449);
            this.lcgMain.TextVisible = false;
            // 
            // lciStartButton
            // 
            this.lciStartButton.Control = this.sbStart;
            this.lciStartButton.Location = new System.Drawing.Point(542, 403);
            this.lciStartButton.Name = "lciStartButton";
            this.lciStartButton.Size = new System.Drawing.Size(231, 26);
            this.lciStartButton.TextSize = new System.Drawing.Size(0, 0);
            this.lciStartButton.TextVisible = false;
            // 
            // gcConcept
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gcConcept.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcConcept.Location = new System.Drawing.Point(402, 46);
            this.gcConcept.MainView = this.gvConcept;
            this.gcConcept.Name = "gcConcept";
            this.gcConcept.Size = new System.Drawing.Size(367, 327);
            this.gcConcept.TabIndex = 2;
            this.gcConcept.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConcept});
            // 
            // gvConcept
            // 
            this.gvConcept.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolNumber,
            this.gcolName,
            this.gcolDegree});
            this.gvConcept.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvConcept.GridControl = this.gcConcept;
            this.gvConcept.Name = "gvConcept";
            this.gvConcept.OptionsView.ShowDetailButtons = false;
            this.gvConcept.OptionsView.ShowGroupPanel = false;
            this.gvConcept.OptionsView.ShowViewCaption = true;
            this.gvConcept.ViewCaption = "Концепты";
            // 
            // gcolName
            // 
            this.gcolName.AppearanceCell.Options.UseTextOptions = true;
            this.gcolName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolName.Caption = "Наименование";
            this.gcolName.FieldName = "Name";
            this.gcolName.Name = "gcolName";
            this.gcolName.OptionsColumn.AllowEdit = false;
            this.gcolName.OptionsColumn.AllowFocus = false;
            this.gcolName.OptionsColumn.ReadOnly = true;
            this.gcolName.Visible = true;
            this.gcolName.VisibleIndex = 1;
            this.gcolName.Width = 163;
            // 
            // gcolDegree
            // 
            this.gcolDegree.AppearanceCell.Options.UseTextOptions = true;
            this.gcolDegree.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolDegree.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolDegree.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolDegree.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolDegree.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolDegree.Caption = "Степень принадлежности";
            this.gcolDegree.FieldName = "DegreeOfBelonging";
            this.gcolDegree.Name = "gcolDegree";
            this.gcolDegree.OptionsColumn.AllowEdit = false;
            this.gcolDegree.OptionsColumn.AllowFocus = false;
            this.gcolDegree.OptionsColumn.ReadOnly = true;
            this.gcolDegree.Visible = true;
            this.gcolDegree.VisibleIndex = 2;
            this.gcolDegree.Width = 164;
            // 
            // sbAdd
            // 
            this.sbAdd.ImageOptions.Image = global::fmMain.Properties.Resources.Add;
            this.sbAdd.Location = new System.Drawing.Point(402, 377);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(100, 22);
            this.sbAdd.StyleController = this.lcMain;
            this.sbAdd.TabIndex = 3;
            this.sbAdd.Text = "Добавить...";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbEdit
            // 
            this.sbEdit.ImageOptions.Image = global::fmMain.Properties.Resources.Edit;
            this.sbEdit.Location = new System.Drawing.Point(506, 377);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(100, 22);
            this.sbEdit.StyleController = this.lcMain;
            this.sbEdit.TabIndex = 4;
            this.sbEdit.Text = "Изменить...";
            this.sbEdit.Click += new System.EventHandler(this.sbEdit_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.ImageOptions.Image = global::fmMain.Properties.Resources.Delete;
            this.sbDelete.Location = new System.Drawing.Point(610, 377);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(100, 22);
            this.sbDelete.StyleController = this.lcMain;
            this.sbDelete.TabIndex = 5;
            this.sbDelete.Text = "Удалить";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 403);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(542, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gcolNumber
            // 
            this.gcolNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.gcolNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gcolNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcolNumber.Caption = "№";
            this.gcolNumber.FieldName = "Id";
            this.gcolNumber.Name = "gcolNumber";
            this.gcolNumber.OptionsColumn.AllowEdit = false;
            this.gcolNumber.OptionsColumn.AllowFocus = false;
            this.gcolNumber.OptionsColumn.ReadOnly = true;
            this.gcolNumber.Visible = true;
            this.gcolNumber.VisibleIndex = 0;
            this.gcolNumber.Width = 30;
            // 
            // lciAdd
            // 
            this.lciAdd.Control = this.sbAdd;
            this.lciAdd.Location = new System.Drawing.Point(378, 331);
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
            this.lciEdit.Control = this.sbEdit;
            this.lciEdit.Location = new System.Drawing.Point(482, 331);
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
            this.lciDelete.Control = this.sbDelete;
            this.lciDelete.Location = new System.Drawing.Point(586, 331);
            this.lciDelete.MaxSize = new System.Drawing.Size(104, 26);
            this.lciDelete.MinSize = new System.Drawing.Size(104, 26);
            this.lciDelete.Name = "lciDelete";
            this.lciDelete.Size = new System.Drawing.Size(104, 26);
            this.lciDelete.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciDelete.TextVisible = false;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcConcept;
            this.lciGrid.Location = new System.Drawing.Point(378, 0);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(371, 331);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.lcgInitConcept;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(773, 403);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgInitConcept,
            this.lcgChart});
            // 
            // lcgInitConcept
            // 
            this.lcgInitConcept.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPicture,
            this.lciGrid,
            this.lciAdd,
            this.lciEdit,
            this.lciDelete,
            this.emptySpaceItem2});
            this.lcgInitConcept.Location = new System.Drawing.Point(0, 0);
            this.lcgInitConcept.Name = "lcgInitConcept";
            this.lcgInitConcept.Size = new System.Drawing.Size(749, 357);
            this.lcgInitConcept.Text = "Основные настройки";
            // 
            // lciPicture
            // 
            this.lciPicture.Control = this.pictureBox1;
            this.lciPicture.Location = new System.Drawing.Point(0, 0);
            this.lciPicture.Name = "lciPicture";
            this.lciPicture.Size = new System.Drawing.Size(378, 357);
            this.lciPicture.TextSize = new System.Drawing.Size(0, 0);
            this.lciPicture.TextVisible = false;
            // 
            // lcgChart
            // 
            this.lcgChart.Location = new System.Drawing.Point(0, 0);
            this.lcgChart.Name = "lcgChart";
            this.lcgChart.Size = new System.Drawing.Size(749, 357);
            this.lcgChart.Text = "График";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(690, 331);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(59, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 449);
            this.Controls.Add(this.lcMain);
            this.Name = "fmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInitConcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.SimpleButton sbStart;
        private DevExpress.XtraLayout.LayoutControlItem lciStartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gcConcept;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConcept;
        private DevExpress.XtraGrid.Columns.GridColumn gcolName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDegree;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraEditors.SimpleButton sbEdit;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolNumber;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInitConcept;
        private DevExpress.XtraLayout.LayoutControlItem lciPicture;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup lcgChart;
    }
}

