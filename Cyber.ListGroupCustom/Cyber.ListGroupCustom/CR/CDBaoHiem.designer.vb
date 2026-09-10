<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDBaoHiem
    Inherits Cyber.From.FrmList

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
        Me.TxtNgay_KT = New ClsTextBox.txtDate()
        Me.TxtNgay_BD = New ClsTextBox.txtDate()
        Me.LabNgay_KT = New System.Windows.Forms.Label()
        Me.LabNgay_BD = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_LHBH = New System.Windows.Forms.TextBox()
        Me.TxtMa_LHBH = New Cyber.SmLists.TxtLookup()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.LabMa_xe = New System.Windows.Forms.Label()
        Me.Labso_khung = New System.Windows.Forms.Label()
        Me.LabelMa_Kx = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.labDien_thoai = New System.Windows.Forms.Label()
        Me.txtDia_chi = New System.Windows.Forms.TextBox()
        Me.LabDia_chi = New System.Windows.Forms.Label()
        Me.labGT_Xe = New System.Windows.Forms.Label()
        Me.TxtTien_NT = New ClsTextBox.txtTien_NT()
        Me.LabelTien_Nt = New System.Windows.Forms.Label()
        Me.TxtMa_Loai_CRM = New System.Windows.Forms.TextBox()
        Me.LabMa_Loai_CRM = New System.Windows.Forms.Label()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New System.Windows.Forms.TextBox()
        Me.TxtGT_Xe = New ClsTextBox.txtTien_NT()
        Me.TxtNam = New ClsTextBox.txtTien_NT()
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(568, 370)
        Me.ButtExit.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(466, 370)
        Me.ButtOK.TabIndex = 16
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(332, 378)
        Me.TxtMa_Dvcs.TabIndex = 15
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(9, 380)
        Me.ChkActi.TabIndex = 18
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 360)
        Me.GroupBoxLine.Size = New System.Drawing.Size(666, 9)
        Me.GroupBoxLine.TabIndex = 24
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.Flags = 65536
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.isEmpty = True
        Me.TxtNgay_KT.Location = New System.Drawing.Point(109, 28)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(135, 21)
        Me.TxtNgay_KT.TabIndex = 1
        Me.TxtNgay_KT.Text = "__/__/____"
        Me.TxtNgay_KT.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.Flags = 65536
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_BD.isEmpty = True
        Me.TxtNgay_BD.Location = New System.Drawing.Point(109, 4)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(135, 21)
        Me.TxtNgay_BD.TabIndex = 0
        Me.TxtNgay_BD.Text = "__/__/____"
        Me.TxtNgay_BD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabNgay_KT
        '
        Me.LabNgay_KT.AutoSize = True
        Me.LabNgay_KT.Location = New System.Drawing.Point(6, 33)
        Me.LabNgay_KT.Name = "LabNgay_KT"
        Me.LabNgay_KT.Size = New System.Drawing.Size(74, 13)
        Me.LabNgay_KT.TabIndex = 47
        Me.LabNgay_KT.Tag = "Group 5"
        Me.LabNgay_KT.Text = "Ngày kết thúc"
        '
        'LabNgay_BD
        '
        Me.LabNgay_BD.AutoSize = True
        Me.LabNgay_BD.Location = New System.Drawing.Point(6, 9)
        Me.LabNgay_BD.Name = "LabNgay_BD"
        Me.LabNgay_BD.Size = New System.Drawing.Size(72, 13)
        Me.LabNgay_BD.TabIndex = 46
        Me.LabNgay_BD.Tag = "Group 4"
        Me.LabNgay_BD.Text = "Ngày bắt đầu"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(6, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 301
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtTen_LHBH
        '
        Me.TxtTen_LHBH.BackColor = System.Drawing.Color.White
        Me.TxtTen_LHBH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_LHBH.Enabled = False
        Me.TxtTen_LHBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LHBH.Location = New System.Drawing.Point(249, 79)
        Me.TxtTen_LHBH.Name = "TxtTen_LHBH"
        Me.TxtTen_LHBH.ReadOnly = True
        Me.TxtTen_LHBH.Size = New System.Drawing.Size(414, 14)
        Me.TxtTen_LHBH.TabIndex = 387
        Me.TxtTen_LHBH.TabStop = False
        '
        'TxtMa_LHBH
        '
        Me.TxtMa_LHBH._ActilookupPopup = False
        Me.TxtMa_LHBH.CyberActilookupPopup = True
        Me.TxtMa_LHBH.Dv_ListDetail = Nothing
        Me.TxtMa_LHBH.Dv_Master = Nothing
        Me.TxtMa_LHBH.FilterClient = ""
        Me.TxtMa_LHBH.FilterSQL = ""
        Me.TxtMa_LHBH.Location = New System.Drawing.Point(109, 76)
        Me.TxtMa_LHBH.Name = "TxtMa_LHBH"
        Me.TxtMa_LHBH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LHBH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_LHBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_LHBH.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_LHBH.TabIndex = 3
        Me.TxtMa_LHBH.Table_Name = ""
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(6, 81)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(72, 13)
        Me.LabMa_kho.TabIndex = 386
        Me.LabMa_kho.Tag = "Stock code"
        Me.LabMa_kho.Text = "Loại hình BH"
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(249, 102)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(414, 14)
        Me.TxtTen_BH.TabIndex = 390
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(109, 99)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_BH.TabIndex = 4
        Me.TxtMa_BH.Table_Name = ""
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(6, 105)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(72, 13)
        Me.LabMa_vt.TabIndex = 389
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Đơn vị BH"
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(109, 146)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(135, 21)
        Me.TxtStt_Rec.TabIndex = 6
        Me.TxtStt_Rec.TabStop = False
        '
        'LabelID
        '
        Me.LabelID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabelID.ForeColor = System.Drawing.Color.Navy
        Me.LabelID.Location = New System.Drawing.Point(6, 153)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(72, 13)
        Me.LabelID.TabIndex = 391
        Me.LabelID.Tag = "Year"
        Me.LabelID.Text = "ID"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(109, 170)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Xe.TabIndex = 7
        '
        'LabMa_xe
        '
        Me.LabMa_xe.ForeColor = System.Drawing.Color.Black
        Me.LabMa_xe.Location = New System.Drawing.Point(6, 177)
        Me.LabMa_xe.Name = "LabMa_xe"
        Me.LabMa_xe.Size = New System.Drawing.Size(72, 13)
        Me.LabMa_xe.TabIndex = 418
        Me.LabMa_xe.Tag = "License plate"
        Me.LabMa_xe.Text = "Biển số"
        '
        'Labso_khung
        '
        Me.Labso_khung.ForeColor = System.Drawing.Color.Black
        Me.Labso_khung.Location = New System.Drawing.Point(6, 201)
        Me.Labso_khung.Name = "Labso_khung"
        Me.Labso_khung.Size = New System.Drawing.Size(72, 13)
        Me.Labso_khung.TabIndex = 2091
        Me.Labso_khung.Tag = "Chassis number"
        Me.Labso_khung.Text = "Số khung"
        '
        'LabelMa_Kx
        '
        Me.LabelMa_Kx.ForeColor = System.Drawing.Color.Black
        Me.LabelMa_Kx.Location = New System.Drawing.Point(6, 225)
        Me.LabelMa_Kx.Name = "LabelMa_Kx"
        Me.LabelMa_Kx.Size = New System.Drawing.Size(72, 13)
        Me.LabelMa_Kx.TabIndex = 2093
        Me.LabelMa_Kx.Tag = "Chassis number"
        Me.LabelMa_Kx.Text = "Kiểu xe"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 2096
        Me.Label9.Tag = "Address"
        Me.Label9.Text = "Tên KH"
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(109, 244)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.Size = New System.Drawing.Size(296, 21)
        Me.TxtTen_Kh.TabIndex = 10
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDien_Thoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDien_Thoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(109, 268)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(135, 21)
        Me.TxtDien_Thoai.TabIndex = 11
        '
        'labDien_thoai
        '
        Me.labDien_thoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.labDien_thoai.ForeColor = System.Drawing.Color.Black
        Me.labDien_thoai.Location = New System.Drawing.Point(6, 273)
        Me.labDien_thoai.Name = "labDien_thoai"
        Me.labDien_thoai.Size = New System.Drawing.Size(72, 13)
        Me.labDien_thoai.TabIndex = 2098
        Me.labDien_thoai.Tag = "Tel"
        Me.labDien_thoai.Text = "Điện thoại"
        '
        'txtDia_chi
        '
        Me.txtDia_chi.ForeColor = System.Drawing.Color.Navy
        Me.txtDia_chi.Location = New System.Drawing.Point(109, 292)
        Me.txtDia_chi.Name = "txtDia_chi"
        Me.txtDia_chi.Size = New System.Drawing.Size(296, 21)
        Me.txtDia_chi.TabIndex = 12
        '
        'LabDia_chi
        '
        Me.LabDia_chi.Location = New System.Drawing.Point(6, 297)
        Me.LabDia_chi.Name = "LabDia_chi"
        Me.LabDia_chi.Size = New System.Drawing.Size(72, 13)
        Me.LabDia_chi.TabIndex = 2100
        Me.LabDia_chi.Tag = "Address VAT"
        Me.LabDia_chi.Text = "Địa chỉ"
        '
        'labGT_Xe
        '
        Me.labGT_Xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.labGT_Xe.Location = New System.Drawing.Point(6, 321)
        Me.labGT_Xe.Name = "labGT_Xe"
        Me.labGT_Xe.Size = New System.Drawing.Size(72, 13)
        Me.labGT_Xe.TabIndex = 2102
        Me.labGT_Xe.Tag = "Value (currency)"
        Me.labGT_Xe.Text = "Giá trị xe"
        '
        'TxtTien_NT
        '
        Me.TxtTien_NT.AllowNegative = True
        Me.TxtTien_NT.Flags = 7680
        Me.TxtTien_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT.InputMask = "### ### ### ### ###"
        Me.TxtTien_NT.Location = New System.Drawing.Point(109, 340)
        Me.TxtTien_NT.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTien_NT.MaxWholeDigits = 14
        Me.TxtTien_NT.Name = "TxtTien_NT"
        Me.TxtTien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT.Size = New System.Drawing.Size(135, 21)
        Me.TxtTien_NT.TabIndex = 14
        Me.TxtTien_NT.Text = "0"
        Me.TxtTien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelTien_Nt
        '
        Me.LabelTien_Nt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabelTien_Nt.Location = New System.Drawing.Point(6, 345)
        Me.LabelTien_Nt.Name = "LabelTien_Nt"
        Me.LabelTien_Nt.Size = New System.Drawing.Size(83, 13)
        Me.LabelTien_Nt.TabIndex = 2104
        Me.LabelTien_Nt.Tag = "Value (currency)"
        Me.LabelTien_Nt.Text = "Tiền bảo hiểm"
        '
        'TxtMa_Loai_CRM
        '
        Me.TxtMa_Loai_CRM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Loai_CRM.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai_CRM.Location = New System.Drawing.Point(109, 122)
        Me.TxtMa_Loai_CRM.Name = "TxtMa_Loai_CRM"
        Me.TxtMa_Loai_CRM.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Loai_CRM.TabIndex = 5
        '
        'LabMa_Loai_CRM
        '
        Me.LabMa_Loai_CRM.Location = New System.Drawing.Point(6, 129)
        Me.LabMa_Loai_CRM.Name = "LabMa_Loai_CRM"
        Me.LabMa_Loai_CRM.Size = New System.Drawing.Size(72, 13)
        Me.LabMa_Loai_CRM.TabIndex = 2106
        Me.LabMa_Loai_CRM.Tag = "Code"
        Me.LabMa_Loai_CRM.Text = "Mã loại CSKH"
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSo_Khung.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(109, 195)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_Khung.TabIndex = 8
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMa_Kx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Location = New System.Drawing.Point(109, 220)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Kx.TabIndex = 9
        '
        'TxtGT_Xe
        '
        Me.TxtGT_Xe.AllowNegative = True
        Me.TxtGT_Xe.Flags = 7680
        Me.TxtGT_Xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGT_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtGT_Xe.InputMask = "### ### ### ### ###"
        Me.TxtGT_Xe.Location = New System.Drawing.Point(109, 316)
        Me.TxtGT_Xe.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtGT_Xe.MaxWholeDigits = 14
        Me.TxtGT_Xe.Name = "TxtGT_Xe"
        Me.TxtGT_Xe.RangeMax = 1.7976931348623157E+308R
        Me.TxtGT_Xe.RangeMin = -1.7976931348623157E+308R
        Me.TxtGT_Xe.Size = New System.Drawing.Size(135, 21)
        Me.TxtGT_Xe.TabIndex = 13
        Me.TxtGT_Xe.Text = "0"
        Me.TxtGT_Xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNam
        '
        Me.TxtNam.AllowNegative = True
        Me.TxtNam.Flags = 7680
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.InputMask = "### ### ### ### ###"
        Me.TxtNam.Location = New System.Drawing.Point(109, 52)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNam.MaxWholeDigits = 14
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.RangeMax = 1.7976931348623157E+308R
        Me.TxtNam.RangeMin = -1.7976931348623157E+308R
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 2107
        Me.TxtNam.Text = "0"
        Me.TxtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CDBaoHiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 403)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.TxtMa_Loai_CRM)
        Me.Controls.Add(Me.LabMa_Loai_CRM)
        Me.Controls.Add(Me.TxtTien_NT)
        Me.Controls.Add(Me.LabelTien_Nt)
        Me.Controls.Add(Me.TxtGT_Xe)
        Me.Controls.Add(Me.labGT_Xe)
        Me.Controls.Add(Me.txtDia_chi)
        Me.Controls.Add(Me.LabDia_chi)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.labDien_thoai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.LabelMa_Kx)
        Me.Controls.Add(Me.Labso_khung)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.LabMa_xe)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_vt)
        Me.Controls.Add(Me.TxtTen_LHBH)
        Me.Controls.Add(Me.TxtMa_LHBH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Controls.Add(Me.LabNgay_KT)
        Me.Controls.Add(Me.LabNgay_BD)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 150)
        Me.Name = "CDBaoHiem"
        Me.Tb_Name = ""
        Me.Text = "Danh mục đầu kỳ xe bảo hiểm"
        Me.Controls.SetChildIndex(Me.LabNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LHBH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LHBH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.LabelID, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.LabMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Labso_khung, 0)
        Me.Controls.SetChildIndex(Me.LabelMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.labDien_thoai, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.LabDia_chi, 0)
        Me.Controls.SetChildIndex(Me.txtDia_chi, 0)
        Me.Controls.SetChildIndex(Me.labGT_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtGT_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabelTien_Nt, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Loai_CRM, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai_CRM, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_KT As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_BD As ClsTextBox.txtDate
    Friend WithEvents LabNgay_KT As System.Windows.Forms.Label
    Friend WithEvents LabNgay_BD As System.Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtTen_LHBH As Windows.Forms.TextBox
    Friend WithEvents TxtMa_LHBH As SmLists.TxtLookup
    Friend WithEvents LabMa_kho As Windows.Forms.Label
    Friend WithEvents TxtTen_BH As Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As SmLists.TxtLookup
    Friend WithEvents LabMa_vt As Windows.Forms.Label
    Friend WithEvents TxtStt_Rec As Windows.Forms.TextBox
    Friend WithEvents LabelID As Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Windows.Forms.TextBox
    Friend WithEvents LabMa_xe As Windows.Forms.Label
    Friend WithEvents Labso_khung As Windows.Forms.Label
    Friend WithEvents LabelMa_Kx As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtTen_Kh As Windows.Forms.TextBox
    Friend WithEvents TxtDien_Thoai As Windows.Forms.TextBox
    Friend WithEvents labDien_thoai As Windows.Forms.Label
    Friend WithEvents txtDia_chi As Windows.Forms.TextBox
    Friend WithEvents LabDia_chi As Windows.Forms.Label
    Friend WithEvents labGT_Xe As Windows.Forms.Label
    Friend WithEvents TxtTien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents LabelTien_Nt As Windows.Forms.Label
    Friend WithEvents TxtMa_Loai_CRM As Windows.Forms.TextBox
    Friend WithEvents LabMa_Loai_CRM As Windows.Forms.Label
    Friend WithEvents TxtSo_Khung As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Windows.Forms.TextBox
    Friend WithEvents TxtGT_Xe As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNam As ClsTextBox.txtTien_NT
End Class
