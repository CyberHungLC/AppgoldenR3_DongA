<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmNhTraGop
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
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtMa_NH = New System.Windows.Forms.TextBox()
        Me.TxtTen_NH = New System.Windows.Forms.TextBox()
        Me.LabTen_kho = New System.Windows.Forms.Label()
        Me.TxtTen_NH2 = New System.Windows.Forms.TextBox()
        Me.Labten_Kho2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtE_mail = New System.Windows.Forms.TextBox()
        Me.TxtHome_page = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDoi_tac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_So_thue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtGhi_chu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTinh_thanh = New System.Windows.Forms.TextBox()
        Me.LabMa_Tinh = New System.Windows.Forms.Label()
        Me.Chkis_Tfs = New System.Windows.Forms.CheckBox()
        Me.LabMa_Kh = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 239)
        Me.ButtExit.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 239)
        Me.ButtOK.TabIndex = 14
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 245)
        Me.TxtMa_Dvcs.TabIndex = 13
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 249)
        Me.ChkActi.TabIndex = 12
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 229)
        '
        'LabMa_kho
        '
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(4, 7)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(75, 13)
        Me.LabMa_kho.TabIndex = 10
        Me.LabMa_kho.Tag = "Code"
        Me.LabMa_kho.Text = "Mã ngân hàng"
        '
        'TxtMa_NH
        '
        Me.TxtMa_NH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NH.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NH.Location = New System.Drawing.Point(105, 3)
        Me.TxtMa_NH.Name = "TxtMa_NH"
        Me.TxtMa_NH.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_NH.TabIndex = 0
        '
        'TxtTen_NH
        '
        Me.TxtTen_NH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NH.Location = New System.Drawing.Point(105, 26)
        Me.TxtTen_NH.Name = "TxtTen_NH"
        Me.TxtTen_NH.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_NH.TabIndex = 1
        '
        'LabTen_kho
        '
        Me.LabTen_kho.AutoSize = True
        Me.LabTen_kho.Location = New System.Drawing.Point(4, 30)
        Me.LabTen_kho.Name = "LabTen_kho"
        Me.LabTen_kho.Size = New System.Drawing.Size(79, 13)
        Me.LabTen_kho.TabIndex = 12
        Me.LabTen_kho.Tag = "Name"
        Me.LabTen_kho.Text = "Tên ngân hàng"
        '
        'TxtTen_NH2
        '
        Me.TxtTen_NH2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NH2.Location = New System.Drawing.Point(105, 49)
        Me.TxtTen_NH2.Name = "TxtTen_NH2"
        Me.TxtTen_NH2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_NH2.TabIndex = 2
        '
        'Labten_Kho2
        '
        Me.Labten_Kho2.AutoSize = True
        Me.Labten_Kho2.Location = New System.Drawing.Point(4, 53)
        Me.Labten_Kho2.Name = "Labten_Kho2"
        Me.Labten_Kho2.Size = New System.Drawing.Size(73, 13)
        Me.Labten_Kho2.TabIndex = 14
        Me.Labten_Kho2.Tag = "English name"
        Me.Labten_Kho2.Text = "Tên tiếng anh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Tag = "Account"
        Me.Label2.Text = "Điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Fax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Email"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(105, 95)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(149, 21)
        Me.TxtDien_Thoai.TabIndex = 4
        '
        'TxtFax
        '
        Me.TxtFax.ForeColor = System.Drawing.Color.Navy
        Me.TxtFax.Location = New System.Drawing.Point(105, 118)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(149, 21)
        Me.TxtFax.TabIndex = 5
        '
        'TxtE_mail
        '
        Me.TxtE_mail.ForeColor = System.Drawing.Color.Navy
        Me.TxtE_mail.Location = New System.Drawing.Point(347, 118)
        Me.TxtE_mail.Name = "TxtE_mail"
        Me.TxtE_mail.Size = New System.Drawing.Size(160, 21)
        Me.TxtE_mail.TabIndex = 6
        '
        'TxtHome_page
        '
        Me.TxtHome_page.ForeColor = System.Drawing.Color.Navy
        Me.TxtHome_page.Location = New System.Drawing.Point(617, 118)
        Me.TxtHome_page.Name = "TxtHome_page"
        Me.TxtHome_page.Size = New System.Drawing.Size(160, 21)
        Me.TxtHome_page.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(528, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Tag = "Account"
        Me.Label5.Text = "Home page"
        '
        'TxtDoi_tac
        '
        Me.TxtDoi_tac.ForeColor = System.Drawing.Color.Navy
        Me.TxtDoi_tac.Location = New System.Drawing.Point(105, 141)
        Me.TxtDoi_tac.Name = "TxtDoi_tac"
        Me.TxtDoi_tac.Size = New System.Drawing.Size(402, 21)
        Me.TxtDoi_tac.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Tag = "Account"
        Me.Label6.Text = "Đối tác"
        '
        'TxtMa_So_thue
        '
        Me.TxtMa_So_thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_So_thue.Location = New System.Drawing.Point(617, 141)
        Me.TxtMa_So_thue.Name = "TxtMa_So_thue"
        Me.TxtMa_So_thue.Size = New System.Drawing.Size(160, 21)
        Me.TxtMa_So_thue.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Tag = "Account"
        Me.Label7.Text = "Mã số thuế"
        '
        'TxtGhi_chu
        '
        Me.TxtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_chu.Location = New System.Drawing.Point(105, 188)
        Me.TxtGhi_chu.Multiline = True
        Me.TxtGhi_chu.Name = "TxtGhi_chu"
        Me.TxtGhi_chu.Size = New System.Drawing.Size(672, 36)
        Me.TxtGhi_chu.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Tag = "Account"
        Me.Label8.Text = "Ghi chú"
        '
        'TxtTinh_thanh
        '
        Me.TxtTinh_thanh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTinh_thanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTinh_thanh.Location = New System.Drawing.Point(105, 72)
        Me.TxtTinh_thanh.Name = "TxtTinh_thanh"
        Me.TxtTinh_thanh.Size = New System.Drawing.Size(672, 21)
        Me.TxtTinh_thanh.TabIndex = 3
        '
        'LabMa_Tinh
        '
        Me.LabMa_Tinh.AutoSize = True
        Me.LabMa_Tinh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Tinh.Location = New System.Drawing.Point(4, 74)
        Me.LabMa_Tinh.Name = "LabMa_Tinh"
        Me.LabMa_Tinh.Size = New System.Drawing.Size(58, 13)
        Me.LabMa_Tinh.TabIndex = 2086
        Me.LabMa_Tinh.Tag = "Province"
        Me.LabMa_Tinh.Text = "Tỉnh thành"
        '
        'Chkis_Tfs
        '
        Me.Chkis_Tfs.AutoSize = True
        Me.Chkis_Tfs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Chkis_Tfs.ForeColor = System.Drawing.Color.Navy
        Me.Chkis_Tfs.Location = New System.Drawing.Point(105, 165)
        Me.Chkis_Tfs.Name = "Chkis_Tfs"
        Me.Chkis_Tfs.Size = New System.Drawing.Size(136, 17)
        Me.Chkis_Tfs.TabIndex = 10
        Me.Chkis_Tfs.Tag = "TFS(Financial company)"
        Me.Chkis_Tfs.Text = "TFS (Công ty tài chính)"
        '
        'LabMa_Kh
        '
        Me.LabMa_Kh.ForeColor = System.Drawing.Color.Red
        Me.LabMa_Kh.Location = New System.Drawing.Point(267, 4)
        Me.LabMa_Kh.Name = "LabMa_Kh"
        Me.LabMa_Kh.Size = New System.Drawing.Size(89, 18)
        Me.LabMa_Kh.TabIndex = 2089
        Me.LabMa_Kh.Tag = "Customer"
        Me.LabMa_Kh.Text = "Mã khách hàng"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(517, 6)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(260, 14)
        Me.TxtTen_KH.TabIndex = 2088
        Me.TxtTen_KH.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(364, 3)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Kh.TabIndex = 2087
        Me.TxtMa_Kh.Table_Name = ""
        '
        'DmNhTraGop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 272)
        Me.Controls.Add(Me.LabMa_Kh)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.Chkis_Tfs)
        Me.Controls.Add(Me.TxtTinh_thanh)
        Me.Controls.Add(Me.LabMa_Tinh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtGhi_chu)
        Me.Controls.Add(Me.TxtMa_So_thue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDoi_tac)
        Me.Controls.Add(Me.TxtHome_page)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtE_mail)
        Me.Controls.Add(Me.TxtFax)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_NH2)
        Me.Controls.Add(Me.Labten_Kho2)
        Me.Controls.Add(Me.TxtTen_NH)
        Me.Controls.Add(Me.LabTen_kho)
        Me.Controls.Add(Me.TxtMa_NH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmNhTraGop"
        Me.Text = "Danh mục kho"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NH, 0)
        Me.Controls.SetChildIndex(Me.LabTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NH, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kho2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NH2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.TxtFax, 0)
        Me.Controls.SetChildIndex(Me.TxtE_mail, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtHome_page, 0)
        Me.Controls.SetChildIndex(Me.TxtDoi_tac, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_So_thue, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Tinh, 0)
        Me.Controls.SetChildIndex(Me.TxtTinh_thanh, 0)
        Me.Controls.SetChildIndex(Me.Chkis_Tfs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Kh, 0)
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtMa_NH As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_NH As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NH2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_Kho2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents TxtE_mail As System.Windows.Forms.TextBox
    Friend WithEvents TxtHome_page As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDoi_tac As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_So_thue As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTinh_thanh As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Tinh As System.Windows.Forms.Label
    Friend WithEvents Chkis_Tfs As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_Kh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup

End Class
