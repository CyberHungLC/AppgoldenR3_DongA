<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmHLChietKhauDV
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
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.LabNgay_Ku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.TxtNgay_KT = New ClsTextBox.txtDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Cv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_Cv = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Post = New System.Windows.Forms.Label()
        Me.TxtPT_CK = New ClsTextBox.txtTy_Gia()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(480, 155)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(378, 155)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(272, 161)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 165)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 145)
        Me.GroupBoxLine.Size = New System.Drawing.Size(578, 9)
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(110, 62)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 2
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(5, 63)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(99, 18)
        Me.LabNgay_Ku.TabIndex = 3
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Hiệu lực từ"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Mã vật tư"
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(110, 10)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Vt.TabIndex = 0
        Me.TxtMa_Vt.Table_Name = ""
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(265, 12)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_Vt.TabIndex = 3
        Me.TxtTen_Vt.TabStop = False
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.Flags = 65536
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.isEmpty = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(110, 89)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_KT.TabIndex = 3
        Me.TxtNgay_KT.Text = "26/07/2011"
        Me.TxtNgay_KT.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Tag = "Date from"
        Me.Label3.Text = "Hiệu lực từ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTen_Cv
        '
        Me.TxtTen_Cv.BackColor = System.Drawing.Color.White
        Me.TxtTen_Cv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cv.Enabled = False
        Me.TxtTen_Cv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cv.Location = New System.Drawing.Point(265, 38)
        Me.TxtTen_Cv.Name = "TxtTen_Cv"
        Me.TxtTen_Cv.ReadOnly = True
        Me.TxtTen_Cv.Size = New System.Drawing.Size(315, 14)
        Me.TxtTen_Cv.TabIndex = 19
        Me.TxtTen_Cv.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Mã công việc"
        '
        'TxtMa_Cv
        '
        Me.TxtMa_Cv._ActilookupPopup = False
        Me.TxtMa_Cv.CyberActilookupPopup = True
        Me.TxtMa_Cv.Dv_ListDetail = Nothing
        Me.TxtMa_Cv.Dv_Master = Nothing
        Me.TxtMa_Cv.FilterClient = ""
        Me.TxtMa_Cv.FilterSQL = ""
        Me.TxtMa_Cv.Location = New System.Drawing.Point(110, 36)
        Me.TxtMa_Cv.Name = "TxtMa_Cv"
        Me.TxtMa_Cv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cv.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Cv.TabIndex = 1
        Me.TxtMa_Cv.Table_Name = ""
        '
        'LabMa_Post
        '
        Me.LabMa_Post.Location = New System.Drawing.Point(5, 120)
        Me.LabMa_Post.Name = "LabMa_Post"
        Me.LabMa_Post.Size = New System.Drawing.Size(100, 13)
        Me.LabMa_Post.TabIndex = 21
        Me.LabMa_Post.Tag = "Currency"
        Me.LabMa_Post.Text = "% chiết khấu"
        '
        'TxtPT_CK
        '
        Me.TxtPT_CK.AllowNegative = True
        Me.TxtPT_CK.Flags = 7680
        Me.TxtPT_CK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CK.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CK.InputMask = "### ### ### ###"
        Me.TxtPT_CK.Location = New System.Drawing.Point(110, 118)
        Me.TxtPT_CK.MaxWholeDigits = 11
        Me.TxtPT_CK.Name = "TxtPT_CK"
        Me.TxtPT_CK.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CK.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CK.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_CK.TabIndex = 4
        Me.TxtPT_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DmHLChietKhauDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 188)
        Me.Controls.Add(Me.TxtPT_CK)
        Me.Controls.Add(Me.LabMa_Post)
        Me.Controls.Add(Me.TxtTen_Cv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_Cv)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_Vt)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmHLChietKhauDV"
        Me.Text = "Danh mục đăng ký hiệu lực chiết khấu dịch vụ"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cv, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cv, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CK, 0)
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_KT As ClsTextBox.txtDate
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtTen_Cv As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_Cv As SmLists.TxtLookup
    Friend WithEvents LabMa_Post As Windows.Forms.Label
    Friend WithEvents TxtPT_CK As ClsTextBox.txtTy_Gia
End Class
