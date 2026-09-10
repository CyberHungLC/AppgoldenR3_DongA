Public Class FACTTSBK1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtLoai_Phieu As DataTable
    Dim _Nxt As String = ""
    Private Sub FACTTSBK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _Nxt = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception
        End Try

        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()        
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        'Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Dim _DsGroup As New DataSet

        If _Nxt = "" Then
            _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_PHIEU_FA" & Me.Para(Me.VT_PARA + 2).ToString.Trim & "' AND Acti = '1'#ID")
        Else
            _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_PHIEU_FA" & _Nxt & "' AND Acti = '1'#ID")

        End If

        _DtLoai_Phieu = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Ct, _DtLoai_Phieu, "Nhom", "Ten_nhom")
        
        RemoveHandler CmbMa_Ct.SelectedValueChanged, AddressOf V_LoadMa_GD
        AddHandler CmbMa_Ct.SelectedValueChanged, AddressOf V_LoadMa_GD

        V_LoadMa_GD(New System.Object, New System.EventArgs)

        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        'Ma_CTTS
        AddHandler TxtMa_CTTS.CyberValiting, AddressOf V_Ma_CTTS
        AddHandler TxtMa_CTTS.CyberLeave, AddressOf L_Ma_CTTS
        'Nh_CTTS1
        RemoveHandler TxtNh_CTTS1.CyberValiting, AddressOf V_Nh_CTTS1
        RemoveHandler TxtNh_CTTS1.CyberLeave, AddressOf L_Nh_CTTS1
        AddHandler TxtNh_CTTS1.CyberValiting, AddressOf V_Nh_CTTS1
        AddHandler TxtNh_CTTS1.CyberLeave, AddressOf L_Nh_CTTS1
        'Nh_CTTS2
        RemoveHandler TxtNh_CTTS2.CyberValiting, AddressOf V_Nh_CTTS2
        RemoveHandler TxtNh_CTTS2.CyberLeave, AddressOf L_Nh_CTTS2
        AddHandler TxtNh_CTTS2.CyberValiting, AddressOf V_Nh_CTTS2
        AddHandler TxtNh_CTTS2.CyberLeave, AddressOf L_Nh_CTTS2
        'Nh_CTTS3
        RemoveHandler TxtNh_CTTS3.CyberValiting, AddressOf V_Nh_CTTS3
        RemoveHandler TxtNh_CTTS3.CyberLeave, AddressOf L_Nh_CTTS3
        AddHandler TxtNh_CTTS3.CyberValiting, AddressOf V_Nh_CTTS3
        AddHandler TxtNh_CTTS3.CyberLeave, AddressOf L_Nh_CTTS3
        'Nh_CTTS4
        RemoveHandler TxtNh_CTTS4.CyberValiting, AddressOf V_Nh_CTTS4
        RemoveHandler TxtNh_CTTS4.CyberLeave, AddressOf L_Nh_CTTS4
        AddHandler TxtNh_CTTS4.CyberValiting, AddressOf V_Nh_CTTS4
        AddHandler TxtNh_CTTS4.CyberLeave, AddressOf L_Nh_CTTS4
        'Nh_CTTS5
        RemoveHandler TxtNh_CTTS5.CyberValiting, AddressOf V_Nh_CTTS5
        RemoveHandler TxtNh_CTTS5.CyberLeave, AddressOf L_Nh_CTTS5
        AddHandler TxtNh_CTTS5.CyberValiting, AddressOf V_Nh_CTTS5
        AddHandler TxtNh_CTTS5.CyberLeave, AddressOf L_Nh_CTTS5
        'Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        'Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_CTTS"
    Private Sub V_Ma_CTTS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CTTS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CTTS", "DmCTTS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CTTS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_CTTS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CTTS.Text = DrReturn.Item("Ma_CTTS")
            TxtTen_CTTS.Text = DrReturn.Item("Ten_CTTS")
        Else
            TxtMa_CTTS.Text = ""
            TxtTen_CTTS.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CTTS1"
    Private Sub V_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCTTS", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS1.Text = "" Then
            TxtTen_Nh_CTTS1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_CTTS1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS1.Text = ""
            TxtTen_Nh_CTTS1.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CTTS2"
    Private Sub V_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCTTS", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS2.Text = "" Then
            TxtTen_Nh_CTTS2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_CTTS2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS2.Text = ""
            TxtTen_Nh_CTTS2.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CTTS3"
    Private Sub V_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCTTS", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS3.Text = "" Then
            TxtTen_Nh_CTTS3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_CTTS3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS3.Text = ""
            TxtTen_Nh_CTTS3.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CTTS4"
    Private Sub V_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCTTS", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CTTS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_CTTS4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS4.Text = ""
            TxtTen_Nh_CTTS4.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_CTTS5"
    Private Sub V_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCTTS", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CTTS5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_CTTS5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS5.Text = ""
            TxtTen_Nh_CTTS5.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_BP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_BP")
            TxtTen_Hs.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Ma_GD"
    Private Sub V_LoadMa_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Ct As String = ""
        Try
            _Ma_Ct = CmbMa_Ct.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        CyberMe.V_GetMaGD(AppConn, _Ma_Ct, CmbMa_GD, CyberSmLib, CyberFill)
    End Sub
#End Region
#End Region   
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)        
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_Ct.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbMa_GD.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CTTS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CTTS1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CTTS2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CTTS3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CTTS4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CTTS5.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Nxt
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
