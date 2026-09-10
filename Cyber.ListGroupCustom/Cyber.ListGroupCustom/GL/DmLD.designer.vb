<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMLD
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
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.TxtMa_LD = New System.Windows.Forms.TextBox()
        Me.TxtTen_LD = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtTen_LD2 = New System.Windows.Forms.TextBox()
        Me.LabTen_BP2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(539, 78)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(437, 78)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(331, 84)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(81, 88)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 68)
        Me.GroupBoxLine.Size = New System.Drawing.Size(637, 9)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.AutoSize = True
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 7)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(47, 13)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã lý do"
        '
        'TxtMa_LD
        '
        Me.TxtMa_LD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_LD.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LD.Location = New System.Drawing.Point(81, 3)
        Me.TxtMa_LD.Name = "TxtMa_LD"
        Me.TxtMa_LD.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_LD.TabIndex = 0
        '
        'TxtTen_LD
        '
        Me.TxtTen_LD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LD.Location = New System.Drawing.Point(81, 26)
        Me.TxtTen_LD.Name = "TxtTen_LD"
        Me.TxtTen_LD.Size = New System.Drawing.Size(557, 21)
        Me.TxtTen_LD.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.AutoSize = True
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(51, 13)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên lý do"
        '
        'TxtTen_LD2
        '
        Me.TxtTen_LD2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LD2.Location = New System.Drawing.Point(81, 49)
        Me.TxtTen_LD2.Name = "TxtTen_LD2"
        Me.TxtTen_LD2.Size = New System.Drawing.Size(557, 21)
        Me.TxtTen_LD2.TabIndex = 2
        '
        'LabTen_BP2
        '
        Me.LabTen_BP2.AutoSize = True
        Me.LabTen_BP2.Location = New System.Drawing.Point(5, 53)
        Me.LabTen_BP2.Name = "LabTen_BP2"
        Me.LabTen_BP2.Size = New System.Drawing.Size(60, 13)
        Me.LabTen_BP2.TabIndex = 14
        Me.LabTen_BP2.Tag = "English name"
        Me.LabTen_BP2.Text = "Tên lý do 2"
        '
        'DMLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 111)
        Me.Controls.Add(Me.TxtTen_LD2)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.TxtTen_LD)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.TxtMa_LD)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 120)
        Me.Name = "DMLD"
        Me.Text = "Danh mục lý do hủy phiếu"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LD, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LD, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LD2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtMa_LD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_LD As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtTen_LD2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label

End Class
