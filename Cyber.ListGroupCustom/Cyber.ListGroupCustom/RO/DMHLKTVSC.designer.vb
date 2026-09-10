<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMHLKTVSC
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
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtTen_To = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_To = New Cyber.SmLists.TxtLookup()
        Me.ChkIs_Go = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Son = New System.Windows.Forms.CheckBox()
        Me.ChkIs_SCC = New System.Windows.Forms.CheckBox()
        Me.chkIs_PK = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Rua_Xe = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Kho = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(480, 111)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(378, 111)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(272, 117)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.Size = New System.Drawing.Size(578, 9)
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 54)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 2
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(5, 55)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(99, 18)
        Me.LabNgay_Ku.TabIndex = 3
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Hiệu lực từ"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Mã KTV"
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(110, 10)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_HS.TabIndex = 0
        Me.TxtMa_HS.Table_Name = ""
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(265, 12)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_Hs.TabIndex = 3
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtTen_To
        '
        Me.TxtTen_To.BackColor = System.Drawing.Color.White
        Me.TxtTen_To.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_To.Enabled = False
        Me.TxtTen_To.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_To.Location = New System.Drawing.Point(265, 34)
        Me.TxtTen_To.Name = "TxtTen_To"
        Me.TxtTen_To.ReadOnly = True
        Me.TxtTen_To.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_To.TabIndex = 4
        Me.TxtTen_To.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Mã Tổ"
        '
        'TxtMa_To
        '
        Me.TxtMa_To._ActilookupPopup = False
        Me.TxtMa_To.CyberActilookupPopup = True
        Me.TxtMa_To.Dv_ListDetail = Nothing
        Me.TxtMa_To.Dv_Master = Nothing
        Me.TxtMa_To.FilterClient = ""
        Me.TxtMa_To.FilterSQL = ""
        Me.TxtMa_To.Location = New System.Drawing.Point(110, 32)
        Me.TxtMa_To.Name = "TxtMa_To"
        Me.TxtMa_To.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_To.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_To.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_To.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_To.TabIndex = 1
        Me.TxtMa_To.Table_Name = ""
        '
        'ChkIs_Go
        '
        Me.ChkIs_Go.AutoSize = True
        Me.ChkIs_Go.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Go.Location = New System.Drawing.Point(5, 79)
        Me.ChkIs_Go.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkIs_Go.Name = "ChkIs_Go"
        Me.ChkIs_Go.Size = New System.Drawing.Size(59, 17)
        Me.ChkIs_Go.TabIndex = 15
        Me.ChkIs_Go.Text = "KTV gò"
        Me.ChkIs_Go.UseVisualStyleBackColor = True
        '
        'ChkIs_Son
        '
        Me.ChkIs_Son.AutoSize = True
        Me.ChkIs_Son.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Son.Location = New System.Drawing.Point(76, 79)
        Me.ChkIs_Son.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkIs_Son.Name = "ChkIs_Son"
        Me.ChkIs_Son.Size = New System.Drawing.Size(64, 17)
        Me.ChkIs_Son.TabIndex = 16
        Me.ChkIs_Son.Text = "KTV sơn"
        Me.ChkIs_Son.UseVisualStyleBackColor = True
        '
        'ChkIs_SCC
        '
        Me.ChkIs_SCC.AutoSize = True
        Me.ChkIs_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_SCC.Location = New System.Drawing.Point(155, 79)
        Me.ChkIs_SCC.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkIs_SCC.Name = "ChkIs_SCC"
        Me.ChkIs_SCC.Size = New System.Drawing.Size(67, 17)
        Me.ChkIs_SCC.TabIndex = 17
        Me.ChkIs_SCC.Text = "KTV SCC"
        Me.ChkIs_SCC.UseVisualStyleBackColor = True
        '
        'chkIs_PK
        '
        Me.chkIs_PK.AutoSize = True
        Me.chkIs_PK.ForeColor = System.Drawing.Color.Blue
        Me.chkIs_PK.Location = New System.Drawing.Point(247, 79)
        Me.chkIs_PK.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIs_PK.Name = "chkIs_PK"
        Me.chkIs_PK.Size = New System.Drawing.Size(87, 17)
        Me.chkIs_PK.TabIndex = 18
        Me.chkIs_PK.Text = "KTV Phụ kiện"
        Me.chkIs_PK.UseVisualStyleBackColor = True
        '
        'ChkIs_Rua_Xe
        '
        Me.ChkIs_Rua_Xe.AutoSize = True
        Me.ChkIs_Rua_Xe.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Rua_Xe.Location = New System.Drawing.Point(355, 79)
        Me.ChkIs_Rua_Xe.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkIs_Rua_Xe.Name = "ChkIs_Rua_Xe"
        Me.ChkIs_Rua_Xe.Size = New System.Drawing.Size(79, 17)
        Me.ChkIs_Rua_Xe.TabIndex = 500
        Me.ChkIs_Rua_Xe.Text = "KTV rửa xe"
        Me.ChkIs_Rua_Xe.UseVisualStyleBackColor = True
        '
        'ChkIs_Kho
        '
        Me.ChkIs_Kho.AutoSize = True
        Me.ChkIs_Kho.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Kho.Location = New System.Drawing.Point(458, 79)
        Me.ChkIs_Kho.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkIs_Kho.Name = "ChkIs_Kho"
        Me.ChkIs_Kho.Size = New System.Drawing.Size(65, 17)
        Me.ChkIs_Kho.TabIndex = 501
        Me.ChkIs_Kho.Text = "KTV Kho"
        Me.ChkIs_Kho.UseVisualStyleBackColor = True
        '
        'DMHLKTVSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 144)
        Me.Controls.Add(Me.ChkIs_Kho)
        Me.Controls.Add(Me.ChkIs_Rua_Xe)
        Me.Controls.Add(Me.chkIs_PK)
        Me.Controls.Add(Me.ChkIs_SCC)
        Me.Controls.Add(Me.ChkIs_Son)
        Me.Controls.Add(Me.ChkIs_Go)
        Me.Controls.Add(Me.TxtTen_To)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_To)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMHLKTVSC"
        Me.Text = "Danh mục hiệu lực vật tư tối ưu"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_To, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_To, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Go, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Son, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_SCC, 0)
        Me.Controls.SetChildIndex(Me.chkIs_PK, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Rua_Xe, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Kho, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HS As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_To As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_To As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkIs_Go As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Son As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents chkIs_PK As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Rua_Xe As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Kho As System.Windows.Forms.CheckBox
End Class
