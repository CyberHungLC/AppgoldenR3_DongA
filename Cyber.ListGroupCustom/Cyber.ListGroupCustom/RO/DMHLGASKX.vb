Public Class DMHLGASKX
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim Dt_DmTTLN, Dt_DmTTCP, Dt_DmNN, Dt_DmNH, Dt_GioiTinh As DataTable
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView

    Private Sub DMTHEVIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtNgay_HL.Focus()
        RemoveHandler TxtNh_KX2.CyberValiting, AddressOf V_Nh_Kx2
        RemoveHandler TxtNh_KX2.CyberLeave, AddressOf L_Nh_Kx2
        AddHandler TxtNh_KX2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_KX2.CyberLeave, AddressOf L_Nh_Kx2
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Nh_KX2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DMNHKX", "(Ma_Nh = N'" + TxtNh_KX2.Text.Trim + "' AND Loai_Nh = 2)", CyberSmlib)

        If Me.Mode = "M" Then
            TxtNgay_HL.Value = Now.Date
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali ---Ma_HS"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh=2")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_KX2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX2.Text = ""
            TxtTen_Nh_KX2.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_KU.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
