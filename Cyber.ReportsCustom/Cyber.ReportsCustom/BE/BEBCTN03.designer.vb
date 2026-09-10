<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEBCTN03
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ma_Bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Bp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_Hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_Kx = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_Mau = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CbbM_Ma_Loc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtM_Ma_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 229)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 190)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 193)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 229)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 167)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 167)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 168)
        Me.ChkNT.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 212)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(188, 307)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox1.TabIndex = 158
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 50)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 162
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 29)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 161
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(94, 49)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 160
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(94, 27)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 159
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ma_Bp
        '
        Me.TxtM_Ma_Bp._ActilookupPopup = False
        Me.TxtM_Ma_Bp.CyberActilookupPopup = True
        Me.TxtM_Ma_Bp.Dv_ListDetail = Nothing
        Me.TxtM_Ma_Bp.Dv_Master = Nothing
        Me.TxtM_Ma_Bp.FilterClient = Nothing
        Me.TxtM_Ma_Bp.FilterSQL = Nothing
        Me.TxtM_Ma_Bp.Location = New System.Drawing.Point(94, 95)
        Me.TxtM_Ma_Bp.Name = "TxtM_Ma_Bp"
        Me.TxtM_Ma_Bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_Bp.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_Bp.Size = New System.Drawing.Size(113, 20)
        Me.TxtM_Ma_Bp.TabIndex = 170
        Me.TxtM_Ma_Bp.Table_Name = Nothing
        '
        'TxtTen_Bp
        '
        Me.TxtTen_Bp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp.Location = New System.Drawing.Point(209, 98)
        Me.TxtTen_Bp.Name = "TxtTen_Bp"
        Me.TxtTen_Bp.ReadOnly = True
        Me.TxtTen_Bp.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Bp.TabIndex = 172
        Me.TxtTen_Bp.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 171
        Me.Label7.Tag = "Phòng ban"
        Me.Label7.Text = "Phòng ban"
        '
        'TxtM_Ma_Hs
        '
        Me.TxtM_Ma_Hs._ActilookupPopup = False
        Me.TxtM_Ma_Hs.CyberActilookupPopup = True
        Me.TxtM_Ma_Hs.Dv_ListDetail = Nothing
        Me.TxtM_Ma_Hs.Dv_Master = Nothing
        Me.TxtM_Ma_Hs.FilterClient = Nothing
        Me.TxtM_Ma_Hs.FilterSQL = Nothing
        Me.TxtM_Ma_Hs.Location = New System.Drawing.Point(94, 72)
        Me.TxtM_Ma_Hs.Name = "TxtM_Ma_Hs"
        Me.TxtM_Ma_Hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_Hs.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_Hs.Size = New System.Drawing.Size(113, 20)
        Me.TxtM_Ma_Hs.TabIndex = 167
        Me.TxtM_Ma_Hs.Table_Name = Nothing
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(209, 75)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Hs.TabIndex = 169
        Me.TxtTen_Hs.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 168
        Me.Label6.Tag = "Nhân viên"
        Me.Label6.Text = "Nhân viên"
        '
        'TxtM_Ma_Kx
        '
        Me.TxtM_Ma_Kx._ActilookupPopup = False
        Me.TxtM_Ma_Kx.CyberActilookupPopup = True
        Me.TxtM_Ma_Kx.Dv_ListDetail = Nothing
        Me.TxtM_Ma_Kx.Dv_Master = Nothing
        Me.TxtM_Ma_Kx.FilterClient = Nothing
        Me.TxtM_Ma_Kx.FilterSQL = Nothing
        Me.TxtM_Ma_Kx.Location = New System.Drawing.Point(94, 118)
        Me.TxtM_Ma_Kx.Name = "TxtM_Ma_Kx"
        Me.TxtM_Ma_Kx.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_Kx.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_Kx.Size = New System.Drawing.Size(113, 20)
        Me.TxtM_Ma_Kx.TabIndex = 173
        Me.TxtM_Ma_Kx.Table_Name = Nothing
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(209, 121)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_kx.TabIndex = 175
        Me.TxtTen_kx.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Tag = "Kiểu xe"
        Me.Label2.Text = "Kiểu xe"
        '
        'TxtM_Ma_Mau
        '
        Me.TxtM_Ma_Mau._ActilookupPopup = False
        Me.TxtM_Ma_Mau.CyberActilookupPopup = True
        Me.TxtM_Ma_Mau.Dv_ListDetail = Nothing
        Me.TxtM_Ma_Mau.Dv_Master = Nothing
        Me.TxtM_Ma_Mau.FilterClient = Nothing
        Me.TxtM_Ma_Mau.FilterSQL = Nothing
        Me.TxtM_Ma_Mau.Location = New System.Drawing.Point(94, 141)
        Me.TxtM_Ma_Mau.Name = "TxtM_Ma_Mau"
        Me.TxtM_Ma_Mau.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_Mau.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_Mau.Size = New System.Drawing.Size(113, 20)
        Me.TxtM_Ma_Mau.TabIndex = 176
        Me.TxtM_Ma_Mau.Table_Name = Nothing
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(209, 144)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Mau.TabIndex = 178
        Me.TxtTen_Mau.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 177
        Me.Label3.Tag = "Màu xe"
        Me.Label3.Text = "Màu xe"
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = Nothing
        Me.TxtMa_Mau.FilterSQL = Nothing
        Me.TxtMa_Mau.Location = New System.Drawing.Point(96, 142)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(113, 20)
        Me.TxtMa_Mau.TabIndex = 176
        Me.TxtMa_Mau.Table_Name = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(209, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(382, 13)
        Me.TextBox1.TabIndex = 178
        Me.TextBox1.TabStop = False
        '
        'CbbM_Ma_Loc
        '
        Me.CbbM_Ma_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Ma_Loc.FormattingEnabled = True
        Me.CbbM_Ma_Loc.Location = New System.Drawing.Point(93, 3)
        Me.CbbM_Ma_Loc.Name = "CbbM_Ma_Loc"
        Me.CbbM_Ma_Loc.Size = New System.Drawing.Size(220, 21)
        Me.CbbM_Ma_Loc.TabIndex = 179
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Tag = "Màu xe"
        Me.Label4.Text = "Lọc theo"
        '
        'BEBCTN03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 281)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Ma_Loc)
        Me.Controls.Add(Me.TxtM_Ma_Mau)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtM_Ma_Kx)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Ma_Bp)
        Me.Controls.Add(Me.TxtTen_Bp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtM_Ma_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BEBCTN03"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_Bp, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_Mau, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Ma_Loc, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtM_Ma_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ma_Bp As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Bp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CbbM_Ma_Loc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
