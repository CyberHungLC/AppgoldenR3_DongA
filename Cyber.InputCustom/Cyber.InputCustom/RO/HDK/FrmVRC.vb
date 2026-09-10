Imports System.Windows.Forms
Public Class FrmVRC
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
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
    Public Property Ma_Xe() As String
        Get
            Return M_Ma_xe
        End Get
        Set(ByVal value As String)
            M_Ma_xe = value
        End Set
    End Property
    Public Property Ten_Kh() As String
        Get
            Return M_Ten_KH
        End Get
        Set(ByVal value As String)
            M_Ten_KH = value
        End Set
    End Property
    Public Property So_RO() As String
        Get
            Return M_So_RO
        End Get
        Set(ByVal value As String)
            M_So_RO = value
        End Set
    End Property
    Public Property Ngay_Ct() As Date
        Get
            Return M_Ngay_Ct
        End Get
        Set(ByVal value As Date)
            M_Ngay_Ct = value
        End Set
    End Property
    Public Property DT_Return() As DataTable
        Get
            Return M_DT_Return
        End Get
        Set(ByVal value As DataTable)
            M_DT_Return = value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Ma_xe As String = ""
    Dim M_So_RO As String = ""
    Dim M_Ngay_Ct As Date
    Dim M_Ten_KH As String = ""
    Dim M_DT_Return, Tb As DataTable
    Dim Dt_Master As DataTable
    Dim vTb As DataView
    Dim DrReturn As DataRow
    Dim DsLookup, dsMaster, DsMau As DataSet
    Private Sub FrmVRC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhandler()
        Me.Text = "Thông tin kiểm tra tình trạng xe"
    End Sub
    Private Sub V_Addhandler()
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler CmbQuickSelect.SelectedValueChanged, AddressOf V_QuickSelect
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        '--> Load các mức độ màu Ktra
        DsMau = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadCbbVRC", M_Ma_Dvcs & "#" & M_User_Name)

        V_LoadCbb(CmbCT_01)
        V_LoadCbb(CmbCT_02)
        V_LoadCbb(CmbCT_03)
        V_LoadCbb(CmbCT_04)
        V_LoadCbb(CmbCT_05)
        V_LoadCbb(CmbCT_06)
        V_LoadCbb(CmbCT_07)
        V_LoadCbb(CmbCT_08)
        V_LoadCbb(CmbCT_09)
        V_LoadCbb(CmbCT_10)
        V_LoadCbb(CmbCT_11)
        V_LoadCbb(CmbCT_12)
        V_LoadCbb(CmbCT_13)
        V_LoadCbb(CmbCT_14)
        V_LoadCbb(CmbCT_15)
        V_LoadCbb(CmbCT_16)
        V_LoadCbb(CmbCT_17)
        V_LoadCbb(CmbCT_18)
        V_LoadCbb(CmbCT_19)
        V_LoadCbb(CmbQuickSelect)

        V_LoadDatabase()
        TxtSo_Ro.Text = M_So_RO
        TxtMa_Xe.Text = M_Ma_xe
        TxtNgay_Ct.Value = M_Ngay_Ct
        TxtTen_Kh.Text = M_Ten_KH
    End Sub
    Private Sub V_QuickSelect()
        Dim _Value As String = CmbQuickSelect.SelectedValue
        CmbCT_01.SelectedValue = _Value
        CmbCT_02.SelectedValue = _Value
        CmbCT_03.SelectedValue = _Value
        CmbCT_04.SelectedValue = _Value
        CmbCT_05.SelectedValue = _Value
        CmbCT_06.SelectedValue = _Value
        CmbCT_07.SelectedValue = _Value
        CmbCT_08.SelectedValue = _Value
        CmbCT_09.SelectedValue = _Value
        CmbCT_10.SelectedValue = _Value
        CmbCT_11.SelectedValue = _Value
        CmbCT_12.SelectedValue = _Value
        CmbCT_13.SelectedValue = _Value
        CmbCT_14.SelectedValue = _Value
        CmbCT_15.SelectedValue = _Value
        CmbCT_16.SelectedValue = _Value
        CmbCT_17.SelectedValue = _Value
        CmbCT_18.SelectedValue = _Value
        CmbCT_19.SelectedValue = _Value
    End Sub
    Private Sub V_LoadDatabase()
        Dim _Ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultVRC", M_Ma_Ct & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim i As Integer
        Dim Drv As DataRowView
        Dim Dv_Master As DataView
        Dt_Master = _Ds.Tables(0).Clone()
        Dv_Master = New DataView(_Ds.Tables(0))
        Drv = Nothing
        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next
        CyberSmodb.SetValueTObj(Me, Drv)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _strField As String = ""
        Dim _strValue As String = ""

        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysChkVRC", M_Stt_rec.Trim + "#" + M_Ma_Ct.Trim + "#" + _strField + "#" + _strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name.Trim)

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dim Dt_Master As DataTable = CyberSmodb.OpenTableKey(AppConn, dsMaster, "PH89_VRC", "Stt_rec", "1=0")
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        drMaster = Dt_Master.NewRow
        CyberSmodb.SetValueBlankRow(drMaster)
        CyberSmodb.AddValueToRow(drMaster, Me)
        drMaster.Item("Stt_Rec") = M_Stt_rec
        drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        drMaster.Item("Ma_Ct") = M_Ma_Ct.Trim

        CyberSmodb.V_SaveToSQL(AppConn, Sysvar, M_User_Name, drMaster, "PH89_VRC", "M", "Stt_Rec = N'" + M_Stt_rec + "'", True)
        Me.Close()
    End Sub
    Private Sub V_LoadCbb(ByVal _cbb As ComboBox)
        Tb = DsMau.Tables(0).Copy
        vTb = New DataView(Tb)

        CyberFill.V_FillComBoxDefaul(_cbb, vTb, "Ma", "Ten", "Ngam_Dinh")
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class
