<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintINCD1
    Inherits Cyber.From.FrmCalculator

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.CmdLoadData = New System.Windows.Forms.Button()
        Me.CmbbSelectAll = New System.Windows.Forms.Button()
        Me.CmbbUnSelectAll = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtMa_Kho = New System.Windows.Forms.TextBox()
        Me.CmdFiter_Kho = New DevExpress.XtraEditors.SimpleButton()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Tk_Vt = New System.Windows.Forms.TextBox()
        Me.TxtTk_Vt = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtten_nh_vt3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtten_nh_vt2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_vt2 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtten_nh_vt1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_vt1 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_vt3 = New Cyber.SmLists.TxtLookup()
        Me.cbbTinh_dc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkIs_Dm = New System.Windows.Forms.CheckBox()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_vt2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_vt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_vt3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 492)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(978, 8)
        Me.GroupBoxLine.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(307, 310)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Lưu dữ liệu"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(880, 502)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 16
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(775, 501)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(100, 30)
        Me.CmbbXuatExcel.TabIndex = 15
        Me.CmbbXuatExcel.Text = "&Export Excel"
        Me.CmbbXuatExcel.UseVisualStyleBackColor = True
        '
        'CmdLoadData
        '
        Me.CmdLoadData.Location = New System.Drawing.Point(15, 138)
        Me.CmdLoadData.Name = "CmdLoadData"
        Me.CmdLoadData.Size = New System.Drawing.Size(100, 30)
        Me.CmdLoadData.TabIndex = 10
        Me.CmdLoadData.Text = "&Lấy dữ liệu"
        Me.CmdLoadData.UseVisualStyleBackColor = True
        '
        'CmbbSelectAll
        '
        Me.CmbbSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbSelectAll.Location = New System.Drawing.Point(10, 502)
        Me.CmbbSelectAll.Name = "CmbbSelectAll"
        Me.CmbbSelectAll.Size = New System.Drawing.Size(89, 29)
        Me.CmbbSelectAll.TabIndex = 12
        Me.CmbbSelectAll.Tag = "&XepXe"
        Me.CmbbSelectAll.Text = "&Chọn toàn bộ"
        '
        'CmbbUnSelectAll
        '
        Me.CmbbUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbUnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbUnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbUnSelectAll.Location = New System.Drawing.Point(100, 502)
        Me.CmbbUnSelectAll.Name = "CmbbUnSelectAll"
        Me.CmbbUnSelectAll.Size = New System.Drawing.Size(89, 29)
        Me.CmbbUnSelectAll.TabIndex = 13
        Me.CmbbUnSelectAll.Tag = "&XepXe"
        Me.CmbbUnSelectAll.Text = "&Gỡ chọn"
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.Location = New System.Drawing.Point(675, 501)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(100, 30)
        Me.BtnPrint.TabIndex = 14
        Me.BtnPrint.Text = "In/&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(15, 174)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(965, 321)
        Me.Detail.TabIndex = 11
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowAutoFilterRow = True
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Kho.Location = New System.Drawing.Point(128, 48)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kho.TabIndex = 2
        '
        'CmdFiter_Kho
        '
        Me.CmdFiter_Kho.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFiter_Kho.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdFiter_Kho.Appearance.Options.UseFont = True
        Me.CmdFiter_Kho.Appearance.Options.UseForeColor = True
        Me.CmdFiter_Kho.Location = New System.Drawing.Point(250, 47)
        Me.CmdFiter_Kho.Name = "CmdFiter_Kho"
        Me.CmdFiter_Kho.Size = New System.Drawing.Size(99, 21)
        Me.CmdFiter_Kho.TabIndex = 3
        Me.CmdFiter_Kho.Text = "Tìm kiếm kho"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(15, 29)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 623
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(46, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 622
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(128, 26)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(116, 20)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "__/__/____"
        Me.TxtNgay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(128, 3)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(116, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(15, 52)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_kho.TabIndex = 621
        Me.LabMa_kho.Tag = "Supplies code"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 630
        Me.Label6.Tag = "Supplies account"
        Me.Label6.Text = "Tk vật tư"
        '
        'TxtTen_Tk_Vt
        '
        Me.TxtTen_Tk_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk_Vt.Enabled = False
        Me.TxtTen_Tk_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_Vt.Location = New System.Drawing.Point(249, 97)
        Me.TxtTen_Tk_Vt.Name = "TxtTen_Tk_Vt"
        Me.TxtTen_Tk_Vt.ReadOnly = True
        Me.TxtTen_Tk_Vt.Size = New System.Drawing.Size(260, 13)
        Me.TxtTen_Tk_Vt.TabIndex = 629
        Me.TxtTen_Tk_Vt.TabStop = False
        '
        'TxtTk_Vt
        '
        Me.TxtTk_Vt._ActilookupPopup = False
        Me.TxtTk_Vt.CyberActilookupPopup = True
        Me.TxtTk_Vt.Dv_ListDetail = Nothing
        Me.TxtTk_Vt.Dv_Master = Nothing
        Me.TxtTk_Vt.FilterClient = ""
        Me.TxtTk_Vt.FilterSQL = ""
        Me.TxtTk_Vt.Location = New System.Drawing.Point(128, 94)
        Me.TxtTk_Vt.Name = "TxtTk_Vt"
        Me.TxtTk_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Vt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Vt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Vt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtTk_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Vt.Size = New System.Drawing.Size(116, 22)
        Me.TxtTk_Vt.TabIndex = 5
        Me.TxtTk_Vt.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(15, 73)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 628
        Me.LabMa_Cc.Tag = "Supplies code"
        Me.LabMa_Cc.Text = "Mã vật tư"
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(249, 76)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(260, 13)
        Me.TxtTen_Vt.TabIndex = 627
        Me.TxtTen_Vt.TabStop = False
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(128, 71)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Vt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(116, 22)
        Me.TxtMa_Vt.TabIndex = 4
        Me.TxtMa_Vt.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(515, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 639
        Me.Label8.Tag = "Group supplies 3"
        Me.Label8.Text = "Nhóm vật tư 3"
        '
        'txtten_nh_vt3
        '
        Me.txtten_nh_vt3.BackColor = System.Drawing.Color.White
        Me.txtten_nh_vt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_vt3.Enabled = False
        Me.txtten_nh_vt3.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_vt3.Location = New System.Drawing.Point(747, 120)
        Me.txtten_nh_vt3.Name = "txtten_nh_vt3"
        Me.txtten_nh_vt3.ReadOnly = True
        Me.txtten_nh_vt3.Size = New System.Drawing.Size(277, 13)
        Me.txtten_nh_vt3.TabIndex = 638
        Me.txtten_nh_vt3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(515, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 637
        Me.Label7.Tag = "Group supplies 2"
        Me.Label7.Text = "Nhóm vật tư 2"
        '
        'txtten_nh_vt2
        '
        Me.txtten_nh_vt2.BackColor = System.Drawing.Color.White
        Me.txtten_nh_vt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_vt2.Enabled = False
        Me.txtten_nh_vt2.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_vt2.Location = New System.Drawing.Point(747, 98)
        Me.txtten_nh_vt2.Name = "txtten_nh_vt2"
        Me.txtten_nh_vt2.ReadOnly = True
        Me.txtten_nh_vt2.Size = New System.Drawing.Size(277, 13)
        Me.txtten_nh_vt2.TabIndex = 636
        Me.txtten_nh_vt2.TabStop = False
        '
        'TxtNh_vt2
        '
        Me.TxtNh_vt2._ActilookupPopup = False
        Me.TxtNh_vt2.CyberActilookupPopup = True
        Me.TxtNh_vt2.Dv_ListDetail = Nothing
        Me.TxtNh_vt2.Dv_Master = Nothing
        Me.TxtNh_vt2.FilterClient = ""
        Me.TxtNh_vt2.FilterSQL = ""
        Me.TxtNh_vt2.Location = New System.Drawing.Point(625, 93)
        Me.TxtNh_vt2.Name = "TxtNh_vt2"
        Me.TxtNh_vt2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_vt2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_vt2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_vt2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_vt2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtNh_vt2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_vt2.Size = New System.Drawing.Size(116, 22)
        Me.TxtNh_vt2.TabIndex = 8
        Me.TxtNh_vt2.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(515, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 635
        Me.Label5.Tag = "Group supplies 1"
        Me.Label5.Text = "Nhóm vật tư 1"
        '
        'txtten_nh_vt1
        '
        Me.txtten_nh_vt1.BackColor = System.Drawing.Color.White
        Me.txtten_nh_vt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_vt1.Enabled = False
        Me.txtten_nh_vt1.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_vt1.Location = New System.Drawing.Point(747, 76)
        Me.txtten_nh_vt1.Name = "txtten_nh_vt1"
        Me.txtten_nh_vt1.ReadOnly = True
        Me.txtten_nh_vt1.Size = New System.Drawing.Size(277, 13)
        Me.txtten_nh_vt1.TabIndex = 634
        Me.txtten_nh_vt1.TabStop = False
        '
        'TxtNh_vt1
        '
        Me.TxtNh_vt1._ActilookupPopup = False
        Me.TxtNh_vt1.CyberActilookupPopup = True
        Me.TxtNh_vt1.Dv_ListDetail = Nothing
        Me.TxtNh_vt1.Dv_Master = Nothing
        Me.TxtNh_vt1.FilterClient = ""
        Me.TxtNh_vt1.FilterSQL = ""
        Me.TxtNh_vt1.Location = New System.Drawing.Point(625, 71)
        Me.TxtNh_vt1.Name = "TxtNh_vt1"
        Me.TxtNh_vt1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_vt1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_vt1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_vt1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_vt1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtNh_vt1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_vt1.Size = New System.Drawing.Size(116, 22)
        Me.TxtNh_vt1.TabIndex = 7
        Me.TxtNh_vt1.Table_Name = ""
        '
        'TxtNh_vt3
        '
        Me.TxtNh_vt3._ActilookupPopup = False
        Me.TxtNh_vt3.CyberActilookupPopup = True
        Me.TxtNh_vt3.Dv_ListDetail = Nothing
        Me.TxtNh_vt3.Dv_Master = Nothing
        Me.TxtNh_vt3.FilterClient = ""
        Me.TxtNh_vt3.FilterSQL = ""
        Me.TxtNh_vt3.Location = New System.Drawing.Point(625, 115)
        Me.TxtNh_vt3.Name = "TxtNh_vt3"
        Me.TxtNh_vt3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_vt3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_vt3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_vt3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_vt3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtNh_vt3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_vt3.Size = New System.Drawing.Size(116, 22)
        Me.TxtNh_vt3.TabIndex = 9
        Me.TxtNh_vt3.Table_Name = ""
        '
        'cbbTinh_dc
        '
        Me.cbbTinh_dc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTinh_dc.ForeColor = System.Drawing.Color.Navy
        Me.cbbTinh_dc.FormattingEnabled = True
        Me.cbbTinh_dc.Location = New System.Drawing.Point(128, 117)
        Me.cbbTinh_dc.Name = "cbbTinh_dc"
        Me.cbbTinh_dc.Size = New System.Drawing.Size(220, 21)
        Me.cbbTinh_dc.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(15, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 641
        Me.Label12.Tag = "Transfer arising stock"
        Me.Label12.Text = "Tính điều chuyển kho"
        '
        'ChkIs_Dm
        '
        Me.ChkIs_Dm.AutoSize = True
        Me.ChkIs_Dm.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_Dm.Location = New System.Drawing.Point(250, 5)
        Me.ChkIs_Dm.Name = "ChkIs_Dm"
        Me.ChkIs_Dm.Size = New System.Drawing.Size(127, 17)
        Me.ChkIs_Dm.TabIndex = 642
        Me.ChkIs_Dm.Text = "Lấy dữ liệu danh mục"
        Me.ChkIs_Dm.UseVisualStyleBackColor = True
        '
        'PrintINCD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(982, 556)
        Me.Controls.Add(Me.ChkIs_Dm)
        Me.Controls.Add(Me.cbbTinh_dc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtten_nh_vt3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtten_nh_vt2)
        Me.Controls.Add(Me.TxtNh_vt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtten_nh_vt1)
        Me.Controls.Add(Me.TxtNh_vt1)
        Me.Controls.Add(Me.TxtNh_vt3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Tk_Vt)
        Me.Controls.Add(Me.TxtTk_Vt)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.TxtMa_Vt)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.CmdFiter_Kho)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.CmbbSelectAll)
        Me.Controls.Add(Me.CmbbUnSelectAll)
        Me.Controls.Add(Me.CmdLoadData)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrintINCD1"
        Me.Text = "In bảng lương"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdLoadData, 0)
        Me.Controls.SetChildIndex(Me.CmbbUnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbSelectAll, 0)
        Me.Controls.SetChildIndex(Me.BtnPrint, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.CmdFiter_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_vt3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_vt1, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_vt1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_vt2, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_vt2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_vt3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cbbTinh_dc, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Dm, 0)
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_vt2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_vt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_vt3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbbXuatExcel As System.Windows.Forms.Button
    Friend WithEvents CmdLoadData As System.Windows.Forms.Button
    Friend WithEvents CmbbSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmbbUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtMa_Kho As System.Windows.Forms.TextBox
    Friend WithEvents CmdFiter_Kho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Tk_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_vt3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_vt2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_vt2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_vt1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_vt1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_vt3 As Cyber.SmLists.TxtLookup
    Friend WithEvents cbbTinh_dc As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_Dm As System.Windows.Forms.CheckBox

End Class
