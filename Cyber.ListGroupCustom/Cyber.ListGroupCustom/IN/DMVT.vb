Public Class DMVT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMVT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        If Me.Mode = "M" Then
            TxtNgay_HL_Gia.Value = Now.Date
        End If

        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Vt, TxtNh_Vt1, TxtNh_Vt2, TxtNh_Vt3, TxtNh_Vt4, TxtNh_Vt5)

        TxtNh_Vt1.ReadOnly = False
        TxtNh_Vt2.ReadOnly = False
        TxtTk_Vt.Enabled = False
        TxtTk_Dt.Enabled = False
        TxtTk_Gv.Enabled = False
        TxtTk_Ck.Enabled = False
        TxtTk_CL_VT.Enabled = False
        TxtTk_Dt_NB.Enabled = False
        TxtTk_SPDD.Enabled = False
        TxtTk_TL.Enabled = False
        TxtMa_TTCP.Enabled = False
        If Mode = "S" Then
            Dim DsTmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SuaDMVT_TK", TxtMa_Vt.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            If DsTmp1.Tables(0).Rows(0).Item("Sua_TK") = 0 Then
                TxtNh_Vt1.ReadOnly = True
                TxtNh_Vt2.ReadOnly = True
                TxtMa_Vt.Focus()

            End If

        End If
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_Vt1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vt1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vt2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vt2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vt3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vt3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vt4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Vt4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Vt5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Vt5.Text.Trim + "')", CyberSmlib)

        If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)

        If TxtMa_HangXe.Text.Trim = "" Then TxtTen_HangXe.Text = "" Else TxtTen_HangXe.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_hangxe", "Dmhangxe", "(Ma_Hangxe = N'" + TxtMa_HangXe.Text.Trim + "')", CyberSmlib)

        If TxtTk_Vt.Text.Trim = "" Then TxtTen_Tk_Vt.Text = "" Else TxtTen_Tk_Vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Vt.Text.Trim + "')", CyberSmlib)
        If TxtTk_Gv.Text.Trim = "" Then TxtTen_Tk_Gv.Text = "" Else TxtTen_Tk_Gv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Gv.Text.Trim + "')", CyberSmlib)
        If TxtTk_Dt.Text.Trim = "" Then TxtTen_Tk_Dt.Text = "" Else TxtTen_Tk_Dt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Dt.Text.Trim + "')", CyberSmlib)

        If TxtTk_Dt_NB.Text.Trim = "" Then TxtTen_Tk_Dt_NB.Text = "" Else TxtTen_Tk_Dt_NB.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Dt_NB.Text.Trim + "')", CyberSmlib)
        If TxtTk_TL.Text.Trim = "" Then TxtTen_Tk_TL.Text = "" Else TxtTen_Tk_TL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_TL.Text.Trim + "')", CyberSmlib)
        If TxtTk_SPDD.Text.Trim = "" Then TxtTen_Tk_SPDD.Text = "" Else TxtTen_Tk_SPDD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_SPDD.Text.Trim + "')", CyberSmlib)
        If TxtTk_CL_VT.Text.Trim = "" Then TxtTen_Tk_CL_VT.Text = "" Else TxtTen_Tk_CL_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_CL_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck.Text.Trim = "" Then TxtTen_Tk_Ck.Text = "" Else TxtTen_Tk_Ck.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then CmbVt_Ton_kho.SelectedValue = "1"
        If Me.Mode = "M" Then CmbGia_Ton.SelectedValue = "1"
        If Me.Mode = "M" Then CmbSua_Tk_Vt.SelectedValue = "0"

        If CmbVt_Ton_kho.Text.Trim = "" Then CmbVt_Ton_kho.SelectedValue = "1"
        If CmbGia_Ton.Text.Trim = "" Then CmbGia_Ton.SelectedValue = "1"
        If CmbSua_Tk_Vt.Text.Trim = "" Then CmbSua_Tk_Vt.SelectedValue = "0"
        If Mode = "M" Then
            TxtMa_Thue.Text = "08"
            TxtThue_Suat.Text = 8
        End If

        'If TxtMa_Thue.Tex
        ''t.Trim = "" Then TxtMa_Thue.Text = "10"
        'If TxtMa_Thue.Text = "10" Then TxtThue_Suat.Text = 10
        'If TxtMa_Thue.Text = "08" Then TxtThue_Suat.Text = 8
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Vt.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Vt.KeyPress, AddressOf TxtCodeError_KeyPress

        'Nh_Vt1
        RemoveHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        RemoveHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        'Nh_Vt2
        RemoveHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        RemoveHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        'Nh_Vt3
        RemoveHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        RemoveHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        'Nh_Vt4
        RemoveHandler TxtNh_Vt4.CyberValiting, AddressOf V_Nh_Vt4
        RemoveHandler TxtNh_Vt4.CyberLeave, AddressOf L_Nh_Vt4
        AddHandler TxtNh_Vt4.CyberValiting, AddressOf V_Nh_Vt4
        AddHandler TxtNh_Vt4.CyberLeave, AddressOf L_Nh_Vt4
        'Nh_Vt5
        RemoveHandler TxtNh_Vt5.CyberValiting, AddressOf V_Nh_Vt5
        RemoveHandler TxtNh_Vt5.CyberLeave, AddressOf L_Nh_Vt5
        AddHandler TxtNh_Vt5.CyberValiting, AddressOf V_Nh_Vt5
        AddHandler TxtNh_Vt5.CyberLeave, AddressOf L_Nh_Vt5
        'Ma_Kho
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        'Tk_Vt
        RemoveHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        RemoveHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        AddHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        AddHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        'Tk_Gv
        RemoveHandler TxtTk_Gv.CyberValiting, AddressOf V_Tk_Gv
        RemoveHandler TxtTk_Gv.CyberLeave, AddressOf L_Tk_Gv
        AddHandler TxtTk_Gv.CyberValiting, AddressOf V_Tk_Gv
        AddHandler TxtTk_Gv.CyberLeave, AddressOf L_Tk_Gv
        'Tk_Dt
        RemoveHandler TxtTk_Dt.CyberValiting, AddressOf V_Tk_Dt
        RemoveHandler TxtTk_Dt.CyberLeave, AddressOf L_Tk_Dt
        AddHandler TxtTk_Dt.CyberValiting, AddressOf V_Tk_Dt
        AddHandler TxtTk_Dt.CyberLeave, AddressOf L_Tk_Dt
        'Tk_Dt_NB
        RemoveHandler TxtTk_Dt_NB.CyberValiting, AddressOf V_Tk_Dt_NB
        RemoveHandler TxtTk_Dt_NB.CyberLeave, AddressOf L_Tk_Dt_NB
        AddHandler TxtTk_Dt_NB.CyberValiting, AddressOf V_Tk_Dt_NB
        AddHandler TxtTk_Dt_NB.CyberLeave, AddressOf L_Tk_Dt_NB
        'Tk_TL
        RemoveHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        RemoveHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        AddHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        AddHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        'Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD
        'Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        'Tk_CK
        RemoveHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        RemoveHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        AddHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        AddHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        'Ma_Thue
        RemoveHandler TxtMa_Thue.CyberValiting, AddressOf V_Ma_Thue
        RemoveHandler TxtMa_Thue.CyberLeave, AddressOf L_Ma_Thue
        AddHandler TxtMa_Thue.CyberValiting, AddressOf V_Ma_Thue
        AddHandler TxtMa_Thue.CyberLeave, AddressOf L_Ma_Thue
        'Ma_TTLN
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        'Ma_Hang
        RemoveHandler TxtMa_HangXe.CyberValiting, AddressOf V_Ma_Hangxe
        RemoveHandler TxtMa_HangXe.CyberLeave, AddressOf L_Ma_Hangxe
        AddHandler TxtMa_HangXe.CyberValiting, AddressOf V_Ma_Hangxe
        AddHandler TxtMa_HangXe.CyberLeave, AddressOf L_Ma_Hangxe
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtTon_kho As New DataTable
        Dim DtGia_Ton As New DataTable
        Dim DtTSua_Tk_Vt As New DataTable

        DtTon_kho.Columns.Add("Vt_Ton_kho", GetType(String))
        DtTon_kho.Columns.Add("Ten", GetType(String))
        DtTon_kho.Rows.Add("1", IIf(M_LAN = "V", "Theo dõi tồn kho", "Inventory"))
        DtTon_kho.Rows.Add("0", IIf(M_LAN = "V", "Không theo dõi tồn kho", "No inventory"))
        CyberFill.V_FillComBoxDefaul(Me.CmbVt_Ton_kho, DtTon_kho, "Vt_Ton_kho", "Ten")
        '---
        DtGia_Ton.Columns.Add("Gia_Ton", GetType(String))
        DtGia_Ton.Columns.Add("Ten", GetType(String))
        DtGia_Ton.Rows.Add("1", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân", "Average price"))
        DtGia_Ton.Rows.Add("2", IIf(M_LAN = "V", "Tính theo phương pháp giá đích danh", "First in first out price - FIFO"))
        DtGia_Ton.Rows.Add("3", IIf(M_LAN = "V", "Tính theo phương pháp giá nhập trước xuất trước", "Average price"))
        DtGia_Ton.Rows.Add("4", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân ngày", "Average daily price"))
        CyberFill.V_FillComBoxDefaul(Me.CmbGia_Ton, DtGia_Ton, "Gia_Ton", "Ten")
        '---
        DtTSua_Tk_Vt.Columns.Add("Sua_Tk_Vt", GetType(String))
        DtTSua_Tk_Vt.Columns.Add("Ten", GetType(String))
        DtTSua_Tk_Vt.Rows.Add("1", IIf(M_LAN = "V", "Được sửa tài khoản tồn kho", "Account is correct warehouse"))
        DtTSua_Tk_Vt.Rows.Add("0", IIf(M_LAN = "V", "Không được sửa tài khoản tồn kho", "Account is not correct warehouse"))
        CyberFill.V_FillComBoxDefaul(Me.CmbSua_Tk_Vt, DtTSua_Tk_Vt, "Sua_Tk_Vt", "Ten")
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Vt1"
    Private Sub V_UpdateTk(ByVal _Dr As DataRow)
        If _Dr Is Nothing Then Exit Sub
        '    If TxtNh_Vt1.Text = "01" Then
        '        If _Dr.Table.Columns.Contains("Ma_Kho") Then If Not _Dr.Item("Ma_Kho").ToString.Trim = "" Then TxtMa_Kho.Text = _Dr.Item("Ma_Kho").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Vt") Then If Not _Dr.Item("Tk_Vt").ToString.Trim = "" Then TxtTk_Vt.Text = _Dr.Item("Tk_Vt").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Gv") Then If Not _Dr.Item("Tk_Gv").ToString.Trim = "" Then TxtTk_Gv.Text = _Dr.Item("Tk_Gv").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Dt") Then If Not _Dr.Item("Tk_Dt").ToString.Trim = "" Then TxtTk_Dt.Text = _Dr.Item("Tk_Dt").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Dt_NB") Then If Not _Dr.Item("Tk_Dt_NB").ToString.Trim = "" Then TxtTk_Dt_NB.Text = _Dr.Item("Tk_Dt_NB").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_TL") Then If Not _Dr.Item("Tk_TL").ToString.Trim = "" Then TxtTk_TL.Text = _Dr.Item("Tk_TL").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_CL_VT") Then If Not _Dr.Item("Tk_CL_VT").ToString.Trim = "" Then TxtTk_CL_VT.Text = _Dr.Item("Tk_CL_VT").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_SPDD") Then If Not _Dr.Item("Tk_SPDD").ToString.Trim = "" Then TxtTk_SPDD.Text = _Dr.Item("Tk_SPDD").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_CK") Then If Not _Dr.Item("Tk_CK").ToString.Trim = "" Then TxtTk_Ck.Text = _Dr.Item("Tk_CK").ToString.Trim
        '    End If
        '    If TxtNh_Vt1.Text = "02" Then
        '        If _Dr.Table.Columns.Contains("Ma_Kho") Then If Not _Dr.Item("Ma_Kho").ToString.Trim = "" Then TxtMa_Kho.Text = _Dr.Item("Ma_Kho").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Vt1") Then If Not _Dr.Item("Tk_Vt1").ToString.Trim = "" Then TxtTk_Vt.Text = _Dr.Item("Tk_Vt1").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Gv1") Then If Not _Dr.Item("Tk_Gv1").ToString.Trim = "" Then TxtTk_Gv.Text = _Dr.Item("Tk_Gv1").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Dt1") Then If Not _Dr.Item("Tk_Dt1").ToString.Trim = "" Then TxtTk_Dt.Text = _Dr.Item("Tk_Dt1").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_Dt_NB") Then If Not _Dr.Item("Tk_Dt_NB").ToString.Trim = "" Then TxtTk_Dt_NB.Text = _Dr.Item("Tk_Dt_NB").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_TL") Then If Not _Dr.Item("Tk_TL").ToString.Trim = "" Then TxtTk_TL.Text = _Dr.Item("Tk_TL").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_CL_VT") Then If Not _Dr.Item("Tk_CL_VT").ToString.Trim = "" Then TxtTk_CL_VT.Text = _Dr.Item("Tk_CL_VT").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_SPDD1") Then If Not _Dr.Item("Tk_SPDD1").ToString.Trim = "" Then TxtTk_SPDD.Text = _Dr.Item("Tk_SPDD1").ToString.Trim
        '        If _Dr.Table.Columns.Contains("Tk_CK1") Then If Not _Dr.Item("Tk_CK1").ToString.Trim = "" Then TxtTk_Ck.Text = _Dr.Item("Tk_CK1").ToString.Trim
        '    End If
        If TxtNh_Vt1.Text = "01" Then

            If _Dr.Table.Columns.Contains("Ma_Kho") Then TxtMa_Kho.Text = _Dr.Item("Ma_Kho").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Vt") Then TxtTk_Vt.Text = _Dr.Item("Tk_Vt").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Gv") Then TxtTk_Gv.Text = _Dr.Item("Tk_Gv").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Dt") Then TxtTk_Dt.Text = _Dr.Item("Tk_Dt").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Dt_NB") Then TxtTk_Dt_NB.Text = _Dr.Item("Tk_Dt_NB").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_TL") Then TxtTk_TL.Text = _Dr.Item("Tk_TL").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_CL_VT") Then TxtTk_CL_VT.Text = _Dr.Item("Tk_CL_VT").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_SPDD") Then TxtTk_SPDD.Text = _Dr.Item("Tk_SPDD").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_CK") Then TxtTk_Ck.Text = _Dr.Item("Tk_CK").ToString.Trim
        End If
        If TxtNh_Vt1.Text = "02" Then
            If _Dr.Table.Columns.Contains("Ma_Kho") Then TxtMa_Kho.Text = _Dr.Item("Ma_Kho").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Vt1") Then TxtTk_Vt.Text = _Dr.Item("Tk_Vt1").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Gv1") Then TxtTk_Gv.Text = _Dr.Item("Tk_Gv1").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Dt1") Then TxtTk_Dt.Text = _Dr.Item("Tk_Dt1").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_Dt_NB") Then TxtTk_Dt_NB.Text = _Dr.Item("Tk_Dt_NB").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_TL") Then TxtTk_TL.Text = _Dr.Item("Tk_TL").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_CL_VT") Then TxtTk_CL_VT.Text = _Dr.Item("Tk_CL_VT").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_SPDD1") Then TxtTk_SPDD.Text = _Dr.Item("Tk_SPDD1").ToString.Trim
            If _Dr.Table.Columns.Contains("Tk_CK1") Then TxtTk_Ck.Text = _Dr.Item("Tk_CK1").ToString.Trim
        End If
        If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)

        If TxtMa_HangXe.Text.Trim = "" Then TxtTen_HangXe.Text = "" Else TxtTen_HangXe.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_hangxe", "Dmhangxe", "(Ma_Hangxe = N'" + TxtMa_HangXe.Text.Trim + "')", CyberSmlib)

        If TxtTk_Vt.Text.Trim = "" Then TxtTen_Tk_Vt.Text = "" Else TxtTen_Tk_Vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Vt.Text.Trim + "')", CyberSmlib)
        If TxtTk_Gv.Text.Trim = "" Then TxtTen_Tk_Gv.Text = "" Else TxtTen_Tk_Gv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Gv.Text.Trim + "')", CyberSmlib)
        If TxtTk_Dt.Text.Trim = "" Then TxtTen_Tk_Dt.Text = "" Else TxtTen_Tk_Dt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Dt.Text.Trim + "')", CyberSmlib)

        If TxtTk_Dt_NB.Text.Trim = "" Then TxtTen_Tk_Dt_NB.Text = "" Else TxtTen_Tk_Dt_NB.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Dt_NB.Text.Trim + "')", CyberSmlib)
        If TxtTk_TL.Text.Trim = "" Then TxtTen_Tk_TL.Text = "" Else TxtTen_Tk_TL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_TL.Text.Trim + "')", CyberSmlib)
        If TxtTk_SPDD.Text.Trim = "" Then TxtTen_Tk_SPDD.Text = "" Else TxtTen_Tk_SPDD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_SPDD.Text.Trim + "')", CyberSmlib)
        If TxtTk_CL_VT.Text.Trim = "" Then TxtTen_Tk_CL_VT.Text = "" Else TxtTen_Tk_CL_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_CL_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck.Text.Trim = "" Then TxtTen_Tk_Ck.Text = "" Else TxtTen_Tk_Ck.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck.Text.Trim + "')", CyberSmlib)

    End Sub
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vt1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vt1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
            'If TxtNh_Vt1.Text <> "" And TxtNh_Vt2.Text <> "" Then
            '    V_UpdateTk(DrReturn)
            'End If

        Else
            TxtNh_Vt1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vt2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vt2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
            If TxtNh_Vt1.Text <> "" And TxtNh_Vt2.Text <> "" Then
                V_UpdateTk(DrReturn)
            End If
        Else
            TxtNh_Vt2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vt3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vt3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
        
        Else
            TxtNh_Vt3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
      
    End Sub
#End Region
#Region "Vali --- Nh_Vt4"
    Private Sub V_Nh_Vt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vt4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Vt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vt4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
           
        Else
            TxtNh_Vt4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
 
    End Sub
#End Region
#Region "Vali --- Nh_Vt5"
    Private Sub V_Nh_Vt5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Vt5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Vt5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Vt5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Vt5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
            'If TxtNh_Vt1.Text <> "" And TxtNh_Vt2.Text <> "" Then
            '    V_UpdateTk(DrReturn)
            'End If
        Else
            TxtNh_Vt5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
 
    End Sub
#End Region
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_Kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DMMTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
#Region "Vali --- Ma_Hang"
    Private Sub V_Ma_Hangxe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HangXe.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hangxe", "Dmhangxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hangxe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_HangXe.Text = "" Then
            TxtTen_HangXe.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HangXe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HangXe.Text = DrReturn.Item("Ma_Hangxe")
            TxtTen_HangXe.Text = DrReturn.Item("Ten_hangxe")
        Else
            TxtMa_HangXe.Text = ""
            TxtTen_HangXe.Text = ""
        End If
    End Sub
    'Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TxtMa_Vt.Text = "" Then
    '        TxtTen_Vt.Text = ""
    '        Exit Sub
    '    End If

    '    Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "SELECT TOP 1 Ten_vt FROM dbo.Dmvttmv WHERE Ma_vt = '" + TxtMa_Vt.Text + "'#" + M_Ma_Dvcs + "#" + M_User_Name)
    '    If Not Dstmp Is Nothing Then
    '        If Dstmp.Tables(0).Rows.Count > 0 Then TxtTen_Vt.Text = Dstmp.Tables(0).Rows(0).Item("Ten_Vt")
    '    Else
    '        TxtTen_Vt.Text = ""
    '    End If
    'End Sub
#End Region
#Region "Vali --- Tk_Vt"
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Vt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Vt.Text = "" Then
            TxtTen_Tk_Vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Vt.Text = DrReturn.Item("TK")
            TxtTen_Tk_Vt.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Vt.Text = ""
            TxtTen_Tk_Vt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_Gv"
    Private Sub V_Tk_Gv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Gv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Gv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Gv.Text = "" Then
            TxtTen_Tk_Gv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Gv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Gv.Text = DrReturn.Item("TK")
            TxtTen_Tk_Gv.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Gv.Text = ""
            TxtTen_Tk_Gv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_Dt"
    Private Sub V_Tk_Dt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Dt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Dt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Dt.Text = "" Then
            TxtTen_Tk_Dt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Dt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Dt.Text = DrReturn.Item("TK")
            TxtTen_Tk_Dt.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Dt.Text = ""
            TxtTen_Tk_Dt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_Dt_NB"
    Private Sub V_Tk_Dt_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Dt_NB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Dt_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Dt_NB.Text = "" Then
            TxtTen_Tk_Dt_NB.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Dt_NB.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Dt_NB.Text = DrReturn.Item("TK")
            TxtTen_Tk_Dt_NB.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Dt_NB.Text = ""
            TxtTen_Tk_Dt_NB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_TL"
    Private Sub V_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_TL.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_TL.Text = "" Then
            TxtTen_Tk_TL.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_TL.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_TL.Text = DrReturn.Item("TK")
            TxtTen_Tk_TL.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_TL.Text = ""
            TxtTen_Tk_TL.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_SPDD"
    Private Sub V_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_SPDD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_SPDD.Text = "" Then
            TxtTen_Tk_SPDD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_SPDD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_SPDD.Text = DrReturn.Item("TK")
            TxtTen_Tk_SPDD.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_SPDD.Text = ""
            TxtTen_Tk_SPDD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CL_VT"
    Private Sub V_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_CL_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_CL_VT.Text = "" Then
            TxtTen_Tk_CL_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_CL_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_CL_VT.Text = DrReturn.Item("TK")
            TxtTen_Tk_CL_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_CL_VT.Text = ""
            TxtTen_Tk_CL_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CK"
    Private Sub V_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ck.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ck.Text = "" Then
            TxtTen_Tk_Ck.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ck.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ck.Text = DrReturn.Item("TK")
            TxtTen_Tk_Ck.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ck.Text = ""
            TxtTen_Tk_Ck.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Thue"
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Thue.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_Thue", "Dmthue", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Thue.Text = "" Then
            TxtThue_Suat.Text = 0
            Exit Sub
        End If
        DrReturn = TxtMa_Thue.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Thue.Text = DrReturn.Item("ma_Thue")
            TxtThue_Suat.Text = DrReturn.Item("Thue_suat")
        Else
            TxtMa_Thue.Text = ""
            TxtThue_Suat.Text = 0
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "SELECT TOP 1 Ten_vt FROM dbo.Dmvttmv WHERE Ma_vt = '" + TxtMa_VT.Text + "'#" + M_Ma_Dvcs + "'#" + M_User_Name)
        'If Not Dstmp Is Nothing Then
        '    If TxtNh_Vt1.Text = "01" And Dstmp.Tables(0).Rows.Count <= 0 Then
        '        MsgBox("Mã vật tư chính hãng không có trong hệ thống!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, oSysvar("M_CYBER_VER"))
        '        Exit Sub
        '    End If
        '    If TxtNh_Vt1.Text <> "01" And Dstmp.Tables(0).Rows.Count > 0 Then
        '        MsgBox("Nhập sai mã vật tư ngoài hãng!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, oSysvar("M_CYBER_VER"))
        '        Exit Sub
        '    End If
        'End If
        TxtGia_NT.Double = TxtGia.Double
        TxtGia_NT2.Double = TxtGia2.Double
        If TxtNh_Vt1.Text = "01" And ChkIs_Auto.Checked Then
            If MsgBox(" Vật chính hãng bạn không tạo tự động được", MsgBoxStyle.YesNo, oSysvar("M_CYBER_VER")) <> MsgBoxResult.Yes Then Return
        End If
        If ChkIs_Auto.Checked Then
            Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
            If Not _Value.Trim = "" Then TxtMa_Vt.Text = _Value
        End If
      
        If TxtGia2.Double = 0 Then
            If MsgBox(" Vật tư chưa nhập giá bạn có lưu không?", MsgBoxStyle.YesNo, oSysvar("M_CYBER_VER")) <> MsgBoxResult.Yes Then Return
        End If

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
        Dim _Ma_vt As String = TxtMa_Vt.Text

        Dim Dt1 As Date = TxtNgay_HL_Gia.Value
        If Me.Mode = "M" Then
            Dim DsTmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CreateDmGia2FromDmvt", Dt1.ToString("yyyyMMdd") & "#" & _Ma_vt.ToString.Trim & "#" & TxtGia2.Double & "#" & TxtGia.Double & "#" & TxtGia_Min.Double & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        End If
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
