Public Class DmHLTonVT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim Dt_DmTTLN, Dt_DmTTCP, Dt_DmNN, Dt_DmNH, Dt_GioiTinh As DataTable
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView
    Private Sub DmHLTonVT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtNgay_HL.Focus()

        RemoveHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        RemoveHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt

        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Vt", "DmVt", "(Ma_Vt = N'" + TxtMa_Vt.Text.Trim + "')", CyberSmlib)
        TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kho", "DmKho", "Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "'")

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
#Region "Vali ---Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
            TxtDvt.Text = DrReturn.Item("Dvt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
            TxtDvt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali ---Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kho", "DmKho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
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