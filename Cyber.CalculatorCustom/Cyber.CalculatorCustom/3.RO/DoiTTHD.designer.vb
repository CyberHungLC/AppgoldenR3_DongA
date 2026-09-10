<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoiTTHD
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
        Me.CmdFilter = New System.Windows.Forms.Button()
        Me.TxtMa_Hd = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hd = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hd_New = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hd_New = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Hd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hd_New.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 225)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 237)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 5
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 237)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 6
        '
        'CmbbMa_CT
        '
        Me.CmbbMa_CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_CT.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_CT.FormattingEnabled = True
        Me.CmbbMa_CT.Location = New System.Drawing.Point(153, 7)
        Me.CmbbMa_CT.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbbMa_CT.Name = "CmbbMa_CT"
        Me.CmbbMa_CT.Size = New System.Drawing.Size(252, 24)
        Me.CmbbMa_CT.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.Location = New System.Drawing.Point(4, 7)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(129, 22)
        Me.LabM_month1.TabIndex = 504
        Me.LabM_month1.Tag = "Type"
        Me.LabM_month1.Text = "Loại lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(153, 38)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(252, 22)
        Me.TxtSo_Ro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 532
        Me.Label1.Tag = "R/O"
        Me.Label1.Text = "Lệnh số"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 534
        Me.Label2.Tag = "Explain"
        Me.Label2.Text = "Diễn giải"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(153, 69)
        Me.TxtDien_Giai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(608, 83)
        Me.TxtDien_Giai.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 22)
        Me.Label3.TabIndex = 536
        Me.Label3.Tag = "Current level"
        Me.Label3.Text = "Hợp đồng"
        '
        'CmdFilter
        '
        Me.CmdFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFilter.ForeColor = System.Drawing.Color.Red
        Me.CmdFilter.Location = New System.Drawing.Point(447, 34)
        Me.CmdFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdFilter.Name = "CmdFilter"
        Me.CmdFilter.Size = New System.Drawing.Size(109, 28)
        Me.CmdFilter.TabIndex = 539
        Me.CmdFilter.Text = "Xem lệnh"
        Me.CmdFilter.UseVisualStyleBackColor = True
        '
        'TxtMa_Hd
        '
        Me.TxtMa_Hd._ActilookupPopup = False
        Me.TxtMa_Hd.CyberActilookupPopup = True
        Me.TxtMa_Hd.Dv_ListDetail = Nothing
        Me.TxtMa_Hd.Dv_Master = Nothing
        Me.TxtMa_Hd.FilterClient = ""
        Me.TxtMa_Hd.FilterSQL = ""
        Me.TxtMa_Hd.Location = New System.Drawing.Point(153, 158)
        Me.TxtMa_Hd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Hd.Name = "TxtMa_Hd"
        Me.TxtMa_Hd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hd.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hd.Size = New System.Drawing.Size(252, 22)
        Me.TxtMa_Hd.TabIndex = 1831
        Me.TxtMa_Hd.Table_Name = ""
        '
        'TxtTen_Hd
        '
        Me.TxtTen_Hd.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hd.Enabled = False
        Me.TxtTen_Hd.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hd.Location = New System.Drawing.Point(413, 161)
        Me.TxtTen_Hd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Hd.Name = "TxtTen_Hd"
        Me.TxtTen_Hd.ReadOnly = True
        Me.TxtTen_Hd.Size = New System.Drawing.Size(339, 15)
        Me.TxtTen_Hd.TabIndex = 1832
        Me.TxtTen_Hd.TabStop = False
        '
        'TxtMa_Hd_New
        '
        Me.TxtMa_Hd_New._ActilookupPopup = False
        Me.TxtMa_Hd_New.CyberActilookupPopup = True
        Me.TxtMa_Hd_New.Dv_ListDetail = Nothing
        Me.TxtMa_Hd_New.Dv_Master = Nothing
        Me.TxtMa_Hd_New.FilterClient = ""
        Me.TxtMa_Hd_New.FilterSQL = ""
        Me.TxtMa_Hd_New.Location = New System.Drawing.Point(153, 188)
        Me.TxtMa_Hd_New.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Hd_New.Name = "TxtMa_Hd_New"
        Me.TxtMa_Hd_New.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hd_New.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hd_New.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hd_New.Size = New System.Drawing.Size(252, 22)
        Me.TxtMa_Hd_New.TabIndex = 1834
        Me.TxtMa_Hd_New.Table_Name = ""
        '
        'TxtTen_Hd_New
        '
        Me.TxtTen_Hd_New.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hd_New.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hd_New.Enabled = False
        Me.TxtTen_Hd_New.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hd_New.Location = New System.Drawing.Point(413, 191)
        Me.TxtTen_Hd_New.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Hd_New.Name = "TxtTen_Hd_New"
        Me.TxtTen_Hd_New.ReadOnly = True
        Me.TxtTen_Hd_New.Size = New System.Drawing.Size(339, 15)
        Me.TxtTen_Hd_New.TabIndex = 1835
        Me.TxtTen_Hd_New.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 1833
        Me.Label4.Tag = "Current level"
        Me.Label4.Text = "Hợp đồng mới"
        '
        'DoiTTHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 304)
        Me.Controls.Add(Me.TxtMa_Hd_New)
        Me.Controls.Add(Me.TxtTen_Hd_New)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_Hd)
        Me.Controls.Add(Me.TxtTen_Hd)
        Me.Controls.Add(Me.CmdFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.CmbbMa_CT)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DoiTTHD"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_CT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CmdFilter, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hd, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hd, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hd_New, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hd_New, 0)
        CType(Me.TxtMa_Hd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hd_New.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CmdFilter As System.Windows.Forms.Button
    Friend WithEvents TxtMa_Hd As SmLists.TxtLookup
    Friend WithEvents TxtTen_Hd As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hd_New As SmLists.TxtLookup
    Friend WithEvents TxtTen_Hd_New As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
