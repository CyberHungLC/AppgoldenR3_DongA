<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMChiaHHBH
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
        Me.TxtTen_LHBH = New System.Windows.Forms.TextBox()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_hl = New ClsTextBox.txtDate1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_HT = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.Txtpt_hh_tv = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_CTY = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_Phucloi5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPt_hh_tp5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_GDKD5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_HT5 = New ClsTextBox.txtTy_Gia()
        Me.Txtpt_hh_tv5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_CTY5 = New ClsTextBox.txtTy_Gia()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPt_hh_NganHang = New ClsTextBox.txtTy_Gia()
        Me.TxtMa_TTHD = New Cyber.SmLists.TxtLookup()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTen_TTHD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPT_hh_Khac = New ClsTextBox.txtTy_Gia()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_PPK = New ClsTextBox.txtTy_Gia()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPt_HH_PKT = New ClsTextBox.txtTy_Gia()
        Me.TxtMa_TT = New Cyber.SmLists.TxtLookup()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkXe_taitung = New System.Windows.Forms.CheckBox()
        Me.ChkXe_moi = New System.Windows.Forms.CheckBox()
        Me.txtTen_TT = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_TTHD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(618, 303)
        Me.ButtExit.TabIndex = 11
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(516, 303)
        Me.ButtOK.TabIndex = 10
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(366, 322)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 19
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 312)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 293)
        Me.GroupBoxLine.Size = New System.Drawing.Size(716, 9)
        Me.GroupBoxLine.TabIndex = 8
        '
        'TxtTen_LHBH
        '
        Me.TxtTen_LHBH.BackColor = System.Drawing.Color.White
        Me.TxtTen_LHBH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_LHBH.Enabled = False
        Me.TxtTen_LHBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LHBH.Location = New System.Drawing.Point(278, 36)
        Me.TxtTen_LHBH.Name = "TxtTen_LHBH"
        Me.TxtTen_LHBH.ReadOnly = True
        Me.TxtTen_LHBH.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_LHBH.TabIndex = 384
        Me.TxtTen_LHBH.TabStop = False
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(4, 20)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 14)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_hl
        '
        Me.TxtNgay_hl.Flags = 65536
        Me.TxtNgay_hl.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_hl.IsAllowResize = False
        Me.TxtNgay_hl.isEmpty = True
        Me.TxtNgay_hl.Location = New System.Drawing.Point(125, 16)
        Me.TxtNgay_hl.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_hl.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_hl.MaxLength = 10
        Me.TxtNgay_hl.Name = "TxtNgay_hl"
        Me.TxtNgay_hl.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_hl.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_hl.ShowDayBeforeMonth = False
        Me.TxtNgay_hl.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_hl.TabIndex = 3
        Me.TxtNgay_hl.Text = "07/09/2011"
        Me.TxtNgay_hl.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 14)
        Me.Label1.TabIndex = 406
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "% HH NV Chuyên trách"
        '
        'TxtPT_HH_HT
        '
        Me.TxtPT_HH_HT.AllowNegative = True
        Me.TxtPT_HH_HT.Flags = 7680
        Me.TxtPT_HH_HT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_HT.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_HT.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_HT.Location = New System.Drawing.Point(125, 139)
        Me.TxtPT_HH_HT.MaxWholeDigits = 19
        Me.TxtPT_HH_HT.Name = "TxtPT_HH_HT"
        Me.TxtPT_HH_HT.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_HT.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_HT.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_HT.TabIndex = 5
        Me.TxtPT_HH_HT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.Location = New System.Drawing.Point(3, 118)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(121, 14)
        Me.LabGia_nt3.TabIndex = 405
        Me.LabGia_nt3.Tag = "Date"
        Me.LabGia_nt3.Text = "% HH Tư vấn"
        '
        'Txtpt_hh_tv
        '
        Me.Txtpt_hh_tv.AllowNegative = True
        Me.Txtpt_hh_tv.Flags = 7680
        Me.Txtpt_hh_tv.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtpt_hh_tv.ForeColor = System.Drawing.Color.Navy
        Me.Txtpt_hh_tv.InputMask = "### ### ### ### ##0.###0"
        Me.Txtpt_hh_tv.Location = New System.Drawing.Point(125, 116)
        Me.Txtpt_hh_tv.MaxWholeDigits = 19
        Me.Txtpt_hh_tv.Name = "Txtpt_hh_tv"
        Me.Txtpt_hh_tv.RangeMax = 1.7976931348623157E+308R
        Me.Txtpt_hh_tv.RangeMin = -1.7976931348623157E+308R
        Me.Txtpt_hh_tv.Size = New System.Drawing.Size(149, 21)
        Me.Txtpt_hh_tv.TabIndex = 4
        Me.Txtpt_hh_tv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_HH_CTY
        '
        Me.TxtPT_HH_CTY.AllowNegative = True
        Me.TxtPT_HH_CTY.Flags = 7680
        Me.TxtPT_HH_CTY.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_CTY.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_CTY.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_CTY.Location = New System.Drawing.Point(125, 92)
        Me.TxtPT_HH_CTY.MaxWholeDigits = 19
        Me.TxtPT_HH_CTY.Name = "TxtPT_HH_CTY"
        Me.TxtPT_HH_CTY.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_CTY.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_CTY.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_CTY.TabIndex = 3
        Me.TxtPT_HH_CTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(3, 95)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 14)
        Me.LabGia_nt2.TabIndex = 404
        Me.LabGia_nt2.Tag = "Date"
        Me.LabGia_nt2.Text = "% HH công ty"
        '
        'TxtPT_HH_Phucloi5
        '
        Me.TxtPT_HH_Phucloi5.AllowNegative = True
        Me.TxtPT_HH_Phucloi5.Flags = 7680
        Me.TxtPT_HH_Phucloi5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_Phucloi5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_Phucloi5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_Phucloi5.Location = New System.Drawing.Point(485, 304)
        Me.TxtPT_HH_Phucloi5.MaxWholeDigits = 19
        Me.TxtPT_HH_Phucloi5.Name = "TxtPT_HH_Phucloi5"
        Me.TxtPT_HH_Phucloi5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_Phucloi5.TabIndex = 16
        Me.TxtPT_HH_Phucloi5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPT_HH_Phucloi5.Visible = False
        '
        'TxtPt_hh_tp5
        '
        Me.TxtPt_hh_tp5.AllowNegative = True
        Me.TxtPt_hh_tp5.Flags = 7680
        Me.TxtPt_hh_tp5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPt_hh_tp5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPt_hh_tp5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPt_hh_tp5.Location = New System.Drawing.Point(485, 304)
        Me.TxtPt_hh_tp5.MaxWholeDigits = 19
        Me.TxtPt_hh_tp5.Name = "TxtPt_hh_tp5"
        Me.TxtPt_hh_tp5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPt_hh_tp5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPt_hh_tp5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPt_hh_tp5.TabIndex = 15
        Me.TxtPt_hh_tp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPt_hh_tp5.Visible = False
        '
        'TxtPT_HH_GDKD5
        '
        Me.TxtPT_HH_GDKD5.AllowNegative = True
        Me.TxtPT_HH_GDKD5.Flags = 7680
        Me.TxtPT_HH_GDKD5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_GDKD5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_GDKD5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_GDKD5.Location = New System.Drawing.Point(485, 304)
        Me.TxtPT_HH_GDKD5.MaxWholeDigits = 19
        Me.TxtPT_HH_GDKD5.Name = "TxtPT_HH_GDKD5"
        Me.TxtPT_HH_GDKD5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_GDKD5.TabIndex = 16
        Me.TxtPT_HH_GDKD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPT_HH_GDKD5.Visible = False
        '
        'TxtPT_HH_HT5
        '
        Me.TxtPT_HH_HT5.AllowNegative = True
        Me.TxtPT_HH_HT5.Flags = 7680
        Me.TxtPT_HH_HT5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_HT5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_HT5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_HT5.Location = New System.Drawing.Point(485, 304)
        Me.TxtPT_HH_HT5.MaxWholeDigits = 19
        Me.TxtPT_HH_HT5.Name = "TxtPT_HH_HT5"
        Me.TxtPT_HH_HT5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_HT5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_HT5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_HT5.TabIndex = 14
        Me.TxtPT_HH_HT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPT_HH_HT5.Visible = False
        '
        'Txtpt_hh_tv5
        '
        Me.Txtpt_hh_tv5.AllowNegative = True
        Me.Txtpt_hh_tv5.Flags = 7680
        Me.Txtpt_hh_tv5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtpt_hh_tv5.ForeColor = System.Drawing.Color.Navy
        Me.Txtpt_hh_tv5.InputMask = "### ### ### ### ##0.###0"
        Me.Txtpt_hh_tv5.Location = New System.Drawing.Point(485, 304)
        Me.Txtpt_hh_tv5.MaxWholeDigits = 19
        Me.Txtpt_hh_tv5.Name = "Txtpt_hh_tv5"
        Me.Txtpt_hh_tv5.RangeMax = 1.7976931348623157E+308R
        Me.Txtpt_hh_tv5.RangeMin = -1.7976931348623157E+308R
        Me.Txtpt_hh_tv5.Size = New System.Drawing.Size(149, 21)
        Me.Txtpt_hh_tv5.TabIndex = 13
        Me.Txtpt_hh_tv5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtpt_hh_tv5.Visible = False
        '
        'TxtPT_HH_CTY5
        '
        Me.TxtPT_HH_CTY5.AllowNegative = True
        Me.TxtPT_HH_CTY5.Flags = 7680
        Me.TxtPT_HH_CTY5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_CTY5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_CTY5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_CTY5.Location = New System.Drawing.Point(485, 304)
        Me.TxtPT_HH_CTY5.MaxWholeDigits = 19
        Me.TxtPT_HH_CTY5.Name = "TxtPT_HH_CTY5"
        Me.TxtPT_HH_CTY5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_CTY5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_CTY5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_CTY5.TabIndex = 12
        Me.TxtPT_HH_CTY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPT_HH_CTY5.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(3, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 14)
        Me.Label14.TabIndex = 434
        Me.Label14.Tag = "Date"
        Me.Label14.Text = "% HH ngân hàng"
        '
        'TxtPt_hh_NganHang
        '
        Me.TxtPt_hh_NganHang.AllowNegative = True
        Me.TxtPt_hh_NganHang.Flags = 7680
        Me.TxtPt_hh_NganHang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPt_hh_NganHang.ForeColor = System.Drawing.Color.Navy
        Me.TxtPt_hh_NganHang.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPt_hh_NganHang.Location = New System.Drawing.Point(125, 163)
        Me.TxtPt_hh_NganHang.MaxWholeDigits = 19
        Me.TxtPt_hh_NganHang.Name = "TxtPt_hh_NganHang"
        Me.TxtPt_hh_NganHang.RangeMax = 1.7976931348623157E+308R
        Me.TxtPt_hh_NganHang.RangeMin = -1.7976931348623157E+308R
        Me.TxtPt_hh_NganHang.Size = New System.Drawing.Size(149, 21)
        Me.TxtPt_hh_NganHang.TabIndex = 6
        Me.TxtPt_hh_NganHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_TTHD
        '
        Me.TxtMa_TTHD._ActilookupPopup = False
        Me.TxtMa_TTHD.CyberActilookupPopup = True
        Me.TxtMa_TTHD.Dv_ListDetail = Nothing
        Me.TxtMa_TTHD.Dv_Master = Nothing
        Me.TxtMa_TTHD.FilterClient = ""
        Me.TxtMa_TTHD.FilterSQL = ""
        Me.TxtMa_TTHD.Location = New System.Drawing.Point(125, 42)
        Me.TxtMa_TTHD.Name = "TxtMa_TTHD"
        Me.TxtMa_TTHD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTHD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTHD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTHD.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_TTHD.TabIndex = 2
        Me.TxtMa_TTHD.Table_Name = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(3, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 436
        Me.Label15.Tag = "Stock code"
        Me.Label15.Text = "Hình thức hợp đồng"
        '
        'txtTen_TTHD
        '
        Me.txtTen_TTHD.BackColor = System.Drawing.Color.White
        Me.txtTen_TTHD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_TTHD.Enabled = False
        Me.txtTen_TTHD.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_TTHD.Location = New System.Drawing.Point(278, 45)
        Me.txtTen_TTHD.Name = "txtTen_TTHD"
        Me.txtTen_TTHD.ReadOnly = True
        Me.txtTen_TTHD.Size = New System.Drawing.Size(382, 14)
        Me.txtTen_TTHD.TabIndex = 437
        Me.txtTen_TTHD.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 14)
        Me.Label2.TabIndex = 439
        Me.Label2.Tag = "Date"
        Me.Label2.Text = "% HH khác"
        '
        'TxtPT_hh_Khac
        '
        Me.TxtPT_hh_Khac.AllowNegative = True
        Me.TxtPT_hh_Khac.Flags = 7680
        Me.TxtPT_hh_Khac.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_hh_Khac.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_hh_Khac.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_hh_Khac.Location = New System.Drawing.Point(125, 237)
        Me.TxtPT_hh_Khac.MaxWholeDigits = 19
        Me.TxtPT_hh_Khac.Name = "TxtPT_hh_Khac"
        Me.TxtPT_hh_Khac.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_hh_Khac.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_hh_Khac.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_hh_Khac.TabIndex = 7
        Me.TxtPT_hh_Khac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 14)
        Me.Label3.TabIndex = 441
        Me.Label3.Tag = "Date"
        Me.Label3.Text = "% HH nhân phòng DV"
        '
        'TxtPT_HH_PPK
        '
        Me.TxtPT_HH_PPK.AllowNegative = True
        Me.TxtPT_HH_PPK.Flags = 7680
        Me.TxtPT_HH_PPK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_PPK.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_PPK.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_PPK.Location = New System.Drawing.Point(125, 186)
        Me.TxtPT_HH_PPK.MaxWholeDigits = 19
        Me.TxtPT_HH_PPK.Name = "TxtPT_HH_PPK"
        Me.TxtPT_HH_PPK.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_PPK.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_PPK.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_PPK.TabIndex = 440
        Me.TxtPT_HH_PPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 14)
        Me.Label4.TabIndex = 443
        Me.Label4.Tag = "Date"
        Me.Label4.Text = "% HH phòng KT"
        '
        'TxtPt_HH_PKT
        '
        Me.TxtPt_HH_PKT.AllowNegative = True
        Me.TxtPt_HH_PKT.Flags = 7680
        Me.TxtPt_HH_PKT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPt_HH_PKT.ForeColor = System.Drawing.Color.Navy
        Me.TxtPt_HH_PKT.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPt_HH_PKT.Location = New System.Drawing.Point(125, 211)
        Me.TxtPt_HH_PKT.MaxWholeDigits = 19
        Me.TxtPt_HH_PKT.Name = "TxtPt_HH_PKT"
        Me.TxtPt_HH_PKT.RangeMax = 1.7976931348623157E+308R
        Me.TxtPt_HH_PKT.RangeMin = -1.7976931348623157E+308R
        Me.TxtPt_HH_PKT.Size = New System.Drawing.Size(149, 21)
        Me.TxtPt_HH_PKT.TabIndex = 442
        Me.TxtPt_HH_PKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_TT
        '
        Me.TxtMa_TT._ActilookupPopup = False
        Me.TxtMa_TT.CyberActilookupPopup = True
        Me.TxtMa_TT.Dv_ListDetail = Nothing
        Me.TxtMa_TT.Dv_Master = Nothing
        Me.TxtMa_TT.FilterClient = ""
        Me.TxtMa_TT.FilterSQL = ""
        Me.TxtMa_TT.Location = New System.Drawing.Point(125, 66)
        Me.TxtMa_TT.Name = "TxtMa_TT"
        Me.TxtMa_TT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TT.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_TT.TabIndex = 444
        Me.TxtMa_TT.Table_Name = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(3, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 447
        Me.Label13.Tag = "Stock code"
        Me.Label13.Text = "Mã thanh toán"
        '
        'ChkXe_taitung
        '
        Me.ChkXe_taitung.AutoSize = True
        Me.ChkXe_taitung.Location = New System.Drawing.Point(462, 16)
        Me.ChkXe_taitung.Name = "ChkXe_taitung"
        Me.ChkXe_taitung.Size = New System.Drawing.Size(78, 17)
        Me.ChkXe_taitung.TabIndex = 446
        Me.ChkXe_taitung.Text = "Xe tái tụng"
        Me.ChkXe_taitung.UseVisualStyleBackColor = True
        '
        'ChkXe_moi
        '
        Me.ChkXe_moi.AutoSize = True
        Me.ChkXe_moi.Location = New System.Drawing.Point(368, 16)
        Me.ChkXe_moi.Name = "ChkXe_moi"
        Me.ChkXe_moi.Size = New System.Drawing.Size(57, 17)
        Me.ChkXe_moi.TabIndex = 445
        Me.ChkXe_moi.Text = "Xe mới"
        Me.ChkXe_moi.UseVisualStyleBackColor = True
        '
        'txtTen_TT
        '
        Me.txtTen_TT.BackColor = System.Drawing.Color.White
        Me.txtTen_TT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_TT.Enabled = False
        Me.txtTen_TT.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_TT.Location = New System.Drawing.Point(278, 72)
        Me.txtTen_TT.Name = "txtTen_TT"
        Me.txtTen_TT.ReadOnly = True
        Me.txtTen_TT.Size = New System.Drawing.Size(382, 14)
        Me.txtTen_TT.TabIndex = 448
        Me.txtTen_TT.TabStop = False
        '
        'DMChiaHHBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(720, 336)
        Me.Controls.Add(Me.txtTen_TT)
        Me.Controls.Add(Me.TxtMa_TT)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ChkXe_taitung)
        Me.Controls.Add(Me.ChkXe_moi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPt_HH_PKT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPT_HH_PPK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPT_hh_Khac)
        Me.Controls.Add(Me.txtTen_TTHD)
        Me.Controls.Add(Me.TxtMa_TTHD)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtPt_hh_NganHang)
        Me.Controls.Add(Me.TxtPT_HH_Phucloi5)
        Me.Controls.Add(Me.TxtPt_hh_tp5)
        Me.Controls.Add(Me.TxtPT_HH_GDKD5)
        Me.Controls.Add(Me.TxtPT_HH_HT5)
        Me.Controls.Add(Me.Txtpt_hh_tv5)
        Me.Controls.Add(Me.TxtPT_HH_CTY5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPT_HH_HT)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.Txtpt_hh_tv)
        Me.Controls.Add(Me.TxtPT_HH_CTY)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_hl)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_LHBH)
        Me.KeyPreview = True
        Me.Name = "DMChiaHHBH"
        Me.Controls.SetChildIndex(Me.TxtTen_LHBH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_hl, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_CTY, 0)
        Me.Controls.SetChildIndex(Me.Txtpt_hh_tv, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_HT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_CTY5, 0)
        Me.Controls.SetChildIndex(Me.Txtpt_hh_tv5, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_HT5, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_GDKD5, 0)
        Me.Controls.SetChildIndex(Me.TxtPt_hh_tp5, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_Phucloi5, 0)
        Me.Controls.SetChildIndex(Me.TxtPt_hh_NganHang, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTHD, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.txtTen_TTHD, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_hh_Khac, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_PPK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtPt_HH_PKT, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ChkXe_moi, 0)
        Me.Controls.SetChildIndex(Me.ChkXe_taitung, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TT, 0)
        Me.Controls.SetChildIndex(Me.txtTen_TT, 0)
        CType(Me.TxtMa_TTHD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_LHBH As System.Windows.Forms.TextBox
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_hl As ClsTextBox.txtDate1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_HT As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents Txtpt_hh_tv As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_CTY As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_Phucloi5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPt_hh_tp5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_GDKD5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_HT5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Txtpt_hh_tv5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_CTY5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtPt_hh_NganHang As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtMa_TTHD As Cyber.SmLists.TxtLookup
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTen_TTHD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_hh_Khac As ClsTextBox.txtTy_Gia
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_PPK As ClsTextBox.txtTy_Gia
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPt_HH_PKT As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtMa_TT As Cyber.SmLists.TxtLookup
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkXe_taitung As System.Windows.Forms.CheckBox
    Friend WithEvents ChkXe_moi As System.Windows.Forms.CheckBox
    Friend WithEvents txtTen_TT As System.Windows.Forms.TextBox

End Class
