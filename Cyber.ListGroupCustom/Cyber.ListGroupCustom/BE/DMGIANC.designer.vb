<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMGIANC
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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.TxtTen_Pk = New System.Windows.Forms.TextBox()
        Me.TxtMa_PK = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_ban = New ClsTextBox.txtDate1()
        Me.TxtGia_nt2 = New ClsTextBox.txtTy_Gia()
        Me.Txtgia_NC = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.Labgia2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(693, 110)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(591, 110)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(401, 199)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 119)
        Me.ChkActi.TabIndex = 15
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 100)
        Me.GroupBoxLine.Size = New System.Drawing.Size(791, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(7, 15)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(104, 16)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Mã phụ kiện"
        '
        'TxtTen_Pk
        '
        Me.TxtTen_Pk.BackColor = System.Drawing.Color.White
        Me.TxtTen_Pk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Pk.Enabled = False
        Me.TxtTen_Pk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Pk.Location = New System.Drawing.Point(282, 15)
        Me.TxtTen_Pk.Name = "TxtTen_Pk"
        Me.TxtTen_Pk.ReadOnly = True
        Me.TxtTen_Pk.Size = New System.Drawing.Size(512, 14)
        Me.TxtTen_Pk.TabIndex = 382
        Me.TxtTen_Pk.TabStop = False
        '
        'TxtMa_PK
        '
        Me.TxtMa_PK._ActilookupPopup = False
        Me.TxtMa_PK.CyberActilookupPopup = True
        Me.TxtMa_PK.Dv_ListDetail = Nothing
        Me.TxtMa_PK.Dv_Master = Nothing
        Me.TxtMa_PK.FilterClient = ""
        Me.TxtMa_PK.FilterSQL = ""
        Me.TxtMa_PK.Location = New System.Drawing.Point(128, 12)
        Me.TxtMa_PK.Name = "TxtMa_PK"
        Me.TxtMa_PK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_PK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_PK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_PK.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_PK.TabIndex = 0
        Me.TxtMa_PK.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(7, 43)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 17)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_ban
        '
        Me.TxtNgay_ban.Flags = 65536
        Me.TxtNgay_ban.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ban.IsAllowResize = False
        Me.TxtNgay_ban.isEmpty = True
        Me.TxtNgay_ban.Location = New System.Drawing.Point(128, 39)
        Me.TxtNgay_ban.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ban.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_ban.MaxLength = 10
        Me.TxtNgay_ban.Name = "TxtNgay_ban"
        Me.TxtNgay_ban.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_ban.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_ban.ShowDayBeforeMonth = False
        Me.TxtNgay_ban.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_ban.TabIndex = 9
        Me.TxtNgay_ban.Text = "07/09/2011"
        Me.TxtNgay_ban.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtGia_nt2
        '
        Me.TxtGia_nt2.AllowNegative = True
        Me.TxtGia_nt2.Flags = 7680
        Me.TxtGia_nt2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt2.InputMask = "### ### ### ###"
        Me.TxtGia_nt2.Location = New System.Drawing.Point(128, 62)
        Me.TxtGia_nt2.MaxWholeDigits = 11
        Me.TxtGia_nt2.Name = "TxtGia_nt2"
        Me.TxtGia_nt2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt2.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt2.TabIndex = 10
        Me.TxtGia_nt2.Text = "1"
        Me.TxtGia_nt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtgia_NC
        '
        Me.Txtgia_NC.AllowNegative = True
        Me.Txtgia_NC.Flags = 7680
        Me.Txtgia_NC.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtgia_NC.ForeColor = System.Drawing.Color.Navy
        Me.Txtgia_NC.InputMask = "### ### ### ###"
        Me.Txtgia_NC.Location = New System.Drawing.Point(514, 62)
        Me.Txtgia_NC.MaxWholeDigits = 11
        Me.Txtgia_NC.Name = "Txtgia_NC"
        Me.Txtgia_NC.RangeMax = 1.7976931348623157E+308R
        Me.Txtgia_NC.RangeMin = -1.7976931348623157E+308R
        Me.Txtgia_NC.Size = New System.Drawing.Size(149, 21)
        Me.Txtgia_NC.TabIndex = 11
        Me.Txtgia_NC.Text = "1"
        Me.Txtgia_NC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(6, 65)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Giá phụ kiện"
        '
        'Labgia2
        '
        Me.Labgia2.Location = New System.Drawing.Point(382, 65)
        Me.Labgia2.Name = "Labgia2"
        Me.Labgia2.Size = New System.Drawing.Size(110, 17)
        Me.Labgia2.TabIndex = 412
        Me.Labgia2.Tag = "Pretax price VND"
        Me.Labgia2.Text = "Giá nhân công"
        '
        'DMGIANC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(795, 143)
        Me.Controls.Add(Me.Labgia2)
        Me.Controls.Add(Me.Txtgia_NC)
        Me.Controls.Add(Me.TxtGia_nt2)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_ban)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_Pk)
        Me.Controls.Add(Me.TxtMa_PK)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMGIANC"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_PK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Pk, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.Txtgia_NC, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labgia2, 0)
        CType(Me.TxtMa_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Pk As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_PK As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_ban As ClsTextBox.txtDate1
    Friend WithEvents TxtGia_nt2 As ClsTextBox.txtTy_Gia
    Friend WithEvents Txtgia_NC As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents Labgia2 As System.Windows.Forms.Label

End Class
