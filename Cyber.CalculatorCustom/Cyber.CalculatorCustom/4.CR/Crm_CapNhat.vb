Public Class Crm_CapNhat
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DsTmp As DataSet
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
    Dim M_Ma_Get As String = ""
    Public Property Ma_Get() As String
        Get
            Ma_Get = M_Ma_Get
        End Get
        Set(ByVal Value As String)
            M_Ma_Get = Value
        End Set
    End Property
    Dim M_Ma_Get1 As String = ""
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
    Dim M_Drv_Load As DataRowView
    Public Property Drv_Load() As DataRowView
        Get
            Drv_Load = M_Drv_Load
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv_Load = Value
        End Set
    End Property
    Private Sub CRM_CapNhat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler TxtMa_Xe.Leave, AddressOf L_Ma_Xe

        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, M_Drv_Load)
        TxtDien_Thoai.Text = Dien_Thoai
        TxtMa_Xe.Text = Ma_Xe
        If TxtMa_Xe.Text <> "" Then
            L_Ma_Xe()
        End If
    End Sub
#Region "Valid"
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
    Private Sub L_Ma_Xe()
        Dim _Dt As String = TxtDien_Thoai.Text.Trim
        Dim _Ma_xe As String = TxtMa_Xe.Text.Trim

        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMLoadDmXe", _Ma_xe & "#" & _Dt & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If DsTmp.Tables.Count < 1 Then Exit Sub

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            DsTmp.Dispose()
            Exit Sub
        Else
            If TxtMa_Xe.Text = "" Then
                TxtMa_Kx.Text = ""
                TxtSo_Khung.Text = ""
                TxtDien_Thoai.Text = ""
                TxtDia_Chi.Text = ""
                TxtE_Mail.Text = ""
                TxtTen_Kh.Text = ""
                TxtTen_Lx.Text = ""
                TxtNam_Sx.Text = ""
                Exit Sub
            ElseIf TxtMa_Xe.Text <> "" Then
                TxtMa_Xe.Text = DsTmp.Tables(1).Rows(0).Item("Ma_Xe")
                TxtMa_Kx.Text = DsTmp.Tables(1).Rows(0).Item("Ma_Kx")
                TxtSo_Khung.Text = DsTmp.Tables(1).Rows(0).Item("So_Khung")
                TxtDien_Thoai.Text = DsTmp.Tables(1).Rows(0).Item("Dien_Thoai")
                TxtDia_Chi.Text = DsTmp.Tables(1).Rows(0).Item("Dia_Chi")
                TxtE_Mail.Text = DsTmp.Tables(1).Rows(0).Item("E_mail")
                TxtTen_Kh.Text = DsTmp.Tables(1).Rows(0).Item("Ten_Kh")
                TxtTen_Lx.Text = DsTmp.Tables(1).Rows(0).Item("Ten_Lx")
                TxtNam_Sx.Text = DsTmp.Tables(1).Rows(0).Item("Nam_Sx")
            End If
        End If
    End Sub
#End Region
    Public M_Dt_Return As DataTable
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True

        Dim _PH As DataTable = DsTmp.Tables(1).Clone

        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        drMaster = _PH.NewRow
        drMaster.BeginEdit()
        CyberSmodb.SetValueBlankRow(drMaster)
        CyberSmodb.AddValueToRow(drMaster, Me)
        drMaster.Item("Ma_Xe") = TxtMa_Xe.Text.Trim
        drMaster.EndEdit()
        _PH.Rows.Add(drMaster)
        _PH.AcceptChanges()

        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"DmXe"}, {CyberSmodb.V_ConvertDrToTb(drMaster)})

        Dim M_strParameterStore As String = strXML
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Get1.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Get.Trim

        Dim DsTmpSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMSaveDmXe", M_strParameterStore)

        If Not CyberSupport.V_MsgChk(DsTmpSave.Tables(0), Sysvar, M_LAN) Then
            DsTmpSave.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            DsTmpSave.Dispose()
            Exit Sub
        Else
            Me.M_Dt_Return = DsTmpSave.Tables(0).Copy
            Me.Save_OK = True
            DsTmpSave.Dispose()
        End If
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class