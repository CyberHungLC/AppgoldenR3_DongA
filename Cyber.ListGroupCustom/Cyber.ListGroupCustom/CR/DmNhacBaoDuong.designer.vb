<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmNhacBaoDuong
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
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx1 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx3 = New Cyber.SmLists.TxtLookup()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.TxtSo_Ngay = New ClsTextBox.txtTy_Gia()
        Me.TxtSo_KM = New ClsTextBox.txtTy_Gia()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.LabNgay_HL = New System.Windows.Forms.Label()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(422, 118)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(320, 118)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(220, 118)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 128)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 108)
        Me.GroupBoxLine.Size = New System.Drawing.Size(495, 10)
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(5, 4)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 15)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Dòng xe"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(226, 6)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(271, 14)
        Me.TxtTen_Nh1.TabIndex = 23
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
        Me.TxtNh_Kx1.Location = New System.Drawing.Point(110, 4)
        Me.TxtNh_Kx1.Name = "TxtNh_Kx1"
        Me.TxtNh_Kx1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNh_Kx1.TabIndex = 0
        Me.TxtNh_Kx1.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Loại xe"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(226, 28)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(271, 14)
        Me.TxtTen_Nh3.TabIndex = 26
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_Kx3
        '
        Me.TxtNh_Kx3._ActilookupPopup = False
        Me.TxtNh_Kx3.CyberActilookupPopup = True
        Me.TxtNh_Kx3.Dv_ListDetail = Nothing
        Me.TxtNh_Kx3.Dv_Master = Nothing
        Me.TxtNh_Kx3.FilterClient = ""
        Me.TxtNh_Kx3.FilterSQL = ""
        Me.TxtNh_Kx3.Location = New System.Drawing.Point(110, 26)
        Me.TxtNh_Kx3.Name = "TxtNh_Kx3"
        Me.TxtNh_Kx3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx3.Size = New System.Drawing.Size(110, 20)
        Me.TxtNh_Kx3.TabIndex = 1
        Me.TxtNh_Kx3.Table_Name = ""
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(5, 53)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(79, 17)
        Me.LabGia_nt2.TabIndex = 44
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Số ngày nhắc"
        '
        'TxtSo_Ngay
        '
        Me.TxtSo_Ngay.AllowNegative = True
        Me.TxtSo_Ngay.Flags = 7680
        Me.TxtSo_Ngay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay.InputMask = "### ### ###.##"
        Me.TxtSo_Ngay.Location = New System.Drawing.Point(110, 49)
        Me.TxtSo_Ngay.MaxWholeDigits = 11
        Me.TxtSo_Ngay.Name = "TxtSo_Ngay"
        Me.TxtSo_Ngay.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay.Size = New System.Drawing.Size(111, 21)
        Me.TxtSo_Ngay.TabIndex = 2
        Me.TxtSo_Ngay.Text = "1.00"
        Me.TxtSo_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_KM
        '
        Me.TxtSo_KM.AllowNegative = True
        Me.TxtSo_KM.Flags = 7680
        Me.TxtSo_KM.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_KM.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_KM.InputMask = "### ### ###.##"
        Me.TxtSo_KM.Location = New System.Drawing.Point(389, 49)
        Me.TxtSo_KM.MaxWholeDigits = 11
        Me.TxtSo_KM.Name = "TxtSo_KM"
        Me.TxtSo_KM.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_KM.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_KM.Size = New System.Drawing.Size(109, 21)
        Me.TxtSo_KM.TabIndex = 3
        Me.TxtSo_KM.Text = "1.00"
        Me.TxtSo_KM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(315, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 50
        Me.Label11.Tag = "Pretax price"
        Me.Label11.Text = "Số km nhắc"
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 74)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(111, 21)
        Me.TxtNgay_HL.TabIndex = 4
        Me.TxtNgay_HL.Text = "__/__/____"
        Me.TxtNgay_HL.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabNgay_HL
        '
        Me.LabNgay_HL.AutoSize = True
        Me.LabNgay_HL.Location = New System.Drawing.Point(5, 79)
        Me.LabNgay_HL.Name = "LabNgay_HL"
        Me.LabNgay_HL.Size = New System.Drawing.Size(72, 13)
        Me.LabNgay_HL.TabIndex = 52
        Me.LabNgay_HL.Tag = "Group 4"
        Me.LabNgay_HL.Text = "Ngày hiệu lực"
        '
        'DmNhacBaoDuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 151)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_HL)
        Me.Controls.Add(Me.TxtSo_KM)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtSo_Ngay)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_Kx3)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_Kx1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 162)
        Me.Name = "DmNhacBaoDuong"
        Me.Text = "Danh mục nhắc bảo dưỡng xe"
        Me.Controls.SetChildIndex(Me.TxtNh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_KM, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx3 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabGia_nt2 As Windows.Forms.Label
    Friend WithEvents TxtSo_Ngay As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtSo_KM As ClsTextBox.txtTy_Gia
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_HL As System.Windows.Forms.Label
End Class
