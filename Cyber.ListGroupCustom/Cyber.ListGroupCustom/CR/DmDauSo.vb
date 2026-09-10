Public Class DmDauSo
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtMuc As New DataTable
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_DauSo.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        If TxtMa_TP.Text = "" Then TxtTen_TP.Text = "" Else TxtTen_TP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tp", "DmTP", "(Ma_TP = N'" + TxtMa_TP.Text.Trim + "')", CyberSmlib)
        If TxtMa_NhaMang.Text = "" Then TxtTen_NhaMang.Text = "" Else TxtTen_NhaMang.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_NhaMang", "DmNhaMang", "(Ma_NhaMang = N'" + TxtMa_NhaMang.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_DauSo.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_DauSo.KeyPress, AddressOf TxtCodeError_KeyPress

        RemoveHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        RemoveHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP

        RemoveHandler TxtMa_NhaMang.CyberValiting, AddressOf V_Ma_NhaMang
        RemoveHandler TxtMa_NhaMang.CyberLeave, AddressOf L_Ma_NhaMang
        AddHandler TxtMa_NhaMang.CyberValiting, AddressOf V_Ma_NhaMang
        AddHandler TxtMa_NhaMang.CyberLeave, AddressOf L_Ma_NhaMang
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_TP"
    Private Sub V_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TP", "DmTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_TP.GetRowsSelectData(True)
        If TxtMa_TP.Text = "" Then
            TxtTen_TP.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_TP.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP.Text = DrReturn.Item("Ten_TP")
        Else
            TxtMa_TP.Text = ""
            TxtTen_TP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_NhaMang,Ten_NhaMang"
    Private Sub V_Ma_NhaMang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NhaMang.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NhaMang", "DmNhaMang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NhaMang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NhaMang.GetRowsSelectData(True)
        If TxtMa_NhaMang.Text = "" Then
            TxtTen_NhaMang.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_NhaMang.Text = DrReturn.Item("Ma_NhaMang")
            TxtTen_NhaMang.Text = DrReturn.Item("Ten_NhaMang")
        Else
            TxtMa_NhaMang.Text = ""
            TxtTen_NhaMang.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_DauSo.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class