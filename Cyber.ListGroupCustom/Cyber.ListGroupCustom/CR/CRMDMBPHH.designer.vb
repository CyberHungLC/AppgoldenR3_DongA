<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRMDMBPHH
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
        Me.TxtTen_Lv = New System.Windows.Forms.TextBox()
        Me.TxtMa_Lv = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Bphh = New System.Windows.Forms.TextBox()
        Me.LabTen_TD2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Vd = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vd = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabMa_HS = New System.Windows.Forms.Label()
        Me.TxtMa_Bphh = New System.Windows.Forms.TextBox()
        Me.TxtTen_Bphh2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Lv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 157)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 157)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 166)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(108, 170)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 152)
        Me.GroupBoxLine.Size = New System.Drawing.Size(648, 2)
        Me.GroupBoxLine.TabIndex = 4
        '
        'TxtTen_Lv
        '
        Me.TxtTen_Lv.BackColor = System.Drawing.Color.White
        Me.TxtTen_Lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Lv.Enabled = False
        Me.TxtTen_Lv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Lv.Location = New System.Drawing.Point(266, 16)
        Me.TxtTen_Lv.Name = "TxtTen_Lv"
        Me.TxtTen_Lv.ReadOnly = True
        Me.TxtTen_Lv.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_Lv.TabIndex = 482
        Me.TxtTen_Lv.TabStop = False
        '
        'TxtMa_Lv
        '
        Me.TxtMa_Lv._ActilookupPopup = False
        Me.TxtMa_Lv.CyberActilookupPopup = True
        Me.TxtMa_Lv.Dv_ListDetail = Nothing
        Me.TxtMa_Lv.Dv_Master = Nothing
        Me.TxtMa_Lv.FilterClient = ""
        Me.TxtMa_Lv.FilterSQL = ""
        Me.TxtMa_Lv.Location = New System.Drawing.Point(108, 12)
        Me.TxtMa_Lv.Name = "TxtMa_Lv"
        Me.TxtMa_Lv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Lv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Lv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Lv.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Lv.TabIndex = 0
        Me.TxtMa_Lv.Table_Name = ""
        '
        'TxtTen_Bphh
        '
        Me.TxtTen_Bphh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bphh.Location = New System.Drawing.Point(108, 91)
        Me.TxtTen_Bphh.Name = "TxtTen_Bphh"
        Me.TxtTen_Bphh.Size = New System.Drawing.Size(539, 21)
        Me.TxtTen_Bphh.TabIndex = 3
        '
        'LabTen_TD2
        '
        Me.LabTen_TD2.Location = New System.Drawing.Point(2, 94)
        Me.LabTen_TD2.Name = "LabTen_TD2"
        Me.LabTen_TD2.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_TD2.TabIndex = 484
        Me.LabTen_TD2.Tag = "Name"
        Me.LabTen_TD2.Text = "Tên Bphh"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 480
        Me.Label3.Tag = "Code"
        Me.Label3.Text = "Lĩnh vực"
        '
        'TxtTen_Vd
        '
        Me.TxtTen_Vd.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vd.Enabled = False
        Me.TxtTen_Vd.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vd.Location = New System.Drawing.Point(266, 42)
        Me.TxtTen_Vd.Name = "TxtTen_Vd"
        Me.TxtTen_Vd.ReadOnly = True
        Me.TxtTen_Vd.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_Vd.TabIndex = 487
        Me.TxtTen_Vd.TabStop = False
        '
        'TxtMa_Vd
        '
        Me.TxtMa_Vd._ActilookupPopup = False
        Me.TxtMa_Vd.CyberActilookupPopup = True
        Me.TxtMa_Vd.Dv_ListDetail = Nothing
        Me.TxtMa_Vd.Dv_Master = Nothing
        Me.TxtMa_Vd.FilterClient = ""
        Me.TxtMa_Vd.FilterSQL = ""
        Me.TxtMa_Vd.Location = New System.Drawing.Point(108, 38)
        Me.TxtMa_Vd.Name = "TxtMa_Vd"
        Me.TxtMa_Vd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vd.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vd.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Vd.TabIndex = 1
        Me.TxtMa_Vd.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 486
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Vấn đề"
        '
        'LabMa_HS
        '
        Me.LabMa_HS.Location = New System.Drawing.Point(2, 68)
        Me.LabMa_HS.Name = "LabMa_HS"
        Me.LabMa_HS.Size = New System.Drawing.Size(99, 16)
        Me.LabMa_HS.TabIndex = 491
        Me.LabMa_HS.Tag = "Staff"
        Me.LabMa_HS.Text = "Mã bphh"
        '
        'TxtMa_Bphh
        '
        Me.TxtMa_Bphh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Bphh.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bphh.Location = New System.Drawing.Point(108, 64)
        Me.TxtMa_Bphh.Name = "TxtMa_Bphh"
        Me.TxtMa_Bphh.ReadOnly = True
        Me.TxtMa_Bphh.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_Bphh.TabIndex = 2
        '
        'TxtTen_Bphh2
        '
        Me.TxtTen_Bphh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bphh2.Location = New System.Drawing.Point(108, 119)
        Me.TxtTen_Bphh2.Name = "TxtTen_Bphh2"
        Me.TxtTen_Bphh2.Size = New System.Drawing.Size(539, 21)
        Me.TxtTen_Bphh2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 494
        Me.Label4.Tag = "Name"
        Me.Label4.Text = "Tên Bphh 2"
        '
        'CRMDMBPHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 199)
        Me.Controls.Add(Me.TxtTen_Bphh2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabMa_HS)
        Me.Controls.Add(Me.TxtMa_Bphh)
        Me.Controls.Add(Me.TxtTen_Vd)
        Me.Controls.Add(Me.TxtMa_Vd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Bphh)
        Me.Controls.Add(Me.LabTen_TD2)
        Me.Controls.Add(Me.TxtTen_Lv)
        Me.Controls.Add(Me.TxtMa_Lv)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "CRMDMBPHH"
        Me.Text = "Danh mục bộ phận hư hỏng"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Lv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lv, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bphh, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vd, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vd, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bphh, 0)
        Me.Controls.SetChildIndex(Me.LabMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bphh2, 0)
        CType(Me.TxtMa_Lv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_Lv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Lv As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Bphh As Windows.Forms.TextBox
    Friend WithEvents LabTen_TD2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtTen_Vd As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vd As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LabMa_HS As Windows.Forms.Label
    Friend WithEvents TxtMa_Bphh As Windows.Forms.TextBox
    Friend WithEvents TxtTen_Bphh2 As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
