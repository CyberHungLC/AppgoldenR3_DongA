Public Class BEKQTH1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub BEKQTH1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
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
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

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
        'Ma_Kx
        RemoveHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        'Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        'Nh_Kx2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        'Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        'Nh_Kx4
        RemoveHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_Kx4
        RemoveHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_Kx4
        AddHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_Kx4
        AddHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_Kx4
        'Nh_Kx5
        RemoveHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_Kx5
        RemoveHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_Kx5
        AddHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_Kx5
        AddHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_Kx5
        'Ma_Mau
        RemoveHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        RemoveHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        'Ma_Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_BP
        RemoveHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        RemoveHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
    End Sub
#End Region
#Region "Valid"
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
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "Is_KD = 1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh_Kx1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx2"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            TxtTen_Nh_Kx2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx3"
    Private Sub V_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '3'")
    End Sub
    Private Sub L_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            TxtTen_Nh_Kx3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx4"
    Private Sub V_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '4'")
    End Sub
    Private Sub L_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx4.Text = ""
            TxtTen_Nh_Kx4.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Kx5"
    Private Sub V_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '5'")
    End Sub
    Private Sub L_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx5.Text = ""
            TxtTen_Nh_Kx5.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx5.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
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
