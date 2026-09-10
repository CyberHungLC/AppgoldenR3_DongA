Public Class DMChiaHHBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHH_LHBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtNgay_hl.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
 
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        '-Ma_TTHD
        RemoveHandler TxtMa_TTHD.CyberValiting, AddressOf V_Ma_TTHD
        RemoveHandler TxtMa_TTHD.CyberLeave, AddressOf L_Ma_TTHD
        AddHandler TxtMa_TTHD.CyberValiting, AddressOf V_Ma_TTHD
        AddHandler TxtMa_TTHD.CyberLeave, AddressOf L_Ma_TTHD


        '-Ma_TT
        RemoveHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        RemoveHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT
        AddHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        AddHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT

      
    End Sub
 
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
 
#Region "Vali --- Ma_TTHD"
    Private Sub V_Ma_TTHD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTHD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTHD", "DMTTHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTHD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTHD.Text = "" Then
            txtTen_TTHD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTHD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTHD.Text = DrReturn.Item("Ma_TTHD")
            txtTen_TTHD.Text = DrReturn.Item("Ten_TTHD")
        Else
            TxtMa_TTHD.Text = ""
            txtTen_TTHD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TT", "DMTT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TT.Text = "" Then
            txtTen_TT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TT.Text = DrReturn.Item("Ma_TT")
            txtTen_TT.Text = DrReturn.Item("Ten_TT")
        Else
            TxtMa_TT.Text = ""
            txtTen_TT.Text = ""
        End If
    End Sub
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
