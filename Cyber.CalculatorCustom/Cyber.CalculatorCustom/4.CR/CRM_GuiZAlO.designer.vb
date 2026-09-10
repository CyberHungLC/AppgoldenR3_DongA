<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRM_GuiZalo
    Inherits Cyber.From.FrmCalculator

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_SMS = New System.Windows.Forms.TextBox()
        Me.TxtMa_SMS = New Cyber.SmLists.TxtLookup()
        Me.TxtNoi_Dung = New System.Windows.Forms.TextBox()
        Me.TxtND1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtND5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBody = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabLeng = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabSo_Tin_Nhan = New System.Windows.Forms.Label()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkM_Is_LoaiN = New System.Windows.Forms.RadioButton()
        Me.ChkM_Is_So_Ngay = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx2 = New Cyber.SmLists.TxtLookup()
        Me.CbbM_LoaiN = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtM_So_Ngay = New ClsTextBox.txtTien_NT()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.CmbbSelectAll = New System.Windows.Forms.Button()
        Me.CmbbUnSelectAll = New System.Windows.Forms.Button()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.ComFilter = New System.Windows.Forms.ComboBox()
        Me.BtnLoc = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabTong = New System.Windows.Forms.Label()
        Me.LabDa_Gui = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabCon_Lai = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbbLoai = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTen_ChienDich = New System.Windows.Forms.TextBox()
        Me.TxtMa_ChienDich = New Cyber.SmLists.TxtLookup()
        Me.CbbLoai_Cs = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtId_Zalo = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_SMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 697)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1559, 10)
        Me.GroupBoxLine.TabIndex = 28
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1313, 713)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.Size = New System.Drawing.Size(109, 37)
        Me.ButtOK.TabIndex = 16
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Send"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1428, 713)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 17
        Me.ButtExit.Text = "&Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Tag = "Type"
        Me.Label1.Text = "Chọn mẫu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "Type"
        Me.Label2.Text = "Nội dung"
        '
        'TxtTen_SMS
        '
        Me.TxtTen_SMS.BackColor = System.Drawing.Color.White
        Me.TxtTen_SMS.Enabled = False
        Me.TxtTen_SMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_SMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_SMS.Location = New System.Drawing.Point(183, 11)
        Me.TxtTen_SMS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_SMS.Name = "TxtTen_SMS"
        Me.TxtTen_SMS.ReadOnly = True
        Me.TxtTen_SMS.Size = New System.Drawing.Size(305, 26)
        Me.TxtTen_SMS.TabIndex = 27
        Me.TxtTen_SMS.TabStop = False
        '
        'TxtMa_SMS
        '
        Me.TxtMa_SMS._ActilookupPopup = False
        Me.TxtMa_SMS.CyberActilookupPopup = True
        Me.TxtMa_SMS.Dv_ListDetail = Nothing
        Me.TxtMa_SMS.Dv_Master = Nothing
        Me.TxtMa_SMS.FilterClient = ""
        Me.TxtMa_SMS.FilterSQL = ""
        Me.TxtMa_SMS.Location = New System.Drawing.Point(97, 11)
        Me.TxtMa_SMS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_SMS.Name = "TxtMa_SMS"
        Me.TxtMa_SMS.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_SMS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_SMS.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_SMS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_SMS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_SMS.Size = New System.Drawing.Size(77, 26)
        Me.TxtMa_SMS.TabIndex = 2
        Me.TxtMa_SMS.Table_Name = ""
        '
        'TxtNoi_Dung
        '
        Me.TxtNoi_Dung.BackColor = System.Drawing.Color.White
        Me.TxtNoi_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoi_Dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Dung.Location = New System.Drawing.Point(96, 74)
        Me.TxtNoi_Dung.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNoi_Dung.Multiline = True
        Me.TxtNoi_Dung.Name = "TxtNoi_Dung"
        Me.TxtNoi_Dung.Size = New System.Drawing.Size(648, 111)
        Me.TxtNoi_Dung.TabIndex = 4
        Me.TxtNoi_Dung.TabStop = False
        '
        'TxtND1
        '
        Me.TxtND1.BackColor = System.Drawing.Color.White
        Me.TxtND1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtND1.ForeColor = System.Drawing.Color.Navy
        Me.TxtND1.Location = New System.Drawing.Point(97, 42)
        Me.TxtND1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtND1.Name = "TxtND1"
        Me.TxtND1.Size = New System.Drawing.Size(647, 23)
        Me.TxtND1.TabIndex = 3
        Me.TxtND1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 47)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Tag = "Type"
        Me.Label8.Text = "Begin"
        '
        'TxtND5
        '
        Me.TxtND5.BackColor = System.Drawing.Color.White
        Me.TxtND5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtND5.ForeColor = System.Drawing.Color.Navy
        Me.TxtND5.Location = New System.Drawing.Point(96, 192)
        Me.TxtND5.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtND5.Name = "TxtND5"
        Me.TxtND5.Size = New System.Drawing.Size(647, 23)
        Me.TxtND5.TabIndex = 5
        Me.TxtND5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 194)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Tag = "Type"
        Me.Label7.Text = "End"
        '
        'TxtBody
        '
        Me.TxtBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBody.BackColor = System.Drawing.Color.White
        Me.TxtBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBody.ForeColor = System.Drawing.Color.Navy
        Me.TxtBody.Location = New System.Drawing.Point(752, 48)
        Me.TxtBody.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.ReadOnly = True
        Me.TxtBody.Size = New System.Drawing.Size(808, 168)
        Me.TxtBody.TabIndex = 22
        Me.TxtBody.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(756, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Tag = "Type"
        Me.Label4.Text = "Preview"
        '
        'LabLeng
        '
        Me.LabLeng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLeng.Location = New System.Drawing.Point(955, 11)
        Me.LabLeng.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLeng.Name = "LabLeng"
        Me.LabLeng.Size = New System.Drawing.Size(131, 22)
        Me.LabLeng.TabIndex = 51
        Me.LabLeng.Tag = "Type"
        Me.LabLeng.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1079, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Tag = "Type"
        Me.Label6.Text = "/160 = "
        '
        'LabSo_Tin_Nhan
        '
        Me.LabSo_Tin_Nhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSo_Tin_Nhan.Location = New System.Drawing.Point(1144, 11)
        Me.LabSo_Tin_Nhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Tin_Nhan.Name = "LabSo_Tin_Nhan"
        Me.LabSo_Tin_Nhan.Size = New System.Drawing.Size(135, 30)
        Me.LabSo_Tin_Nhan.TabIndex = 53
        Me.LabSo_Tin_Nhan.Tag = "Type"
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(8, 298)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Margin = New System.Windows.Forms.Padding(4)
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1551, 390)
        Me.Master.TabIndex = 15
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelect = True
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 217)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1555, 14)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'ChkM_Is_LoaiN
        '
        Me.ChkM_Is_LoaiN.BackColor = System.Drawing.Color.White
        Me.ChkM_Is_LoaiN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkM_Is_LoaiN.Location = New System.Drawing.Point(253, 266)
        Me.ChkM_Is_LoaiN.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkM_Is_LoaiN.Name = "ChkM_Is_LoaiN"
        Me.ChkM_Is_LoaiN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkM_Is_LoaiN.Size = New System.Drawing.Size(85, 21)
        Me.ChkM_Is_LoaiN.TabIndex = 9
        Me.ChkM_Is_LoaiN.UseVisualStyleBackColor = False
        '
        'ChkM_Is_So_Ngay
        '
        Me.ChkM_Is_So_Ngay.BackColor = System.Drawing.Color.White
        Me.ChkM_Is_So_Ngay.Checked = True
        Me.ChkM_Is_So_Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkM_Is_So_Ngay.Location = New System.Drawing.Point(253, 236)
        Me.ChkM_Is_So_Ngay.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkM_Is_So_Ngay.Name = "ChkM_Is_So_Ngay"
        Me.ChkM_Is_So_Ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkM_Is_So_Ngay.Size = New System.Drawing.Size(85, 21)
        Me.ChkM_Is_So_Ngay.TabIndex = 8
        Me.ChkM_Is_So_Ngay.TabStop = True
        Me.ChkM_Is_So_Ngay.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 240)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Tag = "Date from"
        Me.Label5.Text = "Dòng xe"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(735, 238)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(424, 15)
        Me.TxtTen_Nh2.TabIndex = 67
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_Kx2
        '
        Me.TxtNh_Kx2._ActilookupPopup = False
        Me.TxtNh_Kx2.CyberActilookupPopup = True
        Me.TxtNh_Kx2.Dv_ListDetail = Nothing
        Me.TxtNh_Kx2.Dv_Master = Nothing
        Me.TxtNh_Kx2.FilterClient = ""
        Me.TxtNh_Kx2.FilterSQL = ""
        Me.TxtNh_Kx2.Location = New System.Drawing.Point(619, 235)
        Me.TxtNh_Kx2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Kx2.Name = "TxtNh_Kx2"
        Me.TxtNh_Kx2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx2.Size = New System.Drawing.Size(113, 22)
        Me.TxtNh_Kx2.TabIndex = 12
        Me.TxtNh_Kx2.Table_Name = ""
        '
        'CbbM_LoaiN
        '
        Me.CbbM_LoaiN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_LoaiN.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_LoaiN.FormattingEnabled = True
        Me.CbbM_LoaiN.Location = New System.Drawing.Point(345, 263)
        Me.CbbM_LoaiN.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_LoaiN.Name = "CbbM_LoaiN"
        Me.CbbM_LoaiN.Size = New System.Drawing.Size(95, 24)
        Me.CbbM_LoaiN.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(449, 239)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 65
        Me.Label9.Tag = "Date to"
        Me.Label9.Text = "ngày"
        '
        'TxtM_So_Ngay
        '
        Me.TxtM_So_Ngay.AllowNegative = True
        Me.TxtM_So_Ngay.BackColor = System.Drawing.Color.White
        Me.TxtM_So_Ngay.Flags = 7680
        Me.TxtM_So_Ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtM_So_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_So_Ngay.InputMask = "## ### ### ### ###"
        Me.TxtM_So_Ngay.Location = New System.Drawing.Point(345, 234)
        Me.TxtM_So_Ngay.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtM_So_Ngay.MaxWholeDigits = 13
        Me.TxtM_So_Ngay.Name = "TxtM_So_Ngay"
        Me.TxtM_So_Ngay.RangeMax = 1.7976931348623157E+308R
        Me.TxtM_So_Ngay.RangeMin = -1.7976931348623157E+308R
        Me.TxtM_So_Ngay.Size = New System.Drawing.Size(95, 24)
        Me.TxtM_So_Ngay.TabIndex = 10
        Me.TxtM_So_Ngay.TabStop = False
        Me.TxtM_So_Ngay.Text = "180"
        Me.TxtM_So_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(8, 268)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(69, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 64
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(8, 239)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 63
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(97, 263)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 22)
        Me.TxtM_Ngay_Ct2.TabIndex = 7
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(97, 234)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 22)
        Me.TxtM_Ngay_Ct1.TabIndex = 6
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CmbbSelectAll
        '
        Me.CmbbSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbSelectAll.Location = New System.Drawing.Point(599, 719)
        Me.CmbbSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbbSelectAll.Name = "CmbbSelectAll"
        Me.CmbbSelectAll.Size = New System.Drawing.Size(133, 30)
        Me.CmbbSelectAll.TabIndex = 20
        Me.CmbbSelectAll.Tag = "&Select all"
        Me.CmbbSelectAll.Text = "&Select all"
        '
        'CmbbUnSelectAll
        '
        Me.CmbbUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbUnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbUnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbUnSelectAll.Location = New System.Drawing.Point(735, 719)
        Me.CmbbUnSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbbUnSelectAll.Name = "CmbbUnSelectAll"
        Me.CmbbUnSelectAll.Size = New System.Drawing.Size(133, 30)
        Me.CmbbUnSelectAll.TabIndex = 21
        Me.CmbbUnSelectAll.Tag = "&Deselect"
        Me.CmbbUnSelectAll.Text = "&Unselect All"
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbXuatExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(869, 719)
        Me.CmbbXuatExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(133, 30)
        Me.CmbbXuatExcel.TabIndex = 22
        Me.CmbbXuatExcel.Tag = "&ExportExcel(xls)"
        Me.CmbbXuatExcel.Text = "Export (xls)"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(207, 721)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(383, 22)
        Me.TxtSearch.TabIndex = 19
        '
        'ComFilter
        '
        Me.ComFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComFilter.ForeColor = System.Drawing.Color.Navy
        Me.ComFilter.FormattingEnabled = True
        Me.ComFilter.Location = New System.Drawing.Point(4, 721)
        Me.ComFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.ComFilter.Name = "ComFilter"
        Me.ComFilter.Size = New System.Drawing.Size(196, 24)
        Me.ComFilter.TabIndex = 18
        '
        'BtnLoc
        '
        Me.BtnLoc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLoc.Appearance.Options.UseFont = True
        Me.BtnLoc.Location = New System.Drawing.Point(1257, 234)
        Me.BtnLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(152, 28)
        Me.BtnLoc.TabIndex = 14
        Me.BtnLoc.Text = "Lọc dữ liệu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1157, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Tag = "Date from"
        Me.Label3.Text = "Tổng cộng:"
        '
        'LabTong
        '
        Me.LabTong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTong.Location = New System.Drawing.Point(1243, 270)
        Me.LabTong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTong.Name = "LabTong"
        Me.LabTong.Size = New System.Drawing.Size(55, 16)
        Me.LabTong.TabIndex = 69
        Me.LabTong.Tag = "Date from"
        '
        'LabDa_Gui
        '
        Me.LabDa_Gui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDa_Gui.Location = New System.Drawing.Point(1352, 270)
        Me.LabDa_Gui.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDa_Gui.Name = "LabDa_Gui"
        Me.LabDa_Gui.Size = New System.Drawing.Size(55, 16)
        Me.LabDa_Gui.TabIndex = 71
        Me.LabDa_Gui.Tag = "Date from"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1299, 270)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 70
        Me.Label11.Tag = "Date from"
        Me.Label11.Text = "Đã gửi:"
        '
        'LabCon_Lai
        '
        Me.LabCon_Lai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCon_Lai.Location = New System.Drawing.Point(1504, 270)
        Me.LabCon_Lai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCon_Lai.Name = "LabCon_Lai"
        Me.LabCon_Lai.Size = New System.Drawing.Size(55, 16)
        Me.LabCon_Lai.TabIndex = 73
        Me.LabCon_Lai.Tag = "Date from"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1431, 270)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 72
        Me.Label13.Tag = "Date from"
        Me.Label13.Text = "Chưa  gửi:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(449, 268)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 74
        Me.Label10.Tag = "Date to"
        Me.Label10.Text = "tháng"
        '
        'CbbLoai
        '
        Me.CbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai.FormattingEnabled = True
        Me.CbbLoai.Location = New System.Drawing.Point(1157, 235)
        Me.CbbLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLoai.Name = "CbbLoai"
        Me.CbbLoai.Size = New System.Drawing.Size(95, 24)
        Me.CbbLoai.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(515, 270)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 17)
        Me.Label12.TabIndex = 77
        Me.Label12.Tag = "Date from"
        Me.Label12.Text = "Chiến dịch"
        '
        'TxtTen_ChienDich
        '
        Me.TxtTen_ChienDich.BackColor = System.Drawing.Color.White
        Me.TxtTen_ChienDich.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_ChienDich.Enabled = False
        Me.TxtTen_ChienDich.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChienDich.Location = New System.Drawing.Point(735, 268)
        Me.TxtTen_ChienDich.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ChienDich.Name = "TxtTen_ChienDich"
        Me.TxtTen_ChienDich.ReadOnly = True
        Me.TxtTen_ChienDich.Size = New System.Drawing.Size(424, 15)
        Me.TxtTen_ChienDich.TabIndex = 78
        Me.TxtTen_ChienDich.TabStop = False
        '
        'TxtMa_ChienDich
        '
        Me.TxtMa_ChienDich._ActilookupPopup = False
        Me.TxtMa_ChienDich.CyberActilookupPopup = True
        Me.TxtMa_ChienDich.Dv_ListDetail = Nothing
        Me.TxtMa_ChienDich.Dv_Master = Nothing
        Me.TxtMa_ChienDich.FilterClient = ""
        Me.TxtMa_ChienDich.FilterSQL = ""
        Me.TxtMa_ChienDich.Location = New System.Drawing.Point(619, 265)
        Me.TxtMa_ChienDich.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_ChienDich.Name = "TxtMa_ChienDich"
        Me.TxtMa_ChienDich.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ChienDich.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ChienDich.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ChienDich.Size = New System.Drawing.Size(113, 22)
        Me.TxtMa_ChienDich.TabIndex = 13
        Me.TxtMa_ChienDich.Table_Name = ""
        '
        'CbbLoai_Cs
        '
        Me.CbbLoai_Cs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Cs.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Cs.FormattingEnabled = True
        Me.CbbLoai_Cs.Location = New System.Drawing.Point(869, 235)
        Me.CbbLoai_Cs.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLoai_Cs.Name = "CbbLoai_Cs"
        Me.CbbLoai_Cs.Size = New System.Drawing.Size(232, 24)
        Me.CbbLoai_Cs.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(785, 240)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 80
        Me.Label14.Tag = "Date from"
        Me.Label14.Text = "Loại CSKH"
        '
        'TxtId_Zalo
        '
        Me.TxtId_Zalo.BackColor = System.Drawing.Color.White
        Me.TxtId_Zalo.Enabled = False
        Me.TxtId_Zalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId_Zalo.ForeColor = System.Drawing.Color.Navy
        Me.TxtId_Zalo.Location = New System.Drawing.Point(496, 10)
        Me.TxtId_Zalo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId_Zalo.Name = "TxtId_Zalo"
        Me.TxtId_Zalo.ReadOnly = True
        Me.TxtId_Zalo.Size = New System.Drawing.Size(248, 26)
        Me.TxtId_Zalo.TabIndex = 81
        Me.TxtId_Zalo.TabStop = False
        '
        'CRM_GuiSMSOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1564, 779)
        Me.Controls.Add(Me.TxtId_Zalo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CbbLoai_Cs)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTen_ChienDich)
        Me.Controls.Add(Me.TxtMa_ChienDich)
        Me.Controls.Add(Me.CbbLoai)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabCon_Lai)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabDa_Gui)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabTong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.CmbbSelectAll)
        Me.Controls.Add(Me.CmbbUnSelectAll)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.ComFilter)
        Me.Controls.Add(Me.ChkM_Is_LoaiN)
        Me.Controls.Add(Me.ChkM_Is_So_Ngay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_Kx2)
        Me.Controls.Add(Me.CbbM_LoaiN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtM_So_Ngay)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.LabSo_Tin_Nhan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabLeng)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBody)
        Me.Controls.Add(Me.TxtND5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtND1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNoi_Dung)
        Me.Controls.Add(Me.TxtTen_SMS)
        Me.Controls.Add(Me.TxtMa_SMS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "CRM_GuiSMSOld"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_SMS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_SMS, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtND1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtND5, 0)
        Me.Controls.SetChildIndex(Me.TxtBody, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabLeng, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Tin_Nhan, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.TxtM_So_Ngay, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbM_LoaiN, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ChkM_Is_So_Ngay, 0)
        Me.Controls.SetChildIndex(Me.ChkM_Is_LoaiN, 0)
        Me.Controls.SetChildIndex(Me.ComFilter, 0)
        Me.Controls.SetChildIndex(Me.TxtSearch, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.CmbbUnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbSelectAll, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.BtnLoc, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.LabTong, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.LabDa_Gui, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.LabCon_Lai, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Cs, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtId_Zalo, 0)
        CType(Me.TxtMa_SMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTen_SMS As Windows.Forms.TextBox
    Friend WithEvents TxtMa_SMS As SmLists.TxtLookup
    Friend WithEvents TxtNoi_Dung As Windows.Forms.TextBox
    Friend WithEvents TxtND1 As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtND5 As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtBody As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents LabLeng As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents LabSo_Tin_Nhan As Windows.Forms.Label
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents ChkM_Is_LoaiN As Windows.Forms.RadioButton
    Friend WithEvents ChkM_Is_So_Ngay As Windows.Forms.RadioButton
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx2 As SmLists.TxtLookup
    Friend WithEvents CbbM_LoaiN As Windows.Forms.ComboBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtM_So_Ngay As ClsTextBox.txtTien_NT
    Friend WithEvents LabM_Ngay_Ct2 As Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents CmbbSelectAll As Windows.Forms.Button
    Friend WithEvents CmbbUnSelectAll As Windows.Forms.Button
    Friend WithEvents CmbbXuatExcel As Windows.Forms.Button
    Friend WithEvents TxtSearch As Windows.Forms.TextBox
    Friend WithEvents ComFilter As Windows.Forms.ComboBox
    Friend WithEvents BtnLoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents LabTong As Windows.Forms.Label
    Friend WithEvents LabDa_Gui As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents LabCon_Lai As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents CbbLoai As Windows.Forms.ComboBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents TxtTen_ChienDich As Windows.Forms.TextBox
    Friend WithEvents TxtMa_ChienDich As SmLists.TxtLookup
    Friend WithEvents CbbLoai_Cs As Windows.Forms.ComboBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents TxtId_Zalo As Windows.Forms.TextBox
End Class
