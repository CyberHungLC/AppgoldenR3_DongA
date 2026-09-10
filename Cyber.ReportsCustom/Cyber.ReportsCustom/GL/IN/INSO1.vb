Public Class INSo1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_Ma_Post1, _Dt_Ma_Post2 As DataTable
    Dim _DtTTCP As DataTable
    Private Sub INSo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        TxtMa_Kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kho)
        TxtMa_Vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vt)

        If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Vt.Text.Trim = "" Then TxtTen_Vt.Text = "" Else TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_Vt.Text.Trim + "')", CyberSmLib)

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

        'Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_KHo
        'Ma_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        'NonVat
        AddHandler TxtNonVat.CyberValiting, AddressOf V_NonVat
        AddHandler TxtNonVat.CyberLeave, AddressOf L_NonVat
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kho", "DmKho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
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
        If TxtMa_Kho.Text.Trim = "" Then
            TxtMa_Kho.Focus()
            Exit Sub
        End If
        If TxtMa_Vt.Text.Trim = "" Then
            TxtMa_Vt.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Me.Para(Me.VT_PARA + 2).Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNonVat.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_Post1.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_Post2.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_TTCP.SelectedValue.Trim
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
