<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doi_TVBH
    Inherits Cyber.From.FrmCalculator

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
        Me.lblMa = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.Label()
        Me.NVKD = New System.Windows.Forms.Label()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate1()
        Me.TxtTen_HsKd = New System.Windows.Forms.Label()
        Me.TxtTen_Hd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_HsKd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSo_HD = New System.Windows.Forms.TextBox()
        Me.ChkHD_AO = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 151)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(923, 8)
        Me.GroupBoxLine.TabIndex = 22
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(723, 161)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 14
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(825, 161)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 15
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblMa.Location = New System.Drawing.Point(9, 16)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(69, 13)
        Me.lblMa.TabIndex = 554
        Me.lblMa.Tag = "New processor"
        Me.lblMa.Text = "Mã hợp đồng"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = Nothing
        Me.TxtMa_HD.FilterSQL = Nothing
        Me.TxtMa_HD.Location = New System.Drawing.Point(94, 12)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HD.TabIndex = 0
        Me.TxtMa_HD.Table_Name = Nothing
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Hs.Location = New System.Drawing.Point(215, 116)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.Size = New System.Drawing.Size(731, 14)
        Me.TxtTen_Hs.TabIndex = 558
        Me.TxtTen_Hs.Tag = "Group 4"
        '
        'NVKD
        '
        Me.NVKD.AutoSize = True
        Me.NVKD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.NVKD.Location = New System.Drawing.Point(12, 113)
        Me.NVKD.Name = "NVKD"
        Me.NVKD.Size = New System.Drawing.Size(51, 13)
        Me.NVKD.TabIndex = 557
        Me.NVKD.Tag = "New processor"
        Me.NVKD.Text = "TVBH mới"
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = Nothing
        Me.TxtMa_HS.FilterSQL = Nothing
        Me.TxtMa_HS.Location = New System.Drawing.Point(93, 110)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HS.TabIndex = 4
        Me.TxtMa_HS.Table_Name = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(9, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 559
        Me.Label3.Tag = "New processor"
        Me.Label3.Text = "TVBH hiện thời"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 561
        Me.Label5.Tag = "New processor"
        Me.Label5.Text = "Ngày "
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Flags = 0
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.IsAllowResize = False
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(94, 35)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(116, 20)
        Me.TxtNgay_Ct.TabIndex = 1
        Me.TxtNgay_Ct.Text = "__/__/____"
        Me.TxtNgay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtTen_HsKd
        '
        Me.TxtTen_HsKd.BackColor = System.Drawing.Color.White
        Me.TxtTen_HsKd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_HsKd.Location = New System.Drawing.Point(215, 87)
        Me.TxtTen_HsKd.Name = "TxtTen_HsKd"
        Me.TxtTen_HsKd.Size = New System.Drawing.Size(731, 14)
        Me.TxtTen_HsKd.TabIndex = 570
        Me.TxtTen_HsKd.Tag = "Group 4"
        '
        'TxtTen_Hd
        '
        Me.TxtTen_Hd.Location = New System.Drawing.Point(94, 58)
        Me.TxtTen_Hd.Name = "TxtTen_Hd"
        Me.TxtTen_Hd.ReadOnly = True
        Me.TxtTen_Hd.Size = New System.Drawing.Size(830, 20)
        Me.TxtTen_Hd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 572
        Me.Label1.Tag = "New processor"
        Me.Label1.Text = "Địa điểm"
        '
        'TxtMa_HsKd
        '
        Me.TxtMa_HsKd.Location = New System.Drawing.Point(94, 84)
        Me.TxtMa_HsKd.Name = "TxtMa_HsKd"
        Me.TxtMa_HsKd.ReadOnly = True
        Me.TxtMa_HsKd.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HsKd.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(216, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 574
        Me.Label2.Tag = "New processor"
        Me.Label2.Text = "Số HĐ"
        '
        'TxtSo_HD
        '
        Me.TxtSo_HD.Location = New System.Drawing.Point(268, 13)
        Me.TxtSo_HD.Name = "TxtSo_HD"
        Me.TxtSo_HD.ReadOnly = True
        Me.TxtSo_HD.Size = New System.Drawing.Size(241, 20)
        Me.TxtSo_HD.TabIndex = 573
        '
        'ChkHD_AO
        '
        Me.ChkHD_AO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHD_AO.AutoSize = True
        Me.ChkHD_AO.BackColor = System.Drawing.Color.Transparent
        Me.ChkHD_AO.ForeColor = System.Drawing.Color.Blue
        Me.ChkHD_AO.Location = New System.Drawing.Point(93, 136)
        Me.ChkHD_AO.Name = "ChkHD_AO"
        Me.ChkHD_AO.Size = New System.Drawing.Size(108, 17)
        Me.ChkHD_AO.TabIndex = 2151
        Me.ChkHD_AO.Text = "Lập hợp đồng ảo"
        Me.ChkHD_AO.UseVisualStyleBackColor = False
        '
        'Doi_TVBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(927, 215)
        Me.Controls.Add(Me.ChkHD_AO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSo_HD)
        Me.Controls.Add(Me.TxtMa_HsKd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Hd)
        Me.Controls.Add(Me.TxtTen_HsKd)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.NVKD)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Doi_TVBH"
        Me.Text = "Đổi tư vấn bán hàng"
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.lblMa, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.NVKD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HsKd, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hd, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HsKd, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HD, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ChkHD_AO, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMa As Windows.Forms.Label
    Friend WithEvents TxtMa_HD As SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As Windows.Forms.Label
    Friend WithEvents NVKD As Windows.Forms.Label
    Friend WithEvents TxtMa_HS As SmLists.TxtLookup
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate1
    Friend WithEvents TxtTen_HsKd As Windows.Forms.Label
    Friend WithEvents TxtTen_Hd As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_HsKd As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtSo_HD As Windows.Forms.TextBox
    Friend WithEvents ChkHD_AO As System.Windows.Forms.CheckBox
End Class
