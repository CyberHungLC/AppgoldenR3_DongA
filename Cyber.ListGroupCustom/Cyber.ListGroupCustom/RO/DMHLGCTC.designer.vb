<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMHLGCTC
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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.TxtTen_Cv = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cv = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.TxtDon_Gia = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx1 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KX2 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KX2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(461, 155)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(359, 155)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(229, 167)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 164)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 145)
        Me.GroupBoxLine.Size = New System.Drawing.Size(560, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(5, 30)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(104, 16)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Công việc"
        '
        'TxtTen_Cv
        '
        Me.TxtTen_Cv.BackColor = System.Drawing.Color.White
        Me.TxtTen_Cv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cv.Enabled = False
        Me.TxtTen_Cv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cv.Location = New System.Drawing.Point(246, 33)
        Me.TxtTen_Cv.Name = "TxtTen_Cv"
        Me.TxtTen_Cv.ReadOnly = True
        Me.TxtTen_Cv.Size = New System.Drawing.Size(308, 14)
        Me.TxtTen_Cv.TabIndex = 382
        Me.TxtTen_Cv.TabStop = False
        '
        'TxtMa_Cv
        '
        Me.TxtMa_Cv._ActilookupPopup = False
        Me.TxtMa_Cv.CyberActilookupPopup = True
        Me.TxtMa_Cv.Dv_ListDetail = Nothing
        Me.TxtMa_Cv.Dv_Master = Nothing
        Me.TxtMa_Cv.FilterClient = ""
        Me.TxtMa_Cv.FilterSQL = ""
        Me.TxtMa_Cv.Location = New System.Drawing.Point(127, 30)
        Me.TxtMa_Cv.Name = "TxtMa_Cv"
        Me.TxtMa_Cv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cv.Size = New System.Drawing.Size(108, 20)
        Me.TxtMa_Cv.TabIndex = 1
        Me.TxtMa_Cv.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(5, 7)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 17)
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
        Me.TxtNgay_HL.Location = New System.Drawing.Point(127, 7)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(109, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtDon_Gia
        '
        Me.TxtDon_Gia.AllowNegative = True
        Me.TxtDon_Gia.Flags = 7680
        Me.TxtDon_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDon_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtDon_Gia.InputMask = "### ### ###"
        Me.TxtDon_Gia.Location = New System.Drawing.Point(127, 120)
        Me.TxtDon_Gia.MaxWholeDigits = 8
        Me.TxtDon_Gia.Name = "TxtDon_Gia"
        Me.TxtDon_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtDon_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtDon_Gia.Size = New System.Drawing.Size(109, 21)
        Me.TxtDon_Gia.TabIndex = 6
        Me.TxtDon_Gia.Text = "1"
        Me.TxtDon_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(5, 120)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Đơn giá"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(246, 56)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(308, 14)
        Me.TxtTen_Kx.TabIndex = 391
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(127, 53)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(108, 20)
        Me.TxtMa_Kx.TabIndex = 2
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 390
        Me.Label1.Tag = "Item code"
        Me.Label1.Text = "Kiểu xe"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(247, 79)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(308, 14)
        Me.TxtTen_Nh1.TabIndex = 394
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_Kx1
        '
        Me.TxtNh_Kx1._ActilookupPopup = False
        Me.TxtNh_Kx1.CyberActilookupPopup = True
        Me.TxtNh_Kx1.Dv_ListDetail = Nothing
        Me.TxtNh_Kx1.Dv_Master = Nothing
        Me.TxtNh_Kx1.FilterClient = ""
        Me.TxtNh_Kx1.FilterSQL = ""
        Me.TxtNh_Kx1.Location = New System.Drawing.Point(127, 76)
        Me.TxtNh_Kx1.Name = "TxtNh_Kx1"
        Me.TxtNh_Kx1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx1.Size = New System.Drawing.Size(108, 20)
        Me.TxtNh_Kx1.TabIndex = 3
        Me.TxtNh_Kx1.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 393
        Me.Label2.Tag = "Item code"
        Me.Label2.Text = "Nhóm kiểu xe 1"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(247, 100)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(308, 14)
        Me.TxtTen_Nh2.TabIndex = 397
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_KX2
        '
        Me.TxtNh_KX2._ActilookupPopup = False
        Me.TxtNh_KX2.CyberActilookupPopup = True
        Me.TxtNh_KX2.Dv_ListDetail = Nothing
        Me.TxtNh_KX2.Dv_Master = Nothing
        Me.TxtNh_KX2.FilterClient = ""
        Me.TxtNh_KX2.FilterSQL = ""
        Me.TxtNh_KX2.Location = New System.Drawing.Point(127, 97)
        Me.TxtNh_KX2.Name = "TxtNh_KX2"
        Me.TxtNh_KX2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KX2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KX2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KX2.Size = New System.Drawing.Size(108, 20)
        Me.TxtNh_KX2.TabIndex = 4
        Me.TxtNh_KX2.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 396
        Me.Label4.Tag = "Item code"
        Me.Label4.Text = "Nhóm kiểu xe 2"
        '
        'DMHLGCTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(563, 189)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_KX2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_Kx1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDon_Gia)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_Cv)
        Me.Controls.Add(Me.TxtMa_Cv)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMHLGCTC"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cv, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtDon_Gia, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KX2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KX2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cv As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents TxtDon_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx1 As SmLists.TxtLookup
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As Windows.Forms.TextBox
    Friend WithEvents TxtNh_KX2 As SmLists.TxtLookup
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
