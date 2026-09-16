<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMHLGASKX
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
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.LabNgay_Ku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNh_KX2 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_KX2 = New System.Windows.Forms.TextBox()
        Me.TxtSo_Luong1 = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSo_Luong2 = New ClsTextBox.txtTien_NT()
        CType(Me.TxtNh_KX2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(436, 111)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(334, 111)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(228, 117)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.Size = New System.Drawing.Size(534, 9)
        Me.GroupBoxLine.TabIndex = 13
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 3)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(5, 4)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(99, 18)
        Me.LabNgay_Ku.TabIndex = 8
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Hiệu lực từ"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Nhóm kiểu xe"
        '
        'TxtNh_KX2
        '
        Me.TxtNh_KX2._ActilookupPopup = False
        Me.TxtNh_KX2.CyberActilookupPopup = True
        Me.TxtNh_KX2.Dv_ListDetail = Nothing
        Me.TxtNh_KX2.Dv_Master = Nothing
        Me.TxtNh_KX2.FilterClient = ""
        Me.TxtNh_KX2.FilterSQL = ""
        Me.TxtNh_KX2.Location = New System.Drawing.Point(110, 26)
        Me.TxtNh_KX2.Name = "TxtNh_KX2"
        Me.TxtNh_KX2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KX2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KX2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KX2.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_KX2.TabIndex = 1
        Me.TxtNh_KX2.Table_Name = ""
        '
        'TxtTen_Nh_KX2
        '
        Me.TxtTen_Nh_KX2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh_KX2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_KX2.Enabled = False
        Me.TxtTen_Nh_KX2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_KX2.Location = New System.Drawing.Point(264, 29)
        Me.TxtTen_Nh_KX2.Name = "TxtTen_Nh_KX2"
        Me.TxtTen_Nh_KX2.ReadOnly = True
        Me.TxtTen_Nh_KX2.Size = New System.Drawing.Size(271, 14)
        Me.TxtTen_Nh_KX2.TabIndex = 11
        Me.TxtTen_Nh_KX2.TabStop = False
        '
        'TxtSo_Luong1
        '
        Me.TxtSo_Luong1.AllowNegative = True
        Me.TxtSo_Luong1.Flags = 7680
        Me.TxtSo_Luong1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Luong1.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Luong1.InputMask = "### ### ###.###"
        Me.TxtSo_Luong1.Location = New System.Drawing.Point(110, 49)
        Me.TxtSo_Luong1.MaxWholeDigits = 12
        Me.TxtSo_Luong1.Name = "TxtSo_Luong1"
        Me.TxtSo_Luong1.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Luong1.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Luong1.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_Luong1.TabIndex = 2
        Me.TxtSo_Luong1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Khoảng gas từ"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(273, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Tag = "Group 2"
        Me.Label3.Text = "Đến"
        '
        'TxtSo_Luong2
        '
        Me.TxtSo_Luong2.AllowNegative = True
        Me.TxtSo_Luong2.Flags = 7680
        Me.TxtSo_Luong2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Luong2.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Luong2.InputMask = "### ### ###.###"
        Me.TxtSo_Luong2.Location = New System.Drawing.Point(309, 49)
        Me.TxtSo_Luong2.MaxWholeDigits = 12
        Me.TxtSo_Luong2.Name = "TxtSo_Luong2"
        Me.TxtSo_Luong2.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Luong2.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Luong2.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_Luong2.TabIndex = 3
        Me.TxtSo_Luong2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DMHLGASKX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 144)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_Luong2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_Luong1)
        Me.Controls.Add(Me.TxtTen_Nh_KX2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNh_KX2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.Name = "DMHLGASKX"
        Me.Text = "Danh mục hiệu lực vật tư tối ưu"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KX2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_KX2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Luong1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Luong2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtNh_KX2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_KX2 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_KX2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSo_Luong1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtSo_Luong2 As ClsTextBox.txtTien_NT
End Class
