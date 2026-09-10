<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmThTT
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
        Me.LabMa_KH = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.TxtNgay_Chot = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(819, 149)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(683, 149)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(442, 162)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(143, 24)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(159, 161)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 136)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(950, 12)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_KH
        '
        Me.LabMa_KH.Location = New System.Drawing.Point(2, 13)
        Me.LabMa_KH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_KH.Name = "LabMa_KH"
        Me.LabMa_KH.Size = New System.Drawing.Size(133, 21)
        Me.LabMa_KH.TabIndex = 23
        Me.LabMa_KH.Tag = "Customer code"
        Me.LabMa_KH.Text = "Mã khách hàng"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(369, 11)
        Me.TxtTen_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_KH.TabIndex = 388
        Me.TxtTen_KH.TabStop = False
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(165, 8)
        Me.TxtMa_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(197, 22)
        Me.TxtMa_KH.TabIndex = 0
        Me.TxtMa_KH.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(3, 44)
        Me.LabNgay_ban.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(133, 22)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.IsAllowResize = False
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(165, 39)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_HL.TabIndex = 1
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtNgay_Chot
        '
        Me.TxtNgay_Chot.AllowNegative = True
        Me.TxtNgay_Chot.Flags = 7680
        Me.TxtNgay_Chot.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Chot.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Chot.InputMask = "### ### ###"
        Me.TxtNgay_Chot.Location = New System.Drawing.Point(165, 70)
        Me.TxtNgay_Chot.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_Chot.MaxWholeDigits = 8
        Me.TxtNgay_Chot.Name = "TxtNgay_Chot"
        Me.TxtNgay_Chot.RangeMax = 1.7976931348623157E+308R
        Me.TxtNgay_Chot.RangeMin = -1.7976931348623157E+308R
        Me.TxtNgay_Chot.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_Chot.TabIndex = 2
        Me.TxtNgay_Chot.Text = "1"
        Me.TxtNgay_Chot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(4, 74)
        Me.LabGia_nt2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(161, 22)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Hạn chốt"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 21)
        Me.Label6.TabIndex = 389
        Me.Label6.Tag = "English name"
        Me.Label6.Text = "Ghi chú"
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(165, 103)
        Me.TxtGhi_Chu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(777, 24)
        Me.TxtGhi_Chu.TabIndex = 3
        '
        'DmThTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(955, 193)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNgay_Chot)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Controls.Add(Me.LabMa_KH)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(646, 222)
        Me.Name = "DmThTT"
        Me.Controls.SetChildIndex(Me.LabMa_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Chot, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_KH As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Chot As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtGhi_Chu As Windows.Forms.TextBox
End Class
