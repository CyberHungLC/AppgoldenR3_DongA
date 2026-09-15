Public Class ROBH_BC02
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim DtTrangThai, DtNguon_Gui As DataTable
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Dim DsTmp As DataSet
    Private Sub ROBC03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
#Region "Chi tiet theo"

#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '------------------------------------------------------------------------------
        DsTmp = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_CS01_Filter", "#" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        DtNguon_Gui = DsTmp.Tables(4)
        DtTrangThai = DsTmp.Tables(5)

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_BH.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_BH)
        TxtMa_Xe.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Xe)
        TxtSo_Ro.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_Ro)

        If TxtMa_BH.Text.Trim = "" Then TxtTen_BH.Text = "" Else TxtTen_BH.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BH", "DmBH", "(Ma_BH = N'" + TxtMa_BH.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '-- Đơn vị bảo hiểm
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH

        '-- So_Ro
        AddHandler TxtSo_Ro.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BH.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_BH")
            TxtTen_BH.Text = DrReturn.Item("Ten_BH")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Valid --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali - Lenh_Ro"
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = TxtM_Ngay_Ct1.Value
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.sysvar, "", "S", "", _Dt, TxtSo_Ro.Text, "", Ma_Dvcs, User_Name, CyberSmLib)
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BH.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Ro.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Dvcs_Filter
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