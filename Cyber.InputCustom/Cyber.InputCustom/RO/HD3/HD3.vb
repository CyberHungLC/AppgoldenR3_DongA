Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class HD3
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
#End Region
#Region "Khai bao bien Paramater----------------------"
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"
    'Vật tư
    Dim EditMa_Lo, EditTk_Dt, EditTk_Vt, EditTk_Gv, EditMa_Kh_I As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Vt, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_Phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_Ku_I, EditMa_TTLN_i As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Db_I, EditMa_Xe_I, EditMa_Kx_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_Vt, EditTen_Tk_Dt, EditTen_Tk_Gv, EditTen_Tk_Vt, EditTen_Kho_i, EditDvt, EditSo_Luong, EditGia2, EditTien_Hang, EditThue, EditGia_Nt, EditGia, EditTien_Nt, EditTien As New Cyber.Fill.CyberColumnGridView
    Dim EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView
    Dim EditTien_Hang0, EditGia20, EditPT_CK_I, EditCK_I As New Cyber.Fill.CyberColumnGridView
    'Công việc
    Dim EditMa_CV, EditTen_CV, EditTien_HangCv, EditThueCv, EditThue_SuatCv, EditTk_Dt_Cv As New Cyber.Fill.CyberColumnGridView
    Dim EditTien_Hang0CV, EditPT_CK_ICV, EditCK_ICV As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TTLN_iCV, EditMa_TTCP_iCV, EditMa_BP_iCV As New Cyber.Fill.CyberColumnGridView
    Dim EditTien_C, EditThue_C, EditTien_BH, EditThue_BH, EditTien_CCV, EditThue_CCV, EditTien_BHCV, EditThue_BHCV As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditIs_Sua_Thue, EditIs_Sua_ThueCV As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim tbDmTk0 As New DataTable
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As New DataTable

    Dim Dt_DetailCv As New DataTable
    Dim Dt_DetailCvTmp As New DataTable
    Dim Dv_DetailCv As New DataView
    Dim Dv_DetailCvTmp As New DataView

    Dim M_Ma_TT, M_HT_TT, M_Ma_Thue As String
    Dim _Para_Ky_Hieu_HD As String = ""
    Dim _Para_So_RO As String = ""
#End Region
    Private Sub HD3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        'CyberSmodb.SetListFixLengthEnabled(Me, M_Ph, AppConn, Me.Mode, M_User_Name, CyberSmlib)
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        V_MainSystemCv()
        GetRound()
        CmdNew.Select()
        VisibleCK(sender, e)
        'V_LoadNew(sender, e)
    End Sub
#Region "Load And Set And Default"
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_So_RO.Trim = "" Then Exit Sub
        V_New(sender, e)
        If Not M_Mode = "M" Then Exit Sub
        TxtLenh_Ro.Text = _Para_So_RO
        L_Lenh_Ro(sender, e)
    End Sub
    Private Sub V_Load()
        V_Getdefault()

        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone

        Dt_Master = M_DsData.Tables(1)

        Dt_DetailCv = M_DsData.Tables(2)
        Dt_DetailCvTmp = Dt_DetailCv.Clone

        '====== hach toans
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        '====== Cong viec
        Dv_DetailCv = New DataView(Dt_DetailCv)
        Dv_DetailCvTmp = New DataView(Dt_DetailCvTmp)

        '====== Master
        Dv_Master = New DataView(Dt_Master)
        '====== hach toans
        Detail.DataSource = Dv_DetailTmp
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        '====== Cong viec
        DetailCv.DataSource = Dv_DetailCvTmp
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailCvTmp, Me.DrDmct)

        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)

        'M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)
        TxtT_tien_dat.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_tien_dat.InputMask)

        TxtT_Tien_Cong.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_Tien_Cong.InputMask)
        TxtT_Thue_Cong.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Thue_Cong.InputMask)
        TxtT_Tong_Cong.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tong_Cong.InputMask)

        TxtT_Tien_Hang.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_Hang.InputMask)
        TxtT_Thue_hang.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue_hang.InputMask)
        TxtT_Tong_Hang.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tong_Hang.InputMask)

        TxtT_Tien_Nt2.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien_Nt2.InputMask)
        TxtT_Thue_Nt.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Thue_Nt.InputMask)
        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT_NT.InputMask)

        DetailGRV.ViewCaption = "Danh sách vật tư phụ tùng"
        DetailGRVCv.ViewCaption = "Danh sách công việc sửa chữa"
    End Sub
    Private Sub V_Getdefault()
        M_strFilter = Me.strFilter
        M_DrDmct = Me.DrDmct
        M_Ph = M_DrDmct.Item("M_Ph").ToString.Trim
        M_Ct = M_DrDmct.Item("M_Ct").ToString.Trim

        osysvar = Me.SysVar
        M_Stt_Rec = Me.Stt_Rec
        M_LAN = Me.Lan
        M_Para = Me.Para
        AppConn = Me.AppConn
        M_DsData = Me.DsData
        M_DsHead = Me.DsHead
        M_DsLookUp = Me.DsLookup

        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        K_Tmp = M_Para(1).Trim
        K_System = M_Para(2).Trim
        K_Repo = M_Para(3).Trim
        K_Repo_Nt = M_Para(4).Trim
        M_CYBER_VER = M_Para(5).Trim
        M_User_Name = M_Para(6).Trim
        M_Comment = M_Para(7).Trim
        M_is_Admin = CType(M_Para(8), Boolean)
        M_User_ID = M_Para(9).Trim
        M_Menu_ID0 = M_Para(10).Trim
        M_Bar = M_Para(11).Trim
        M_Bar2 = M_Para(12).Trim
        M_LAN = M_Para(13).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_GD = M_Para(M_VT_PARA + 1).Trim
        M_Ma_CT = M_Para(M_VT_PARA + 2).Trim
        M_Ma_TT = M_Para(M_VT_PARA + 3).Trim
        M_Ma_Thue = M_Para(M_VT_PARA + 4).Trim
        M_HT_TT = M_Para(M_VT_PARA + 5).Trim
        _Para_So_RO = ""
        Try
            _Para_So_RO = M_Para(M_VT_PARA + 6).Trim
        Catch ex As Exception

        End Try
        _Para_Ky_Hieu_HD = M_Para(M_VT_PARA + 7).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '---------------------------------------------------------------------------------------------'

        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Tk_No = DrDmct.Item("M_Tk_No").ToString.Trim
        M_Tk_Co = DrDmct.Item("M_Tk_Co").ToString.Trim
        M_Tk_Thue = DrDmct.Item("M_Tk_Thue").ToString.Trim
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        If M_Tk_No.Trim <> "" Then M_Ten_Tk_No = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_No.Trim + "'", CyberSmlib) Else M_Ten_Tk_No = ""
        If M_Tk_Co.Trim <> "" Then M_Ten_Tk_Co = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Co.Trim + "'", CyberSmlib) Else M_Ten_Tk_Co = ""
        If M_Tk_Thue.Trim <> "" Then M_Ten_Tk_Thue = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Thue.Trim + "'", CyberSmlib) Else M_Ten_Tk_Thue = ""

        Dim Dstmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLoaiTT", M_Ma_CT.Trim + "#" + M_User_Name)
        Dim tbDmTT = Dstmp.Tables(0).Copy

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        'Dim tbDmThue = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmThue", "Ma_thue", "Ma_Thue IN ('00','05','08','10','20') ", CyberSmlib)
        Dim tbDmThue = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmThue", "Ma_thue", "Ma_Thue IN ('00','08','10','50') ", CyberSmlib)
        tbDmTk0 = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmTk0", "Tk0", "1=1", CyberSmlib)

        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
        CyberFill.V_FillComBoxValue(Me.CbBMa_TT, tbDmTT, "Ma_TT", "Ten_TT", M_Ma_TT)
        CyberFill.V_FillComBoxValue(Me.CbBMa_TT, tbDmTT, "Ma_TT", "Ten_TT", M_Ma_TT)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Thue, tbDmThue, "Ma_Thue", "Ma_Thue", M_Ma_Thue)
        txtKy_Hieu_HD.Text = _Para_Ky_Hieu_HD

        '---------------------------------------------------------------------------------------------'
        V_LoadDefault()
        V_SetSo_BG()
    End Sub
    Private Sub V_SetProperty()

        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")
        If FixCol < DetailGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        'Vật tư
        EditMa_Vt.GetColumn(DetailGRV, "Ma_VT")
        EditTen_Vt.GetColumn(DetailGRV, "Ten_VT")
        EditDvt.GetColumn(DetailGRV, "DVT")
        EditMa_Lo.GetColumn(DetailGRV, "Ma_Lo")
        EditMa_Vitri.GetColumn(DetailGRV, "Ma_Vitri")

        EditMa_Kho_I.GetColumn(DetailGRV, "Ma_Kho_I")
        EditTen_Kho_i.GetColumn(DetailGRV, "Ten_Kho_I")

        EditTk_Dt.GetColumn(DetailGRV, "Tk_Dt")
        EditTen_Tk_Vt.GetColumn(DetailGRV, "Ten_Tk_Dt")

        EditTk_Vt.GetColumn(DetailGRV, "Tk_Vt")
        EditTen_Tk_Vt.GetColumn(DetailGRV, "Ten_Tk_Vt")

        EditTk_Gv.GetColumn(DetailGRV, "Tk_Gv")
        EditTen_Tk_Gv.GetColumn(DetailGRV, "Ten_Tk_Gv")

        EditDien_Giaii.GetColumn(DetailGRV, "Dien_Giaii")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditGia2.GetColumn(DetailGRV, "Gia2")
        EditTien_Hang.GetColumn(DetailGRV, "Tien_Hang")
        EditThue.GetColumn(DetailGRV, "Thue")


        EditTien_C.GetColumn(DetailGRV, "Tien_C")
        EditThue_C.GetColumn(DetailGRV, "Thue_C")
        EditTien_BH.GetColumn(DetailGRV, "Tien_BH")
        EditThue_BH.GetColumn(DetailGRV, "Thue_BH")
        EditIs_Sua_Thue.GetColumn(DetailGRV, "Is_Sua_Thue")

        EditGia_Nt.GetColumn(DetailGRV, "Gia_Nt")
        EditGia.GetColumn(DetailGRV, "Gia")
        EditTien_Nt.GetColumn(DetailGRV, "Tien_Nt")
        EditTien.GetColumn(DetailGRV, "Tien")
        EditTien_Hang0.GetColumn(DetailGRV, "Tien_Hang0")
        EditGia20.GetColumn(DetailGRV, "Gia20")
        EditPT_CK_I.GetColumn(DetailGRV, "PT_CK_I")
        EditCK_I.GetColumn(DetailGRV, "CK_I")

        EditMa_Vv_I.GetColumn(DetailGRV, "Ma_Vv_I")
        EditMa_Phi_i.GetColumn(DetailGRV, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRV, "Ma_HD_I")
        EditMa_Sp_I.GetColumn(DetailGRV, "Ma_SP_I")
        EditMa_Ku_I.GetColumn(DetailGRV, "Ma_Ku_I")
        EditMa_TTLN_i.GetColumn(DetailGRV, "Ma_TTLN_I")
        EditMa_TTCP_i.GetColumn(DetailGRV, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRV, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRV, "Ma_Hs_I")
        EditMa_CD_I.GetColumn(DetailGRV, "Ma_CD_I")

        EditMa_TD1_I.GetColumn(DetailGRV, "Ma_TD1_I")
        EditMa_TD2_I.GetColumn(DetailGRV, "Ma_TD2_I")
        EditMa_TD3_I.GetColumn(DetailGRV, "Ma_TD3_I")
        EditMa_TD4_I.GetColumn(DetailGRV, "Ma_TD4_I")
        EditMa_TD5_I.GetColumn(DetailGRV, "Ma_TD5_I")

        EditSo_So.GetColumn(DetailGRV, "SO_SO")
        EditSo_Po.GetColumn(DetailGRV, "SO_PO")
        EditSo_Ro.GetColumn(DetailGRV, "SO_RO")
        EditSo_VT.GetColumn(DetailGRV, "SO_VT")

        EditMa_Db_I.GetColumn(DetailGRV, "Ma_Db_I")
        EditMa_Xe_I.GetColumn(DetailGRV, "Ma_XE_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_TUYEN_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")

        'Công việc      
        EditMa_CV.GetColumn(DetailGRVCv, "Ma_CV")
        EditTen_CV.GetColumn(DetailGRVCv, "Ten_CV")
        EditThue_SuatCv.GetColumn(DetailGRVCv, "Thue_Suat")
        EditTien_HangCv.GetColumn(DetailGRVCv, "Tien_Hang")
        EditThueCv.GetColumn(DetailGRVCv, "Thue")
        EditTk_Dt_Cv.GetColumn(DetailGRVCv, "Tk_Dt")
        EditMa_TTLN_iCV.GetColumn(DetailGRVCv, "Ma_TTLN_i")
        EditMa_TTCP_iCV.GetColumn(DetailGRVCv, "Ma_TTCP_i")
        EditMa_BP_iCV.GetColumn(DetailGRVCv, "Ma_BP_i")

        EditTien_Hang0CV.GetColumn(DetailGRVCv, "Tien_Hang0")
        EditPT_CK_ICV.GetColumn(DetailGRVCv, "PT_CK_I")
        EditCK_ICV.GetColumn(DetailGRVCv, "CK_I")

        EditTien_CCV.GetColumn(DetailGRVCv, "Tien_C")
        EditThue_CCV.GetColumn(DetailGRVCv, "Thue_C")
        EditTien_BHCV.GetColumn(DetailGRVCv, "Tien_BH")
        EditThue_BHCV.GetColumn(DetailGRVCv, "Thue_BH")
        EditIs_Sua_ThueCV.GetColumn(DetailGRVCv, "Is_Sua_Thue")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtOng_Ba.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.ToUpper.Trim = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            M_R_GIA_NT = M_R_GIA
            M_R_TIEN_NT = M_R_TIEN
        End If
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
        AddHandler Me.KeyDown, AddressOf FrmMain_KeyDown
        '---
        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdNew.Click, AddressOf V_New
        AddHandler CmdEdit.Click, AddressOf V_Edit
        AddHandler CmdDelete.Click, AddressOf V_Delete
        AddHandler CmdCancel.Click, AddressOf V_Cancel
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdView.Click, AddressOf V_View
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler CmdExit.Click, AddressOf V_Exit

        AddHandler CmdImport.Click, AddressOf V_Import
        AddHandler CmdCopy.Click, AddressOf V_Copy
        '---
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown

        AddHandler DetailGRVCv.PopupMenuShowing, AddressOf MasterGRVCv_PopupMenuShowing
        AddHandler DetailGRVCv.KeyDown, AddressOf MasterGRVCv_KeyDown
        '---
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
        AddHandler CbBMa_TT.SelectedValueChanged, AddressOf L_Ma_TT
        'HT_TT
        AddHandler txtHT_TT.CyberValiting, AddressOf V_HT_TT
        AddHandler txtHT_TT.CyberLeave, AddressOf L_HT_TT
        'HT_TT
        AddHandler txtKy_Hieu_HD.CyberValiting, AddressOf V_Ky_Hieu_HD
        AddHandler txtKy_Hieu_HD.CyberLeave, AddressOf L_Ky_Hieu_HD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia
        'Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'Ma_BP_H
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H
        'Ma_HS_H
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_HS_H

        AddHandler ChkSua_Thue.CheckedChanged, AddressOf V_Sua_Thue
        AddHandler TxtT_Thue_Cong.Leave, AddressOf V_E_Thue
        AddHandler TxtT_Thue_hang.Leave, AddressOf V_E_Thue
        'Ma_Nx
        AddHandler TxtMa_Nx.CyberValiting, AddressOf V_Ma_Nx
        AddHandler TxtMa_Nx.CyberLeave, AddressOf L_Ma_Nx
        'Mau_HD
        AddHandler TxtMau_HD.CyberValiting, AddressOf V_Mau_hd
        AddHandler TxtMau_HD.CyberLeave, AddressOf L_Mau_hd
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po

        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT
        AddHandler TxtLenh_Ro.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtSo_BG.Leave, AddressOf L_So_BG
        AddHandler ChkIs_BG.CheckedChanged, AddressOf V_SetSo_BG

        AddHandler CmdLoc_Ro.Click, AddressOf V_Loc_RO
        AddHandler TxtTien_HD.Leave, AddressOf L_Tien_Hd

        AddHandler cmdXe_Tiep_Don.Click, AddressOf V_ChonBaoGia
        AddHandler ChkXoa_Detail.CheckedChanged, AddressOf V_Xoa_Detail

        AddHandler CmdChonHDS.Click, AddressOf V_ChonHDS
        'Ma_Xe
        AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_Xe
        AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_Xe
        AddHandler ChkHD_Xuat_VAT.CheckedChanged, AddressOf VisibleCK
        '-----------------BKAV
        'Tạo hóa đơn nháp
        AddHandler CmdTao_HD_Nhap.Click, AddressOf V_Tao_HD_Nhap
        'Update thông tin
        AddHandler CmdUPDATE_HD.Click, AddressOf V_Update_HD
        'Lấy thông tin hóa đơn
        AddHandler CmdLay_TTHD.Click, AddressOf V_Lay_HD
        'Phát hành hóa đơn
        AddHandler CmdPH_HoaDon.Click, AddressOf V_PH_HDDT
        'Xem trước hóa đơn
        AddHandler CmdXem_HoaDon.Click, AddressOf V_View_HDDT

    End Sub
    Private Sub V_AddHandler_Detail()
        'Vật tư
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Hang.Column Is Nothing Then AddHandler EditTien_Hang.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue.Column Is Nothing Then AddHandler EditThue.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditGia_Nt.Column Is Nothing Then AddHandler EditGia_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt.Column Is Nothing Then AddHandler EditTien_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        If Not EditTien_Hang0.Column Is Nothing Then AddHandler EditTien_Hang0.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia20.Column Is Nothing Then AddHandler EditGia20.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditPT_CK_I.Column Is Nothing Then AddHandler EditPT_CK_I.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCK_I.Column Is Nothing Then AddHandler EditCK_I.EditColumn.Leave, AddressOf L_Tinh_Toan


        If Not EditIs_Sua_Thue.Column Is Nothing Then AddHandler EditIs_Sua_Thue.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Hang.Column Is Nothing Then AddHandler EditTien_Hang.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue.Column Is Nothing Then AddHandler EditThue.EditColumn.Leave, AddressOf L_Tinh_Toan
        'If Not EditIs_Sua_Thue.Column Is Nothing Then AddHandler EditIs_Sua_Thue.EditColumn.Leave, AddressOf DetailGRV_ShowingEditor
        If Not EditTien_C.Column Is Nothing Then AddHandler EditTien_C.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue_C.Column Is Nothing Then AddHandler EditThue_C.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_BH.Column Is Nothing Then AddHandler EditTien_BH.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue_BH.Column Is Nothing Then AddHandler EditThue_BH.EditColumn.Leave, AddressOf L_Tinh_Toan



        EditMa_Vt.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        EditTk_Dt.V_ActiLookUpColumn(AddressOf V_Tk_Dt, AddressOf L_Tk_Dt)
        EditTk_Vt.V_ActiLookUpColumn(AddressOf V_Tk_Vt, AddressOf L_Tk_Vt)
        EditTk_Gv.V_ActiLookUpColumn(AddressOf V_Tk_Gv, AddressOf L_Tk_Gv)
        EditMa_Lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)

        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_i, AddressOf L_Ma_Kho_i)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_Phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_Sp_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_Ku_I.V_ActiLookUpColumn(AddressOf V_Ma_Ku_i, AddressOf L_Ma_Ku_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)
        EditMa_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_i, AddressOf L_Ma_Db_i)
        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_i, AddressOf L_Ma_Xe_i)
        EditMa_Kx_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
        EditMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_Ma_Tuyen_i, AddressOf L_Ma_Tuyen_i)
        EditMa_Ts.V_ActiLookUpColumn(AddressOf V_Ma_Ts, AddressOf L_Ma_Ts)
        EditMa_Cc.V_ActiLookUpColumn(AddressOf V_Ma_Cc, AddressOf L_Ma_Cc)
        If Not EditSo_So.Column Is Nothing Then AddHandler EditSo_So.EditColumn.Leave, AddressOf L_So_So
        If Not EditSo_Po.Column Is Nothing Then AddHandler EditSo_Po.EditColumn.Leave, AddressOf L_So_Po
        If Not EditSo_Ro.Column Is Nothing Then AddHandler EditSo_Ro.EditColumn.Leave, AddressOf L_So_Ro
        If Not EditSo_VT.Column Is Nothing Then AddHandler EditSo_VT.EditColumn.Leave, AddressOf L_So_VT
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        'Công việc
        EditMa_CV.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        EditTk_Dt_Cv.V_ActiLookUpColumn(AddressOf V_Tk_Dt_Cv, AddressOf L_Tk_Dt_Cv)
        EditMa_TTLN_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_I_Cv, AddressOf L_Ma_TTLN_I_Cv)
        EditMa_BP_iCV.V_ActiLookUpColumn(AddressOf V_Ma_BP_I_Cv, AddressOf L_Ma_BP_I_Cv)

        If Not EditThueCv.Column Is Nothing Then AddHandler EditThueCv.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditThue_SuatCv.Column Is Nothing Then AddHandler EditThue_SuatCv.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditTien_HangCv.Column Is Nothing Then AddHandler EditTien_HangCv.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditTien_Hang0CV.Column Is Nothing Then AddHandler EditTien_Hang0CV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditPT_CK_ICV.Column Is Nothing Then AddHandler EditPT_CK_ICV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditCK_ICV.Column Is Nothing Then AddHandler EditCK_ICV.EditColumn.Leave, AddressOf L_Tinh_ToanCV

        If Not EditTien_CCV.Column Is Nothing Then AddHandler EditTien_CCV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditThue_CCV.Column Is Nothing Then AddHandler EditThue_CCV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditTien_BHCV.Column Is Nothing Then AddHandler EditTien_BHCV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        If Not EditThue_BHCV.Column Is Nothing Then AddHandler EditThue_BHCV.EditColumn.Leave, AddressOf L_Tinh_ToanCV
        'EditMa_THue_I.V_ActiLookUpColumn(AddressOf V_Ma_Thue_i, AddressOf L_Ma_Thue_i)
        AddHandler DetailGRVCv.RowCellStyle, AddressOf DetailGRVCV_RowCellStyle
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVCV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVCv, Dt_DetailCvTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_NT()
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            EditTien.Visible = False
            EditGia.Visible = False
        Else
            EditTien.Visible = True
            EditGia.Visible = True
        End If
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
    End Sub
    Private Sub VisibleColumnMa_GD()
        Enableloc_Ro()
    End Sub

    Private Sub DetailGRV_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DetailGRV.ShowingEditor
        Dim view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        If view.FocusedColumn.FieldName.ToUpper = "THUE" Then
            If view.GetFocusedRowCellValue("Is_Sua_Thue") <> 1 Then

                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DetailGRVCV_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DetailGRVCv.ShowingEditor
        Dim view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        If view.FocusedColumn.FieldName.ToUpper = "THUE" Then
            If view.GetFocusedRowCellValue("Is_Sua_Thue") <> 1 Then
                e.Cancel = True
            End If
        End If
    End Sub
    Protected Overrides Sub V_Databing()
        Dim i As Integer
        Dim Drv As DataRowView
        Drv = Nothing

        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next

        CyberSmodb.SetValueTObj(Me, Drv)
        If Drv Is Nothing Then
            TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CbbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If

        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next

        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()
        For i = 0 To Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailCvTmp.ImportRow(Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next

        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        M_Count = Dt_Master.Rows.Count
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        If Not ChkHD_Xuat_VAT.Checked And 1 = 0 Then TxtMa_xe.ReadOnly = True
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
        SetTxt()
        Enableloc_Ro()
    End Sub
    Private Sub V_GetDateVoucher(ByVal _Mode As String, ByRef _Ngay_Ct As Date, ByRef _Ngay_LCT As Date)
        Dim _DtReturn As DataTable = CyberSupport.V_GetDateVoucher(_Mode, _Ngay_Ct, _Ngay_LCT, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        If _DtReturn Is Nothing Then Exit Sub Else If _DtReturn.Rows.Count <= 0 Then Exit Sub
        If Not _DtReturn.Columns.Contains("Status") Then Exit Sub
        If _DtReturn.Rows(0).Item("Status").ToString.Trim = "N" Then Exit Sub
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_LCt.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_Ct.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_Ct.Value
        _Ngay_LCT = TxtNgay_Ct.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And TxtSo_Ct.Text.Trim <> "" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Master"
    Private Sub V_E_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        UpdateList()
    End Sub
    Private Sub V_Sua_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_Thue.Checked Then
            TxtT_Thue_Cong.BackColor = Drawing.Color.White
            TxtT_Thue_hang.BackColor = Drawing.Color.White
            TxtT_Thue_Nt.BackColor = Drawing.Color.White

            TxtT_ThueVT_C.BackColor = Drawing.Color.White
            TxtT_ThueCV_C.BackColor = Drawing.Color.White
            TxtT_ThueVT_I.BackColor = Drawing.Color.White
            TxtT_ThueCV_I.BackColor = Drawing.Color.White

            'TxtT_Thue_Nt.ReadOnly = True
            TxtT_Thue_hang.ReadOnly = True
            TxtT_Thue_Cong.ReadOnly = True
            TxtT_ThueVT_I.ReadOnly = True
            TxtT_ThueCV_C.ReadOnly = True
            TxtT_ThueVT_C.ReadOnly = True
            TxtT_ThueCV_I.ReadOnly = True

        Else
            TxtT_Thue_Cong.BackColor = Drawing.Color.Pink
            TxtT_Thue_hang.BackColor = Drawing.Color.Pink
            TxtT_Thue_Nt.BackColor = Drawing.Color.Pink
            TxtT_ThueVT_C.BackColor = Drawing.Color.Pink
            TxtT_ThueCV_C.BackColor = Drawing.Color.Pink
            TxtT_ThueVT_I.BackColor = Drawing.Color.Pink
            TxtT_ThueCV_I.BackColor = Drawing.Color.Pink

            TxtT_Thue_hang.ReadOnly = False
            TxtT_Thue_Cong.ReadOnly = False
            'TxtT_Thue_Nt.ReadOnly = False
            TxtT_ThueVT_I.ReadOnly = False
            TxtT_ThueCV_C.ReadOnly = False
            TxtT_ThueVT_C.ReadOnly = False
            TxtT_ThueCV_I.ReadOnly = False
            TxtT_Thue_hang.Focus()
        End If
        UpdateList()
    End Sub
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "Ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("Ma_Quyen")
    End Sub
#End Region
#Region "Valid --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text = "" Then
            TxtTen_KhVat.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn("Ma_Kh").ToString.Trim
            TxtTen_Kh.Text = DrReturn("Ten_kh").ToString.Trim
            TxtDia_Chi.Text = DrReturn("Dia_Chi").ToString.Trim

            TxtTen_KhVat.Text = DrReturn("Ten_KhVat").ToString.Trim
            TxtDia_ChiVat.Text = DrReturn("Dia_ChiVat").ToString.Trim
            txtSo_CCCD.Text = DrReturn("CCCDan").ToString.Trim
            'TxtTen_KhVat.Text = IIf(TxtTen_KhVat.Text.Trim = "", DrReturn("Ten_KhVat").ToString.Trim, TxtTen_KhVat.Text)
            'TxtDia_ChiVat.Text = IIf(TxtDia_ChiVat.Text.Trim = "", DrReturn("Dia_ChiVat").ToString.Trim, TxtDia_ChiVat.Text)
            TxtMa_So_Thue.Text = DrReturn("Ma_So_Thue").ToString.Trim
            'TxtOng_Ba.Text = IIf(TxtOng_Ba.Text.Trim = "", DrReturn("Ong_ba").ToString.Trim, TxtOng_Ba.Text)
            TxtHan_TT.Text = IIf(TxtHan_TT.Text.Trim = "0" Or TxtHan_TT.Text.Trim = "", DrReturn("Han_tt").ToString.Trim, TxtHan_TT.Text)
            'TxtTen_KhVat.Text = IIf(TxtTen_KhVat.Text.Trim = "", DrReturn("Ten_kh").ToString.Trim, TxtTen_KhVat.Text.Trim)
            'TxtDia_ChiVat.Text = IIf(TxtDia_ChiVat.Text.Trim = "", DrReturn("Dia_Chi").ToString.Trim, TxtDia_ChiVat.Text.Trim)
            'TxtMa_So_Thue.Text = IIf(TxtMa_So_Thue.Text.Trim = "", DrReturn("Ma_So_Thue").ToString.Trim, TxtMa_So_Thue.Text.Trim)

            If TxtEmailHDDT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("E_Mail") Then TxtEmailHDDT.Text = DrReturn.Item("E_Mail").ToString.Trim

        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
            TxtDia_Chi.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_BP_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_BP_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP_H.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HS_H"
    Private Sub V_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Nx"
    Private Sub V_Ma_Nx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "tk", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Nx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Nx.Text = "" Then
            TxtTen_Nx.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Nx.Text = DrReturn("Tk").ToString.Trim
            TxtTen_Nx.Text = DrReturn("Ten_tk").ToString.Trim
        Else
            TxtMa_Nx.Text = ""
            TxtTen_Nx.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- MaU_HD"
    Private Sub V_Mau_hd(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Mau_HD", "DmMauHd", "1=1", "1=1")
    End Sub
    Private Sub L_Mau_hd(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMau_HD.Text = "" Then
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMau_HD.Text = DrReturn("Mau_HD").ToString.Trim

        Else
            TxtMau_HD.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Xe", "DmXE", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Xe.Text = "" Then

            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xe.Text = DrReturn("Ma_Xe").ToString.Trim

        Else
            TxtMa_Xe.Text = ""

        End If

    End Sub
#End Region
#Region "Chon bao gia"
    Private Sub V_ChonBaoGia(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not (M_Mode = "M") Then Exit Sub

        'Dim _Dt As Date = TxtNgay_Ct.Value
        'Dim _Filter As String = "1"
        '_Filter = _Filter & "#"
        '_Filter = _Filter & "#" & M_Stt_Rec
        '_Filter = _Filter & "#" & M_Stt_Rec
        '_Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        '_Filter = _Filter & "#" & M_Ma_Dvcs
        '_Filter = _Filter & "#" & M_User_Name

        'Dim dr() As DataRow = CyberSupport.V_GetDatarowSelectList(AppConn, osysvar, M_Para, "CP_HD3ChonBaoGia", _Filter, M_LAN)
        'If dr Is Nothing Then
        '    Return
        'End If

        'If dr.Length <> 1 Then Return

        'Dim _dr As DataRow = dr(0)
        'TxtSo_BG.Text = _dr("So_BG")

        'V_So_BG()
        Dim _Bg As String = "1"

        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim frm As New FrmLocRo_HD3
        frm._Is_BG = _Bg
        frm._Ds_LoolUp = DsLookup
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Sysvar = osysvar
        frm.AppConn = AppConn
        frm.CyberSmlib = CyberSmlib
        frm.CyberSupport = CyberSupport
        frm.CyberFill = CyberFill
        frm.CyberSmlistSys = CyberSmlistSys
        frm.CyberSmodb = CyberSmodb
        frm.CyberExport = Nothing
        frm.CyberVoucher = CyberVoucher
        frm.CyberLoading = CyberLoading
        frm.ShowInTaskbar = False
        frm.Stt_rec = M_Stt_Rec
        frm.Ma_Ct = M_Ma_CT
        frm.Mode = M_Mode
        frm.Ma_Thue = CbbMa_Thue.SelectedValue.ToString.Trim
        frm.Ma_TT = CbBMa_TT.SelectedValue.ToString.Trim
        frm.Is_ALL_Thue = ChkIs_All_Thue.Checked
        frm.ShowDialog()
        If Not frm.Save_OK Then Exit Sub
        V_UpdateMaster(frm.Master_Return, frm.CV_Return, frm.Vt_Return)
        ChkIs_All_Thue.Checked = frm.Is_ALL_Thue
    End Sub
    Private Sub V_ChonHDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim frm As New FrmLocHDS
        frm._Ds_LoolUp = DsLookup
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Sysvar = osysvar
        frm.AppConn = AppConn
        frm.CyberSmlib = CyberSmlib
        frm.CyberSupport = CyberSupport
        frm.CyberFill = CyberFill
        frm.CyberSmlistSys = CyberSmlistSys
        frm.CyberSmodb = CyberSmodb
        frm.CyberExport = Nothing
        frm.CyberVoucher = CyberVoucher
        frm.CyberLoading = CyberLoading
        frm.ShowInTaskbar = False
        frm.Stt_rec = M_Stt_Rec
        frm.So_Ro = TxtLenh_Ro.Text.Trim
        frm.Ma_Ct = M_Ma_CT
        frm.Mode = M_Mode
        frm.Ma_Thue = CbbMa_Thue.SelectedValue.ToString.Trim
        frm.Ma_TT = CbBMa_TT.SelectedValue.ToString.Trim

        frm.ShowDialog()
        TxtSo_Ct_HDS.Text = frm.So_Ct_HDS
        TxtStt_Rec_HDS.Text = frm.Stt_Rec_HDS
        If Not frm.Save_OK Then Exit Sub

        If Not frm.Master_Return Is Nothing Then
            If frm.Master_Return.Rows.Count > 0 Then
                If frm.Master_Return.Columns.Contains("Lenh_RO") Then TxtLenh_Ro.Text = frm.Master_Return.Rows(0).Item("Lenh_RO")
                'V_Lenh_RO()


            End If
        End If

    End Sub
#End Region
#Region "Lenh/SO/Po/Ro/Vt/So_Lenh"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_FormatSo_PO(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_SO.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_FormatSo_PO(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_PO.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        If TxtLenh_Ro.Text = "" Then Exit Sub
        TxtLenh_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_CT, TxtLenh_Ro.Text, CbbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)
        If TxtSo_BG.Text <> "" Then Exit Sub
        V_Lenh_RO()
    End Sub
    Private Sub L_So_BG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        If TxtSo_BG.Text = "" Then Exit Sub
        V_So_BG()
    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_Vt.Text = CyberVoucher.V_FormatSo_VT(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_Vt.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid --- Ky Hiệu Hóa đơn"
    Private Sub V_Ky_Hieu_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        txtKy_Hieu_HD.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ky_Hieu_HD", "DmKyhieuHoaDon", "1=1", "1=1")
    End Sub
    Private Sub L_Ky_Hieu_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtKy_Hieu_HD.Text = "" Then
            txtKy_Hieu_HD.Text = ""
            Exit Sub
        End If
        DrReturn = txtKy_Hieu_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtKy_Hieu_HD.Text = DrReturn.Item("Ky_Hieu_HD")

        Else
            txtKy_Hieu_HD.Text = ""

        End If
    End Sub
#End Region
#Region "Valid --- HT_TT"
    Private Sub V_HT_TT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        txtHT_TT.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "HT_TT", "DMHTTT", "1=1", "1=1")
    End Sub
    Private Sub L_HT_TT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtHT_TT.Text = "" Then
            TxtTen_HT_TT.Text = ""
            Exit Sub
        End If
        DrReturn = txtHT_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtHT_TT.Text = DrReturn.Item("HT_TT")
            TxtTen_HT_TT.Text = DrReturn.Item("Ten_HT_TT")
        Else
            txtHT_TT.Text = ""
            TxtTen_HT_TT.Text = ""
        End If
    End Sub
#End Region
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If CbbMa_GD.SelectedValue.ToString.Trim <> "1" Then Exit Sub
        L_Lenh_Ro(sender, e)
    End Sub
    Private Sub V_Lenh_RO()
        If (TxtLenh_Ro.Text = "") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        Dim nCount As Integer
        Dim strFiled = "", strValues As String = ""
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")
        Dim DsLenh_RO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetdetailHD3Default", "0#1#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & M_Mode & "#0#" & strFiled & "#" & strValues & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        nCount = DsLenh_RO.Tables.Count

        For i = 0 To nCount - 1
            CyberSmodb.SetNotNullTable(DsLenh_RO.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsLenh_RO.Tables(0), Me.SysVar, Me.Lan) Then
            TxtLenh_Ro.Text = ""
            TxtLenh_Ro.Focus()
            DsLenh_RO.Dispose()
            Dt_DetailTmp.Rows.Clear()
            Dt_DetailCvTmp.Rows.Clear()
            ChkSua_Thue.Checked = False
            UpdateList()
            Exit Sub
        End If
        ChkSua_Thue.Checked = False
        V_UpdateMaster(DsLenh_RO.Tables(0), DsLenh_RO.Tables(2), DsLenh_RO.Tables(3))
        DsLenh_RO.Dispose()
    End Sub
    Private Sub V_So_BG()
        If (TxtSo_BG.Text = "") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        Dim nCount As Integer
        Dim strFiled = "", strValues As String = ""
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")
        Dim DsBG As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetdetailHD3Default", "0#1#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & M_Mode & "#1#" & strFiled & "#" & strValues & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        nCount = DsBG.Tables.Count

        For i = 0 To nCount - 1
            CyberSmodb.SetNotNullTable(DsBG.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsBG.Tables(0), Me.SysVar, Me.Lan) Then
            TxtSo_BG.Focus()
            DsBG.Dispose()
            Dt_DetailTmp.Rows.Clear()
            Dt_DetailCvTmp.Rows.Clear()
            ChkSua_Thue.Checked = False
            UpdateList()
            Exit Sub
        End If
        ChkSua_Thue.Checked = False
        V_UpdateMaster(DsBG.Tables(0), DsBG.Tables(2), DsBG.Tables(3))
        DsBG.Dispose()
    End Sub
    Private Sub V_UpdateMaster(ByVal _Dt_Master As DataTable, ByVal _Dt_DetailCV As DataTable, ByVal _Dt_DetailVT As DataTable)
        If Not _Dt_Master Is Nothing Then
            If _Dt_Master.Rows.Count > 0 Then
                If _Dt_Master.Columns.Contains("Ma_Kh") Then TxtMa_Kh.Text = _Dt_Master.Rows(0).Item("Ma_Kh")
                If _Dt_Master.Columns.Contains("Ten_kh") Then TxtTen_Kh.Text = _Dt_Master.Rows(0).Item("Ten_kh")
                If _Dt_Master.Columns.Contains("Dia_Chi") Then TxtDia_Chi.Text = _Dt_Master.Rows(0).Item("Dia_Chi")

                If _Dt_Master.Columns.Contains("Ten_khVAT") Then TxtTen_KhVat.Text = _Dt_Master.Rows(0).Item("Ten_khVAT")
                If _Dt_Master.Columns.Contains("Dia_ChiVAT") Then TxtDia_ChiVat.Text = _Dt_Master.Rows(0).Item("Dia_ChiVAT")

                If _Dt_Master.Columns.Contains("Ma_So_Thue") Then TxtMa_So_Thue.Text = _Dt_Master.Rows(0).Item("Ma_So_Thue")
                If _Dt_Master.Columns.Contains("Dien_Giai") Then TxtDien_Giai.Text = _Dt_Master.Rows(0).Item("Dien_Giai")
                If _Dt_Master.Columns.Contains("Ma_Thue") Then CbbMa_Thue.SelectedValue = _Dt_Master.Rows(0).Item("Ma_Thue")

                If _Dt_Master.Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = _Dt_Master.Rows(0).Item("Ma_Xe")
                'If _Dt_Master.Columns.Contains("Ong_Ba") Then TxtOng_Ba.Text = _Dt_Master.Rows(0).Item("Ong_Ba").ToString.Trim
                If _Dt_Master.Columns.Contains("Ten_vtthue") Then TxtTen_vtthue.Text = _Dt_Master.Rows(0).Item("Ten_vtthue").ToString.Trim

                If _Dt_Master.Columns.Contains("Ma_Hs_H") Then TxtMa_Hs_H.Text = _Dt_Master.Rows(0).Item("Ma_Hs_H").ToString.Trim
                If _Dt_Master.Columns.Contains("Ten_Hs_H") Then TxtTen_Hs_H.Text = _Dt_Master.Rows(0).Item("Ten_Hs_H").ToString.Trim

                If _Dt_Master.Columns.Contains("Ma_BP_H") Then TxtMa_BP_H.Text = _Dt_Master.Rows(0).Item("Ma_BP_H").ToString.Trim
                If _Dt_Master.Columns.Contains("Ten_BP_H") Then TxtTen_BP_H.Text = _Dt_Master.Rows(0).Item("Ten_BP_H").ToString.Trim

                If _Dt_Master.Columns.Contains("So_BG") Then TxtSo_BG.Text = _Dt_Master.Rows(0).Item("So_BG").ToString.Trim
                If _Dt_Master.Columns.Contains("T_Tien_Dat") Then TxtT_tien_dat.Double = _Dt_Master.Rows(0).Item("T_Tien_Dat")
            End If
        End If
        Dt_DetailTmp.Rows.Clear()
        Dt_DetailCvTmp.Rows.Clear()
        CyberSmodb.SQLTbToTb(_Dt_DetailCV, Dt_DetailCvTmp)
        CyberSmodb.SQLTbToTb(_Dt_DetailVT, Dt_DetailTmp)
        UpdateList()
    End Sub
    Private Sub V_Loc_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim frm As New FrmLocRo_HD3
        frm._Ds_LoolUp = DsLookup
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Sysvar = osysvar
        frm.AppConn = AppConn
        frm.CyberSmlib = CyberSmlib
        frm.CyberSupport = CyberSupport
        frm.CyberFill = CyberFill
        frm.CyberSmlistSys = CyberSmlistSys
        frm.CyberSmodb = CyberSmodb
        frm.CyberExport = Nothing
        frm.CyberVoucher = CyberVoucher
        frm.CyberLoading = CyberLoading
        frm.ShowInTaskbar = False
        frm.Stt_rec = M_Stt_Rec
        frm.Ma_Ct = M_Ma_CT
        frm.Mode = M_Mode
        frm.Ma_Thue = CbbMa_Thue.SelectedValue.ToString.Trim
        frm.Ma_TT = CbBMa_TT.SelectedValue.ToString.Trim
        frm.Is_ALL_Thue = ChkIs_All_Thue.Checked
        frm.ShowDialog()
        If Not frm.Save_OK Then Exit Sub
        TxtLenh_Ro.Text = ""
        V_UpdateMaster(frm.Master_Return, frm.CV_Return, frm.Vt_Return)
        ChkIs_All_Thue.Checked = frm.Is_ALL_Thue
    End Sub
    Private Sub L_Tien_Hd()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Return
        'For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
        '    Dt_DetailTmp.Rows(iRow).BeginEdit()
        '    Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
        '    Dt_DetailTmp.Rows(iRow).EndEdit()
        'Next
        'Dt_DetailTmp.AcceptChanges()
        '' Update Phan Dung Chung cua detail va Master
        'For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
        '    Dt_DetailCvTmp.Rows(iRow).BeginEdit()
        '    Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
        '    Dt_DetailCvTmp.Rows(iRow).EndEdit()
        'Next
        'Dt_DetailCvTmp.AcceptChanges()

        ''If TxtTien_HD.Double = 0 Then Return
        'Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        'Dim _Ma_Thue As String = CbbMa_Thue.SelectedValue.ToString.Trim

        'Dim _StrXML As String = ""

        '_StrXML = CyberSmodb.V_ConvertDataToXML({"CTHD3", "CTHD3CV"}, {Dt_DetailTmp, Dt_DetailCvTmp})

        'Dim _Pb As String = "0"
        'Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PbTienHdHD3", _Pb & "#" & TxtTien_HD.Double.ToString & "#" & TxtMoi_Gioi.Double.ToString & "#" & TxtHH_BH.Double.ToString & "#" _
        '                                           & M_Mode & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & _StrXML & "#" & _Ma_Thue & "#" _
        '                                           & M_Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        'If Dstmp.Tables.Count = 0 Then
        '    Dstmp.Dispose()
        '    Return
        'End If

        'If Dstmp.Tables.Count >= 1 Then
        '    For iRow As Integer = 0 To Dstmp.Tables(0).Rows.Count - 1
        '        Try
        '            CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(0).Rows(iRow), Dt_DetailTmp, iRow)
        '        Catch ex As Exception
        '        End Try
        '    Next
        'End If
        'If Dstmp.Tables.Count >= 2 Then
        '    For iRow As Integer = 0 To Dstmp.Tables(1).Rows.Count - 1
        '        Try
        '            CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(1).Rows(iRow), Dt_DetailCvTmp, iRow)
        '        Catch ex As Exception
        '        End Try
        '    Next
        'End If
        'Dstmp.Dispose()

        'Dt_DetailTmp.AcceptChanges()
        'Dt_DetailCvTmp.AcceptChanges()

        'UpdateList()
    End Sub
    Function GetTen_Tk(ByVal tk As String) As String
        Dim DtrReturnTk0 As DataRow()
        DtrReturnTk0 = tbDmTk0.Select("Tk0 ='" + tk.Trim + "'")
        If DtrReturnTk0.Length > 0 Then
            GetTen_Tk = DtrReturnTk0(0).Item("Ten_Tk0")
        Else
            GetTen_Tk = ""
        End If
    End Function
    Sub Enableloc_Ro()
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            CmdLoc_Ro.Enabled = False
            Exit Sub
        End If
        If CbbMa_GD.SelectedValue = "1" Then
            CmdLoc_Ro.Enabled = False
            TxtLenh_Ro.Enabled = True
            CbbMa_Thue.Enabled = True
        Else
            CmdLoc_Ro.Enabled = True
            TxtLenh_Ro.Enabled = False
            CbbMa_Thue.Enabled = False
            If M_Mode = "M" Then CmdLoc_Ro.Enabled = True
        End If

        If M_Mode = "S" Then CmdLoc_Ro.Enabled = False
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "S" Then CbBMa_TT.Enabled = False
    End Sub
#End Region
#Region "Valid - Detail"
    Private Sub VisibleCK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkHD_Xuat_VAT.Checked Then
            EditGia20.Visible = False
            EditCK_I.Visible = False
            EditPT_CK_I.Visible = False
            EditTien_Hang0.Visible = False

            EditCK_ICV.Visible = False
            EditPT_CK_ICV.Visible = False
            EditTien_Hang0CV.Visible = False
        End If
        If ChkHD_Xuat_VAT.Checked Then
            EditGia20.Visible = True
            EditCK_I.Visible = True
            EditPT_CK_I.Visible = True
            EditTien_Hang0.Visible = True
            EditCK_ICV.Visible = True
            EditPT_CK_ICV.Visible = True
            EditTien_Hang0CV.Visible = True
        End If
    End Sub
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim i As Integer
        Dim nT_Thue_Cong As Decimal = 0
        Dim nT_Tien_Cong As Decimal = 0
        Dim nT_Tong_Cong As Decimal = 0

        Dim nT_Thue_Hang As Decimal = 0
        Dim nT_Tien_Hang As Decimal = 0
        Dim nT_Tong_Hang As Decimal = 0

        Dim nT_Tien_Nt2 As Decimal = 0
        Dim nT_Tien2 As Decimal = 0

        Dim nT_Thue_Nt As Decimal = 0
        Dim nT_Thue As Decimal = 0

        Dim nT_TT_Nt As Decimal = 0
        Dim nT_TT As Decimal = 0
        Dim nT_TienVT_C As Decimal = 0
        Dim nT_ThueVT_C As Decimal = 0
        Dim nT_TienCV_C As Decimal = 0
        Dim nT_ThueCV_C As Decimal = 0
        Dim nT_TienVT_I As Decimal = 0
        Dim nT_ThueVT_I As Decimal = 0
        Dim nT_TienCV_I As Decimal = 0
        Dim nT_ThueCV_I As Decimal = 0

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            nT_Tien_Hang = nT_Tien_Hang + Dt_DetailTmp.Rows(i).Item("Tien_Hang")
            nT_Thue_Hang = nT_Thue_Hang + Dt_DetailTmp.Rows(i).Item("Thue")
            nT_TienVT_C = nT_TienVT_C + Dt_DetailTmp.Rows(i).Item("Tien_C")
            nT_ThueVT_C = nT_ThueVT_C + Dt_DetailTmp.Rows(i).Item("Thue_C")
            nT_TienVT_I = nT_TienVT_I + Dt_DetailTmp.Rows(i).Item("Tien_BH")
            nT_ThueVT_I = nT_ThueVT_I + Dt_DetailTmp.Rows(i).Item("Thue_BH")
        Next
 


        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            nT_Tien_Cong = nT_Tien_Cong + Dt_DetailCvTmp.Rows(i).Item("Tien_Hang")
            nT_Thue_Cong = nT_Thue_Cong + Dt_DetailCvTmp.Rows(i).Item("Thue")
            nT_TienCV_C = nT_TienCV_C + Dt_DetailCvTmp.Rows(i).Item("Tien_C")
            nT_ThueCV_C = nT_ThueCV_C + Dt_DetailCvTmp.Rows(i).Item("Thue_C")
            nT_TienCV_I = nT_TienCV_I + Dt_DetailCvTmp.Rows(i).Item("Tien_BH")
            nT_ThueCV_I = nT_ThueCV_I + Dt_DetailCvTmp.Rows(i).Item("Thue_BH")
        Next

        If (M_Mode = "M" Or M_Mode = "S") Then
            If ChkSua_Thue.Checked And nT_Thue_Cong = 0 Then TxtT_Thue_Cong.Double = 0
            If ChkSua_Thue.Checked And nT_Thue_Hang = 0 Then TxtT_Thue_hang.Double = 0
            If ChkSua_Thue.Checked And nT_ThueVT_C = 0 Then TxtT_ThueVT_C.Double = 0
            If ChkSua_Thue.Checked And nT_ThueVT_I = 0 Then TxtT_ThueVT_I.Double = 0
            If ChkSua_Thue.Checked And nT_ThueCV_C = 0 Then TxtT_ThueCV_C.Double = 0
            If ChkSua_Thue.Checked And nT_ThueCV_I = 0 Then TxtT_ThueCV_I.Double = 0
        End If
        If ChkSua_Thue.Checked Then nT_Thue_Cong = TxtT_Thue_Cong.Double
        If ChkSua_Thue.Checked Then nT_Thue_Hang = TxtT_Thue_hang.Double

        If ChkSua_Thue.Checked Then nT_ThueVT_C = TxtT_ThueVT_C.Double
        If ChkSua_Thue.Checked Then nT_ThueVT_I = TxtT_ThueVT_I.Double
        If ChkSua_Thue.Checked Then nT_ThueCV_C = TxtT_ThueCV_C.Double
        If ChkSua_Thue.Checked Then nT_ThueCV_I = TxtT_ThueCV_I.Double


        nT_Tong_Cong = nT_Thue_Cong + nT_Tien_Cong
        nT_Tong_Hang = nT_Thue_Hang + nT_Tien_Hang

        '----
        TxtT_Tien_Cong.Double = nT_Tien_Cong
        TxtT_Thue_Cong.Double = nT_Thue_Cong
        TxtT_Tong_Cong.Double = nT_Tong_Cong

        TxtT_TienCV_C.Double = nT_TienCV_C
        TxtT_ThueCV_C.Double = nT_ThueCV_C
        TxtT_TienVT_C.Double = nT_TienVT_C
        TxtT_ThueVT_C.Double = nT_ThueVT_C

        TxtT_TienCV_I.Double = nT_TienCV_I
        TxtT_ThueCV_I.Double = nT_ThueCV_I
        TxtT_TienVT_I.Double = nT_TienVT_I
        TxtT_ThueVT_I.Double = nT_ThueVT_I
        '----
        TxtT_Tien_Hang.Double = nT_Tien_Hang
        TxtT_Thue_hang.Double = nT_Thue_Hang
        TxtT_Tong_Hang.Double = nT_Tong_Hang
        '----
        nT_Tien_Nt2 = nT_Tien_Hang + nT_Tien_Cong
        nT_Thue_Nt = nT_Thue_Hang + nT_Thue_Cong

        nT_Tien2 = nT_Tien_Nt2
        nT_Thue = nT_Thue_Nt

        '-------
        nT_TT_Nt = nT_Tien_Nt2 + nT_Thue_Nt
        nT_TT = nT_TT_Nt
        '-------
        TxtT_Tien2.Double = nT_Tien2
        TxtT_Tien_Nt2.Double = nT_Tien_Nt2
        '----
        TxtT_Thue.Double = nT_Thue
        TxtT_Thue_Nt.Double = nT_Thue_Nt
        '----
        TxtT_TT.Double = nT_TT.ToString
        TxtT_TT_NT.Double = nT_TT_Nt
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        If ChkHD_Xuat_VAT.Checked Then
            '-- TÍnh giá trước chiết khấu
            If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia20") <> 0 Then
                Dv_DetailTmp.Item(iRow).BeginEdit()
                Dv_DetailTmp.Item(iRow).Item("Tien_Hang0") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia20"), M_R_TIEN_NT)
                Dv_DetailTmp.Item(iRow).EndEdit()
            End If

            'Chiet Khau---------------------------------------------------------------------------------------
            If Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") <> 0 Then
                Dv_DetailTmp.Item(iRow).BeginEdit()
                Dv_DetailTmp.Item(iRow).Item("CK_I") = IIf(Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0, Dv_DetailTmp.Item(iRow).Item("CK_I"), CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Hang0") * Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") / 100, 0))
                Dv_DetailTmp.Item(iRow).EndEdit()
            End If

            Dv_DetailTmp.Item(iRow).BeginEdit()

            Dv_DetailTmp.Item(iRow).Item("Tien_Hang") = Dv_DetailTmp.Item(iRow).Item("Tien_Hang0") - Dv_DetailTmp.Item(iRow).Item("CK_I")
            'If Dv_DetailTmp.Item(iRow).Item("Gia2") = 0 Then Dv_DetailTmp.Item(iRow).Item("Gia2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Hang") / Dv_DetailTmp.Item(iRow).Item("So_Luong"), 2)
            If Dv_DetailTmp.Item(iRow).Item("So_Luong") <> 0 Then
                Dv_DetailTmp.Item(iRow).Item("Gia2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Hang") / Dv_DetailTmp.Item(iRow).Item("So_Luong"), 2)
            End If

            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia2") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Hang") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia2"), M_R_TIEN_NT)
            If Dv_DetailTmp.Item(iRow).Item("Is_Sua_Thue") = "0" Then
                Dv_DetailTmp.Item(iRow).Item("Thue") = CyberSupport.V_Round((Dv_DetailTmp.Item(iRow).Item("Tien_Hang") * Dv_DetailTmp.Item(iRow).Item("Thue_Suat")) / 100, M_R_TIEN_NT)
            End If


            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If nTy_Gia = 1 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_Nt")
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            Dv_DetailTmp.Item(iRow).EndEdit()
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA_NT)
            Dv_DetailTmp.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_GIA_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub Tinh_Gia2(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        '--  đối với số Ro lấy từ lệnh sang thì không cho nhảy lại giá
        If Not TxtLenh_Ro.Text.Trim.ToUpper().Contains("F") Then
            Exit Sub

        End If

        Dim _Gia_TK As Decimal = 0 'Dv_DetailTmp.Item(iRow).Item("Gia_TK")
        Dim _Gia2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia2")
        Dim _Ma_vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt")
        Dim _Ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I")
        Dim _Ma_TT As String = Dv_DetailTmp.Item(iRow).Item("Ma_TT")
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        'Dim _Ngay_Ct As Date = Dv_DetailTmp.Item(iRow).Item("Ngay_Gia2")

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        If _Ngay_Ct.ToString = "" Or _Ngay_Ct.ToString("yyyyMMdd") = "19000101" Then
            _Ngay_Ct = TxtNgay_Ct.Value
        End If

        Dim iTai_tung As Integer = 0
        'Dim _KM_Hang As String = Dv_DetailTmp.Item(iRow).Item("Km_Hang")
        Dim _Ma_CTTT As String = "" 'Dv_DetailTmp.Item(iRow).Item("MA_CTTT")
        '-----------------------------------------------------------------------------------------------------------
        Dim dsGia2 As New DataSet
        dsGia2 = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDKGia2", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT.Trim & "#" & M_Stt_Rec & "#" & M_Mode & "#" &
                                                    _Ma_GD & "#" & _Ma_Post & "#" & _Ma_vt.Trim & "#" & _Ma_Kho.Trim + "#" & _Ma_TT & "#" &
                                                    _Gia2.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim + "#" + _Ma_CTTT)
        _Gia2 = dsGia2.Tables(0).Rows(0).Item("Gia2")
        _Gia_TK = dsGia2.Tables(0).Rows(0).Item("Gia_TK")

        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Gia2") = _Gia2
        Dv_DetailTmp.Item(iRow).Item("Gia20") = _Gia2
        'If Dt_DetailTmp.Columns.Contains("Gia_TK") Then Dv_DetailTmp.Item(iRow).Item("Gia_TK") = _Gia_TK
        If Dt_DetailTmp.Columns.Contains("BackColor") And dsGia2.Tables(0).Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = dsGia2.Tables(0).Rows(0).Item("BackColor")
        If Dt_DetailTmp.Columns.Contains("BackColor2") And dsGia2.Tables(0).Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = dsGia2.Tables(0).Rows(0).Item("BackColor2")
        If Dt_DetailTmp.Columns.Contains("ForeColor") And dsGia2.Tables(0).Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = dsGia2.Tables(0).Rows(0).Item("ForeColor")
        If Dt_DetailTmp.Columns.Contains("Bold") And dsGia2.Tables(0).Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = dsGia2.Tables(0).Rows(0).Item("Bold")
        Dv_DetailTmp.Item(iRow).EndEdit()

        dsGia2.Dispose()

        '-----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_Tinh_ToanCV(ByVal iRow As Integer)
        If ChkHD_Xuat_VAT.Checked Then
            'Chiet Khau---------------------------------------------------------------------------------------
            If Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") <> 0 Then
                Dv_DetailCvTmp.Item(iRow).BeginEdit()
                Dv_DetailCvTmp.Item(iRow).Item("CK_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") = 0, Dv_DetailCvTmp.Item(iRow).Item("CK_I"), CyberSupport.V_Round(Dv_DetailCvTmp.Item(iRow).Item("Tien_Hang0") * Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") / 100, 0))
                Dv_DetailCvTmp.Item(iRow).EndEdit()
            End If
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Tien_Hang") = Dv_DetailCvTmp.Item(iRow).Item("Tien_Hang0") - Dv_DetailCvTmp.Item(iRow).Item("CK_I")
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If

        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        If Dv_DetailCvTmp.Item(iRow).Item("Is_Sua_Thue") = "0" Then
            Dv_DetailCvTmp.Item(iRow).Item("Thue") = CyberSupport.V_Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_Hang") * Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat")) / 100, M_R_TIEN_NT)
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        CyberSupport.V_UpdateGRV(DetailGRVCv)
        UpdateList()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)
        Tinh_Gia2(iRow)
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub L_Tinh_ToanCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRVCv.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVCv.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRVCv)
        V_Tinh_ToanCV(iRow)
    End Sub
    Private Sub V_Ma_Kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = TxtDien_Giai.Text
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        DetailGRV.ShowEditor()
    End Sub
#End Region
#Region "Vat tu kho/Vitri - "
    Private Sub V_Ma_Lo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Lo(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Lo(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Ma_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Tk_Vt As String = DrReturn.Item("Tk_Vt")
        Dim _Tk_Dt As String = DrReturn.Item("Tk_Dt")
        Dim _Tk_Gv As String = DrReturn.Item("Tk_Gv")
        Dim _Tk_SPDD As String = DrReturn.Item("Tk_SPDD")
        Dim _DVT As String = "", _Ten_VT As String = "", _Ma_VT As String = "", _Thue_Suat As Decimal = 0
        _Ma_VT = DrReturn("Ma_vt").ToString.Trim
        _Ma_VT = DrReturn("Ma_vt").ToString.Trim
        _Ten_VT = DrReturn("Ten_VT").ToString.Trim
        _DVT = DrReturn("DVT").ToString.Trim
        _Thue_Suat = DrReturn("Thue_Suat").ToString.Trim

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tk_Dt") = _Tk_Dt
        Dv_DetailTmp.Item(iRow).Item("Tk_Vt") = _Tk_Vt
        Dv_DetailTmp.Item(iRow).Item("Tk_Gv") = _Tk_Gv
        Dv_DetailTmp.Item(iRow).Item("Ma_Vt") = _Ma_VT
        Dv_DetailTmp.Item(iRow).Item("Ten_vt") = _Ten_VT
        Dv_DetailTmp.Item(iRow).Item("DVT") = _DVT
        Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = 0, _Thue_Suat, Dv_DetailTmp.Item(iRow).Item("Thue_Suat"))
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------------------------------------------------------
        If Dv_DetailTmp.Item(iRow).Item("Ten_vt3").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ten_vt3") = _Ten_VT
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        'Dv_DetailTmp.Item(iRow).Item("Ma_TTLN_I") = _Ma_TTLN
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        Tinh_Gia2(iRow)
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim
        Dim _Ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _Ma_Vitri As String = If(Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri"), Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim, "")
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_Lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_Kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If Dt_DetailTmp.Columns.Contains("Ton13") Then Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Ma_Vitri") And _Return.Table.Columns.Contains("Ma_Vitri") Then Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = _Return("Ma_Vitri")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor") And _Return.Table.Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = _Return.Item("BackColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor2") And _Return.Table.Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = _Return.Item("BackColor2")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ForeColor") And _Return.Table.Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = _Return.Item("ForeColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Bold") And _Return.Table.Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = _Return.Item("Bold")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Underline") And _Return.Table.Columns.Contains("Underline") Then Dv_DetailTmp.Item(iRow).Item("Underline") = _Return.Item("Underline")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Italic") And _Return.Table.Columns.Contains("Italic") Then Dv_DetailTmp.Item(iRow).Item("Italic") = _Return.Item("Italic")

            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
#End Region
#Region "Tai khoan "
    Private Sub V_Tk_Dt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Dt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_Dt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Dt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Tk_Gv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Nx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_Gv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Gv(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_So(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_PO(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_Ro(Dv_DetailTmp, iRow, AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_Ct, CbbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_VT(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Detail - Add On"
    Private Sub V_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Db_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kx_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Tuyen_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Tuyen_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Ts(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ts(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ts(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cc(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cc(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
#Region "Công việc"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = ""
            Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailCvTmp.Item(iRow).Item("Dvt3") = ""
            Dv_DetailCvTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).Item("Dvt3") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Dvt3") <> "", Dv_DetailCvTmp.Item(iRow).Item("Dvt3"), DrReturn("Dvt").ToString.Trim)
        'Dv_DetailCvTmp.Item(iRow).Item("Ma_TTLN_I") = DrReturn("Ma_TTLN").ToString.Trim
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub L_Tk_Dt_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Dt(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Tk_Dt_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Dt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_I_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TTLN_I_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_BP_I_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_BP_I_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
#End Region
    Private Sub V_Ma_Thue_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        CyberSupport.V_Lookup("Ma_Thue", "DmThue", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Thue_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)

        If DrReturn Is Nothing Then
            If Dv_DetailTmp.Item(iRow).Item("Ma_Thue").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    'UpdateList()
                    SendKeys.Send("^{TAB}")
                    Exit Sub
                End If
            End If
            Exit Sub
        End If

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Thue_I") = DrReturn("Ma_Thue").ToString.Trim
        If Dv_DetailTmp.Table.Columns.Contains("Thue_SuatI") And DrReturn.Table.Columns.Contains("Thue_Suat") Then Dv_DetailTmp.Item(iRow).Item("Thue_SuatI") = DrReturn("Thue_Suat")
        Dv_DetailTmp.Item(iRow).EndEdit()

        Dv_DetailTmp.Table.AcceptChanges()
        V_Tinh_Toan(iRow)
        DetailGRV.UpdateCurrentRow()
    End Sub
#End Region

#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Ty gia -  Ngoai te"
    Private Sub L_Ma_NT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, DsLookup, TxtMa_NT.Text, "Ma_NT", "DmNT", DrReturn, "1=1", "1=1", "1")
        If Not DrReturn Is Nothing Then TxtMa_NT.Text = DrReturn.Item("Ma_NT") Else TxtMa_NT.Text = ""
        Dim Dt As Date = TxtNgay_Ct.Value
        TxtTy_Gia.Double = CyberSupport.GetRate(Dt, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        GetRound()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next

        VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Function V_GetTyGia() As Decimal
        Dim nTy_Gia As Decimal = TxtTy_Gia.Double
        If nTy_Gia = 0 Then nTy_Gia = 1
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.ToUpper.Trim Then TxtTy_Gia.Double = 1
        TxtTy_Gia.Double = nTy_Gia
        V_GetTyGia = nTy_Gia
    End Function
#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsManl As New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)
        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        DetailGRV.GridControl.ContextMenu = mnItemsMail

        mnItemsManl.MenuItems.Add(mnItemsSave)
        mnItemsManl.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRV) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Mode = "X" Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Me.CmdPrint.Enabled Then V_Print(sender, e)
    End Sub
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode.Trim = "X" Then If e.KeyValue = 27 Then V_Exit(sender, e)
        If M_Mode.Trim = "X" Then
            Select Case e.KeyValue
                Case 33 'Pageup
                    V_Prev(sender, e)
                Case 34 'PageDown
                    V_NEXT(sender, e)
                Case 35 'End
                    V_Bottom(sender, e)
                Case 36 'Home
                    V_Top(sender, e)
            End Select
        End If
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String) As Boolean
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Dt, _Mode, _Ma_Post, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, osysvar, CyberSmlib)
    End Function
#End Region
#Region "Mainform Cong Viec"
    Private Sub V_MainSystemCv()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemCv, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemCv, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVCv_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCv, Nothing, True, False))

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItemCv(iRow)
        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCvTmp, AppConn, DetailGRVCv) Then Exit Sub
        Dv_DetailCvTmp.Delete(iRow)
        Dv_DetailCvTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        DetailGRVCv.PostEditor()

        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailCvTmp.Table.AcceptChanges()

        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtLenh_Ro.Text <> "" And txtSo_Ro_Vat.Text = "" Then
            txtSo_Ro_Vat.Text = TxtLenh_Ro.Text
        End If

        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailCvTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)

        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        If TxtSo_HD.Text.Trim = "" Then TxtSo_HD.Text = TxtSo_Ct.Text
        '----------------------------------------------------------------------------------------------------------------------
        V_Phan_Bo_Thue()
        '----------------------------------------------------------------------------------------------------------------------
        Dim DrMasterOld As DataRow
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            DrMasterOld = CyberSmodb.V_CopyDataRow(drMaster)

            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp}, {M_Ct, M_Ph, "CTHD3CV"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
            If M_Mode = "S" And Not DrMasterOld Is Nothing Then CyberSmodb.V_UpdateRowtoRow(DrMasterOld, Dt_Master, CrrRow)
            Return
        End If
        '---------------------------------------------------
        '---Update Head
        If DsSave.Tables.Count >= 2 Then
            If DsSave.Tables(1).Rows.Count > 0 Then
                CyberSmodb.SetValueTObj_1(Me, DsSave.Tables(1).Rows(0)) '----Chi set Những trường có dữ liệu
                CyberSmodb.AddValueToRow(drMaster, Me)
                drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
                drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
                drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            End If
        End If
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '---Update Chi tiet
        If DsSave.Tables.Count >= 3 Then
            For iRow As Integer = 0 To DsSave.Tables(2).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(2).Rows(iRow), Dt_DetailTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_Detail.Load(Dt_DetailTmp.CreateDataReader)

        '---Update CV
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailCvTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---------------------------------------------------

        '---Xoa trong DetailCV
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailCv.Load(Dt_DetailCvTmp.CreateDataReader)
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")

        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Save_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------

        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri

        '----------------------------------------------------------------------------------------------------------------------
        Dim _strField As String = ""
        Dim _strvalue As String = ""

        Dim CP_ChkInPut As String = "CP_SysChkVoucherInput" & M_Ma_CT.Trim
        Dim CP_ChkInPut_CV As String = "CP_SysChkVoucherInput" & M_Ma_CT.Trim & "_CV"

        CyberSmodb.GetValueControler(Me, _strField, _strvalue)

        If Dt_DetailTmp.Rows.Count > 0 Then If Not CyberSupport.ChkVoucherInput1(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, CP_ChkInPut, _strField, _strvalue, "Ten_NV,Ten_KH,Ten_KX,Ten_MAU,Ten_BH,Ten_SK,Ten_LHSC,Ten_LHKH", "Ten_VT,Ten_VT3,Ten_Kho_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub

        If Dt_DetailCvTmp.Rows.Count > 0 Then If Not CyberSupport.ChkVoucherInput1(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailCvTmp, CP_ChkInPut_CV, _strField, _strvalue, "Ten_NV,Ten_KH,Ten_KX,Ten_MAU,Ten_BH,Ten_SK,Ten_LHSC,Ten_LHKH", "Ten_VT,Ten_VT3,Ten_Kho_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub

        If Not ChkDetailHD3(_strField, _strvalue) Then Exit Sub

        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,Ten_KH", "Ten_VT,Ten_Kho_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        If TxtSo_HD.Text.Trim = "" Then TxtSo_HD.Text = TxtSo_Ct.Text
        '----------------------------------------------------------------------------------------------------------------------
        V_Phan_Bo_Thue()
        '----------------------------------------------------------------------------------------------------------------------
        If Not Add2Database() Then Return
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        'CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Phan_Bo_Thue()
        If ChkSua_Thue.Checked Then
            CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_Hang", "Thue", TxtT_Thue_hang.Double, M_R_TIEN_NT)
            CyberSupport.Phan_Bo(Dt_DetailCvTmp, "Tien_Hang", "Thue", TxtT_Thue_Cong.Double, M_R_TIEN)
            CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_C", "Thue_C", TxtT_ThueVT_C.Double, M_R_TIEN_NT)
            CyberSupport.Phan_Bo(Dt_DetailCvTmp, "Tien_C", "Thue_C", TxtT_ThueCV_C.Double, M_R_TIEN)
            CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_BH", "Thue_BH", TxtT_ThueVT_I.Double, M_R_TIEN_NT)
            CyberSupport.Phan_Bo(Dt_DetailCvTmp, "Tien_BH", "Thue_BH", TxtT_ThueCV_I.Double, M_R_TIEN)
        End If
    End Sub
    Private Function ChkVsave() As Boolean
        Dim iRow, nCount, nCountCV As Integer
        nCount = Dt_DetailTmp.Rows.Count
        If ChkHD_Xuat_VAT.Checked Then
            For iRow = nCount - 1 To 0 Step -1
                V_Tinh_Toan(iRow)
            Next

            nCountCV = Dt_DetailCvTmp.Rows.Count
            For iRow = nCountCV - 1 To 0 Step -1
                V_Tinh_ToanCV(iRow)
            Next
        End If


        'For iRow = nCount - 1 To 0 Step -1
        '    If Dt_DetailTmp.Rows(iRow).Item("Tk_I").ToString.Trim = "" Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'Next

        'nCount = Dt_DetailCvTmp.Rows.Count
        'For iRow = nCount - 1 To 0 Step -1
        '    If Dt_DetailCvTmp.Rows(iRow).Item("Ma_Cv").ToString.Trim = "" Then
        '        Dt_DetailCvTmp.Rows(iRow).Delete()
        '        Dt_DetailCvTmp.AcceptChanges()
        '    End If
        'Next
        'nCount = Dt_DetailVtTmp.Rows.Count
        'For iRow = nCount - 1 To 0 Step -1
        '    If Dt_DetailVtTmp.Rows(iRow).Item("Ma_VT").ToString.Trim = "" Then
        '        Dt_DetailVtTmp.Rows(iRow).Delete()
        '        Dt_DetailVtTmp.AcceptChanges()
        '    End If
        'Next        
        '---------------------------------------------------------------------------------
        ' Update Phan Dung Chung cua detail va Master
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_TT") = CbBMa_TT.SelectedValue.ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            If Dt_DetailTmp.Columns.Contains("Ma_Bp_I") Then If TxtMa_BP_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Bp_I") = TxtMa_BP_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_HS_I") Then If TxtMa_Hs_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HS_I") = TxtMa_Hs_H.Text.Trim

            If Dt_DetailTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim

            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        ' Update Phan Dung Chung cua detail va Master
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).BeginEdit()
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_TT") = CbBMa_TT.SelectedValue.ToString.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            If Dt_DetailCvTmp.Columns.Contains("Ma_Bp_I") Then If TxtMa_BP_H.Text.Trim <> "" Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Bp_I") = TxtMa_BP_H.Text.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_HS_I") Then If TxtMa_Hs_H.Text.Trim <> "" Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_HS_I") = TxtMa_Hs_H.Text.Trim

            If Dt_DetailCvTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim

            Dt_DetailCvTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges()
        'If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---------------------------------------------------------------------------------
        If Dt_DetailTmp.Rows.Count < 1 And Dt_DetailCvTmp.Rows.Count < 1 Then
            MsgBox("bạn chưa nhập chi tiết!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            Return False
        End If
        '---------------------------------------------------------------------------------
        '---Update: So_RO/So_PO/So_SO
        'CyberSupport.V_SaveLenh(Dv_DetailTmp, "", TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        UpdateList()

        ChkVsave = True
    End Function
    Function ChkDetailHD3(Optional ByRef _StrFieldMaster As String = "", Optional ByRef _strValueMaster As String = "") As Boolean
        Dim nCountVt, nCountCv, i As Integer
        Dim strCVRec_RO As String = ""
        Dim strCVRec0_RO As String = ""
        Dim strCVSo_RO As String = ""
        Dim strCVMa_CV As String = ""
        Dim strCVMa_TT As String = ""
        Dim strCVTk_DT As String = ""
        Dim strCVTk_Thue As String = ""
        Dim strCVTien_CV As String = ""
        Dim strCVThue_CV As String = ""

        Dim strVTRec_RO As String = ""
        Dim strVTRec0_RO As String = ""
        Dim strVTSo_RO As String = ""
        Dim strVTMa_Vt As String = ""
        Dim strVTMa_TT As String = ""
        Dim strVTTk_DT As String = ""
        Dim strVTTk_Thue As String = ""
        Dim strVTSo_luong As String = ""
        Dim strVTTien2 As String = ""
        Dim strVTThue_VT As String = ""

        nCountCv = Dt_DetailCvTmp.Rows.Count
        nCountVt = Dt_DetailTmp.Rows.Count
        For i = 0 To nCountCv - 1
            strCVRec_RO = strCVRec_RO + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Rec_RO").ToString.Trim
            strCVRec0_RO = strCVRec0_RO + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Rec0_RO").ToString.Trim
            strCVSo_RO = strCVSo_RO + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("So_RO").ToString.Trim
            strCVMa_CV = strCVMa_CV + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Ma_CV").ToString.Trim
            strCVMa_TT = strCVMa_TT + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim
            strCVTk_DT = strCVTk_DT + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Tk_DT").ToString.Trim
            strCVTk_Thue = strCVTk_Thue + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Tk_Thue").ToString.Trim
            strCVTien_CV = strCVTien_CV + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Tien_Hang").ToString.Trim.Replace(",", "").Replace(" ", "")
            strCVThue_CV = strCVThue_CV + IIf(i = 0, "", "!~!") + Dt_DetailCvTmp.Rows(i).Item("Thue").ToString.Trim.Replace(",", "").Replace(" ", "")
        Next
        For i = 0 To nCountVt - 1
            strVTRec_RO = strVTRec_RO + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Rec_RO").ToString.Trim
            strVTRec0_RO = strVTRec0_RO + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Rec0_RO").ToString.Trim
            strVTSo_RO = strVTSo_RO + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("So_RO").ToString.Trim
            strVTMa_Vt = strVTMa_Vt + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Ma_Vt").ToString.Trim
            strVTMa_TT = strVTMa_TT + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim
            strVTTk_DT = strVTTk_DT + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Tk_DT").ToString.Trim
            strVTTk_Thue = strVTTk_Thue + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Tk_Thue").ToString.Trim
            strVTSo_luong = strVTSo_luong + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("So_luong").ToString.Trim.Replace(",", "").Replace(" ", "")
            strVTTien2 = strVTTien2 + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Tien_Hang").ToString.Trim.Replace(",", "").Replace(" ", "")
            strVTThue_VT = strVTThue_VT + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Thue").ToString.Trim.Replace(",", "").Replace(" ", "")
        Next
        '------------------------------------------------------------------------------------------------------------------
        Dim DstmChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkDetailHD3", M_Ma_CT + "#" + M_Stt_Rec + "#" + M_Mode + "#" + M_Ma_GD + "#" + CbbMa_Post.SelectedValue.ToString.Trim + "#" + _
        nCountVt.ToString.Trim.Replace(" ", "") + "#" + nCountCv.ToString.Trim.Replace(" ", "") + "#" + _
        strCVRec_RO + "#" + strCVRec0_RO + "#" + strCVSo_RO + "#" + strCVMa_CV + "#" + strCVMa_TT + "#" + strCVTk_DT + "#" + strCVTk_Thue + "#" + strCVTien_CV + "#" + strCVThue_CV + "#" + _
        strVTRec_RO + "#" + strVTRec0_RO + "#" + strVTSo_RO + "#" + strVTMa_Vt + "#" + strVTMa_TT + "#" + strVTTk_DT + "#" + strVTTk_Thue + "#" + strVTSo_luong + "#" + strVTTien2 + "#" + strVTThue_VT + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If Not CyberSupport.V_MsgChk(DstmChk.Tables(0), Me.SysVar, Me.Lan) Then
            DstmChk.Dispose()
            ChkDetailHD3 = False
            Exit Function
        End If
        DstmChk.Dispose()
        ChkDetailHD3 = True
    End Function
    Private Function Add2Database() As Boolean
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp}, {M_Ct, M_Ph, "CTHD3CV"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)

        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTHD3CV", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
    Private Sub Add2Database_Luu()
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL
        CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTHD3CV", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub

        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        Dim Frm As Cyber.From.FrmCopy
        Frm = New FrmCopy
        Frm.Para = M_Para
        Frm.Lan = M_LAN
        Frm.Sysvar = osysvar
        Frm.DrDmct = Me.DrDmct
        Frm.So_CT = ""
        Frm.Ngay_CT = Now.Date
        Frm.Ngay_LCT = Now.Date
        Frm.SysApp = AppConn
        Frm.Ma_Dvcs = TxtMa_Dvcs.Text
        Frm.Stt_Rec = M_Stt_Rec
        Frm.ShowDialog()

        If Not Frm.Ok_Copy Then
            M_Stt_Rec = M_Stt_RecOld
            Exit Sub
        End If

        Dim _Ngay_Ct_Copy As Date = Frm.TxtNgay_Ct.Value
        Dim _Ngay_LCt_Copy As Date = Frm.TxtNgay_LCt.Value
        Dim _So_Ct_Copy As String = Frm.txtSo_ct.Text
        Dim _Ma_Quyen_Copy As String = Frm.TxtMa_Quyen.Text

        Dim I As Integer
        For I = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(I).BeginEdit()
            Dt_DetailTmp.Rows(I).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(I).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(I).Item("So_Ct") = _So_Ct_Copy
            Tinh_Gia2(I)
            V_SetSD(I)
            Dt_DetailTmp.Rows(I).EndEdit()
        Next
 

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        TxtSo_Ct.Text = _So_Ct_Copy.Trim
        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

        TxtNgay_CtHD.Value = TxtNgay_Ct.Value
        TxtNoteHDDT.Text = ""
        TxtMau_VatHD.Text = ""
        TxtSo_SeriHD.Text = ""
        TxtSo_HDDT.Text = ""
        TxtMa_Tra_Cuu.Text = ""
        TxtEmailHDDT.Text = ""
        txtSo_Ro_Vat.Text = ""
        TxtLenh_Ro.Text = ""
        TxtDien_Giai.Text = ""
        TxtDien_Giai_HDDT.Text = ""

    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)
        M_Mode = "M"
        V_Databing()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtMa_Nx.Text = M_Tk_No
        TxtTen_Nx.Text = M_Ten_Tk_No
        If TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = M_Dien_Giai
        If txtHT_TT.Text.Trim = "" Then txtHT_TT.Text = M_HT_TT
        txtKy_Hieu_HD.Text = _Para_Ky_Hieu_HD
        CbbMa_Thue.SelectedValue = M_Ma_Thue
        TxtNgay_HD.Value = Now.Date
        ChkSua_Thue.Checked = False

        V_New()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        TxtHT_TT.Text = IIf(TxtHT_TT.Text = "", "TM/CK", TxtHT_TT.Text)
        V_Setstatus()
        V_SetFocus("M")
        Enableloc_Ro()
        '----------------------------------------------------------------------------
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
        '----------------------------------------------------------------------------
    End Sub
    Private Sub V_New()
        'If Dt_DetailTmp.Rows.Count < 1 Then
        '    Dim DrCurren As DataRow
        '    Dt_DetailTmp.NewRow()
        '    DrCurren = Dt_DetailTmp.NewRow
        '    CyberSmodb.SetValueBlankRow(DrCurren)
        '    DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
        '    DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
        '    DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
        '    DrCurren.Item("Stt_Rec0") = "0001"

        '    Dt_DetailTmp.Rows.Add(DrCurren)
        '    Dt_DetailTmp.AcceptChanges()
        'End If
    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        M_Mode = "S"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("S")
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("D") Then Exit Sub
        If Not chkCherDeleteHDDT("D") Then Exit Sub

        Dim iMasterRow As Integer = -1
        For iRow As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                iMasterRow = iRow
                Exit For
            End If
        Next
        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub
        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailCv, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("D")
    End Sub
    Function chkCherDeleteHDDT(ByVal Status As String) As Boolean
        If DrDmct.Table.Columns.Contains("HDDT") = False Then Return True
        If DrDmct("HDDT").ToString.Trim <> "1" Then Return True

        Dim dsReturn As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_InvoiceChekDeleteVoucher", M_Ma_CT & "#" & M_Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If dsReturn.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper = "N" Then
            MsgBox(dsReturn.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_CYBER_VER"))
            dsReturn.Dispose()
            Return False
        End If
        dsReturn.Dispose()
        Return True
    End Function
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_Rec = M_Stt_RecOld
        V_Databing()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub

        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)

        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberSupport.V_ExitVoucher(osysvar, M_LAN) Then Exit Sub
        Me.Close()
    End Sub
#End Region
#Region "Add Or Detete Item"
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRV.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRV.VisibleColumns.IndexOf(DetailGRV.FocusedColumn)
        Dim iRowOld As Integer = DetailGRV.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Thue_Suat") = CbbMa_Thue.SelectedValue.ToString.Trim
        DvNew.Item("Tk_Thue") = M_Tk_Thue
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Add Or Detete Item Cong Viec"
    Private Sub MasterGRVCv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCv(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemCv(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailCvTmp
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCv(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Thue_Suat") = CbbMa_Thue.SelectedValue.ToString.Trim
        DvNew.Item("Tk_Thue") = M_Tk_Thue
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRV, Dt_DetailTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub SetTxt()
        TxtT_Tien_Cong.ReadOnly = True
        TxtT_Thue_Cong.ReadOnly = True
        TxtT_Tong_Cong.ReadOnly = True

        TxtT_Tien_Hang.ReadOnly = True
        TxtT_Thue_hang.ReadOnly = True
        TxtT_Tong_Hang.ReadOnly = True

        TxtT_Tien_Nt2.ReadOnly = True
        TxtT_Thue_Nt.ReadOnly = True
        TxtT_TT_NT.ReadOnly = True
        If Not ChkHD_Xuat_VAT.Checked And 1 = 0 Then
            TxtMa_xe.ReadOnly = True
        End If


        If M_Mode = "M" Or M_Mode = "S" Then
            'If ChkSua_Thue.Checked Then TxtT_Thue_Nt.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_Thue_hang.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_Thue_Cong.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_ThueVT_C.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_ThueCV_C.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_ThueVT_I.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_ThueCV_I.ReadOnly = False

        End If
        If ChkSua_Thue.Checked Then
            TxtT_Thue_Cong.BackColor = Drawing.Color.Pink
            TxtT_Thue_hang.BackColor = Drawing.Color.Pink
            TxtT_Thue_Nt.BackColor = Drawing.Color.Pink

            TxtT_ThueCV_C.BackColor = Drawing.Color.Pink
            TxtT_ThueVT_C.BackColor = Drawing.Color.Pink
            TxtT_ThueCV_I.BackColor = Drawing.Color.Pink
            TxtT_ThueVT_I.BackColor = Drawing.Color.Pink

        Else
            TxtT_Thue_Cong.BackColor = Drawing.Color.White
            TxtT_Thue_hang.BackColor = Drawing.Color.White
            TxtT_Thue_Nt.BackColor = Drawing.Color.White
            TxtT_ThueCV_C.BackColor = Drawing.Color.White
            TxtT_ThueVT_C.BackColor = Drawing.Color.White
            TxtT_ThueCV_I.BackColor = Drawing.Color.White
            TxtT_ThueVT_I.BackColor = Drawing.Color.White

        End If

        TxtNgay_CtHD.ReadOnly = True
        TxtNoteHDDT.ReadOnly = True
        TxtMau_VatHD.ReadOnly = True
        TxtSo_SeriHD.ReadOnly = True
        TxtSo_HDDT.ReadOnly = True
        TxtMa_Tra_Cuu.ReadOnly = True
        'TxtEmailHDDT.ReadOnly = True
        'TxtDiem_Luy_Ke.ReadOnly = True
        'TxtDiem_Ro.ReadOnly = True
    End Sub
#End Region
#Region "TTCP Default and New/Save _TTCP"
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DtTTCP As DataTable
    Dim M_Ma_TTCP_H As String = ""
    Dim M_Ten_TTCP_H As String = ""
    Dim M_Ten_TTCP2_H As String = ""

    Dim M_Ma_TTLN_H As String = ""
    Dim M_Ten_TTLN_H As String = ""
    Dim M_Ten_TTLN2_H As String = ""

    Dim M_Ma_HS_H As String = ""
    Dim M_Ten_HS_H As String = ""
    Dim M_Ten_HS2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CbbMa_TTCP_H.Visible = M_Is_Visible_TTCP
        If M_Is_Visible_TTCP And DrDmct.Table.Columns.Contains("CaptionTTCP") Then If DrDmct.Item("CaptionTTCP").ToString.Trim <> "" Then LabMa_TTCP_H.Text = DrDmct.Item("CaptionTTCP").ToString.Trim

        If M_Is_Visible_TTCP Then
            Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

            If DsTmp.Tables.Count = 0 Then
                M_Is_Visible_TTCP = False
                DsTmp.Dispose()
                Return
            End If

            If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP_H") Then M_Ten_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP2_H") Then M_Ten_TTCP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub
    Private Sub V_SetSo_BG()
        If ChkIs_BG.Checked = True Then
            TxtSo_BG.Enabled = True
            cmdXe_Tiep_Don.Enabled = True
        ElseIf ChkIs_BG.Checked = False Then
            TxtSo_BG.Enabled = False
            TxtSo_BG.Text = ""
            cmdXe_Tiep_Don.Enabled = False
        End If
    End Sub
    Private Sub V_Xoa_Detail()
        If ChkXoa_Detail.Checked = True Then
            Dt_DetailTmp.Clear()
            Dt_DetailCvTmp.Clear()
            UpdateList()
        End If
    End Sub
#End Region
#Region "Hóa đơn điện tử"
#Region "Hóa đơn điện tử"
    Private Sub CmdTAONhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        'Check phân quyền
        Dim dsCheck As New DataSet
        dsCheck = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Chk_HDDT ", M_Ma_CT.Trim + "#" + M_Stt_Rec.Trim + "#U" + "#" + M_User_Name.Trim + "#" + M_Ma_Dvcs.Trim)

        If dsCheck.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then
            MsgBox(dsCheck.Tables(0).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
            If dsCheck.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
                dsCheck.Dispose()
                Exit Sub
            End If
        End If

        If MsgBox("Bạn chắc chắn muốn tạo hóa đơn điện tử?", MsgBoxStyle.YesNo, osysvar("M_CYBER_VER")) <> MsgBoxResult.Yes Then Return
        '--==========================================================
        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO", "T#" + M_Stt_Rec.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)

        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If
        Dim _postapi As New Cyber.PostAPIInvoiceVNPT.supportInvoiceVNPT
        Dim dsReturn As DataSet = _postapi.V_TaoHoaDon_Nhap(DsData.Tables(1).Rows(0), DsData.Tables(2).Rows(0), DsData.Tables(3))

        If dsReturn.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(dsReturn.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        '==================================================
        Dim So_hoadon As String = "" 'dsReturn.Tables(1).Rows(0)("So_Hd").ToString()
        Dim Seri_hoadon As String = "" 'dsReturn.Tables(1).Rows(0)("So_Seri").ToString()
        Dim mauso_hoadon As String = "" 'dsReturn.Tables(1).Rows(0)("mau_so").ToString()

        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIInvoice_UPDATE", M_Stt_Rec.Trim + "##" + M_Ma_CT.Trim + "#T#" + dsReturn.Tables(1).Rows(0)("mau_so") + "#" + dsReturn.Tables(1).Rows(0)("So_Seri") + "##" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)

        'TxtSo_HDDT.Text = So_hoadon
        If TxtSo_SeriHD.Text = "" Then TxtSo_SeriHD.Text = Seri_hoadon
        If TxtMau_VatHD.Text = "" Then TxtMau_VatHD.Text = mauso_hoadon
        TxtNoteHDDT.Text = "Hóa đơn đã tạo hóa đơn điện tử nháp"

        MsgBox("Hóa đơn đã tạo hóa đơn điện tử nháp thành công!", MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))

    End Sub


    Private Sub CMDTAO_HD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        'Check phân quyền
        Dim dsCheck As New DataSet
        dsCheck = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Chk_HDDT ", M_Ma_CT.Trim + "#" + M_Stt_Rec.Trim + "#U" + "#" + M_User_Name.Trim + "#" + M_Ma_Dvcs.Trim)

        If dsCheck.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then
            MsgBox(dsCheck.Tables(0).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
            If dsCheck.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
                dsCheck.Dispose()
                Exit Sub
            End If
        End If

        If MsgBox("Bạn chắc chắn muốn update hóa đơn điện tử?", MsgBoxStyle.YesNo, osysvar("M_CYBER_VER")) <> MsgBoxResult.Yes Then Return

        '--==========================================================
        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO", "P#" + M_Stt_Rec.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)

        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If
        Dim _postapi As New Cyber.PostAPIInvoiceVNPT.supportInvoiceVNPT
        Dim dsReturn As DataSet = _postapi.V_TaoHoaDon(DsData.Tables(1).Rows(0), DsData.Tables(2).Rows(0), DsData.Tables(3))

        If dsReturn.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(dsReturn.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        '==================================================
        Dim So_hoadon As String = dsReturn.Tables(1).Rows(0)("So_Hd").ToString()
        Dim Seri_hoadon As String = dsReturn.Tables(1).Rows(0)("So_Seri").ToString()
        Dim mauso_hoadon As String = dsReturn.Tables(1).Rows(0)("mau_so").ToString()

        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIInvoice_UPDATE", M_Stt_Rec.Trim + "#" + TxtStt_Rec_TT.Text + "#" + M_Ma_CT.Trim + "#P#" + dsReturn.Tables(1).Rows(0)("mau_so") + "#" + dsReturn.Tables(1).Rows(0)("So_Seri") + "#" + dsReturn.Tables(1).Rows(0)("So_Hd") + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)

        TxtSo_Ct.Text = Strings.Right("00000000" & So_hoadon, 8)
        TxtSo_HDDT.Text = Strings.Right("00000000" & So_hoadon, 8)
        TxtSo_Seri.Text = Seri_hoadon
        TxtNoteHDDT.Text = "Hóa đơn điện tử số " + Strings.Right("00000000" & So_hoadon, 8) + " đã được phát hành"

    End Sub
    Private Sub CmdHuy_HDDT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        'Check phân quyền
        Dim dsCheck As New DataSet
        dsCheck = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Chk_HDDT ", M_Ma_CT.Trim + "#" + M_Stt_Rec.Trim + "#U" + "#" + M_User_Name.Trim + "#" + M_Ma_Dvcs.Trim)

        If dsCheck.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then
            MsgBox(dsCheck.Tables(0).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
            If dsCheck.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
                dsCheck.Dispose()
                Exit Sub
            End If
        End If

        If MsgBox("Bạn chắc chắn muốn hủy hóa đơn điện tử?", MsgBoxStyle.YesNo, osysvar("M_CYBER_VER")) <> MsgBoxResult.Yes Then Return
        '--==========================================================
        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO", "H#" + M_Stt_Rec.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)

        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If
        Dim _postapi As New Cyber.PostAPIInvoiceVNPT.supportInvoiceVNPT
        Dim dsReturn As DataSet = _postapi.V_HuyHoaDon(DsData.Tables(1).Rows(0))

        If dsReturn.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(dsReturn.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If
        '==================================================
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIInvoice_UPDATE", M_Stt_Rec.Trim + "#" + TxtStt_Rec_TT.Text + "#" + M_Ma_CT.Trim + "#H####" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim)
        TxtNoteHDDT.Text = "Hóa đơn điện tử đã hủy"

    End Sub
#End Region
#End Region
    Dim ProccessList As New Collection
    Private Sub KillProce()
        Try
            Dim op As Process
            For i As Integer = ProccessList.Count To 1 Step -1
                op = ProccessList(i)
                If Not op Is Nothing Then
                    If Not op.HasExited() Then
                        op.Kill()
                        ProccessList.Remove(i)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
    Private Function V_Get_Print_Name(ByVal _return_fr As Boolean) As String
        Dim prtdoc As PrintDocument = New PrintDocument()
        Dim strPrintName_Return As String = ""
        Dim strDefaultPrinter As String = prtdoc.PrinterSettings.PrinterName

        If _return_fr = True Then
            Return strDefaultPrinter
        End If
        strPrintName_Return = strDefaultPrinter

        Return strPrintName_Return
    End Function

#Region "Hóa đơn điện tử"
    Private Sub V_Tao_HD_Nhap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Loai As String = "T"

        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If
        If MessageBox.Show("Bạn chắc chắn muốn tạo hóa đơn nháp!", M_CYBER_VER, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value

        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")

        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)

        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim

        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO_BKAV", M_Stt_Rec & "#00#" & _Loai & "#" & _Ma_GD & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        Dim sGUID = "", InvoiceNo = "", msg As String = ""
        Dim dtRetun As DataTable = HDBkav.Tao_Hoa_Don100(DsData, sGUID, InvoiceNo, msg)

        If dtRetun Is Nothing Then
            MsgBox(msg, MsgBoxStyle.Critical, osysvar("M_CYBER_VER"))
            Return
        End If

        'If DsData.Tables(1).Rows(0)("So_HDDT").ToString.Trim = "" Then
        If dtRetun.Rows(0)("InvoiceGUID") <> "" Then
            Txtma_tra_cuu.Text = dtRetun.Rows(0)("InvoiceGUID")
            txtInvoiceGUID.Text = dtRetun.Rows(0)("InvoiceGUID")

            Dt_Master.Rows(0).Item("Ma_Tra_Cuu") = TxtMa_Tra_Cuu.Text
            Dt_Master.Rows(0).Item("InvoiceGUID") = txtInvoiceGUID.Text
        End If

        Dim _So_HDDT As String = ""
        Dim _So_Seri As String = ""
        Dim _Ngay_CTHD As Date = New Date(1900, 1, 1)
        Dim _Ma_Tra_Cuu As String = dtRetun.Rows(0)("InvoiceGUID")
        Dim _InvoiceGUID As String = dtRetun.Rows(0)("InvoiceGUID")
        Dim _Mau_So As String = ""
        Dim _DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APISaveInvoice", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _InvoiceGUID & "#" & _So_HDDT & "#" & _So_Seri & "#" & _Ngay_CTHD.ToString("yyyyMMdd") & "#" & _Mau_So & "#" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)

        If _DsSave.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
    End Sub
    Private Sub V_Update_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Loai As String = "U"
        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If
        If MessageBox.Show("Bạn chắc chắn muốn update thông tin!", M_CYBER_VER, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value

        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")

        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)

        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim

        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO_BKAV", M_Stt_Rec & "#00#" & _Loai & "#" & _Ma_GD & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        Dim sGUID = "", InvoiceNo = "", msg As String = ""
        Dim dtRetun As DataTable = HDBkav.Cap_Nhap_thong_Tin_Hoa_Don(DsData, msg)
        If String.IsNullOrEmpty(msg) = False Then
            MsgBox(msg)
            Return
        End If
        If dtRetun Is Nothing Then
            MsgBox(msg, MsgBoxStyle.Critical, osysvar("M_CYBER_VER"))
            Return
        End If

        If DsData.Tables(1).Rows(0)("So_HDDT").ToString.Trim = "" Then

            Txtma_tra_cuu.Text = dtRetun.Rows(0)("InvoiceGUID")
            txtInvoiceGUID.Text = dtRetun.Rows(0)("InvoiceGUID")


            Dt_Master.Rows(0).Item("Ma_Tra_Cuu") = TxtMa_Tra_Cuu.Text
            Dt_Master.Rows(0).Item("InvoiceGUID") = txtInvoiceGUID.Text
        End If

        Dim _So_HDDT As String = ""
        Dim _So_Seri As String = ""
        Dim _Ngay_CTHD As Date = New Date(1900, 1, 1)
        Dim _Ma_Tra_Cuu As String = dtRetun.Rows(0)("InvoiceGUID")
        Dim _InvoiceGUID As String = dtRetun.Rows(0)("InvoiceGUID")
        Dim _Mau_So As String = ""
        Dim _DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APISaveInvoice", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _InvoiceGUID & "#" & _So_HDDT & "#" & _So_Seri & "#" & _Ngay_CTHD.ToString("yyyyMMdd") & "#" & _Mau_So & "#" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)

        If _DsSave.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
    End Sub
    Private Sub V_PH_HDDT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtInvoiceGUID.Text = "" Then 'Phát hành hóa đơn
            MsgBox("Bạn phải phát hành hóa đơn nháp trước")
            Return
        End If
        Dim _Loai As String = "P"
        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If
        If MessageBox.Show("Bạn chắc chắn phát hành hóa đơn điện tử!", M_CYBER_VER, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value

        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")
        'MsgBox(_PartnerGUID & "#" & _PartnerToken & "#" & _Mode)
        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)

        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim

        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APIGetDataToInvoiceTAO_BKAV", M_Stt_Rec & "#00#" & _Loai & "#" & _Ma_GD & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
        If DsData.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(DsData.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If

        Dim _InvoiceGUID0 As String = DsData.Tables(1).Rows(0).Item("InvoiceGUID")

        'If _InvoiceGUID0 = "" Then 'Phát hành hóa đơn
        If _InvoiceGUID0 = "" Then 'Phát hành hóa đơn
            MsgBox("Bạn phải phát hành hóa đơn nháp trước")
            Return
            Dim sGUID = "", InvoiceNo = "", msg As String = ""
            'Dim dtRetun As DataTable = HDBkav.Tao_Hoa_Don111(DsData, sGUID, InvoiceNo, msg)
            Dim dtRetun As DataTable = HDBkav.Tao_Hoa_Don101(DsData, sGUID, InvoiceNo, msg)
            If dtRetun Is Nothing Then
                MsgBox(msg, MsgBoxStyle.Critical, osysvar("M_CYBER_VER"))
                Return
            End If

            If DsData.Tables(1).Rows(0)("So_HDDT").ToString.Trim = "" Then
                TxtSo_HDDT.Text = Strings.Right("0000000" & dtRetun.Rows(0)("InvoiceNo"), 7)
                TxtSo_seriHD.Text = dtRetun.Rows(0)("InvoiceSerial")
                TxtMau_VATHD.Text = dtRetun.Rows(0)("InvoiceForm")
                Txtma_tra_cuu.Text = dtRetun.Rows(0)("InvoiceGUID")
                txtInvoiceGUID.Text = dtRetun.Rows(0)("InvoiceGUID")
                Dt_Master.Rows(0).Item("So_HDDT") = TxtSo_HDDT.Text
                Dt_Master.Rows(0).Item("So_Seri") = TxtSo_seriHD.Text
                Dt_Master.Rows(0).Item("Ngay_CTHD") = TxtNgay_CtHD.Value
                Dt_Master.Rows(0).Item("Mau_VATHD") = TxtMau_VATHD.Text
                Dt_Master.Rows(0).Item("Ma_Tra_Cuu") = TxtMa_Tra_Cuu.Text
                Dt_Master.Rows(0).Item("InvoiceGUID") = txtInvoiceGUID.Text
            End If

            Dim _So_HDDT As String = Strings.Right("0000000" & dtRetun.Rows(0)("InvoiceNo"), 7)
            Dim _So_Seri As String = dtRetun.Rows(0)("InvoiceSerial")

            'Dim _Ngay_CTHD As Date = dtRetun.Rows(0)("InvoiceDate")
            Dim _Ngay_CTHD As DateTime = TxtNgay_Ct.Value

            Dim _InvoiceGUID As String = dtRetun.Rows(0)("InvoiceGUID")
            Dim _Mau_So As String = dtRetun.Rows(0)("InvoiceForm")
            Dim _Ma_Tra_Cuu As String = dtRetun.Rows(0)("InvoiceGUID")
            Dim _DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APISaveInvoice", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _InvoiceGUID & "#" & _So_HDDT & "#" & _So_Seri & "#" & _Ngay_CTHD.ToString("yyyyMMdd") & "#" & _Mau_So & "#" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)

            If _DsSave.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
                MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
                Return
            End If
            MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
            '-- đẩy ký hóa đơn
            Dim msgKyHoaDon As String = HDBkav.Ky_Hoa_Don(_InvoiceGUID)
            If String.IsNullOrEmpty(msgKyHoaDon) = False Then
                MsgBox("Lỗi: " + msgKyHoaDon)
            End If
        Else
            'Ký hóa đơn nháp
            Dim msgKyHoaDon As String = HDBkav.Ky_Hoa_Don(_InvoiceGUID0)
            If String.IsNullOrEmpty(msgKyHoaDon) = False Then
                MsgBox("Lỗi: " + msgKyHoaDon)
            Else
                Dim _So_HDDT1 As String = ""
                Dim _So_SeriHD1 As String = ""

                'CuongNH: Cho delay 11s vì cơ chế của BKAV sau 11s thì mới nhận được số hóa đơn nếu là ký
                Threading.Thread.Sleep(11000)

                HDBkav.Lay_Thong_Tin_HD800(txtInvoiceGUID.Text.Trim, _So_HDDT1, _So_SeriHD1, msgKyHoaDon)
                If String.IsNullOrEmpty(msgKyHoaDon) = False Then
                    MsgBox("Lỗi thông tin HD" + msgKyHoaDon)
                    Return
                End If

                'Update dữ liệu
                _So_HDDT1 = Strings.Right("0000000" & _So_HDDT1, 7)

                TxtSo_HDDT.Text = _So_HDDT1
                TxtSo_seriHD.Text = _So_SeriHD1

                Dt_Master.Rows(0).Item("So_HDDT") = TxtSo_HDDT.Text
                Dt_Master.Rows(0).Item("So_Seri") = TxtSo_seriHD.Text

                Dim _Ngay_CTHD As Date = New Date(1900, 1, 1) 'dtRetun.Rows(0)("InvoiceDate")
                Dim _DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APISaveInvoice", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _InvoiceGUID0 & "#" & _So_HDDT1 & "#" & _So_SeriHD1 & "#" & _Ngay_CTHD.ToString("yyyyMMdd") & "##" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)

                If _DsSave.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
                    MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
                    Return
                End If
                MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
            End If
        End If
    End Sub
    Private Sub V_Lay_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtInvoiceGUID.Text.Trim = "" Then Exit Sub

        Dim _Loai As String = "L"
        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value

        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")


        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)
        Dim _So_HDDT As String = ""
        Dim _So_SeriHD As String = ""
        Dim _Ngay_CTHD As Date = New Date(1900, 1, 1)
        Dim _Lay_TT_HD As String = ""

        HDBkav.Lay_Thong_Tin_HD8001(txtInvoiceGUID.Text.Trim, _So_HDDT, _So_SeriHD, _Ngay_CTHD, _Lay_TT_HD)
        If String.IsNullOrEmpty(_Lay_TT_HD) = False Then
            MsgBox("Lỗi thông tin HD" + _Lay_TT_HD)
            Return
        End If
        'Update dữ liệu
        _So_HDDT = Strings.Right("00000000" & _So_HDDT, 8)
        TxtSo_HDDT.Text = _So_HDDT
        TxtSo_seriHD.Text = _So_SeriHD
        'TxtSo_Ct.Text = _So_HDDT
        TxtNgay_CtHD.Value = _Ngay_CTHD
        Dt_Master.Rows(0).Item("So_HDDT") = TxtSo_HDDT.Text
        Dt_Master.Rows(0).Item("So_Seri") = TxtSo_seriHD.Text
        Dt_Master.Rows(0).Item("Ngay_CtHD") = _Ngay_CTHD

        'Lưu thông tin vào database
        'Dim _Ngay_CTHD As Date = dtRetun.Rows(0)("InvoiceDate")
        Dim _DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_APISaveInvoice", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & txtInvoiceGUID.Text.Trim & "#" & _So_HDDT & "#" & _So_SeriHD & "#" & _Ngay_CTHD.ToString("yyyyMMdd") & "##" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim)

        If _DsSave.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper <> "Y" Then
            MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_Cyber_Ver"))
            Return
        End If
        MsgBox(_DsSave.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
    End Sub


    Private Sub V_View_HDDT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Loai As String = "V"
        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value
        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If
        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""
        Dim _Domain As String = ""
        Dim _PartnerInvoiceStringID As String = ""
        Dim _PartPDF As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")

        If _DsInfoAPI.Tables(0).Columns.Contains("Domain") Then _Domain = _DsInfoAPI.Tables(0).Rows(0).Item("Domain")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerInvoiceStringID") Then _PartnerInvoiceStringID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerInvoiceStringID")
        'Dim sys As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)
        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)
        Dim _So_HDDT As String = ""
        Dim _So_SeriHD As String = ""
        Dim _MTC As String = ""
        Dim _Lay_TT_HD As String = ""

        HDBkav.Lay_Thong_Tin_HD800WEB(txtInvoiceGUID.Text.Trim, _So_HDDT, _So_SeriHD, _MTC, _Lay_TT_HD)
        If String.IsNullOrEmpty(_Lay_TT_HD) = False Then
            MsgBox("Lỗi thông tin HD" + _Lay_TT_HD)
            Return
        End If
        Dim sGUID = "", InvoiceNo = "", msg As String = ""
        Process.Start("https://van.ehoadon.vn/TCHD?MTC=" + _MTC)

    End Sub
    Private Sub V_View_HDDTPDF(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Loai As String = "V"
        If Not V_ChkRightsHDDT(_Loai) Then
            Exit Sub
        End If

        Dim _Dt As DateTime = TxtNgay_Ct.Value
        Dim _DsInfoAPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoAPIInvoice", _Loai & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        If _DsInfoAPI.Tables.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If
        If _DsInfoAPI.Tables(0).Rows.Count < 1 Then
            _DsInfoAPI.Dispose()
            Exit Sub
        End If

        Dim _PartnerGUID As String = ""
        Dim _PartnerToken As String = ""
        Dim _Mode As String = ""
        Dim _Domain As String = ""
        Dim _PartnerInvoiceStringID As String = ""
        Dim _PartPDF As String = ""

        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerGUID") Then _PartnerGUID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerGUID")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerToken") Then _PartnerToken = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerToken")
        If _DsInfoAPI.Tables(0).Columns.Contains("Mode") Then _Mode = _DsInfoAPI.Tables(0).Rows(0).Item("Mode")

        If _DsInfoAPI.Tables(0).Columns.Contains("Domain") Then _Domain = _DsInfoAPI.Tables(0).Rows(0).Item("Domain")
        If _DsInfoAPI.Tables(0).Columns.Contains("PartnerInvoiceStringID") Then _PartnerInvoiceStringID = _DsInfoAPI.Tables(0).Rows(0).Item("PartnerInvoiceStringID")
        'Dim sys As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)
        Dim HDBkav As New HDBAKVV01.Sys(_PartnerGUID, _PartnerToken, _Mode)
        Dim sGUID = "", InvoiceNo = "", msg As String = ""



        '_PartPDF = HDBkav.Lay_LinkPDF(txtInvoiceGUID.Text.Trim, TxtSo_HDDT.Text.Trim, TxtSo_SeriHD.Text.Trim, msg)
        _PartPDF = HDBkav.Lay_LinkPDF(txtInvoiceGUID.Text.Trim, "", "C26STS", msg)

        If _DsInfoAPI.Tables(0).Columns.Contains("Domain") Then _Domain = _DsInfoAPI.Tables(0).Rows(0).Item("Domain")
        msg = HDBkav.ViewHoaDonPDF(_Domain, _PartPDF)
        If String.IsNullOrEmpty(msg) = False Then
            MsgBox(msg)
        End If
    End Sub
    Private Function V_ChkRightsHDDT(ByRef _Loai As String) As Boolean
        Dim _Return As Boolean = True
        Dim _StrPara As String = M_Ma_CT.Trim & "#" & M_Stt_Rec.Trim & "#" & _Loai & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name.Trim
        Dim _DsRight As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Chk_HDDT", _StrPara)
        If Not CyberSupport.V_MsgChk(_DsRight.Tables(0), SysVar, M_LAN) Then
            _DsRight.Dispose()
            _Return = False
        End If
        Return _Return
    End Function
#End Region
End Class
