<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRM_SMS
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.TxtTen_SMS = New System.Windows.Forms.TextBox()
        Me.TxtMa_SMS = New Cyber.SmLists.TxtLookup()
        Me.TxtNoi_Dung = New System.Windows.Forms.TextBox()
        Me.TxtND1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtND5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBody = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabLeng = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabSo_Tin_Nhan = New System.Windows.Forms.Label()
        CType(Me.TxtMa_SMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 224)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(957, 8)
        Me.GroupBoxLine.TabIndex = 20
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(757, 234)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 6
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(859, 234)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabM_month1.Location = New System.Drawing.Point(3, 11)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(63, 15)
        Me.LabM_month1.TabIndex = 8
        Me.LabM_month1.Tag = "Type"
        Me.LabM_month1.Text = "Điện thoại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Tag = "Type"
        Me.Label1.Text = "Chọn mẫu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Tag = "Type"
        Me.Label2.Text = "Nội dung"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDien_Thoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(73, 5)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(168, 29)
        Me.TxtDien_Thoai.TabIndex = 0
        '
        'TxtTen_SMS
        '
        Me.TxtTen_SMS.BackColor = System.Drawing.Color.White
        Me.TxtTen_SMS.Enabled = False
        Me.TxtTen_SMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_SMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_SMS.Location = New System.Drawing.Point(137, 39)
        Me.TxtTen_SMS.Name = "TxtTen_SMS"
        Me.TxtTen_SMS.ReadOnly = True
        Me.TxtTen_SMS.Size = New System.Drawing.Size(359, 22)
        Me.TxtTen_SMS.TabIndex = 15
        Me.TxtTen_SMS.TabStop = False
        '
        'TxtMa_SMS
        '
        Me.TxtMa_SMS._ActilookupPopup = False
        Me.TxtMa_SMS.CyberActilookupPopup = True
        Me.TxtMa_SMS.Dv_ListDetail = Nothing
        Me.TxtMa_SMS.Dv_Master = Nothing
        Me.TxtMa_SMS.FilterClient = ""
        Me.TxtMa_SMS.FilterSQL = ""
        Me.TxtMa_SMS.Location = New System.Drawing.Point(73, 39)
        Me.TxtMa_SMS.Name = "TxtMa_SMS"
        Me.TxtMa_SMS.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_SMS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_SMS.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_SMS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_SMS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_SMS.Size = New System.Drawing.Size(58, 22)
        Me.TxtMa_SMS.TabIndex = 1
        Me.TxtMa_SMS.Table_Name = ""
        '
        'TxtNoi_Dung
        '
        Me.TxtNoi_Dung.BackColor = System.Drawing.Color.White
        Me.TxtNoi_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoi_Dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Dung.Location = New System.Drawing.Point(72, 90)
        Me.TxtNoi_Dung.Multiline = True
        Me.TxtNoi_Dung.Name = "TxtNoi_Dung"
        Me.TxtNoi_Dung.Size = New System.Drawing.Size(423, 107)
        Me.TxtNoi_Dung.TabIndex = 5
        Me.TxtNoi_Dung.TabStop = False
        '
        'TxtND1
        '
        Me.TxtND1.BackColor = System.Drawing.Color.White
        Me.TxtND1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtND1.ForeColor = System.Drawing.Color.Navy
        Me.TxtND1.Location = New System.Drawing.Point(73, 64)
        Me.TxtND1.Name = "TxtND1"
        Me.TxtND1.Size = New System.Drawing.Size(422, 20)
        Me.TxtND1.TabIndex = 4
        Me.TxtND1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Tag = "Type"
        Me.Label8.Text = "Begin"
        '
        'TxtND5
        '
        Me.TxtND5.BackColor = System.Drawing.Color.White
        Me.TxtND5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtND5.ForeColor = System.Drawing.Color.Navy
        Me.TxtND5.Location = New System.Drawing.Point(72, 201)
        Me.TxtND5.Name = "TxtND5"
        Me.TxtND5.Size = New System.Drawing.Size(422, 20)
        Me.TxtND5.TabIndex = 45
        Me.TxtND5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Tag = "Type"
        Me.Label7.Text = "End"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.Location = New System.Drawing.Point(326, 4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(168, 29)
        Me.TxtMa_Xe.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Tag = "Type"
        Me.Label3.Text = "Biển số"
        '
        'TxtBody
        '
        Me.TxtBody.BackColor = System.Drawing.Color.White
        Me.TxtBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBody.ForeColor = System.Drawing.Color.Navy
        Me.TxtBody.Location = New System.Drawing.Point(502, 39)
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.ReadOnly = True
        Me.TxtBody.Size = New System.Drawing.Size(457, 184)
        Me.TxtBody.TabIndex = 49
        Me.TxtBody.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(502, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Tag = "Type"
        Me.Label4.Text = "Xem trước nội dung"
        '
        'LabLeng
        '
        Me.LabLeng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLeng.Location = New System.Drawing.Point(716, 9)
        Me.LabLeng.Name = "LabLeng"
        Me.LabLeng.Size = New System.Drawing.Size(98, 18)
        Me.LabLeng.TabIndex = 51
        Me.LabLeng.Tag = "Type"
        Me.LabLeng.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(809, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 52
        Me.Label6.Tag = "Type"
        Me.Label6.Text = "/160 = "
        '
        'LabSo_Tin_Nhan
        '
        Me.LabSo_Tin_Nhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSo_Tin_Nhan.Location = New System.Drawing.Point(858, 9)
        Me.LabSo_Tin_Nhan.Name = "LabSo_Tin_Nhan"
        Me.LabSo_Tin_Nhan.Size = New System.Drawing.Size(101, 24)
        Me.LabSo_Tin_Nhan.TabIndex = 53
        Me.LabSo_Tin_Nhan.Tag = "Type"
        '
        'CRM_SMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(961, 288)
        Me.Controls.Add(Me.LabSo_Tin_Nhan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabLeng)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBody)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtND5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtND1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNoi_Dung)
        Me.Controls.Add(Me.TxtTen_SMS)
        Me.Controls.Add(Me.TxtMa_SMS)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CRM_SMS"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_SMS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_SMS, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtND1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtND5, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtBody, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabLeng, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Tin_Nhan, 0)
        CType(Me.TxtMa_SMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As Windows.Forms.TextBox
    Friend WithEvents TxtTen_SMS As Windows.Forms.TextBox
    Friend WithEvents TxtMa_SMS As SmLists.TxtLookup
    Friend WithEvents TxtNoi_Dung As Windows.Forms.TextBox
    Friend WithEvents TxtND1 As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtND5 As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtBody As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents LabLeng As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents LabSo_Tin_Nhan As Windows.Forms.Label
End Class
