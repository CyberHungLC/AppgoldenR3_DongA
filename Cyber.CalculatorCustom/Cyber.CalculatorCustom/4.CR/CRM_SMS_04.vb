Imports System.Windows.Forms
Public Class CRM_SMS_04
    Dim Dt_Master, Dt_Head, Dt_Filter0, Dt_Filter1 As DataTable
    Dim Dv_Master, Dv_Head, Dv_Filter0, Dv_Filter1 As DataView
    Dim Dt_TTCP As DataTable
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Dim _KeyTP As String = "0"
    Dim _KeyQuan As String = "0"
    Dim M_Ma_LoaiSMS As String = "", M_Title As String = ""
    Dim _Id_GuiSMS As String = ""
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
        V_SetTxt()

        'Load data
        V_LoadData("1")
        V_SetGridview(MasterGRV)
    End Sub
    Private Sub V_AddHander()
        AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab

        AddHandler ButtOK.Click, AddressOf V_Loc
        AddHandler ButtClearFilter.Click, AddressOf V_XoaLoc

        'Ma_NN
        AddHandler CmdChon_NN.Click, AddressOf V_ChonNN

        'Ma_GT
        AddHandler TxtMa_GT.CyberValiting, AddressOf V_Ma_GT
        AddHandler TxtMa_GT.CyberLeave, AddressOf L_Ma_GT

        'Ma_NhaMang
        AddHandler TxtMa_NhaMang.CyberValiting, AddressOf V_Ma_NhaMang
        AddHandler TxtMa_NhaMang.CyberLeave, AddressOf L_Ma_NhaMang

        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx

        'Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau

        'Nh_Kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1

        'Nh_Kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2

        'Nh_Kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3

        'Nh_Kx4
        AddHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_Kx4
        AddHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_Kx4

        'Nh_Kx5
        AddHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_Kx5
        AddHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_Kx5

        'Nh_Kx6
        AddHandler TxtNh_Kx6.CyberValiting, AddressOf V_Nh_Kx6
        AddHandler TxtNh_Kx6.CyberLeave, AddressOf L_Nh_Kx6

        'Nh_Kx7
        AddHandler TxtNh_Kx7.CyberValiting, AddressOf V_Nh_Kx7
        AddHandler TxtNh_Kx7.CyberLeave, AddressOf L_Nh_Kx7

        'Nh_Kx8
        AddHandler TxtNh_Kx8.CyberValiting, AddressOf V_Nh_Kx8
        AddHandler TxtNh_Kx8.CyberLeave, AddressOf L_Nh_Kx8

        'Nh_Kx9
        AddHandler TxtNh_Kx9.CyberValiting, AddressOf V_Nh_Kx9
        AddHandler TxtNh_Kx9.CyberLeave, AddressOf L_Nh_Kx9

        'Ma_TP
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP

        'Ma_Quan
        AddHandler TxtMa_Quan.CyberValiting, AddressOf V_Ma_Quan
        AddHandler TxtMa_Quan.CyberLeave, AddressOf L_Ma_Quan

        'Ma_Xa
        AddHandler TxtMa_Xa.CyberValiting, AddressOf V_Ma_Xa
        AddHandler TxtMa_Xa.CyberLeave, AddressOf L_Ma_Xa

        'Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP

        'Ma_TP
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP

        'Ma_SMS
        AddHandler TxtMa_SMS.CyberValiting, AddressOf V_Ma_SMS
        AddHandler TxtMa_SMS.CyberLeave, AddressOf L_Ma_SMS

        AddHandler ChkTat_Ca.Click, AddressOf V_SelectAll
        AddHandler ChkDa_Gui.Click, AddressOf V_SelectDa_Gui
        AddHandler ChkChua_Gui.Click, AddressOf V_SelectChua_Gui

        AddHandler CmdXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler TxtSearch.TextChanged, AddressOf V_Search

        'set txt
        AddHandler ChkIs_Ngay_Sinh.CheckedChanged, AddressOf V_SetTxt

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
        Dim DsSmsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.SmsData WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtSMSTmp As DataTable = DsSmsTmp.Tables(0).Copy
        DsSmsTmp.Dispose()

        CyberSmodb.SQLTbToTb(_DtSms, DtSMSTmp)
        Dim smKey As String = "1=1"
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtSMSTmp, "SmsData", "", smKey)

        Dim _ChkSuaNgay As String = IIf(ChkThoi_Gian_Gui.Checked = True, "1", "0")
        Dim _Noi_Dung As String = TxtBody.Text.Trim
        Dim _Ngay_Gui As DateTime = TxtNgay_Gui.Value

        Dim M_strParameterStore As String = _Id_GuiSMS & "#" & TxtMa_SMS.Text.Trim & "#" & _Noi_Dung
        M_strParameterStore = M_strParameterStore & "#" & _ChkSuaNgay
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_Gui.ToString("yyyyMMdd hh:mm:ss")
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim

        Me.Tag = M_strParameterStore

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SMSToCustomer_SaveSMS", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            DsTmp.Dispose()
            Exit Sub
        Else
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
        TxtMa_TTCP.Text = ""
        TxtMa_TP.Text = ""
        TxtMa_Quan.Text = ""
        TxtMa_Xa.Text = ""
        TxtMa_NN.Text = ""
        TxtMa_GT.Text = ""
        TxtMa_Kx.Text = ""
        TxtMa_Mau.Text = ""
        TxtNh_Kx1.Text = ""
        TxtNh_Kx2.Text = ""
        TxtNh_Kx3.Text = ""
        TxtNh_Kx4.Text = ""
        TxtNh_Kx5.Text = ""
        TxtNh_Kx6.Text = ""
        TxtNh_Kx7.Text = ""
        TxtNh_Kx8.Text = ""
        TxtNh_Kx9.Text = ""
        TxtMa_NhaMang.Text = ""

        TxtMa_Xe.Text = ""
        TxtTen_TTCP.Text = ""
        TxtTen_TP.Text = ""
        TxtTen_Quan.Text = ""
        TxtTen_Xa.Text = ""
        TxtTen_GT.Text = ""
        TxtTen_Kx.Text = ""
        TxtTen_Mau.Text = ""
        TxtTen_NhaMang.Text = ""

        ChkIs_Ngay_Sinh.Checked = False
        V_SetTxt()
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

        Dim _DsDefault As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadReportsTTCP", M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        If _DsDefault.Tables.Count < 1 Then
            _DsDefault.Dispose()
            Exit Sub
        End If

        If _DsDefault.Tables(0).Rows.Count < 1 Then
            _DsDefault.Dispose()
            Exit Sub
        End If

        TxtNgay_Ct1.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        TxtNgay_Ct2.Value = Date.Now
        TxtNgay_Ct1.Focus()

        TxtMa_Kx.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Kx)
        TxtMa_Mau.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Mau)
        TxtNh_Kx1.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx1)
        TxtNh_Kx2.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx2)
        TxtNh_Kx3.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx3)
        TxtNh_Kx4.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx4)
        TxtNh_Kx5.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx5)
        TxtNh_Kx6.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx6)
        TxtNh_Kx7.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx7)
        TxtNh_Kx8.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx8)
        TxtNh_Kx9.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_Kx9)
        TxtMa_TP.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_TP)
        TxtMa_Quan.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Quan)
        TxtMa_Xa.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Xa)
        TxtMa_TTCP.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_TTCP)
        TxtMa_GT.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_GT)
        TxtMa_NN.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_NN)

        If TxtMa_GT.Text = "" Then TxtTen_GT.Text = "" Else TxtTen_GT.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten", "CRDmGioiTinh", "Ma = N'" + TxtMa_GT.Text.Trim + "'", CyberSmlib)
        If TxtMa_Kx.Text = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "Ma_kx = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmlib)
        If TxtMa_Mau.Text = "" Then TxtTen_Mau.Text = "" Else TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMau", "Ma_Mau = N'" + TxtMa_Mau.Text.Trim + "'", CyberSmlib)
        If TxtMa_TP.Text = "" Then TxtTen_TP.Text = "" Else TxtTen_TP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TP", "DmTP", "Ma_TP = N'" + TxtMa_TP.Text.Trim + "'", CyberSmlib)
        If TxtMa_Quan.Text = "" Then TxtTen_Quan.Text = "" Else TxtTen_Quan.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Quan", "DmQuan", "Ma_Quan = N'" + TxtMa_Quan.Text.Trim + "'", CyberSmlib)
        If TxtMa_Xa.Text = "" Then TxtTen_Xa.Text = "" Else TxtTen_Xa.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Xa", "DmXa", "Ma_Xa = N'" + TxtMa_Xa.Text.Trim + "'", CyberSmlib)
        If TxtMa_TTCP.Text = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "Ma_TTCP = N'" + TxtMa_TTCP.Text.Trim + "'", CyberSmlib)

        V_Thoi_Gian_Gui()
    End Sub
#End Region
#Region "LoadData"
    Private Sub V_LoadData(ByVal Status As String)
        Dim _Dt1 As DateTime = TxtNgay_Ct1.Value
        Dim _Dt2 As DateTime = TxtNgay_Ct2.Value

        Dim _Ma_LoaiCS As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Ma_Xe As String = TxtMa_Xe.Text.Trim
        Dim _TTCS As String = ""
        Dim _Ma_Cs As String = ""
        Dim _Ma_TTCP As String = TxtMa_TTCP.Text.Trim
        Dim _Ma_HSGX As String = ""
        Dim _Ma_TT As String = ""
        Dim _Ma_TP As String = TxtMa_TP.Text.Trim
        Dim _Ma_Quan As String = TxtMa_Quan.Text.Trim
        Dim _Ma_Xa As String = TxtMa_Xa.Text.Trim
        Dim _Ma_Kx As String = TxtMa_Kx.Text.Trim
        Dim _Ma_Mau As String = TxtMa_Mau.Text.Trim
        Dim _Nh_Kx1 As String = TxtNh_Kx1.Text.Trim
        Dim _Nh_Kx2 As String = TxtNh_Kx2.Text.Trim
        Dim _Nh_Kx3 As String = TxtNh_Kx3.Text.Trim
        Dim _Nh_Kx4 As String = TxtNh_Kx4.Text.Trim
        Dim _Nh_Kx5 As String = TxtNh_Kx5.Text.Trim
        Dim _Nh_Kx6 As String = TxtNh_Kx6.Text.Trim
        Dim _Nh_Kx7 As String = TxtNh_Kx7.Text.Trim
        Dim _Nh_Kx8 As String = TxtNh_Kx8.Text.Trim
        Dim _Nh_Kx9 As String = TxtNh_Kx9.Text.Trim
        Dim _Ma_LanKTDK1 As String = ""
        Dim _Ma_LanKTDK2 As String = ""
        Dim _Ma_LanLH1 As String = ""
        Dim _Ma_LanLH2 As String = ""
        Dim _Ma_PhanLoai As String = ""
        Dim _Ma_ChienDich As String = ""
        Dim _Ma_Sk As String = ""
        Dim _Ma_NN As String = TxtMa_NN.Text.Trim
        Dim _Ma_GT As String = TxtMa_GT.Text.Trim
        Dim _Dt3 As DateTime
        Dim _Dt4 As DateTime
        Dim _Ma_KN As String = ""
        Dim _Ma_NhaMang As String = TxtMa_NhaMang.Text.Trim

        If Not IsDBNull(TxtNgay_Sinh1.Value) Then
            _Dt3 = CDate(TxtNgay_Sinh1.Value)
        Else
            _Dt3 = New Date(1900, 1, 1)
        End If
        If Not IsDBNull(TxtNgay_Sinh2.Value) Then
            _Dt4 = CDate(TxtNgay_Sinh2.Value)
        Else
            _Dt4 = New Date(1900, 1, 1)
        End If

        Dim _Is_Ngay1 As String = "0"
        Dim _Is_Ngay_SMS As String = "0"
        Dim _Is_Ngay_D As String = "0"

        _Is_Ngay1 = IIf(ChkIs_Ngay1.Checked = True, "1", _Is_Ngay1)
        _Is_Ngay_SMS = IIf(ChkIs_Ngay_SMS.Checked = True, "1", _Is_Ngay_SMS)
        _Is_Ngay_D = IIf(ChkIs_Ngay_D.Checked = True, "1", _Is_Ngay_D)

        Dim _StrParameter As String = Status & "#" & M_Ma_LoaiSMS & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") &
            "#" & _Ma_LoaiCS & "#" & _Ma_Ct & "#" & _Ma_Xe & "#" & _TTCS & "#" & _Ma_Cs & "#" & _Ma_TTCP & "#" & _Ma_HSGX & "#" & _Ma_TT &
            "#" & _Ma_TP & "#" & _Ma_Quan & "#" & _Ma_Xa & "#" & _Ma_Kx & "#" & _Ma_Mau & "#" & _Nh_Kx1 & "#" & _Nh_Kx2 & "#" & _Nh_Kx3 &
            "#" & _Nh_Kx4 & "#" & _Nh_Kx5 & "#" & _Nh_Kx6 & "#" & _Nh_Kx7 & "#" & _Nh_Kx8 & "#" & _Nh_Kx9 & "#" & _Ma_LanKTDK1 &
            "#" & _Ma_LanKTDK2 & "#" & _Ma_LanLH1 & "#" & _Ma_LanLH2 & "#" & _Ma_PhanLoai & "#" & _Ma_ChienDich & "#" & _Ma_Sk & "#" & _Ma_NN &
            "#" & _Ma_GT & "#" & _Dt3.ToString("yyyyMMdd") & "#" & _Dt4.ToString("yyyyMMdd") &
            "#" & _Ma_KN & "#" & _Ma_NhaMang & "#" & _Is_Ngay1 & "#" & _Is_Ngay_SMS & "#" & _Is_Ngay_D & "#" & M_Ma_Dvcs & "#" & M_User_Name

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmsToCustomer", _StrParameter)

        If DsTmp.Tables.Count < 2 Then
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
#Region "Valid --- Ma_NN"
    Private Sub V_ChonNN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(AppConn, Me.Sysvar, Me.Para, "CP_GetListSelect", "DmNN#" & TxtMa_NN.Text.Trim & "##" & M_Ma_Dvcs & "#" & M_User_Name, Me.Lan)
        If str Is Nothing Then Exit Sub
        TxtMa_NN.Text = str
    End Sub
#End Region
#Region "Valid --- Ma_GT"
    Private Sub V_Ma_GT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_GT.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma", "CRDmGioiTinh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_GT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_GT.Text = "" Then
            TxtTen_GT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_GT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_GT.Text = DrReturn.Item("Ma")
            TxtTen_GT.Text = DrReturn.Item("Ten")
        Else
            TxtMa_GT.Text = ""
            TxtTen_GT.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_NhaMang"
    Private Sub V_Ma_NhaMang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NhaMang.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NhaMang", "DmNhaMang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NhaMang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_NhaMang.Text = "" Then
            TxtTen_NhaMang.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_NhaMang.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NhaMang.Text = DrReturn.Item("Ma_NhaMang")
            TxtTen_NhaMang.Text = DrReturn.Item("Ten_NhaMang")
        Else
            TxtMa_NhaMang.Text = ""
            TxtTen_NhaMang.Text = ""
        End If
    End Sub
#End Region
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
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx1.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx1.Text = ""
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
        Else
            TxtNh_Kx2.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx3"
    Private Sub V_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx3.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '3'")
    End Sub
    Private Sub L_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx3.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx3.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx4"
    Private Sub V_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx4.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '4'")
    End Sub
    Private Sub L_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx4.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx4.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx4.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx5"
    Private Sub V_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx5.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '5'")
    End Sub
    Private Sub L_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx5.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx5.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx5.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx6"
    Private Sub V_Nh_Kx6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx6.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '6'")
    End Sub
    Private Sub L_Nh_Kx6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx6.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx6.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx6.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx6.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx7"
    Private Sub V_Nh_Kx7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx7.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '7'")
    End Sub
    Private Sub L_Nh_Kx7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx7.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx7.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx7.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx7.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx8"
    Private Sub V_Nh_Kx8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx8.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '8'")
    End Sub
    Private Sub L_Nh_Kx8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx8.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx8.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx8.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx8.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx9"
    Private Sub V_Nh_Kx9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx9.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '9'")
    End Sub
    Private Sub L_Nh_Kx9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx9.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtNh_Kx9.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx9.Text = DrReturn.Item("Ma_Nh")
        Else
            TxtNh_Kx9.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TP"
    Private Sub V_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TP.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TP", "DmTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text = "" Then
            TxtTen_TP.Text = ""
            _KeyTP = "0"
            Exit Sub
        End If
        DrReturn = TxtMa_TP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TP.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP.Text = DrReturn.Item("Ten_TP")
            _KeyTP = "1"
        Else
            TxtMa_TP.Text = ""
            TxtTen_TP.Text = ""
            _KeyTP = "0"
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Quan"
    Private Sub V_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Quan.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Quan", "DmQuan", "1=1", IIf(_KeyTP = "1", "Ma_TP = '" + TxtMa_TP.Text.Trim + "'", "1=1"))
    End Sub
    Private Sub L_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Quan.Text = "" Then
            TxtTen_Quan.Text = ""
            _KeyQuan = "0"
            Exit Sub
        End If
        DrReturn = TxtMa_Quan.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Quan.Text = DrReturn.Item("Ma_Quan")
            TxtTen_Quan.Text = DrReturn.Item("Ten_Quan")
            _KeyQuan = "1"
        Else
            TxtMa_Quan.Text = ""
            TxtTen_Quan.Text = ""
            _KeyQuan = "0"
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Xa"
    Private Sub V_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Xa.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Xa", "DmXa", "1=1", IIf(_KeyQuan = "1", "Ma_Quan = '" + TxtMa_Quan.Text.Trim + "'", "1=1"))
    End Sub
    Private Sub L_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xa.Text = "" Then
            TxtTen_Xa.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Xa.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xa.Text = DrReturn.Item("Ma_Xa")
            TxtTen_Xa.Text = DrReturn.Item("Ten_Xa")
        Else
            TxtMa_Xa.Text = ""
            TxtTen_Xa.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Valid Ma_SMS"
    Private Sub V_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_SMS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_SMS", "DmSMSTemplate", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_SMS.Text = "" Then
            TxtTen_SMS.Text = ""
            TxtBody.Text = ""
            Exit Sub
        End If

        DrReturn = TxtMa_SMS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SMS.Text = DrReturn.Item("Ma_SMS")
            TxtTen_SMS.Text = DrReturn.Item("Ten_SMS")
            TxtBody.Text = DrReturn.Item("Body")
            TxtBody.Text = DrReturn.Item("Body")
            TxtP1A.Text = DrReturn.Item("P1A")
            TxtP2A.Text = DrReturn.Item("P2A")
            TxtP3A.Text = DrReturn.Item("P3A")
            TxtP4A.Text = DrReturn.Item("P4A")
            TxtP5A.Text = DrReturn.Item("P5A")
            TxtP1B.Text = DrReturn.Item("P1B")
            TxtP2B.Text = DrReturn.Item("P2B")
            TxtP3B.Text = DrReturn.Item("P3B")
            TxtP4B.Text = DrReturn.Item("P4B")
            TxtP5B.Text = DrReturn.Item("P5B")
            TxtP1C.Text = DrReturn.Item("P1C")
            TxtP2C.Text = DrReturn.Item("P2C")
            TxtP3C.Text = DrReturn.Item("P3C")
            TxtP4C.Text = DrReturn.Item("P4C")
            TxtP5C.Text = DrReturn.Item("P5C")
            TxtP1D.Text = DrReturn.Item("P1D")
            TxtP2D.Text = DrReturn.Item("P2D")
            TxtP3D.Text = DrReturn.Item("P3D")
            TxtP4D.Text = DrReturn.Item("P4D")
            TxtP5D.Text = DrReturn.Item("P5D")

            If Not TxtMa_SMS.Text = "" Then
                Dim StrPara As String = "##" & TxtMa_SMS.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name
                Dim dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SMSTemplate_GhepCRM", StrPara)

                If Not dstmp.Tables.Count < 1 Then
                    If Not dstmp.Tables(1).Rows.Count < 1 Then
                        TxtBody.Text = dstmp.Tables(1).Rows(0).Item("Body").ToString.Trim
                    End If
                End If
            End If
        Else
            TxtMa_SMS.Text = ""
            TxtTen_SMS.Text = ""
            TxtBody.Text = ""
            TxtP1A.Text = ""
            TxtP2A.Text = ""
            TxtP3A.Text = ""
            TxtP4A.Text = ""
            TxtP5A.Text = ""
            TxtP1B.Text = ""
            TxtP2B.Text = ""
            TxtP3B.Text = ""
            TxtP4B.Text = ""
            TxtP5B.Text = ""
            TxtP1C.Text = ""
            TxtP2C.Text = ""
            TxtP3C.Text = ""
            TxtP4C.Text = ""
            TxtP5C.Text = ""
            TxtP1D.Text = ""
            TxtP2D.Text = ""
            TxtP3D.Text = ""
            TxtP4D.Text = ""
            TxtP5D.Text = ""
        End If
    End Sub
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
    Private Sub V_SetTxt()
        Dim _En As Boolean = ChkIs_Ngay_Sinh.Checked

        TxtNgay_Sinh1.Enabled = _En
        TxtNgay_Sinh2.Enabled = _En

        Select Case _En
            Case True
                TxtNgay_Sinh1.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
                TxtNgay_Sinh2.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1).AddMonths(1).AddDays(-1)
            Case False
                TxtNgay_Sinh1.Value = New DateTime(1900, 1, 1)
                TxtNgay_Sinh2.Value = New DateTime(1900, 1, 1)
                TxtNgay_Sinh1.Text = "__/__/____"
                TxtNgay_Sinh2.Text = "__/__/____"
        End Select

        If _En = True Then TxtNgay_Sinh1.Focus()
    End Sub
    Private Sub V_Tinh_Toan()
        Dim _Len As Double = IIf(TxtBody.Text = "", 0, Len(TxtBody.Text))
        TxtSo_Ky_Tu.Text = _Len

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
    Private Sub V_Thoi_Gian_Gui()
        Dim _En As Boolean = ChkThoi_Gian_Gui.Checked
        TxtNgay_Gui.Enabled = _En
        TxtNgay_Gui.Value = DateTime.Now
        If _En = True Then TxtNgay_Gui.Focus()
    End Sub
#End Region
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
End Class