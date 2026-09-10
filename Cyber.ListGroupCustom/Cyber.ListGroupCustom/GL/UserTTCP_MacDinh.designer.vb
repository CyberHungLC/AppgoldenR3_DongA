<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserTTCP_MacDinh
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
        Me.LabMa_TTCP = New System.Windows.Forms.Label()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTCP = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_User = New System.Windows.Forms.TextBox()
        Me.TxtUser_Name = New Cyber.SmLists.TxtLookup()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(595, 103)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 103)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(387, 109)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 113)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 80)
        Me.GroupBoxLine.Size = New System.Drawing.Size(685, 8)
        '
        'LabMa_TTCP
        '
        Me.LabMa_TTCP.Location = New System.Drawing.Point(4, 12)
        Me.LabMa_TTCP.Name = "LabMa_TTCP"
        Me.LabMa_TTCP.Size = New System.Drawing.Size(100, 18)
        Me.LabMa_TTCP.TabIndex = 24
        Me.LabMa_TTCP.Tag = "Group 1"
        Me.LabMa_TTCP.Text = "Mã TTCP"
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.Color.White
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Enabled = False
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(262, 14)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(424, 14)
        Me.TxtTen_TTCP.TabIndex = 23
        Me.TxtTen_TTCP.TabStop = False
        '
        'TxtMa_TTCP
        '
        Me.TxtMa_TTCP._ActilookupPopup = False
        Me.TxtMa_TTCP.CyberActilookupPopup = True
        Me.TxtMa_TTCP.Dv_ListDetail = Nothing
        Me.TxtMa_TTCP.Dv_Master = Nothing
        Me.TxtMa_TTCP.FilterClient = ""
        Me.TxtMa_TTCP.FilterSQL = ""
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(109, 12)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_TTCP.TabIndex = 1
        Me.TxtMa_TTCP.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "User"
        '
        'TxtTen_User
        '
        Me.TxtTen_User.BackColor = System.Drawing.Color.White
        Me.TxtTen_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_User.Enabled = False
        Me.TxtTen_User.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_User.Location = New System.Drawing.Point(262, 40)
        Me.TxtTen_User.Name = "TxtTen_User"
        Me.TxtTen_User.ReadOnly = True
        Me.TxtTen_User.Size = New System.Drawing.Size(424, 14)
        Me.TxtTen_User.TabIndex = 26
        Me.TxtTen_User.TabStop = False
        '
        'TxtUser_Name
        '
        Me.TxtUser_Name._ActilookupPopup = False
        Me.TxtUser_Name.CyberActilookupPopup = True
        Me.TxtUser_Name.Dv_ListDetail = Nothing
        Me.TxtUser_Name.Dv_Master = Nothing
        Me.TxtUser_Name.FilterClient = ""
        Me.TxtUser_Name.FilterSQL = ""
        Me.TxtUser_Name.Location = New System.Drawing.Point(109, 38)
        Me.TxtUser_Name.Name = "TxtUser_Name"
        Me.TxtUser_Name.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser_Name.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUser_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtUser_Name.Size = New System.Drawing.Size(149, 20)
        Me.TxtUser_Name.TabIndex = 2
        Me.TxtUser_Name.Table_Name = ""
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.IsAllowResize = False
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(217, 113)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        Me.TxtNgay_HL.Visible = False
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(111, 113)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 17)
        Me.LabNgay_ban.TabIndex = 31
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        Me.LabNgay_ban.Visible = False
        '
        'UserTTCP_MacDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 142)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_User)
        Me.Controls.Add(Me.TxtUser_Name)
        Me.Controls.Add(Me.LabMa_TTCP)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "UserTTCP_MacDinh"
        Me.Text = "Danh mục người dùng TTCP"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_Name, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_User, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TTCP As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TTCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TTCP As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_User As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser_Name As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents LabNgay_ban As Windows.Forms.Label
End Class
