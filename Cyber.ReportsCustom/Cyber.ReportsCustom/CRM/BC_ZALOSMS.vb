Public Class BC_ZALOSMS
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DtGroup, Dt_Loai, Dt_Ngay_D, Dt_Template As DataTable
    Dim DvGroup, Dv_Loai, Dv_Ngay_D, Dv_Template As DataView
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

        Dim _Loai_Gui As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_Loai_Gui", Me.Ma_Dvcs & "#" & Me.User_Name)
        Dt_Loai = _Loai_Gui.Tables(0).Copy
        Dt_Template = _Loai_Gui.Tables(1).Copy
        CyberFill.V_FillComBoxValue(Me.CbbLoai_Gui, Dt_Loai, "Ma_Loai", "Ten_Loai", "")
        CyberFill.V_FillComBoxValue(Me.CbbTemp, Dt_Template, "Ma_Template", "Ten_Template", "")

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_GetData()

    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
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
        M_strParameterStore = M_strParameterStore & "#" & CbbLoai_Gui.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbTemp.SelectedValue.ToString.Trim
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
