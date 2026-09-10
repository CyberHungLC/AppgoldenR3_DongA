Public Class CRMDMVDKN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub CRMDMVDKN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()

        V_Load()
        TxtMa_Lv.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtTen_Lv.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_hs", "Dmhs", "ma_hs = N'" + TxtMa_Lv.Text + "'", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_Lv
        RemoveHandler TxtMa_Lv.CyberValiting, AddressOf V_Ma_Lv
        RemoveHandler TxtMa_Lv.CyberLeave, AddressOf L_Ma_Lv
        AddHandler TxtMa_Lv.CyberValiting, AddressOf V_Ma_Lv
        AddHandler TxtMa_Lv.CyberLeave, AddressOf L_Ma_Lv

    End Sub
#End Region
#Region "Vali --- Ma_LV"
    Private Sub V_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Lv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Lv", "CRMDMLVKN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Lv.Text = "" Then
            TxtTen_Lv.Text = ""
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
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Vd.Text = _Value
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
