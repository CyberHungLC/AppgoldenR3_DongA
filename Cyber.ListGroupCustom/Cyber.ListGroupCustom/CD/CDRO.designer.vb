<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDRO
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_TT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Ma_TT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDu_Co_Nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_Nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No1 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDu_Co_Nt00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_Nt00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No00 = New ClsTextBox.txtTien_NT()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtMa_NT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSo_HD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSo_seri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNgay_HD = New ClsTextBox.txtDate()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(637, 282)
        Me.ButtExit.TabIndex = 21
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(535, 282)
        Me.ButtOK.TabIndex = 20
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(119, 31)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 292)
        Me.ChkActi.TabIndex = 19
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 272)
        Me.GroupBoxLine.Size = New System.Drawing.Size(735, 9)
        Me.GroupBoxLine.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(5, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(469, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Currency"
        Me.Label8.Text = "Tài khoản"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(5, 35)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(102, 13)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Producing process"
        Me.LabMa_CD.Text = "Đơn vị hạch toán"
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(119, 53)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(135, 20)
        Me.TxtTk.TabIndex = 2
        Me.TxtTk.Table_Name = ""
        '
        'TxtTen_Tk
        '
        Me.TxtTen_Tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk.Location = New System.Drawing.Point(262, 56)
        Me.TxtTen_Tk.Name = "TxtTen_Tk"
        Me.TxtTen_Tk.ReadOnly = True
        Me.TxtTen_Tk.Size = New System.Drawing.Size(470, 14)
        Me.TxtTen_Tk.TabIndex = 297
        Me.TxtTen_Tk.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(5, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 17)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(119, 7)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(256, 34)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(476, 14)
        Me.TxtTen_Dvcs.TabIndex = 301
        Me.TxtTen_Dvcs.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 318
        Me.Label1.Tag = "Account"
        Me.Label1.Text = "Số lệnh"
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.Location = New System.Drawing.Point(119, 75)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_RO.TabIndex = 3
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(119, 119)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_Kh.TabIndex = 7
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(262, 122)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(470, 14)
        Me.TxtTen_Kh.TabIndex = 325
        Me.TxtTen_Kh.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(5, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 324
        Me.Label5.Tag = "Currency"
        Me.Label5.Text = "Khách hàng"
        '
        'TxtMa_TT
        '
        Me.TxtMa_TT._ActilookupPopup = False
        Me.TxtMa_TT.CyberActilookupPopup = True
        Me.TxtMa_TT.Dv_ListDetail = Nothing
        Me.TxtMa_TT.Dv_Master = Nothing
        Me.TxtMa_TT.FilterClient = ""
        Me.TxtMa_TT.FilterSQL = ""
        Me.TxtMa_TT.Location = New System.Drawing.Point(119, 141)
        Me.TxtMa_TT.Name = "TxtMa_TT"
        Me.TxtMa_TT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TT.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_TT.TabIndex = 8
        Me.TxtMa_TT.Table_Name = ""
        '
        'TxtTen_Ma_TT
        '
        Me.TxtTen_Ma_TT.BackColor = System.Drawing.Color.White
        Me.TxtTen_Ma_TT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Ma_TT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Ma_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ma_TT.Location = New System.Drawing.Point(262, 144)
        Me.TxtTen_Ma_TT.Name = "TxtTen_Ma_TT"
        Me.TxtTen_Ma_TT.ReadOnly = True
        Me.TxtTen_Ma_TT.Size = New System.Drawing.Size(470, 14)
        Me.TxtTen_Ma_TT.TabIndex = 328
        Me.TxtTen_Ma_TT.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(5, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 327
        Me.Label7.Tag = "Currency"
        Me.Label7.Text = "Mã TT"
        '
        'TxtDu_Co_Nt1
        '
        Me.TxtDu_Co_Nt1.AllowNegative = True
        Me.TxtDu_Co_Nt1.Flags = 7680
        Me.TxtDu_Co_Nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_Nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co_Nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_Nt1.Location = New System.Drawing.Point(586, 250)
        Me.TxtDu_Co_Nt1.MaxWholeDigits = 17
        Me.TxtDu_Co_Nt1.Name = "TxtDu_Co_Nt1"
        Me.TxtDu_Co_Nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_Nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_Nt1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_Co_Nt1.TabIndex = 16
        Me.TxtDu_Co_Nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_Nt1.Text = "0.00"
        Me.TxtDu_Co_Nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No_Nt1
        '
        Me.TxtDu_No_Nt1.AllowNegative = True
        Me.TxtDu_No_Nt1.Flags = 7680
        Me.TxtDu_No_Nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_Nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No_Nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_Nt1.Location = New System.Drawing.Point(586, 226)
        Me.TxtDu_No_Nt1.MaxWholeDigits = 17
        Me.TxtDu_No_Nt1.Name = "TxtDu_No_Nt1"
        Me.TxtDu_No_Nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_Nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_Nt1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_No_Nt1.TabIndex = 15
        Me.TxtDu_No_Nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_Nt1.Text = "0.00"
        Me.TxtDu_No_Nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_Co1
        '
        Me.TxtDu_Co1.AllowNegative = True
        Me.TxtDu_Co1.Flags = 7680
        Me.TxtDu_Co1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co1.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co1.Location = New System.Drawing.Point(586, 203)
        Me.TxtDu_Co1.MaxWholeDigits = 14
        Me.TxtDu_Co1.Name = "TxtDu_Co1"
        Me.TxtDu_Co1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_Co1.TabIndex = 14
        Me.TxtDu_Co1.Text = "0"
        Me.TxtDu_Co1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No1
        '
        Me.TxtDu_No1.AllowNegative = True
        Me.TxtDu_No1.Flags = 7680
        Me.TxtDu_No1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No1.InputMask = "### ### ### ### ###"
        Me.TxtDu_No1.Location = New System.Drawing.Point(586, 180)
        Me.TxtDu_No1.MaxWholeDigits = 14
        Me.TxtDu_No1.Name = "TxtDu_No1"
        Me.TxtDu_No1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_No1.TabIndex = 13
        Me.TxtDu_No1.Text = "0"
        Me.TxtDu_No1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(429, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 360
        Me.Label2.Tag = "Y.starts credit balance(FC)"
        Me.Label2.Text = "Dư có đầu năm (NT)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(429, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 359
        Me.Label3.Tag = "Y.starts credit balance(VND)"
        Me.Label3.Text = "Dư có đầu năm  (VNĐ)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(429, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 17)
        Me.Label6.TabIndex = 358
        Me.Label6.Tag = "Y.starts debt balance(FC)"
        Me.Label6.Text = "Dư nợ đầu năm (NT)"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(429, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 17)
        Me.Label11.TabIndex = 357
        Me.Label11.Tag = "Y.starts debt balance(VND)"
        Me.Label11.Text = "Dư nợ đầu năm (VNĐ)"
        '
        'TxtDu_Co_Nt00
        '
        Me.TxtDu_Co_Nt00.AllowNegative = True
        Me.TxtDu_Co_Nt00.Flags = 7680
        Me.TxtDu_Co_Nt00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_Nt00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co_Nt00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_Nt00.Location = New System.Drawing.Point(119, 250)
        Me.TxtDu_Co_Nt00.MaxWholeDigits = 17
        Me.TxtDu_Co_Nt00.Name = "TxtDu_Co_Nt00"
        Me.TxtDu_Co_Nt00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_Nt00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_Nt00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co_Nt00.TabIndex = 12
        Me.TxtDu_Co_Nt00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_Nt00.Text = "0.00"
        Me.TxtDu_Co_Nt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No_Nt00
        '
        Me.TxtDu_No_Nt00.AllowNegative = True
        Me.TxtDu_No_Nt00.Flags = 7680
        Me.TxtDu_No_Nt00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_Nt00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No_Nt00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_Nt00.Location = New System.Drawing.Point(119, 226)
        Me.TxtDu_No_Nt00.MaxWholeDigits = 17
        Me.TxtDu_No_Nt00.Name = "TxtDu_No_Nt00"
        Me.TxtDu_No_Nt00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_Nt00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_Nt00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_No_Nt00.TabIndex = 11
        Me.TxtDu_No_Nt00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_Nt00.Text = "0.00"
        Me.TxtDu_No_Nt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_Co00
        '
        Me.TxtDu_Co00.AllowNegative = True
        Me.TxtDu_Co00.Flags = 7680
        Me.TxtDu_Co00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co00.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co00.Location = New System.Drawing.Point(119, 203)
        Me.TxtDu_Co00.MaxWholeDigits = 14
        Me.TxtDu_Co00.Name = "TxtDu_Co00"
        Me.TxtDu_Co00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co00.TabIndex = 10
        Me.TxtDu_Co00.Text = "0"
        Me.TxtDu_Co00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No00
        '
        Me.TxtDu_No00.AllowNegative = True
        Me.TxtDu_No00.Flags = 7680
        Me.TxtDu_No00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No00.InputMask = "### ### ### ### ###"
        Me.TxtDu_No00.Location = New System.Drawing.Point(119, 180)
        Me.TxtDu_No00.MaxWholeDigits = 14
        Me.TxtDu_No00.Name = "TxtDu_No00"
        Me.TxtDu_No00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_No00.TabIndex = 9
        Me.TxtDu_No00.Text = "0"
        Me.TxtDu_No00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(5, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 21)
        Me.Label13.TabIndex = 356
        Me.Label13.Tag = "Open credit balance(FC)"
        Me.Label13.Text = "Dư có đầu kỳ (NT)"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(5, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 17)
        Me.Label14.TabIndex = 355
        Me.Label14.Tag = "Open credit balance(VND)"
        Me.Label14.Text = "Dư có đầu kỳ (VNĐ)"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(5, 228)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 17)
        Me.Label15.TabIndex = 354
        Me.Label15.Tag = "Open debt balance(FC)"
        Me.Label15.Text = "Dư nợ đầu kỳ (NT)"
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbTen_phi2.ForeColor = System.Drawing.Color.Navy
        Me.lbTen_phi2.Location = New System.Drawing.Point(5, 182)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(132, 17)
        Me.lbTen_phi2.TabIndex = 353
        Me.lbTen_phi2.Tag = "Open debt balance(VND)"
        Me.lbTen_phi2.Text = "Dư nợ đầu kỳ (VNĐ)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 10)
        Me.GroupBox1.TabIndex = 361
        Me.GroupBox1.TabStop = False
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT._ActilookupPopup = False
        Me.TxtMa_NT.CyberActilookupPopup = True
        Me.TxtMa_NT.Dv_ListDetail = Nothing
        Me.TxtMa_NT.Dv_Master = Nothing
        Me.TxtMa_NT.FilterClient = ""
        Me.TxtMa_NT.FilterSQL = ""
        Me.TxtMa_NT.Location = New System.Drawing.Point(119, 337)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_NT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NT.Properties.ReadOnly = True
        Me.TxtMa_NT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NT.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_NT.TabIndex = 362
        Me.TxtMa_NT.Table_Name = ""
        Me.TxtMa_NT.Visible = False
        '
        'TxtTen_NT
        '
        Me.TxtTen_NT.BackColor = System.Drawing.Color.White
        Me.TxtTen_NT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NT.Location = New System.Drawing.Point(262, 340)
        Me.TxtTen_NT.Name = "TxtTen_NT"
        Me.TxtTen_NT.ReadOnly = True
        Me.TxtTen_NT.Size = New System.Drawing.Size(233, 14)
        Me.TxtTen_NT.TabIndex = 363
        Me.TxtTen_NT.TabStop = False
        Me.TxtTen_NT.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(5, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 17)
        Me.Label16.TabIndex = 364
        Me.Label16.Tag = "Currency"
        Me.Label16.Text = "Mã ngoại tệ"
        Me.Label16.Visible = False
        '
        'TxtSo_HD
        '
        Me.TxtSo_HD.Location = New System.Drawing.Point(119, 97)
        Me.TxtSo_HD.Name = "TxtSo_HD"
        Me.TxtSo_HD.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_HD.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(5, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 366
        Me.Label9.Tag = "Account"
        Me.Label9.Text = "Số hóa đơn"
        '
        'TxtSo_seri
        '
        Me.TxtSo_seri.Location = New System.Drawing.Point(361, 95)
        Me.TxtSo_seri.Name = "TxtSo_seri"
        Me.TxtSo_seri.Size = New System.Drawing.Size(113, 21)
        Me.TxtSo_seri.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(304, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 368
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Số seri"
        '
        'txtNgay_HD
        '
        Me.txtNgay_HD.Flags = 65536
        Me.txtNgay_HD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_HD.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_HD.isEmpty = True
        Me.txtNgay_HD.Location = New System.Drawing.Point(614, 93)
        Me.txtNgay_HD.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_HD.MaxLength = 10
        Me.txtNgay_HD.Name = "txtNgay_HD"
        Me.txtNgay_HD.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HD.ShowDayBeforeMonth = False
        Me.txtNgay_HD.Size = New System.Drawing.Size(113, 21)
        Me.txtNgay_HD.TabIndex = 6
        Me.txtNgay_HD.Text = "__/__/____"
        Me.txtNgay_HD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(526, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 15)
        Me.Label17.TabIndex = 370
        Me.Label17.Tag = "Date"
        Me.Label17.Text = "Ngày hóa đơn"
        '
        'CDRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 315)
        Me.Controls.Add(Me.txtNgay_HD)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtSo_seri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSo_HD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTen_NT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtDu_Co_Nt1)
        Me.Controls.Add(Me.TxtDu_No_Nt1)
        Me.Controls.Add(Me.TxtDu_Co1)
        Me.Controls.Add(Me.TxtDu_No1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDu_Co_Nt00)
        Me.Controls.Add(Me.TxtDu_No_Nt00)
        Me.Controls.Add(Me.TxtDu_Co00)
        Me.Controls.Add(Me.TxtDu_No00)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.Controls.Add(Me.TxtMa_TT)
        Me.Controls.Add(Me.TxtTen_Ma_TT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.TxtTen_Tk)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.KeyPreview = True
        Me.Name = "CDRO"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ma_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TT, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_Nt00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_Nt00, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_Nt1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_Nt1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HD, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_seri, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_HD, 0)
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_TT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Ma_TT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDu_Co_Nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_Nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtDu_Co_Nt00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_Nt00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_NT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NT As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_seri As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNgay_HD As ClsTextBox.txtDate
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
