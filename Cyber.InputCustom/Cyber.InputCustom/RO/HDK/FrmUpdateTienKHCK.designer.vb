<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateTienKHCK
    Inherits Cyber.From.FrmCalculator

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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTien_KH_CK = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 51)
        Me.GroupBoxLine.Size = New System.Drawing.Size(481, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(281, 61)
        Me.ButtOK.TabIndex = 1
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(383, 61)
        Me.ButtExit.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(12, 23)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 15)
        Me.Label16.TabIndex = 1976
        Me.Label16.Tag = "Hãng"
        Me.Label16.Text = "Tiền KH chuyển khoản"
        '
        'TxtTien_KH_CK
        '
        Me.TxtTien_KH_CK.AllowNegative = True
        Me.TxtTien_KH_CK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_KH_CK.BackColor = System.Drawing.Color.White
        Me.TxtTien_KH_CK.Flags = 7680
        Me.TxtTien_KH_CK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_KH_CK.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_KH_CK.Location = New System.Drawing.Point(192, 18)
        Me.TxtTien_KH_CK.MaxWholeDigits = 16
        Me.TxtTien_KH_CK.Name = "TxtTien_KH_CK"
        Me.TxtTien_KH_CK.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_KH_CK.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_KH_CK.ReadOnly = True
        Me.TxtTien_KH_CK.Size = New System.Drawing.Size(119, 20)
        Me.TxtTien_KH_CK.TabIndex = 2220
        Me.TxtTien_KH_CK.Text = "1.0"
        Me.TxtTien_KH_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmUpdateTienKHCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(485, 115)
        Me.Controls.Add(Me.TxtTien_KH_CK)
        Me.Controls.Add(Me.Label16)
        Me.Name = "FrmUpdateTienKHCK"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_KH_CK, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_KH_CK As ClsTextBox.txtTien_NT

End Class
