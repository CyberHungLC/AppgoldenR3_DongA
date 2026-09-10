Public Class CRMDMVDTM
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DmLoaiKN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_Vd.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Vd, TxtNh_Vd1, TxtNh_Vd2, TxtNh_Vd3, TxtNh_Vd4, TxtNh_Vd5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vd1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vd2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vd3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Vd4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLoaiKN", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Vd5.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_Vd.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Vd.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Vitri1
        RemoveHandler TxtNh_Vd1.CyberValiting, AddressOf V_NH_Vitri1
        RemoveHandler TxtNh_Vd1.CyberLeave, AddressOf L_NH_Vitri1
        AddHandler TxtNh_Vd1.CyberValiting, AddressOf V_NH_Vitri1
        AddHandler TxtNh_Vd1.CyberLeave, AddressOf L_NH_Vitri1
        '--Vitri2
        RemoveHandler TxtNh_Vd2.CyberValiting, AddressOf V_NH_Vitri2
        RemoveHandler TxtNh_Vd2.CyberLeave, AddressOf L_NH_Vitri2
        AddHandler TxtNh_Vd2.CyberValiting, AddressOf V_NH_Vitri2
        AddHandler TxtNh_Vd2.CyberLeave, AddressOf L_NH_Vitri2
        '--Vitri3
        RemoveHandler TxtNh_Vd3.CyberValiting, AddressOf V_NH_Vitri3
        RemoveHandler TxtNh_Vd3.CyberLeave, AddressOf L_NH_Vitri3
        AddHandler TxtNh_Vd3.CyberValiting, AddressOf V_NH_Vitri3
        AddHandler TxtNh_Vd3.CyberLeave, AddressOf L_NH_Vitri3
        '--Vitri4
        RemoveHandler TxtNh_Vd4.CyberValiting, AddressOf V_NH_Vitri4
        RemoveHandler TxtNh_Vd4.CyberLeave, AddressOf L_NH_Vitri4
        AddHandler TxtNh_Vd4.CyberValiting, AddressOf V_NH_Vitri4
        AddHandler TxtNh_Vd4.CyberLeave, AddressOf L_NH_Vitri4
        '--Vitri5
        RemoveHandler TxtNh_Vd5.CyberValiting, AddressOf V_NH_Vitri5
        RemoveHandler TxtNh_Vd5.CyberLeave, AddressOf L_NH_Vitri5
        AddHandler TxtNh_Vd5.CyberValiting, AddressOf V_NH_Vitri5
        AddHandler TxtNh_Vd5.CyberLeave, AddressOf L_NH_Vitri5

        RemoveHandler TxtMa_Lv.CyberValiting, AddressOf V_Ma_Lv
        RemoveHandler TxtMa_Lv.CyberLeave, AddressOf L_Ma_Lv
        AddHandler TxtMa_Lv.CyberValiting, AddressOf V_Ma_Lv
        AddHandler TxtMa_Lv.CyberLeave, AddressOf L_Ma_Lv

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Vitri1"
    Private Sub V_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vd1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vd1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vd1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vd1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vd1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri2"
    Private Sub V_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vd2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vd2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vd2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vd2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vd2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri3"
    Private Sub V_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vd3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vd3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vd3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vd3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vd3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri4"
    Private Sub V_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vd4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vd4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vd4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vd4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vd4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri5"
    Private Sub V_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vd5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLoaiKN", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vd5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vd5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vd5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vd5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_LV"
    Private Sub V_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Lv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_LV", "CRMDMLVTM", "1=1")
    End Sub
    Private Sub L_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Lv.Text = "" Then
            TxtMa_Lv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Lv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Lv.Text = DrReturn.Item("Ma_Lv")
            TxtTen_Lv.Text = DrReturn.Item("Ten_Lv")
        Else
            TxtMa_Lv.Text = ""
            TxtTen_Lv.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Vd.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
