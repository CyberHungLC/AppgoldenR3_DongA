Public Class CDCoupon
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CDCoupon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_Coupon.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then Txtten_DVCS.Text = "" Else Txtten_DVCS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)       
        TxtTen_Coupon.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Coupon", "DmCoupon", "(Ma_Coupon = N'" + TxtMa_Coupon.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'Ma_Coupon
        RemoveHandler TxtMa_Coupon.CyberValiting, AddressOf V_Ma_Coupon
        RemoveHandler TxtMa_Coupon.CyberLeave, AddressOf L_Ma_Coupon
        AddHandler TxtMa_Coupon.CyberValiting, AddressOf V_Ma_Coupon
        AddHandler TxtMa_Coupon.CyberLeave, AddressOf L_Ma_Coupon
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Coupon"
    Private Sub V_Ma_Coupon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Coupon.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Coupon", "DmCoupon", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Coupon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Coupon.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Coupon.Text = DrReturn.Item("Ma_Coupon")
            TxtTen_Coupon.Text = DrReturn.Item("Ten_Coupon")
        Else
            TxtMa_Coupon.Text = ""
            TxtTen_Coupon.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)        
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