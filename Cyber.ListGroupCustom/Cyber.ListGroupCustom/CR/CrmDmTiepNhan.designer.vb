<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrmDmTiepNhan
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
        Me.TxtMa_Tiep_nhan = New System.Windows.Forms.TextBox()
        Me.TxtTen_Tiep_nhan = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh = New System.Windows.Forms.Label()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(483, 75)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(381, 75)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(275, 81)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 85)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 65)
        Me.GroupBoxLine.Size = New System.Drawing.Size(581, 9)
        '
        'LabMa_BH
        '
        Me.LabMa_BH.AutoSize = True
        Me.LabMa_BH.Location = New System.Drawing.Point(8, 15)
        Me.LabMa_BH.Name = "LabMa_BH"
        Me.LabMa_BH.Size = New System.Drawing.Size(69, 13)
        Me.LabMa_BH.TabIndex = 6
        Me.LabMa_BH.Tag = "Code"
        Me.LabMa_BH.Text = "Mã tiếp nhận"
        '
        'TxtMa_Tiep_nhan
        '
        Me.TxtMa_Tiep_nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Tiep_nhan.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Tiep_nhan.Location = New System.Drawing.Point(110, 14)
        Me.TxtMa_Tiep_nhan.Name = "TxtMa_Tiep_nhan"
        Me.TxtMa_Tiep_nhan.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_Tiep_nhan.TabIndex = 0
        '
        'TxtTen_Tiep_nhan
        '
        Me.TxtTen_Tiep_nhan.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tiep_nhan.Location = New System.Drawing.Point(110, 37)
        Me.TxtTen_Tiep_nhan.Name = "TxtTen_Tiep_nhan"
        Me.TxtTen_Tiep_nhan.Size = New System.Drawing.Size(472, 21)
        Me.TxtTen_Tiep_nhan.TabIndex = 1
        '
        'LabTen_Bh
        '
        Me.LabTen_Bh.AutoSize = True
        Me.LabTen_Bh.Location = New System.Drawing.Point(8, 39)
        Me.LabTen_Bh.Name = "LabTen_Bh"
        Me.LabTen_Bh.Size = New System.Drawing.Size(73, 13)
        Me.LabTen_Bh.TabIndex = 8
        Me.LabTen_Bh.Tag = "Name"
        Me.LabTen_Bh.Text = "Tên tiếp nhận"
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(275, 16)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(76, 17)
        Me.ChkNgam_Dinh.TabIndex = 11
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'CrmDmTiepNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(585, 108)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.TxtTen_Tiep_nhan)
        Me.Controls.Add(Me.LabTen_Bh)
        Me.Controls.Add(Me.TxtMa_Tiep_nhan)
        Me.Controls.Add(Me.LabMa_BH)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 100)
        Me.Name = "CrmDmTiepNhan"
        Me.Text = "Danh mục nguồn tiếp nhận"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Tiep_nhan, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tiep_nhan, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_BH As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Tiep_nhan As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Tiep_nhan As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh As System.Windows.Forms.Label
    Friend WithEvents ChkNgam_Dinh As Windows.Forms.CheckBox
End Class
