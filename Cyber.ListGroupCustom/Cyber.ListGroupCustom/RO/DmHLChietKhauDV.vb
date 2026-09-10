Public Class DmHLChietKhauDV
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

        '- Ma_VT
        RemoveHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_VT
        RemoveHandler TxtMa_Vt.CyberLeave, AddressOf L_MA_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_VT
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_MA_Vt

        '- Ma_CV
        RemoveHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_Cv
        RemoveHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_Cv
        AddHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_Cv
        AddHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_Cv

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then
            TxtNgay_HL.Value = Now.Date
            TxtNgay_KT.Value = Now.Date
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
#Region "Vali ---Ma_VT"
    Private Sub V_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_MA_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali ---Ma_Cv"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cv", "DmCv", "1=1", "1=1")
    End Sub
    Private Sub L_MA_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Cv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cv.Text = DrReturn.Item("Ma_CV")
            TxtTen_Cv.Text = DrReturn.Item("Ten_CV")
        Else
            TxtMa_Cv.Text = ""
            TxtTen_Cv.Text = ""
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
