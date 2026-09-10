<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLCD1_BPPhi
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
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ChkM_LK = New System.Windows.Forms.CheckBox()
        Me.CmbM_Bac_TK = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Phi = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNh_BP1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_BP1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNh_Phi1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_Phi1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Phi = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_BP1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Phi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Phi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(713, 292)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(153, 241)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(693, 25)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 245)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(575, 292)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 213)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(153, 212)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(279, 213)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(153, 9)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(153, 39)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "__/__/____"
        Me.TxtNgay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 12)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(13, 43)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 270)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(843, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'ChkM_LK
        '
        Me.ChkM_LK.Location = New System.Drawing.Point(469, 47)
        Me.ChkM_LK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_LK.Name = "ChkM_LK"
        Me.ChkM_LK.Size = New System.Drawing.Size(347, 24)
        Me.ChkM_LK.TabIndex = 11
        Me.ChkM_LK.Tag = "Accumulated charge incurred"
        Me.ChkM_LK.Text = "Tính phát sinh lũy kế"
        Me.ChkM_LK.UseVisualStyleBackColor = True
        '
        'CmbM_Bac_TK
        '
        Me.CmbM_Bac_TK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbM_Bac_TK.ForeColor = System.Drawing.Color.Navy
        Me.CmbM_Bac_TK.FormattingEnabled = True
        Me.CmbM_Bac_TK.Location = New System.Drawing.Point(469, 12)
        Me.CmbM_Bac_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbM_Bac_TK.Name = "CmbM_Bac_TK"
        Me.CmbM_Bac_TK.Size = New System.Drawing.Size(335, 25)
        Me.CmbM_Bac_TK.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Tag = "Account Level"
        Me.Label3.Text = "Bậc tài khoản"
        '
        'TxtTen_Phi
        '
        Me.TxtTen_Phi.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Phi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Phi.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Phi.Location = New System.Drawing.Point(311, 157)
        Me.TxtTen_Phi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Phi.Name = "TxtTen_Phi"
        Me.TxtTen_Phi.ReadOnly = True
        Me.TxtTen_Phi.Size = New System.Drawing.Size(536, 16)
        Me.TxtTen_Phi.TabIndex = 159
        Me.TxtTen_Phi.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(153, 97)
        Me.TxtMa_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(152, 24)
        Me.TxtMa_BP.TabIndex = 3
        Me.TxtMa_BP.Table_Name = ""
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(311, 102)
        Me.TxtTen_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(536, 16)
        Me.TxtTen_BP.TabIndex = 157
        Me.TxtTen_BP.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 156
        Me.Label2.Tag = "Account"
        Me.Label2.Text = "Bộ phận"
        '
        'TxtNh_BP1
        '
        Me.TxtNh_BP1._ActilookupPopup = False
        Me.TxtNh_BP1.CyberActilookupPopup = True
        Me.TxtNh_BP1.Dv_ListDetail = Nothing
        Me.TxtNh_BP1.Dv_Master = Nothing
        Me.TxtNh_BP1.FilterClient = ""
        Me.TxtNh_BP1.FilterSQL = ""
        Me.TxtNh_BP1.Location = New System.Drawing.Point(153, 69)
        Me.TxtNh_BP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_BP1.Name = "TxtNh_BP1"
        Me.TxtNh_BP1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_BP1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_BP1.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_BP1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_BP1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_BP1.Size = New System.Drawing.Size(152, 24)
        Me.TxtNh_BP1.TabIndex = 2
        Me.TxtNh_BP1.Table_Name = ""
        '
        'TxtTen_Nh_BP1
        '
        Me.TxtTen_Nh_BP1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_BP1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_BP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_BP1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_BP1.Location = New System.Drawing.Point(311, 75)
        Me.TxtTen_Nh_BP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh_BP1.Name = "TxtTen_Nh_BP1"
        Me.TxtTen_Nh_BP1.ReadOnly = True
        Me.TxtTen_Nh_BP1.Size = New System.Drawing.Size(536, 16)
        Me.TxtTen_Nh_BP1.TabIndex = 162
        Me.TxtTen_Nh_BP1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 161
        Me.Label5.Tag = "Account"
        Me.Label5.Text = "Nhóm Bộ phận 1"
        '
        'TxtNh_Phi1
        '
        Me.TxtNh_Phi1._ActilookupPopup = False
        Me.TxtNh_Phi1.CyberActilookupPopup = True
        Me.TxtNh_Phi1.Dv_ListDetail = Nothing
        Me.TxtNh_Phi1.Dv_Master = Nothing
        Me.TxtNh_Phi1.FilterClient = ""
        Me.TxtNh_Phi1.FilterSQL = ""
        Me.TxtNh_Phi1.Location = New System.Drawing.Point(153, 124)
        Me.TxtNh_Phi1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_Phi1.Name = "TxtNh_Phi1"
        Me.TxtNh_Phi1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_Phi1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Phi1.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_Phi1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Phi1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Phi1.Size = New System.Drawing.Size(152, 24)
        Me.TxtNh_Phi1.TabIndex = 4
        Me.TxtNh_Phi1.Table_Name = ""
        '
        'TxtTen_Nh_Phi1
        '
        Me.TxtTen_Nh_Phi1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Phi1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Phi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_Phi1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Phi1.Location = New System.Drawing.Point(311, 129)
        Me.TxtTen_Nh_Phi1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh_Phi1.Name = "TxtTen_Nh_Phi1"
        Me.TxtTen_Nh_Phi1.ReadOnly = True
        Me.TxtTen_Nh_Phi1.Size = New System.Drawing.Size(536, 16)
        Me.TxtTen_Nh_Phi1.TabIndex = 165
        Me.TxtTen_Nh_Phi1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 164
        Me.Label6.Tag = "Account"
        Me.Label6.Text = "Nhóm khoản mục 1"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(315, 183)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(288, 22)
        Me.Label12.TabIndex = 2213
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
        Me.TxtNonVat.Location = New System.Drawing.Point(153, 179)
        Me.TxtNonVat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNonVat.Name = "TxtNonVat"
        Me.TxtNonVat.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNonVat.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNonVat.Properties.Appearance.Options.UseFont = True
        Me.TxtNonVat.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNonVat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNonVat.Size = New System.Drawing.Size(152, 24)
        Me.TxtNonVat.TabIndex = 6
        Me.TxtNonVat.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(13, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 22)
        Me.Label11.TabIndex = 2212
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        '
        'TxtMa_Phi
        '
        Me.TxtMa_Phi._ActilookupPopup = False
        Me.TxtMa_Phi.CyberActilookupPopup = True
        Me.TxtMa_Phi.Dv_ListDetail = Nothing
        Me.TxtMa_Phi.Dv_Master = Nothing
        Me.TxtMa_Phi.FilterClient = ""
        Me.TxtMa_Phi.FilterSQL = ""
        Me.TxtMa_Phi.Location = New System.Drawing.Point(153, 152)
        Me.TxtMa_Phi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Phi.Name = "TxtMa_Phi"
        Me.TxtMa_Phi.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Phi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Phi.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Phi.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Phi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Phi.Size = New System.Drawing.Size(152, 24)
        Me.TxtMa_Phi.TabIndex = 5
        Me.TxtMa_Phi.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 158
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Khoản mục phí"
        '
        'GLCD1_BPPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(852, 361)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNh_Phi1)
        Me.Controls.Add(Me.TxtTen_Nh_Phi1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNh_BP1)
        Me.Controls.Add(Me.TxtTen_Nh_BP1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Phi)
        Me.Controls.Add(Me.TxtTen_Phi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbM_Bac_TK)
        Me.Controls.Add(Me.ChkM_LK)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLCD1_BPPhi"
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ChkM_LK, 0)
        Me.Controls.SetChildIndex(Me.CmbM_Bac_TK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_BP1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_BP1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Phi1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Phi1, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_BP1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Phi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Phi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ChkM_LK As System.Windows.Forms.CheckBox
    Friend WithEvents CmbM_Bac_TK As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Phi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_BP1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_BP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_Phi1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_Phi1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Phi As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
