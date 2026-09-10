<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmPBPNL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtTen_BT = New System.Windows.Forms.TextBox()
        Me.TxtTen_ChiTieu = New System.Windows.Forms.TextBox()
        Me.TxtMa_So = New Cyber.SmLists.TxtLookup()
        Me.TxtStt = New ClsTextBox.txtSo_luong()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_So.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1213, 475)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1077, 475)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(172, 37)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(157, 24)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(172, 492)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 462)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1360, 12)
        Me.GroupBoxLine.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "Year"
        Me.Label1.Text = "Năm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Tag = "Unit"
        Me.Label2.Text = "Đơn vị hạch toán"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Tag = "Order"
        Me.Label3.Text = "Thứ tự phân bổ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Tag = "Acc allocation"
        Me.Label5.Text = "Chỉ tiêu phân bổ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(911, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Tag = "Name"
        Me.Label6.Text = "Tên bút toán phân bổ"
        Me.Label6.Visible = False
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.Location = New System.Drawing.Point(172, 8)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.Size = New System.Drawing.Size(157, 24)
        Me.TxtNam.TabIndex = 0
        '
        'TxtTen_BT
        '
        Me.TxtTen_BT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_BT.Enabled = False
        Me.TxtTen_BT.Location = New System.Drawing.Point(1077, 94)
        Me.TxtTen_BT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_BT.Name = "TxtTen_BT"
        Me.TxtTen_BT.Size = New System.Drawing.Size(271, 24)
        Me.TxtTen_BT.TabIndex = 3
        Me.TxtTen_BT.Visible = False
        '
        'TxtTen_ChiTieu
        '
        Me.TxtTen_ChiTieu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_ChiTieu.BackColor = System.Drawing.Color.White
        Me.TxtTen_ChiTieu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_ChiTieu.Enabled = False
        Me.TxtTen_ChiTieu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChiTieu.Location = New System.Drawing.Point(340, 101)
        Me.TxtTen_ChiTieu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ChiTieu.Name = "TxtTen_ChiTieu"
        Me.TxtTen_ChiTieu.ReadOnly = True
        Me.TxtTen_ChiTieu.Size = New System.Drawing.Size(1008, 17)
        Me.TxtTen_ChiTieu.TabIndex = 40
        Me.TxtTen_ChiTieu.TabStop = False
        '
        'TxtMa_So
        '
        Me.TxtMa_So._ActilookupPopup = False
        Me.TxtMa_So.CyberActilookupPopup = True
        Me.TxtMa_So.Dv_ListDetail = Nothing
        Me.TxtMa_So.Dv_Master = Nothing
        Me.TxtMa_So.FilterClient = ""
        Me.TxtMa_So.FilterSQL = ""
        Me.TxtMa_So.Location = New System.Drawing.Point(172, 97)
        Me.TxtMa_So.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_So.Name = "TxtMa_So"
        Me.TxtMa_So.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_So.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_So.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_So.Size = New System.Drawing.Size(157, 22)
        Me.TxtMa_So.TabIndex = 4
        Me.TxtMa_So.Table_Name = ""
        '
        'TxtStt
        '
        Me.TxtStt.AllowNegative = True
        Me.TxtStt.Flags = 7680
        Me.TxtStt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt.InputMask = "####"
        Me.TxtStt.Location = New System.Drawing.Point(172, 65)
        Me.TxtStt.MaxWholeDigits = 4
        Me.TxtStt.Name = "TxtStt"
        Me.TxtStt.RangeMax = 1.7976931348623157E+308R
        Me.TxtStt.RangeMin = -1.7976931348623157E+308R
        Me.TxtStt.Size = New System.Drawing.Size(157, 24)
        Me.TxtStt.TabIndex = 2
        Me.TxtStt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(4, 139)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(1357, 325)
        Me.Detail.TabIndex = 8
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.OptionsView.ShowViewCaption = True
        Me.DetailGRV.RowHeight = 21
        Me.DetailGRV.ViewCaption = "F4: Thêm dòng - F8: Xóa dòng - Ctr + Tab: Rời nhập chi tiết"
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.Location = New System.Drawing.Point(872, 7)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(153, 26)
        Me.TxtStt_Rec.TabIndex = 5
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'DmPBPNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1365, 518)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtStt)
        Me.Controls.Add(Me.TxtTen_ChiTieu)
        Me.Controls.Add(Me.TxtMa_So)
        Me.Controls.Add(Me.TxtTen_BT)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DmPBPNL"
        Me.Text = "Danh mục phân bổ báo cáo PNL"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_So, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChiTieu, 0)
        Me.Controls.SetChildIndex(Me.TxtStt, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        CType(Me.TxtMa_So.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_BT As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_ChiTieu As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_So As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtStt As ClsTextBox.txtSo_luong
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox

End Class
