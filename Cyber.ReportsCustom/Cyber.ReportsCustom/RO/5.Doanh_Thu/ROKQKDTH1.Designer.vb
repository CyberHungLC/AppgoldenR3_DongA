<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ROKQKDTH1
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTCP = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNh_Vt1 = New Cyber.SmLists.TxtLookup()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNh_CV1 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_CV = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cv = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_NhVt1 = New System.Windows.Forms.TextBox()
        Me.TxtTen_NhCV1 = New System.Windows.Forms.TextBox()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CV1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(431, 234)
        Me.ButtExit.TabIndex = 13
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 199)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(420, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 202)
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(327, 234)
        Me.ButtOK.TabIndex = 12
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 243)
        Me.LabLoai_NT.Size = New System.Drawing.Size(62, 13)
        Me.LabLoai_NT.TabIndex = 12
        Me.LabLoai_NT.Visible = False
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(118, 241)
        Me.ChkVND.TabIndex = 10
        Me.ChkVND.Visible = False
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(232, 241)
        Me.ChkNT.TabIndex = 11
        Me.ChkNT.Visible = False
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 3)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(107, 26)
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
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 8
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(15, 30)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 217)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(528, 9)
        Me.GroupBoxLine.TabIndex = 18
        Me.GroupBoxLine.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 548
        Me.Label18.Tag = "Staff"
        Me.Label18.Text = "Xưởng"
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Enabled = False
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(227, 180)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_TTCP.TabIndex = 547
        Me.TxtTen_TTCP.TabStop = False
        '
        'TxtMa_TTCP
        '
        Me.TxtMa_TTCP._ActilookupPopup = False
        Me.TxtMa_TTCP.CyberActilookupPopup = True
        Me.TxtMa_TTCP.Dv_ListDetail = Nothing
        Me.TxtMa_TTCP.Dv_Master = Nothing
        Me.TxtMa_TTCP.FilterClient = ""
        Me.TxtMa_TTCP.FilterSQL = ""
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(107, 177)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_TTCP.TabIndex = 8
        Me.TxtMa_TTCP.Table_Name = ""
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(15, 52)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(55, 13)
        Me.LabMa_Hs.TabIndex = 551
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Nhân viên"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(227, 50)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_Hs.TabIndex = 550
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(107, 48)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 2
        Me.TxtMa_Hs.Table_Name = ""
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(15, 74)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(66, 13)
        Me.LabSo_Ct1.TabIndex = 553
        Me.LabSo_Ct1.Tag = "Voucher from"
        Me.LabSo_Ct1.Text = "Lệnh RO"
        '
        'TxtNh_Vt1
        '
        Me.TxtNh_Vt1._ActilookupPopup = False
        Me.TxtNh_Vt1.CyberActilookupPopup = True
        Me.TxtNh_Vt1.Dv_ListDetail = Nothing
        Me.TxtNh_Vt1.Dv_Master = Nothing
        Me.TxtNh_Vt1.FilterClient = ""
        Me.TxtNh_Vt1.FilterSQL = ""
        Me.TxtNh_Vt1.Location = New System.Drawing.Point(107, 113)
        Me.TxtNh_Vt1.Name = "TxtNh_Vt1"
        Me.TxtNh_Vt1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt1.TabIndex = 5
        Me.TxtNh_Vt1.Table_Name = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 558
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Nhóm vật tư 1"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(227, 95)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_vt.TabIndex = 557
        Me.TxtTen_vt.TabStop = False
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.EditValue = ""
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(107, 92)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_vt.TabIndex = 4
        Me.TxtMa_vt.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(15, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 556
        Me.Label6.Tag = "Supplies "
        Me.Label6.Text = "Vật tư"
        '
        'TxtNh_CV1
        '
        Me.TxtNh_CV1._ActilookupPopup = False
        Me.TxtNh_CV1.CyberActilookupPopup = True
        Me.TxtNh_CV1.Dv_ListDetail = Nothing
        Me.TxtNh_CV1.Dv_Master = Nothing
        Me.TxtNh_CV1.FilterClient = ""
        Me.TxtNh_CV1.FilterSQL = ""
        Me.TxtNh_CV1.Location = New System.Drawing.Point(107, 156)
        Me.TxtNh_CV1.Name = "TxtNh_CV1"
        Me.TxtNh_CV1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CV1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CV1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CV1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CV1.TabIndex = 7
        Me.TxtNh_CV1.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 563
        Me.Label2.Tag = "Group 1"
        Me.Label2.Text = "Nhóm công việc 1"
        '
        'TxtTen_CV
        '
        Me.TxtTen_CV.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_CV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_CV.Enabled = False
        Me.TxtTen_CV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CV.Location = New System.Drawing.Point(227, 137)
        Me.TxtTen_CV.Name = "TxtTen_CV"
        Me.TxtTen_CV.ReadOnly = True
        Me.TxtTen_CV.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_CV.TabIndex = 562
        Me.TxtTen_CV.TabStop = False
        '
        'TxtMa_Cv
        '
        Me.TxtMa_Cv._ActilookupPopup = False
        Me.TxtMa_Cv.CyberActilookupPopup = True
        Me.TxtMa_Cv.Dv_ListDetail = Nothing
        Me.TxtMa_Cv.Dv_Master = Nothing
        Me.TxtMa_Cv.EditValue = ""
        Me.TxtMa_Cv.FilterClient = ""
        Me.TxtMa_Cv.FilterSQL = ""
        Me.TxtMa_Cv.Location = New System.Drawing.Point(107, 134)
        Me.TxtMa_Cv.Name = "TxtMa_Cv"
        Me.TxtMa_Cv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cv.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Cv.TabIndex = 6
        Me.TxtMa_Cv.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(15, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 561
        Me.Label3.Tag = "Supplies "
        Me.Label3.Text = "Công việc"
        '
        'TxtTen_NhVt1
        '
        Me.TxtTen_NhVt1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_NhVt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NhVt1.Enabled = False
        Me.TxtTen_NhVt1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhVt1.Location = New System.Drawing.Point(227, 116)
        Me.TxtTen_NhVt1.Name = "TxtTen_NhVt1"
        Me.TxtTen_NhVt1.ReadOnly = True
        Me.TxtTen_NhVt1.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_NhVt1.TabIndex = 564
        Me.TxtTen_NhVt1.TabStop = False
        '
        'TxtTen_NhCV1
        '
        Me.TxtTen_NhCV1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_NhCV1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NhCV1.Enabled = False
        Me.TxtTen_NhCV1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCV1.Location = New System.Drawing.Point(227, 159)
        Me.TxtTen_NhCV1.Name = "TxtTen_NhCV1"
        Me.TxtTen_NhCV1.ReadOnly = True
        Me.TxtTen_NhCV1.Size = New System.Drawing.Size(304, 14)
        Me.TxtTen_NhCV1.TabIndex = 565
        Me.TxtTen_NhCV1.TabStop = False
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(107, 70)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(114, 21)
        Me.TxtSo_RO.TabIndex = 3
        '
        'ROKQKDTH1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(535, 287)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.TxtTen_NhCV1)
        Me.Controls.Add(Me.TxtTen_NhVt1)
        Me.Controls.Add(Me.TxtNh_CV1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_CV)
        Me.Controls.Add(Me.TxtMa_Cv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNh_Vt1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "ROKQKDTH1"
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
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CV, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CV1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhVt1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCV1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CV1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTen_TTCP As TextBox
    Friend WithEvents TxtMa_TTCP As SmLists.TxtLookup
    Friend WithEvents LabMa_Hs As Label
    Friend WithEvents TxtTen_Hs As TextBox
    Friend WithEvents TxtMa_Hs As SmLists.TxtLookup
    Friend WithEvents LabSo_Ct1 As Label
    Friend WithEvents TxtNh_Vt1 As SmLists.TxtLookup
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTen_vt As TextBox
    Friend WithEvents TxtMa_vt As SmLists.TxtLookup
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNh_CV1 As SmLists.TxtLookup
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTen_CV As TextBox
    Friend WithEvents TxtMa_Cv As SmLists.TxtLookup
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_NhVt1 As TextBox
    Friend WithEvents TxtTen_NhCV1 As TextBox
    Friend WithEvents TxtSo_RO As TextBox
End Class
