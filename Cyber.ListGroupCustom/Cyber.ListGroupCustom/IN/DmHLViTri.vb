Public Class DMHLVITRI
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHLVITRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_TTCP.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Mode = "M" Then TxtNgay_HL.Value = Date.Now
        TxtTen_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_VT", "DmVT", "Ma_VT = N'" + TxtMa_VT.Text.Trim + "'", CyberSmlib)
        TxtTen_Vitri.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_Vitri", "DmVitri", "Ma_Vitri = N'" + TxtMa_Vitri.Text.Trim + "'", CyberSmlib)
        TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kho", "Dmkho", String.Format("(Ma_kho = N'{0}')", TxtMa_kho.Text.Trim), CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        '--Vitri1
        RemoveHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_VT
        RemoveHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_VT
        AddHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_VT
        AddHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_VT
        '--Vitri2
        RemoveHandler TxtMa_Vitri.CyberValiting, AddressOf V_Ma_Vitri
        RemoveHandler TxtMa_Vitri.CyberLeave, AddressOf L_Ma_Vitri
        AddHandler TxtMa_Vitri.CyberValiting, AddressOf V_Ma_Vitri
        AddHandler TxtMa_Vitri.CyberLeave, AddressOf L_Ma_Vitri
        '--Kho
        RemoveHandler TxtMa_kho.CyberValiting, AddressOf V_Kho
        RemoveHandler TxtMa_kho.CyberLeave, AddressOf L_Kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Kho

        '--Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_VT"
    Private Sub V_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_VT", "DmVT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_VT.Text = "" Then
            TxtTen_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_VT.Text = DrReturn.Item("Ma_VT")
            TxtTen_VT.Text = DrReturn.Item("Ten_VT")
            TxtMa_kho.Text = DrReturn.Item("Ma_Kho")
        Else
            TxtMa_VT.Text = ""
            TxtTen_VT.Text = ""
            TxtMa_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vitri"
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vitri.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vitri", "DmVitri", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Vitri.Text = "" Then
            TxtTen_Vitri.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vitri.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vitri.Text = DrReturn.Item("Ma_Vitri")
            TxtTen_Vitri.Text = DrReturn.Item("Ten_Vitri")
        Else
            TxtMa_Vitri.Text = ""
            TxtTen_Vitri.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kho"
    Private Sub V_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kho", "Dmkho", "1=1")
    End Sub
    Private Sub L_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_kho.Text = "" Then
            TxtTen_kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
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
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
