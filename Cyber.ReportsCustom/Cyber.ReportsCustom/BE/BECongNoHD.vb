Public Class BECongNoHD
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _M_Tk As String = ""
    Private Sub BECongNoHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        _M_Tk = Me.Para(Me.VT_PARA + 2).ToString.Trim
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        'Thời gin
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtTk.Text = _M_Tk
        If TxtTk.Text.Trim = "" Then TxtTk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTk)
        If TxtTk.Text.Trim = "" Then TxtTen_Tk.Text = "" Else TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTk.Text.Trim + "'", CyberSmLib)
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'Tk
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk
        'Ma_TD3
        RemoveHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        'Ma_HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        'Ma_Kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'Nh_Kh1
        RemoveHandler TxtNh_Kh1.CyberValiting, AddressOf V_Nh_Kh1
        RemoveHandler TxtNh_Kh1.CyberLeave, AddressOf L_Nh_Kh1
        AddHandler TxtNh_Kh1.CyberValiting, AddressOf V_Nh_Kh1
        AddHandler TxtNh_Kh1.CyberLeave, AddressOf L_Nh_Kh1
        'Nh_Kh2
        RemoveHandler TxtNh_Kh2.CyberValiting, AddressOf V_Nh_Kh2
        RemoveHandler TxtNh_Kh2.CyberLeave, AddressOf L_Nh_Kh2
        AddHandler TxtNh_Kh2.CyberValiting, AddressOf V_Nh_Kh2
        AddHandler TxtNh_Kh2.CyberLeave, AddressOf L_Nh_Kh2
        'Nh_Kh3
        RemoveHandler TxtNh_Kh3.CyberValiting, AddressOf V_Nh_Kh3
        RemoveHandler TxtNh_Kh3.CyberLeave, AddressOf L_Nh_Kh3
        AddHandler TxtNh_Kh3.CyberValiting, AddressOf V_Nh_Kh3
        AddHandler TxtNh_Kh3.CyberLeave, AddressOf L_Nh_Kh3
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk", "DmTkCN", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk")
            TxtTen_Tk.Text = DrReturn.Item("Ten_Tk")
        Else
            TxtTk.Text = ""
            TxtTen_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_TD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_TD3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_TD3.Text = ""
            TxtTen_TD3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kh1"
    Private Sub V_Nh_Kh1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kh1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKh", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_Kh1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kh1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh1.Text = ""
            TxtTen_Nh_Kh1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kh2"
    Private Sub V_Nh_Kh2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kh2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKh", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_Kh2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kh2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh2.Text = ""
            TxtTen_Nh_Kh2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kh3"
    Private Sub V_Nh_Kh3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kh3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKh", "1=1", "Loai_Nh = '3'")
    End Sub
    Private Sub L_Nh_Kh3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kh3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh3.Text = ""
            TxtTen_Nh_Kh3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kh1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kh2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kh3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_CN.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_Du_No.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_Du_Co.Checked, "1", "0")
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
