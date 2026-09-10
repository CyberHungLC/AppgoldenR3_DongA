<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRM_KQLH_Detail
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Loai = New System.Windows.Forms.TextBox()
        Me.TxtMa_Loai = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Ngay = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ngay = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Cs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cs = New Cyber.SmLists.TxtLookup()
        Me.ChkNgay_Goi = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(688, 260)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(119, 209)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(685, 25)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 213)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(549, 260)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 184)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(119, 180)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(321, 180)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(119, 5)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(119, 38)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(7, 9)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(7, 42)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 238)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(817, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 1867
        Me.Label6.Tag = "Staff"
        Me.Label6.Text = "Loại chăm sóc"
        '
        'TxtTen_Loai
        '
        Me.TxtTen_Loai.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai.Enabled = False
        Me.TxtTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai.Location = New System.Drawing.Point(287, 107)
        Me.TxtTen_Loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Loai.Name = "TxtTen_Loai"
        Me.TxtTen_Loai.ReadOnly = True
        Me.TxtTen_Loai.Size = New System.Drawing.Size(454, 17)
        Me.TxtTen_Loai.TabIndex = 1866
        Me.TxtTen_Loai.TabStop = False
        '
        'TxtMa_Loai
        '
        Me.TxtMa_Loai._ActilookupPopup = False
        Me.TxtMa_Loai.CyberActilookupPopup = True
        Me.TxtMa_Loai.Dv_ListDetail = Nothing
        Me.TxtMa_Loai.Dv_Master = Nothing
        Me.TxtMa_Loai.FilterClient = ""
        Me.TxtMa_Loai.FilterSQL = ""
        Me.TxtMa_Loai.Location = New System.Drawing.Point(119, 104)
        Me.TxtMa_Loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Loai.Name = "TxtMa_Loai"
        Me.TxtMa_Loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Loai.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Loai.TabIndex = 3
        Me.TxtMa_Loai.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 1862
        Me.Label4.Tag = "type car"
        Me.Label4.Text = "Mã ngày"
        '
        'Txtten_Ngay
        '
        Me.Txtten_Ngay.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Ngay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Ngay.Enabled = False
        Me.Txtten_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Ngay.Location = New System.Drawing.Point(287, 141)
        Me.Txtten_Ngay.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtten_Ngay.Name = "Txtten_Ngay"
        Me.Txtten_Ngay.ReadOnly = True
        Me.Txtten_Ngay.Size = New System.Drawing.Size(454, 17)
        Me.Txtten_Ngay.TabIndex = 1861
        Me.Txtten_Ngay.TabStop = False
        '
        'TxtMa_Ngay
        '
        Me.TxtMa_Ngay._ActilookupPopup = False
        Me.TxtMa_Ngay.CyberActilookupPopup = True
        Me.TxtMa_Ngay.Dv_ListDetail = Nothing
        Me.TxtMa_Ngay.Dv_Master = Nothing
        Me.TxtMa_Ngay.FilterClient = ""
        Me.TxtMa_Ngay.FilterSQL = ""
        Me.TxtMa_Ngay.Location = New System.Drawing.Point(119, 138)
        Me.TxtMa_Ngay.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ngay.Name = "TxtMa_Ngay"
        Me.TxtMa_Ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ngay.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Ngay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Ngay.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Ngay.TabIndex = 4
        Me.TxtMa_Ngay.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 1872
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "NV CS/CR"
        '
        'TxtTen_Cs
        '
        Me.TxtTen_Cs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cs.Enabled = False
        Me.TxtTen_Cs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cs.Location = New System.Drawing.Point(287, 74)
        Me.TxtTen_Cs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Cs.Name = "TxtTen_Cs"
        Me.TxtTen_Cs.ReadOnly = True
        Me.TxtTen_Cs.Size = New System.Drawing.Size(454, 17)
        Me.TxtTen_Cs.TabIndex = 1871
        Me.TxtTen_Cs.TabStop = False
        '
        'TxtMa_Cs
        '
        Me.TxtMa_Cs._ActilookupPopup = False
        Me.TxtMa_Cs.CyberActilookupPopup = True
        Me.TxtMa_Cs.Dv_ListDetail = Nothing
        Me.TxtMa_Cs.Dv_Master = Nothing
        Me.TxtMa_Cs.FilterClient = ""
        Me.TxtMa_Cs.FilterSQL = ""
        Me.TxtMa_Cs.Location = New System.Drawing.Point(119, 71)
        Me.TxtMa_Cs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Cs.Name = "TxtMa_Cs"
        Me.TxtMa_Cs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cs.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Cs.TabIndex = 2
        Me.TxtMa_Cs.Table_Name = ""
        '
        'ChkNgay_Goi
        '
        Me.ChkNgay_Goi.AutoSize = True
        Me.ChkNgay_Goi.ForeColor = System.Drawing.Color.Red
        Me.ChkNgay_Goi.Location = New System.Drawing.Point(432, 7)
        Me.ChkNgay_Goi.Name = "ChkNgay_Goi"
        Me.ChkNgay_Goi.Size = New System.Drawing.Size(146, 21)
        Me.ChkNgay_Goi.TabIndex = 5
        Me.ChkNgay_Goi.Text = "Xem theo ngày gọi"
        Me.ChkNgay_Goi.UseVisualStyleBackColor = True
        '
        'CRM_KQLH_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(827, 329)
        Me.Controls.Add(Me.ChkNgay_Goi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Cs)
        Me.Controls.Add(Me.TxtMa_Cs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Loai)
        Me.Controls.Add(Me.TxtMa_Loai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Ngay)
        Me.Controls.Add(Me.TxtMa_Ngay)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CRM_KQLH_Detail"
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
        Me.Controls.SetChildIndex(Me.TxtMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Ngay, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cs, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ChkNgay_Goi, 0)
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Loai As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Ngay As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ngay As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cs As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkNgay_Goi As CheckBox
End Class
