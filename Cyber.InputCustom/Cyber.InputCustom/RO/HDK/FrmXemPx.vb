Public Class FrmXemPx
#Region "AddProperty"
    Public Property CP_Name() As String
        Get
            CP_Name = M_CP_Name
        End Get
        Set(ByVal Value As String)
            M_CP_Name = Value
        End Set
    End Property
    Public Property Filter_Loc() As String
        Get
            Filter_Loc = M_Filter_Loc
        End Get
        Set(ByVal Value As String)
            M_Filter_Loc = Value
        End Set
    End Property
    Public Property Frm_Title() As String
        Get
            Frm_Title = M_Frm_Title
        End Get
        Set(ByVal Value As String)
            M_Frm_Title = Value
        End Set
    End Property
    Public Property So_RO() As String
        Get
            So_RO = M_So_RO
        End Get
        Set(ByVal Value As String)
            M_So_RO = Value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Ma_Ct = M_Ma_Ct
        End Get
        Set(ByVal Value As String)
            M_Ma_Ct = Value
        End Set
    End Property
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
#End Region
#Region "Khai báo biến"
    Dim M_Stt_Rec, M_Ma_Ct, M_Frm_Title, M_So_RO, M_Filter_Loc, M_CP_name As String
    Dim dtDetail, dtHeader As New DataTable
    Dim vdtDetail, vdtHeader As New DataView

    Dim M_Ma_Hs As String = ""
    Dim M_Ten_Hs As String = ""
    Dim M_Ma_BP As String = ""
    Dim M_Ten_BP As String = ""

#End Region
    Private Sub FrmXemPx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        Me.Text = M_Frm_Title
        AddHandler ButtOK.Click, AddressOf V_Nhan
        ' AddHandler CmdExit.Click, AddressOf V_Exit
        '  AddHandler CmdRefresh.Click, AddressOf V_OK
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        GetDefault()
    End Sub
#Region "Load..........."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        V_LoadDatabases("1")
        CyberFill.V_FillReports(MasterGRV, M_LAN, vdtHeader, vdtDetail)
        Master.DataSource = vdtDetail
    End Sub
    Private Sub GetDefault()
        If Not CP_Name.ToString.Trim.ToUpper = "CP_SoDLHenDs".Trim.ToUpper Then Exit Sub
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetBpHs", M_User_Name.ToString().Trim())
        Dim _Dt_Bp_Hs As DataTable = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        '---------------------------------------------------------------------------------------------'
        If _Dt_Bp_Hs.Columns.Contains("Ma_Hs_H") Then M_Ma_Hs = _Dt_Bp_Hs.Rows(0).Item("Ma_HS_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_Hs_H") Then M_Ten_Hs = _Dt_Bp_Hs.Rows(0).Item("Ten_Hs_H")
        If _Dt_Bp_Hs.Columns.Contains("Ma_BP_H") Then M_Ma_BP = _Dt_Bp_Hs.Rows(0).Item("Ma_BP_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_BP_H") Then M_Ten_BP = _Dt_Bp_Hs.Rows(0).Item("Ten_BP_H")

    End Sub

    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabases("0")
    End Sub
    Private Sub V_LoadDatabases(ByVal status)
 
        Dim DsXemPX As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_CP_name, M_Filter_Loc)
        If status.ToString.Trim = "1" Then
            dtDetail = New DataTable
            dtHeader = New DataTable

            dtDetail = DsXemPX.Tables(0).Copy
            dtHeader = DsXemPX.Tables(1).Copy

            vdtDetail = New DataView(dtDetail)
            vdtHeader = New DataView(dtHeader)
        End If
        dtDetail.Clear()
        For i As Integer = 0 To DsXemPX.Tables(0).Rows.Count - 1
            dtDetail.ImportRow(DsXemPX.Tables(0).Rows(i))
        Next
        DsXemPX.Dispose()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "PXK"
    Dim ProccessList As New Collection
    Private Sub V_Edit_PXK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _iRow As Integer = -1
        _iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        If Not dtDetail.Columns.Contains("Stt_Rec") Or Not dtDetail.Columns.Contains("Ma_CT") Then Exit Sub
        Dim _Stt_Rec As String = vdtDetail.Item(_iRow).Item("Stt_Rec").ToString.Trim
        Dim _ma_CT As String = vdtDetail.Item(_iRow).Item("Ma_CT").ToString.Trim
        If _Stt_Rec.Trim = "" Or _ma_CT.Trim = "" Then Exit Sub
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _ma_CT, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Function GetProcess(ByVal pPath As String, ByVal pParam As String, ByRef ReturnTo As Process) As Process
        ReturnTo = Process.Start(pPath, pParam)
        Return ReturnTo
    End Function
    Private Sub V_Print_PXK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _iRow As Integer = -1
        _iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        If Not dtDetail.Columns.Contains("Stt_Rec") Or Not dtDetail.Columns.Contains("Ma_CT") Or Not dtDetail.Columns.Contains("Ma_Post") Or Not dtDetail.Columns.Contains("Ngay_CT") Then Exit Sub

        Dim _Stt_Rec As String = vdtDetail.Item(_iRow).Item("Stt_Rec").ToString.Trim
        Dim _ma_CT As String = vdtDetail.Item(_iRow).Item("Ma_CT").ToString.Trim
        Dim _Ma_Post As String = vdtDetail.Item(_iRow).Item("Ma_Post").ToString.Trim
        Dim _Ngay_CT As Date = vdtDetail.Item(_iRow).Item("Ngay_CT")

        Dim DrDmct As DataRow = CyberSmodb.SQLGetRow(AppConn, "DMCT", "Ma_CT =N'" + _ma_CT.Trim + "'", CyberSmlib)

        If Not ChkRightsVoucher("P", _Ngay_CT, _Ma_Post, _Stt_Rec, _ma_CT) Then Exit Sub
        If _Stt_Rec.Trim = "" Then Exit Sub
        CyberVoucher.V_PrintVocuher(AppConn, Me.Sysvar, Nothing, _Stt_Rec, _Ngay_CT, _Ma_Post, M_LAN, Me.Para, DrDmct, _ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

    End Sub
    Private Sub V_Print_PIC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _iRow As Integer = -1
        _iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        If Not dtDetail.Columns.Contains("Stt_Rec") Or Not dtDetail.Columns.Contains("Ma_CT") Or Not dtDetail.Columns.Contains("Ma_Post") Or Not dtDetail.Columns.Contains("Ngay_CT") Then Exit Sub

        Dim _Stt_Rec As String = vdtDetail.Item(_iRow).Item("Stt_Rec").ToString.Trim
        Dim _ma_CT As String = vdtDetail.Item(_iRow).Item("Ma_CT").ToString.Trim
        Dim _Ma_Post As String = vdtDetail.Item(_iRow).Item("Ma_Post").ToString.Trim
        Dim _Ngay_CT As Date = vdtDetail.Item(_iRow).Item("Ngay_CT")

        Dim DrDmct As DataRow = CyberSmodb.SQLGetRow(AppConn, "DMCT", "Ma_CT =N'" + _ma_CT.Trim + "'", CyberSmlib)

        If Not ChkRightsVoucher("P", _Ngay_CT, _Ma_Post, _Stt_Rec, _ma_CT) Then Exit Sub
        If _Stt_Rec.Trim = "" Then Exit Sub
        CyberVoucher.V_PrintVocuher(AppConn, Me.Sysvar, Nothing, _Stt_Rec, _Ngay_CT, _Ma_Post, M_LAN, Me.Para, DrDmct, _ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

    End Sub

    Private Function ChkRightsVoucher(ByVal _Mode As String, ByVal _DT As Date, ByVal _ma_Post As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String) As Boolean
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_DT, _Mode, _ma_Post, _Stt_Rec, _Ma_Ct, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, Me.Sysvar, CyberSmlib)
    End Function
    Private Sub KillProce()
        Try
            Dim op As Process
            For i As Integer = ProccessList.Count To 1 Step -1
                op = ProccessList(i)
                If Not op Is Nothing Then
                    If Not op.HasExited() Then
                        op.Kill()
                        ProccessList.Remove(i)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
#End Region
 
#Region "Grid View..........."
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
 
        If CP_Name.ToString.Trim.ToUpper = "CP_RoXemLichsuPX".Trim.ToUpper Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem phiếu xuất kho", "Print"), AddressOf V_Edit_PXK, Shortcut.F3, Nothing, True, True), False)
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "In phiếu xuất", "Print"), AddressOf V_Print_PXK, Shortcut.F7, Nothing, True, True), False)
        End If

        If CP_Name.ToString.Trim.ToUpper = "CP_RoXemLichsuPIC".Trim.ToUpper Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "In phiếu xuất", "Print"), AddressOf V_Print_PIC, Shortcut.F7, Nothing, True, True), False)
        End If

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, Nothing, True, True), True)
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, Nothing, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle(sender, e, MasterGRV, dtDetail, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", CyberColor)
    End Sub
    Private Sub MasterGRV_RowCellStyle_luu(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim Dt_Master As New DataTable
        Dim vDt_Master As New DataView
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim CyberColor As New Cyber.Color.Sys
        Grid = sender

        If Grid.DataSource.GetType.Name.Trim.ToUpper = "DATAVIEW" Then
            vDt_Master = Grid.DataSource
            Dt_Master = vDt_Master.Table
        Else
            Dt_Master = Grid.DataSource
        End If

        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If

        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#End Region
End Class
