Public Class DMVTTonTT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMVTTonTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtNgay_HL.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtNgay_HL, TxtMa_VT)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Vt", "Dmvt", String.Format("(Ma_Vt = N'{0}')", TxtTen_Vt.Text.Trim), CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        'RemoveHandler TxtMa_VITRI.KeyPress, AddressOf TxtCodeError_KeyPress
        'AddHandler TxtMa_VITRI.KeyPress, AddressOf TxtCodeError_KeyPress


        '--Vật tư
        RemoveHandler TxtMa_VT.CyberValiting, AddressOf V_VT
        RemoveHandler TxtMa_VT.CyberLeave, AddressOf L_VT
        AddHandler TxtMa_VT.CyberValiting, AddressOf V_VT
        AddHandler TxtMa_VT.CyberLeave, AddressOf L_VT

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"

#Region "Vali --- Ma_Vt"
    Private Sub V_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vt", "DMVT", "1=1")
    End Sub
    Private Sub L_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_VT.Text = "" Then
            TxtMa_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_VT.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_VT.Text = ""
            TxtTen_Vt.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_VT.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
