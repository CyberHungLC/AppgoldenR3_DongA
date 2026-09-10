Public Class BEBCTN03
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub BEBCTN03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        loadM_Loc()
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        TxtM_Ma_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_Hs)
        TxtM_Ma_Bp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_Bp)
        TxtM_Ma_Kx.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_Kx)

        If TxtM_Ma_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_hs", "Dmhs", "Ma_hs = N'" + TxtM_Ma_Hs.Text.Trim + "'", CyberSmLib)
        If TxtM_Ma_Bp.Text.Trim = "" Then TxtTen_Bp.Text = "" Else TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_bp", "Dmbp", "Ma_bp = N'" + TxtM_Ma_Bp.Text.Trim + "'", CyberSmLib)
        If TxtM_Ma_Kx.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_kx", "Dmkx", "Ma_kx = N'" + TxtM_Ma_Kx.Text.Trim + "'", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)

    End Sub
    Private Sub loadM_Loc()
        Dim dtLoc As New DataTable
        dtLoc.Columns.Add("Ma")
        dtLoc.Columns.Add("Ten")
        dtLoc.Columns.Add("Default")

        dtLoc.Rows.Add("1", "Loại xe", 1)
        dtLoc.Rows.Add("2", "Loại màu xe", 1)
        CyberFill.V_FillComBoxValue(CbbM_Ma_Loc, dtLoc, "Ma", "Ten", 1)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--HS
        AddHandler TxtM_Ma_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtM_Ma_Hs.CyberLeave, AddressOf L_Ma_HS
        '--BP
        AddHandler TxtM_Ma_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtM_Ma_Bp.CyberLeave, AddressOf L_Ma_BP
        '--Kx
        AddHandler TxtM_Ma_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtM_Ma_Kx.CyberLeave, AddressOf L_Ma_Kx

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_Hs.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtM_Ma_Hs.Text = ""
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_Bp.Text = DrReturn.Item("Ma_BP")
            TxtTen_Bp.Text = DrReturn.Item("Ten_BP")
        Else
            TxtM_Ma_Bp.Text = ""
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtM_Ma_Kx.Text = ""
            TxtTen_kx.Text = ""
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
        Dim M_strParameterStore As String = CbbM_Ma_Loc.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_Kx.Text.Trim
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
