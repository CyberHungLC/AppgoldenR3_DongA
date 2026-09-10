Imports System.Windows.Forms
Public Class CRM_GuiSMS
    Dim Dt_Master, Dt_Head, Dt_Filter0, Dt_Filter1 As DataTable
    Dim Dv_Master, Dv_Head, Dv_Filter0, Dv_Filter1 As DataView
    Dim Dt_TTCP As DataTable
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Dim _KeyTP As String = "0"
    Dim _KeyQuan As String = "0"
    Dim M_Ma_LoaiSMS As String = "", M_Title As String = ""
    Dim _Id_GuiSMS As String = ""
    Public M_Dt_Return As DataTable
    Private Sub CRM_SMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_AddHander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load()
        'Load Default
        V_Getdefault()
        'Load data
        V_LoadData("1")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_AddHander()
        AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab

        AddHandler TxtND1.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtND5.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtBody.TextChanged, AddressOf V_So_Tin_Nhan

        AddHandler TxtND1.TextChanged, AddressOf V_Ghep
        AddHandler TxtND5.TextChanged, AddressOf V_Ghep
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_Ghep
        AddHandler ButtOK.Click, AddressOf V_Loc
        AddHandler ButtClearFilter.Click, AddressOf V_XoaLoc

        'Ma_LoaiCS
        AddHandler TxtMa_LoaiCS.CyberValiting, AddressOf V_Ma_LoaiCS
        AddHandler TxtMa_LoaiCS.CyberLeave, AddressOf L_Ma_LoaiCS

        'Ma_Cs
        AddHandler TxtMa_Cs.CyberValiting, AddressOf V_Ma_Cs
        AddHandler TxtMa_Cs.CyberLeave, AddressOf L_Ma_Cs

        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx

        'Nh_Kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2

        AddHandler ChkTat_Ca.Click, AddressOf V_SelectAll
        AddHandler ChkDa_Gui.Click, AddressOf V_SelectDa_Gui
        AddHandler ChkChua_Gui.Click, AddressOf V_SelectChua_Gui

        AddHandler CmdXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler TxtSearch.TextChanged, AddressOf V_Search

        'Đếm ký tự
        AddHandler TxtBody.TextChanged, AddressOf V_Tinh_Toan

        'Thời gian gửi
        AddHandler ChkThoi_Gian_Gui.CheckedChanged, AddressOf V_Thoi_Gian_Gui

        'Send
        AddHandler CmdSendSMS.Click, AddressOf V_SendSMS
        '-----------------------------------------------------------------------------------------
        'RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        'AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
    End Sub
#Region "Button"
    Private Sub V_SendSMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--> Gửi SMS Click
        If TxtMa_SMS.Text = "" Then
            MsgBox("Vui lòng chọn Template", vbOKOnly + vbCritical, M_CYBER_VER)
            Exit Sub
        End If

        If Dt_Master.Select("Tag = 1").Count = 0 Then
            MsgBox("Vui lòng chọn ít nhất 1 dòng", vbOKOnly + vbCritical, M_CYBER_VER)
            Exit Sub
        End If

        Dim _dtMaster As DataTable = Dt_Master.Clone()
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            _dtMaster.ImportRow(Dt_Master.Rows(i))
        Next

        If _dtMaster.Rows.Count < 1 Then
            Exit Sub
        End If

        Dim _MsgResult = MsgBox("Xác nhận gửi tin nhắn?", vbOKCancel + vbCritical, M_CYBER_VER)
        If _MsgResult = MsgBoxResult.Ok Then
            V_Gui(_dtMaster)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub V_Gui(ByRef _DtSms As DataTable)
        Dim DsSmsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.SMSTemp WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtSMSTmp As DataTable = DsSmsTmp.Tables(0).Copy
        DsSmsTmp.Dispose()

        Dim DtSendSMS As DataTable
        Dim _Noi_Dung As String = TxtNoi_Dung.Text.Trim.Replace("#", "%23")

        CyberSmodb.SQLTbToTb(Dt_Master, DtSMSTmp)
        Dim smKey As String = "1=1"
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtSMSTmp, "SMSTemp", "", smKey)

        Dim M_strParameterStore As String = TxtMa_SMS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtND1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Noi_Dung
        M_strParameterStore = M_strParameterStore & "#" & _Noi_Dung
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim

        Me.Tag = M_strParameterStore

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_SaveSMS", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            DsTmp.Dispose()
            Exit Sub
        Else
            Me.M_Dt_Return = DsTmp.Tables(0).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
        End If
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Loc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData("0")
        V_SetGridview(MasterGRV)
        ChkTat_Ca.Checked = False
        ChkDa_Gui.Checked = False
        ChkChua_Gui.Checked = False
    End Sub
    Private Sub V_XoaLoc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.Text = ""
        TxtNh_Kx2.Text = ""
        CmbTT_CS.SelectedValue = ""
        TxtMa_LoaiCS.Text = ""
        TxtMa_Xe.Text = ""
        TxtMa_Cs.Text = ""
        TxtTen_Kx.Text = ""
        TxtTen_LoaiCS.Text = ""
        TxtTen_Cs.Text = ""
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_History(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _dtMaster As DataTable = Dt_Master.Clone()
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            _dtMaster.ImportRow(Dt_Master.Rows(i))
        Next

        If _dtMaster.Rows.Count = 0 Then
            Dim Dr As DataRow = MasterGRV.GetFocusedRow.Row
            _dtMaster.ImportRow(Dr)
        End If

        If _dtMaster.Rows.Count < 1 Then
            Exit Sub
        End If
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "Danh sách nút chức năng"
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)

        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_SetGridview(ByVal _MasterGRV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
        CyberFill.V_GridviewRowCellStyle(_MasterGRV)
    End Sub
#End Region
#Region "Load Default"
    Private Sub V_Getdefault()
        M_Ma_LoaiSMS = Me.Para(M_VT_PARA + 2).ToString.Trim()
        If M_Ma_LoaiSMS = "" Then M_Title = "" Else M_Title = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhSMSTemplate", "Loai_Nh = '1' AND Ma_Nh = '" & M_Ma_LoaiSMS & "'", CyberSmlib)
        If Not M_Title = "" Then Me.Text = M_Title

        Dim DtTT_CS As DataTable = New DataTable
        DtTT_CS.Columns.Add("Ma_TTCS")
        DtTT_CS.Columns.Add("Ten_TTCS")
        DtTT_CS.Columns.Add("Ten_TTCS2")
        DtTT_CS.Columns.Add("Ngam_Dinh")
        DtTT_CS.Rows.Add("", "Tât cả", "All", "1")
        DtTT_CS.Rows.Add("01", "Đã chăm sóc", "Called", "0")
        DtTT_CS.Rows.Add("02", "Chưa chăm sóc", "Not called yet", "0")

        CyberFill.V_FillComBoxDefaul(CmbTT_CS, DtTT_CS, "Ma_TTCS", IIf(Me.Lan = "V", "Ten_TTCS", "Ten_TTCS2"), "Ngam_Dinh")

        'Dim _DsDefault As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadReportsTTCP", M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        'If _DsDefault.Tables.Count < 1 Then
        '    _DsDefault.Dispose()
        '    Exit Sub
        'End If

        'If _DsDefault.Tables(0).Rows.Count < 1 Then
        '    _DsDefault.Dispose()
        '    Exit Sub
        'End If

        TxtNgay_Ct1.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        TxtNgay_Ct2.Value = Date.Now
        TxtNgay_Ct1.Focus()

        TxtMa_Xe.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Xe)
        TxtMa_Kx.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Kx)

        TxtNh_Kx2.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx2)

        If TxtMa_Kx.Text = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "Ma_kx = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmlib)
        V_Thoi_Gian_Gui()
    End Sub
#End Region
#Region "LoadData"
    Private Sub V_LoadData(ByVal Status As String)
        Dim _Dt1 As Date = TxtNgay_Ct1.Value
        Dim _Dt2 As Date = TxtNgay_Ct2.Value

        Dim _Ma_LoaiCS As String = TxtMa_LoaiCS.Text.Trim

        Dim _Ma_Xe As String = TxtMa_Xe.Text.Trim
        Dim _Ma_KX As String = TxtMa_Kx.Text.Trim
        Dim _TTCS As String = CmbTT_CS.SelectedValue.ToString.Trim
        Dim _Ma_Cs As String = TxtMa_Cs.Text.Trim



        Dim _Nh_Kx2 As String = TxtNh_Kx2.Text.Trim


        Dim _Ma_ChienDich As String = ""

        Dim _Is_Ngay1 As String = "0"
        Dim _Is_Ngay_SMS As String = "0"
        Dim _Is_Ngay_D As String = "0"

        _Is_Ngay1 = IIf(ChkIs_Ngay1.Checked = True, "1", _Is_Ngay1)
        _Is_Ngay_SMS = IIf(ChkIs_Ngay_SMS.Checked = True, "1", _Is_Ngay_SMS)
        _Is_Ngay_D = IIf(ChkIs_Ngay_D.Checked = True, "1", _Is_Ngay_D)

        Dim _StrParameter As String = Status & "#" & M_Ma_LoaiSMS & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") &
            "#" & _Ma_LoaiCS & "#" & _Ma_Xe & "#" & _TTCS & "#" & _Ma_Cs & "#" & _Ma_KX & "#" & _Nh_Kx2 & "#" & _Ma_ChienDich &
            "#" & _Is_Ngay1 & "#" & _Is_Ngay_SMS & "#" & _Is_Ngay_D & "#" & M_Ma_Dvcs & "#" & M_User_Name

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmsToCustomer", _StrParameter)

        If DsTmp.Tables.Count < 2 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(4), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dt_Master = DsTmp.Tables(0).Copy
        Dt_Head = DsTmp.Tables(2).Copy
        _Id_GuiSMS = DsTmp.Tables(6).Rows(0).Item("Id_GuiSMS").ToString()
        Dv_Master = New DataView(Dt_Master)
        Dv_Head = New DataView(Dt_Head)
        MasterGRV.OptionsBehavior.Editable = True
        CyberFill.V_FillReportsBanded(MasterGRV, M_LAN, Dt_Head, Dv_Master)
        MasterGRV.GridControl.DataSource = Dv_Master

        LoadFilter()
        V_Tinh_Toan()
        DsTmp.Dispose()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_LoaiCS"
    Private Sub V_Ma_LoaiCS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_LoaiCS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "CrmMa_Loai", "CrmDmLoai", "1=1", "CrmLoai = 'CS'")
    End Sub
    Private Sub L_Ma_LoaiCS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_LoaiCS.Text = "" Then
            TxtTen_LoaiCS.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_LoaiCS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LoaiCS.Text = DrReturn.Item("CrmMa_Loai")
            TxtTen_LoaiCS.Text = DrReturn.Item("CrmTen_Loai")
        Else
            TxtMa_LoaiCS.Text = ""
            TxtTen_LoaiCS.Text = ""
        End If

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLLoad_Filter", "CS#" + TxtMa_LoaiCS.Text.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtDsLenh As DataTable = DsTmp.Tables(3).Copy

    End Sub
#End Region
#Region "Valid --- Ma_Cs"
    Private Sub V_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cs.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Cs.Text = "" Then
            TxtTen_Cs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Cs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Cs.Text = ""
            TxtTen_Cs.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_SMS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_SMS", "DmSMSTemplate", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_SMS.Text = "" Then
            TxtTen_SMS.Text = ""
            TxtNoi_Dung.Text = ""
            TxtND1.Text = ""
            TxtND5.Text = ""
            TxtBody.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_SMS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SMS.Text = DrReturn.Item("Ma_SMS")
            TxtTen_SMS.Text = DrReturn.Item("Ten_SMS")
            TxtND1.Text = DrReturn.Item("ND1")
            TxtNoi_Dung.Text = DrReturn.Item("Body")
            TxtND5.Text = DrReturn.Item("ND5")
            V_Ghep()
            V_So_Tin_Nhan()
        Else
            TxtMa_SMS.Text = ""
            TxtTen_SMS.Text = ""
            TxtND1.Text = ""
            TxtNoi_Dung.Text = ""
            TxtND5.Text = ""
            V_Ghep()
            V_So_Tin_Nhan()
        End If
    End Sub
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region

#Region "Valid --- Nh_Kx2"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx2.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx2.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            TxtTen_Nh_Kx2.Text = ""
        End If
    End Sub
#End Region

#End Region

#Region "Add-on"
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
        If ChkTat_Ca.Checked = True Then
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If _Type Then Dv_Master.Item(i).Item("Tag") = True Else Dv_Master.Item(i).Item("Tag") = "1"
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        Else
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        End If
    End Sub
    Private Sub V_SelectDa_Gui(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next

        If ChkDa_Gui.Checked = True Then
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If Dv_Master.Item(i).Item("Is_SMS") = "1" Then
                    If _Type Then
                        Dv_Master.Item(i).Item("Tag") = True
                    Else
                        Dv_Master.Item(i).Item("Tag") = "1"
                    End If
                End If
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        Else
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        End If
    End Sub
    Private Sub V_SelectChua_Gui(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        If ChkChua_Gui.Checked = True Then
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If Dv_Master.Item(i).Item("Is_SMS") = "0" Then
                    If _Type = True Then
                        Dv_Master.Item(i).Item("Tag") = True
                    Else
                        Dv_Master.Item(i).Item("Tag") = "1"
                    End If
                End If
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        Else
            For i As Integer = 0 To Dv_Master.Count - 1
                Dv_Master.Item(i).BeginEdit()
                If _Type = True Then
                    Dv_Master.Item(i).Item("Tag") = False
                Else
                    Dv_Master.Item(i).Item("Tag") = "0"
                End If
                Dv_Master.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            Next
        End If
    End Sub
    Private Sub LoadFilter()
        Dt_Filter0 = New DataTable
        Dt_Filter1 = New DataTable

        Dt_Filter1.Columns.Add("Field_Name")
        Dt_Filter1.Columns.Add("Field_Type")

        Dt_Filter0.Columns.Add("Ma")
        Dt_Filter0.Columns.Add("Ten")
        Dt_Filter0.Columns.Add("Default")

        Dim _Field_Name As String = ""
        Dim _Field_Head As String = ""
        Dim _Field_Type As String = ""
        Dt_Filter0.Rows.Add("", "Tất cả", "0")

        For i As Integer = 1 To Dt_Head.Rows.Count - 1
            _Field_Name = Dt_Head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_Head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_Head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        Dv_Filter0 = New DataView(Dt_Filter0)
        Dv_Filter1 = New DataView(Dt_Filter1)
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0
        _FieldName = ComFilter.SelectedValue.ToString.Trim

        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, Dv_Filter1, _FieldName, _Value, "%")

        _Filter1 = "1=1"
        If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        MasterGRV.ActiveFilterString = _Filter
        MasterGRV.FocusedRowHandle = 0
    End Sub
#Region "Tính toán"
    Private Sub V_So_Tin_Nhan()
        If TxtBody.Text = "" Then
            LabLeng.Text = 0
            LabSo_Tin_Nhan.Text = 0
            Return
        ElseIf TxtBody.Text <> "" Then
            Dim _len As Double = 0, _So_Tin As Double = 0
            _len = Len(TxtBody.Text)
            _So_Tin = _len \ 160 + 1
            LabLeng.Text = _len
            LabSo_Tin_Nhan.Text = _So_Tin & " TN"
        End If
    End Sub
    Private Sub V_Ghep()
        If TxtNoi_Dung.Text <> "" Then TxtBody.Text = TxtND1.Text & ". " & TxtNoi_Dung.Text & ". " & TxtND5.Text
    End Sub

    Private Sub V_Tinh_Toan()
        Dim _Tong_Cong As Double = 0, _Da_Gui As Double = 0, _Chua_Gui As Double = 0

        _Tong_Cong = Dt_Master.Rows.Count

        If Dt_Master.Rows.Count = 0 Then
            _Da_Gui = 0
            _Chua_Gui = 0
        Else
            _Da_Gui = Dt_Master.Select("Is_SMS = 1").Count
            _Chua_Gui = Dt_Master.Select("Is_SMS = 0").Count
        End If

        TxtTong_Cong.Text = _Tong_Cong
        TxtDa_Gui.Text = _Da_Gui
        TxtChua_Gui.Text = _Chua_Gui
    End Sub
#End Region
    Private Sub V_Thoi_Gian_Gui()
        Dim _En As Boolean = ChkThoi_Gian_Gui.Checked
        TxtNgay_Gui.Enabled = _En
        TxtNgay_Gui.Value = DateTime.Now
        If _En = True Then TxtNgay_Gui.Focus()
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
    Public Function V_GetValueCombox(ByVal _Cbb As ComboBox) As String
        Dim _Return As String = ""
        Try
            _Return = _Cbb.SelectedValue.ToString.Trim
        Catch ex As Exception
            _Return = ""
        End Try
        V_GetValueCombox = _Return
    End Function
#End Region
End Class