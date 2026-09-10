<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INVTANLYSIS
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
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk_Vt = New System.Windows.Forms.TextBox()
        Me.TxtTk_Vt = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Vt3 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt2 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt1 = New System.Windows.Forms.TextBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt3 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt1 = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(726, 223)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(120, 178)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(741, 25)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(588, 223)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 153)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(120, 153)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(279, 153)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(120, 7)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(145, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 10)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 207)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(856, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(13, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 338
        Me.Label6.Tag = "Supplies "
        Me.Label6.Text = "Mã vật tư"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(279, 65)
        Me.TxtTen_vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(582, 17)
        Me.TxtTen_vt.TabIndex = 340
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
        Me.TxtMa_vt.Location = New System.Drawing.Point(120, 61)
        Me.TxtMa_vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_vt.TabIndex = 2
        Me.TxtMa_vt.Table_Name = ""
        '
        'TxtTen_Tk_Vt
        '
        Me.TxtTen_Tk_Vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Tk_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk_Vt.Enabled = False
        Me.TxtTen_Tk_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_Vt.Location = New System.Drawing.Point(279, 94)
        Me.TxtTen_Tk_Vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Tk_Vt.Name = "TxtTen_Tk_Vt"
        Me.TxtTen_Tk_Vt.ReadOnly = True
        Me.TxtTen_Tk_Vt.Size = New System.Drawing.Size(582, 17)
        Me.TxtTen_Tk_Vt.TabIndex = 343
        Me.TxtTen_Tk_Vt.TabStop = False
        '
        'TxtTk_Vt
        '
        Me.TxtTk_Vt._ActilookupPopup = False
        Me.TxtTk_Vt.CyberActilookupPopup = True
        Me.TxtTk_Vt.Dv_ListDetail = Nothing
        Me.TxtTk_Vt.Dv_Master = Nothing
        Me.TxtTk_Vt.EditValue = ""
        Me.TxtTk_Vt.FilterClient = ""
        Me.TxtTk_Vt.FilterSQL = ""
        Me.TxtTk_Vt.Location = New System.Drawing.Point(120, 90)
        Me.TxtTk_Vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTk_Vt.Name = "TxtTk_Vt"
        Me.TxtTk_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Vt.Size = New System.Drawing.Size(147, 22)
        Me.TxtTk_Vt.TabIndex = 3
        Me.TxtTk_Vt.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 342
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Tk vật tư"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(562, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 349
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm vật tư 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(279, 123)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 17)
        Me.Label13.TabIndex = 348
        Me.Label13.Tag = "Group 2"
        Me.Label13.Text = "Nhóm vật tư 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 123)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 17)
        Me.Label14.TabIndex = 347
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Nhóm vật tư 1"
        '
        'TxtTen_Nh_Vt3
        '
        Me.TxtTen_Nh_Vt3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt3.Enabled = False
        Me.TxtTen_Nh_Vt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt3.Location = New System.Drawing.Point(212, 284)
        Me.TxtTen_Nh_Vt3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nh_Vt3.Name = "TxtTen_Nh_Vt3"
        Me.TxtTen_Nh_Vt3.ReadOnly = True
        Me.TxtTen_Nh_Vt3.Size = New System.Drawing.Size(235, 24)
        Me.TxtTen_Nh_Vt3.TabIndex = 352
        Me.TxtTen_Nh_Vt3.TabStop = False
        Me.TxtTen_Nh_Vt3.Visible = False
        '
        'TxtTen_Nh_Vt2
        '
        Me.TxtTen_Nh_Vt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt2.Enabled = False
        Me.TxtTen_Nh_Vt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt2.Location = New System.Drawing.Point(212, 255)
        Me.TxtTen_Nh_Vt2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nh_Vt2.Name = "TxtTen_Nh_Vt2"
        Me.TxtTen_Nh_Vt2.ReadOnly = True
        Me.TxtTen_Nh_Vt2.Size = New System.Drawing.Size(235, 24)
        Me.TxtTen_Nh_Vt2.TabIndex = 351
        Me.TxtTen_Nh_Vt2.TabStop = False
        Me.TxtTen_Nh_Vt2.Visible = False
        '
        'TxtTen_Nh_Vt1
        '
        Me.TxtTen_Nh_Vt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Nh_Vt1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt1.Enabled = False
        Me.TxtTen_Nh_Vt1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt1.Location = New System.Drawing.Point(212, 226)
        Me.TxtTen_Nh_Vt1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nh_Vt1.Name = "TxtTen_Nh_Vt1"
        Me.TxtTen_Nh_Vt1.ReadOnly = True
        Me.TxtTen_Nh_Vt1.Size = New System.Drawing.Size(235, 24)
        Me.TxtTen_Nh_Vt1.TabIndex = 350
        Me.TxtTen_Nh_Vt1.TabStop = False
        Me.TxtTen_Nh_Vt1.Visible = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(13, 36)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(88, 17)
        Me.LabMa_kho.TabIndex = 355
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(279, 39)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(582, 17)
        Me.TxtTen_kho.TabIndex = 354
        Me.TxtTen_kho.TabStop = False
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(120, 35)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_kho.TabIndex = 1
        Me.TxtMa_kho.Table_Name = ""
        '
        'TxtNh_Vt3
        '
        Me.TxtNh_Vt3._ActilookupPopup = False
        Me.TxtNh_Vt3.CyberActilookupPopup = True
        Me.TxtNh_Vt3.Dv_ListDetail = Nothing
        Me.TxtNh_Vt3.Dv_Master = Nothing
        Me.TxtNh_Vt3.FilterClient = ""
        Me.TxtNh_Vt3.FilterSQL = ""
        Me.TxtNh_Vt3.Location = New System.Drawing.Point(668, 119)
        Me.TxtNh_Vt3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Vt3.Name = "TxtNh_Vt3"
        Me.TxtNh_Vt3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_Vt3.TabIndex = 6
        Me.TxtNh_Vt3.Table_Name = ""
        '
        'TxtNh_Vt2
        '
        Me.TxtNh_Vt2._ActilookupPopup = False
        Me.TxtNh_Vt2.CyberActilookupPopup = True
        Me.TxtNh_Vt2.Dv_ListDetail = Nothing
        Me.TxtNh_Vt2.Dv_Master = Nothing
        Me.TxtNh_Vt2.FilterClient = ""
        Me.TxtNh_Vt2.FilterSQL = ""
        Me.TxtNh_Vt2.Location = New System.Drawing.Point(396, 119)
        Me.TxtNh_Vt2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Vt2.Name = "TxtNh_Vt2"
        Me.TxtNh_Vt2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt2.Size = New System.Drawing.Size(131, 22)
        Me.TxtNh_Vt2.TabIndex = 5
        Me.TxtNh_Vt2.Table_Name = ""
        '
        'TxtNh_Vt1
        '
        Me.TxtNh_Vt1._ActilookupPopup = False
        Me.TxtNh_Vt1.CyberActilookupPopup = True
        Me.TxtNh_Vt1.Dv_ListDetail = Nothing
        Me.TxtNh_Vt1.Dv_Master = Nothing
        Me.TxtNh_Vt1.FilterClient = ""
        Me.TxtNh_Vt1.FilterSQL = ""
        Me.TxtNh_Vt1.Location = New System.Drawing.Point(120, 119)
        Me.TxtNh_Vt1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Vt1.Name = "TxtNh_Vt1"
        Me.TxtNh_Vt1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_Vt1.TabIndex = 4
        Me.TxtNh_Vt1.Table_Name = ""
        '
        'INVTANLYSIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(865, 298)
        Me.Controls.Add(Me.TxtNh_Vt3)
        Me.Controls.Add(Me.TxtNh_Vt2)
        Me.Controls.Add(Me.TxtNh_Vt1)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtTen_Nh_Vt3)
        Me.Controls.Add(Me.TxtTen_Nh_Vt2)
        Me.Controls.Add(Me.TxtTen_Nh_Vt1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTen_Tk_Vt)
        Me.Controls.Add(Me.TxtTk_Vt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(646, 222)
        Me.Name = "INVTANLYSIS"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt3, 0)
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Vt3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh_Vt2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh_Vt1 As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt2 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt1 As Cyber.SmLists.TxtLookup
End Class
