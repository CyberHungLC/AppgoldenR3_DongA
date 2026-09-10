Public Class DmLoaiKN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DmLoaiKN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_LoaiKN.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_LoaiKN, TxtNh_LoaiKN1, TxtNh_LoaiKN2, TxtNh_LoaiKN3, TxtNh_LoaiKN4, TxtNh_LoaiKN5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_LoaiKN1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_LoaiKN2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_LoaiKN3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_LoaiKN4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_LoaiKN5.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_LoaiKN.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_LoaiKN.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Vitri1
        RemoveHandler TxtNh_LoaiKN1.CyberValiting, AddressOf V_NH_Vitri1
        RemoveHandler TxtNh_LoaiKN1.CyberLeave, AddressOf L_NH_Vitri1
        AddHandler TxtNh_LoaiKN1.CyberValiting, AddressOf V_NH_Vitri1
        AddHandler TxtNh_LoaiKN1.CyberLeave, AddressOf L_NH_Vitri1
        '--Vitri2
        RemoveHandler TxtNh_LoaiKN2.CyberValiting, AddressOf V_NH_Vitri2
        RemoveHandler TxtNh_LoaiKN2.CyberLeave, AddressOf L_NH_Vitri2
        AddHandler TxtNh_LoaiKN2.CyberValiting, AddressOf V_NH_Vitri2
        AddHandler TxtNh_LoaiKN2.CyberLeave, AddressOf L_NH_Vitri2
        '--Vitri3
        RemoveHandler TxtNh_LoaiKN3.CyberValiting, AddressOf V_NH_Vitri3
        RemoveHandler TxtNh_LoaiKN3.CyberLeave, AddressOf L_NH_Vitri3
        AddHandler TxtNh_LoaiKN3.CyberValiting, AddressOf V_NH_Vitri3
        AddHandler TxtNh_LoaiKN3.CyberLeave, AddressOf L_NH_Vitri3
        '--Vitri4
        RemoveHandler TxtNh_LoaiKN4.CyberValiting, AddressOf V_NH_Vitri4
        RemoveHandler TxtNh_LoaiKN4.CyberLeave, AddressOf L_NH_Vitri4
        AddHandler TxtNh_LoaiKN4.CyberValiting, AddressOf V_NH_Vitri4
        AddHandler TxtNh_LoaiKN4.CyberLeave, AddressOf L_NH_Vitri4
        '--Vitri5
        RemoveHandler TxtNh_LoaiKN5.CyberValiting, AddressOf V_NH_Vitri5
        RemoveHandler TxtNh_LoaiKN5.CyberLeave, AddressOf L_NH_Vitri5
        AddHandler TxtNh_LoaiKN5.CyberValiting, AddressOf V_NH_Vitri5
        AddHandler TxtNh_LoaiKN5.CyberLeave, AddressOf L_NH_Vitri5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Vitri1"
    Private Sub V_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LoaiKN1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LoaiKN1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LoaiKN1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LoaiKN1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LoaiKN1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri2"
    Private Sub V_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LoaiKN2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LoaiKN2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LoaiKN2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LoaiKN2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LoaiKN2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri3"
    Private Sub V_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LoaiKN3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LoaiKN3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LoaiKN3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LoaiKN3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LoaiKN3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri4"
    Private Sub V_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LoaiKN4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LoaiKN4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LoaiKN4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LoaiKN4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LoaiKN4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri5"
    Private Sub V_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LoaiKN5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LoaiKN5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LoaiKN5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LoaiKN5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LoaiKN5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
       Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_LoaiKN.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
