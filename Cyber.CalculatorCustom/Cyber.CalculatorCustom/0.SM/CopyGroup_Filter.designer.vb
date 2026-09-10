<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyGroup_Filter
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGoup = New Cyber.SmLists.TxtLookup()
        Me.CbbMa_Dvcs = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        CType(Me.TxtGoup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 87)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(389, 96)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(491, 96)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 510
        Me.Label4.Tag = "Model"
        Me.Label4.Text = "Group"
        '
        'TxtGoup
        '
        Me.TxtGoup._ActilookupPopup = False
        Me.TxtGoup.CyberActilookupPopup = True
        Me.TxtGoup.Dv_ListDetail = Nothing
        Me.TxtGoup.Dv_Master = Nothing
        Me.TxtGoup.FilterClient = ""
        Me.TxtGoup.FilterSQL = ""
        Me.TxtGoup.Location = New System.Drawing.Point(84, 22)
        Me.TxtGoup.Name = "TxtGoup"
        Me.TxtGoup.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtGoup.Properties.Appearance.Options.UseForeColor = True
        Me.TxtGoup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtGoup.Size = New System.Drawing.Size(104, 20)
        Me.TxtGoup.TabIndex = 3
        Me.TxtGoup.Table_Name = ""
        '
        'CbbMa_Dvcs
        '
        Me.CbbMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Dvcs.FormattingEnabled = True
        Me.CbbMa_Dvcs.Location = New System.Drawing.Point(84, 46)
        Me.CbbMa_Dvcs.Name = "CbbMa_Dvcs"
        Me.CbbMa_Dvcs.Size = New System.Drawing.Size(482, 23)
        Me.CbbMa_Dvcs.TabIndex = 511
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(6, 50)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 15)
        Me.Label14.TabIndex = 512
        Me.Label14.Tag = "Units"
        Me.Label14.Text = "Đơn vị"
        '
        'TxtComment
        '
        Me.TxtComment.BackColor = System.Drawing.Color.White
        Me.TxtComment.Enabled = False
        Me.TxtComment.ForeColor = System.Drawing.Color.Navy
        Me.TxtComment.Location = New System.Drawing.Point(194, 22)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.ReadOnly = True
        Me.TxtComment.Size = New System.Drawing.Size(372, 20)
        Me.TxtComment.TabIndex = 517
        Me.TxtComment.TabStop = False
        '
        'CoppyGroup_Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(593, 150)
        Me.Controls.Add(Me.TxtComment)
        Me.Controls.Add(Me.CbbMa_Dvcs)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGoup)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CoppyGroup_Filter"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtGoup, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtComment, 0)
        CType(Me.TxtGoup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGoup As Cyber.SmLists.TxtLookup
    Friend WithEvents CbbMa_Dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtComment As System.Windows.Forms.TextBox

End Class
