<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLPNL
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabT_Tien_NT = New System.Windows.Forms.Label()
        Me.TxtDvt = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbM_Nam2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbM_Thang4 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbDmMauBc = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 177)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(106, 125)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(480, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 128)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 177)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 106)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 103)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(231, 103)
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(10, 12)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(85, 13)
        Me.LabM_month1.TabIndex = 13
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Kỳ này từ tháng"
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(228, 12)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(58, 13)
        Me.LabM_month2.TabIndex = 14
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 147)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(106, 9)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(305, 9)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(491, 9)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'LabT_Tien_NT
        '
        Me.LabT_Tien_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Tien_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_Tien_NT.ForeColor = System.Drawing.Color.Red
        Me.LabT_Tien_NT.Location = New System.Drawing.Point(10, 58)
        Me.LabT_Tien_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Tien_NT.Name = "LabT_Tien_NT"
        Me.LabT_Tien_NT.Size = New System.Drawing.Size(61, 14)
        Me.LabT_Tien_NT.TabIndex = 204
        Me.LabT_Tien_NT.Tag = "Pay cash"
        Me.LabT_Tien_NT.Text = "Đơn vị tính"
        Me.LabT_Tien_NT.Visible = False
        '
        'TxtDvt
        '
        Me.TxtDvt.AllowNegative = True
        Me.TxtDvt.BackColor = System.Drawing.Color.White
        Me.TxtDvt.Flags = 7680
        Me.TxtDvt.ForeColor = System.Drawing.Color.Navy
        Me.TxtDvt.InputMask = "### ### ### ### ###"
        Me.TxtDvt.Location = New System.Drawing.Point(106, 53)
        Me.TxtDvt.MaxWholeDigits = 14
        Me.TxtDvt.Name = "TxtDvt"
        Me.TxtDvt.RangeMax = 1.7976931348623157E+308R
        Me.TxtDvt.RangeMin = -1.7976931348623157E+308R
        Me.TxtDvt.Size = New System.Drawing.Size(95, 21)
        Me.TxtDvt.TabIndex = 4
        Me.TxtDvt.TabStop = False
        Me.TxtDvt.Text = "1"
        Me.TxtDvt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDvt.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(228, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 205
        Me.Label3.Tag = "Pay cash"
        Me.Label3.Text = "VNĐ"
        Me.Label3.Visible = False
        '
        'CbbM_Nam2
        '
        Me.CbbM_Nam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam2.FormattingEnabled = True
        Me.CbbM_Nam2.Location = New System.Drawing.Point(491, 31)
        Me.CbbM_Nam2.Name = "CbbM_Nam2"
        Me.CbbM_Nam2.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Nam2.TabIndex = 208
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 211
        Me.Label4.Tag = "Year"
        Me.Label4.Text = "Năm"
        '
        'CbbM_Thang4
        '
        Me.CbbM_Thang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang4.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang4.FormattingEnabled = True
        Me.CbbM_Thang4.Location = New System.Drawing.Point(305, 31)
        Me.CbbM_Thang4.Name = "CbbM_Thang4"
        Me.CbbM_Thang4.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Thang4.TabIndex = 207
        '
        'CbbM_Thang3
        '
        Me.CbbM_Thang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang3.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang3.FormattingEnabled = True
        Me.CbbM_Thang3.Location = New System.Drawing.Point(106, 31)
        Me.CbbM_Thang3.Name = "CbbM_Thang3"
        Me.CbbM_Thang3.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Thang3.TabIndex = 206
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 210
        Me.Label5.Tag = "Month to"
        Me.Label5.Text = "Đến tháng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 209
        Me.Label6.Tag = "Month from"
        Me.Label6.Text = "Kỳ trước từ tháng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 213
        Me.Label7.Tag = "Form"
        Me.Label7.Text = "Mẫu theo"
        '
        'CbbDmMauBc
        '
        Me.CbbDmMauBc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDmMauBc.ForeColor = System.Drawing.Color.Navy
        Me.CbbDmMauBc.FormattingEnabled = True
        Me.CbbDmMauBc.Location = New System.Drawing.Point(107, 76)
        Me.CbbDmMauBc.Name = "CbbDmMauBc"
        Me.CbbDmMauBc.Size = New System.Drawing.Size(479, 21)
        Me.CbbDmMauBc.TabIndex = 212
        '
        'GLPNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 230)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbbDmMauBc)
        Me.Controls.Add(Me.CbbM_Nam2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Thang4)
        Me.Controls.Add(Me.CbbM_Thang3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabT_Tien_NT)
        Me.Controls.Add(Me.TxtDvt)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Name = "GLPNL"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.TxtDvt, 0)
        Me.Controls.SetChildIndex(Me.LabT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang3, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang4, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam2, 0)
        Me.Controls.SetChildIndex(Me.CbbDmMauBc, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabT_Tien_NT As System.Windows.Forms.Label
    Friend WithEvents TxtDvt As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Nam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang4 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbDmMauBc As System.Windows.Forms.ComboBox

End Class
