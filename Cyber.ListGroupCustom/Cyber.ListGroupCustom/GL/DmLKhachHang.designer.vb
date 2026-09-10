<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmLKhachHang
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
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.TxtMa_LoaiKH = New System.Windows.Forms.TextBox()
        Me.TxtTen_LoaiKH = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtTen_LoaiKH2 = New System.Windows.Forms.TextBox()
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
        Me.LabMa_Bp.Size = New System.Drawing.Size(40, 13)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã loại"
        '
        'TxtMa_LoaiKH
        '
        Me.TxtMa_LoaiKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_LoaiKH.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LoaiKH.Location = New System.Drawing.Point(81, 3)
        Me.TxtMa_LoaiKH.Name = "TxtMa_LoaiKH"
        Me.TxtMa_LoaiKH.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_LoaiKH.TabIndex = 0
        '
        'TxtTen_LoaiKH
        '
        Me.TxtTen_LoaiKH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LoaiKH.Location = New System.Drawing.Point(81, 26)
        Me.TxtTen_LoaiKH.Name = "TxtTen_LoaiKH"
        Me.TxtTen_LoaiKH.Size = New System.Drawing.Size(557, 21)
        Me.TxtTen_LoaiKH.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.AutoSize = True
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(44, 13)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên loại"
        '
        'TxtTen_LoaiKH2
        '
        Me.TxtTen_LoaiKH2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LoaiKH2.Location = New System.Drawing.Point(81, 49)
        Me.TxtTen_LoaiKH2.Name = "TxtTen_LoaiKH2"
        Me.TxtTen_LoaiKH2.Size = New System.Drawing.Size(557, 21)
        Me.TxtTen_LoaiKH2.TabIndex = 2
        '
        'LabTen_BP2
        '
        Me.LabTen_BP2.AutoSize = True
        Me.LabTen_BP2.Location = New System.Drawing.Point(5, 53)
        Me.LabTen_BP2.Name = "LabTen_BP2"
        Me.LabTen_BP2.Size = New System.Drawing.Size(53, 13)
        Me.LabTen_BP2.TabIndex = 14
        Me.LabTen_BP2.Tag = "English name"
        Me.LabTen_BP2.Text = "Tên loại 2"
        '
        'DmLKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 136)
        Me.Controls.Add(Me.TxtTen_LoaiKH2)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.TxtTen_LoaiKH)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.TxtMa_LoaiKH)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(488, 118)
        Me.Name = "DmLKhachHang"
        Me.Text = "Danh mục loại khách hàng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LoaiKH, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LoaiKH, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LoaiKH2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtMa_LoaiKH As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_LoaiKH As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtTen_LoaiKH2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label

End Class
