Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Filter_NTS
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
    Private Sub Filter_NTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_AddMenuShorcut()
        V_Addhander()
        Dim CyberVouccher As New Sys
    End Sub
    Private Sub V_Load()
        M_Lan = Me.Lan
        M_Para = Me.Para
        osysvar = Me.Sysvar
        M_Appconn = Me.AppConn
        M_DsLookup = Me.DsLookup

        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date

        CyberFill.V_FillComBoxDefaul(CbbMa_Post, DtPost, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
        CyberFill.V_FillComBoxDefaul(CbbMa_GD, DtMaGD, "Ma_GD", IIf(Me.Lan = "V", "Ten_GD", "Ten_GD2"))

        CyberSmodb.GetValueToControler(Me)
        '---
        CyberSupport.Translaste(Me, Me.Lan, True)

    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        'Ma_Kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH               
        'Ma_CTTS
        RemoveHandler TxtMa_CTTS.CyberValiting, AddressOf V_Ma_CTTS
        RemoveHandler TxtMa_CTTS.CyberLeave, AddressOf L_Ma_CTTS
        AddHandler TxtMa_CTTS.CyberValiting, AddressOf V_Ma_CTTS
        AddHandler TxtMa_CTTS.CyberLeave, AddressOf L_Ma_CTTS
        'Ma_Kho
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
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
        'Ma_Vv
        RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        'Ma_HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        'Ma_Phi
        RemoveHandler TxtMa_Phi.CyberValiting, AddressOf V_Ma_Phi
        RemoveHandler TxtMa_Phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_Phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_Phi.CyberLeave, AddressOf L_Ma_Phi
        'Ma_SP
        RemoveHandler TxtMa_SP.CyberValiting, AddressOf V_Ma_SP
        RemoveHandler TxtMa_SP.CyberLeave, AddressOf L_Ma_SP
        AddHandler TxtMa_SP.CyberValiting, AddressOf V_Ma_SP
        AddHandler TxtMa_SP.CyberLeave, AddressOf L_Ma_SP
        'Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        'Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        'Ma_Ku
        RemoveHandler TxtMa_Ku.CyberValiting, AddressOf V_Ma_Ku
        RemoveHandler TxtMa_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler TxtMa_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler TxtMa_Ku.CyberLeave, AddressOf L_Ma_Ku
        'Ma_BP
        RemoveHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        RemoveHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        'Ma_Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        'Ma_TD1
        RemoveHandler TxtMa_TD1.CyberValiting, AddressOf V_Ma_TD1
        RemoveHandler TxtMa_TD1.CyberLeave, AddressOf L_Ma_TD1
        AddHandler TxtMa_TD1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_TD1.CyberLeave, AddressOf L_Ma_TD1
        'Ma_TD2
        RemoveHandler TxtMa_TD2.CyberValiting, AddressOf V_Ma_TD2
        RemoveHandler TxtMa_TD2.CyberLeave, AddressOf L_Ma_TD2
        AddHandler TxtMa_TD2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_TD2.CyberLeave, AddressOf L_Ma_TD2
        'Ma_TD3
        RemoveHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        'Ma_TD4
        RemoveHandler TxtMa_TD4.CyberValiting, AddressOf V_Ma_TD4
        RemoveHandler TxtMa_TD4.CyberLeave, AddressOf L_Ma_TD4
        AddHandler TxtMa_TD4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_TD4.CyberLeave, AddressOf L_Ma_TD4
        'Ma_TD5
        RemoveHandler TxtMa_TD5.CyberValiting, AddressOf V_Ma_TD5
        RemoveHandler TxtMa_TD5.CyberLeave, AddressOf L_Ma_TD5
        AddHandler TxtMa_TD5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_TD5.CyberLeave, AddressOf L_Ma_TD5
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""

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
#Region "Valid"
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
#Region "Vali --- Ma_CTTS"
    Private Sub V_Ma_CTTS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CTTS.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_CTTS", "DmCTTS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CTTS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CTTS.Text = "" Then
            TxtTen_CTTS.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CTTS.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CTTS.Text = DrReturn.Item("Ma_CTTS")
            TxtTen_CTTS.Text = DrReturn.Item("Ten_CTTS")
        Else
            TxtMa_CTTS.Text = ""
            TxtTen_CTTS.Text = ""
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
#Region "Vali --- Nh_CTTS1"
    Private Sub V_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS1.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS1.Text = "" Then
            ''TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS1.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS1.Text = ""
            'TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS2"
    Private Sub V_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS2.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS2.Text = "" Then
            'TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS2.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS2.Text = ""
            'TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS3"
    Private Sub V_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS3.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS3.Text = "" Then
            'TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS3.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS3.Text = ""
            'TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS4"
    Private Sub V_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS4.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS4.Text = "" Then
            'TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS4.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS4.Text = ""
            'TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS5"
    Private Sub V_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CTTS5.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CTTS5.Text = "" Then
            'TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CTTS5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS5.Text = DrReturn.Item("Ma_Nh")
            'TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS5.Text = ""
            'TxtTen_Nh5.Text = ""
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
        TxtMa_Phi.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Phi.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_Phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_SP"
    Private Sub V_Ma_SP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_SP.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_SP", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_SP.Text = "" Then
            TxtTen_SP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_SP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_SP.Text = DrReturn.Item("Ma_SP")
            TxtTen_SP.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_SP.Text = ""
            TxtTen_SP.Text = ""
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
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Ku.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Ku.Text = "" Then
            TxtTen_Ku.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_Ku.Text = DrReturn.Item("Ten_Ku")
        Else
            TxtMa_Ku.Text = ""
            TxtTen_Ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(M_Lan, M_Para, osysvar, AppConn, M_DsLookup, "Ma_BP", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BP.Text = "" Then
            TxtTen_BP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
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
        If TxtMa_TD1.Text = "" Then
            TxtTen_TD1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_TD1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_TD1.Text = ""
            TxtTen_TD1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD2.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD2.Text = "" Then
            TxtTen_TD2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_TD2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_TD2.Text = ""
            TxtTen_TD2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD3.Text = "" Then
            TxtTen_TD3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_TD3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_TD3.Text = ""
            TxtTen_TD3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD4.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD4.Text = "" Then
            TxtTen_TD4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_TD4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_TD4.Text = ""
            TxtTen_TD4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD5.V_LookUp(M_Lan, M_Para, oSysvar, M_Appconn, M_DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD5.Text = "" Then
            TxtTen_TD5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_TD5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_TD5.Text = ""
            TxtTen_TD5.Text = ""
        End If
    End Sub
#End Region
#End Region
End Class
