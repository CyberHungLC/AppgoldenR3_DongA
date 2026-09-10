<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapNhatHD30
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
        Me.TxtNgay_HDDT = New ClsTextBox.txtDate()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.LabSo_Ct_TT = New System.Windows.Forms.Label()
        Me.TxtStt_Rec_HDI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSo_HDDT = New System.Windows.Forms.TextBox()
        Me.txtSo_Seri = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 60)
        Me.GroupBoxLine.Size = New System.Drawing.Size(566, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(366, 70)
        Me.ButtOK.TabIndex = 3
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(468, 70)
        Me.ButtExit.TabIndex = 4
        '
        'TxtNgay_HDDT
        '
        Me.TxtNgay_HDDT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_HDDT.Flags = 65536
        Me.TxtNgay_HDDT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HDDT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HDDT.isEmpty = True
        Me.TxtNgay_HDDT.Location = New System.Drawing.Point(111, 30)
        Me.TxtNgay_HDDT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HDDT.MaxLength = 10
        Me.TxtNgay_HDDT.Name = "TxtNgay_HDDT"
        Me.TxtNgay_HDDT.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HDDT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HDDT.ShowDayBeforeMonth = False
        Me.TxtNgay_HDDT.Size = New System.Drawing.Size(153, 21)
        Me.TxtNgay_HDDT.TabIndex = 2
        Me.TxtNgay_HDDT.Text = "01/01/1900"
        Me.TxtNgay_HDDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_HDDT.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.AutoSize = True
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(5, 38)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(64, 13)
        Me.LabNgay_Ct.TabIndex = 1920
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày HĐĐT"
        '
        'LabSo_Ct_TT
        '
        Me.LabSo_Ct_TT.AutoSize = True
        Me.LabSo_Ct_TT.ForeColor = System.Drawing.Color.Navy
        Me.LabSo_Ct_TT.Location = New System.Drawing.Point(5, 13)
        Me.LabSo_Ct_TT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSo_Ct_TT.Name = "LabSo_Ct_TT"
        Me.LabSo_Ct_TT.Size = New System.Drawing.Size(54, 13)
        Me.LabSo_Ct_TT.TabIndex = 1922
        Me.LabSo_Ct_TT.Tag = "Explaination"
        Me.LabSo_Ct_TT.Text = "Số HĐĐT"
        '
        'TxtStt_Rec_HDI
        '
        Me.TxtStt_Rec_HDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec_HDI.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec_HDI.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec_HDI.Location = New System.Drawing.Point(2, 75)
        Me.TxtStt_Rec_HDI.Name = "TxtStt_Rec_HDI"
        Me.TxtStt_Rec_HDI.Size = New System.Drawing.Size(143, 20)
        Me.TxtStt_Rec_HDI.TabIndex = 1923
        Me.TxtStt_Rec_HDI.Tag = ""
        Me.TxtStt_Rec_HDI.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(348, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1930
        Me.Label1.Tag = "Explaination"
        Me.Label1.Text = "Số Seri"
        '
        'txtSo_HDDT
        '
        Me.txtSo_HDDT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSo_HDDT.BackColor = System.Drawing.Color.White
        Me.txtSo_HDDT.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_HDDT.Location = New System.Drawing.Point(111, 6)
        Me.txtSo_HDDT.Name = "txtSo_HDDT"
        Me.txtSo_HDDT.Size = New System.Drawing.Size(153, 20)
        Me.txtSo_HDDT.TabIndex = 1931
        Me.txtSo_HDDT.Tag = ""
        '
        'txtSo_Seri
        '
        Me.txtSo_Seri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSo_Seri.BackColor = System.Drawing.Color.White
        Me.txtSo_Seri.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_Seri.Location = New System.Drawing.Point(405, 6)
        Me.txtSo_Seri.Name = "txtSo_Seri"
        Me.txtSo_Seri.Size = New System.Drawing.Size(153, 20)
        Me.txtSo_Seri.TabIndex = 1932
        Me.txtSo_Seri.Tag = ""
        '
        'FrmCapNhatHD30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(570, 124)
        Me.Controls.Add(Me.txtSo_Seri)
        Me.Controls.Add(Me.txtSo_HDDT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtStt_Rec_HDI)
        Me.Controls.Add(Me.LabSo_Ct_TT)
        Me.Controls.Add(Me.TxtNgay_HDDT)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.MinimizeBox = False
        Me.Name = "FrmCapNhatHD30"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HDDT, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec_HDI, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtSo_HDDT, 0)
        Me.Controls.SetChildIndex(Me.txtSo_Seri, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HDDT As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents LabSo_Ct_TT As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec_HDI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSo_HDDT As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_Seri As System.Windows.Forms.TextBox

End Class
