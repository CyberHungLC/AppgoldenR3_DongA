<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmDauSo
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
        Me.LabMa_BH = New System.Windows.Forms.Label()
        Me.TxtMa_DauSo = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh = New System.Windows.Forms.Label()
        Me.TxtTen_TP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TP = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_NhaMang = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhaMang = New System.Windows.Forms.TextBox()
        Me.TxtLeng = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NhaMang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(483, 109)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(381, 109)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(275, 115)
        Me.TxtMa_Dvcs.TabIndex = 12
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(109, 114)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 99)
        Me.GroupBoxLine.Size = New System.Drawing.Size(581, 9)
        Me.GroupBoxLine.TabIndex = 11
        '
        'LabMa_BH
        '
        Me.LabMa_BH.AutoSize = True
        Me.LabMa_BH.Location = New System.Drawing.Point(8, 11)
        Me.LabMa_BH.Name = "LabMa_BH"
        Me.LabMa_BH.Size = New System.Drawing.Size(41, 13)
        Me.LabMa_BH.TabIndex = 7
        Me.LabMa_BH.Tag = "Code"
        Me.LabMa_BH.Text = "Đầu số"
        '
        'TxtMa_DauSo
        '
        Me.TxtMa_DauSo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_DauSo.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_DauSo.Location = New System.Drawing.Point(109, 7)
        Me.TxtMa_DauSo.Name = "TxtMa_DauSo"
        Me.TxtMa_DauSo.Size = New System.Drawing.Size(145, 21)
        Me.TxtMa_DauSo.TabIndex = 0
        '
        'LabTen_Bh
        '
        Me.LabTen_Bh.AutoSize = True
        Me.LabTen_Bh.Location = New System.Drawing.Point(8, 34)
        Me.LabTen_Bh.Name = "LabTen_Bh"
        Me.LabTen_Bh.Size = New System.Drawing.Size(55, 13)
        Me.LabTen_Bh.TabIndex = 8
        Me.LabTen_Bh.Tag = "Name"
        Me.LabTen_Bh.Text = "Nhà mạng"
        '
        'TxtTen_TP
        '
        Me.TxtTen_TP.BackColor = System.Drawing.Color.White
        Me.TxtTen_TP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TP.Enabled = False
        Me.TxtTen_TP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TP.Location = New System.Drawing.Point(259, 55)
        Me.TxtTen_TP.Name = "TxtTen_TP"
        Me.TxtTen_TP.ReadOnly = True
        Me.TxtTen_TP.Size = New System.Drawing.Size(322, 14)
        Me.TxtTen_TP.TabIndex = 14
        Me.TxtTen_TP.TabStop = False
        '
        'TxtMa_TP
        '
        Me.TxtMa_TP._ActilookupPopup = False
        Me.TxtMa_TP.CyberActilookupPopup = True
        Me.TxtMa_TP.Dv_ListDetail = Nothing
        Me.TxtMa_TP.Dv_Master = Nothing
        Me.TxtMa_TP.FilterClient = ""
        Me.TxtMa_TP.FilterSQL = ""
        Me.TxtMa_TP.Location = New System.Drawing.Point(109, 52)
        Me.TxtMa_TP.Name = "TxtMa_TP"
        Me.TxtMa_TP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TP.Size = New System.Drawing.Size(145, 20)
        Me.TxtMa_TP.TabIndex = 2
        Me.TxtMa_TP.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = "English name"
        Me.Label1.Text = "Tỉnh/TP"
        '
        'TxtMa_NhaMang
        '
        Me.TxtMa_NhaMang._ActilookupPopup = False
        Me.TxtMa_NhaMang.CyberActilookupPopup = True
        Me.TxtMa_NhaMang.Dv_ListDetail = Nothing
        Me.TxtMa_NhaMang.Dv_Master = Nothing
        Me.TxtMa_NhaMang.FilterClient = ""
        Me.TxtMa_NhaMang.FilterSQL = ""
        Me.TxtMa_NhaMang.Location = New System.Drawing.Point(109, 30)
        Me.TxtMa_NhaMang.Name = "TxtMa_NhaMang"
        Me.TxtMa_NhaMang.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NhaMang.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NhaMang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NhaMang.Size = New System.Drawing.Size(145, 20)
        Me.TxtMa_NhaMang.TabIndex = 1
        Me.TxtMa_NhaMang.Table_Name = ""
        '
        'TxtTen_NhaMang
        '
        Me.TxtTen_NhaMang.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhaMang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NhaMang.Enabled = False
        Me.TxtTen_NhaMang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhaMang.Location = New System.Drawing.Point(259, 33)
        Me.TxtTen_NhaMang.Name = "TxtTen_NhaMang"
        Me.TxtTen_NhaMang.ReadOnly = True
        Me.TxtTen_NhaMang.Size = New System.Drawing.Size(322, 14)
        Me.TxtTen_NhaMang.TabIndex = 13
        Me.TxtTen_NhaMang.TabStop = False
        '
        'TxtLeng
        '
        Me.TxtLeng.AllowNegative = True
        Me.TxtLeng.BackColor = System.Drawing.Color.White
        Me.TxtLeng.Flags = 7680
        Me.TxtLeng.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLeng.ForeColor = System.Drawing.Color.Navy
        Me.TxtLeng.InputMask = " ###"
        Me.TxtLeng.Location = New System.Drawing.Point(109, 75)
        Me.TxtLeng.MaxWholeDigits = 2
        Me.TxtLeng.Name = "TxtLeng"
        Me.TxtLeng.RangeMax = 1.7976931348623157E+308R
        Me.TxtLeng.RangeMin = -1.7976931348623157E+308R
        Me.TxtLeng.Size = New System.Drawing.Size(145, 21)
        Me.TxtLeng.TabIndex = 3
        Me.TxtLeng.Text = "0"
        Me.TxtLeng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = "English name"
        Me.Label2.Text = "Độ dài SĐT"
        '
        'DmDauSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(585, 142)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLeng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_NhaMang)
        Me.Controls.Add(Me.TxtTen_TP)
        Me.Controls.Add(Me.TxtMa_NhaMang)
        Me.Controls.Add(Me.TxtMa_TP)
        Me.Controls.Add(Me.LabTen_Bh)
        Me.Controls.Add(Me.TxtMa_DauSo)
        Me.Controls.Add(Me.LabMa_BH)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmDauSo"
        Me.Text = "Danh mục nhà mạng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_DauSo, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NhaMang, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhaMang, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtLeng, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NhaMang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_BH As System.Windows.Forms.Label
    Friend WithEvents TxtMa_DauSo As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TP As Windows.Forms.TextBox
    Friend WithEvents TxtMa_TP As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_NhaMang As SmLists.TxtLookup
    Friend WithEvents TxtTen_NhaMang As Windows.Forms.TextBox
    Friend WithEvents TxtLeng As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
