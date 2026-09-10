<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC2
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
        Me.LabM_Ngay_Ct4 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct3 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_CT4 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_CT3 = New ClsTextBox.txtDate1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbDmMauBc = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtMa_TTCP = New System.Windows.Forms.TextBox()
        Me.BtnMa_TTCP = New System.Windows.Forms.Button()
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 237)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 198)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 201)
        Me.Label1.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 237)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 179)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 176)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 176)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(161, 19)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(369, 19)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(97, 22)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 0
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(284, 22)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 220)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Ngay_Ct4
        '
        Me.LabM_Ngay_Ct4.AutoSize = True
        Me.LabM_Ngay_Ct4.Location = New System.Drawing.Point(284, 73)
        Me.LabM_Ngay_Ct4.Name = "LabM_Ngay_Ct4"
        Me.LabM_Ngay_Ct4.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct4.TabIndex = 19
        Me.LabM_Ngay_Ct4.Tag = "Date to"
        Me.LabM_Ngay_Ct4.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct3
        '
        Me.LabM_Ngay_Ct3.AutoSize = True
        Me.LabM_Ngay_Ct3.Location = New System.Drawing.Point(97, 73)
        Me.LabM_Ngay_Ct3.Name = "LabM_Ngay_Ct3"
        Me.LabM_Ngay_Ct3.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct3.TabIndex = 18
        Me.LabM_Ngay_Ct3.Tag = "Date from"
        Me.LabM_Ngay_Ct3.Text = "Từ ngày"
        '
        'TxtM_Ngay_CT4
        '
        Me.TxtM_Ngay_CT4.Flags = 0
        Me.TxtM_Ngay_CT4.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_CT4.IsAllowResize = False
        Me.TxtM_Ngay_CT4.isEmpty = True
        Me.TxtM_Ngay_CT4.Location = New System.Drawing.Point(369, 70)
        Me.TxtM_Ngay_CT4.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_CT4.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_CT4.MaxLength = 10
        Me.TxtM_Ngay_CT4.Name = "TxtM_Ngay_CT4"
        Me.TxtM_Ngay_CT4.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_CT4.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_CT4.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_CT4.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_CT4.TabIndex = 3
        Me.TxtM_Ngay_CT4.Text = "__/__/____"
        Me.TxtM_Ngay_CT4.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_CT3
        '
        Me.TxtM_Ngay_CT3.Flags = 0
        Me.TxtM_Ngay_CT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_CT3.IsAllowResize = False
        Me.TxtM_Ngay_CT3.isEmpty = True
        Me.TxtM_Ngay_CT3.Location = New System.Drawing.Point(161, 70)
        Me.TxtM_Ngay_CT3.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_CT3.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_CT3.MaxLength = 10
        Me.TxtM_Ngay_CT3.Name = "TxtM_Ngay_CT3"
        Me.TxtM_Ngay_CT3.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_CT3.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_CT3.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_CT3.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_CT3.TabIndex = 2
        Me.TxtM_Ngay_CT3.Text = "__/__/____"
        Me.TxtM_Ngay_CT3.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Tag = "Form"
        Me.Label4.Text = "Mẫu theo"
        '
        'CmbDmMauBc
        '
        Me.CmbDmMauBc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDmMauBc.ForeColor = System.Drawing.Color.Navy
        Me.CmbDmMauBc.FormattingEnabled = True
        Me.CmbDmMauBc.Location = New System.Drawing.Point(95, 107)
        Me.CmbDmMauBc.Name = "CmbDmMauBc"
        Me.CmbDmMauBc.Size = New System.Drawing.Size(491, 21)
        Me.CmbDmMauBc.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 44)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "This period"
        Me.GroupBox1.Text = "Kỳ này"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 44)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "Previous period"
        Me.GroupBox2.Text = "Kỳ trước"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 17)
        Me.Label12.TabIndex = 2207
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
        Me.TxtNonVat.Location = New System.Drawing.Point(95, 151)
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
        Me.Label11.Location = New System.Drawing.Point(10, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 2206
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        Me.Label11.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(9, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 2220
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Đại lý"
        '
        'TxtMa_TTCP
        '
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(95, 129)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_TTCP.TabIndex = 2221
        '
        'BtnMa_TTCP
        '
        Me.BtnMa_TTCP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnMa_TTCP.ForeColor = System.Drawing.Color.Red
        Me.BtnMa_TTCP.Location = New System.Drawing.Point(215, 128)
        Me.BtnMa_TTCP.Name = "BtnMa_TTCP"
        Me.BtnMa_TTCP.Size = New System.Drawing.Size(65, 23)
        Me.BtnMa_TTCP.TabIndex = 2222
        Me.BtnMa_TTCP.Text = "..."
        Me.BtnMa_TTCP.UseVisualStyleBackColor = True
        '
        'GLTC2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 290)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.Controls.Add(Me.BtnMa_TTCP)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbDmMauBc)
        Me.Controls.Add(Me.LabM_Ngay_Ct4)
        Me.Controls.Add(Me.LabM_Ngay_Ct3)
        Me.Controls.Add(Me.TxtM_Ngay_CT4)
        Me.Controls.Add(Me.TxtM_Ngay_CT3)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GLTC2"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
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
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_CT3, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_CT4, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct3, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct4, 0)
        Me.Controls.SetChildIndex(Me.CmbDmMauBc, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.BtnMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        CType(Me.TxtNonVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Ngay_Ct4 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct3 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_CT4 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_CT3 As ClsTextBox.txtDate1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbDmMauBc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_TTCP As TextBox
    Friend WithEvents BtnMa_TTCP As Button
End Class
