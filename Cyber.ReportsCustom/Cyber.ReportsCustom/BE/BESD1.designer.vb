<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BESD1
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
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx5 = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx4 = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx3 = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx2 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx1 = New Cyber.SmLists.TxtLookup()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 280)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 241)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(497, 21)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 244)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 280)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 222)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 219)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 219)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 3)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 0
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 6)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 263)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(10, 28)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_Kho
        '
        Me.TxtTen_Kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kho.Enabled = False
        Me.TxtTen_Kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kho.Location = New System.Drawing.Point(216, 28)
        Me.TxtTen_Kho.Name = "TxtTen_Kho"
        Me.TxtTen_Kho.ReadOnly = True
        Me.TxtTen_Kho.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Kho.TabIndex = 193
        Me.TxtTen_Kho.TabStop = False
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho._ActilookupPopup = False
        Me.TxtMa_Kho.CyberActilookupPopup = True
        Me.TxtMa_Kho.Dv_ListDetail = Nothing
        Me.TxtMa_Kho.Dv_Master = Nothing
        Me.TxtMa_Kho.FilterClient = ""
        Me.TxtMa_Kho.FilterSQL = ""
        Me.TxtMa_Kho.Location = New System.Drawing.Point(95, 25)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kho.TabIndex = 1
        Me.TxtMa_Kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(10, 52)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Type car"
        Me.LabMa_Cc.Text = "Mã kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(216, 49)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Kx.TabIndex = 196
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(95, 46)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kx.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kx.TabIndex = 2
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 199
        Me.Label2.Tag = "Color"
        Me.Label2.Text = "Mã màu"
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(95, 172)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Mau.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Mau.TabIndex = 8
        Me.TxtMa_Mau.Table_Name = ""
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(214, 175)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Mau.TabIndex = 200
        Me.TxtTen_Mau.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 439
        Me.Label9.Tag = "Case"
        Me.Label9.Text = "Nhóm kiểu xe 5"
        '
        'TxtTen_Nh_Kx5
        '
        Me.TxtTen_Nh_Kx5.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx5.Enabled = False
        Me.TxtTen_Nh_Kx5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx5.Location = New System.Drawing.Point(216, 154)
        Me.TxtTen_Nh_Kx5.Name = "TxtTen_Nh_Kx5"
        Me.TxtTen_Nh_Kx5.ReadOnly = True
        Me.TxtTen_Nh_Kx5.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Nh_Kx5.TabIndex = 438
        Me.TxtTen_Nh_Kx5.TabStop = False
        '
        'TxtNh_Kx5
        '
        Me.TxtNh_Kx5._ActilookupPopup = False
        Me.TxtNh_Kx5.CyberActilookupPopup = True
        Me.TxtNh_Kx5.Dv_ListDetail = Nothing
        Me.TxtNh_Kx5.Dv_Master = Nothing
        Me.TxtNh_Kx5.FilterClient = ""
        Me.TxtNh_Kx5.FilterSQL = ""
        Me.TxtNh_Kx5.Location = New System.Drawing.Point(95, 151)
        Me.TxtNh_Kx5.Name = "TxtNh_Kx5"
        Me.TxtNh_Kx5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx5.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx5.TabIndex = 7
        Me.TxtNh_Kx5.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 437
        Me.Label8.Tag = "Case"
        Me.Label8.Text = "Nhóm kiểu xe 4"
        '
        'TxtTen_Nh_Kx4
        '
        Me.TxtTen_Nh_Kx4.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx4.Enabled = False
        Me.TxtTen_Nh_Kx4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx4.Location = New System.Drawing.Point(216, 133)
        Me.TxtTen_Nh_Kx4.Name = "TxtTen_Nh_Kx4"
        Me.TxtTen_Nh_Kx4.ReadOnly = True
        Me.TxtTen_Nh_Kx4.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Nh_Kx4.TabIndex = 436
        Me.TxtTen_Nh_Kx4.TabStop = False
        '
        'TxtNh_Kx4
        '
        Me.TxtNh_Kx4._ActilookupPopup = False
        Me.TxtNh_Kx4.CyberActilookupPopup = True
        Me.TxtNh_Kx4.Dv_ListDetail = Nothing
        Me.TxtNh_Kx4.Dv_Master = Nothing
        Me.TxtNh_Kx4.FilterClient = ""
        Me.TxtNh_Kx4.FilterSQL = ""
        Me.TxtNh_Kx4.Location = New System.Drawing.Point(95, 130)
        Me.TxtNh_Kx4.Name = "TxtNh_Kx4"
        Me.TxtNh_Kx4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx4.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx4.TabIndex = 6
        Me.TxtNh_Kx4.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 435
        Me.Label7.Tag = "Case"
        Me.Label7.Text = "Nhóm kiểu xe 3"
        '
        'TxtTen_Nh_Kx3
        '
        Me.TxtTen_Nh_Kx3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx3.Enabled = False
        Me.TxtTen_Nh_Kx3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx3.Location = New System.Drawing.Point(216, 112)
        Me.TxtTen_Nh_Kx3.Name = "TxtTen_Nh_Kx3"
        Me.TxtTen_Nh_Kx3.ReadOnly = True
        Me.TxtTen_Nh_Kx3.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Nh_Kx3.TabIndex = 434
        Me.TxtTen_Nh_Kx3.TabStop = False
        '
        'TxtNh_Kx3
        '
        Me.TxtNh_Kx3._ActilookupPopup = False
        Me.TxtNh_Kx3.CyberActilookupPopup = True
        Me.TxtNh_Kx3.Dv_ListDetail = Nothing
        Me.TxtNh_Kx3.Dv_Master = Nothing
        Me.TxtNh_Kx3.FilterClient = ""
        Me.TxtNh_Kx3.FilterSQL = ""
        Me.TxtNh_Kx3.Location = New System.Drawing.Point(95, 109)
        Me.TxtNh_Kx3.Name = "TxtNh_Kx3"
        Me.TxtNh_Kx3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx3.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx3.TabIndex = 5
        Me.TxtNh_Kx3.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 433
        Me.Label6.Tag = "Case"
        Me.Label6.Text = "Nhóm kiểu xe 2"
        '
        'TxtTen_Nh_Kx2
        '
        Me.TxtTen_Nh_Kx2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx2.Enabled = False
        Me.TxtTen_Nh_Kx2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx2.Location = New System.Drawing.Point(216, 91)
        Me.TxtTen_Nh_Kx2.Name = "TxtTen_Nh_Kx2"
        Me.TxtTen_Nh_Kx2.ReadOnly = True
        Me.TxtTen_Nh_Kx2.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Nh_Kx2.TabIndex = 432
        Me.TxtTen_Nh_Kx2.TabStop = False
        '
        'TxtNh_Kx2
        '
        Me.TxtNh_Kx2._ActilookupPopup = False
        Me.TxtNh_Kx2.CyberActilookupPopup = True
        Me.TxtNh_Kx2.Dv_ListDetail = Nothing
        Me.TxtNh_Kx2.Dv_Master = Nothing
        Me.TxtNh_Kx2.FilterClient = ""
        Me.TxtNh_Kx2.FilterSQL = ""
        Me.TxtNh_Kx2.Location = New System.Drawing.Point(95, 88)
        Me.TxtNh_Kx2.Name = "TxtNh_Kx2"
        Me.TxtNh_Kx2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx2.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx2.TabIndex = 4
        Me.TxtNh_Kx2.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 431
        Me.Label5.Tag = "Case"
        Me.Label5.Text = "Nhóm kiểu xe 1"
        '
        'TxtTen_Nh_Kx1
        '
        Me.TxtTen_Nh_Kx1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx1.Enabled = False
        Me.TxtTen_Nh_Kx1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx1.Location = New System.Drawing.Point(216, 70)
        Me.TxtTen_Nh_Kx1.Name = "TxtTen_Nh_Kx1"
        Me.TxtTen_Nh_Kx1.ReadOnly = True
        Me.TxtTen_Nh_Kx1.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Nh_Kx1.TabIndex = 430
        Me.TxtTen_Nh_Kx1.TabStop = False
        '
        'TxtNh_Kx1
        '
        Me.TxtNh_Kx1._ActilookupPopup = False
        Me.TxtNh_Kx1.CyberActilookupPopup = True
        Me.TxtNh_Kx1.Dv_ListDetail = Nothing
        Me.TxtNh_Kx1.Dv_Master = Nothing
        Me.TxtNh_Kx1.FilterClient = ""
        Me.TxtNh_Kx1.FilterSQL = ""
        Me.TxtNh_Kx1.Location = New System.Drawing.Point(95, 67)
        Me.TxtNh_Kx1.Name = "TxtNh_Kx1"
        Me.TxtNh_Kx1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx1.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx1.TabIndex = 3
        Me.TxtNh_Kx1.Table_Name = ""
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.BackColor = System.Drawing.Color.White
        Me.TxtSo_Khung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(95, 193)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(246, 20)
        Me.TxtSo_Khung.TabIndex = 9
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(10, 195)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(82, 14)
        Me.LabDien_Giai.TabIndex = 441
        Me.LabDien_Giai.Tag = "Note"
        Me.LabDien_Giai.Text = "Số khung"
        '
        'BESD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 333)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Nh_Kx5)
        Me.Controls.Add(Me.TxtNh_Kx5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Nh_Kx4)
        Me.Controls.Add(Me.TxtNh_Kx4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_Nh_Kx3)
        Me.Controls.Add(Me.TxtNh_Kx3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Nh_Kx2)
        Me.Controls.Add(Me.TxtNh_Kx2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nh_Kx1)
        Me.Controls.Add(Me.TxtNh_Kx1)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BESD1"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx4, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx5, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx5 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label

End Class
