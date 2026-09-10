Public Class DmSMSTemplate
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMKHO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_SMS, TxtNh_SMS1, TxtNh_SMS2, TxtNh_SMS3, TxtNh_SMS4, TxtNh_SMS5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSMSTemplate", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_SMS1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSMSTemplate", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_SMS2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSMSTemplate", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_SMS3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSMSTemplate", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_SMS4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSMSTemplate", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_SMS5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_SMS.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_SMS.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Sms1
        RemoveHandler TxtNh_SMS1.CyberValiting, AddressOf V_Nh_SMS1
        RemoveHandler TxtNh_SMS1.CyberLeave, AddressOf L_Nh_SMS1
        AddHandler TxtNh_SMS1.CyberValiting, AddressOf V_Nh_SMS1
        AddHandler TxtNh_SMS1.CyberLeave, AddressOf L_Nh_SMS1
        '--Sms2
        RemoveHandler TxtNh_SMS2.CyberValiting, AddressOf V_Nh_SMS2
        RemoveHandler TxtNh_SMS2.CyberLeave, AddressOf L_Nh_SMS2
        AddHandler TxtNh_SMS2.CyberValiting, AddressOf V_Nh_SMS2
        AddHandler TxtNh_SMS2.CyberLeave, AddressOf L_Nh_SMS2
        '--Sms3
        RemoveHandler TxtNh_SMS3.CyberValiting, AddressOf V_Nh_SMS3
        RemoveHandler TxtNh_SMS3.CyberLeave, AddressOf L_Nh_SMS3
        AddHandler TxtNh_SMS3.CyberValiting, AddressOf V_Nh_SMS3
        AddHandler TxtNh_SMS3.CyberLeave, AddressOf L_Nh_SMS3
        '--Sms4
        RemoveHandler TxtNh_SMS4.CyberValiting, AddressOf V_Nh_SMS4
        RemoveHandler TxtNh_SMS4.CyberLeave, AddressOf L_Nh_SMS4
        AddHandler TxtNh_SMS4.CyberValiting, AddressOf V_Nh_SMS4
        AddHandler TxtNh_SMS4.CyberLeave, AddressOf L_Nh_SMS4
        '--Sms5
        RemoveHandler TxtNh_SMS5.CyberValiting, AddressOf V_Nh_SMS5
        RemoveHandler TxtNh_SMS5.CyberLeave, AddressOf L_Nh_SMS5
        AddHandler TxtNh_SMS5.CyberValiting, AddressOf V_Nh_SMS5
        AddHandler TxtNh_SMS5.CyberLeave, AddressOf L_Nh_SMS5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_SMS1"
    Private Sub V_Nh_SMS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SMS1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSMSTemplate", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_SMS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SMS1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SMS1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SMS1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_SMS2"
    Private Sub V_Nh_SMS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SMS2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSMSTemplate", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_SMS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SMS2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SMS2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SMS2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_SMS3"
    Private Sub V_Nh_SMS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SMS3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSMSTemplate", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_SMS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SMS3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SMS3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SMS3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_SMS4"
    Private Sub V_Nh_SMS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SMS4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSMSTemplate", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_SMS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SMS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SMS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SMS4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_SMS5"
    Private Sub V_Nh_SMS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SMS5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSMSTemplate", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_SMS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SMS5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SMS5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SMS5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_SMS.Text = _Value
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