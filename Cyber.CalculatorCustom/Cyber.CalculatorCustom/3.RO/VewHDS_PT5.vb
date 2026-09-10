Imports System.Windows.Forms
Public Class VewHDS_PT5
    Dim Dt_Master, Dt_Head As DataTable
    Dim Dv_Master, Dv_Head As DataView
    Dim DT_Post1, DT_Post2 As DataTable
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Dim ProccessList As New Collection
    Dim DrDmct As DataRow
    Dim M_So_Ro As String = ""
    Private Sub BELoadDmKHTN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        'V_Load()
        V_AddHander()
        V_LoadData("1")
        V_SetGridview(MasterGRV)
        LabelTitle.Text = "Lịch sử Phiếu thu - Hóa đơn của R/O " + M_So_Ro
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load()
        'TxtNgay_Ct1.Value = Date.Now
        'TxtNgay_Ct2.Value = Date.Now       
        'TxtNgay_Ct1.Focus()

        'V_GetPost()
        ''Load data
        'V_LoadData("1")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_AddHander()
        'AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        'AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab

        ''Ma_Hs
        'RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        'RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        'AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        'AddHandler ButtOK.Click, AddressOf V_Refresh
        ''-----------------------------------------------------------------------------------------
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
    End Sub
#Region "Valid"
#Region "Valid Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "GRVMaster View"
#Region "F3"
    Private Sub V_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim strAddParar As String = Dv_Master.Item(iRow).Item("Procedure")
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)

    End Sub
#End Region
#Region "F6"
    Private Sub V_F6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec")
        Dim _Dt As Date = Dv_Master.Item(iRow).Item("Ngay_Ct")
        Dim _Ma_Post As String = Dv_Master.Item(iRow).Item("Ma_Post")
        Dim _Ma_Ct As String = Dv_Master.Item(iRow).Item("Ma_Ct")

        If _Stt_Rec.Trim = "" Then Exit Sub
        CyberVoucher.V_PrintVocuher(AppConn, Sysvar, Nothing, _Stt_Rec, _Dt, _Ma_Post, M_LAN, Para, DrDmct, _Ma_Ct, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub    
#End Region
#Region "F7"
    Private Sub V_F7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim strAddParar As String = Dv_Master.Item(iRow).Item("Procedure")
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F8"
    Private Sub V_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        If _So_Ro = "" Then Exit Sub
        Dim strAddParar As String = "2#PT5#C#" + _So_Ro + "####"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F9"
    Private Sub V_F9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        If _So_Ro = "" Then Exit Sub
        Dim strAddParar As String = "1#HDS#C#50#TM/CK#" + _So_Ro + "####"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "Khac"
    Private Sub V_Export_Excel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberExport.V_ExportToXlsx(AppConn, MasterGRV, Dv_Head, Dv_Master, Me.Para, Me.Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData("0")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
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
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem phiếu", "Xem phiếu"), AddressOf V_F7, Shortcut.F6, My.Resources.edit_16x16, True, False))
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)

        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_SetGridview(ByVal _MasterGRV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
        CyberFill.V_GridviewRowCellStyle(_MasterGRV)
    End Sub
#End Region
#Region "Load Ma_Post"
    Private Sub V_GetPost()
        Dim _DsPost As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RODsLenhDefault", "2#9#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        'Ma_Post1
        If _DsPost.Tables.Count < 1 Then
            _DsPost.Dispose()
            Exit Sub
        End If

        If _DsPost.Tables(0).Rows.Count < 1 Then
            _DsPost.Dispose()
            Exit Sub
        End If

        DT_Post1 = _DsPost.Tables(0)
        CyberFill.V_FillComBoxDefaul(CmbMa_Post1, DT_Post1, "Ma_Post", "Ten_Post", "Ngam_Dinh")
        'Ma_Post2
        If _DsPost.Tables.Count < 2 Then
            _DsPost.Dispose()
            Exit Sub
        End If

        If _DsPost.Tables(1).Rows.Count < 1 Then
            _DsPost.Dispose()
            Exit Sub
        End If

        DT_Post2 = _DsPost.Tables(1)
        CyberFill.V_FillComBoxDefaul(CmbMa_Post2, DT_Post2, "Ma_Post", "Ten_Post", "Ngam_Dinh")
        'DrDmct
        If _DsPost.Tables.Count < 3 Then
            _DsPost.Dispose()
            Exit Sub
        End If

        If _DsPost.Tables(2).Rows.Count < 1 Then
            _DsPost.Dispose()
            Exit Sub
        End If
        DrDmct = _DsPost.Tables(2).Rows(0)        
    End Sub    
#End Region
#Region "LoadData"
    Private Sub V_LoadData(ByVal Status As String)
        Dim M_So_Ro As String = TxtSo_RO.Text.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ViewHistoryHDS_PT5", M_So_Ro & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)

        If Status = "1" Then
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