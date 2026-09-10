Public Class INCD1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy, _Dt_Ma_Post1, _Dt_Ma_Post2 As DataTable
    Dim _DtTTCP As DataTable
    Private Sub INSD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function
    Private Sub V_Load()
        CyberFill.V_FillComBoxDefaul(Me.CmbTinh_Dc, _DtGroupBy, "Tinh_dc", "Ten_DC", "Ngam_Dinh")
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kho)
        TxtMa_Vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vt)

        'If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Vt.Text.Trim = "" Then TxtTen_Vt.Text = "" Else TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_Vt.Text.Trim + "')", CyberSmLib)

        If TxtNh_Vt1.Text.Trim = "" Then TxtTen_Nh_Vt1.Text = "" Else TxtTen_Nh_Vt1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vt1.Text.Trim + "')", CyberSmLib)
        If TxtNh_Vt2.Text.Trim = "" Then TxtTen_Nh_Vt2.Text = "" Else TxtTen_Nh_Vt2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vt2.Text.Trim + "')", CyberSmLib)
        If TxtNh_Vt3.Text.Trim = "" Then TxtTen_Nh_Vt3.Text = "" Else TxtTen_Nh_Vt3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vt3.Text.Trim + "')", CyberSmLib)

        'Bổ sung thêm mức xử lý
        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_ROBC_Load_Ngam_Dinh", CBBMa_Dvcs.SelectedValue + "#" + User_Name)
        _Dt_Ma_Post1 = DsTmp.Tables(6).Copy
        _Dt_Ma_Post2 = DsTmp.Tables(7).Copy
        CyberFill.V_FillComBoxDefaul(CmbMa_Post1, _Dt_Ma_Post1, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(CmbMa_Post2, _Dt_Ma_Post2, "Ma", "Ten")
        ' Load cửa hàng
        Dim _DsTTCP As DataSet
        _DsTTCP = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_LoadReportsTTCP", Me.Para(14) & "#" & Me.Para(6))
        For i As Integer = 0 To _DsTTCP.Tables.Count - 1
            CyberSmodb.SetNotNullTable(_DsTTCP.Tables(i))
        Next
        _DtTTCP = _DsTTCP.Tables(0)
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TTCP, _DtTTCP, "Ma_TTCP", "Ten_TTCP")
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
        'Ma_Kho
        'AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        'AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        'Ma_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        'Tk_Vt
        AddHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        AddHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        'Nh_Vt1
        RemoveHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        RemoveHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        'Nh_Vt2
        RemoveHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        RemoveHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        'Nh_Vt3
        RemoveHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        RemoveHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        'Filter Ma_Dvcs
        AddHandler CmdMa_Kho.Click, AddressOf V_Filter_Ma_Kho
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
    '#Region "Valid --- Ma_Kho"
    '    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        TxtMa_Kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kho", "DmKho", "1=1", "1=1")
    '    End Sub
    '    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
    '            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
    '        Else
    '            TxtMa_Kho.Text = ""
    '            TxtTen_Kho.Text = ""
    '            Exit Sub
    '        End If
    '    End Sub
    '#End Region
#Region "Valid --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---TK_VT"
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Vt.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Vt.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Vt.Text = ""
            TxtTen_Tk_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Vt1.Text = "" Then
            TxtTen_Nh_Vt1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Vt1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt1.Text = ""
            TxtTen_Nh_Vt1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Vt2.Text = "" Then
            TxtTen_Nh_Vt2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Vt2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt2.Text = ""
            TxtTen_Nh_Vt2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Vt3.Text = "" Then
            TxtTen_Nh_Vt3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Vt3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt3.Text = ""
            TxtTen_Nh_Vt3.Text = ""
        End If
    End Sub
#End Region

#Region "Filter"
#Region "Filter Ma_Kho"
    Private Sub V_Filter_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Str As String
        Dim _Ten_Dm As String = "DmKho"
        Dim _Ma_Kho As String = TxtMa_Kho.Text.Trim
        Dim strTen As String = ""
        _Str = GetList(_Ten_Dm, _Ma_Kho, strTen)

        If _Str Is Nothing Then Exit Sub
        If _Str Is Nothing Then _Str = ""
        TxtMa_Kho.Text = _Str
    End Sub
#End Region
    Private Function GetList(ByVal Ten_DM As String, ByVal _List As String, ByRef _Ten As String) As String
        GetList = CyberSupport.V_GetStrSelectList(AppConn, sysvar, Para, "CP_GetListSelect", Ten_DM & "#" & _List & "#" & Ten_DM & "#" & Ma_Dvcs & "#" & User_Name, LAN, _Ten)
    End Function
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = ""
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNonVat.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_TTCP.SelectedValue.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbTinh_Dc.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup1.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup2.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup3.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & Me.Para(Me.VT_PARA + 1).ToString.Trim

        M_strParameterStore = M_strParameterStore & "#" & CmbMa_Post1.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_Post2.SelectedValue.ToString.Trim

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