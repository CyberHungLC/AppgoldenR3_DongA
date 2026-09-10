<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSo1
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbMa_Post2 = New System.Windows.Forms.ComboBox()
        Me.CmbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbMa_TTCP = New System.Windows.Forms.ComboBox()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 228)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 189)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 192)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 228)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 170)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 167)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 167)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 48)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 71)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 51)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 74)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 211)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(9, 9)
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
        Me.TxtTen_Kho.Location = New System.Drawing.Point(216, 8)
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
        Me.TxtMa_Kho.Location = New System.Drawing.Point(95, 5)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kho.TabIndex = 0
        Me.TxtMa_Kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(9, 32)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Supplies"
        Me.LabMa_Cc.Text = "Mã vật tư"
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(216, 29)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Vt.TabIndex = 196
        Me.TxtTen_Vt.TabStop = False
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(95, 26)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Vt.TabIndex = 1
        Me.TxtMa_Vt.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(217, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 511
        Me.Label9.Tag = "Loại giao dịch"
        Me.Label9.Text = "Đến mức xử lý"
        '
        'CmbMa_Post2
        '
        Me.CmbMa_Post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Post2.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Post2.FormattingEnabled = True
        Me.CmbMa_Post2.Location = New System.Drawing.Point(296, 95)
        Me.CmbMa_Post2.Name = "CmbMa_Post2"
        Me.CmbMa_Post2.Size = New System.Drawing.Size(116, 21)
        Me.CmbMa_Post2.TabIndex = 6
        '
        'CmbMa_Post1
        '
        Me.CmbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Post1.FormattingEnabled = True
        Me.CmbMa_Post1.Location = New System.Drawing.Point(95, 93)
        Me.CmbMa_Post1.Name = "CmbMa_Post1"
        Me.CmbMa_Post1.Size = New System.Drawing.Size(116, 21)
        Me.CmbMa_Post1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 510
        Me.Label10.Tag = "Type"
        Me.Label10.Text = "Từ mức xử lý"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(215, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 17)
        Me.Label2.TabIndex = 2216
        Me.Label2.Tag = "Corresponding acc"
        Me.Label2.Text = "0 - Kê khai thuế, 1 - Không kê khai thuế"
        Me.Label2.Visible = False
        '
        'TxtNonVat
        '
        Me.TxtNonVat._ActilookupPopup = False
        Me.TxtNonVat.CyberActilookupPopup = True
        Me.TxtNonVat.Dv_ListDetail = Nothing
        Me.TxtNonVat.Dv_Master = Nothing
        Me.TxtNonVat.FilterClient = ""
        Me.TxtNonVat.FilterSQL = ""
        Me.TxtNonVat.Location = New System.Drawing.Point(98, 238)
        Me.TxtNonVat.Name = "TxtNonVat"
        Me.TxtNonVat.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNonVat.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNonVat.Properties.Appearance.Options.UseFont = True
        Me.TxtNonVat.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNonVat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNonVat.Size = New System.Drawing.Size(116, 20)
        Me.TxtNonVat.TabIndex = 4
        Me.TxtNonVat.Table_Name = ""
        Me.TxtNonVat.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(12, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 2215
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        Me.Label11.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(12, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 2222
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Đại lý"
        '
        'CmbMa_TTCP
        '
        Me.CmbMa_TTCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbMa_TTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TTCP.FormattingEnabled = True
        Me.CmbMa_TTCP.Location = New System.Drawing.Point(96, 116)
        Me.CmbMa_TTCP.Name = "CmbMa_TTCP"
        Me.CmbMa_TTCP.Size = New System.Drawing.Size(316, 21)
        Me.CmbMa_TTCP.TabIndex = 2221
        '
        'INSo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 281)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CmbMa_TTCP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbMa_Post2)
        Me.Controls.Add(Me.CmbMa_Post1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.TxtMa_Vt)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "INSo1"
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
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Post2, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_Post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TTCP As System.Windows.Forms.ComboBox

End Class
