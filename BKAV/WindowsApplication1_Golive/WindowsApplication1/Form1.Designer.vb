<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTaoHoaDon = New System.Windows.Forms.Button()
        Me.btnPhatHanh = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTaoHoaDon
        '
        Me.btnTaoHoaDon.Location = New System.Drawing.Point(93, 54)
        Me.btnTaoHoaDon.Name = "btnTaoHoaDon"
        Me.btnTaoHoaDon.Size = New System.Drawing.Size(320, 23)
        Me.btnTaoHoaDon.TabIndex = 0
        Me.btnTaoHoaDon.Text = "Tạo hóa đơn"
        Me.btnTaoHoaDon.UseVisualStyleBackColor = True
        '
        'btnPhatHanh
        '
        Me.btnPhatHanh.Location = New System.Drawing.Point(93, 131)
        Me.btnPhatHanh.Name = "btnPhatHanh"
        Me.btnPhatHanh.Size = New System.Drawing.Size(320, 23)
        Me.btnPhatHanh.TabIndex = 1
        Me.btnPhatHanh.Text = "Tạo hóa đơn và phát hành"
        Me.btnPhatHanh.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(93, 224)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(320, 23)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "View hóa đơn"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 422)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPhatHanh)
        Me.Controls.Add(Me.btnTaoHoaDon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTaoHoaDon As System.Windows.Forms.Button
    Friend WithEvents btnPhatHanh As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button

End Class
