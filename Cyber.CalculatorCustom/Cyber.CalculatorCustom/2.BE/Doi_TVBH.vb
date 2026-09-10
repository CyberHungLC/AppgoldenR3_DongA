Imports System.Windows.Forms

Public Class Doi_TVBH
    Dim M_Stt_rec As String = "", M_Back_Color As String = "", M_Mode As String = "", M_Row As DataRow = Nothing, M_Row_S As DataRow = Nothing

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim Dt_TTXL, TbTtxL, _Dt_VD, _Dt_BPHH As DataTable
    Dim vtbttxl, _Dv_BPHH, _Dv_CTVD As DataView
    Private Sub ROXPTFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load()

    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_Hd
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_Hd

        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_Hs
    End Sub
#Region "Valid"
    Private Sub V_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtMa_Lv.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Lv", "CRMDMLVKN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtMa_Lv.Text = "" Then
        '    TxtTen_Lv.Text = ""
        '    Exit Sub
        'End If
        'DrReturn = TxtMa_Lv.GetRowsSelectData(True)
        'If Not DrReturn Is Nothing Then
        '    TxtMa_Lv.Text = DrReturn.Item("Ma_Lv")
        '    TxtTen_Lv.Text = DrReturn.Item("Ten_Lv")
        'Else
        '    TxtMa_Lv.Text = ""
        '    TxtTen_Lv.Text = ""
        'End If
    End Sub
    Private Sub V_Ma_VD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'V_FilterMa_BPHH(CmbMa_VD, _Dv_BPHH)
    End Sub
    Private Sub V_Ma_BPHH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'V_FilterMa_CTVD(CmbMa_bphh, _Dv_CTVD)
    End Sub
    Private Sub V_FilterMa_BPHH(ByVal CbbVd As System.Windows.Forms.ComboBox, ByRef _Dv As DataView)
        ''Dim _Ma_VD As String = CmbMa_VD.SelectedValue.ToString.Trim
        'Dim _Filter As String = "1=1"
        ''_Filter = "Ma_VD = '" + _Ma_VD + "'"
        '_Dv.RowFilter = _Filter
    End Sub
    Private Sub V_FilterMa_CTVD(ByVal CbbVd As System.Windows.Forms.ComboBox, ByRef _Dv As DataView)
        ''Dim _Ma_BPHH As String = CmbMa_bphh.SelectedValue.ToString.Trim
        'Dim _Filter As String = "1=1"
        '_Filter = "Ma_BPHH = '" + _Ma_BPHH + "'"
        '_Dv.RowFilter = _Filter
    End Sub
#Region "Ma_To"
    Private Sub V_Ma_To(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtMa_To.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtMa_To.Text = "" Then
        '    TxtTen_To.Text = ""
        '    Exit Sub
        'End If
        'DrReturn = TxtMa_To.GetRowsSelectData(True)
        'If Not DrReturn Is Nothing Then
        '    TxtMa_To.Text = DrReturn.Item("Ma_BP")
        '    TxtTen_To.Text = DrReturn.Item("Ten_BP")
        'Else
        '    TxtMa_To.Text = ""
        '    TxtTen_To.Text = ""
        'End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HsKd.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_DOI_TVBH", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Close()
            Return
        End If
        If DsTmp.Tables.Count < 1 Then
            DsTmp.Dispose()
            Return
        End If
        Me.Save_OK = True

        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_hs", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HS.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub

    Private Sub V_Ma_Hd(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_Hd", "DmHd", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hd(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_Hd.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_Hd")
            TxtSo_HD.Text = DrReturn.Item("So_Hd")
            TxtTen_Hd.Text = DrReturn.Item("Ten_Hd")
            TxtNgay_Ct.Text = DrReturn.Item("Ngay_HD1")
            TxtMa_HsKd.Text = DrReturn.Item("Ma_HsKd")
            Dim DsHSKD As DataSet
            DsHSKD = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetValue", "DmHS#Ten_Hs#Ma_Hs='" + TxtMa_HsKd.Text.Trim + "'")
            If DsHSKD.Tables(0).Rows.Count > 0 Then
                TxtTen_HsKd.Text = DsHSKD.Tables(0).Rows.Item(0)("Ten_Hs")
            Else
                TxtTen_HsKd.Text = ""
            End If

        Else
            TxtMa_HD.Text = ""
            TxtSo_HD.Text = ""
            TxtTen_Hd.Text = ""
            TxtNgay_Ct.Text = ""
            TxtMa_HsKd.Text = ""
            TxtTen_HsKd.Text = ""
        End If
    End Sub
#Region "Support"
    'Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        SendKeys.Send("{TAB}")
    '    Else
    '        Exit Sub
    '    End If
    '    e.SuppressKeyPress = True
    'End Sub
#End Region
End Class
