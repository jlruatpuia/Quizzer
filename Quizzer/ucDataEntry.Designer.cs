namespace Quizzer
{
    partial class ucDataEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDataEntry));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonDataEntry = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDelete});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonDataEntry});
            this.ribbonControl.Size = new System.Drawing.Size(750, 141);
            // 
            // bNew
            // 
            this.bNew.Caption = "New";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 1;
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 2;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDelete
            // 
            this.bDelete.Caption = "Delete";
            this.bDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelete.Glyph")));
            this.bDelete.Id = 3;
            this.bDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelete.LargeGlyph")));
            this.bDelete.Name = "bDelete";
            this.bDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDelete_ItemClick);
            // 
            // ribbonDataEntry
            // 
            this.ribbonDataEntry.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonDataEntry.MergeOrder = 0;
            this.ribbonDataEntry.Name = "ribbonDataEntry";
            this.ribbonDataEntry.Text = "Data Entry";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDelete);
            this.ribbonPageGroup1.MergeOrder = 0;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Question";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(750, 323);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colQTP,
            this.colQTN,
            this.colOP1,
            this.colOP2,
            this.colOP3,
            this.colOP4,
            this.colANS,
            this.colPTS,
            this.colSEC,
            this.colQID});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsBehavior.AutoExpandAllGroups = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colQTP, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colQTP
            // 
            this.colQTP.Caption = "Type";
            this.colQTP.FieldName = "QuestionType";
            this.colQTP.Name = "colQTP";
            this.colQTP.OptionsColumn.AllowEdit = false;
            this.colQTP.OptionsColumn.AllowFocus = false;
            this.colQTP.OptionsColumn.ReadOnly = true;
            this.colQTP.OptionsColumn.ShowCaption = false;
            this.colQTP.Visible = true;
            this.colQTP.VisibleIndex = 0;
            // 
            // colQTN
            // 
            this.colQTN.Caption = "Question";
            this.colQTN.FieldName = "Question";
            this.colQTN.Name = "colQTN";
            this.colQTN.OptionsColumn.AllowEdit = false;
            this.colQTN.OptionsColumn.AllowFocus = false;
            this.colQTN.OptionsColumn.ReadOnly = true;
            this.colQTN.Visible = true;
            this.colQTN.VisibleIndex = 0;
            this.colQTN.Width = 239;
            // 
            // colOP1
            // 
            this.colOP1.Caption = "Option 1";
            this.colOP1.FieldName = "Option1";
            this.colOP1.Name = "colOP1";
            this.colOP1.OptionsColumn.AllowEdit = false;
            this.colOP1.OptionsColumn.AllowFocus = false;
            this.colOP1.OptionsColumn.ReadOnly = true;
            this.colOP1.Visible = true;
            this.colOP1.VisibleIndex = 1;
            this.colOP1.Width = 64;
            // 
            // colOP2
            // 
            this.colOP2.Caption = "Option 2";
            this.colOP2.FieldName = "Option2";
            this.colOP2.Name = "colOP2";
            this.colOP2.OptionsColumn.AllowEdit = false;
            this.colOP2.OptionsColumn.AllowFocus = false;
            this.colOP2.OptionsColumn.ReadOnly = true;
            this.colOP2.Visible = true;
            this.colOP2.VisibleIndex = 2;
            this.colOP2.Width = 64;
            // 
            // colOP3
            // 
            this.colOP3.Caption = "Option 3";
            this.colOP3.FieldName = "Option3";
            this.colOP3.Name = "colOP3";
            this.colOP3.OptionsColumn.AllowEdit = false;
            this.colOP3.OptionsColumn.AllowFocus = false;
            this.colOP3.OptionsColumn.ReadOnly = true;
            this.colOP3.Visible = true;
            this.colOP3.VisibleIndex = 3;
            this.colOP3.Width = 64;
            // 
            // colOP4
            // 
            this.colOP4.Caption = "Option 4";
            this.colOP4.FieldName = "Option4";
            this.colOP4.Name = "colOP4";
            this.colOP4.OptionsColumn.AllowEdit = false;
            this.colOP4.OptionsColumn.AllowFocus = false;
            this.colOP4.OptionsColumn.ReadOnly = true;
            this.colOP4.Visible = true;
            this.colOP4.VisibleIndex = 4;
            this.colOP4.Width = 64;
            // 
            // colANS
            // 
            this.colANS.Caption = "Answer";
            this.colANS.FieldName = "Answer";
            this.colANS.Name = "colANS";
            this.colANS.OptionsColumn.AllowEdit = false;
            this.colANS.OptionsColumn.AllowFocus = false;
            this.colANS.OptionsColumn.ReadOnly = true;
            this.colANS.Visible = true;
            this.colANS.VisibleIndex = 5;
            this.colANS.Width = 64;
            // 
            // colPTS
            // 
            this.colPTS.Caption = "Value";
            this.colPTS.FieldName = "Points";
            this.colPTS.Name = "colPTS";
            this.colPTS.OptionsColumn.AllowEdit = false;
            this.colPTS.OptionsColumn.AllowFocus = false;
            this.colPTS.OptionsColumn.ReadOnly = true;
            this.colPTS.Visible = true;
            this.colPTS.VisibleIndex = 6;
            this.colPTS.Width = 64;
            // 
            // colSEC
            // 
            this.colSEC.Caption = "Time";
            this.colSEC.FieldName = "MaxTime";
            this.colSEC.Name = "colSEC";
            this.colSEC.OptionsColumn.AllowEdit = false;
            this.colSEC.OptionsColumn.AllowFocus = false;
            this.colSEC.OptionsColumn.ReadOnly = true;
            this.colSEC.Visible = true;
            this.colSEC.VisibleIndex = 7;
            this.colSEC.Width = 73;
            // 
            // colQID
            // 
            this.colQID.Caption = "gridColumn1";
            this.colQID.FieldName = "QID";
            this.colQID.Name = "colQID";
            // 
            // ucDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucDataEntry";
            this.Size = new System.Drawing.Size(750, 464);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDelete;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonDataEntry;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colQTP;
        private DevExpress.XtraGrid.Columns.GridColumn colQTN;
        private DevExpress.XtraGrid.Columns.GridColumn colOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colOP2;
        private DevExpress.XtraGrid.Columns.GridColumn colOP3;
        private DevExpress.XtraGrid.Columns.GridColumn colOP4;
        private DevExpress.XtraGrid.Columns.GridColumn colANS;
        private DevExpress.XtraGrid.Columns.GridColumn colPTS;
        private DevExpress.XtraGrid.Columns.GridColumn colSEC;
        private DevExpress.XtraGrid.Columns.GridColumn colQID;
    }
}
