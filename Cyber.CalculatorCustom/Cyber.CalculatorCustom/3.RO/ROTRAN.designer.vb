<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ROTRAN
    Inherits Cyber.From.FrmCalculator

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
        Me.CmbbMa_CT = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbbMa_PostOld = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbbMa_PostNew = New System.Windows.Forms.ComboBox()
        Me.CmdFilter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 202)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(570, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(370, 212)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 5
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(472, 212)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 6
        '
        'CmbbMa_CT
        '
        Me.CmbbMa_CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_CT.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_CT.FormattingEnabled = True
        Me.CmbbMa_CT.Location = New System.Drawing.Point(115, 6)
        Me.CmbbMa_CT.Name = "CmbbMa_CT"
        Me.CmbbMa_CT.Size = New System.Drawing.Size(279, 21)
        Me.CmbbMa_CT.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.Location = New System.Drawing.Point(3, 6)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(97, 18)
        Me.LabM_month1.TabIndex = 504
        Me.LabM_month1.Tag = "Type"
        Me.LabM_month1.Text = "Loại lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(115, 54)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(279, 20)
        Me.TxtSo_Ro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 532
        Me.Label1.Tag = "R/O"
        Me.Label1.Text = "Lệnh số"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 534
        Me.Label2.Tag = "Explain"
        Me.Label2.Text = "Diễn giải"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(115, 79)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(457, 68)
        Me.TxtDien_Giai.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 536
        Me.Label3.Tag = "Current level"
        Me.Label3.Text = "Mức hiện tại"
        '
        'CmbbMa_PostOld
        '
        Me.CmbbMa_PostOld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_PostOld.Enabled = False
        Me.CmbbMa_PostOld.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_PostOld.FormattingEnabled = True
        Me.CmbbMa_PostOld.Location = New System.Drawing.Point(115, 151)
        Me.CmbbMa_PostOld.Name = "CmbbMa_PostOld"
        Me.CmbbMa_PostOld.Size = New System.Drawing.Size(279, 21)
        Me.CmbbMa_PostOld.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 538
        Me.Label4.Tag = "Level to"
        Me.Label4.Text = "Loại Chuyển về mức"
        '
        'CmbbMa_PostNew
        '
        Me.CmbbMa_PostNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_PostNew.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_PostNew.FormattingEnabled = True
        Me.CmbbMa_PostNew.Location = New System.Drawing.Point(115, 176)
        Me.CmbbMa_PostNew.Name = "CmbbMa_PostNew"
        Me.CmbbMa_PostNew.Size = New System.Drawing.Size(279, 21)
        Me.CmbbMa_PostNew.TabIndex = 4
        '
        'CmdFilter
        '
        Me.CmdFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFilter.ForeColor = System.Drawing.Color.Red
        Me.CmdFilter.Location = New System.Drawing.Point(412, 52)
        Me.CmdFilter.Name = "CmdFilter"
        Me.CmdFilter.Size = New System.Drawing.Size(82, 23)
        Me.CmdFilter.TabIndex = 539
        Me.CmdFilter.Text = "Xem lệnh"
        Me.CmdFilter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 543
        Me.Label5.Tag = "Type"
        Me.Label5.Text = "Xưởng DV"
        '
        'CbbMa_TTCP
        '
        Me.CbbMa_TTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP.FormattingEnabled = True
        Me.CbbMa_TTCP.Location = New System.Drawing.Point(115, 30)
        Me.CbbMa_TTCP.Name = "CbbMa_TTCP"
        Me.CbbMa_TTCP.Size = New System.Drawing.Size(279, 21)
        Me.CbbMa_TTCP.TabIndex = 542
        '
        'ROTRAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 266)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_TTCP)
        Me.Controls.Add(Me.CmdFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbbMa_PostNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbbMa_PostOld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.CmbbMa_CT)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ROTRAN"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_CT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_PostOld, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_PostNew, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CmdFilter, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbbMa_CT As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbbMa_PostOld As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbbMa_PostNew As System.Windows.Forms.ComboBox
    Friend WithEvents CmdFilter As System.Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP As Windows.Forms.ComboBox
End Class
