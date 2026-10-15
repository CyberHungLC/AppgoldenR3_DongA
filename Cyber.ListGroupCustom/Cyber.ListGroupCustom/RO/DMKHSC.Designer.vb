<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMKHSC
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
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.LabTen_kho = New System.Windows.Forms.Label()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.Labten_Kho2 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.RichTextBox()
        Me.Labghi_chu = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_HL2 = New ClsTextBox.txtDate1()
        Me.TxtNgay_HL1 = New ClsTextBox.txtDate1()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(626, 176)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(524, 176)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(418, 182)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 186)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 166)
        Me.GroupBoxLine.Size = New System.Drawing.Size(724, 9)
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(110, 27)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(128, 21)
        Me.TxtMa_Xe.TabIndex = 6
        '
        'LabTen_kho
        '
        Me.LabTen_kho.Location = New System.Drawing.Point(5, 29)
        Me.LabTen_kho.Name = "LabTen_kho"
        Me.LabTen_kho.Size = New System.Drawing.Size(100, 18)
        Me.LabTen_kho.TabIndex = 12
        Me.LabTen_kho.Tag = "Name"
        Me.LabTen_kho.Text = "Biển số"
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(110, 52)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(128, 21)
        Me.TxtSo_Khung.TabIndex = 7
        '
        'Labten_Kho2
        '
        Me.Labten_Kho2.Location = New System.Drawing.Point(5, 56)
        Me.Labten_Kho2.Name = "Labten_Kho2"
        Me.Labten_Kho2.Size = New System.Drawing.Size(100, 18)
        Me.Labten_Kho2.TabIndex = 14
        Me.Labten_Kho2.Tag = "English name"
        Me.Labten_Kho2.Text = "Số Khung"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.Location = New System.Drawing.Point(110, 77)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(616, 83)
        Me.TxtDien_Giai.TabIndex = 354
        Me.TxtDien_Giai.Text = ""
        '
        'Labghi_chu
        '
        Me.Labghi_chu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Labghi_chu.Location = New System.Drawing.Point(5, 80)
        Me.Labghi_chu.Name = "Labghi_chu"
        Me.Labghi_chu.Size = New System.Drawing.Size(70, 18)
        Me.Labghi_chu.TabIndex = 355
        Me.Labghi_chu.Tag = "Note"
        Me.Labghi_chu.Text = "Diễn Giải"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(296, 7)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 359
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 358
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtNgay_HL2
        '
        Me.TxtNgay_HL2.Flags = 0
        Me.TxtNgay_HL2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL2.IsAllowResize = False
        Me.TxtNgay_HL2.isEmpty = True
        Me.TxtNgay_HL2.Location = New System.Drawing.Point(384, 3)
        Me.TxtNgay_HL2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL2.MaxLength = 10
        Me.TxtNgay_HL2.Name = "TxtNgay_HL2"
        Me.TxtNgay_HL2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_HL2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_HL2.ShowDayBeforeMonth = False
        Me.TxtNgay_HL2.Size = New System.Drawing.Size(114, 21)
        Me.TxtNgay_HL2.TabIndex = 357
        Me.TxtNgay_HL2.Text = "__/__/____"
        Me.TxtNgay_HL2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_HL1
        '
        Me.TxtNgay_HL1.Flags = 0
        Me.TxtNgay_HL1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL1.IsAllowResize = False
        Me.TxtNgay_HL1.isEmpty = True
        Me.TxtNgay_HL1.Location = New System.Drawing.Point(110, 3)
        Me.TxtNgay_HL1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL1.MaxLength = 10
        Me.TxtNgay_HL1.Name = "TxtNgay_HL1"
        Me.TxtNgay_HL1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_HL1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_HL1.ShowDayBeforeMonth = False
        Me.TxtNgay_HL1.Size = New System.Drawing.Size(128, 21)
        Me.TxtNgay_HL1.TabIndex = 356
        Me.TxtNgay_HL1.Text = "__/__/____"
        Me.TxtNgay_HL1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DMKHSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 209)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_HL2)
        Me.Controls.Add(Me.TxtNgay_HL1)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Labghi_chu)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.Labten_Kho2)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.LabTen_kho)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMKHSC"
        Me.Text = "Danh mục đội xe"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kho2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.Labghi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_kho As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox
    Friend WithEvents Labten_Kho2 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As Windows.Forms.RichTextBox
    Friend WithEvents Labghi_chu As Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As Windows.Forms.Label
    Friend WithEvents TxtNgay_HL2 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_HL1 As ClsTextBox.txtDate1
End Class
