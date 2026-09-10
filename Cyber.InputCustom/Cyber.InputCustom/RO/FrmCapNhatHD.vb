Public Class FrmCapNhatHD
    Public Property Stt_Rec() As String
        Get
            Return M_Stt_Rec
        End Get
        Set(ByVal value As String)
            M_Stt_Rec = value
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
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Public Property Ngay_Ct() As DateTime
        Get
            Return M_Ngay_CT
        End Get
        Set(ByVal value As DateTime)
            M_Ngay_CT = value
        End Set
    End Property
    Dim M_Ngay_HDDT As DateTime
    Public Property Ngay_HDDT() As DateTime
        Get
            Return M_Ngay_HDDT
        End Get
        Set(ByVal value As DateTime)
            M_Ngay_HDDT = value
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
    Dim M_Loai As String = ""
    Public Property Loai() As String
        Get
            Return M_Loai
        End Get
        Set(ByVal value As String)
            M_Loai = value
        End Set
    End Property
    Dim M_So_Ct As String = ""
    Public Property So_Ct() As String
        Get
            Return M_So_Ct
        End Get
        Set(ByVal value As String)
            M_So_Ct = value
        End Set
    End Property

    Dim M_So_HDDT As String = ""
    Public Property So_HDDT() As String
        Get
            Return M_So_HDDT
        End Get
        Set(ByVal value As String)
            M_So_HDDT = value
        End Set
    End Property

    Dim M_So_Seri As String = ""
    Public Property So_Seri() As String
        Get
            Return M_So_Seri
        End Get
        Set(ByVal value As String)
            M_So_Seri = value
        End Set
    End Property

    Dim M_Ma_Post As String = ""
    Public Property Ma_Post() As String
        Get
            Return M_Ma_Post
        End Get
        Set(ByVal value As String)
            M_Ma_Post = value
        End Set
    End Property

    Dim M_Stt_Rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = ""
    Dim M_Ngay_Ct As DateTime
    Dim M_DT_Return As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtMa_CT, DtPostOld, DtPostNew As DataTable
    Dim _P1, _P2, _Stt_Rec As String
    Dim _Dt_Post As DataTable


    Private Sub FrmTTDC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        'TxtNgay_HDDT.Value = Now.Date
        'TxtSo_HDDT.Text = So_Ct
        'TxtSo_HDDT.ReadOnly = True
        V_Load()
        V_Addhandler()
        Me.Text = "Cập nhật số hóa đơn"
    End Sub
    Private Sub V_Addhandler()
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        ' Load Ma_Post

    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt As Date = TxtNgay_HDDT.Value
        Dim _DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDI_CapNhatHD", TxtSo_HDDT.Text & "#" & Dt.ToString("yyyyMMdd") & "#" & TxtSo_Seri.Text & "#" & M_Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _ncount As Integer = _DsChk.Tables.Count

        If Not CyberSupport.V_MsgChk(_DsChk.Tables(_ncount - 1), Sysvar, M_LAN) Then
            Exit Sub
            _DsChk.Dispose()
        End If

        Ngay_HDDT = _DsChk.Tables(0).Rows(0).Item("NGay_HDDT")
        So_HDDT = _DsChk.Tables(0).Rows(0).Item("So_HDDT")
        So_Seri = _DsChk.Tables(0).Rows(0).Item("So_Seri")
        Me.Save_OK = True
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class
