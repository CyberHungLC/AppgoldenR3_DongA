<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMPTCK
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
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.TxtPT_CK = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTy_Gia1 = New ClsTextBox.txtTy_Gia()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbMa_LoaiCK = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(461, 185)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(359, 185)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(10, 171)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 194)
        Me.ChkActi.TabIndex = 6
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 175)
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
        Me.LabMa_vt.Text = "Mã khách hàng"
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Enabled = False
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(246, 33)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(308, 14)
        Me.TxtTen_Kh.TabIndex = 382
        Me.TxtTen_Kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(127, 30)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(108, 20)
        Me.TxtMa_Kh.TabIndex = 1
        Me.TxtMa_Kh.Table_Name = ""
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
        'TxtPT_CK
        '
        Me.TxtPT_CK.AllowNegative = True
        Me.TxtPT_CK.Flags = 7680
        Me.TxtPT_CK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CK.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CK.InputMask = "### ### ###.##"
        Me.TxtPT_CK.Location = New System.Drawing.Point(127, 98)
        Me.TxtPT_CK.MaxWholeDigits = 11
        Me.TxtPT_CK.Name = "TxtPT_CK"
        Me.TxtPT_CK.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CK.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CK.Size = New System.Drawing.Size(109, 21)
        Me.TxtPT_CK.TabIndex = 4
        Me.TxtPT_CK.Text = "1.00"
        Me.TxtPT_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(5, 98)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "% chiết khấu"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(127, 51)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(109, 21)
        Me.TxtMa_Xe.TabIndex = 2
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.Location = New System.Drawing.Point(127, 74)
        Me.TxtSo_Khung.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(109, 21)
        Me.TxtSo_Khung.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 385
        Me.Label1.Tag = "Item code"
        Me.Label1.Text = "Biển số"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 386
        Me.Label2.Tag = "Item code"
        Me.Label2.Text = "Số khung"
        '
        'TxtTy_Gia1
        '
        Me.TxtTy_Gia1.AllowNegative = True
        Me.TxtTy_Gia1.Flags = 7680
        Me.TxtTy_Gia1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia1.InputMask = "### ### ###.##"
        Me.TxtTy_Gia1.Location = New System.Drawing.Point(127, 119)
        Me.TxtTy_Gia1.MaxWholeDigits = 11
        Me.TxtTy_Gia1.Name = "TxtTy_Gia1"
        Me.TxtTy_Gia1.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia1.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia1.Size = New System.Drawing.Size(109, 21)
        Me.TxtTy_Gia1.TabIndex = 5
        Me.TxtTy_Gia1.Text = "1.00"
        Me.TxtTy_Gia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 388
        Me.Label3.Tag = "Pretax price"
        Me.Label3.Text = "% chiết khấu CV"
        '
        'CbbMa_LoaiCK
        '
        Me.CbbMa_LoaiCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_LoaiCK.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_LoaiCK.FormattingEnabled = True
        Me.CbbMa_LoaiCK.Location = New System.Drawing.Point(291, 7)
        Me.CbbMa_LoaiCK.Name = "CbbMa_LoaiCK"
        Me.CbbMa_LoaiCK.Size = New System.Drawing.Size(270, 21)
        Me.CbbMa_LoaiCK.TabIndex = 389
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 390
        Me.Label6.Tag = "Month from"
        Me.Label6.Text = "Loại CK"
        '
        'DMPTCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(563, 219)
        Me.Controls.Add(Me.CbbMa_LoaiCK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTy_Gia1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.TxtPT_CK)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMPTCK"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_LoaiCK, 0)
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents TxtPT_CK As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Windows.Forms.TextBox
    Friend WithEvents TxtSo_Khung As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTy_Gia1 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents CbbMa_LoaiCK As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
