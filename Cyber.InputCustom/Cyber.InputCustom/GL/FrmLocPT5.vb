Public Class FrmLocPT5
#Region "Get or Set Property----------------------"
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property So_seri() As String
        Get
            Return M_So_seri
        End Get
        Set(ByVal value As String)
            M_So_seri = value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Return M_Mode
        End Get
        Set(ByVal value As String)
            M_Mode = value
        End Set
    End Property
    Public Property Ma_Thue() As String
        Get
            Return M_Ma_Thue
        End Get
        Set(ByVal value As String)
            M_Ma_Thue = value
        End Set
    End Property
    Public Property Ma_Xe() As String
        Get
            Return M_Ma_Xe
        End Get
        Set(ByVal value As String)
            M_Ma_Xe = value
        End Set
    End Property
    Public Property Ma_TT() As String
        Get
            Return M_Ma_TT
        End Get
        Set(ByVal value As String)
            M_Ma_TT = value
        End Set
    End Property

    Public Property So_Ro() As String
        Get
            Return M_So_Ro
        End Get
        Set(ByVal value As String)
            M_So_Ro = value
        End Set
    End Property
    Public Property Master_Return() As DataTable
        Get
            Master_Return = M_Master_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Master_Return = Value
        End Set
    End Property
    Public Property Vt_Return() As DataTable
        Get
            Vt_Return = M_Vt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Vt_Return = Value
        End Set
    End Property
    Public Property Dt_Return() As DataTable
        Get
            Dt_Return = M_Dt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Return = Value
        End Set
    End Property
    Public Property CV_Return() As DataTable
        Get
            CV_Return = M_Cv_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Cv_Return = Value
        End Set
    End Property
    Public Property _Ds_LoolUp() As DataSet
        Get
            _Ds_LoolUp = DsLookup
        End Get
        Set(ByVal Value As DataSet)
            DsLookup = Value
        End Set
    End Property
    Public Property Ma_Tang() As String
        Get
            Return M_Ma_Tang
        End Get
        Set(ByVal value As String)
            M_Ma_Tang = value
        End Set
    End Property

#End Region
#Region "Bien----------------------"
    Dim M_Stt_rec As String = ""
    Dim M_So_seri As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_Thue As String = "10"
    Dim M_Ma_xe As String = ""
    Dim M_Ma_TT As String = "C"
    Dim M_Ma_Tang As String = "01"
    Dim M_So_Ro As String = ""
    Dim DsLookup As New DataSet
    Dim tbMaster As New DataTable
    Dim dtMasterRo, dtMasterHeaderRo As New DataTable
    Dim vdtMasterRo, vdtMasterHeaderRo As New DataView
    Dim dtDetailRo As New DataTable, vdtDetailRo As New DataView

    Dim dtDetailCvRo, dtDetailHeaderCvRo As New DataTable
    Dim vdtDetailCvRo, vdtDetailHeaderCvRo As New DataView

    Dim dtDetailVtRo, dtDetailHeaderVtRo As New DataTable
    Dim vdtDetailVtRo, vdtDetailHeaderVtRo As New DataView

    Dim EditMasterTag, EditDetailCvTag, EditDetailVtTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, M_Vt_Return, M_Cv_Return, M_Dt_Return As DataTable
    Dim DrReturn As DataRow
#End Region
    Private Sub FrmLocPT5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        'V_GetColumn()
        Me.Text = "Chọn lệnh sửa chữa"
        TxtTk.Text = "1133"
        V_AddHander()

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    'Private Sub V_GetColumn()
    '    EditMasterTag.GetColumn(DetailGRVRo_Master, "tag")
    '    EditDetailCvTag.GetColumn(DetailGRVRo_DetailCv, "tag")
    'End Sub
    Private Sub V_AddHander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler txtLenh_Ro.Leave, AddressOf L_So_Lenh
        'AddHandler CmdLoc_TT.Click, AddressOf V_LocTT
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        AddMenu()
        'AddHandler DetailGRVRo_Master.FocusedRowChanged, AddressOf DetailGRVRo_Master_FocusedRowChanged
        'CyberFill.V_GridviewRowCellStyle(DetailGRVRo_Master)

        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk
    End Sub
    Private Sub AddMenu()
        Dim mnItemsMail = New ContextMenu
        'Dim mnItemsF3 As New MenuItem("Xem chi tiết chứng từ", Events, Keys.F3)
        'Dim mnItemsSelectAll As New MenuItem("Chọn toàn bộ", AddressOf V_SelectAllRo, Shortcut.CtrlA)
        'Dim mnItemsRemoveAll As New MenuItem("Bỏ chọn ", AddressOf V_RemoveAllRo, Shortcut.CtrlU)

        'mnItemsMail.MenuItems.Add(mnItemsSelectAll)
        'mnItemsMail.MenuItems.Add(mnItemsRemoveAll)
        'DetailGRVRo_Master.GridControl.ContextMenu = mnItemsMail
    End Sub
 
#Region "Valid --- Ma_KH"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtTk.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk.Text = "" Then
            TxtTen_tk.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn("Tk0").ToString.Trim
            TxtTen_tk.Text = DrReturn("ten_tk0").ToString.Trim
        Else
            TxtTk.Text = ""
            TxtTen_tk.Text = ""
        End If
    End Sub
#End Region
    Private Sub L_So_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_Ct As Date = TxtNgay_Ct1.Value
        txtLenh_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, M_Ma_Ct, "S", M_Mode, _Ngay_Ct, txtLenh_Ro.Text, "", M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#Region "Load - "
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        'TxtSo_Ro.Text = M_So_Ro
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLoaiTT", M_Ma_Ct.Trim + "#" + M_User_Name)
        Dim tbDmTT = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        'V_LoadDatabase("1")
        'V_LoadHeaderGridview()
    End Sub
 
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
    Private Sub V_BingDataTableToDataTable(ByVal Status As String, ByRef Dt_Data_Nguon As DataTable, ByRef Dt_Data_Dich As DataTable, ByRef Dv_Data_Dich As DataView)
        If Status.Trim = "1" Then
            Dt_Data_Dich = Dt_Data_Nguon.Copy
            Dv_Data_Dich = New DataView(Dt_Data_Dich)
            Exit Sub
        End If
        Dt_Data_Dich.Clear()
        For i As Integer = 0 To Dt_Data_Nguon.Rows.Count - 1
            Dt_Data_Dich.ImportRow(Dt_Data_Nguon.Rows(i))
        Next
    End Sub
#End Region
#Region "Tinh toan"
 
 
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore


        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value, _Ngay_Ct2 As Date = TxtNgay_Ct2.Value
        Dim DsLenh_RO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPT1FROMPT5", _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd") & "#" & TxtTk.Text & "#" & txtLenh_Ro.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(DsLenh_RO.Tables(0), Me.Sysvar, Me.Lan) Then
            DsLenh_RO.Dispose()
            Exit Sub
        End If

        For i = 0 To DsLenh_RO.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsLenh_RO.Tables(i))
        Next

        Dim _CV_Return As DataTable = DsLenh_RO.Tables(1).Clone
        CyberSmodb.SQLTbToTb(DsLenh_RO.Tables(1), _CV_Return)

        Me.CV_Return = _CV_Return

        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub

End Class
