Public Class UserTTCP_MacDinh
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FUserTTCP_MacDinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, , TxtMa_TTCP, TxtUser_Name)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL.Value = Now.Date
        End If

        'TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_TTCP", "DmTTCP", "(Ma_TTCP = N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmlib)
        'TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_Kho", "DmNhKHO", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()


        '--KHO1
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        '--KHO2
        RemoveHandler TxtUser_Name.CyberValiting, AddressOf V_User_Name
        RemoveHandler TxtUser_Name.CyberLeave, AddressOf L_User_Name
        AddHandler TxtUser_Name.CyberValiting, AddressOf V_User_Name
        AddHandler TxtUser_Name.CyberLeave, AddressOf L_User_Name

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DMTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
#Region "Vali --- Ma_Kho"
    Private Sub V_User_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtUser_Name.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "User_Name", "UserInfo", "1=1", "User_Name <> 'abc'")
    End Sub
    Private Sub L_User_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtUser_Name.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtUser_Name.Text = DrReturn.Item("User_Name")
            TxtTen_User.Text = DrReturn.Item("Comment")
        Else
            TxtUser_Name.Text = ""
            TxtTen_User.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_KhoTTCP.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class