Imports System.Windows.Forms
Public Class RODsLenh
    Dim Dt_Master, Dt_Head As DataTable
    Dim Dv_Master, Dv_Head As DataView
    Dim DT_Post1, DT_Post2 As DataTable
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Dim ProccessList As New Collection
    Dim DrDmct As DataRow
    Private Sub RODsLenh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
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

        Dim _DsTTCP As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTTCP", M_Ma_Dvcs & "#" & Me.M_User_Name)
        Dim _DtTTCP As DataTable = _DsTTCP.Tables(0)
        CyberFill.V_FillComBoxDefaul(CbbMa_TTCP, _DtTTCP, "Ma_TTCP", IIf(Me.Lan = "V", "Ten_TTCP", "Ten_TTCP"), "Ngam_Dinh")


        V_GetPost()
        'Load data
        V_LoadData("1")
        V_SetGridview(MasterGRV)
        ' Cho phép form nhận sự kiện phím trước các control con
        Me.KeyPreview = True
        ' Cấu hình Timer
        AutoRefreshTimer.Interval = 15000 ' 10 giây
        AutoRefreshTimer.Start()
    End Sub
    Private Sub AutoRefreshTimer_Tick(sender As Object, e As EventArgs) Handles AutoRefreshTimer.Tick
        AutoRefreshTimer.Stop()

        V_Refresh(sender, e)

        AutoRefreshTimer.Start()
    End Sub
    ' Reset lại thời gian 15 giây khi có di chuyển chuột trên form
    Private Sub YourForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ResetTimer()
    End Sub

    ' Reset lại thời gian 15 giây khi người dùng gõ phím bất kỳ
    Private Sub YourForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ResetTimer()
    End Sub
    ' Hàm phụ trợ reset timer
    Private Sub ResetTimer()
        AutoRefreshTimer.Stop()
        AutoRefreshTimer.Start()
    End Sub

    Private Sub V_AddHander()
        AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab

        'Ma_Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs


        AddHandler ButtOK.Click, AddressOf V_Refresh
        '-----------------------------------------------------------------------------------------
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
#Region "F2"
    Private Sub V_F2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim strAddParar As String = Dv_Master.Item(iRow).Item("Procedure")
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)

    End Sub
#End Region
#Region "F3"
    Private Sub V_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
#Region "F4"
    Private Sub V_F4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        Dim _Ma_TTCP_H As String = Dv_Master.Item(iRow).Item("Ma_TTCP_H")
        If _So_Ro = "" Then Exit Sub
        Dim strAddParar As String = "1#PNA#00#1#" + _So_Ro + "#" + _Ma_TTCP_H + ""
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F5"
    Private Sub V_F5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        Dim _Ma_TTCP_H As String = Dv_Master.Item(iRow).Item("Ma_TTCP_H")

        If _So_Ro = "" Then Exit Sub
        Dim strAddParar As String = "S#PXK#" + _So_Ro + "#" + _Ma_TTCP_H + ""
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F6"
    Private Sub V_F6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        Dim _So_BG As String = Dv_Master.Item(iRow).Item("So_Bg")
        Dim _Ma_TTCP_H As String = Dv_Master.Item(iRow).Item("Ma_TTCP_H")

        If _So_Ro = "" And _So_BG = "" Then Exit Sub
        Dim strAddParar As String = "2#PT5#C#" + _So_Ro.Trim + _So_BG.Trim + "#" + _Ma_TTCP_H + ""
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F7"
    Private Sub V_F7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        Dim _Ma_TTCP_H As String = Dv_Master.Item(iRow).Item("Ma_TTCP_H")

        If _So_Ro = "" Then Exit Sub
        Dim strAddParar As String = "1#HDS#C#50#TM/CK#" + _So_Ro + "##" + _Ma_TTCP_H + ""
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.InputCustom.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "F9"
    ' Xem thông tin hóa đơn và phiếu
    Private Sub V_F9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _So_Ro As String = Dv_Master.Item(iRow).Item("So_Ro")
        If _So_Ro = "" Then Exit Sub
        Dim _frm As New VewHDS_PT5
        _frm.TxtSo_RO.Text = _So_Ro
        _frm.M_Ma_Dvcs = M_Ma_Dvcs
        _frm.Para = Me.Para
        _frm.M_User_Name = M_User_Name
        _frm.ShowDialog()
    End Sub
#End Region
#Region "F8"
    Private Sub V_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _Ma_Xe As String = Dv_Master.Item(iRow).Item("Ma_Xe")
        Dim _Ma_TTCP_H As String = Dv_Master.Item(iRow).Item("Ma_TTCP_H")

        If _Ma_Xe = "" Then Exit Sub
        Dim strAddParar As String = "2#TD2#" + _Ma_Xe + "#" + _Ma_TTCP_H + ""
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
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Mở lệnh", "Edit"), AddressOf V_F2, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In lệnh", "Contact"), AddressOf V_F3, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu nhập kho", "Tạo phiếu nhập kho"), AddressOf V_F4, Nothing, My.Resources.edit_16x16, True, False))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu xuất kho", "Tạo phiếu xuất kho"), AddressOf V_F5, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu thu", "Tạo phiếu thu"), AddressOf V_F6, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo hóa đơn", "Tạo hóa đơn"), AddressOf V_F7, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu ra cổng", "Tạo phiếu ra cổng"), AddressOf V_F8, Nothing, My.Resources.edit_16x16, True, False))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem lịch sử phiếu thu - Hóa đơn", "Xem thông tin phiếu thu - Hóa đơn"), AddressOf V_F9, Nothing, My.Resources.edit_16x16, True, False))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Kết xuất excel", "Kết xuất excel"), AddressOf V_Export_Excel, Nothing, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, False))
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
        Dim _Dt1 As Date = TxtNgay_Ct1.Value
        Dim _Dt2 As Date = TxtNgay_Ct2.Value        

        Dim _Ma_Post1 As String = CmbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2 As String = CmbMa_Post2.SelectedValue.ToString.Trim

        Dim _TTCP As String = CbbMa_TTCP.SelectedValue

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RODsLenh", Status & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") & "#" & IIf(ChkIs_Ngay_Nt.Checked, "1", "0") & "#" & _Ma_Post1.Trim & "#" & _Ma_Post2.Trim & "#" & TxtMa_Hs.Text.Trim & "#" & TxtSo_RO.Text.Trim & "#" & TxtSo_Ro_Hang.Text.Trim & "#" & TxtMa_Xe.Text.Trim & "#" & TxtSo_Khung.Text.Trim & "#" & _TTCP & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)

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

    Private Sub TxtSo_RO_TextChanged(sender As Object, e As EventArgs) Handles TxtSo_RO.Leave
        If TxtSo_RO.Text.Trim = "" Then Return
        V_LoadData("0")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub TxtSo_RO_Hang_TextChanged(sender As Object, e As EventArgs) Handles TxtSo_Ro_Hang.Leave
        If TxtSo_Ro_Hang.Text.Trim = "" Then Return
        V_LoadData("0")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub TxtMa_Xe_TextChanged(sender As Object, e As EventArgs) Handles TxtMa_Xe.Leave
        If TxtMa_Xe.Text.Trim = "" Then Return
        V_LoadData("0")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub TxtSo_Khung_TextChanged(sender As Object, e As EventArgs) Handles TxtSo_Khung.Leave
        If TxtSo_Khung.Text.Trim = "" Then Return
        V_LoadData("0")
        V_SetGridview(MasterGRV)
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