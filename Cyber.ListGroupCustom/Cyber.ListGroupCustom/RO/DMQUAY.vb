Public Class DmQuay
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtMuc As New DataTable
    Private Sub DmQuay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_quay.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
        If TxtMa_hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_hs", "Dmhs", "(ma_hs = N'" + TxtMa_hs.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_hs.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_hs.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_hs
        AddHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_hs

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_hs.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub

    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_hs.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_hs", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_hs.GetRowsSelectData(True)
        If TxtMa_hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_hs.Text = DrReturn.Item("ma_hs")
            TxtTen_Hs.Text = DrReturn.Item("ten_hs")
        Else
            TxtMa_hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
End Class
