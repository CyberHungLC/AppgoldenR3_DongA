<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmQuay
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
        Me.LabMa_Nh = New System.Windows.Forms.Label()
        Me.LabLoai_Nh = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_quay = New System.Windows.Forms.TextBox()
        Me.TxtTen_quay2 = New System.Windows.Forms.TextBox()
        Me.TxtMa_quay = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 119)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(445, 119)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(340, 124)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 128)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 102)
        Me.GroupBoxLine.Size = New System.Drawing.Size(645, 10)
        '
        'LabMa_Nh
        '
        Me.LabMa_Nh.AutoSize = True
        Me.LabMa_Nh.Location = New System.Drawing.Point(10, 35)
        Me.LabMa_Nh.Name = "LabMa_Nh"
        Me.LabMa_Nh.Size = New System.Drawing.Size(52, 13)
        Me.LabMa_Nh.TabIndex = 2
        Me.LabMa_Nh.Tag = "Code"
        Me.LabMa_Nh.Text = "Tên quầy"
        '
        'LabLoai_Nh
        '
        Me.LabLoai_Nh.AutoSize = True
        Me.LabLoai_Nh.Location = New System.Drawing.Point(10, 11)
        Me.LabLoai_Nh.Name = "LabLoai_Nh"
        Me.LabLoai_Nh.Size = New System.Drawing.Size(48, 13)
        Me.LabLoai_Nh.TabIndex = 0
        Me.LabLoai_Nh.Tag = "Code"
        Me.LabLoai_Nh.Text = "Mã quầy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Tag = "Code"
        Me.Label5.Text = "Tên quầy 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Tag = "Name"
        Me.Label6.Text = "Nhân viên"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(260, 82)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(387, 14)
        Me.TxtTen_Hs.TabIndex = 8
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.FilterClient = ""
        Me.TxtMa_hs.FilterSQL = ""
        Me.TxtMa_hs.Location = New System.Drawing.Point(105, 79)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_hs.TabIndex = 3
        Me.TxtMa_hs.Table_Name = ""
        '
        'TxtTen_quay
        '
        Me.TxtTen_quay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTen_quay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quay.Location = New System.Drawing.Point(105, 31)
        Me.TxtTen_quay.Name = "TxtTen_quay"
        Me.TxtTen_quay.Size = New System.Drawing.Size(149, 21)
        Me.TxtTen_quay.TabIndex = 1
        '
        'TxtTen_quay2
        '
        Me.TxtTen_quay2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTen_quay2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quay2.Location = New System.Drawing.Point(105, 55)
        Me.TxtTen_quay2.Name = "TxtTen_quay2"
        Me.TxtTen_quay2.Size = New System.Drawing.Size(149, 21)
        Me.TxtTen_quay2.TabIndex = 2
        '
        'TxtMa_quay
        '
        Me.TxtMa_quay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_quay.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_quay.Location = New System.Drawing.Point(105, 7)
        Me.TxtMa_quay.Name = "TxtMa_quay"
        Me.TxtMa_quay.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_quay.TabIndex = 0
        '
        'DmQuay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(649, 151)
        Me.Controls.Add(Me.TxtMa_quay)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_quay2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabLoai_Nh)
        Me.Controls.Add(Me.TxtTen_quay)
        Me.Controls.Add(Me.LabMa_Nh)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(488, 179)
        Me.Name = "DmQuay"
        Me.Text = "Danh mục Quầy"
        Me.Controls.SetChildIndex(Me.LabMa_Nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_quay, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_Nh, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_quay2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_quay, 0)
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh As System.Windows.Forms.Label
    Friend WithEvents LabLoai_Nh As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As Windows.Forms.TextBox
    Friend WithEvents TxtMa_hs As SmLists.TxtLookup
    Friend WithEvents TxtTen_quay As Windows.Forms.TextBox
    Friend WithEvents TxtTen_quay2 As Windows.Forms.TextBox
    Friend WithEvents TxtMa_quay As Windows.Forms.TextBox
End Class
