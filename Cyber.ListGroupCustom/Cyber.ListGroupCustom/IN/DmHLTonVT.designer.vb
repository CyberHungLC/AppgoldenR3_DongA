<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmHLTonVT
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
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTon_Min = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTon_Max = New ClsTextBox.txtTien_NT()
        Me.TxtDvt = New System.Windows.Forms.TextBox()
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(480, 157)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(378, 157)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(272, 162)
        Me.TxtMa_Dvcs.TabIndex = 15
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 164)
        Me.ChkActi.TabIndex = 6
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 147)
        Me.GroupBoxLine.Size = New System.Drawing.Size(578, 9)
        Me.GroupBoxLine.TabIndex = 13
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 124)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 5
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(5, 125)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(99, 18)
        Me.LabNgay_Ku.TabIndex = 12
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Ngày áp dụng"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Vật tư"
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(110, 29)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Vt.TabIndex = 1
        Me.TxtMa_Vt.Table_Name = ""
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(265, 32)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_Vt.TabIndex = 14
        Me.TxtTen_Vt.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Đvt"
        '
        'TxtTon_Min
        '
        Me.TxtTon_Min.AllowNegative = True
        Me.TxtTon_Min.BackColor = System.Drawing.Color.White
        Me.TxtTon_Min.Flags = 7680
        Me.TxtTon_Min.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTon_Min.ForeColor = System.Drawing.Color.Navy
        Me.TxtTon_Min.InputMask = " ### ### ### ###.####"
        Me.TxtTon_Min.Location = New System.Drawing.Point(110, 76)
        Me.TxtTon_Min.MaxWholeDigits = 16
        Me.TxtTon_Min.Name = "TxtTon_Min"
        Me.TxtTon_Min.RangeMax = 1.7976931348623157E+308R
        Me.TxtTon_Min.RangeMin = -1.7976931348623157E+308R
        Me.TxtTon_Min.Size = New System.Drawing.Size(149, 21)
        Me.TxtTon_Min.TabIndex = 3
        Me.TxtTon_Min.Text = "0.0000"
        Me.TxtTon_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Tag = "Group 2"
        Me.Label3.Text = "Tồn kho tối thiểu"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Tồn kho tối đa"
        '
        'TxtTon_Max
        '
        Me.TxtTon_Max.AllowNegative = True
        Me.TxtTon_Max.BackColor = System.Drawing.Color.White
        Me.TxtTon_Max.Flags = 7680
        Me.TxtTon_Max.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTon_Max.ForeColor = System.Drawing.Color.Navy
        Me.TxtTon_Max.InputMask = " ### ### ### ###.####"
        Me.TxtTon_Max.Location = New System.Drawing.Point(110, 100)
        Me.TxtTon_Max.MaxWholeDigits = 16
        Me.TxtTon_Max.Name = "TxtTon_Max"
        Me.TxtTon_Max.RangeMax = 1.7976931348623157E+308R
        Me.TxtTon_Max.RangeMin = -1.7976931348623157E+308R
        Me.TxtTon_Max.Size = New System.Drawing.Size(149, 21)
        Me.TxtTon_Max.TabIndex = 4
        Me.TxtTon_Max.Text = "0.0000"
        Me.TxtTon_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDvt
        '
        Me.TxtDvt.BackColor = System.Drawing.Color.White
        Me.TxtDvt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDvt.Enabled = False
        Me.TxtDvt.ForeColor = System.Drawing.Color.Navy
        Me.TxtDvt.Location = New System.Drawing.Point(110, 52)
        Me.TxtDvt.Name = "TxtDvt"
        Me.TxtDvt.ReadOnly = True
        Me.TxtDvt.Size = New System.Drawing.Size(149, 21)
        Me.TxtDvt.TabIndex = 2
        '
        'TxtTen_Kho
        '
        Me.TxtTen_Kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kho.Enabled = False
        Me.TxtTen_Kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kho.Location = New System.Drawing.Point(265, 9)
        Me.TxtTen_Kho.Name = "TxtTen_Kho"
        Me.TxtTen_Kho.ReadOnly = True
        Me.TxtTen_Kho.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_Kho.TabIndex = 18
        Me.TxtTen_Kho.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Kho"
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho._ActilookupPopup = False
        Me.TxtMa_Kho.CyberActilookupPopup = True
        Me.TxtMa_Kho.Dv_ListDetail = Nothing
        Me.TxtMa_Kho.Dv_Master = Nothing
        Me.TxtMa_Kho.FilterClient = ""
        Me.TxtMa_Kho.FilterSQL = ""
        Me.TxtMa_Kho.Location = New System.Drawing.Point(110, 6)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Kho.TabIndex = 0
        Me.TxtMa_Kho.Table_Name = ""
        '
        'DmHLTonVT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 190)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.TxtDvt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTon_Max)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTon_Min)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_Vt)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.Name = "DmHLTonVT"
        Me.Text = "Đăng ký định mức tồn kho vật tư"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTon_Min, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTon_Max, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtDvt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTon_Min As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TxtTon_Max As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDvt As Windows.Forms.TextBox
    Friend WithEvents TxtTen_Kho As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtMa_Kho As SmLists.TxtLookup
End Class
