<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RO_HD03_XanhSm
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
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkIs_All = New System.Windows.Forms.CheckBox()
        Me.ChkIs_N = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.ChkIs_I = New System.Windows.Forms.CheckBox()
        Me.ChkIs_C = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkIs_Con_CN = New System.Windows.Forms.CheckBox()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTCP = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(505, 286)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 247)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(504, 21)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 250)
        Me.Label1.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(401, 286)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 229)
        Me.LabLoai_NT.TabIndex = 11
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 226)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 226)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 9)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 30)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 12)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 35)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 269)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(602, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Enabled = False
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(217, 57)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(361, 14)
        Me.TxtTen_TK.TabIndex = 21
        Me.TxtTen_TK.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Tài khoản"
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.Location = New System.Drawing.Point(95, 99)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(114, 21)
        Me.TxtSo_RO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Tag = "No R/O"
        Me.Label2.Text = "Số R/O"
        '
        'TxtTK
        '
        Me.TxtTK._ActilookupPopup = False
        Me.TxtTK.CyberActilookupPopup = True
        Me.TxtTK.Dv_ListDetail = Nothing
        Me.TxtTK.Dv_Master = Nothing
        Me.TxtTK.FilterClient = ""
        Me.TxtTK.FilterSQL = ""
        Me.TxtTK.Location = New System.Drawing.Point(95, 55)
        Me.TxtTK.Name = "TxtTK"
        Me.TxtTK.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK.Properties.Appearance.Options.UseFont = True
        Me.TxtTK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK.Size = New System.Drawing.Size(114, 20)
        Me.TxtTK.TabIndex = 2
        Me.TxtTK.Table_Name = ""
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Enabled = False
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(217, 80)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(361, 14)
        Me.TxtTen_Kh.TabIndex = 27
        Me.TxtTen_Kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(95, 77)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kh.TabIndex = 3
        Me.TxtMa_Kh.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Khách hàng"
        '
        'ChkIs_All
        '
        Me.ChkIs_All.AutoSize = True
        Me.ChkIs_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_All.Location = New System.Drawing.Point(95, 153)
        Me.ChkIs_All.Name = "ChkIs_All"
        Me.ChkIs_All.Size = New System.Drawing.Size(154, 17)
        Me.ChkIs_All.TabIndex = 28
        Me.ChkIs_All.Text = "Tất cả loại hình thanh toán"
        Me.ChkIs_All.UseVisualStyleBackColor = True
        '
        'ChkIs_N
        '
        Me.ChkIs_N.AutoSize = True
        Me.ChkIs_N.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_N.Location = New System.Drawing.Point(317, 196)
        Me.ChkIs_N.Name = "ChkIs_N"
        Me.ChkIs_N.Size = New System.Drawing.Size(130, 17)
        Me.ChkIs_N.TabIndex = 32
        Me.ChkIs_N.Text = "Nội bộ thanh toán (N)"
        Me.ChkIs_N.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_W.Location = New System.Drawing.Point(95, 196)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(148, 17)
        Me.ChkIs_W.TabIndex = 30
        Me.ChkIs_W.Text = "Bảo hành thanh toán (W)"
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'ChkIs_I
        '
        Me.ChkIs_I.AutoSize = True
        Me.ChkIs_I.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_I.Location = New System.Drawing.Point(317, 174)
        Me.ChkIs_I.Name = "ChkIs_I"
        Me.ChkIs_I.Size = New System.Drawing.Size(140, 17)
        Me.ChkIs_I.TabIndex = 31
        Me.ChkIs_I.Text = "Bảo hiểm thanh toán (I)"
        Me.ChkIs_I.UseVisualStyleBackColor = True
        '
        'ChkIs_C
        '
        Me.ChkIs_C.AutoSize = True
        Me.ChkIs_C.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_C.Location = New System.Drawing.Point(95, 174)
        Me.ChkIs_C.Name = "ChkIs_C"
        Me.ChkIs_C.Size = New System.Drawing.Size(156, 17)
        Me.ChkIs_C.TabIndex = 29
        Me.ChkIs_C.Text = "Khách hàng thanh toán (C)"
        Me.ChkIs_C.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(382, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 17)
        Me.Label12.TabIndex = 2210
        Me.Label12.Tag = "Corresponding acc"
        Me.Label12.Text = "0 - Kê khai thuế, 1 - Không kê khai thuế"
        Me.Label12.Visible = False
        '
        'TxtNonVat
        '
        Me.TxtNonVat._ActilookupPopup = False
        Me.TxtNonVat.CyberActilookupPopup = True
        Me.TxtNonVat.Dv_ListDetail = Nothing
        Me.TxtNonVat.Dv_Master = Nothing
        Me.TxtNonVat.FilterClient = ""
        Me.TxtNonVat.FilterSQL = ""
        Me.TxtNonVat.Location = New System.Drawing.Point(385, 30)
        Me.TxtNonVat.Name = "TxtNonVat"
        Me.TxtNonVat.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNonVat.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNonVat.Properties.Appearance.Options.UseFont = True
        Me.TxtNonVat.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNonVat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNonVat.Size = New System.Drawing.Size(114, 20)
        Me.TxtNonVat.TabIndex = 5
        Me.TxtNonVat.Table_Name = ""
        Me.TxtNonVat.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(382, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 2209
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        Me.Label11.Visible = False
        '
        'ChkIs_Con_CN
        '
        Me.ChkIs_Con_CN.AutoSize = True
        Me.ChkIs_Con_CN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_Con_CN.Location = New System.Drawing.Point(385, 13)
        Me.ChkIs_Con_CN.Name = "ChkIs_Con_CN"
        Me.ChkIs_Con_CN.Size = New System.Drawing.Size(110, 17)
        Me.ChkIs_Con_CN.TabIndex = 2212
        Me.ChkIs_Con_CN.Text = "Lệnh còn công nợ"
        Me.ChkIs_Con_CN.UseVisualStyleBackColor = True
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(10, 125)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(54, 13)
        Me.LabMa_Hs.TabIndex = 2215
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Xưởng DV"
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Enabled = False
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(223, 125)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_TTCP.TabIndex = 2214
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
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(95, 122)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_TTCP.TabIndex = 2213
        Me.TxtMa_TTCP.Table_Name = ""
        '
        'RO_HD03_XanhSm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 339)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.Controls.Add(Me.ChkIs_Con_CN)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ChkIs_All)
        Me.Controls.Add(Me.ChkIs_N)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.ChkIs_I)
        Me.Controls.Add(Me.ChkIs_C)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(488, 179)
        Me.Name = "RO_HD03_XanhSm"
        Me.Text = "Điều kiện lọc báo cáo "
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
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_All, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Con_CN, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kh As TextBox
    Friend WithEvents TxtMa_Kh As SmLists.TxtLookup
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkIs_All As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_N As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_W As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_I As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_C As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_Con_CN As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_Hs As Label
    Friend WithEvents TxtTen_TTCP As TextBox
    Friend WithEvents TxtMa_TTCP As SmLists.TxtLookup
End Class
