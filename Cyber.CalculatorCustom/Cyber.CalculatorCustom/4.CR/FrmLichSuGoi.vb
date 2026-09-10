Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Reflection
Imports RestSharp
Imports System.Net

Public Class FrmLichSuGoi
#Region "AddProperty"
    Dim M_Loai As String
    Public Property Loai() As String
        Get
            Loai = M_Loai
        End Get
        Set(ByVal Value As String)
            M_Loai = Value
        End Set
    End Property
    Dim M_Ma_Loai As String
    Public Property Ma_Loai() As String
        Get
            Ma_Loai = M_Ma_Loai
        End Get
        Set(ByVal Value As String)
            M_Ma_Loai = Value
        End Set
    End Property
    Dim M_Ma_Ngay As String
    Public Property Ma_Ngay() As String
        Get
            Ma_Ngay = M_Ma_Ngay
        End Get
        Set(ByVal Value As String)
            M_Ma_Ngay = Value
        End Set
    End Property
    Dim M_Ma_Get As String
    Public Property Ma_Get() As String
        Get
            Ma_Get = M_Ma_Get
        End Get
        Set(ByVal Value As String)
            M_Ma_Get = Value
        End Set
    End Property
    Dim M_Ma_Get1 As String
    Public Property Ma_Get1() As String
        Get
            Ma_Get1 = M_Ma_Get1
        End Get
        Set(ByVal Value As String)
            M_Ma_Get1 = Value
        End Set
    End Property
    Dim M_Drv_Load As DataRowView
    Public Property Drv_Load() As DataRowView
        Get
            Drv_Load = M_Drv_Load
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv_Load = Value
        End Set
    End Property
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"
    Dim EditTen_KH, EditMa_Get1, EditMa_Cv As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_XeVt, EditMa_TuyenVt, EditMa_Vt, EditMa_ViTri As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim osysvar As Collection
    Dim DrReturn As DataRow
    Dim DtMaGD, DtPost, DtDvcs As New DataTable
    Dim DsLookup As DataSet
    '----
    Dim M_Mode = "M", M_Ma_CT = "KHN"
    Dim M_Ma_Post = "1", M_Ma_GD = "1"
    Dim M_Ma_TTCP As String = ""
    Dim M_Stt_Rec As String = ""
    '----
    Dim Dt_Detail, Dt_DetailVt, Dt_Header, Dt_Master As New DataTable
    Dim Dv_Detail, Dv_DetailVt, Dv_Header, Dv_Master As New DataView

    '----
    Public StrXML As String
    '----
    Dim ProccessList As New Collection
#End Region
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FrmXacNhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '------------------------------------------------------------------------------------
        V_Load()
        V_GetColumn()
        '------------------------------------------------------------------------------------
        V_Addhandler()
        V_AddHandler_Detail()

        '------------------------------------------------------------------------------------
        V_MainSystem()

        '------------------------------------------------------------------------------------
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP(M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '-----------
    End Sub
    Private Sub V_Load()

        V_Getdefault()
        V_LoadDB()
        V_FillDataToGridview(DetailGRV, M_LAN, Dv_Header, Dv_Detail)

    End Sub
    Private Sub V_GetColumn()
        EditTen_KH.GetColumn(DetailGRV, "Ten_KH")

        EditMa_Get1.GetColumn(DetailGRV, "Ma_Get1")

    End Sub
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF3 As New MenuItem(If(M_LAN = "V", "Xem cuộc gọi", "Xem cuộc gọi"), AddressOf V_Xem_Ghi_Am, Keys.F3)
        mnItemsMail.MenuItems.Add(mnItemsF3)
        DetailGRV.GridControl.ContextMenu = mnItemsMail
    End Sub

    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem cuộc gọi", "Xem cuộc gọi"), AddressOf V_Xem_Ghi_Am, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub

    Private Sub V_Xem_Ghi_Am(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim Dt As Date = Dv_Detail.Item(iRow).Item("Ngay_CT")

        Dim dsgetCuocgoi As DataSet
        dsgetCuocgoi = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CMSGhiAmCuocGoi", M_Ma_Get + "#" + Dt.ToString("yyyyMMdd HH:mm:ss").Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)
        If dsgetCuocgoi.Tables(0).Rows.Count < 1 Then Exit Sub
        Dim _Call_ID As String = ""
        _Call_ID = dsgetCuocgoi.Tables(0).Rows(0).Item("Call_ID")
        If _Call_ID = "" Then
            MsgBox("Chưa có cuộc gọi nào được ghi âm")
            Exit Sub
        End If

        Dim _UrlMedia As String = dsgetCuocgoi.Tables(0).Rows(0).Item("UrlMedia")
        Dim _access_key As String = dsgetCuocgoi.Tables(0).Rows(0).Item("access_key")



        'Dim _sysCMS As New Cyber.CMSVNPT.Sys

        '_sysCMS.V_GetUrlMedia(_access_key, _UrlMedia)
    End Sub

    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_Detail.Item(iRow) Else DrvOld = Nothing
        Dv_Detail.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_Detail.Table.Rows(Dv_Detail.Table.Rows.Count - 1))
        iRow = Dv_Detail.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
    End Sub

    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim

    End Sub

#End Region

    Private Sub V_Getdefault()
        M_LAN = Me.Lan
        AppConn = Me.AppConn
        '---------------------------------------------------------------------------------------------'
    End Sub
    Private Sub V_Addhandler()

        '---------------------------------------------------------------------------------------------
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        RemoveHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing

    End Sub
    Private Sub V_AddHandler_Detail()
        RemoveHandler EditTen_KH.EditColumn.Click, AddressOf V_Xem_Ghi_Am
        RemoveHandler EditMa_Get1.EditColumn.Click, AddressOf V_Xem_Ghi_Am
        AddHandler EditTen_KH.EditColumn.Click, AddressOf V_Xem_Ghi_Am
        AddHandler EditMa_Get1.EditColumn.Click, AddressOf V_Xem_Ghi_Am
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
    End Sub

#Region "Valid - Cong viec"

#End Region
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_Detail, Me.Font)
    End Sub
#Region "Data"
    Private Sub V_LoadDB()

        'Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLichSuGoi_Load", M_Ma_Get.Trim & "#" & M_Ma_Loai.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLichSuGoi_Load", M_Ma_Get.Trim & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        'Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLichSuGoi_Load", M_Ma_Get.Trim)


        Dt_Master = DsTmp.Tables(0).Copy
        Dt_Detail = DsTmp.Tables(1).Copy
        Dt_Header = DsTmp.Tables(2).Copy
        Dv_Master = New DataView(Dt_Master)
        Dv_Detail = New DataView(Dt_Detail)
        Dv_Header = New DataView(Dt_Header)
        DsTmp.Dispose()
    End Sub
#End Region
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal Dv_Header As DataView, ByVal DvData As DataView)
        GRV.OptionsBehavior.Editable = True
        CyberFill.V_FillReports(GRV, _M_lan, Dv_Header, DvData)
        GRV.GridControl.DataSource = DvData

        For Each dc As DevExpress.XtraGrid.Columns.GridColumn In DetailGRV.Columns
            dc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub

    'Private Sub V_DetailVoucher(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TxtSo_Kh.Text.Trim = "" Or txtStt_rec.Text.Trim = "" Then Exit Sub
    '    Dim _Stt_rec As String = txtStt_rec.Text.Trim
    '    If _Stt_rec = "" Then Exit Sub
    '    Dim strAddParar As String = "S#HDK###24#C#" + _Stt_rec
    '    Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
    '    If Not _Process Is Nothing Then ProccessList.Add(_Process)
    'End Sub
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#Region "Valid"


#End Region
End Class