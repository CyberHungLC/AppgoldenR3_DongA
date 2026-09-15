<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ROBH_BC02
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
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTCP = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(431, 136)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 101)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(420, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 104)
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(327, 136)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 145)
        Me.LabLoai_NT.Size = New System.Drawing.Size(62, 13)
        Me.LabLoai_NT.TabIndex = 12
        Me.LabLoai_NT.Visible = False
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(118, 143)
        Me.ChkVND.Visible = False
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(232, 143)
        Me.ChkNT.TabIndex = 17
        Me.ChkNT.Visible = False
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 3)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(415, 3)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 8
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(323, 7)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 119)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(528, 9)
        Me.GroupBoxLine.TabIndex = 18
        Me.GroupBoxLine.TabStop = False
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(15, 53)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(86, 15)
        Me.LabSo_Ct1.TabIndex = 10
        Me.LabSo_Ct1.Tag = "Voucher from"
        Me.LabSo_Ct1.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(107, 50)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 3
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(226, 31)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(303, 14)
        Me.TxtTen_BH.TabIndex = 20
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
        Me.TxtMa_BH.Location = New System.Drawing.Point(107, 28)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_BH.TabIndex = 2
        Me.TxtMa_BH.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Tag = "Voucher from"
        Me.Label3.Text = "Đơn vị bảo hiểm"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(415, 50)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(114, 21)
        Me.TxtSo_Ro.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(326, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Tag = "Voucher from"
        Me.Label2.Text = "Số R/O"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 548
        Me.Label18.Tag = "Staff"
        Me.Label18.Text = "Xưởng"
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Enabled = False
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(235, 75)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(296, 14)
        Me.TxtTen_TTCP.TabIndex = 547
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
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(107, 72)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_TTCP.TabIndex = 5
        Me.TxtMa_TTCP.Table_Name = ""
        '
        'ROBH_BC02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(535, 189)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "ROBH_BC02"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_BH As TextBox
    Friend WithEvents TxtMa_BH As SmLists.TxtLookup
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSo_Ro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTen_TTCP As TextBox
    Friend WithEvents TxtMa_TTCP As SmLists.TxtLookup
End Class
