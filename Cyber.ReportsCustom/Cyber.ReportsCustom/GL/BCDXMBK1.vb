Public Class BCDXMBK1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtMauBC As DataTable
    Dim _Loai_BC As String = ""
    Dim _DtGroupBy As DataTable
    Private Sub BCDXMBK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Loai_BC = Me.Para(Me.VT_PARA + 2).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kh)
        TxtMa_CC.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_CC)
        TxtMa_Vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vt)

        If TxtMa_Kh.Text.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "(Ma_Kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmLib)
        If TxtMa_CC.Text.Trim = "" Then TxtTen_CC.Text = "" Else TxtTen_CC.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CC", "DmCC", "(Ma_CC= N'" + TxtMa_CC.Text.Trim + "')", CyberSmLib)
        If TxtMa_Vt.Text.Trim = "" Then TxtTen_Vt.Text = "" Else TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_Vt.Text.Trim + "')", CyberSmLib)

        'Mau_BC
        Dim _MauBC As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_GetLoaiDX", _Loai_BC & "#" & Me.Ma_Dvcs & "#" & Me.User_Name)
        DtMauBC = _MauBC.Tables(0)
        CyberFill.V_FillComBoxDefaul(CbbDmMauBc, DtMauBC, "Ma", "Ten", "Ngam_Dinh")

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh

        'Ma_CC
        AddHandler TxtMa_CC.CyberValiting, AddressOf V_Ma_Cc
        AddHandler TxtMa_CC.CyberLeave, AddressOf L_Ma_Cc
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_CC"
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CC.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Cc", "DmCC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_CC.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CC.Text = DrReturn.Item("Ma_CC")
            TxtTen_CC.Text = DrReturn.Item("Ten_Cc")
        Else
            TxtMa_CC.Text = ""
            TxtTen_CC.Text = ""
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
        Dim _Mau_BC As String = CbbDmMauBc.SelectedValue.ToString.Trim

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = _Mau_BC & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CC.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vt.Text.Trim
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
