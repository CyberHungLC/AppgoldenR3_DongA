<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BEDmHD02
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtMa_TD3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TD3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNh_Kh1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_Kh1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNh_Kh2 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_Kh2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNh_Kh3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_Kh3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct3 = New ClsTextBox.txtDate1()
        Me.ChkIs_HD_Ao = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMa_bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_bp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(565, 342)
        Me.ButtExit.TabIndex = 15
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(131, 303)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(528, 21)
        Me.CBBMa_Dvcs.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 306)
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(461, 342)
        Me.ButtOK.TabIndex = 14
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 284)
        Me.LabLoai_NT.Size = New System.Drawing.Size(112, 13)
        Me.LabLoai_NT.TabIndex = 16
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(131, 281)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 281)
        Me.ChkNT.TabIndex = 12
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(131, 5)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(131, 27)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 8)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(115, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày ký hợp đồng"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 30)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(116, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày ký hợp đồng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 325)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(662, 9)
        Me.GroupBoxLine.TabIndex = 17
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_TD3
        '
        Me.TxtMa_TD3._ActilookupPopup = False
        Me.TxtMa_TD3.CyberActilookupPopup = True
        Me.TxtMa_TD3.Dv_ListDetail = Nothing
        Me.TxtMa_TD3.Dv_Master = Nothing
        Me.TxtMa_TD3.FilterClient = ""
        Me.TxtMa_TD3.FilterSQL = ""
        Me.TxtMa_TD3.Location = New System.Drawing.Point(131, 72)
        Me.TxtMa_TD3.Name = "TxtMa_TD3"
        Me.TxtMa_TD3.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_TD3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TD3.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_TD3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TD3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TD3.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_TD3.TabIndex = 4
        Me.TxtMa_TD3.Table_Name = ""
        '
        'TxtTen_TD3
        '
        Me.TxtTen_TD3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TD3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TD3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TD3.Location = New System.Drawing.Point(249, 76)
        Me.TxtTen_TD3.Name = "TxtTen_TD3"
        Me.TxtTen_TD3.ReadOnly = True
        Me.TxtTen_TD3.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_TD3.TabIndex = 150
        Me.TxtTen_TD3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 149
        Me.Label2.Tag = "Account"
        Me.Label2.Text = "Số hợp đồng chi tiết"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = ""
        Me.TxtMa_HD.FilterSQL = ""
        Me.TxtMa_HD.Location = New System.Drawing.Point(131, 93)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_HD.TabIndex = 5
        Me.TxtMa_HD.Table_Name = ""
        '
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD.Location = New System.Drawing.Point(249, 97)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.ReadOnly = True
        Me.TxtTen_HD.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_HD.TabIndex = 153
        Me.TxtTen_HD.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Mã hợp đồng"
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(131, 114)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kh.TabIndex = 6
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(249, 118)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_Kh.TabIndex = 156
        Me.TxtTen_Kh.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 155
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Mã đối tượng"
        '
        'TxtNh_Kh1
        '
        Me.TxtNh_Kh1._ActilookupPopup = False
        Me.TxtNh_Kh1.CyberActilookupPopup = True
        Me.TxtNh_Kh1.Dv_ListDetail = Nothing
        Me.TxtNh_Kh1.Dv_Master = Nothing
        Me.TxtNh_Kh1.FilterClient = ""
        Me.TxtNh_Kh1.FilterSQL = ""
        Me.TxtNh_Kh1.Location = New System.Drawing.Point(131, 135)
        Me.TxtNh_Kh1.Name = "TxtNh_Kh1"
        Me.TxtNh_Kh1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_Kh1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh1.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_Kh1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh1.TabIndex = 7
        Me.TxtNh_Kh1.Table_Name = ""
        '
        'TxtTen_Nh_Kh1
        '
        Me.TxtTen_Nh_Kh1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_Kh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kh1.Location = New System.Drawing.Point(249, 139)
        Me.TxtTen_Nh_Kh1.Name = "TxtTen_Nh_Kh1"
        Me.TxtTen_Nh_Kh1.ReadOnly = True
        Me.TxtTen_Nh_Kh1.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_Nh_Kh1.TabIndex = 159
        Me.TxtTen_Nh_Kh1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Tag = "Account"
        Me.Label5.Text = "Nhóm đối tượng cấp 1"
        '
        'TxtNh_Kh2
        '
        Me.TxtNh_Kh2._ActilookupPopup = False
        Me.TxtNh_Kh2.CyberActilookupPopup = True
        Me.TxtNh_Kh2.Dv_ListDetail = Nothing
        Me.TxtNh_Kh2.Dv_Master = Nothing
        Me.TxtNh_Kh2.FilterClient = ""
        Me.TxtNh_Kh2.FilterSQL = ""
        Me.TxtNh_Kh2.Location = New System.Drawing.Point(131, 156)
        Me.TxtNh_Kh2.Name = "TxtNh_Kh2"
        Me.TxtNh_Kh2.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_Kh2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh2.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_Kh2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh2.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh2.TabIndex = 8
        Me.TxtNh_Kh2.Table_Name = ""
        '
        'TxtTen_Nh_Kh2
        '
        Me.TxtTen_Nh_Kh2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_Kh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kh2.Location = New System.Drawing.Point(249, 160)
        Me.TxtTen_Nh_Kh2.Name = "TxtTen_Nh_Kh2"
        Me.TxtTen_Nh_Kh2.ReadOnly = True
        Me.TxtTen_Nh_Kh2.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_Nh_Kh2.TabIndex = 162
        Me.TxtTen_Nh_Kh2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 161
        Me.Label6.Tag = "Account"
        Me.Label6.Text = "Nhóm đối tượng cấp 2"
        '
        'TxtNh_Kh3
        '
        Me.TxtNh_Kh3._ActilookupPopup = False
        Me.TxtNh_Kh3.CyberActilookupPopup = True
        Me.TxtNh_Kh3.Dv_ListDetail = Nothing
        Me.TxtNh_Kh3.Dv_Master = Nothing
        Me.TxtNh_Kh3.FilterClient = ""
        Me.TxtNh_Kh3.FilterSQL = ""
        Me.TxtNh_Kh3.Location = New System.Drawing.Point(131, 177)
        Me.TxtNh_Kh3.Name = "TxtNh_Kh3"
        Me.TxtNh_Kh3.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_Kh3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh3.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_Kh3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh3.TabIndex = 9
        Me.TxtNh_Kh3.Table_Name = ""
        '
        'TxtTen_Nh_Kh3
        '
        Me.TxtTen_Nh_Kh3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kh3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_Kh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kh3.Location = New System.Drawing.Point(249, 181)
        Me.TxtTen_Nh_Kh3.Name = "TxtTen_Nh_Kh3"
        Me.TxtTen_Nh_Kh3.ReadOnly = True
        Me.TxtTen_Nh_Kh3.Size = New System.Drawing.Size(410, 13)
        Me.TxtTen_Nh_Kh3.TabIndex = 165
        Me.TxtTen_Nh_Kh3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 164
        Me.Label7.Tag = "Account"
        Me.Label7.Text = "Nhóm đối tượng cấp 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 167
        Me.Label8.Tag = "Date to"
        Me.Label8.Text = "Thanh toán tới ngày"
        '
        'TxtM_Ngay_Ct3
        '
        Me.TxtM_Ngay_Ct3.Flags = 0
        Me.TxtM_Ngay_Ct3.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct3.IsAllowResize = False
        Me.TxtM_Ngay_Ct3.isEmpty = True
        Me.TxtM_Ngay_Ct3.Location = New System.Drawing.Point(131, 49)
        Me.TxtM_Ngay_Ct3.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct3.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct3.MaxLength = 10
        Me.TxtM_Ngay_Ct3.Name = "TxtM_Ngay_Ct3"
        Me.TxtM_Ngay_Ct3.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct3.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct3.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct3.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct3.TabIndex = 2
        Me.TxtM_Ngay_Ct3.Text = "__/__/____"
        Me.TxtM_Ngay_Ct3.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'ChkIs_HD_Ao
        '
        Me.ChkIs_HD_Ao.AutoSize = True
        Me.ChkIs_HD_Ao.Location = New System.Drawing.Point(249, 5)
        Me.ChkIs_HD_Ao.Name = "ChkIs_HD_Ao"
        Me.ChkIs_HD_Ao.Size = New System.Drawing.Size(125, 17)
        Me.ChkIs_HD_Ao.TabIndex = 168
        Me.ChkIs_HD_Ao.Text = "Hiển thị hợp đồng ảo"
        Me.ChkIs_HD_Ao.UseVisualStyleBackColor = True
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(131, 245)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kx.TabIndex = 170
        Me.TxtMa_Kx.Table_Name = ""
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(247, 249)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_Kx.TabIndex = 173
        Me.TxtTen_Kx.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 174
        Me.Label9.Tag = "Type Car"
        Me.Label9.Text = "Kiểu xe"
        '
        'TxtMa_bp
        '
        Me.TxtMa_bp._ActilookupPopup = False
        Me.TxtMa_bp.CyberActilookupPopup = True
        Me.TxtMa_bp.Dv_ListDetail = Nothing
        Me.TxtMa_bp.Dv_Master = Nothing
        Me.TxtMa_bp.FilterClient = ""
        Me.TxtMa_bp.FilterSQL = ""
        Me.TxtMa_bp.Location = New System.Drawing.Point(131, 222)
        Me.TxtMa_bp.Name = "TxtMa_bp"
        Me.TxtMa_bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_bp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_bp.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_bp.TabIndex = 169
        Me.TxtMa_bp.Table_Name = ""
        '
        'TxtTen_bp
        '
        Me.TxtTen_bp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_bp.Location = New System.Drawing.Point(248, 226)
        Me.TxtTen_bp.Name = "TxtTen_bp"
        Me.TxtTen_bp.ReadOnly = True
        Me.TxtTen_bp.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_bp.TabIndex = 171
        Me.TxtTen_bp.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 172
        Me.Label10.Tag = "Department"
        Me.Label10.Text = "Phòng ban"
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.FilterClient = ""
        Me.TxtMa_hs.FilterSQL = ""
        Me.TxtMa_hs.Location = New System.Drawing.Point(131, 198)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_hs.TabIndex = 175
        Me.TxtMa_hs.Table_Name = ""
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(247, 202)
        Me.TxtTen_hs.Name = "TxtTen_hs"
        Me.TxtTen_hs.ReadOnly = True
        Me.TxtTen_hs.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_hs.TabIndex = 176
        Me.TxtTen_hs.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 177
        Me.Label11.Tag = "Sale"
        Me.Label11.Text = "Mã TVBH"
        '
        'BEDmHD02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 395)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMa_bp)
        Me.Controls.Add(Me.TxtTen_bp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ChkIs_HD_Ao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtM_Ngay_Ct3)
        Me.Controls.Add(Me.TxtNh_Kh3)
        Me.Controls.Add(Me.TxtTen_Nh_Kh3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNh_Kh2)
        Me.Controls.Add(Me.TxtTen_Nh_Kh2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNh_Kh1)
        Me.Controls.Add(Me.TxtTen_Nh_Kh1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_TD3)
        Me.Controls.Add(Me.TxtTen_TD3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "BEDmHD02"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TD3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TD3, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kh2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kh3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh3, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_HD_Ao, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_bp, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_TD3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TD3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HD As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_Kh1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_Kh1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_Kh2 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_Kh2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_Kh3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_Kh3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct3 As ClsTextBox.txtDate1
    Friend WithEvents ChkIs_HD_Ao As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_bp As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_hs As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
