<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmTkKc
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
        Me.LabMa_Tx1 = New System.Windows.Forms.Label()
        Me.TxtTen_Tk01 = New System.Windows.Forms.TextBox()
        Me.TxtTk01 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk02 = New System.Windows.Forms.TextBox()
        Me.TxtTk02 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtTk01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk02.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(521, 75)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(419, 75)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(313, 81)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(86, 88)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 65)
        Me.GroupBoxLine.Size = New System.Drawing.Size(619, 9)
        Me.GroupBoxLine.TabIndex = 10
        '
        'LabMa_Tx1
        '
        Me.LabMa_Tx1.AutoSize = True
        Me.LabMa_Tx1.Location = New System.Drawing.Point(5, 5)
        Me.LabMa_Tx1.Name = "LabMa_Tx1"
        Me.LabMa_Tx1.Size = New System.Drawing.Size(67, 13)
        Me.LabMa_Tx1.TabIndex = 39
        Me.LabMa_Tx1.Tag = "Group 5"
        Me.LabMa_Tx1.Text = "Từ tài khoản"
        '
        'TxtTen_Tk01
        '
        Me.TxtTen_Tk01.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk01.Enabled = False
        Me.TxtTen_Tk01.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk01.Location = New System.Drawing.Point(233, 6)
        Me.TxtTen_Tk01.Name = "TxtTen_Tk01"
        Me.TxtTen_Tk01.ReadOnly = True
        Me.TxtTen_Tk01.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Tk01.TabIndex = 51
        Me.TxtTen_Tk01.TabStop = False
        '
        'TxtTk01
        '
        Me.TxtTk01._ActilookupPopup = False
        Me.TxtTk01.CyberActilookupPopup = True
        Me.TxtTk01.Dv_ListDetail = Nothing
        Me.TxtTk01.Dv_Master = Nothing
        Me.TxtTk01.FilterClient = ""
        Me.TxtTk01.FilterSQL = ""
        Me.TxtTk01.Location = New System.Drawing.Point(86, 3)
        Me.TxtTk01.Name = "TxtTk01"
        Me.TxtTk01.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk01.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk01.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk01.Size = New System.Drawing.Size(141, 20)
        Me.TxtTk01.TabIndex = 0
        Me.TxtTk01.Table_Name = ""
        '
        'TxtTen_Tk02
        '
        Me.TxtTen_Tk02.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk02.Enabled = False
        Me.TxtTen_Tk02.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk02.Location = New System.Drawing.Point(233, 28)
        Me.TxtTen_Tk02.Name = "TxtTen_Tk02"
        Me.TxtTen_Tk02.ReadOnly = True
        Me.TxtTen_Tk02.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Tk02.TabIndex = 54
        Me.TxtTen_Tk02.TabStop = False
        '
        'TxtTk02
        '
        Me.TxtTk02._ActilookupPopup = False
        Me.TxtTk02.CyberActilookupPopup = True
        Me.TxtTk02.Dv_ListDetail = Nothing
        Me.TxtTk02.Dv_Master = Nothing
        Me.TxtTk02.FilterClient = ""
        Me.TxtTk02.FilterSQL = ""
        Me.TxtTk02.Location = New System.Drawing.Point(86, 25)
        Me.TxtTk02.Name = "TxtTk02"
        Me.TxtTk02.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk02.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk02.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk02.Size = New System.Drawing.Size(141, 20)
        Me.TxtTk02.TabIndex = 1
        Me.TxtTk02.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Tag = "Group 5"
        Me.Label1.Text = "Đến tài khoản"
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.Color.White
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Enabled = False
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(233, 50)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_BP.TabIndex = 57
        Me.TxtTen_BP.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(86, 47)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(141, 20)
        Me.TxtMa_BP.TabIndex = 2
        Me.TxtMa_BP.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Tag = "Group 5"
        Me.Label2.Text = "Bộ phận"
        '
        'DmTkKc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 108)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Tk02)
        Me.Controls.Add(Me.TxtTk02)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Tk01)
        Me.Controls.Add(Me.TxtTk01)
        Me.Controls.Add(Me.LabMa_Tx1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 100)
        Me.Name = "DmTkKc"
        Me.Text = "Danh mục tài khoản kết chuyển"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Tx1, 0)
        Me.Controls.SetChildIndex(Me.TxtTk01, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk01, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTk02, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk02, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        CType(Me.TxtTk01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk02.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Tx1 As Windows.Forms.Label
    Friend WithEvents TxtTen_Tk01 As Windows.Forms.TextBox
    Friend WithEvents TxtTk01 As SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk02 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk02 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
