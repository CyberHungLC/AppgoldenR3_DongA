<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRMDMVDKN
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
        Me.TxtTen_VD = New System.Windows.Forms.TextBox()
        Me.LabTen_TD2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabMa_HS = New System.Windows.Forms.Label()
        Me.TxtMa_Vd = New System.Windows.Forms.TextBox()
        Me.TxtTen_Vd2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Lv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 134)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 134)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 143)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(108, 147)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 129)
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
        'TxtTen_VD
        '
        Me.TxtTen_VD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_VD.Location = New System.Drawing.Point(108, 68)
        Me.TxtTen_VD.Name = "TxtTen_VD"
        Me.TxtTen_VD.Size = New System.Drawing.Size(539, 21)
        Me.TxtTen_VD.TabIndex = 2
        '
        'LabTen_TD2
        '
        Me.LabTen_TD2.Location = New System.Drawing.Point(2, 71)
        Me.LabTen_TD2.Name = "LabTen_TD2"
        Me.LabTen_TD2.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_TD2.TabIndex = 484
        Me.LabTen_TD2.Tag = "Name"
        Me.LabTen_TD2.Text = "Tên vấn đề"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 480
        Me.Label3.Tag = "Code"
        Me.Label3.Text = "Mã lĩnh vực"
        '
        'LabMa_HS
        '
        Me.LabMa_HS.Location = New System.Drawing.Point(2, 43)
        Me.LabMa_HS.Name = "LabMa_HS"
        Me.LabMa_HS.Size = New System.Drawing.Size(99, 16)
        Me.LabMa_HS.TabIndex = 491
        Me.LabMa_HS.Tag = "Staff"
        Me.LabMa_HS.Text = "Mã vấn đề"
        '
        'TxtMa_Vd
        '
        Me.TxtMa_Vd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Vd.Enabled = False
        Me.TxtMa_Vd.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vd.Location = New System.Drawing.Point(108, 39)
        Me.TxtMa_Vd.Name = "TxtMa_Vd"
        Me.TxtMa_Vd.ReadOnly = True
        Me.TxtMa_Vd.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_Vd.TabIndex = 1
        Me.TxtMa_Vd.TabStop = False
        '
        'TxtTen_Vd2
        '
        Me.TxtTen_Vd2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vd2.Location = New System.Drawing.Point(108, 96)
        Me.TxtTen_Vd2.Name = "TxtTen_Vd2"
        Me.TxtTen_Vd2.Size = New System.Drawing.Size(539, 21)
        Me.TxtTen_Vd2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 494
        Me.Label4.Tag = "Name"
        Me.Label4.Text = "Tên vấn đề"
        '
        'CRMDMVDKN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 176)
        Me.Controls.Add(Me.TxtTen_Vd2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabMa_HS)
        Me.Controls.Add(Me.TxtMa_Vd)
        Me.Controls.Add(Me.TxtTen_VD)
        Me.Controls.Add(Me.LabTen_TD2)
        Me.Controls.Add(Me.TxtTen_Lv)
        Me.Controls.Add(Me.TxtMa_Lv)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "CRMDMVDKN"
        Me.Text = "Danh mục vấn đề khiếu nại"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Lv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lv, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_VD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vd, 0)
        Me.Controls.SetChildIndex(Me.LabMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vd2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtMa_Lv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_Lv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Lv As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_VD As Windows.Forms.TextBox
    Friend WithEvents LabTen_TD2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents LabMa_HS As Windows.Forms.Label
    Friend WithEvents TxtMa_Vd As Windows.Forms.TextBox
    Friend WithEvents TxtTen_Vd2 As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
