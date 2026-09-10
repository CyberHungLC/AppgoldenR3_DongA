Public Class GLTC2
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DtDmMauBc As DataTable
    Dim _DsTmp As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtTTCP As DataTable
    Private Sub GLTC2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtDmMauBc = CyberSmodb.OpenTableKey(AppConn, _DsTmp, "DmMauBC", "FILE_MauBC", "Acti = N'1' AND Ma_MauBc = N'GLTC2'", CyberSmLib)
        CyberFill.V_FillComBoxDefaul(Me.CmbDmMauBc, DtDmMauBc, "File_MauBC", IIf(Me.LAN = "V", "Ten_MauBC", "Ten_MauBc2"), "Ngam_Dinh")

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
        TxtM_Ngay_CT3.Value = Now.Date
        TxtM_Ngay_CT4.Value = Now.Date

        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtM_Ngay_CT3.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_CT3)
        TxtM_Ngay_CT4.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_CT4)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'NonVat
        AddHandler TxtNonVat.CyberValiting, AddressOf V_NonVat
        AddHandler TxtNonVat.CyberLeave, AddressOf L_NonVat
        '--> Ma_TTLN
        RemoveHandler BtnMa_TTCP.Click, AddressOf V_FilterMa_TTCP
        AddHandler BtnMa_TTCP.Click, AddressOf V_FilterMa_TTCP
    End Sub
#End Region
#Region "Valid"
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
#Region "Filter"
    Private Sub V_FilterMa_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        Dim _Ten_Dm As String = "DmTTCP"
        Dim _Ma_Ct As String = TxtMa_TTCP.Text.Trim
        Dim strTen As String = ""
        str = GetList(_Ten_Dm, _Ma_Ct, strTen)

        If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        TxtMa_TTCP.Text = str
    End Sub
    Private Function GetList(ByVal Ten_DM As String, ByVal _List As String, ByRef _Ten As String) As String
        GetList = CyberSupport.V_GetStrSelectList(AppConn, sysvar, Para, "CP_GetListSelect", Ten_DM & "#" & _List & "#" & Ten_DM & "#" & Ma_Dvcs & "#" & User_Name, LAN, _Ten)
    End Function
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim Dt3 As Date = TxtM_Ngay_CT3.Value
        Dim Dt4 As Date = TxtM_Ngay_CT4.Value

        Dim _MauBc As String = ""
        Try
            _MauBc = CmbDmMauBc.SelectedValue.ToString.Trim()
        Catch ex As Exception
        End Try
        If _MauBc.Trim = "" Then
            CmbDmMauBc.Focus()
            Exit Sub
        End If

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt3.ToString("yyyyMMdd") & "#" & Dt4.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _MauBc.Trim
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & TxtNonVat.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text
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
