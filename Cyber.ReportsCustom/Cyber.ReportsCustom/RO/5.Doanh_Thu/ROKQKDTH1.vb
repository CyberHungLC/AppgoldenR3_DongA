Public Class ROKQKDTH1
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

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '-- So_Ro
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP

        '-- ma Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt

        '-- Nh_Vt
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1

        '-- ma Vt
        AddHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_CV
        AddHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_CV

        '-- ma Vt
        AddHandler TxtNh_CV1.CyberValiting, AddressOf V_Nh_CV1
        AddHandler TxtNh_CV1.CyberLeave, AddressOf L_Nh_CV1
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("ma_nh")
            TxtTen_NhVt1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt1.Text = ""
            TxtTen_NhVt1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_CV"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CV", "DmCV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Cv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cv.Text = DrReturn.Item("Ma_CV")
            TxtTen_CV.Text = DrReturn.Item("Ten_CV")
        Else
            TxtMa_Cv.Text = ""
            TxtTen_CV.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CV1"
    Private Sub V_Nh_CV1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CV1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhCV", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_CV1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CV1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CV1.Text = DrReturn.Item("ma_nh")
            TxtTen_NhCV1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CV1.Text = ""
            TxtTen_NhCV1.Text = ""
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CV1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim
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