<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMGIAXE
    Inherits Cyber.From.FrmList

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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_KX = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_ban = New ClsTextBox.txtDate1()
        Me.TxtGia_nt2 = New ClsTextBox.txtTy_Gia()
        Me.TxtGia_nt3 = New ClsTextBox.txtTy_Gia()
        Me.TxtGia3 = New ClsTextBox.txtTy_Gia()
        Me.Txtgia2 = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.Labgia3 = New System.Windows.Forms.Label()
        Me.Labgia2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGia = New ClsTextBox.txtTy_Gia()
        Me.TxtGia_NT = New ClsTextBox.txtTy_Gia()
        Me.TxtDat_Coc = New ClsTextBox.txtTy_Gia()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNam_SX = New ClsTextBox.txtTy_Gia()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TxtHoldBack = New ClsTextBox.txtTy_Gia()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGia_NT_VAT = New ClsTextBox.txtTy_Gia()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(566, 254)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(464, 254)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(340, 261)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 263)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 244)
        Me.GroupBoxLine.Size = New System.Drawing.Size(664, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_vt
        '
        Me.LabMa_vt.AutoSize = True
        Me.LabMa_vt.Location = New System.Drawing.Point(3, 7)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(58, 13)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Mã kiểu xe"
        '
        'LabMa_kho
        '
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(3, 29)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(44, 13)
        Me.LabMa_kho.TabIndex = 21
        Me.LabMa_kho.Tag = "Colour"
        Me.LabMa_kho.Text = "Mã màu"
        '
        'TxtTen_KX
        '
        Me.TxtTen_KX.BackColor = System.Drawing.Color.White
        Me.TxtTen_KX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KX.Enabled = False
        Me.TxtTen_KX.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KX.Location = New System.Drawing.Point(278, 7)
        Me.TxtTen_KX.Name = "TxtTen_KX"
        Me.TxtTen_KX.ReadOnly = True
        Me.TxtTen_KX.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_KX.TabIndex = 382
        Me.TxtTen_KX.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(125, 4)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_KX.TabIndex = 0
        Me.TxtMa_KX.Table_Name = ""
        '
        'TxtTen_mau
        '
        Me.TxtTen_mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_mau.Enabled = False
        Me.TxtTen_mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_mau.Location = New System.Drawing.Point(278, 29)
        Me.TxtTen_mau.Name = "TxtTen_mau"
        Me.TxtTen_mau.ReadOnly = True
        Me.TxtTen_mau.Size = New System.Drawing.Size(227, 14)
        Me.TxtTen_mau.TabIndex = 384
        Me.TxtTen_mau.TabStop = False
        '
        'TxtMa_mau
        '
        Me.TxtMa_mau._ActilookupPopup = False
        Me.TxtMa_mau.CyberActilookupPopup = True
        Me.TxtMa_mau.Dv_ListDetail = Nothing
        Me.TxtMa_mau.Dv_Master = Nothing
        Me.TxtMa_mau.FilterClient = ""
        Me.TxtMa_mau.FilterSQL = ""
        Me.TxtMa_mau.Location = New System.Drawing.Point(125, 26)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_mau.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_mau.TabIndex = 1
        Me.TxtMa_mau.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.AutoSize = True
        Me.LabNgay_ban.Location = New System.Drawing.Point(3, 78)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(53, 13)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày bán"
        '
        'TxtNgay_ban
        '
        Me.TxtNgay_ban.Flags = 65536
        Me.TxtNgay_ban.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ban.IsAllowResize = False
        Me.TxtNgay_ban.isEmpty = True
        Me.TxtNgay_ban.Location = New System.Drawing.Point(124, 74)
        Me.TxtNgay_ban.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ban.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_ban.MaxLength = 10
        Me.TxtNgay_ban.Name = "TxtNgay_ban"
        Me.TxtNgay_ban.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_ban.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_ban.ShowDayBeforeMonth = False
        Me.TxtNgay_ban.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_ban.TabIndex = 3
        Me.TxtNgay_ban.Text = "07/09/2011"
        Me.TxtNgay_ban.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtGia_nt2
        '
        Me.TxtGia_nt2.AllowNegative = True
        Me.TxtGia_nt2.Flags = 7680
        Me.TxtGia_nt2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt2.InputMask = "### ### ### ### ###"
        Me.TxtGia_nt2.Location = New System.Drawing.Point(124, 97)
        Me.TxtGia_nt2.MaxWholeDigits = 14
        Me.TxtGia_nt2.Name = "TxtGia_nt2"
        Me.TxtGia_nt2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt2.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt2.TabIndex = 4
        Me.TxtGia_nt2.Text = "1"
        Me.TxtGia_nt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia_nt3
        '
        Me.TxtGia_nt3.AllowNegative = True
        Me.TxtGia_nt3.Flags = 7680
        Me.TxtGia_nt3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt3.InputMask = "### ### ### ### ###"
        Me.TxtGia_nt3.Location = New System.Drawing.Point(124, 120)
        Me.TxtGia_nt3.MaxWholeDigits = 14
        Me.TxtGia_nt3.Name = "TxtGia_nt3"
        Me.TxtGia_nt3.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt3.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt3.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt3.TabIndex = 5
        Me.TxtGia_nt3.Text = "1"
        Me.TxtGia_nt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia3
        '
        Me.TxtGia3.AllowNegative = True
        Me.TxtGia3.Flags = 7680
        Me.TxtGia3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia3.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia3.InputMask = "### ### ### ### ###"
        Me.TxtGia3.Location = New System.Drawing.Point(510, 120)
        Me.TxtGia3.MaxWholeDigits = 14
        Me.TxtGia3.Name = "TxtGia3"
        Me.TxtGia3.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia3.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia3.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia3.TabIndex = 7
        Me.TxtGia3.Text = "1"
        Me.TxtGia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia3.Visible = False
        '
        'Txtgia2
        '
        Me.Txtgia2.AllowNegative = True
        Me.Txtgia2.Flags = 7680
        Me.Txtgia2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtgia2.ForeColor = System.Drawing.Color.Navy
        Me.Txtgia2.InputMask = "### ### ### ### ###"
        Me.Txtgia2.Location = New System.Drawing.Point(510, 97)
        Me.Txtgia2.MaxWholeDigits = 14
        Me.Txtgia2.Name = "Txtgia2"
        Me.Txtgia2.RangeMax = 1.7976931348623157E+308R
        Me.Txtgia2.RangeMin = -1.7976931348623157E+308R
        Me.Txtgia2.Size = New System.Drawing.Size(149, 21)
        Me.Txtgia2.TabIndex = 5
        Me.Txtgia2.Text = "1"
        Me.Txtgia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtgia2.Visible = False
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.AutoSize = True
        Me.LabGia_nt2.Location = New System.Drawing.Point(2, 100)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 13)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Price before tax (Currency)"
        Me.LabGia_nt2.Text = "Giá bán trước thuế (NT)"
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.AutoSize = True
        Me.LabGia_nt3.Location = New System.Drawing.Point(3, 122)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(112, 13)
        Me.LabGia_nt3.TabIndex = 31
        Me.LabGia_nt3.Tag = "Price after tax (Currency)"
        Me.LabGia_nt3.Text = "Giá bán sau thuế (NT)"
        '
        'Labgia3
        '
        Me.Labgia3.AutoSize = True
        Me.Labgia3.Location = New System.Drawing.Point(380, 122)
        Me.Labgia3.Name = "Labgia3"
        Me.Labgia3.Size = New System.Drawing.Size(98, 13)
        Me.Labgia3.TabIndex = 413
        Me.Labgia3.Tag = "Price after tax (VND)"
        Me.Labgia3.Text = "Giá sau thuế (VND)"
        Me.Labgia3.Visible = False
        '
        'Labgia2
        '
        Me.Labgia2.AutoSize = True
        Me.Labgia2.Location = New System.Drawing.Point(378, 100)
        Me.Labgia2.Name = "Labgia2"
        Me.Labgia2.Size = New System.Drawing.Size(107, 13)
        Me.Labgia2.TabIndex = 412
        Me.Labgia2.Tag = "Price before tax (VND)"
        Me.Labgia2.Text = "Giá trước thuế (VND)"
        Me.Labgia2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(380, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 417
        Me.Label5.Tag = "Purchase price"
        Me.Label5.Text = "Giá mua (VNĐ)"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(4, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 416
        Me.Label6.Tag = "Import prices"
        Me.Label6.Text = "Giá nhập"
        '
        'TxtGia
        '
        Me.TxtGia.AllowNegative = True
        Me.TxtGia.Flags = 7680
        Me.TxtGia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia.ForeColor = System.Drawing.Color.Red
        Me.TxtGia.InputMask = "### ### ### ### ###"
        Me.TxtGia.Location = New System.Drawing.Point(510, 143)
        Me.TxtGia.MaxWholeDigits = 14
        Me.TxtGia.Name = "TxtGia"
        Me.TxtGia.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia.TabIndex = 9
        Me.TxtGia.Text = "1"
        Me.TxtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia.Visible = False
        '
        'TxtGia_NT
        '
        Me.TxtGia_NT.AllowNegative = True
        Me.TxtGia_NT.Flags = 7680
        Me.TxtGia_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_NT.ForeColor = System.Drawing.Color.Red
        Me.TxtGia_NT.InputMask = "### ### ### ### ###"
        Me.TxtGia_NT.Location = New System.Drawing.Point(125, 169)
        Me.TxtGia_NT.MaxWholeDigits = 14
        Me.TxtGia_NT.Name = "TxtGia_NT"
        Me.TxtGia_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_NT.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_NT.TabIndex = 7
        Me.TxtGia_NT.Text = "1"
        Me.TxtGia_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDat_Coc
        '
        Me.TxtDat_Coc.AllowNegative = True
        Me.TxtDat_Coc.Flags = 7680
        Me.TxtDat_Coc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDat_Coc.ForeColor = System.Drawing.Color.Navy
        Me.TxtDat_Coc.InputMask = "### ### ### ### ###"
        Me.TxtDat_Coc.Location = New System.Drawing.Point(124, 145)
        Me.TxtDat_Coc.MaxWholeDigits = 14
        Me.TxtDat_Coc.Name = "TxtDat_Coc"
        Me.TxtDat_Coc.RangeMax = 1.7976931348623157E+308R
        Me.TxtDat_Coc.RangeMin = -1.7976931348623157E+308R
        Me.TxtDat_Coc.Size = New System.Drawing.Size(149, 21)
        Me.TxtDat_Coc.TabIndex = 6
        Me.TxtDat_Coc.Text = "1"
        Me.TxtDat_Coc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 419
        Me.Label1.Tag = "Deposit value"
        Me.Label1.Text = "Gía trị đặt cọc"
        '
        'TxtNam_SX
        '
        Me.TxtNam_SX.AllowNegative = True
        Me.TxtNam_SX.Flags = 7680
        Me.TxtNam_SX.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam_SX.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam_SX.InputMask = "### ####"
        Me.TxtNam_SX.Location = New System.Drawing.Point(124, 49)
        Me.TxtNam_SX.MaxWholeDigits = 6
        Me.TxtNam_SX.Name = "TxtNam_SX"
        Me.TxtNam_SX.RangeMax = 1.7976931348623157E+308R
        Me.TxtNam_SX.RangeMin = -1.7976931348623157E+308R
        Me.TxtNam_SX.Size = New System.Drawing.Size(65, 21)
        Me.TxtNam_SX.TabIndex = 2
        Me.TxtNam_SX.Text = "1"
        Me.TxtNam_SX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(3, 49)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(73, 13)
        Me.Label41.TabIndex = 515
        Me.Label41.Tag = "Item code"
        Me.Label41.Text = "Năm sản xuất"
        '
        'TxtHoldBack
        '
        Me.TxtHoldBack.AllowNegative = True
        Me.TxtHoldBack.Flags = 7680
        Me.TxtHoldBack.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtHoldBack.ForeColor = System.Drawing.Color.Red
        Me.TxtHoldBack.InputMask = "### ### ### ### ###"
        Me.TxtHoldBack.Location = New System.Drawing.Point(124, 193)
        Me.TxtHoldBack.MaxWholeDigits = 14
        Me.TxtHoldBack.Name = "TxtHoldBack"
        Me.TxtHoldBack.RangeMax = 1.7976931348623157E+308R
        Me.TxtHoldBack.RangeMin = -1.7976931348623157E+308R
        Me.TxtHoldBack.Size = New System.Drawing.Size(149, 21)
        Me.TxtHoldBack.TabIndex = 8
        Me.TxtHoldBack.Text = "1"
        Me.TxtHoldBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 416
        Me.Label2.Tag = "Import prices"
        Me.Label2.Text = "Hold Back"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(2, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 517
        Me.Label3.Tag = "Purchase price"
        Me.Label3.Text = "Giá mua cả VAT"
        Me.Label3.Visible = False
        '
        'TxtGia_NT_VAT
        '
        Me.TxtGia_NT_VAT.AllowNegative = True
        Me.TxtGia_NT_VAT.Flags = 7680
        Me.TxtGia_NT_VAT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_NT_VAT.ForeColor = System.Drawing.Color.Red
        Me.TxtGia_NT_VAT.InputMask = "### ### ### ### ###"
        Me.TxtGia_NT_VAT.Location = New System.Drawing.Point(124, 217)
        Me.TxtGia_NT_VAT.MaxWholeDigits = 14
        Me.TxtGia_NT_VAT.Name = "TxtGia_NT_VAT"
        Me.TxtGia_NT_VAT.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_NT_VAT.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_NT_VAT.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_NT_VAT.TabIndex = 516
        Me.TxtGia_NT_VAT.Text = "1"
        Me.TxtGia_NT_VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia_NT_VAT.Visible = False
        '
        'DMGIAXE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(668, 286)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtGia_NT_VAT)
        Me.Controls.Add(Me.TxtNam_SX)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.TxtDat_Coc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtGia)
        Me.Controls.Add(Me.TxtHoldBack)
        Me.Controls.Add(Me.TxtGia_NT)
        Me.Controls.Add(Me.Labgia3)
        Me.Controls.Add(Me.Labgia2)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.TxtGia3)
        Me.Controls.Add(Me.Txtgia2)
        Me.Controls.Add(Me.TxtGia_nt3)
        Me.Controls.Add(Me.TxtGia_nt2)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_ban)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_mau)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.TxtTen_KX)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(488, 179)
        Me.Name = "DMGIAXE"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_mau, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.Txtgia2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia3, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.Labgia2, 0)
        Me.Controls.SetChildIndex(Me.Labgia3, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtHoldBack, 0)
        Me.Controls.SetChildIndex(Me.TxtGia, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDat_Coc, 0)
        Me.Controls.SetChildIndex(Me.Label41, 0)
        Me.Controls.SetChildIndex(Me.TxtNam_SX, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_NT_VAT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KX As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_ban As ClsTextBox.txtDate1
    Friend WithEvents TxtGia_nt2 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia_nt3 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia3 As ClsTextBox.txtTy_Gia
    Friend WithEvents Txtgia2 As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents Labgia3 As System.Windows.Forms.Label
    Friend WithEvents Labgia2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia_NT As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtDat_Coc As ClsTextBox.txtTy_Gia
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNam_SX As ClsTextBox.txtTy_Gia
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TxtHoldBack As ClsTextBox.txtTy_Gia
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_NT_VAT As ClsTextBox.txtTy_Gia

End Class
