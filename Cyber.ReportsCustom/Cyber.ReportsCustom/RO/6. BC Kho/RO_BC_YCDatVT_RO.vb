Public Class RO_BC_YCDatVT_RO
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_post1, _Dt_post2, _DtMa_TT, _Dt_Loai_lenh, _Dt_Loai_lenh1, _Dt_Loai_lenh2 As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
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
        '--------------------------------------------------------------------------------------------------------------------------------------

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        _DsMa_TT.Dispose()

        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        '--------------------------------------------------------------------------------------------------------------------------------------
        '------------------------------------------------------------------------------
        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_ROBC_Load_Ngam_Dinh", CBBMa_Dvcs.SelectedValue + "#" + User_Name)
        _Dt_Loai_lenh = DsTmp.Tables(0).Copy
        _Dt_Loai_lenh1 = DsTmp.Tables(1).Copy
        _Dt_Loai_lenh2 = DsTmp.Tables(2).Copy
        CyberFill.V_FillComBoxDefaul(CbbLoai_lenh, _Dt_Loai_lenh, "Ma", "Ten")

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Hs_H.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs_H)

        If TxtMa_Hs_H.Text.Trim = "" Then TxtTen_Hs_H.Text = "" Else TxtTen_Hs_H.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "(Ma_kh = N'" + TxtMa_Hs_H.Text.Trim + "')", CyberSmLib)
        ChkLoai0.Checked = True

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma khach hang
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_Hs_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_Hs_H
        '-- ma HS

        '-- ma xe
        AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_Xe
        AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_Xe

        AddHandler ChkLoai1.CheckedChanged, AddressOf L_Loai1
        AddHandler ChkLoai2.CheckedChanged, AddressOf L_Loai2
        AddHandler ChkLoai3.CheckedChanged, AddressOf L_Loai3
        AddHandler ChkLoai0.CheckedChanged, AddressOf L_Loai0
    End Sub

#End Region
#Region "Valid"
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs_H.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_xe.Text = DrReturn.Item("Ma_Xe")
        Else
            TxtMa_xe.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Check"
    Private Sub L_Loai1()
        If ChkLoai1.Checked = True Then
            ChkLoai2.Checked = False
            ChkLoai3.Checked = False
            ChkLoai0.Checked = False
        End If
    End Sub
    Private Sub L_Loai2()
        If ChkLoai2.Checked = True Then
            ChkLoai1.Checked = False
            ChkLoai0.Checked = False
            ChkLoai3.Checked = False
        End If
    End Sub
    Private Sub L_Loai3()
        If ChkLoai3.Checked = True Then
            ChkLoai2.Checked = False
            ChkLoai0.Checked = False
            ChkLoai1.Checked = False
        End If
    End Sub
    Private Sub L_Loai0()
        If ChkLoai0.Checked = True Then
            ChkLoai2.Checked = False
            ChkLoai3.Checked = False
            ChkLoai1.Checked = False
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim Loai0 As String = ""
        Dim Loai1 As String = ""
        Dim Loai2 As String = ""
        Dim Loai3 As String = ""
        Dim Loai4 As String = ""
        If ChkLoai0.Checked = True Then Loai0 = "1"
        If ChkLoai1.Checked = True Then Loai1 = "1"
        If ChkLoai2.Checked = True Then Loai2 = "1"
        If ChkLoai3.Checked = True Then Loai3 = "1"


        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbLoai_lenh.SelectedValue
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Loai0.ToString
        M_strParameterStore = M_strParameterStore & "#" & Loai1.ToString
        M_strParameterStore = M_strParameterStore & "#" & Loai2.ToString
        M_strParameterStore = M_strParameterStore & "#" & Loai3.ToString
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

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkLoai2.CheckedChanged

    End Sub
End Class
