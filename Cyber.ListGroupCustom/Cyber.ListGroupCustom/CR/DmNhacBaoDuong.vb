Public Class DmNhacBaoDuong
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDmNhacBaoDuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, , , , , , )
        TxtNh_Kx1.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        'If TxtNh_Kx1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKx", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmlib)
        'If TxtNh_Kx3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKx", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kx3.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_KX1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_KX1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_KX1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_KX1
        '--Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_KX1"
    Private Sub V_Nh_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kx3"
    Private Sub V_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtNh_Kx1.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
