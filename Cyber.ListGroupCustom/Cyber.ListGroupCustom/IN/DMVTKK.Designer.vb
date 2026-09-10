<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMVTKK
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
        Me.LabMa_Vt = New System.Windows.Forms.Label()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_VT = New Cyber.SmLists.TxtLookup()
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSl_VNPG = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSL_Nap = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSL_Tai_Quay = New ClsTextBox.txtTien_NT()
        Me.txtDVT = New System.Windows.Forms.TextBox()
        Me.LabDia_chi = New System.Windows.Forms.Label()
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(551, 217)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(415, 217)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(274, 225)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 230)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 204)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(682, 12)
        Me.GroupBoxLine.TabIndex = 13
        '
        'LabMa_Vt
        '
        Me.LabMa_Vt.Location = New System.Drawing.Point(11, 36)
        Me.LabMa_Vt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Vt.Name = "LabMa_Vt"
        Me.LabMa_Vt.Size = New System.Drawing.Size(103, 21)
        Me.LabMa_Vt.TabIndex = 24
        Me.LabMa_Vt.Tag = "Group 1"
        Me.LabMa_Vt.Text = "Mã vật tư"
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(351, 38)
        Me.TxtTen_Vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(305, 17)
        Me.TxtTen_Vt.TabIndex = 23
        Me.TxtTen_Vt.TabStop = False
        '
        'TxtMa_VT
        '
        Me.TxtMa_VT._ActilookupPopup = False
        Me.TxtMa_VT.CyberActilookupPopup = True
        Me.TxtMa_VT.Dv_ListDetail = Nothing
        Me.TxtMa_VT.Dv_Master = Nothing
        Me.TxtMa_VT.FilterClient = ""
        Me.TxtMa_VT.FilterSQL = ""
        Me.TxtMa_VT.Location = New System.Drawing.Point(147, 35)
        Me.TxtMa_VT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_VT.Name = "TxtMa_VT"
        Me.TxtMa_VT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_VT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_VT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_VT.Size = New System.Drawing.Size(197, 22)
        Me.TxtMa_VT.TabIndex = 1
        Me.TxtMa_VT.Table_Name = ""
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(147, 5)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Tag = "Group 1"
        Me.Label1.Text = "Ngày hiệu lực"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "Group 2"
        Me.Label3.Text = "Số lượng vỏ-nắp"
        '
        'TxtSl_VNPG
        '
        Me.TxtSl_VNPG.AllowNegative = True
        Me.TxtSl_VNPG.BackColor = System.Drawing.Color.White
        Me.TxtSl_VNPG.Flags = 7680
        Me.TxtSl_VNPG.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSl_VNPG.ForeColor = System.Drawing.Color.Navy
        Me.TxtSl_VNPG.InputMask = " ### ### ### ###.#"
        Me.TxtSl_VNPG.Location = New System.Drawing.Point(147, 96)
        Me.TxtSl_VNPG.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSl_VNPG.MaxWholeDigits = 13
        Me.TxtSl_VNPG.Name = "TxtSl_VNPG"
        Me.TxtSl_VNPG.RangeMax = 1.7976931348623157E+308R
        Me.TxtSl_VNPG.RangeMin = -1.7976931348623157E+308R
        Me.TxtSl_VNPG.Size = New System.Drawing.Size(197, 24)
        Me.TxtSl_VNPG.TabIndex = 3
        Me.TxtSl_VNPG.Text = "0.0"
        Me.TxtSl_VNPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Số lượng lắp"
        '
        'TxtSL_Nap
        '
        Me.TxtSL_Nap.AllowNegative = True
        Me.TxtSL_Nap.BackColor = System.Drawing.Color.White
        Me.TxtSL_Nap.Flags = 7680
        Me.TxtSL_Nap.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSL_Nap.ForeColor = System.Drawing.Color.Navy
        Me.TxtSL_Nap.InputMask = " ### ### ### ###.#"
        Me.TxtSL_Nap.Location = New System.Drawing.Point(147, 126)
        Me.TxtSL_Nap.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSL_Nap.MaxWholeDigits = 13
        Me.TxtSL_Nap.Name = "TxtSL_Nap"
        Me.TxtSL_Nap.RangeMax = 1.7976931348623157E+308R
        Me.TxtSL_Nap.RangeMin = -1.7976931348623157E+308R
        Me.TxtSL_Nap.Size = New System.Drawing.Size(197, 24)
        Me.TxtSL_Nap.TabIndex = 4
        Me.TxtSL_Nap.Text = "0.0"
        Me.TxtSL_Nap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Số lượng tay quậy"
        '
        'TxtSL_Tai_Quay
        '
        Me.TxtSL_Tai_Quay.AllowNegative = True
        Me.TxtSL_Tai_Quay.BackColor = System.Drawing.Color.White
        Me.TxtSL_Tai_Quay.Flags = 7680
        Me.TxtSL_Tai_Quay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSL_Tai_Quay.ForeColor = System.Drawing.Color.Navy
        Me.TxtSL_Tai_Quay.InputMask = " ### ### ### ###.#"
        Me.TxtSL_Tai_Quay.Location = New System.Drawing.Point(147, 157)
        Me.TxtSL_Tai_Quay.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSL_Tai_Quay.MaxWholeDigits = 13
        Me.TxtSL_Tai_Quay.Name = "TxtSL_Tai_Quay"
        Me.TxtSL_Tai_Quay.RangeMax = 1.7976931348623157E+308R
        Me.TxtSL_Tai_Quay.RangeMin = -1.7976931348623157E+308R
        Me.TxtSL_Tai_Quay.Size = New System.Drawing.Size(197, 24)
        Me.TxtSL_Tai_Quay.TabIndex = 5
        Me.TxtSL_Tai_Quay.Text = "0.0"
        Me.TxtSL_Tai_Quay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDVT
        '
        Me.txtDVT.ForeColor = System.Drawing.Color.Navy
        Me.txtDVT.Location = New System.Drawing.Point(147, 66)
        Me.txtDVT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.Size = New System.Drawing.Size(197, 24)
        Me.txtDVT.TabIndex = 2
        '
        'LabDia_chi
        '
        Me.LabDia_chi.Location = New System.Drawing.Point(11, 66)
        Me.LabDia_chi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDia_chi.Name = "LabDia_chi"
        Me.LabDia_chi.Size = New System.Drawing.Size(129, 24)
        Me.LabDia_chi.TabIndex = 2102
        Me.LabDia_chi.Tag = "Address VAT"
        Me.LabDia_chi.Text = "Đơn vị tính"
        '
        'DMVTKK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 260)
        Me.Controls.Add(Me.txtDVT)
        Me.Controls.Add(Me.LabDia_chi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSL_Tai_Quay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSL_Nap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSl_VNPG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabMa_Vt)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.TxtMa_VT)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(646, 150)
        Me.Name = "DMVTKK"
        Me.Text = "Danh mục vật tư kiểm kê"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_VT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSl_VNPG, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtSL_Nap, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSL_Tai_Quay, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabDia_chi, 0)
        Me.Controls.SetChildIndex(Me.txtDVT, 0)
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_VT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtSl_VNPG As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtSL_Nap As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TxtSL_Tai_Quay As ClsTextBox.txtTien_NT
    Friend WithEvents txtDVT As Windows.Forms.TextBox
    Friend WithEvents LabDia_chi As Windows.Forms.Label
End Class
