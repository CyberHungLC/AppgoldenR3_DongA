Public Class DmTkKc
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DmTkKc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTk01.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtTk01.Text.Trim = "" Then TxtTen_Tk01.Text = "" Else TxtTen_Tk01.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "Tk0 = N'" + TxtTk01.Text.Trim + "'", CyberSmlib)
        If TxtTk02.Text.Trim = "" Then TxtTen_Tk02.Text = "" Else TxtTen_Tk02.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "Tk0 = N'" + TxtTk02.Text.Trim + "'", CyberSmlib)
        If TxtMa_BP.Text.Trim = "" Then TxtTen_BP.Text = "" Else TxtTen_BP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_BP", "DmBP", "Ma_BP = N'" + TxtMa_BP.Text.Trim + "'", CyberSmlib)

        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs            
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtTk01.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtTk01.KeyPress, AddressOf TxtCodeError_KeyPress

        'Tk01
        RemoveHandler TxtTk01.CyberValiting, AddressOf V_Tk01
        RemoveHandler TxtTk01.CyberLeave, AddressOf L_Tk01
        AddHandler TxtTk01.CyberValiting, AddressOf V_Tk01
        AddHandler TxtTk01.CyberLeave, AddressOf L_Tk01
        'Tk02
        RemoveHandler TxtTk02.CyberValiting, AddressOf V_Tk02
        RemoveHandler TxtTk02.CyberLeave, AddressOf L_Tk02
        AddHandler TxtTk02.CyberValiting, AddressOf V_Tk02
        AddHandler TxtTk02.CyberLeave, AddressOf L_Tk02
        'Ma_BP
        RemoveHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        RemoveHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk01"
    Private Sub V_Tk01(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk01.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk01(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk01.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk01.Text = DrReturn.Item("Tk0")
            TxtTen_Tk01.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk01.Text = ""
            TxtTen_Tk01.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Tk02"
    Private Sub V_Tk02(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk02.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk02(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk02.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk02.Text = DrReturn.Item("Tk0")
            TxtTen_Tk02.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk02.Text = ""
            TxtTen_Tk02.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_BP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtTk01.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub

    Private Sub LabMa_Tx1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LabMa_Tx1.Click

    End Sub

#End Region
End Class
