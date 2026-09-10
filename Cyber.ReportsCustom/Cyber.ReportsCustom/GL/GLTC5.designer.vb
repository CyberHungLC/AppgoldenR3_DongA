<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC5
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
        Me.TxtM_Ngay_Ct4 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct3 = New ClsTextBox.txtDate1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbDmMauBc = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNonVat = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbMa_TTCP = New System.Windows.Forms.ComboBox()
        CType(Me.TxtNonVat.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = true
        Me.ButtExit.Location = New System.Drawing.Point(492, 249)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 210)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 213)
        Me.Label1.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = true
        Me.ButtOK.Location = New System.Drawing.Point(388, 249)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 191)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 188)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 188)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = false
        Me.TxtM_Ngay_Ct1.isEmpty = true
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(161, 19)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = false
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = false
        Me.TxtM_Ngay_Ct2.isEmpty = true
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(369, 19)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = false
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = true
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(97, 22)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 0
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = true
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(284, 22)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 232)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = false
        '
        'LabM_Ngay_Ct4
        '
        Me.LabM_Ngay_Ct4.AutoSize = true
        Me.LabM_Ngay_Ct4.Location = New System.Drawing.Point(284, 73)
        Me.LabM_Ngay_Ct4.Name = "LabM_Ngay_Ct4"
        Me.LabM_Ngay_Ct4.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct4.TabIndex = 19
        Me.LabM_Ngay_Ct4.Tag = "Date to"
        Me.LabM_Ngay_Ct4.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct3
        '
        Me.LabM_Ngay_Ct3.AutoSize = true
        Me.LabM_Ngay_Ct3.Location = New System.Drawing.Point(97, 73)
        Me.LabM_Ngay_Ct3.Name = "LabM_Ngay_Ct3"
        Me.LabM_Ngay_Ct3.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct3.TabIndex = 18
        Me.LabM_Ngay_Ct3.Tag = "Date from"
        Me.LabM_Ngay_Ct3.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct4
        '
        Me.TxtM_Ngay_Ct4.Flags = 0
        Me.TxtM_Ngay_Ct4.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct4.IsAllowResize = false
        Me.TxtM_Ngay_Ct4.isEmpty = true
        Me.TxtM_Ngay_Ct4.Location = New System.Drawing.Point(369, 70)
        Me.TxtM_Ngay_Ct4.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct4.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct4.MaxLength = 10
        Me.TxtM_Ngay_Ct4.Name = "TxtM_Ngay_Ct4"
        Me.TxtM_Ngay_Ct4.RangeMax = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct4.RangeMin = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct4.ShowDayBeforeMonth = false
        Me.TxtM_Ngay_Ct4.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct4.TabIndex = 3
        Me.TxtM_Ngay_Ct4.Text = "__/__/____"
        Me.TxtM_Ngay_Ct4.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct3
        '
        Me.TxtM_Ngay_Ct3.Flags = 0
        Me.TxtM_Ngay_Ct3.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct3.IsAllowResize = false
        Me.TxtM_Ngay_Ct3.isEmpty = true
        Me.TxtM_Ngay_Ct3.Location = New System.Drawing.Point(161, 70)
        Me.TxtM_Ngay_Ct3.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct3.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct3.MaxLength = 10
        Me.TxtM_Ngay_Ct3.Name = "TxtM_Ngay_Ct3"
        Me.TxtM_Ngay_Ct3.RangeMax = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct3.RangeMin = New Date(CType(0,Long))
        Me.TxtM_Ngay_Ct3.ShowDayBeforeMonth = false
        Me.TxtM_Ngay_Ct3.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct3.TabIndex = 2
        Me.TxtM_Ngay_Ct3.Text = "__/__/____"
        Me.TxtM_Ngay_Ct3.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = true
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
        Me.CmbDmMauBc.FormattingEnabled = true
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
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Tag = "This period"
        Me.GroupBox1.Text = "Kỳ này"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 44)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Tag = "Previous period"
        Me.GroupBox2.Text = "Kỳ trước"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 158)
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
        Me.TxtNonVat.Location = New System.Drawing.Point(95, 155)
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
        Me.Label11.Location = New System.Drawing.Point(10, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 2209
        Me.Label11.Tag = "Corresponding acc"
        Me.Label11.Text = "Loại sổ"
        Me.Label11.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(9, 131)
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
        Me.CmbMa_TTCP.Location = New System.Drawing.Point(95, 130)
        Me.CmbMa_TTCP.Name = "CmbMa_TTCP"
        Me.CmbMa_TTCP.Size = New System.Drawing.Size(158, 21)
        Me.CmbMa_TTCP.TabIndex = 2221
        '
        'GLTC5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(596, 302)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CmbMa_TTCP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNonVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbDmMauBc)
        Me.Controls.Add(Me.LabM_Ngay_Ct4)
        Me.Controls.Add(Me.LabM_Ngay_Ct3)
        Me.Controls.Add(Me.TxtM_Ngay_Ct4)
        Me.Controls.Add(Me.TxtM_Ngay_Ct3)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GLTC5"
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
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct3, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct4, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct3, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct4, 0)
        Me.Controls.SetChildIndex(Me.CmbDmMauBc, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNonVat, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        CType(Me.TxtNonVat.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Ngay_Ct4 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct3 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct4 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct3 As ClsTextBox.txtDate1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbDmMauBc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNonVat As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TTCP As System.Windows.Forms.ComboBox

End Class
