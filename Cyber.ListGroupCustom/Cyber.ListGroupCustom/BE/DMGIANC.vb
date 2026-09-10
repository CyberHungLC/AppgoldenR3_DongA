Public Class DMGIANC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_PK.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_ban.Value = Now.Date
        End If
        TxtTen_Pk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Pk", "DmPk", "(Ma_Pk = N'" + TxtMa_PK.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_PK.CyberValiting, AddressOf V_Ma_Vt
        RemoveHandler TxtMa_PK.CyberLeave, AddressOf L_Ma_Vt
        AddHandler TxtMa_PK.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_PK.CyberLeave, AddressOf L_Ma_Vt

        RemoveHandler TxtMa_PK.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_PK.KeyPress, AddressOf TxtCodeError_KeyPress



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_PK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_PK", "DmPk", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_PK.Text = "" Then
            TxtTen_Pk.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_PK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_PK.Text = DrReturn.Item("Ma_Pk")
            TxtTen_Pk.Text = DrReturn.Item("Ten_Pk")
            TxtGia_nt2.Text = DrReturn.Item("Gia_Nt")
        Else
            TxtMa_PK.Text = ""
            TxtTen_Pk.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
        'CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_UpdateDmVtAndDmGia2", "2" & "#" & Mode & "#" & TxtMa_Vt.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
