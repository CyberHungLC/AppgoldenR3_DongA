<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAKKCTTS
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtMa_CTTS = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_CTTS = New System.Windows.Forms.TextBox()
        Me.TxtNh_CTTS4 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_CTTS4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_CTTS3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CTTS3 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_CTTS2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CTTS2 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_CTTS1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CTTS1 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_CTTS5 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_CTTS5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkTon = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_CTTS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CTTS4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CTTS3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CTTS2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CTTS1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CTTS5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 307)
        Me.ButtExit.TabIndex = 15
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 268)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 271)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 307)
        Me.ButtOK.TabIndex = 14
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 246)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 246)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 247)
        Me.ChkNT.TabIndex = 12
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 4)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 26)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 29)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 290)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(9, 51)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(71, 13)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Mã chi tiết TS"
        '
        'TxtMa_CTTS
        '
        Me.TxtMa_CTTS._ActilookupPopup = False
        Me.TxtMa_CTTS.CyberActilookupPopup = True
        Me.TxtMa_CTTS.Dv_ListDetail = Nothing
        Me.TxtMa_CTTS.Dv_Master = Nothing
        Me.TxtMa_CTTS.FilterClient = ""
        Me.TxtMa_CTTS.FilterSQL = ""
        Me.TxtMa_CTTS.Location = New System.Drawing.Point(95, 48)
        Me.TxtMa_CTTS.Name = "TxtMa_CTTS"
        Me.TxtMa_CTTS.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_CTTS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CTTS.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_CTTS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CTTS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CTTS.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_CTTS.TabIndex = 2
        Me.TxtMa_CTTS.Table_Name = ""
        '
        'TxtTen_CTTS
        '
        Me.TxtTen_CTTS.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_CTTS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_CTTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_CTTS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CTTS.Location = New System.Drawing.Point(211, 52)
        Me.TxtTen_CTTS.Name = "TxtTen_CTTS"
        Me.TxtTen_CTTS.ReadOnly = True
        Me.TxtTen_CTTS.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_CTTS.TabIndex = 144
        Me.TxtTen_CTTS.TabStop = False
        '
        'TxtNh_CTTS4
        '
        Me.TxtNh_CTTS4._ActilookupPopup = False
        Me.TxtNh_CTTS4.CyberActilookupPopup = True
        Me.TxtNh_CTTS4.Dv_ListDetail = Nothing
        Me.TxtNh_CTTS4.Dv_Master = Nothing
        Me.TxtNh_CTTS4.FilterClient = ""
        Me.TxtNh_CTTS4.FilterSQL = ""
        Me.TxtNh_CTTS4.Location = New System.Drawing.Point(95, 132)
        Me.TxtNh_CTTS4.Name = "TxtNh_CTTS4"
        Me.TxtNh_CTTS4.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_CTTS4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CTTS4.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_CTTS4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CTTS4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CTTS4.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CTTS4.TabIndex = 6
        Me.TxtNh_CTTS4.Table_Name = ""
        '
        'TxtTen_Nh_CTTS4
        '
        Me.TxtTen_Nh_CTTS4.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_CTTS4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_CTTS4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_CTTS4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_CTTS4.Location = New System.Drawing.Point(211, 136)
        Me.TxtTen_Nh_CTTS4.Name = "TxtTen_Nh_CTTS4"
        Me.TxtTen_Nh_CTTS4.ReadOnly = True
        Me.TxtTen_Nh_CTTS4.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Nh_CTTS4.TabIndex = 148
        Me.TxtTen_Nh_CTTS4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Nhóm CTTS4"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 157
        Me.Label3.Tag = "Group 3"
        Me.Label3.Text = "Nhóm CTTS3"
        '
        'TxtTen_Nh_CTTS3
        '
        Me.TxtTen_Nh_CTTS3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_CTTS3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_CTTS3.Enabled = False
        Me.TxtTen_Nh_CTTS3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_CTTS3.Location = New System.Drawing.Point(211, 114)
        Me.TxtTen_Nh_CTTS3.Name = "TxtTen_Nh_CTTS3"
        Me.TxtTen_Nh_CTTS3.ReadOnly = True
        Me.TxtTen_Nh_CTTS3.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_Nh_CTTS3.TabIndex = 156
        Me.TxtTen_Nh_CTTS3.TabStop = False
        '
        'TxtNh_CTTS3
        '
        Me.TxtNh_CTTS3._ActilookupPopup = False
        Me.TxtNh_CTTS3.CyberActilookupPopup = True
        Me.TxtNh_CTTS3.Dv_ListDetail = Nothing
        Me.TxtNh_CTTS3.Dv_Master = Nothing
        Me.TxtNh_CTTS3.FilterClient = ""
        Me.TxtNh_CTTS3.FilterSQL = ""
        Me.TxtNh_CTTS3.Location = New System.Drawing.Point(95, 111)
        Me.TxtNh_CTTS3.Name = "TxtNh_CTTS3"
        Me.TxtNh_CTTS3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CTTS3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CTTS3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CTTS3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CTTS3.TabIndex = 5
        Me.TxtNh_CTTS3.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 155
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Nhóm CTTS2"
        '
        'TxtTen_Nh_CTTS2
        '
        Me.TxtTen_Nh_CTTS2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_CTTS2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_CTTS2.Enabled = False
        Me.TxtTen_Nh_CTTS2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_CTTS2.Location = New System.Drawing.Point(211, 93)
        Me.TxtTen_Nh_CTTS2.Name = "TxtTen_Nh_CTTS2"
        Me.TxtTen_Nh_CTTS2.ReadOnly = True
        Me.TxtTen_Nh_CTTS2.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_Nh_CTTS2.TabIndex = 154
        Me.TxtTen_Nh_CTTS2.TabStop = False
        '
        'TxtNh_CTTS2
        '
        Me.TxtNh_CTTS2._ActilookupPopup = False
        Me.TxtNh_CTTS2.CyberActilookupPopup = True
        Me.TxtNh_CTTS2.Dv_ListDetail = Nothing
        Me.TxtNh_CTTS2.Dv_Master = Nothing
        Me.TxtNh_CTTS2.FilterClient = ""
        Me.TxtNh_CTTS2.FilterSQL = ""
        Me.TxtNh_CTTS2.Location = New System.Drawing.Point(95, 90)
        Me.TxtNh_CTTS2.Name = "TxtNh_CTTS2"
        Me.TxtNh_CTTS2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CTTS2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CTTS2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CTTS2.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CTTS2.TabIndex = 4
        Me.TxtNh_CTTS2.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(9, 72)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(70, 14)
        Me.LabMa_Nh1.TabIndex = 153
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm CTTS1"
        '
        'TxtTen_Nh_CTTS1
        '
        Me.TxtTen_Nh_CTTS1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_CTTS1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_CTTS1.Enabled = False
        Me.TxtTen_Nh_CTTS1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_CTTS1.Location = New System.Drawing.Point(211, 72)
        Me.TxtTen_Nh_CTTS1.Name = "TxtTen_Nh_CTTS1"
        Me.TxtTen_Nh_CTTS1.ReadOnly = True
        Me.TxtTen_Nh_CTTS1.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_Nh_CTTS1.TabIndex = 152
        Me.TxtTen_Nh_CTTS1.TabStop = False
        '
        'TxtNh_CTTS1
        '
        Me.TxtNh_CTTS1._ActilookupPopup = False
        Me.TxtNh_CTTS1.CyberActilookupPopup = True
        Me.TxtNh_CTTS1.Dv_ListDetail = Nothing
        Me.TxtNh_CTTS1.Dv_Master = Nothing
        Me.TxtNh_CTTS1.FilterClient = ""
        Me.TxtNh_CTTS1.FilterSQL = ""
        Me.TxtNh_CTTS1.Location = New System.Drawing.Point(95, 69)
        Me.TxtNh_CTTS1.Name = "TxtNh_CTTS1"
        Me.TxtNh_CTTS1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CTTS1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CTTS1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CTTS1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CTTS1.TabIndex = 3
        Me.TxtNh_CTTS1.Table_Name = ""
        '
        'TxtNh_CTTS5
        '
        Me.TxtNh_CTTS5._ActilookupPopup = False
        Me.TxtNh_CTTS5.CyberActilookupPopup = True
        Me.TxtNh_CTTS5.Dv_ListDetail = Nothing
        Me.TxtNh_CTTS5.Dv_Master = Nothing
        Me.TxtNh_CTTS5.FilterClient = ""
        Me.TxtNh_CTTS5.FilterSQL = ""
        Me.TxtNh_CTTS5.Location = New System.Drawing.Point(95, 153)
        Me.TxtNh_CTTS5.Name = "TxtNh_CTTS5"
        Me.TxtNh_CTTS5.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_CTTS5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CTTS5.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_CTTS5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CTTS5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CTTS5.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CTTS5.TabIndex = 7
        Me.TxtNh_CTTS5.Table_Name = ""
        '
        'TxtTen_Nh_CTTS5
        '
        Me.TxtTen_Nh_CTTS5.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_CTTS5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_CTTS5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh_CTTS5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_CTTS5.Location = New System.Drawing.Point(211, 157)
        Me.TxtTen_Nh_CTTS5.Name = "TxtTen_Nh_CTTS5"
        Me.TxtTen_Nh_CTTS5.ReadOnly = True
        Me.TxtTen_Nh_CTTS5.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Nh_CTTS5.TabIndex = 387
        Me.TxtTen_Nh_CTTS5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 386
        Me.Label5.Tag = "Customer"
        Me.Label5.Text = "Nhóm CTTS5"
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(95, 174)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_BP.TabIndex = 8
        Me.TxtMa_BP.Table_Name = ""
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(211, 178)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_BP.TabIndex = 393
        Me.TxtTen_BP.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 392
        Me.Label7.Tag = "Account"
        Me.Label7.Text = "Bộ phận"
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(95, 195)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 9
        Me.TxtMa_Hs.Table_Name = ""
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(211, 199)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(382, 13)
        Me.TxtTen_Hs.TabIndex = 396
        Me.TxtTen_Hs.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 395
        Me.Label8.Tag = "Account"
        Me.Label8.Text = "Nhân viên"
        '
        'ChkTon
        '
        Me.ChkTon.AutoSize = True
        Me.ChkTon.Location = New System.Drawing.Point(95, 222)
        Me.ChkTon.Name = "ChkTon"
        Me.ChkTon.Size = New System.Drawing.Size(136, 17)
        Me.ChkTon.TabIndex = 10
        Me.ChkTon.Text = "Hiển thị tài sản còn tồn"
        Me.ChkTon.UseVisualStyleBackColor = True
        '
        'FAKKCTTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 360)
        Me.Controls.Add(Me.ChkTon)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNh_CTTS5)
        Me.Controls.Add(Me.TxtTen_Nh_CTTS5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh_CTTS3)
        Me.Controls.Add(Me.TxtNh_CTTS3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh_CTTS2)
        Me.Controls.Add(Me.TxtNh_CTTS2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh_CTTS1)
        Me.Controls.Add(Me.TxtNh_CTTS1)
        Me.Controls.Add(Me.TxtNh_CTTS4)
        Me.Controls.Add(Me.TxtTen_Nh_CTTS4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_CTTS)
        Me.Controls.Add(Me.TxtTen_CTTS)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "FAKKCTTS"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CTTS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CTTS, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_CTTS4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CTTS4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CTTS1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_CTTS1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CTTS2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_CTTS2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CTTS3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_CTTS3, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_CTTS5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CTTS5, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.ChkTon, 0)
        CType(Me.TxtMa_CTTS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CTTS4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CTTS3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CTTS2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CTTS1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CTTS5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtMa_CTTS As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_CTTS As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CTTS4 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_CTTS4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_CTTS3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CTTS3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_CTTS2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CTTS2 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_CTTS1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_CTTS1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_CTTS5 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_CTTS5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkTon As System.Windows.Forms.CheckBox

End Class
