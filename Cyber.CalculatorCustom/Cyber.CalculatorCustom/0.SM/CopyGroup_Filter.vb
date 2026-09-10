Imports System.Data.SqlClient
Public Class CopyGroup_Filter
    Public Property Add_Title() As String
        Get
            Add_Title = M_Add_Title
        End Get
        Set(ByVal Value As String)
            M_Add_Title = Value
        End Set
    End Property

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtDvcs As DataTable
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim M_Add_Title As String = ""
    Private Sub CP_BELapKHGX_Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtGoup.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtGoup.CyberLeave, AddressOf L_Ma_kx


        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Function V_GetUnists(ByVal Appconn As SqlConnection, ByVal _Ma_Dvcs As String, ByVal _User_Name As String, Optional ByVal CyberSmLib As Cyber.SmLib.Sys = Nothing) As DataTable
        Dim DsUnits As New DataSet

        DsUnits = CyberSmLib.SQLExcuteStoreProcedure(Appconn, "CP_SysListUnits", _Ma_Dvcs.Trim + "#" + _User_Name)
        V_GetUnists = DsUnits.Tables(0).Copy
        DsUnits.Dispose()
    End Function
    Private Sub V_Load()

        DtDvcs = V_GetUnists(AppConn, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        Me.CyberFill.V_FillComBoxValue(Me.CbbMa_Dvcs, DtDvcs, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)

    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#Region "Vali --- Group"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGoup.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Group", "GroupInfo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtGoup.Text = "" Then
            TxtComment.Text = ""
            Exit Sub
        End If
        DrReturn = TxtGoup.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtGoup.Text = DrReturn.Item("Group")
            TxtComment.Text = DrReturn.Item("Comment")
        Else
            TxtGoup.Text = ""
            TxtComment.Text = ""
        End If
    End Sub
#End Region

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = "1"
        M_strParameterStore = M_strParameterStore & "#" & TxtGoup.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_Dvcs.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CopyGroup_Load", M_strParameterStore)

        Dim frm1 As CopyGroup_XEM
        frm1 = New CopyGroup_XEM
        frm1.Lan = M_LAN
        frm1.Para = Me.Para
        frm1.Sysvar = Me.Sysvar
        frm1.AppConn = AppConn
        frm1.CyberSmlib = CyberSmlib
        frm1.CyberSupport = CyberSupport
        frm1.CyberFill = CyberFill
        frm1.CyberSmlistSys = CyberSmlistSys
        frm1.CyberSmodb = CyberSmodb
        frm1.CyberVoucher = CyberVoucher
        frm1.CyberLoading = CyberLoading
        frm1.Key_Sub1 = Me.Key_Sub1.ToString.Trim
        frm1.Key_Sub2 = Me.Key_Sub1.ToString.Trim
        frm1.Ma_DVCSLoc = CbbMa_Dvcs.SelectedValue.ToString.Trim
        frm1.ShowInTaskbar = False
        frm1.DsDataLoc() = DsTmp
        frm1.Cp_Loc() = "CP_CopyGroup_Load"
        frm1.strLoc() = M_strParameterStore

        frm1.ShowDialog()
        '----------------------------------------------
        Me.Key_Sub1 = TxtGoup.Text
        Me.Key_Sub2 = CbbMa_Dvcs.SelectedValue
        Me.Close()
    End Sub
End Class
