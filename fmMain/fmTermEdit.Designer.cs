namespace fmMain
{
    partial class fmTermEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTermEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.seX1 = new DevExpress.XtraEditors.SpinEdit();
            this.lciX1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.seX2 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.seX3 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.seX4 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOK = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbOK);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Controls.Add(this.seX4);
            this.layoutControl1.Controls.Add(this.seX3);
            this.layoutControl1.Controls.Add(this.seX2);
            this.layoutControl1.Controls.Add(this.seX1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(348, 215);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciX1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.lciCancel,
            this.lciOK,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(348, 215);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // seX1
            // 
            this.seX1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seX1.Location = new System.Drawing.Point(89, 36);
            this.seX1.Name = "seX1";
            this.seX1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seX1.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seX1.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seX1.Size = new System.Drawing.Size(247, 20);
            this.seX1.StyleController = this.layoutControl1;
            this.seX1.TabIndex = 4;
            this.seX1.EditValueChanged += new System.EventHandler(this.seX1_EditValueChanged);
            // 
            // lciX1
            // 
            this.lciX1.Control = this.seX1;
            this.lciX1.Location = new System.Drawing.Point(0, 24);
            this.lciX1.Name = "lciX1";
            this.lciX1.Size = new System.Drawing.Size(328, 24);
            this.lciX1.Text = "X1";
            this.lciX1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(328, 49);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // seX2
            // 
            this.seX2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seX2.Location = new System.Drawing.Point(89, 60);
            this.seX2.Name = "seX2";
            this.seX2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seX2.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seX2.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seX2.Size = new System.Drawing.Size(247, 20);
            this.seX2.StyleController = this.layoutControl1;
            this.seX2.TabIndex = 5;
            this.seX2.EditValueChanged += new System.EventHandler(this.seX1_EditValueChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seX2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem2.Text = "X2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // seX3
            // 
            this.seX3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seX3.Location = new System.Drawing.Point(89, 84);
            this.seX3.Name = "seX3";
            this.seX3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seX3.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seX3.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seX3.Size = new System.Drawing.Size(247, 20);
            this.seX3.StyleController = this.layoutControl1;
            this.seX3.TabIndex = 6;
            this.seX3.EditValueChanged += new System.EventHandler(this.seX1_EditValueChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seX3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem3.Text = "X3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // seX4
            // 
            this.seX4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seX4.Location = new System.Drawing.Point(89, 108);
            this.seX4.Name = "seX4";
            this.seX4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seX4.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seX4.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seX4.Size = new System.Drawing.Size(247, 20);
            this.seX4.StyleController = this.layoutControl1;
            this.seX4.TabIndex = 7;
            this.seX4.EditValueChanged += new System.EventHandler(this.seX1_EditValueChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seX4;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem4.Text = "X4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(89, 12);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(247, 20);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 8;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem1.Text = "Наименование";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 169);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(120, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sbOK
            // 
            this.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOK.ImageOptions.Image = global::fmMain.Properties.Resources.Save;
            this.sbOK.Location = new System.Drawing.Point(132, 181);
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
            this.sbCancel.Location = new System.Drawing.Point(236, 181);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(100, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 9;
            this.sbCancel.Text = "Отменить";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.Location = new System.Drawing.Point(224, 169);
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
            this.lciOK.Location = new System.Drawing.Point(120, 169);
            this.lciOK.MaxSize = new System.Drawing.Size(104, 26);
            this.lciOK.MinSize = new System.Drawing.Size(104, 26);
            this.lciOK.Name = "lciOK";
            this.lciOK.Size = new System.Drawing.Size(104, 26);
            this.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOK.TextSize = new System.Drawing.Size(0, 0);
            this.lciOK.TextVisible = false;
            // 
            // fmTermEdit
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(348, 215);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmTermEdit";
            this.Text = "Окно редактирования терма";
            this.Load += new System.EventHandler(this.fmTermEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.SpinEdit seX4;
        private DevExpress.XtraEditors.SpinEdit seX3;
        private DevExpress.XtraEditors.SpinEdit seX2;
        private DevExpress.XtraEditors.SpinEdit seX1;
        private DevExpress.XtraLayout.LayoutControlItem lciX1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciOK;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}