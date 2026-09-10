Public Class CRM_SMS
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Dien_Thoai As String = ""
    Public Property Dien_Thoai() As String
        Get
            Dien_Thoai = M_Dien_Thoai
        End Get
        Set(ByVal Value As String)
            M_Dien_Thoai = Value
        End Set
    End Property
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
    Dim M_Ma_Get1 As String
    Public Property Ma_Get1() As String
        Get
            Ma_Get1 = M_Ma_Get1
        End Get
        Set(ByVal Value As String)
            M_Ma_Get1 = Value
        End Set
    End Property
    Dim M_Ma_Xe As String
    Public Property Ma_Xe() As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Private Sub CRM_SMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_SMS.CyberValiting, AddressOf V_Ma_SMS
        AddHandler TxtMa_SMS.CyberLeave, AddressOf L_Ma_SMS

        AddHandler TxtND1.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtND5.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtBody.TextChanged, AddressOf V_So_Tin_Nhan

        AddHandler TxtND1.TextChanged, AddressOf V_Ghep
        AddHandler TxtND5.TextChanged, AddressOf V_Ghep
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_Ghep
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtDien_Thoai.Text = Dien_Thoai
        TxtMa_Xe.Text = Ma_Xe
        V_So_Tin_Nhan()
    End Sub
#Region "Valid Ma_SMS"
    Private Sub V_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_SMS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_SMS", "DmSMSTemplate", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_SMS.Text = "" Then
            TxtTen_SMS.Text = ""
            TxtNoi_Dung.Text = ""
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
#End Region
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
        If M_Loai = "CR" Then
            TxtBody.Text = "Xe " & TxtMa_Xe.Text & " cua QK " & TxtND1.Text & " " & TxtNoi_Dung.Text.Trim.Replace("#", "%23") & " " & TxtND5.Text
        ElseIf M_Loai <> "CR" Then
            TxtBody.Text = TxtND1.Text & " " & TxtNoi_Dung.Text.Trim.Replace("#", "%23") & " " & TxtND5.Text
        End If
    End Sub
#End Region
    Public M_Dt_Return As DataTable
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = "#" & M_Ma_Loai.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Get1.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtDien_Thoai.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtBody.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & "0"
        Me.Tag = M_strParameterStore

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_AnDoSMS_SaveSMS", M_strParameterStore)
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
        Me.Close()
    End Sub
End Class