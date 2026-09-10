<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmNhaMang
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
        Me.LabMa_BH = New System.Windows.Forms.Label()
        Me.TxtMa_NhaMang = New System.Windows.Forms.TextBox()
        Me.TxtTen_NhaMang = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh = New System.Windows.Forms.Label()
        Me.TxtTen_NhaMang2 = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(483, 111)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(381, 111)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(275, 117)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.Size = New System.Drawing.Size(581, 9)
        '
        'LabMa_BH
        '
        Me.LabMa_BH.AutoSize = True
        Me.LabMa_BH.Location = New System.Drawing.Point(8, 8)
        Me.LabMa_BH.Name = "LabMa_BH"
        Me.LabMa_BH.Size = New System.Drawing.Size(71, 13)
        Me.LabMa_BH.TabIndex = 6
        Me.LabMa_BH.Tag = "Code"
        Me.LabMa_BH.Text = "Mã nhà mạng"
        '
        'TxtMa_NhaMang
        '
        Me.TxtMa_NhaMang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NhaMang.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NhaMang.Location = New System.Drawing.Point(110, 7)
        Me.TxtMa_NhaMang.Name = "TxtMa_NhaMang"
        Me.TxtMa_NhaMang.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_NhaMang.TabIndex = 0
        '
        'TxtTen_NhaMang
        '
        Me.TxtTen_NhaMang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhaMang.Location = New System.Drawing.Point(110, 30)
        Me.TxtTen_NhaMang.Name = "TxtTen_NhaMang"
        Me.TxtTen_NhaMang.Size = New System.Drawing.Size(472, 21)
        Me.TxtTen_NhaMang.TabIndex = 1
        '
        'LabTen_Bh
        '
        Me.LabTen_Bh.AutoSize = True
        Me.LabTen_Bh.Location = New System.Drawing.Point(8, 32)
        Me.LabTen_Bh.Name = "LabTen_Bh"
        Me.LabTen_Bh.Size = New System.Drawing.Size(75, 13)
        Me.LabTen_Bh.TabIndex = 8
        Me.LabTen_Bh.Tag = "Name"
        Me.LabTen_Bh.Text = "Tên nhà mạng"
        '
        'TxtTen_NhaMang2
        '
        Me.TxtTen_NhaMang2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhaMang2.Location = New System.Drawing.Point(110, 53)
        Me.TxtTen_NhaMang2.Name = "TxtTen_NhaMang2"
        Me.TxtTen_NhaMang2.Size = New System.Drawing.Size(472, 21)
        Me.TxtTen_NhaMang2.TabIndex = 2
        '
        'LabTen_Bh2
        '
        Me.LabTen_Bh2.AutoSize = True
        Me.LabTen_Bh2.Location = New System.Drawing.Point(8, 54)
        Me.LabTen_Bh2.Name = "LabTen_Bh2"
        Me.LabTen_Bh2.Size = New System.Drawing.Size(63, 13)
        Me.LabTen_Bh2.TabIndex = 7
        Me.LabTen_Bh2.Tag = "English name"
        Me.LabTen_Bh2.Text = "Tên viết tắt"
        '
        'DmNhaMang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(585, 144)
        Me.Controls.Add(Me.TxtTen_NhaMang2)
        Me.Controls.Add(Me.LabTen_Bh2)
        Me.Controls.Add(Me.TxtTen_NhaMang)
        Me.Controls.Add(Me.LabTen_Bh)
        Me.Controls.Add(Me.TxtMa_NhaMang)
        Me.Controls.Add(Me.LabMa_BH)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmNhaMang"
        Me.Text = "Danh mục nhà mạng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NhaMang, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhaMang, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhaMang2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_BH As System.Windows.Forms.Label
    Friend WithEvents TxtMa_NhaMang As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_NhaMang As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NhaMang2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh2 As System.Windows.Forms.Label

End Class
