Imports System.Windows.Forms
Public Class FrmDuyetCT
    Dim Dt_Master, Dt_Head As DataTable
    Dim Dv_Master, Dv_Head As DataView
    Dim _Tk, _Ma_Ct, _Ma_Post1, _Ma_Post2 As String
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_Post1, _Dt_Post2 As DataTable
    Dim ProccessList As New Collection
    Private Sub FrmDuyetCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        _Tk = Me.Para(M_VT_PARA + 2).ToString.Trim
        _Ma_Ct = Me.Para(M_VT_PARA + 3).ToString.Trim
        _Ma_Post1 = Me.Para(M_VT_PARA + 4).ToString.Trim
        _Ma_Post2 = Me.Para(M_VT_PARA + 5).ToString.Trim

        V_Load()
        V_AddHander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Date.Now
        TxtNgay_Ct2.Value = Date.Now
        TxtNgay_Ct1.Focus()

        ' Load Ma_Post
        Dim _DsPost As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", _Ma_Ct & "##")
        _Dt_Post1 = _DsPost.Tables(0).Copy
        _Dt_Post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(CmbMa_Post1, _Dt_Post1, "Ma_Post", "Ten_Post", _Ma_Post1)
        CyberFill.V_FillComBoxValue(CmbMa_post2, _Dt_Post2, "Ma_Post", "Ten_Post", _Ma_Post2)

        Try
            'TxtTk.Text = _Tk
        Catch ex As Exception
        End Try

        If TxtTk.Text.Trim = "" Then TxtTen_Tk.Text = "" Else TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "DmTk0", "Tk0 = N'" + TxtTk.Text.Trim + "'", CyberSmlib)

        'Load data
        V_LoadData("0")

        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_AddHander()
        AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab
        AddHandler ButtOK.Click, AddressOf V_Refresh

        'Tk
        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk
        'Ma_Ct
        AddHandler TxtMa_Ct.CyberValiting, AddressOf V_Ma_Ct
        AddHandler TxtMa_Ct.CyberLeave, AddressOf L_Ma_Ct

        AddHandler ChkIs_All.Click, AddressOf V_ChkALL
        '-----------------------------------------------------------------------------------------
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
    End Sub
#Region "GRVMaster View"
    Private Sub V_Hach_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Frm As FrmDuyetCT_Ngay
        'Frm = New FrmDuyetCT_Ngay
        'Frm.ShowDialog()
        'Frm.M_LAN = Me.M_LAN
        'If Not Frm.Save_OK Then Exit Sub
        'Dim _Dt As Date = Frm.TxtNgay_Ct.Value
        Dim _Dt As Date = Date.Now
        V_Duyet("9", _Dt)
    End Sub
    Private Sub V_Lap_Phieu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = New Date(1900, 1, 1)
        V_Duyet("3", _Dt)
    End Sub
    Private Sub V_Duyet(ByVal _Ma_Post As String, ByVal _Dt As Date)
        Dim _Detail As DataTable = Dt_Master.Clone
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Rows(i).Item("Is_Chon").ToString.Trim.ToUpper = "1" Or Dt_Master.Rows(i).Item("Is_Chon").ToString.Trim.ToUpper = "TRUE" Then
                _Detail.ImportRow(Dt_Master.Rows(i))
            End If
        Next

        Dim StrXML As String = CyberSmodb.V_ConvertDataToXML({"CT00"}, {_Detail})
        Dim DsChkSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLDuyetCT_Save", StrXML.Trim & "#" & _Ma_Post.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        Dim _ncout As Integer = DsChkSave.Tables.Count
        If Not CyberSupport.V_MsgChk(DsChkSave.Tables(_ncout - 1), Me.Sysvar, M_LAN) Then
            DsChkSave.Dispose()
            Exit Sub
        End If

        MsgBox(DsChkSave.Tables(_ncout - 1).Rows(0).Item("Note"), MsgBoxStyle.Information, Sysvar.Item("M_Cyber_Ver"))
        V_LoadData("1")
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData("1")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim strAddParar As String = Dt_Master.Rows(iRow).Item("Procedure")
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "Grv View"
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer

        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Hạch toán sổ cái", "Create"), AddressOf V_Hach_Toan, Shortcut.F1, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập chứng từ", "Edit"), AddressOf V_Lap_Phieu, Shortcut.F2, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem chứng từ", "View"), AddressOf V_View, Shortcut.F3, My.Resources.edit_16x16, True, False))

        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)

        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_SetGridview(ByVal _MasterGRV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
        CyberFill.V_GridviewRowCellStyle(_MasterGRV)
    End Sub
#End Region
#Region "LoadData"
    Private Sub V_LoadData(ByVal Status As String)
        Dim _Dt1 As Date = TxtNgay_Ct1.Value
        Dim _Dt2 As Date = TxtNgay_Ct2.Value

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLDuyetCT_Load", Status & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") & "#" & TxtTk.Text.Trim & "#" & _
                                                                  TxtMa_Ct.Text.Trim & "#" & CmbMa_Post1.SelectedValue.ToString.Trim & "#" & CmbMa_post2.SelectedValue.ToString.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)

        If Status = "0" Then
            Dt_Master = DsTmp.Tables(0).Copy
            Dt_Head = DsTmp.Tables(1).Copy
            Dv_Master = New DataView(Dt_Master)
            Dv_Head = New DataView(Dt_Head)
            MasterGRV.OptionsBehavior.Editable = True
            CyberFill.V_FillReportsBanded(MasterGRV, M_LAN, Dt_Head, Dv_Master)
            MasterGRV.GridControl.DataSource = Dv_Master
        Else
            Dt_Master.Clear()
            Dt_Master.Load(DsTmp.Tables(0).CreateDataReader)
            Dt_Master.AcceptChanges()
        End If

        DsTmp.Dispose()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Ct"
    Private Sub V_Ma_Ct(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Ct.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Ct", "DmCt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ct(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Ct.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Ct.Text = DrReturn.Item("Ma_Ct")
            TxtTen_Ct.Text = DrReturn.Item("Ten_Ct")
        Else
            TxtMa_Ct.Text = ""
            TxtTen_Ct.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Chọn tất/bỏ chọn"
    Private Sub V_ChkALL()      
        Dim nCount As Integer = Dt_Master.Rows.Count      
        If ChkIs_All.Checked = True Then
            For iRow = nCount - 1 To 0 Step -1
                Dt_Master.Rows(iRow).Item("Is_Chon") = 1
            Next
        Else
            For iRow = nCount - 1 To 0 Step -1
                Dt_Master.Rows(iRow).Item("Is_Chon") = 0
            Next
        End If
    End Sub
#End Region
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#End Region
#Region "Update To Dt_Master"
    Private Sub V_Update(ByVal _Mode As String, ByVal iRow As Integer, ByVal _Dr As DataRow, ByVal _MasterGRV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView, ByVal _Dv_Master As DataView)
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        If _Mode = "S" Then
            rowView = V_UpdateItem(_Dv_Master, iRow, _Dr)
            _MasterGRV.FocusedRowHandle = 0
            iCol = FindRowHandleByRowObject(_MasterGRV, rowView)
            _MasterGRV.FocusedRowHandle = iCol
            _MasterGRV.ClearSelection()
            _MasterGRV.SelectRow(_MasterGRV.FocusedRowHandle)
        Else
            rowView = V_InsertItem(_Dv_Master, _Dr)
            _MasterGRV.FocusedRowHandle = 0
            iCol = FindRowHandleByRowObject(_MasterGRV, rowView)
            _MasterGRV.FocusedRowHandle = iCol
            _MasterGRV.ClearSelection()
            _MasterGRV.SelectRow(_MasterGRV.FocusedRowHandle)
        End If
    End Sub
    Private Function V_UpdateItem(ByVal Dv As DataView, ByVal iRow As Decimal, ByVal DrvUp As DataRow) As DataRowView
        If iRow < 0 Then Return Nothing
        Dim iCol As Integer
        Dim _Fieldname As String
        Dim Drv As DataRowView
        Drv = Dv.Item(iRow)
        Drv.BeginEdit()
        For iCol = 0 To Dv.Table.Columns.Count - 1
            _Fieldname = Dv.Table.Columns(iCol).ColumnName
            If DrvUp.Table.Columns.Contains(_Fieldname) Then
                Drv.Item(_Fieldname) = DrvUp.Item(_Fieldname)
            End If
        Next
        Drv.EndEdit()
        Dv.Table.AcceptChanges()
        Return Drv
    End Function
    Private Function V_InsertItem(ByVal _Dv_Master As DataView, ByVal DrInsert As DataRow) As DataRowView
        Dim iCol As Integer = Dv_Master.Table.Columns.Count - 1
        Dim rowView As DataRowView = _Dv_Master.AddNew
        Dim _Fieldname As String = ""
        rowView.BeginEdit()
        For iCol = 0 To _Dv_Master.Table.Columns.Count - 1
            _Fieldname = _Dv_Master.Table.Columns(iCol).ColumnName
            If Not DrInsert.Table.Columns.Contains(_Fieldname) Then Continue For
            rowView(_Fieldname) = DrInsert.Item(_Fieldname)
        Next
        rowView.EndEdit()
        _Dv_Master.Table.AcceptChanges()
        Return rowView
    End Function
    Private Function FindRowHandleByRowObject(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Object) As Integer
        Dim I As Integer
        If Not row Is Nothing Then
            For I = 0 To view.DataRowCount - 1
                If row.Equals(view.GetRow(I)) Then
                    Return I
                End If
            Next
        End If
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
    End Function
#End Region
End Class