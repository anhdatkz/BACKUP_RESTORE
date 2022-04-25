
namespace BACKUP_RESTORE
{
    partial class Form_Main
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
            System.Windows.Forms.Label Label_stt;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_saoluu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_phuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem_phuchoitheotg = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem_taodevice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DS_LTM = new BACKUP_RESTORE.LTMDataSet();
            this.BDS_DATABASES = new System.Windows.Forms.BindingSource(this.components);
            this.TableAdapter_databases = new BACKUP_RESTORE.LTMDataSetTableAdapters.DATABASESTableAdapter();
            this.tableAdapterManager = new BACKUP_RESTORE.LTMDataSetTableAdapters.TableAdapterManager();
            this.GridControl_databases = new DevExpress.XtraGrid.GridControl();
            this.gridView_databases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button_xoasaoluu = new System.Windows.Forms.Button();
            this.TextBox_stt = new System.Windows.Forms.TextBox();
            this.BDS_SP_STT_BACKUP = new System.Windows.Forms.BindingSource(this.components);
            this.Label_tenCSDL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableAdapter_SP_STT_BACKUP = new BACKUP_RESTORE.LTMDataSetTableAdapters.SP_STT_BACKUPTableAdapter();
            this.SP_STT_BACKUPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_resorebytime = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox_mota = new System.Windows.Forms.RichTextBox();
            this.timeEdit_restore = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit_restore = new DevExpress.XtraEditors.DateEdit();
            this.label_ngaygio = new System.Windows.Forms.Label();
            this.checkBox_xoatatca = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            Label_stt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_DATABASES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_databases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_databases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_SP_STT_BACKUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_STT_BACKUPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_resorebytime)).BeginInit();
            this.groupControl_resorebytime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_restore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_restore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_restore.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_stt
            // 
            Label_stt.AutoSize = true;
            Label_stt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_stt.Location = new System.Drawing.Point(400, 10);
            Label_stt.Name = "Label_stt";
            Label_stt.Size = new System.Drawing.Size(61, 18);
            Label_stt.TabIndex = 2;
            Label_stt.Text = "Position:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_saoluu,
            this.barButtonItem_phuchoi,
            this.barCheckItem_phuchoitheotg,
            this.barButtonItem_taodevice,
            this.barButtonItem_thoat,
            this.barEditItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_saoluu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_phuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barCheckItem_phuchoitheotg, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_taodevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_saoluu
            // 
            this.barButtonItem_saoluu.Caption = "Sao lưu";
            this.barButtonItem_saoluu.Id = 0;
            this.barButtonItem_saoluu.ImageOptions.Image = global::BACKUP_RESTORE.Properties.Resources.editdatasource_16x16;
            this.barButtonItem_saoluu.ImageOptions.LargeImage = global::BACKUP_RESTORE.Properties.Resources.editdatasource_32x32;
            this.barButtonItem_saoluu.Name = "barButtonItem_saoluu";
            this.barButtonItem_saoluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_saoluu_ItemClick);
            // 
            // barButtonItem_phuchoi
            // 
            this.barButtonItem_phuchoi.Caption = "Phục hồi";
            this.barButtonItem_phuchoi.Id = 1;
            this.barButtonItem_phuchoi.ImageOptions.Image = global::BACKUP_RESTORE.Properties.Resources.changedatasourcepivottable_16x16;
            this.barButtonItem_phuchoi.ImageOptions.LargeImage = global::BACKUP_RESTORE.Properties.Resources.changedatasourcepivottable_32x32;
            this.barButtonItem_phuchoi.Name = "barButtonItem_phuchoi";
            this.barButtonItem_phuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_phuchoi_ItemClick);
            // 
            // barCheckItem_phuchoitheotg
            // 
            this.barCheckItem_phuchoitheotg.Caption = "Tham số phục hồi theo thời gian";
            this.barCheckItem_phuchoitheotg.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem_phuchoitheotg.Id = 2;
            this.barCheckItem_phuchoitheotg.ImageOptions.Image = global::BACKUP_RESTORE.Properties.Resources.showworktimeonly_16x16;
            this.barCheckItem_phuchoitheotg.ImageOptions.LargeImage = global::BACKUP_RESTORE.Properties.Resources.showworktimeonly_32x32;
            this.barCheckItem_phuchoitheotg.Name = "barCheckItem_phuchoitheotg";
            this.barCheckItem_phuchoitheotg.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_phuchoitheotg_CheckedChanged);
            // 
            // barButtonItem_taodevice
            // 
            this.barButtonItem_taodevice.Caption = "Tạo device sao lưu";
            this.barButtonItem_taodevice.Id = 3;
            this.barButtonItem_taodevice.ImageOptions.Image = global::BACKUP_RESTORE.Properties.Resources.technology_16x16;
            this.barButtonItem_taodevice.ImageOptions.LargeImage = global::BACKUP_RESTORE.Properties.Resources.technology_32x32;
            this.barButtonItem_taodevice.Name = "barButtonItem_taodevice";
            this.barButtonItem_taodevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_taodevice_ItemClick);
            // 
            // barButtonItem_thoat
            // 
            this.barButtonItem_thoat.Caption = "Thoát";
            this.barButtonItem_thoat.Id = 4;
            this.barButtonItem_thoat.ImageOptions.Image = global::BACKUP_RESTORE.Properties.Resources.cancel_16x16;
            this.barButtonItem_thoat.ImageOptions.LargeImage = global::BACKUP_RESTORE.Properties.Resources.cancel_32x32;
            this.barButtonItem_thoat.Name = "barButtonItem_thoat";
            this.barButtonItem_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1174, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 637);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1174, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 637);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // DS_LTM
            // 
            this.DS_LTM.DataSetName = "LTMDataSet";
            this.DS_LTM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDS_DATABASES
            // 
            this.BDS_DATABASES.DataMember = "DATABASES";
            this.BDS_DATABASES.DataSource = this.DS_LTM;
            // 
            // TableAdapter_databases
            // 
            this.TableAdapter_databases.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.SP_STT_BACKUPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BACKUP_RESTORE.LTMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GridControl_databases
            // 
            this.GridControl_databases.DataSource = this.BDS_DATABASES;
            this.GridControl_databases.Dock = System.Windows.Forms.DockStyle.Left;
            this.GridControl_databases.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_databases.Location = new System.Drawing.Point(0, 24);
            this.GridControl_databases.MainView = this.gridView_databases;
            this.GridControl_databases.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_databases.MenuManager = this.barManager1;
            this.GridControl_databases.Name = "GridControl_databases";
            this.GridControl_databases.Size = new System.Drawing.Size(187, 637);
            this.GridControl_databases.TabIndex = 5;
            this.GridControl_databases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_databases});
            this.GridControl_databases.Click += new System.EventHandler(this.GridControl_databases_Click);
            // 
            // gridView_databases
            // 
            this.gridView_databases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView_databases.DetailHeight = 458;
            this.gridView_databases.FixedLineWidth = 3;
            this.gridView_databases.GridControl = this.GridControl_databases;
            this.gridView_databases.Name = "gridView_databases";
            this.gridView_databases.OptionsBehavior.Editable = false;
            this.gridView_databases.OptionsView.ShowGroupPanel = false;
            this.gridView_databases.OptionsView.ShowViewCaption = true;
            this.gridView_databases.ViewCaption = "Cơ sở dữ liệu";
            // 
            // colname
            // 
            this.colname.Caption = "DATABASES";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 27;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button_xoasaoluu);
            this.groupControl1.Controls.Add(Label_stt);
            this.groupControl1.Controls.Add(this.TextBox_stt);
            this.groupControl1.Controls.Add(this.Label_tenCSDL);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(187, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(987, 39);
            this.groupControl1.TabIndex = 10;
            // 
            // button_xoasaoluu
            // 
            this.button_xoasaoluu.BackColor = System.Drawing.Color.White;
            this.button_xoasaoluu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoasaoluu.ForeColor = System.Drawing.Color.Red;
            this.button_xoasaoluu.Location = new System.Drawing.Point(770, 6);
            this.button_xoasaoluu.Name = "button_xoasaoluu";
            this.button_xoasaoluu.Size = new System.Drawing.Size(130, 27);
            this.button_xoasaoluu.TabIndex = 4;
            this.button_xoasaoluu.Text = "Xóa sao lưu";
            this.button_xoasaoluu.UseVisualStyleBackColor = false;
            this.button_xoasaoluu.Click += new System.EventHandler(this.button_xoasaoluu_Click);
            // 
            // TextBox_stt
            // 
            this.TextBox_stt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS_SP_STT_BACKUP, "position", true));
            this.TextBox_stt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_stt.Location = new System.Drawing.Point(467, 7);
            this.TextBox_stt.Name = "TextBox_stt";
            this.TextBox_stt.Size = new System.Drawing.Size(156, 26);
            this.TextBox_stt.TabIndex = 3;
            // 
            // BDS_SP_STT_BACKUP
            // 
            this.BDS_SP_STT_BACKUP.DataMember = "SP_STT_BACKUP";
            this.BDS_SP_STT_BACKUP.DataSource = this.DS_LTM;
            // 
            // Label_tenCSDL
            // 
            this.Label_tenCSDL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS_DATABASES, "name", true));
            this.Label_tenCSDL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_tenCSDL.Location = new System.Drawing.Point(148, 8);
            this.Label_tenCSDL.Name = "Label_tenCSDL";
            this.Label_tenCSDL.Size = new System.Drawing.Size(182, 25);
            this.Label_tenCSDL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cơ sở dữ liệu";
            // 
            // TableAdapter_SP_STT_BACKUP
            // 
            this.TableAdapter_SP_STT_BACKUP.ClearBeforeFill = true;
            // 
            // SP_STT_BACKUPGridControl
            // 
            this.SP_STT_BACKUPGridControl.DataSource = this.BDS_SP_STT_BACKUP;
            this.SP_STT_BACKUPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SP_STT_BACKUPGridControl.Location = new System.Drawing.Point(187, 63);
            this.SP_STT_BACKUPGridControl.MainView = this.gridView1;
            this.SP_STT_BACKUPGridControl.MenuManager = this.barManager1;
            this.SP_STT_BACKUPGridControl.Name = "SP_STT_BACKUPGridControl";
            this.SP_STT_BACKUPGridControl.Size = new System.Drawing.Size(987, 360);
            this.SP_STT_BACKUPGridControl.TabIndex = 11;
            this.SP_STT_BACKUPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.SP_STT_BACKUPGridControl.Click += new System.EventHandler(this.SP_STT_BACKUPGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView1.GridControl = this.SP_STT_BACKUPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao lưu";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            // 
            // colname1
            // 
            this.colname1.Caption = "Tên bản sao lưu";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Thời gian sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Tài khoản sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            // 
            // groupControl_resorebytime
            // 
            this.groupControl_resorebytime.Controls.Add(this.richTextBox_mota);
            this.groupControl_resorebytime.Controls.Add(this.timeEdit_restore);
            this.groupControl_resorebytime.Controls.Add(this.dateEdit_restore);
            this.groupControl_resorebytime.Controls.Add(this.label_ngaygio);
            this.groupControl_resorebytime.Controls.Add(this.checkBox_xoatatca);
            this.groupControl_resorebytime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_resorebytime.Location = new System.Drawing.Point(187, 423);
            this.groupControl_resorebytime.Name = "groupControl_resorebytime";
            this.groupControl_resorebytime.Size = new System.Drawing.Size(987, 238);
            this.groupControl_resorebytime.TabIndex = 12;
            this.groupControl_resorebytime.Text = "Phục hồi theo thời gian";
            // 
            // richTextBox_mota
            // 
            this.richTextBox_mota.Enabled = false;
            this.richTextBox_mota.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_mota.Location = new System.Drawing.Point(291, 142);
            this.richTextBox_mota.Name = "richTextBox_mota";
            this.richTextBox_mota.Size = new System.Drawing.Size(609, 71);
            this.richTextBox_mota.TabIndex = 4;
            this.richTextBox_mota.Text = resources.GetString("richTextBox_mota.Text");
            // 
            // timeEdit_restore
            // 
            this.timeEdit_restore.EditValue = new System.DateTime(2022, 4, 9, 0, 0, 0, 0);
            this.timeEdit_restore.Location = new System.Drawing.Point(758, 97);
            this.timeEdit_restore.MenuManager = this.barManager1;
            this.timeEdit_restore.Name = "timeEdit_restore";
            this.timeEdit_restore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEdit_restore.Properties.Appearance.Options.UseFont = true;
            this.timeEdit_restore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_restore.Properties.Mask.EditMask = "HH:mm:ss";
            this.timeEdit_restore.Size = new System.Drawing.Size(142, 24);
            this.timeEdit_restore.TabIndex = 3;
            // 
            // dateEdit_restore
            // 
            this.dateEdit_restore.EditValue = null;
            this.dateEdit_restore.Location = new System.Drawing.Point(570, 97);
            this.dateEdit_restore.MenuManager = this.barManager1;
            this.dateEdit_restore.Name = "dateEdit_restore";
            this.dateEdit_restore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_restore.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_restore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_restore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_restore.Size = new System.Drawing.Size(166, 24);
            this.dateEdit_restore.TabIndex = 2;
            // 
            // label_ngaygio
            // 
            this.label_ngaygio.AutoSize = true;
            this.label_ngaygio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngaygio.Location = new System.Drawing.Point(288, 100);
            this.label_ngaygio.Name = "label_ngaygio";
            this.label_ngaygio.Size = new System.Drawing.Size(256, 18);
            this.label_ngaygio.TabIndex = 1;
            this.label_ngaygio.Text = "Ngày giờ để sao lưu đến thời điểm đó";
            // 
            // checkBox_xoatatca
            // 
            this.checkBox_xoatatca.AutoSize = true;
            this.checkBox_xoatatca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_xoatatca.Location = new System.Drawing.Point(451, 54);
            this.checkBox_xoatatca.Name = "checkBox_xoatatca";
            this.checkBox_xoatatca.Size = new System.Drawing.Size(407, 22);
            this.checkBox_xoatatca.TabIndex = 0;
            this.checkBox_xoatatca.Text = "Xóa tất cả bản sao lưu trong file trước khi sao lưu bản mới";
            this.checkBox_xoatatca.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(401, 289);
            this.progressBar.MarqueeAnimationSpeed = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 23);
            this.progressBar.TabIndex = 17;
            this.progressBar.Value = 10;
            this.progressBar.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 661);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupControl_resorebytime);
            this.Controls.Add(this.SP_STT_BACKUPGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridControl_databases);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_DATABASES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_databases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_databases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_SP_STT_BACKUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_STT_BACKUPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_resorebytime)).EndInit();
            this.groupControl_resorebytime.ResumeLayout(false);
            this.groupControl_resorebytime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_restore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_restore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_restore.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_saoluu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_phuchoi;
        private DevExpress.XtraBars.BarCheckItem barCheckItem_phuchoitheotg;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_taodevice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_thoat;
        private System.Windows.Forms.BindingSource BDS_DATABASES;
        private LTMDataSet DS_LTM;
        private LTMDataSetTableAdapters.DATABASESTableAdapter TableAdapter_databases;
        private LTMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl_databases;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_databases;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Label Label_tenCSDL;
        private System.Windows.Forms.BindingSource BDS_SP_STT_BACKUP;
        private LTMDataSetTableAdapters.SP_STT_BACKUPTableAdapter TableAdapter_SP_STT_BACKUP;
        private DevExpress.XtraGrid.GridControl SP_STT_BACKUPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl_resorebytime;
        private System.Windows.Forms.RichTextBox richTextBox_mota;
        private DevExpress.XtraEditors.TimeEdit timeEdit_restore;
        private DevExpress.XtraEditors.DateEdit dateEdit_restore;
        private System.Windows.Forms.Label label_ngaygio;
        private System.Windows.Forms.CheckBox checkBox_xoatatca;
        private System.Windows.Forms.TextBox TextBox_stt;
        private System.Windows.Forms.Button button_xoasaoluu;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}