<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintVT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrintVT))
        Me.Rad12 = New System.Windows.Forms.RadioButton()
        Me.Rad11 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbMa_In = New System.Windows.Forms.ComboBox()
        Me.CmdEditReport = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 72)
        Me.GroupBoxLine.Size = New System.Drawing.Size(471, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(271, 82)
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(373, 82)
        '
        'Rad12
        '
        Me.Rad12.AutoSize = True
        Me.Rad12.Location = New System.Drawing.Point(221, 48)
        Me.Rad12.Name = "Rad12"
        Me.Rad12.Size = New System.Drawing.Size(72, 17)
        Me.Rad12.TabIndex = 46
        Me.Rad12.TabStop = True
        Me.Rad12.Tag = "Preview"
        Me.Rad12.Text = "&Xem và in"
        Me.Rad12.UseVisualStyleBackColor = True
        '
        'Rad11
        '
        Me.Rad11.AutoSize = True
        Me.Rad11.Location = New System.Drawing.Point(123, 48)
        Me.Rad11.Name = "Rad11"
        Me.Rad11.Size = New System.Drawing.Size(57, 17)
        Me.Rad11.TabIndex = 45
        Me.Rad11.TabStop = True
        Me.Rad11.Tag = "Print"
        Me.Rad11.Text = "&Máy In"
        Me.Rad11.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(46, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 364
        Me.Label7.Tag = "Group 2"
        Me.Label7.Text = "Mẫu In"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbMa_In
        '
        Me.CmbMa_In.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_In.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_In.FormattingEnabled = True
        Me.CmbMa_In.Location = New System.Drawing.Point(124, 12)
        Me.CmbMa_In.Name = "CmbMa_In"
        Me.CmbMa_In.Size = New System.Drawing.Size(346, 21)
        Me.CmbMa_In.TabIndex = 363
        '
        'CmdEditReport
        '
        Me.CmdEditReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdEditReport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEditReport.Appearance.Options.UseForeColor = True
        Me.CmdEditReport.Image = CType(resources.GetObject("CmdEditReport.Image"), System.Drawing.Image)
        Me.CmdEditReport.Location = New System.Drawing.Point(3, 81)
        Me.CmdEditReport.Name = "CmdEditReport"
        Me.CmdEditReport.Size = New System.Drawing.Size(100, 30)
        Me.CmdEditReport.TabIndex = 365
        Me.CmdEditReport.Tag = "&Edit"
        Me.CmdEditReport.Text = "&Sữa mẫu"
        '
        'BEDMHD_IN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(475, 136)
        Me.Controls.Add(Me.CmdEditReport)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbMa_In)
        Me.Controls.Add(Me.Rad12)
        Me.Controls.Add(Me.Rad11)
        Me.Name = "BEDMHD_IN"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Rad11, 0)
        Me.Controls.SetChildIndex(Me.Rad12, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_In, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CmdEditReport, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rad12 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad11 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_In As System.Windows.Forms.ComboBox
    Friend WithEvents CmdEditReport As DevExpress.XtraEditors.SimpleButton

End Class
