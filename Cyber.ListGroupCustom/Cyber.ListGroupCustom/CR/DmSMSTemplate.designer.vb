<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmSMSTemplate
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
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtMa_SMS = New System.Windows.Forms.TextBox()
        Me.TxtTen_SMS = New System.Windows.Forms.TextBox()
        Me.LabTen_kho = New System.Windows.Forms.Label()
        Me.TxtTen_SMS2 = New System.Windows.Forms.TextBox()
        Me.Labten_Kho2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_SMS1 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_SMS2 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_SMS3 = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_SMS4 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_SMS5 = New Cyber.SmLists.TxtLookup()
        Me.TxtND1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtND2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtND3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtND4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtND5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBody = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.TxtNh_SMS1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_SMS2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_SMS3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_SMS4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_SMS5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(823, 517)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 16
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(687, 517)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 15
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(545, 525)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.TabIndex = 17
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(125, 530)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 14
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 504)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(953, 13)
        Me.GroupBoxLine.TabIndex = 18
        '
        'LabMa_kho
        '
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(16, 160)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_kho.TabIndex = 24
        Me.LabMa_kho.Tag = "Code"
        Me.LabMa_kho.Text = "Mã SMS"
        '
        'TxtMa_SMS
        '
        Me.TxtMa_SMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_SMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_SMS.Location = New System.Drawing.Point(123, 154)
        Me.TxtMa_SMS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_SMS.Name = "TxtMa_SMS"
        Me.TxtMa_SMS.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_SMS.TabIndex = 5
        '
        'TxtTen_SMS
        '
        Me.TxtTen_SMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_SMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_SMS.Location = New System.Drawing.Point(123, 186)
        Me.TxtTen_SMS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_SMS.Name = "TxtTen_SMS"
        Me.TxtTen_SMS.Size = New System.Drawing.Size(819, 24)
        Me.TxtTen_SMS.TabIndex = 6
        '
        'LabTen_kho
        '
        Me.LabTen_kho.AutoSize = True
        Me.LabTen_kho.Location = New System.Drawing.Point(16, 191)
        Me.LabTen_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_kho.Name = "LabTen_kho"
        Me.LabTen_kho.Size = New System.Drawing.Size(61, 17)
        Me.LabTen_kho.TabIndex = 25
        Me.LabTen_kho.Tag = "Name"
        Me.LabTen_kho.Text = "Tên SMS"
        '
        'TxtTen_SMS2
        '
        Me.TxtTen_SMS2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_SMS2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_SMS2.Location = New System.Drawing.Point(123, 217)
        Me.TxtTen_SMS2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_SMS2.Name = "TxtTen_SMS2"
        Me.TxtTen_SMS2.Size = New System.Drawing.Size(819, 24)
        Me.TxtTen_SMS2.TabIndex = 7
        '
        'Labten_Kho2
        '
        Me.Labten_Kho2.AutoSize = True
        Me.Labten_Kho2.Location = New System.Drawing.Point(16, 222)
        Me.Labten_Kho2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_Kho2.Name = "Labten_Kho2"
        Me.Labten_Kho2.Size = New System.Drawing.Size(86, 17)
        Me.Labten_Kho2.TabIndex = 26
        Me.Labten_Kho2.Tag = "English name"
        Me.Labten_Kho2.Text = "Tên gọi khác"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.AutoSize = True
        Me.LabMa_Nh1.Location = New System.Drawing.Point(16, 9)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(57, 17)
        Me.LabMa_Nh1.TabIndex = 19
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(327, 8)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(616, 17)
        Me.TxtTen_Nh1.TabIndex = 33
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_SMS1
        '
        Me.TxtNh_SMS1._ActilookupPopup = False
        Me.TxtNh_SMS1.CyberActilookupPopup = True
        Me.TxtNh_SMS1.Dv_ListDetail = Nothing
        Me.TxtNh_SMS1.Dv_Master = Nothing
        Me.TxtNh_SMS1.FilterClient = ""
        Me.TxtNh_SMS1.FilterSQL = ""
        Me.TxtNh_SMS1.Location = New System.Drawing.Point(123, 4)
        Me.TxtNh_SMS1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_SMS1.Name = "TxtNh_SMS1"
        Me.TxtNh_SMS1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_SMS1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_SMS1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_SMS1.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_SMS1.TabIndex = 0
        Me.TxtNh_SMS1.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Nhóm 2"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(327, 38)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(616, 17)
        Me.TxtTen_Nh2.TabIndex = 34
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_SMS2
        '
        Me.TxtNh_SMS2._ActilookupPopup = False
        Me.TxtNh_SMS2.CyberActilookupPopup = True
        Me.TxtNh_SMS2.Dv_ListDetail = Nothing
        Me.TxtNh_SMS2.Dv_Master = Nothing
        Me.TxtNh_SMS2.FilterClient = ""
        Me.TxtNh_SMS2.FilterSQL = ""
        Me.TxtNh_SMS2.Location = New System.Drawing.Point(123, 34)
        Me.TxtNh_SMS2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_SMS2.Name = "TxtNh_SMS2"
        Me.TxtNh_SMS2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_SMS2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_SMS2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_SMS2.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_SMS2.TabIndex = 1
        Me.TxtNh_SMS2.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(327, 68)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(616, 17)
        Me.TxtTen_Nh3.TabIndex = 35
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_SMS3
        '
        Me.TxtNh_SMS3._ActilookupPopup = False
        Me.TxtNh_SMS3.CyberActilookupPopup = True
        Me.TxtNh_SMS3.Dv_ListDetail = Nothing
        Me.TxtNh_SMS3.Dv_Master = Nothing
        Me.TxtNh_SMS3.FilterClient = ""
        Me.TxtNh_SMS3.FilterSQL = ""
        Me.TxtNh_SMS3.Location = New System.Drawing.Point(123, 64)
        Me.TxtNh_SMS3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_SMS3.Name = "TxtNh_SMS3"
        Me.TxtNh_SMS3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_SMS3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_SMS3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_SMS3.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_SMS3.TabIndex = 2
        Me.TxtNh_SMS3.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Tag = "Group 4"
        Me.Label3.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(327, 98)
        Me.TxtTen_Nh4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(616, 17)
        Me.TxtTen_Nh4.TabIndex = 36
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_SMS4
        '
        Me.TxtNh_SMS4._ActilookupPopup = False
        Me.TxtNh_SMS4.CyberActilookupPopup = True
        Me.TxtNh_SMS4.Dv_ListDetail = Nothing
        Me.TxtNh_SMS4.Dv_Master = Nothing
        Me.TxtNh_SMS4.FilterClient = ""
        Me.TxtNh_SMS4.FilterSQL = ""
        Me.TxtNh_SMS4.Location = New System.Drawing.Point(123, 94)
        Me.TxtNh_SMS4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_SMS4.Name = "TxtNh_SMS4"
        Me.TxtNh_SMS4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_SMS4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_SMS4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_SMS4.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_SMS4.TabIndex = 3
        Me.TxtNh_SMS4.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Tag = "Group 5"
        Me.Label4.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(327, 128)
        Me.TxtTen_Nh5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(616, 17)
        Me.TxtTen_Nh5.TabIndex = 37
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_SMS5
        '
        Me.TxtNh_SMS5._ActilookupPopup = False
        Me.TxtNh_SMS5.CyberActilookupPopup = True
        Me.TxtNh_SMS5.Dv_ListDetail = Nothing
        Me.TxtNh_SMS5.Dv_Master = Nothing
        Me.TxtNh_SMS5.FilterClient = ""
        Me.TxtNh_SMS5.FilterSQL = ""
        Me.TxtNh_SMS5.Location = New System.Drawing.Point(123, 124)
        Me.TxtNh_SMS5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_SMS5.Name = "TxtNh_SMS5"
        Me.TxtNh_SMS5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_SMS5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_SMS5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_SMS5.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_SMS5.TabIndex = 4
        Me.TxtNh_SMS5.Table_Name = ""
        '
        'TxtND1
        '
        Me.TxtND1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtND1.ForeColor = System.Drawing.Color.Navy
        Me.TxtND1.Location = New System.Drawing.Point(123, 248)
        Me.TxtND1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtND1.Name = "TxtND1"
        Me.TxtND1.Size = New System.Drawing.Size(819, 24)
        Me.TxtND1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 254)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Begin"
        '
        'TxtND2
        '
        Me.TxtND2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtND2.ForeColor = System.Drawing.Color.Navy
        Me.TxtND2.Location = New System.Drawing.Point(123, 280)
        Me.TxtND2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtND2.Name = "TxtND2"
        Me.TxtND2.Size = New System.Drawing.Size(819, 24)
        Me.TxtND2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 285)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Tag = "English name"
        Me.Label6.Text = "Part 1"
        '
        'TxtND3
        '
        Me.TxtND3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtND3.ForeColor = System.Drawing.Color.Navy
        Me.TxtND3.Location = New System.Drawing.Point(123, 311)
        Me.TxtND3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtND3.Name = "TxtND3"
        Me.TxtND3.Size = New System.Drawing.Size(819, 24)
        Me.TxtND3.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 316)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Tag = "English name"
        Me.Label7.Text = "Part 2"
        '
        'TxtND4
        '
        Me.TxtND4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtND4.ForeColor = System.Drawing.Color.Navy
        Me.TxtND4.Location = New System.Drawing.Point(123, 343)
        Me.TxtND4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtND4.Name = "TxtND4"
        Me.TxtND4.Size = New System.Drawing.Size(819, 24)
        Me.TxtND4.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 348)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Tag = "English name"
        Me.Label8.Text = "Part 3"
        '
        'TxtND5
        '
        Me.TxtND5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtND5.ForeColor = System.Drawing.Color.Navy
        Me.TxtND5.Location = New System.Drawing.Point(123, 480)
        Me.TxtND5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtND5.Name = "TxtND5"
        Me.TxtND5.Size = New System.Drawing.Size(819, 24)
        Me.TxtND5.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 485)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Tag = "English name"
        Me.Label9.Text = "End"
        '
        'TxtBody
        '
        Me.TxtBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBody.ForeColor = System.Drawing.Color.Navy
        Me.TxtBody.Location = New System.Drawing.Point(123, 377)
        Me.TxtBody.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.Size = New System.Drawing.Size(819, 97)
        Me.TxtBody.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 377)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Tag = "English name"
        Me.Label10.Text = "Body"
        '
        'DmSMSTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(959, 559)
        Me.Controls.Add(Me.TxtBody)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtND5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtND4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtND3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtND2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtND1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_SMS5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_SMS4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_SMS3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_SMS2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_SMS1)
        Me.Controls.Add(Me.TxtTen_SMS2)
        Me.Controls.Add(Me.Labten_Kho2)
        Me.Controls.Add(Me.TxtTen_SMS)
        Me.Controls.Add(Me.LabTen_kho)
        Me.Controls.Add(Me.TxtMa_SMS)
        Me.Controls.Add(Me.LabMa_kho)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(646, 220)
        Me.Name = "DmSMSTemplate"
        Me.Text = "Danh mục mẫu tin nhắn khách hàng"
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_SMS, 0)
        Me.Controls.SetChildIndex(Me.LabTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_SMS, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kho2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_SMS2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_SMS1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_SMS2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_SMS3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_SMS4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_SMS5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtND1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtND2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtND3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtND4, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtND5, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtBody, 0)
        CType(Me.TxtNh_SMS1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_SMS2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_SMS3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_SMS4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_SMS5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtMa_SMS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_SMS As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_SMS2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_Kho2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_SMS1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_SMS2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_SMS3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_SMS4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_SMS5 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtND1 As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtND2 As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtND3 As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtND4 As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtND5 As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtBody As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
End Class
