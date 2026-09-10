Public Class CRM_KQLH_Detail
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DtGroup, Dt_Loai, Dt_Ngay_D As DataTable
    Dim DvGroup, Dv_Loai, Dv_Ngay_D As DataView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_GetData()

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

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_GetData()

    End Sub

    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        AddHandler TxtMa_Cs.CyberValiting, AddressOf V_Ma_Cs
        AddHandler TxtMa_Cs.CyberLeave, AddressOf L_Ma_Cs
        AddHandler TxtMa_Loai.CyberValiting, AddressOf V_Ma_loai
        AddHandler TxtMa_Loai.CyberLeave, AddressOf L_Ma_loai
        AddHandler TxtMa_Ngay.CyberValiting, AddressOf V_Ma_Ngay
        AddHandler TxtMa_Ngay.CyberLeave, AddressOf L_Ma_Ngay

        'AddHandler ChkNgay_Goi.Click, AddressOf V_Chk_Ngay_Goi
    End Sub
    Private Sub V_Chk_Ngay_Goi(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region
#Region "Vali --- Ma_Cs"
    Private Sub V_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Cs.Text = "" Then
            TxtTen_Cs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cs.Text = DrReturn.Item("Ma_HS")
            TxtTen_Cs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Cs.Text = ""
            TxtTen_Cs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_loai"
    Private Sub V_Ma_loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Loai.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "CRMMa_Loai", "CRMDmLoai", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Loai.Text = "" Then
            TxtTen_Loai.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Loai.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Loai.Text = DrReturn.Item("CRMMa_Loai")
            TxtTen_Loai.Text = DrReturn.Item("CRMTen_Loai")
        Else
            TxtMa_Loai.Text = ""
            TxtTen_Loai.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ngay"
    Private Sub V_Ma_Ngay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Ngay.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Ngay", "CRMLoaiNgay", "1=1", "1=1")
    End Sub

    Private Sub L_Ma_Ngay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Ngay.Text = "" Then
            Txtten_Ngay.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Ngay.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Ngay.Text = DrReturn.Item("Ma_Ngay")
            Txtten_Ngay.Text = DrReturn.Item("Ten_Ngay")
        Else
            TxtMa_Ngay.Text = ""
            Txtten_Ngay.Text = ""
        End If
    End Sub
#End Region

#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Loai As String = ""
        Dim _Ma_Loai As String = ""
        Dim _Ma_Ngay As String = ""

        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Try
            _Loai = Me.Para(M_VT_PARA + 2).ToString.Trim.ToUpper()
        Catch ex As Exception

        End Try



        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Loai.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Ngay.Text
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkNgay_Goi.Checked, "1", "0")

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
