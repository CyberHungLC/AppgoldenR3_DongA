<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARCD1
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtM_Tk_CN = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk_CN = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kh3 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kh2 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kh1 = New Cyber.SmLists.TxtLookup()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ChkGroup3 = New System.Windows.Forms.CheckBox()
        Me.ChkGroup2 = New System.Windows.Forms.CheckBox()
        Me.ChkGroup1 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbMa_TTCP = New System.Windows.Forms.ComboBox()
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kh1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 297)
        Me.ButtExit.TabIndex = 15
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 258)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(497, 21)
        Me.CBBMa_Dvcs.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 261)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 297)
        Me.ButtOK.TabIndex = 14
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 236)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 236)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 237)
        Me.ChkNT.TabIndex = 12
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 47)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 69)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 50)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 72)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 280)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(9, 8)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'TxtM_Tk_CN
        '
        Me.TxtM_Tk_CN._ActilookupPopup = False
        Me.TxtM_Tk_CN.CyberActilookupPopup = True
        Me.TxtM_Tk_CN.Dv_ListDetail = Nothing
        Me.TxtM_Tk_CN.Dv_Master = Nothing
        Me.TxtM_Tk_CN.FilterClient = ""
        Me.TxtM_Tk_CN.FilterSQL = ""
        Me.TxtM_Tk_CN.Location = New System.Drawing.Point(95, 5)
        Me.TxtM_Tk_CN.Name = "TxtM_Tk_CN"
        Me.TxtM_Tk_CN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk_CN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk_CN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk_CN.Size = New System.Drawing.Size(114, 20)
        Me.TxtM_Tk_CN.TabIndex = 0
        Me.TxtM_Tk_CN.Table_Name = ""
        '
        'Txtten_Tk_CN
        '
        Me.Txtten_Tk_CN.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk_CN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk_CN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk_CN.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk_CN.Location = New System.Drawing.Point(214, 9)
        Me.Txtten_Tk_CN.Name = "Txtten_Tk_CN"
        Me.Txtten_Tk_CN.ReadOnly = True
        Me.Txtten_Tk_CN.Size = New System.Drawing.Size(379, 13)
        Me.Txtten_Tk_CN.TabIndex = 144
        Me.Txtten_Tk_CN.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(95, 26)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kh.TabIndex = 1
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(214, 30)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(379, 13)
        Me.TxtTen_Kh.TabIndex = 148
        Me.TxtTen_Kh.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Mã đối tượng"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 157
        Me.Label3.Tag = "Group 3"
        Me.Label3.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(214, 137)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(379, 14)
        Me.TxtTen_Nh3.TabIndex = 156
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_Kh3
        '
        Me.TxtNh_Kh3._ActilookupPopup = False
        Me.TxtNh_Kh3.CyberActilookupPopup = True
        Me.TxtNh_Kh3.Dv_ListDetail = Nothing
        Me.TxtNh_Kh3.Dv_Master = Nothing
        Me.TxtNh_Kh3.FilterClient = ""
        Me.TxtNh_Kh3.FilterSQL = ""
        Me.TxtNh_Kh3.Location = New System.Drawing.Point(95, 134)
        Me.TxtNh_Kh3.Name = "TxtNh_Kh3"
        Me.TxtNh_Kh3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh3.TabIndex = 6
        Me.TxtNh_Kh3.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 155
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Nhóm 2"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(214, 116)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(379, 14)
        Me.TxtTen_Nh2.TabIndex = 154
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_Kh2
        '
        Me.TxtNh_Kh2._ActilookupPopup = False
        Me.TxtNh_Kh2.CyberActilookupPopup = True
        Me.TxtNh_Kh2.Dv_ListDetail = Nothing
        Me.TxtNh_Kh2.Dv_Master = Nothing
        Me.TxtNh_Kh2.FilterClient = ""
        Me.TxtNh_Kh2.FilterSQL = ""
        Me.TxtNh_Kh2.Location = New System.Drawing.Point(95, 113)
        Me.TxtNh_Kh2.Name = "TxtNh_Kh2"
        Me.TxtNh_Kh2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh2.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh2.TabIndex = 5
        Me.TxtNh_Kh2.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(9, 95)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(54, 14)
        Me.LabMa_Nh1.TabIndex = 153
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(214, 95)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(379, 14)
        Me.TxtTen_Nh1.TabIndex = 152
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_Kh1
        '
        Me.TxtNh_Kh1._ActilookupPopup = False
        Me.TxtNh_Kh1.CyberActilookupPopup = True
        Me.TxtNh_Kh1.Dv_ListDetail = Nothing
        Me.TxtNh_Kh1.Dv_Master = Nothing
        Me.TxtNh_Kh1.FilterClient = ""
        Me.TxtNh_Kh1.FilterSQL = ""
        Me.TxtNh_Kh1.Location = New System.Drawing.Point(95, 92)
        Me.TxtNh_Kh1.Name = "TxtNh_Kh1"
        Me.TxtNh_Kh1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kh1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kh1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kh1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Kh1.TabIndex = 4
        Me.TxtNh_Kh1.Table_Name = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(7, 217)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 360
        Me.Label18.Tag = "Group by"
        Me.Label18.Text = "Nhóm theo"
        '
        'ChkGroup3
        '
        Me.ChkGroup3.AutoSize = True
        Me.ChkGroup3.ForeColor = System.Drawing.Color.Navy
        Me.ChkGroup3.Location = New System.Drawing.Point(353, 215)
        Me.ChkGroup3.Name = "ChkGroup3"
        Me.ChkGroup3.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup3.TabIndex = 10
        Me.ChkGroup3.Tag = "Group by 3"
        Me.ChkGroup3.Text = "Theo nhóm 3"
        Me.ChkGroup3.UseVisualStyleBackColor = True
        '
        'ChkGroup2
        '
        Me.ChkGroup2.AutoSize = True
        Me.ChkGroup2.ForeColor = System.Drawing.Color.Navy
        Me.ChkGroup2.Location = New System.Drawing.Point(211, 215)
        Me.ChkGroup2.Name = "ChkGroup2"
        Me.ChkGroup2.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup2.TabIndex = 9
        Me.ChkGroup2.Tag = "Group by 2"
        Me.ChkGroup2.Text = "Theo nhóm 2"
        Me.ChkGroup2.UseVisualStyleBackColor = True
        '
        'ChkGroup1
        '
        Me.ChkGroup1.AutoSize = True
        Me.ChkGroup1.ForeColor = System.Drawing.Color.Navy
        Me.ChkGroup1.Location = New System.Drawing.Point(95, 215)
        Me.ChkGroup1.Name = "ChkGroup1"
        Me.ChkGroup1.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup1.TabIndex = 8
        Me.ChkGroup1.Tag = "Group by 1"
        Me.ChkGroup1.Text = "Theo nhóm 1"
        Me.ChkGroup1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 17)
        Me.Label12.TabIndex = 2207
        Me.Label12.Tag = "Corresponding acc"
        Me.Label12.Text = "0 - Kê khai thuế, 1 - Không kê khai thuế"
        '
        'TxtNonVat
        '
        Me.TxtNonVat._ActilookupPopup = False
        Me.TxtNonVat.CyberActilookupPopup = True
        Me.TxtNonVat.Dv_ListDetail = Nothing
        Me.TxtNonVat.Dv_Master = Nothing
        Me.TxtNonVat.FilterClient = ""
        Me.TxtNonVat.FilterSQL = ""
        Me.TxtNonVat.Location = New System.Drawing.Point(95, 155)
        Me.TxtNonVat.Name = "TxtNonVat"
        Me.TxtNonVat.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNonVat.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNonVat.Properties.Appearance.Options.UseFont = True
        Me.TxtNonVat.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNonVat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNonVat.Size = New System.Drawing.Size(114, 20)
        Me.TxtNonVat.TabIndex = 7
        Me.TxtNonVat.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(9, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 2206
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(9, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 2209
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Xưởng"
        '
        'CmbMa_TTCP
        '
        Me.CmbMa_TTCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbMa_TTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TTCP.FormattingEnabled = True
        Me.CmbMa_TTCP.Location = New System.Drawing.Point(95, 176)
        Me.CmbMa_TTCP.Name = "CmbMa_TTCP"
        Me.CmbMa_TTCP.Size = New System.Drawing.Size(158, 21)
        Me.CmbMa_TTCP.TabIndex = 2208
        '
        'ARCD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 350)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CmbMa_TTCP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ChkGroup3)
        Me.Controls.Add(Me.ChkGroup2)
        Me.Controls.Add(Me.ChkGroup1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_Kh3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_Kh2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_Kh1)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Tk_CN)
        Me.Controls.Add(Me.Txtten_Tk_CN)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "ARCD1"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kh3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup1, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup2, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup3, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kh1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk_CN As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk_CN As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kh3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kh2 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kh1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ChkGroup3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGroup2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGroup1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TTCP As System.Windows.Forms.ComboBox

End Class
