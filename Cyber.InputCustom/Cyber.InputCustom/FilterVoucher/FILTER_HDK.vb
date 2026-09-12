Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Cyber.Voucher
Public Class FILTER_HDK
    Dim CyberSmlib As New Cyber.SmLib.Sys
    Dim CyberSmodb As New Cyber.Smodb.Sys
    Dim CyberSupport As New Cyber.Support.Sys
    Dim CyberFill As New Cyber.Fill.Sys
    Dim CyberLists As New Cyber.SmLists.Sys

    Dim DrReturn As DataRow
    Dim M_Lan As String
    Dim M_Para As String()
    Dim osysvar As Collection
    Dim M_Appconn As SqlConnection
    Dim M_DsLookup As DataSet
    Dim M_Ma_Dvcs As String = ""
    Dim DtPost2 As DataTable
    Dim M_Ma_TTCP As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Dim _DtTTCP As DataTable
    Private Sub HDK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_AddMenuShorcut()
        V_Addhander()
        M_Ma_Dvcs = Me.Para(14).ToString.Trim
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP(Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        Dim CyberVouccher As New Sys
        'CyberVouccher.V_Setcaption(Me, Me.Sysvar)
    End Sub
    Private Sub V_Load()
        M_Lan = Me.Lan
        M_Para = Me.Para
        osysvar = Me.Sysvar
        M_Appconn = Me.AppConn
        M_DsLookup = Me.DsLookup

        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date


        DtPost2 = DtPost.Copy
        Dim _Post2Default As String = ""
        Dim _PostDefault As String = "1"
        For i = 0 To DtPost2.Rows.Count - 1
            If DtPost2.Rows(i).Item("Ma_Post").ToString.Trim.ToUpper > _Post2Default Then _Post2Default = DtPost2.Rows(i).Item("Ma_Post").ToString.Trim.ToUpper

        Next
        CyberFill.V_FillComBoxValue(CbbMa_Post2, DtPost2, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"), _Post2Default)


        CyberFill.V_FillComBoxValue(CbbMa_Post, DtPost, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"), _PostDefault)

        'CyberFill.V_FillComBoxDefaul(CbbMa_Post, DtPost, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
        CyberFill.V_FillComBoxDefaul(CbbMa_GD, DtMaGD, "Ma_GD", IIf(Me.Lan = "V", "Ten_GD", "Ten_GD2"))

        ' Load cửa hàng
        Dim _DsTTCP As DataSet
        _DsTTCP = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadReportsTTCP", M_Para(14) & "#" & M_Para(6))
        For i As Integer = 0 To _DsTTCP.Tables.Count - 1
            CyberSmodb.SetNotNullTable(_DsTTCP.Tables(i))
        Next
        _DtTTCP = _DsTTCP.Tables(0)
        'CyberFill.V_FillComBoxDefaul(Me.CmbMa_TTCP, _DtTTCP, "Ma_TTCP", "Ten_TTCP")

        CyberSmodb.GetValueToControler(Me)
        '---
        CyberSupport.Translaste(Me, Me.Lan, True)
    End Sub

    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler TxtSo_Ct1.Leave, AddressOf V_So_CT1
        RemoveHandler TxtSo_Ct2.Leave, AddressOf V_So_CT2
        AddHandler TxtSo_Ct1.Leave, AddressOf V_So_CT1
        AddHandler TxtSo_Ct2.Leave, AddressOf V_So_CT2

        '--Ma_CV
        RemoveHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_CV
        RemoveHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_CV
        AddHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_CV
        AddHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_CV

        '--Ma_VT
        RemoveHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_VT
        RemoveHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_VT
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_VT
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_VT
        '--Ma_KHo
        RemoveHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_Kho
        '--VT1
        RemoveHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_VT1
        RemoveHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_VT1
        AddHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_VT1
        AddHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_VT1
        '--VT2
        RemoveHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_VT2
        RemoveHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_VT2
        AddHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_VT2
        AddHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_VT2
        '--VT3
        RemoveHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_VT3
        RemoveHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_VT3
        AddHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_VT3
        AddHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_VT3

        '--Ma_KH
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH

        '--Ma_Mau
        RemoveHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        RemoveHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau

        '--Ma_Kx
        RemoveHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx


        '--VT1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        '--VT2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        '--VT3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        '--VT4
        RemoveHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_Kx4
        RemoveHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_Kx4
        AddHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_Kx4
        AddHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_Kx4
        '--VT5
        RemoveHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_Kx5
        RemoveHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_Kx5
        AddHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_Kx5
        AddHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_Kx5
        '--Vv
        RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--Phi
        RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        '--Sp
        RemoveHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        RemoveHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        '--TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        '--Ku
        RemoveHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        RemoveHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku

        '--Bp
        RemoveHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        RemoveHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--TD1
        RemoveHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        RemoveHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        AddHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        '--TD2
        RemoveHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        RemoveHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        AddHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        '--TD3
        RemoveHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        '--TD4
        RemoveHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        RemoveHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        AddHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        '--TD5
        RemoveHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        RemoveHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        AddHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5

        '--Đội xe
        RemoveHandler TxtMa_Db.CyberValiting, AddressOf V_Ma_Db
        RemoveHandler TxtMa_Db.CyberLeave, AddressOf L_Ma_Db
        AddHandler TxtMa_Db.CyberValiting, AddressOf V_Ma_Db
        AddHandler TxtMa_Db.CyberLeave, AddressOf L_Ma_Db



    End Sub
    Private Sub V_So_CT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_GD As String = "S"
        If Me.Ma_CT.Trim.ToUpper = "HDP" Then _Ma_GD = "P"
        If Me.Ma_CT.Trim.ToUpper = "HDM" Then _Ma_GD = "B"
        Dim _Dt As Date = TxtNgay_Ct1.Value
        Dim _Ma_TTCP As String = ""
        _Ma_TTCP = TxtMa_TTCP.Text
        If _Ma_TTCP = "" Then Exit Sub
        TxtSo_Ct1.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, Me.Ma_CT, _Ma_GD, "M", _Dt, TxtSo_Ct1.Text, _Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

    End Sub
    Private Sub V_So_CT2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_GD As String = "S"
        If Me.Ma_CT.Trim.ToUpper = "HDP" Then _Ma_GD = "P"
        If Me.Ma_CT.Trim.ToUpper = "HDM" Then _Ma_GD = "B"

        Dim _Dt As Date = TxtNgay_Ct2.Value
        Dim _Ma_TTCP As String = ""
        _Ma_TTCP = TxtMa_TTCP.Text
        If _Ma_TTCP = "" Then Exit Sub
        TxtSo_Ct2.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, Me.Ma_CT, _Ma_GD, "M", _Dt, TxtSo_Ct2.Text, _Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        If TxtMa_Xe.Text.Trim = "" Then ChkIs_Bs.Checked = False

        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        'Me.Tag = M_strParameterStore
        Me.ReturnOk = True
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ReturnOk = False
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.Lan = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_KX.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KX.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx1.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx1.Text = "" Then
            ''TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            'TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx2"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx2.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx2.Text = "" Then
            'TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            'TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx3"
    Private Sub V_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx3.Text = "" Then
            'TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            'TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx4"
    Private Sub V_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx4.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Kx4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx4.Text = "" Then
            'TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx4.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx4.Text = ""
            'TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx5"
    Private Sub V_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx5.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Kx5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx5.Text = "" Then
            'TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx5.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx5.Text = ""
            'TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CV"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CV.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_CV", "DmCV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_CV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_CV")
            TxtTen_CV.Text = DrReturn.Item("Ten_CV")
        Else
            TxtMa_CV.Text = ""
            TxtTen_CV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vt.Text = "" Then
            TxtTen_Vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vt.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kho.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Kho", "DmKho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_Kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT1"
    Private Sub V_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT1.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT1.Text = "" Then
            ''TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT1.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT1.Text = ""
            'TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT2"
    Private Sub V_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT2.Text = "" Then
            'TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT2.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT2.Text = ""
            'TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT3"
    Private Sub V_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT3.Text = "" Then
            'TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT3.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT3.Text = ""
            'TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vv.Text = "" Then
            TxtTen_Vv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vv.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_phi.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Sp.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Sp.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Sp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Sp.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_Sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP_H.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Ku.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_Ku.Text = "" Then
            TxtTen_ku.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_ku.Text = DrReturn.Item("Ten_Ku")
        Else
            Txtma_Ku.Text = ""
            TxtTen_ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
#Region "Vali --- Ma_TD1"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD1.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td1.Text = "" Then
            TxtTen_Td1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_Td1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_Td1.Text = ""
            TxtTen_Td1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD2.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td2.Text = "" Then
            TxtTen_Td2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_Td2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_Td2.Text = ""
            TxtTen_Td2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td3.Text = "" Then
            TxtTen_Td3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_Td3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_Td3.Text = ""
            TxtTen_Td3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td4.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td4.Text = "" Then
            TxtTen_Td4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_Td4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_Td4.Text = ""
            TxtTen_Td4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD5.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td5.Text = "" Then
            TxtTen_Td5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_Td5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_Td5.Text = ""
            TxtTen_Td5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Db"
    Private Sub V_Ma_Db(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Db.V_LookUp(M_Lan, M_Para, osysvar, M_Appconn, M_DsLookup, "Ma_Db", "DmDB", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Db(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Db.Text = "" Then
            TxtTen_Db.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Db.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Db.Text = DrReturn.Item("Ma_Db")
            TxtTen_Db.Text = DrReturn.Item("Ten_Db")
        Else
            TxtMa_Db.Text = ""
            TxtTen_Db.Text = ""
        End If
    End Sub
#End Region
End Class
