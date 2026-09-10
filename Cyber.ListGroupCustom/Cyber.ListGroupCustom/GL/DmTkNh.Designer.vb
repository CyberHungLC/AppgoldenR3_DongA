<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMTKNH
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
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.TxtE_Mail = New System.Windows.Forms.TextBox()
        Me.Labemail = New System.Windows.Forms.Label()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.LabFax = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.LabDien_thoai = New System.Windows.Forms.Label()
        Me.TxtTinh_Thanh = New System.Windows.Forms.TextBox()
        Me.Labtinh_thanh = New System.Windows.Forms.Label()
        Me.TxtMa_So_Thue = New System.Windows.Forms.TextBox()
        Me.Labma_so_thue = New System.Windows.Forms.Label()
        Me.TxtTen_Tk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabTk0 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.Labten_nh2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh = New System.Windows.Forms.TextBox()
        Me.LabTen_nh = New System.Windows.Forms.Label()
        Me.TxtTk_Nh = New System.Windows.Forms.TextBox()
        Me.Labtk_nh = New System.Windows.Forms.Label()
        Me.TxtChu_Tk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 193)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 193)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 199)
        Me.TxtMa_Dvcs.TabIndex = 13
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 203)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 183)
        Me.GroupBoxLine.Size = New System.Drawing.Size(780, 8)
        Me.GroupBoxLine.TabIndex = 13
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(109, 8)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.AutoHeight = False
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(149, 22)
        Me.TxtTk.TabIndex = 0
        Me.TxtTk.Table_Name = ""
        '
        'TxtE_Mail
        '
        Me.TxtE_Mail.ForeColor = System.Drawing.Color.Navy
        Me.TxtE_Mail.Location = New System.Drawing.Point(109, 162)
        Me.TxtE_Mail.Name = "TxtE_Mail"
        Me.TxtE_Mail.Size = New System.Drawing.Size(672, 21)
        Me.TxtE_Mail.TabIndex = 9
        '
        'Labemail
        '
        Me.Labemail.Location = New System.Drawing.Point(6, 166)
        Me.Labemail.Name = "Labemail"
        Me.Labemail.Size = New System.Drawing.Size(81, 17)
        Me.Labemail.TabIndex = 94
        Me.Labemail.Tag = "Email"
        Me.Labemail.Text = "Email"
        '
        'TxtFax
        '
        Me.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFax.ForeColor = System.Drawing.Color.Navy
        Me.TxtFax.Location = New System.Drawing.Point(481, 139)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(300, 21)
        Me.TxtFax.TabIndex = 8
        '
        'LabFax
        '
        Me.LabFax.Location = New System.Drawing.Point(406, 143)
        Me.LabFax.Name = "LabFax"
        Me.LabFax.Size = New System.Drawing.Size(74, 15)
        Me.LabFax.TabIndex = 93
        Me.LabFax.Tag = "Fax"
        Me.LabFax.Text = "Fax"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDien_Thoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(109, 139)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(149, 21)
        Me.TxtDien_Thoai.TabIndex = 7
        '
        'LabDien_thoai
        '
        Me.LabDien_thoai.Location = New System.Drawing.Point(6, 143)
        Me.LabDien_thoai.Name = "LabDien_thoai"
        Me.LabDien_thoai.Size = New System.Drawing.Size(100, 17)
        Me.LabDien_thoai.TabIndex = 92
        Me.LabDien_thoai.Tag = "Tel"
        Me.LabDien_thoai.Text = "Điện thoại"
        '
        'TxtTinh_Thanh
        '
        Me.TxtTinh_Thanh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTinh_Thanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTinh_Thanh.Location = New System.Drawing.Point(481, 117)
        Me.TxtTinh_Thanh.Name = "TxtTinh_Thanh"
        Me.TxtTinh_Thanh.Size = New System.Drawing.Size(300, 21)
        Me.TxtTinh_Thanh.TabIndex = 6
        '
        'Labtinh_thanh
        '
        Me.Labtinh_thanh.Location = New System.Drawing.Point(404, 121)
        Me.Labtinh_thanh.Name = "Labtinh_thanh"
        Me.Labtinh_thanh.Size = New System.Drawing.Size(74, 15)
        Me.Labtinh_thanh.TabIndex = 91
        Me.Labtinh_thanh.Tag = "Address"
        Me.Labtinh_thanh.Text = "Địa chỉ"
        '
        'TxtMa_So_Thue
        '
        Me.TxtMa_So_Thue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_So_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_So_Thue.Location = New System.Drawing.Point(109, 117)
        Me.TxtMa_So_Thue.Name = "TxtMa_So_Thue"
        Me.TxtMa_So_Thue.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_So_Thue.TabIndex = 5
        '
        'Labma_so_thue
        '
        Me.Labma_so_thue.Location = New System.Drawing.Point(6, 121)
        Me.Labma_so_thue.Name = "Labma_so_thue"
        Me.Labma_so_thue.Size = New System.Drawing.Size(97, 17)
        Me.Labma_so_thue.TabIndex = 90
        Me.Labma_so_thue.Tag = "Tax code"
        Me.Labma_so_thue.Text = "Mã số thuế"
        '
        'TxtTen_Tk
        '
        Me.TxtTen_Tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk.Enabled = False
        Me.TxtTen_Tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk.Location = New System.Drawing.Point(261, 12)
        Me.TxtTen_Tk.Name = "TxtTen_Tk"
        Me.TxtTen_Tk.ReadOnly = True
        Me.TxtTen_Tk.Size = New System.Drawing.Size(520, 14)
        Me.TxtTen_Tk.TabIndex = 89
        Me.TxtTen_Tk.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Tag = "The bank"
        Me.Label1.Text = "Phần ngân hàng"
        '
        'LabTk0
        '
        Me.LabTk0.Location = New System.Drawing.Point(6, 11)
        Me.LabTk0.Name = "LabTk0"
        Me.LabTk0.Size = New System.Drawing.Size(101, 17)
        Me.LabTk0.TabIndex = 87
        Me.LabTk0.Tag = "Account"
        Me.LabTk0.Text = "TK kế toán"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(109, 94)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Nh2.TabIndex = 4
        '
        'Labten_nh2
        '
        Me.Labten_nh2.Location = New System.Drawing.Point(6, 98)
        Me.Labten_nh2.Name = "Labten_nh2"
        Me.Labten_nh2.Size = New System.Drawing.Size(100, 17)
        Me.Labten_nh2.TabIndex = 86
        Me.Labten_nh2.Tag = "English name"
        Me.Labten_nh2.Text = "Tên tiếng anh"
        '
        'TxtTen_Nh
        '
        Me.TxtTen_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh.Location = New System.Drawing.Point(109, 72)
        Me.TxtTen_Nh.Name = "TxtTen_Nh"
        Me.TxtTen_Nh.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Nh.TabIndex = 3
        '
        'LabTen_nh
        '
        Me.LabTen_nh.Location = New System.Drawing.Point(6, 76)
        Me.LabTen_nh.Name = "LabTen_nh"
        Me.LabTen_nh.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_nh.TabIndex = 85
        Me.LabTen_nh.Tag = "Bank"
        Me.LabTen_nh.Text = "Tên ngân hàng"
        '
        'TxtTk_Nh
        '
        Me.TxtTk_Nh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTk_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Nh.Location = New System.Drawing.Point(109, 49)
        Me.TxtTk_Nh.Name = "TxtTk_Nh"
        Me.TxtTk_Nh.Size = New System.Drawing.Size(149, 21)
        Me.TxtTk_Nh.TabIndex = 1
        '
        'Labtk_nh
        '
        Me.Labtk_nh.Location = New System.Drawing.Point(6, 53)
        Me.Labtk_nh.Name = "Labtk_nh"
        Me.Labtk_nh.Size = New System.Drawing.Size(100, 17)
        Me.Labtk_nh.TabIndex = 84
        Me.Labtk_nh.Tag = "Bank Acc"
        Me.Labtk_nh.Text = "Số tài khoản"
        '
        'TxtChu_Tk
        '
        Me.TxtChu_Tk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtChu_Tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtChu_Tk.Location = New System.Drawing.Point(358, 49)
        Me.TxtChu_Tk.Name = "TxtChu_Tk"
        Me.TxtChu_Tk.Size = New System.Drawing.Size(424, 21)
        Me.TxtChu_Tk.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(273, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 96
        Me.Label2.Tag = "Bank Acc"
        Me.Label2.Text = "Chủ tài khoản"
        '
        'DMTKNH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 226)
        Me.Controls.Add(Me.TxtChu_Tk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.TxtE_Mail)
        Me.Controls.Add(Me.Labemail)
        Me.Controls.Add(Me.TxtFax)
        Me.Controls.Add(Me.LabFax)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.LabDien_thoai)
        Me.Controls.Add(Me.TxtTinh_Thanh)
        Me.Controls.Add(Me.Labtinh_thanh)
        Me.Controls.Add(Me.TxtMa_So_Thue)
        Me.Controls.Add(Me.Labma_so_thue)
        Me.Controls.Add(Me.TxtTen_Tk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabTk0)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.Labten_nh2)
        Me.Controls.Add(Me.TxtTen_Nh)
        Me.Controls.Add(Me.LabTen_nh)
        Me.Controls.Add(Me.TxtTk_Nh)
        Me.Controls.Add(Me.Labtk_nh)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMTKNH"
        Me.Text = "Danh mục tài khoản ngân hàng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labtk_nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Nh, 0)
        Me.Controls.SetChildIndex(Me.LabTen_nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh, 0)
        Me.Controls.SetChildIndex(Me.Labten_nh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.LabTk0, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk, 0)
        Me.Controls.SetChildIndex(Me.Labma_so_thue, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_So_Thue, 0)
        Me.Controls.SetChildIndex(Me.Labtinh_thanh, 0)
        Me.Controls.SetChildIndex(Me.TxtTinh_Thanh, 0)
        Me.Controls.SetChildIndex(Me.LabDien_thoai, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.LabFax, 0)
        Me.Controls.SetChildIndex(Me.TxtFax, 0)
        Me.Controls.SetChildIndex(Me.Labemail, 0)
        Me.Controls.SetChildIndex(Me.TxtE_Mail, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtChu_Tk, 0)
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtE_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Labemail As System.Windows.Forms.Label
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents LabFax As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_thoai As System.Windows.Forms.Label
    Friend WithEvents TxtTinh_Thanh As System.Windows.Forms.TextBox
    Friend WithEvents Labtinh_thanh As System.Windows.Forms.Label
    Friend WithEvents TxtMa_So_Thue As System.Windows.Forms.TextBox
    Friend WithEvents Labma_so_thue As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Tk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabTk0 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_nh2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_nh As System.Windows.Forms.Label
    Friend WithEvents TxtTk_Nh As System.Windows.Forms.TextBox
    Friend WithEvents Labtk_nh As System.Windows.Forms.Label
    Friend WithEvents TxtChu_Tk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
