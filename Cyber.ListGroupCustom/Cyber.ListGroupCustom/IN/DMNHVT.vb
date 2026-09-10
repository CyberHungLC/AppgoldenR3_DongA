Public Class DMNHVT
    Dim DrReturn As DataRow '  DataRowView
    Dim DtrReturn As DataRow
    Dim Ds As New DataSet
    Dim DsLookup As New DataSet
    '----------------------------------------------------------------------
    Dim DtGroup As DataTable
    Dim Dt_CapNhom As DataTable
    Dim Dv_CapNhom As DataView
    '----------------------------------------------------------------------
    Dim _Loai_NhOld As String = ""
    Dim _ma_NhOld As String = ""
    'Dim CyberSmlistSys As New Sys
    Private Sub DMNHVT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_LoadLoaiNhom()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Not Me.DrOld Is Nothing Then
            _Loai_NhOld = Me.DrOld.Item("Loai_Nh")
            _ma_NhOld = Me.DrOld.Item("Ma_nh")
        Else
            _Loai_NhOld = ""
            _ma_NhOld = ""
        End If
        If Me.Mode = "S" Then
            _Loai_NhOld = CmbLoai_Nh.SelectedValue.ToString.Trim
            _ma_NhOld = Txtma_nh.Text.Trim
        Else
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
        GetTbCapNhom()
        CmbLoai_Nh.Select()

    End Sub
    Private Sub GetTbCapNhom()
        Dim _Loai_NhNew = "", _Ma_nhNew As String = ""
        Dim DsTmp As New DataSet
        If CmbLoai_Nh.Text = "" Then CmbLoai_Nh.SelectedIndex = 0
        _Loai_NhNew = CmbLoai_Nh.SelectedValue.ToString.Trim
        _Ma_nhNew = Txtma_nh.Text.Trim

        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetNhom", Me.Mode.Trim + "#" + _Loai_NhOld + "#" + _Loai_NhNew + "#" + _ma_NhOld + "#" + _Ma_nhNew + "#" + Me.Tb_Name.Trim.ToString + "#" + Me.TxtMa_Dvcs.Text.ToString + "#" + M_User_Name)
        Dt_CapNhom = DsTmp.Tables(0).Copy
        Dv_CapNhom = New DataView(Dt_CapNhom)

        ChkListBox.DataSource = Dv_CapNhom
        ChkListBox.DisplayMember = Dt_CapNhom.Columns("Ten_nh").ColumnName
        ChkListBox.ValueMember = Dt_CapNhom.Columns("Ma_Nh").ColumnName

        For iRow As Integer = 0 To Dv_CapNhom.Count - 1
            If Dv_CapNhom.Item(iRow).Item("Tag").ToString.ToUpper.Trim = "TRUE".ToString.ToUpper.Trim Or Dv_CapNhom.Item(iRow).Item("Tag").ToString.ToUpper.Trim = "1" Then
                ChkListBox.SetItemChecked(iRow, True)
            End If
        Next
    End Sub
#Region "Load"
    Private Sub V_LoadLoaiNhom()
        Dim DsTmp As New DataSet
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysListGetDmNhom", Me.Tb_Name.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtGroup = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CmbLoai_Nh, DtGroup, "Loai_nh", IIf(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Default")



    End Sub
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)

        If TxtTk_VT.Text.Trim = "" Then TxtTen_Tk_VT.Text = "" Else TxtTen_Tk_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_GV.Text.Trim = "" Then TxtTen_TK_GV.Text = "" Else TxtTen_TK_GV.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_GV.Text.Trim + "')", CyberSmlib)
        If TxtTk_DT.Text.Trim = "" Then TxtTen_TK_DT.Text = "" Else TxtTen_TK_DT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT.Text.Trim + "')", CyberSmlib)
        If TxtMa_phi.Text.Trim = "" Then TxtTen_phi.Text = "" Else TxtTen_phi.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_phi", "Dmphi", "(Ma_phi = N'" + TxtMa_phi.Text.Trim + "')", CyberSmlib)

        If TxtTk_DT_NB.Text.Trim = "" Then TxtTen_TK_DT_NB.Text = "" Else TxtTen_TK_DT_NB.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT_NB.Text.Trim + "')", CyberSmlib)
        If TxtTk_TL.Text.Trim = "" Then TxtTen_TK_TL.Text = "" Else TxtTen_TK_TL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_TL.Text.Trim + "')", CyberSmlib)
        If TxtTk_SPDD.Text.Trim = "" Then TxtTen_TK_SPDD.Text = "" Else TxtTen_TK_SPDD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_SPDD.Text.Trim + "')", CyberSmlib)
        If TxtTk_CL_VT.Text.Trim = "" Then TxtTen_TK_CL_VT.Text = "" Else TxtTen_TK_CL_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_CL_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck.Text.Trim = "" Then TxtTen_TK_CK.Text = "" Else TxtTen_TK_CK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck.Text.Trim + "')", CyberSmlib)

        If TxtTk_VT1.Text.Trim = "" Then TxtTen_Tk_VT1.Text = "" Else TxtTen_Tk_VT1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_VT1.Text.Trim + "')", CyberSmlib)
        If TxtTk_GV1.Text.Trim = "" Then TxtTen_TK_GV1.Text = "" Else TxtTen_TK_GV1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_GV1.Text.Trim + "')", CyberSmlib)
        If TxtTk_DT1.Text.Trim = "" Then TxtTen_TK_DT1.Text = "" Else TxtTen_TK_DT1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT1.Text.Trim + "')", CyberSmlib)
        If TxtTk_SPDD1.Text.Trim = "" Then TxtTen_TK_SPDD1.Text = "" Else TxtTen_TK_SPDD1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_SPDD1.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck1.Text.Trim = "" Then TxtTen_Tk_Ck1.Text = "" Else TxtTen_Tk_Ck1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck1.Text.Trim + "')", CyberSmlib)

        '--Ma_KHO
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho

        '--Tk_VT
        RemoveHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        RemoveHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT
        AddHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        AddHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT

        RemoveHandler TxtTk_VT1.CyberValiting, AddressOf V_Tk_VT1
        RemoveHandler TxtTk_VT1.CyberLeave, AddressOf L_Tk_VT1
        AddHandler TxtTk_VT1.CyberValiting, AddressOf V_Tk_VT1
        AddHandler TxtTk_VT1.CyberLeave, AddressOf L_Tk_VT1
        '--Tk_GV
        RemoveHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        RemoveHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        AddHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        AddHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        '--Tk_GV

        RemoveHandler TxtTk_GV1.CyberValiting, AddressOf V_Tk_GV1
        RemoveHandler TxtTk_GV1.CyberLeave, AddressOf L_Tk_GV1
        AddHandler TxtTk_GV1.CyberValiting, AddressOf V_Tk_GV1
        AddHandler TxtTk_GV1.CyberLeave, AddressOf L_Tk_GV1
        '--Tk_DT
        RemoveHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        RemoveHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT
        AddHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        AddHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT

        RemoveHandler TxtTk_DT1.CyberValiting, AddressOf V_Tk_DT1
        RemoveHandler TxtTk_DT1.CyberLeave, AddressOf L_Tk_DT1
        AddHandler TxtTk_DT1.CyberValiting, AddressOf V_Tk_DT1
        AddHandler TxtTk_DT1.CyberLeave, AddressOf L_Tk_DT1
        '--Tk_DT_NB
        RemoveHandler TxtTk_DT_NB.CyberValiting, AddressOf V_Tk_DT_NB
        RemoveHandler TxtTk_DT_NB.CyberLeave, AddressOf L_Tk_DT_NB
        AddHandler TxtTk_DT_NB.CyberValiting, AddressOf V_Tk_DT_NB
        AddHandler TxtTk_DT_NB.CyberLeave, AddressOf L_Tk_DT_NB
        '--Tk_TL
        RemoveHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        RemoveHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        AddHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        AddHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        '--Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD

        RemoveHandler TxtTk_SPDD1.CyberValiting, AddressOf V_Tk_SPDD1
        RemoveHandler TxtTk_SPDD1.CyberLeave, AddressOf L_Tk_SPDD1
        AddHandler TxtTk_SPDD1.CyberValiting, AddressOf V_Tk_SPDD1
        AddHandler TxtTk_SPDD1.CyberLeave, AddressOf L_Tk_SPDD1
        '--Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        '--Tk_CK
        RemoveHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        RemoveHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        AddHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        AddHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK

        '--Tk_CK
        RemoveHandler TxtTk_Ck1.CyberValiting, AddressOf V_Tk_CK1
        RemoveHandler TxtTk_Ck1.CyberLeave, AddressOf L_Tk_CK1
        AddHandler TxtTk_Ck1.CyberValiting, AddressOf V_Tk_CK1
        AddHandler TxtTk_Ck1.CyberLeave, AddressOf L_Tk_CK1
        '--Ma_phi
        RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_phi
        RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_phi
        '--Ma_TTLN
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTLN
        '--Ma_TTLN (KCH)
        RemoveHandler TxtMa_TTCP1.CyberValiting, AddressOf V_Ma_TTLN1
        RemoveHandler TxtMa_TTCP1.CyberLeave, AddressOf L_Ma_TTLN1
        AddHandler TxtMa_TTCP1.CyberValiting, AddressOf V_Ma_TTLN1
        AddHandler TxtMa_TTCP1.CyberLeave, AddressOf L_Ma_TTLN1
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler CmbLoai_Nh.SelectedIndexChanged, AddressOf V_Loai_Nh
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Nhom"
    Private Sub V_Loai_Nh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetTbCapNhom()
    End Sub
    Private Sub V_SaveSysNhom()
        If Me.Mode = "S" Then
            Dim sKey As String = "(Tb_name = N'" + Me.Tb_Name.Trim + "') AND (Loai_Nh = N'" + _Loai_NhOld.Trim + "') AND (Ma_Nh = N'" + _ma_NhOld.Trim + "')"
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysDeleteTabel", "SysNhom".Trim + "#" + sKey + "#" + M_User_Name)
        End If
        Dim DrV As DataRowView
        Dim _Ma_Nh As String = Txtma_nh.Text.Trim
        Dim _Loai_nh As String = CmbLoai_Nh.SelectedValue.ToString.Trim
        Dim strField As String = "", strValue As String = ""

        For Each _Chk As Object In ChkListBox.CheckedItems
            DrV = _Chk
            strField = ""
            strValue = ""
            CyberSmodb.GetValueData(DrV, strField, strValue)
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysSaveNhom", strField + "#" + strValue + "#" + _Loai_nh + "#" + _Ma_Nh + "#" + Me.Tb_Name.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Next
    End Sub
#End Region
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_KHO.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_KHO.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_KHO.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_phi"
    Private Sub V_Ma_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_phi.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_phi", "Dmphi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_phi")
            TxtTen_phi.Text = DrReturn.Item("Ten_phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_VT"
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_VT.Text = "" Then
            TxtTen_Tk_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_VT.Text = DrReturn.Item("TK")
            TxtTen_Tk_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_VT.Text = ""
            TxtTen_Tk_VT.Text = ""
        End If
    End Sub

    Private Sub V_Tk_VT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_VT1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_VT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_VT1.Text = "" Then
            TxtTen_Tk_VT1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_VT1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_VT1.Text = DrReturn.Item("TK")
            TxtTen_Tk_VT1.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_VT1.Text = ""
            TxtTen_Tk_VT1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_GV"
    Private Sub V_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_GV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_GV.Text = "" Then
            TxtTen_TK_GV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_GV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_GV.Text = DrReturn.Item("TK")
            TxtTen_TK_GV.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_GV.Text = ""
            TxtTen_TK_GV.Text = ""
        End If
    End Sub

    Private Sub V_Tk_GV1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_GV1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_GV1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_GV1.Text = "" Then
            TxtTen_TK_GV1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_GV1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_GV1.Text = DrReturn.Item("TK")
            TxtTen_TK_GV1.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_GV1.Text = ""
            TxtTen_TK_GV1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT"
    Private Sub V_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT.Text = "" Then
            TxtTen_TK_DT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT.Text = DrReturn.Item("TK")
            TxtTen_TK_DT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT.Text = ""
            TxtTen_TK_DT.Text = ""
        End If
    End Sub

    Private Sub V_Tk_DT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT1.Text = "" Then
            TxtTen_TK_DT1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT1.Text = DrReturn.Item("TK")
            TxtTen_TK_DT1.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT1.Text = ""
            TxtTen_TK_DT1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT_NB"
    Private Sub V_Tk_DT_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT_NB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT_NB.Text = "" Then
            TxtTen_TK_DT_NB.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT_NB.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT_NB.Text = DrReturn.Item("TK")
            TxtTen_TK_DT_NB.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT_NB.Text = ""
            TxtTen_TK_DT_NB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_TL"
    Private Sub V_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_TL.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_TL.Text = "" Then
            TxtTen_TK_TL.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_TL.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_TL.Text = DrReturn.Item("TK")
            TxtTen_TK_TL.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_TL.Text = ""
            TxtTen_TK_TL.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_SPDD"
    Private Sub V_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_SPDD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_SPDD.Text = "" Then
            TxtTen_TK_SPDD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_SPDD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_SPDD.Text = DrReturn.Item("TK")
            TxtTen_TK_SPDD.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_SPDD.Text = ""
            TxtTen_TK_SPDD.Text = ""
        End If
    End Sub

    Private Sub V_Tk_SPDD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_SPDD1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_SPDD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_SPDD1.Text = "" Then
            TxtTen_TK_SPDD1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_SPDD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_SPDD1.Text = DrReturn.Item("TK")
            TxtTen_TK_SPDD1.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_SPDD1.Text = ""
            TxtTen_TK_SPDD1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CL_VT"
    Private Sub V_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_CL_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_CL_VT.Text = "" Then
            TxtTen_TK_CL_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_CL_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_CL_VT.Text = DrReturn.Item("TK")
            TxtTen_TK_CL_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_CL_VT.Text = ""
            TxtTen_TK_CL_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CK"
    Private Sub V_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ck.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ck.Text = "" Then
            TxtTen_TK_CK.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ck.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ck.Text = DrReturn.Item("TK")
            TxtTen_TK_CK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ck.Text = ""
            TxtTen_TK_CK.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CK"
    Private Sub V_Tk_CK1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ck1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CK1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ck1.Text = "" Then
            TxtTen_Tk_Ck1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ck1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ck1.Text = DrReturn.Item("TK")
            TxtTen_TK_CK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ck1.Text = ""
            TxtTen_Tk_Ck1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region

#Region "Vali --- Ma_TTLN(KIH)"
    Private Sub V_Ma_TTLN1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTCP1.Text = "" Then
            txtTen_TTCP1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP1.Text = DrReturn.Item("Ma_TTCP")
            txtTen_TTCP1.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP1.Text = ""
            txtTen_TTCP1.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        Dim DsGenCode As New DataSet
        DsGenCode = V_GetCode(Mode, M_Ma_Dvcs, M_User_Name)
        If Not DsGenCode Is Nothing Then Txtma_nh.Text = DsGenCode.Tables(0).Rows(0).Item("Value").ToString.Trim
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        V_SaveSysNhom()
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class