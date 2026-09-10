<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMGDVien
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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.Giá = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcmt = New System.Windows.Forms.TextBox()
        Me.TxtDT_GDV = New System.Windows.Forms.TextBox()
        Me.TxtTen_GDV = New System.Windows.Forms.TextBox()
        Me.TxtMa_GDV = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 135)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(356, 135)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(320, 256)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(143, 24)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(120, 140)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 122)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(622, 12)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(4, 8)
        Me.LabMa_vt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(108, 23)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Mã đơn vị BH"
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(4, 40)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(108, 17)
        Me.LabMa_kho.TabIndex = 21
        Me.LabMa_kho.Tag = "Colour"
        Me.LabMa_kho.Text = "Mã GĐV"
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(252, 9)
        Me.TxtTen_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(373, 17)
        Me.TxtTen_BH.TabIndex = 8
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(120, 6)
        Me.TxtMa_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(124, 22)
        Me.TxtMa_BH.TabIndex = 0
        Me.TxtMa_BH.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(4, 102)
        Me.LabNgay_ban.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(103, 18)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "SĐT"
        '
        'Giá
        '
        Me.Giá.Location = New System.Drawing.Point(275, 6)
        Me.Giá.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Giá.Name = "Giá"
        Me.Giá.Size = New System.Drawing.Size(108, 20)
        Me.Giá.TabIndex = 31
        Me.Giá.Tag = "Price after tax (Currency)"
        Me.Giá.Text = "CMT/CCCD"
        Me.Giá.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 386
        Me.Label1.Tag = "Colour"
        Me.Label1.Text = "Tên GĐV"
        '
        'Txtcmt
        '
        Me.Txtcmt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtcmt.ForeColor = System.Drawing.Color.Navy
        Me.Txtcmt.Location = New System.Drawing.Point(371, 7)
        Me.Txtcmt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcmt.Name = "Txtcmt"
        Me.Txtcmt.Size = New System.Drawing.Size(134, 24)
        Me.Txtcmt.TabIndex = 4
        Me.Txtcmt.Visible = False
        '
        'TxtDT_GDV
        '
        Me.TxtDT_GDV.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDT_GDV.ForeColor = System.Drawing.Color.Navy
        Me.TxtDT_GDV.Location = New System.Drawing.Point(120, 98)
        Me.TxtDT_GDV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDT_GDV.Name = "TxtDT_GDV"
        Me.TxtDT_GDV.Size = New System.Drawing.Size(200, 24)
        Me.TxtDT_GDV.TabIndex = 3
        '
        'TxtTen_GDV
        '
        Me.TxtTen_GDV.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_GDV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_GDV.Location = New System.Drawing.Point(120, 67)
        Me.TxtTen_GDV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_GDV.Name = "TxtTen_GDV"
        Me.TxtTen_GDV.Size = New System.Drawing.Size(505, 24)
        Me.TxtTen_GDV.TabIndex = 2
        '
        'TxtMa_GDV
        '
        Me.TxtMa_GDV.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_GDV.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_GDV.Location = New System.Drawing.Point(120, 36)
        Me.TxtMa_GDV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_GDV.Name = "TxtMa_GDV"
        Me.TxtMa_GDV.ReadOnly = True
        Me.TxtMa_GDV.Size = New System.Drawing.Size(124, 24)
        Me.TxtMa_GDV.TabIndex = 1
        '
        'DMGDVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(628, 179)
        Me.Controls.Add(Me.TxtMa_GDV)
        Me.Controls.Add(Me.TxtTen_GDV)
        Me.Controls.Add(Me.TxtDT_GDV)
        Me.Controls.Add(Me.Txtcmt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Giá)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(646, 222)
        Me.Name = "DMGDVien"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.Giá, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Txtcmt, 0)
        Me.Controls.SetChildIndex(Me.TxtDT_GDV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_GDV, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_GDV, 0)
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents Giá As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtcmt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDT_GDV As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_GDV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_GDV As Windows.Forms.TextBox
End Class
