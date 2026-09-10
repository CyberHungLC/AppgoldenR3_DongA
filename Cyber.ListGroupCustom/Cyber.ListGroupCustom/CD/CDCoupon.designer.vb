<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDCoupon
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtGia_Tri = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Luong = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Seri = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.Txtten_DVCS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Coupon = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Coupon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Coupon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(607, 145)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(505, 145)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(104, 25)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(104, 155)
        Me.ChkActi.TabIndex = 5
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 135)
        Me.GroupBoxLine.Size = New System.Drawing.Size(705, 9)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(5, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 17)
        Me.Label10.TabIndex = 270
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(104, 2)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 250
        Me.TxtNam.TabStop = False
        '
        'TxtGia_Tri
        '
        Me.TxtGia_Tri.AllowNegative = True
        Me.TxtGia_Tri.Flags = 7680
        Me.TxtGia_Tri.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGia_Tri.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri.InputMask = "### ### ### ### ###"
        Me.TxtGia_Tri.Location = New System.Drawing.Point(104, 115)
        Me.TxtGia_Tri.MaxWholeDigits = 14
        Me.TxtGia_Tri.Name = "TxtGia_Tri"
        Me.TxtGia_Tri.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri.Size = New System.Drawing.Size(135, 21)
        Me.TxtGia_Tri.TabIndex = 4
        Me.TxtGia_Tri.Tag = "### ### ### ### ###.##"
        Me.TxtGia_Tri.Text = "0"
        Me.TxtGia_Tri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Luong
        '
        Me.TxtSo_Luong.AllowNegative = True
        Me.TxtSo_Luong.Flags = 7680
        Me.TxtSo_Luong.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Luong.InputMask = "### ### ### ### ###"
        Me.TxtSo_Luong.Location = New System.Drawing.Point(104, 92)
        Me.TxtSo_Luong.MaxWholeDigits = 14
        Me.TxtSo_Luong.Name = "TxtSo_Luong"
        Me.TxtSo_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Luong.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_Luong.TabIndex = 3
        Me.TxtSo_Luong.Text = "0"
        Me.TxtSo_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Seri
        '
        Me.TxtSo_Seri.AllowNegative = True
        Me.TxtSo_Seri.Flags = 7680
        Me.TxtSo_Seri.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Seri.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Seri.InputMask = "### ### ### ### ###"
        Me.TxtSo_Seri.Location = New System.Drawing.Point(104, 69)
        Me.TxtSo_Seri.MaxWholeDigits = 14
        Me.TxtSo_Seri.Name = "TxtSo_Seri"
        Me.TxtSo_Seri.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Seri.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Seri.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_Seri.TabIndex = 2
        Me.TxtSo_Seri.Text = "0"
        Me.TxtSo_Seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 264
        Me.Label2.Tag = "Open credit balance(VND)"
        Me.Label2.Text = "Số lượng"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Open debt balance(FC)"
        Me.Label3.Text = "Giá trị"
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbTen_phi2.ForeColor = System.Drawing.Color.Navy
        Me.lbTen_phi2.Location = New System.Drawing.Point(5, 71)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(91, 17)
        Me.lbTen_phi2.TabIndex = 261
        Me.lbTen_phi2.Tag = "Open debt balance(VND)"
        Me.lbTen_phi2.Text = "Số seri"
        '
        'Txtten_DVCS
        '
        Me.Txtten_DVCS.BackColor = System.Drawing.Color.White
        Me.Txtten_DVCS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_DVCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtten_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_DVCS.Location = New System.Drawing.Point(247, 28)
        Me.Txtten_DVCS.Name = "Txtten_DVCS"
        Me.Txtten_DVCS.ReadOnly = True
        Me.Txtten_DVCS.Size = New System.Drawing.Size(460, 14)
        Me.Txtten_DVCS.TabIndex = 271
        Me.Txtten_DVCS.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(5, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 272
        Me.Label11.Tag = "Acc unit"
        Me.Label11.Text = "Đơn vị hạch toán"
        '
        'TxtMa_Coupon
        '
        Me.TxtMa_Coupon._ActilookupPopup = False
        Me.TxtMa_Coupon.CyberActilookupPopup = True
        Me.TxtMa_Coupon.Dv_ListDetail = Nothing
        Me.TxtMa_Coupon.Dv_Master = Nothing
        Me.TxtMa_Coupon.FilterClient = ""
        Me.TxtMa_Coupon.FilterSQL = ""
        Me.TxtMa_Coupon.Location = New System.Drawing.Point(104, 47)
        Me.TxtMa_Coupon.Name = "TxtMa_Coupon"
        Me.TxtMa_Coupon.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Coupon.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Coupon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Coupon.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_Coupon.TabIndex = 1
        Me.TxtMa_Coupon.Table_Name = ""
        '
        'TxtTen_Coupon
        '
        Me.TxtTen_Coupon.BackColor = System.Drawing.Color.White
        Me.TxtTen_Coupon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Coupon.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Coupon.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Coupon.Location = New System.Drawing.Point(247, 50)
        Me.TxtTen_Coupon.Name = "TxtTen_Coupon"
        Me.TxtTen_Coupon.ReadOnly = True
        Me.TxtTen_Coupon.Size = New System.Drawing.Size(460, 14)
        Me.TxtTen_Coupon.TabIndex = 279
        Me.TxtTen_Coupon.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(5, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 280
        Me.Label9.Tag = "Department"
        Me.Label9.Text = "Mã voucher"
        '
        'CDCoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(709, 178)
        Me.Controls.Add(Me.TxtMa_Coupon)
        Me.Controls.Add(Me.TxtTen_Coupon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtGia_Tri)
        Me.Controls.Add(Me.TxtSo_Luong)
        Me.Controls.Add(Me.TxtSo_Seri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CDCoupon"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ voucher"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Seri, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Coupon, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Coupon, 0)
        CType(Me.TxtMa_Coupon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtGia_Tri As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Luong As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Seri As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label
    Friend WithEvents Txtten_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Coupon As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Coupon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
