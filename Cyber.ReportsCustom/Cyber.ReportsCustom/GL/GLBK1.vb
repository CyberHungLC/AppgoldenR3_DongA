Public Class GLBK1
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy, _Dt_Post1, _Dt_Post2 As DataTable
    Dim _Ma_Ct, _Ma_Post1, _Ma_Post2 As String
    Private Sub GLBK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Ma_Ct = Me.Para(Me.VT_PARA + 2).Trim
        _Ma_Post1 = Me.Para(Me.VT_PARA + 3).Trim
        _Ma_Post2 = Me.Para(Me.VT_PARA + 4).Trim

        Dim _DsGroup As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "Groupby#CP_NAME= N'CP_GLBK1'#ID")
        _DtGroupBy = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbNhom, _DtGroupBy, "Nhom", "Ten_Nhom", "")
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        'Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        ' Load Ma_Post
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", _Ma_Ct & "##")
        _Dt_Post1 = _DsPost.Tables(0).Copy
        _Dt_Post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(CmbMa_Post1, _Dt_Post1, "Ma_Post", "Ten_Post", _Ma_Post1)
        CyberFill.V_FillComBoxValue(CmbMa_post2, _Dt_Post2, "Ma_Post", "Ten_Post", _Ma_Post2)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'NonVat
        RemoveHandler TxtNonVat.CyberValiting, AddressOf V_NonVat
        RemoveHandler TxtNonVat.CyberLeave, AddressOf L_NonVat
        AddHandler TxtNonVat.CyberValiting, AddressOf V_NonVat
        AddHandler TxtNonVat.CyberLeave, AddressOf L_NonVat
        'Tk
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
        'Tk_Du
        RemoveHandler TxtTk_Du.CyberValiting, AddressOf V_TK_DU
        RemoveHandler TxtTk_Du.CyberLeave, AddressOf L_TK_DU
        AddHandler TxtTk_Du.CyberValiting, AddressOf V_TK_DU
        AddHandler TxtTk_Du.CyberLeave, AddressOf L_TK_DU
        'Ma_Kh_N
        RemoveHandler TxtMa_Kh_N.CyberValiting, AddressOf V_Ma_Kh_N
        RemoveHandler TxtMa_Kh_N.CyberLeave, AddressOf L_Ma_Kh_N
        AddHandler TxtMa_Kh_N.CyberValiting, AddressOf V_Ma_Kh_N
        AddHandler TxtMa_Kh_N.CyberLeave, AddressOf L_Ma_Kh_N
        'Ma_Kh_C
        RemoveHandler TxtMa_Kh_C.CyberValiting, AddressOf V_Ma_Kh_C
        RemoveHandler TxtMa_Kh_C.CyberLeave, AddressOf L_Ma_Kh_C
        AddHandler TxtMa_Kh_C.CyberValiting, AddressOf V_Ma_Kh_C
        AddHandler TxtMa_Kh_C.CyberLeave, AddressOf L_Ma_Kh_C
        'Ma_Nt
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT
        'Ma_Ct
        RemoveHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_CT
        RemoveHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_CT
        AddHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_CT
        AddHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_CT
        '-------------------------------------------------------------------------------------------------------------------
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
        'Ma_Sp
        RemoveHandler TxtMa_SP.CyberValiting, AddressOf V_Ma_Sp
        RemoveHandler TxtMa_SP.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_SP.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_SP.CyberLeave, AddressOf L_Ma_Sp
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
        'Ma_CD
        RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        'Ma_BP
        RemoveHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_Bp
        RemoveHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_Bp
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_Bp
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
        'Ma_Tuyen
        RemoveHandler TxtMa_Tuyen.CyberValiting, AddressOf V_Ma_Tuyen
        RemoveHandler TxtMa_Tuyen.CyberLeave, AddressOf L_Ma_Tuyen
        AddHandler TxtMa_Tuyen.CyberValiting, AddressOf V_Ma_Tuyen
        AddHandler TxtMa_Tuyen.CyberLeave, AddressOf L_Ma_Tuyen
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
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk_DU"
    Private Sub V_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Du.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Du.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Du.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk_Du.Text = ""
            TxtTen_Tk_Du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh_N"
    Private Sub V_Ma_Kh_N(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh_N.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_N(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh_N.Text = "" Then
            TxtTen_kh_N.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh_N.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh_N.Text = DrReturn.Item("Ma_Kh")
            TxtTen_kh_N.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh_N.Text = ""
            TxtTen_kh_N.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh_C"
    Private Sub V_Ma_Kh_C(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh_C.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_C(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh_C.Text = "" Then
            TxtTen_kh_C.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh_C.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh_C.Text = DrReturn.Item("Ma_Kh")
            TxtTen_kh_C.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh_C.Text = ""
            TxtTen_kh_C.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
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
#Region "Vali --- Ma_NT"
    Private Sub V_Ma_NT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_NT.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NT", "DmNT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_NT.Text = "" Then
            TxtTen_NT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_NT.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            TxtTen_NT.Text = DrReturn.Item("Ten_NT")
        Else
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CT"
    Private Sub V_Ma_CT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CT.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CT", "DmCT", "M_Approval LIKE N'%CT00%'", "1=1")
    End Sub
    Private Sub L_Ma_CT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CT.Text = "" Then
            TxtTen_Ct.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CT.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CT.Text = DrReturn.Item("Ma_CT")
            TxtTen_Ct.Text = DrReturn.Item("Ten_CT")
        Else
            TxtMa_CT.Text = ""
            TxtTen_Ct.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
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
        TxtMa_Phi.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
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
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_SP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_SP.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_SP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_SP.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_SP.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
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
        TxtMa_TTCP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
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
        TxtMa_Ku.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Ku.Text = "" Then
            TxtTen_ku.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_ku.Text = DrReturn.Item("Ten_Ku")
        Else
            TxtMa_Ku.Text = ""
            TxtTen_ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BP.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_BP.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
        TxtMa_TD1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD1.Text = "" Then
            TxtTen_Td1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_Td1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_TD1.Text = ""
            TxtTen_Td1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD2.Text = "" Then
            TxtTen_Td2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_Td2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_TD2.Text = ""
            TxtTen_Td2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD3.Text = "" Then
            TxtTen_Td3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_Td3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_TD3.Text = ""
            TxtTen_Td3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD4.Text = "" Then
            TxtTen_Td4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_Td4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_TD4.Text = ""
            TxtTen_Td4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TD5.Text = "" Then
            TxtTen_Td5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TD5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_Td5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_TD5.Text = ""
            TxtTen_Td5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Tuyen"
    Private Sub V_Ma_Tuyen(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Tuyen.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_Tuyen", "DmTuyen", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Tuyen(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Tuyen.Text = "" Then
            TxtTen_Tuyen.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Tuyen.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Tuyen.Text = DrReturn.Item("Ma_Tuyen")
            TxtTen_Tuyen.Text = DrReturn.Item("Ten_Tuyen")
        Else
            TxtMa_Tuyen.Text = ""
            TxtTen_Tuyen.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Ma_Post1 As String = CmbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2 As String = CmbMa_post2.SelectedValue.ToString.Trim

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim _No_Co As String = ""
        If ChkNo.Checked Then
            If ChkCo.Checked Then _No_Co = "" Else _No_Co = "1"
        Else
            If ChkCo.Checked Then _No_Co = "2" Else _No_Co = ""
        End If

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNonVat.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtDien_Giai.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbNhom.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Du.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _No_Co
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh_N.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh_C.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_NT.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CT.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Phi.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_SP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Ku.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTLN.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TD5.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Tuyen.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post1.Trim & "#" & _Ma_Post2.Trim
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
