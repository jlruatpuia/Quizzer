namespace Quizzer
{
    partial class frmQuiz
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bOptD = new DevExpress.XtraEditors.CheckButton();
            this.bOptC = new DevExpress.XtraEditors.CheckButton();
            this.bOptB = new DevExpress.XtraEditors.CheckButton();
            this.bOptA = new DevExpress.XtraEditors.CheckButton();
            this.lblQSTN = new DevExpress.XtraEditors.LabelControl();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mStart = new DevExpress.XtraBars.BarButtonItem();
            this.mStop = new DevExpress.XtraBars.BarButtonItem();
            this.mPrev = new DevExpress.XtraBars.BarButtonItem();
            this.mNext = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.mOptA = new DevExpress.XtraBars.BarButtonItem();
            this.mOptB = new DevExpress.XtraBars.BarButtonItem();
            this.mOptC = new DevExpress.XtraBars.BarButtonItem();
            this.mOptD = new DevExpress.XtraBars.BarButtonItem();
            this.mTrue = new DevExpress.XtraBars.BarButtonItem();
            this.mFalse = new DevExpress.XtraBars.BarButtonItem();
            this.m5050 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.mFullScreen = new DevExpress.XtraBars.BarButtonItem();
            this.mBGColor = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mCheck = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bOptD);
            this.layoutControl1.Controls.Add(this.bOptC);
            this.layoutControl1.Controls.Add(this.bOptB);
            this.layoutControl1.Controls.Add(this.bOptA);
            this.layoutControl1.Controls.Add(this.lblQSTN);
            this.layoutControl1.Controls.Add(this.gaugeControl1);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(556, 287, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(810, 463);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bOptD
            // 
            this.bOptD.Location = new System.Drawing.Point(407, 411);
            this.bOptD.MinimumSize = new System.Drawing.Size(230, 40);
            this.bOptD.Name = "bOptD";
            this.bOptD.Size = new System.Drawing.Size(391, 40);
            this.bOptD.StyleController = this.layoutControl1;
            this.bOptD.TabIndex = 10;
            this.bOptD.Text = "checkButton4";
            // 
            // bOptC
            // 
            this.bOptC.Location = new System.Drawing.Point(12, 411);
            this.bOptC.MinimumSize = new System.Drawing.Size(230, 40);
            this.bOptC.Name = "bOptC";
            this.bOptC.Size = new System.Drawing.Size(391, 40);
            this.bOptC.StyleController = this.layoutControl1;
            this.bOptC.TabIndex = 9;
            this.bOptC.Text = "checkButton3";
            // 
            // bOptB
            // 
            this.bOptB.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.bOptB.Location = new System.Drawing.Point(407, 367);
            this.bOptB.MinimumSize = new System.Drawing.Size(230, 40);
            this.bOptB.Name = "bOptB";
            this.bOptB.Size = new System.Drawing.Size(391, 40);
            this.bOptB.StyleController = this.layoutControl1;
            this.bOptB.TabIndex = 8;
            this.bOptB.Text = "checkButton2";
            // 
            // bOptA
            // 
            this.bOptA.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.bOptA.Location = new System.Drawing.Point(12, 367);
            this.bOptA.MinimumSize = new System.Drawing.Size(230, 40);
            this.bOptA.Name = "bOptA";
            this.bOptA.Size = new System.Drawing.Size(391, 40);
            this.bOptA.StyleController = this.layoutControl1;
            this.bOptA.TabIndex = 7;
            this.bOptA.Text = "checkButton1";
            // 
            // lblQSTN
            // 
            this.lblQSTN.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQSTN.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQSTN.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblQSTN.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblQSTN.Location = new System.Drawing.Point(12, 340);
            this.lblQSTN.Name = "lblQSTN";
            this.lblQSTN.Size = new System.Drawing.Size(786, 23);
            this.lblQSTN.StyleController = this.layoutControl1;
            this.lblQSTN.TabIndex = 6;
            this.lblQSTN.Text = "labelControl1";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(100, 42);
            this.gaugeControl1.TabIndex = 5;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8C8C8");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 88, 30);
            this.digitalGauge1.DigitCount = 2;
            this.digitalGauge1.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Text = "00,000";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(112.55F, 106.075F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent13";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style11;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Quizzer.Properties.Resources.Fifty;
            this.pictureEdit1.Location = new System.Drawing.Point(725, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(73, 42);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(810, 463);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(713, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(77, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(104, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(609, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 46);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(790, 282);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gaugeControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lblQSTN;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 328);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(790, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bOptA;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 355);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(395, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.bOptB;
            this.layoutControlItem5.Location = new System.Drawing.Point(395, 355);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(395, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.bOptC;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 399);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(395, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.bOptD;
            this.layoutControlItem7.Location = new System.Drawing.Point(395, 399);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(395, 44);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // bm
            // 
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.mStart,
            this.mStop,
            this.mNext,
            this.mPrev,
            this.barSubItem2,
            this.mOptA,
            this.mOptB,
            this.mOptC,
            this.mOptD,
            this.mTrue,
            this.mFalse,
            this.m5050,
            this.barSubItem3,
            this.mFullScreen,
            this.mBGColor,
            this.mCheck});
            this.bm.MainMenu = this.bar2;
            this.bm.MaxItemId = 29;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            this.bar2.Visible = false;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Quiz";
            this.barSubItem1.Id = 12;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mStart),
            new DevExpress.XtraBars.LinkPersistInfo(this.mStop),
            new DevExpress.XtraBars.LinkPersistInfo(this.mPrev, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mNext)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mStart
            // 
            this.mStart.Caption = "Start";
            this.mStart.Id = 13;
            this.mStart.Name = "mStart";
            this.mStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mStart_ItemClick);
            // 
            // mStop
            // 
            this.mStop.Caption = "Stop";
            this.mStop.Id = 14;
            this.mStop.Name = "mStop";
            this.mStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mStop_ItemClick);
            // 
            // mPrev
            // 
            this.mPrev.Caption = "Previous";
            this.mPrev.Id = 16;
            this.mPrev.Name = "mPrev";
            this.mPrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mPrev_ItemClick);
            // 
            // mNext
            // 
            this.mNext.Caption = "Next";
            this.mNext.Id = 15;
            this.mNext.Name = "mNext";
            this.mNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mNext_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Select";
            this.barSubItem2.Id = 17;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mOptA),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOptB),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOptC),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOptD),
            new DevExpress.XtraBars.LinkPersistInfo(this.mTrue, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mFalse),
            new DevExpress.XtraBars.LinkPersistInfo(this.m5050, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mCheck, true)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // mOptA
            // 
            this.mOptA.Caption = "Option A";
            this.mOptA.Id = 18;
            this.mOptA.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.mOptA.Name = "mOptA";
            this.mOptA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOptA_ItemClick);
            // 
            // mOptB
            // 
            this.mOptB.Caption = "Option B";
            this.mOptB.Id = 19;
            this.mOptB.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.mOptB.Name = "mOptB";
            this.mOptB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOptB_ItemClick);
            // 
            // mOptC
            // 
            this.mOptC.Caption = "Option C";
            this.mOptC.Id = 20;
            this.mOptC.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.mOptC.Name = "mOptC";
            this.mOptC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOptC_ItemClick);
            // 
            // mOptD
            // 
            this.mOptD.Caption = "Option D";
            this.mOptD.Id = 21;
            this.mOptD.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.mOptD.Name = "mOptD";
            this.mOptD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOptD_ItemClick);
            // 
            // mTrue
            // 
            this.mTrue.Caption = "True";
            this.mTrue.Id = 22;
            this.mTrue.Name = "mTrue";
            this.mTrue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mTrue_ItemClick);
            // 
            // mFalse
            // 
            this.mFalse.Caption = "False";
            this.mFalse.Id = 23;
            this.mFalse.Name = "mFalse";
            this.mFalse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mFalse_ItemClick);
            // 
            // m5050
            // 
            this.m5050.Caption = "50/50";
            this.m5050.Id = 24;
            this.m5050.Name = "m5050";
            this.m5050.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m5050_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Toggle";
            this.barSubItem3.Id = 25;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFullScreen),
            new DevExpress.XtraBars.LinkPersistInfo(this.mBGColor)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // mFullScreen
            // 
            this.mFullScreen.Caption = "Fullscreen";
            this.mFullScreen.Id = 26;
            this.mFullScreen.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.mFullScreen.Name = "mFullScreen";
            this.mFullScreen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mFullScreen_ItemClick);
            // 
            // mBGColor
            // 
            this.mBGColor.Caption = "Background Color";
            this.mBGColor.Id = 27;
            this.mBGColor.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11);
            this.mBGColor.Name = "mBGColor";
            this.mBGColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mBGColor_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(810, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 485);
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 463);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 463);
            // 
            // mCheck
            // 
            this.mCheck.Caption = "Check";
            this.mCheck.Id = 28;
            this.mCheck.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.mCheck.Name = "mCheck";
            this.mCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mCheck_ItemClick);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 485);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Window";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.Timer tmr;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraEditors.LabelControl lblQSTN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckButton bOptC;
        private DevExpress.XtraEditors.CheckButton bOptB;
        private DevExpress.XtraEditors.CheckButton bOptA;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.CheckButton bOptD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mStart;
        private DevExpress.XtraBars.BarButtonItem mStop;
        private DevExpress.XtraBars.BarButtonItem mPrev;
        private DevExpress.XtraBars.BarButtonItem mNext;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem mOptA;
        private DevExpress.XtraBars.BarButtonItem mOptB;
        private DevExpress.XtraBars.BarButtonItem mOptC;
        private DevExpress.XtraBars.BarButtonItem mOptD;
        private DevExpress.XtraBars.BarButtonItem mTrue;
        private DevExpress.XtraBars.BarButtonItem mFalse;
        private DevExpress.XtraBars.BarButtonItem m5050;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem mFullScreen;
        private DevExpress.XtraBars.BarButtonItem mBGColor;
        private DevExpress.XtraBars.BarButtonItem mCheck;
    }
}