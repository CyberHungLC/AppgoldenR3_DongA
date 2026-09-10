Public Class GLCD1_BPPhi
    Dim DtBac_Tk As DataTable
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtTTCP As DataTable
    Private Sub GLCD1_BPPhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberSmLib.AddStatusVoucher(Me, Me.User_Name.Trim & "(" & Me.Comment.Trim & ")", Me.sysvar("M_Cyber_Ver"), Me.Ma_Dvcs)
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '-----
        DtBac_Tk = GetBac_TK()
        CyberFill.V_FillComBoxValue(Me.CmbM_Bac_TK, DtBac_Tk, "Bac_Tk", IIf(Me.LAN = "V", "Ten_Bac", "Ten_Bac2"), "0")
        CmbM_Bac_TK.SelectedValue = "0"
        '----Set
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        TxtNgay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtNgay_Ct1)
        TxtNgay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtNgay_Ct2)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Function GetBac_TK() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Bac_Tk")
        _Return.Columns.Add("Ten_Bac")
        _Return.Columns.Add("Ten_Bac2")
        _Return.Rows.Add("0", "Tất cả các bậc tài khoản", "All")
        _Return.Rows.Add("1", "Tài khoản bậc 1", "Account type 1")
        _Return.Rows.Add("2", "Tài khoản bậc 2", "Account type 2")
        _Return.Rows.Add("3", "Tài khoản bậc 3", "Account type 3")
        _Return.Rows.Add("4", "Tài khoản bậc 4", "Account type 4")
        _Return.Rows.Add("5", "Tài khoản bậc 5", "Account type 5")
        _Return.Rows.Add("6", "Tài khoản bậc 6", "Account type 6")
        _Return.Rows.Add("7", "Tài khoản bậc 7", "Account type 7")
        _Return.Rows.Add("8", "Tài khoản bậc 8", "Account type 8")
        _Return.Rows.Add("9", "Tài khoản bậc 9", "Account type 9")
        _Return.Rows.Add("10", "Tài khoản bậc 10", "Account type 10")

        GetBac_TK = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'Nh_BP1
        AddHandler TxtNh_BP1.CyberValiting, AddressOf V_Nh_BP1
        AddHandler TxtNh_BP1.CyberLeave, AddressOf L_Nh_BP1
        'Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        'Nh_Phi1
        AddHandler TxtNh_Phi1.CyberValiting, AddressOf V_Nh_Phi1
        AddHandler TxtNh_Phi1.CyberLeave, AddressOf L_Nh_Phi1
        'Ma_Phi
        AddHandler TxtMa_Phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_Phi.CyberLeave, AddressOf L_Ma_Phi
        'NonVat       
        AddHandler TxtNonVat.CyberValiting, AddressOf V_NonVat
        AddHandler TxtNonVat.CyberLeave, AddressOf L_NonVat
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Nh_BP1"
    Private Sub V_Nh_BP1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_BP1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhBP", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_BP1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_BP1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_BP1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_BP1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP1.Text = ""
            TxtTen_Nh_BP1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_BP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Phi1"
    Private Sub V_Nh_Phi1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Phi1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhPhi", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_Phi1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Phi1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Phi1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi1.Text = ""
            TxtTen_Nh_Phi1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Phi.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Phi.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_Phi.Text = ""
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- NonVat"
    Private Sub V_NonVat(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNonVat.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma", "DmNonVat", "1=1", "1=1")
    End Sub
    Private Sub L_NonVat(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNonVat.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNonVat.Text = DrReturn.Item("Ma")
        Else
            TxtNonVat.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)      
        CyberMe.M_Loai_DK_Loc = "1"
        Dim Dt1 As Date = TxtNgay_Ct1.Value
        Dim Dt2 As Date = TxtNgay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_Bac_Tk As String = Me.CmbM_Bac_TK.SelectedValue.ToString.Trim
        Dim M_LK As String = "0"
        If ChkM_LK.Checked Then M_LK = "1" Else M_LK = "0"

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_BP1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Phi1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Phi.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNonVat.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Bac_Tk
        M_strParameterStore = M_strParameterStore & "#" & M_LK
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()



    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
