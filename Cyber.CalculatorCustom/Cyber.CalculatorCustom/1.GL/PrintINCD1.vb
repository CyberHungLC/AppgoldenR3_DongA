Imports System.Windows.Forms
Imports System.Drawing
Public Class PrintINCD1
#Region "Khai bao bien Property"
    Dim DtThang, DtNam, _DtGroupBy As New DataTable
    Dim DrReturn As DataRow
    Dim DsLookup, _DsTmp As New DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, Dt_Print As New DataTable
    Dim DvMaster, DvHeader As New DataView
    Dim _Tab_Boolean As Boolean = False
    Dim CyberColor As New Cyber.Color.Sys
#End Region
#Region "Columns Edit"
    Dim EditStt_Ds, EditStt_Tn, EditHo_tenV, EditHo_tenE, EditNgay_CT, EditNgay_SinhV As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditNgay_SinhE, EditGioi_TinhV, EditGioi_TinhE, EditXep_LoaiV, EditXep_LoaiE, EditNganh_TNV, EditNganh_TNE, EditTag As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
#End Region
#Region "V_Load"
    Private Sub InBLuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_GetColumn()
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Load()
        _DtGroupBy = GetGroupBy()
        CyberFill.V_FillComBoxDefaul(Me.cbbTinh_dc, _DtGroupBy, "Tinh_dc", "Ten_DC", "Ngam_Dinh")

        'Thời gian
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        TxtNgay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct1)
        TxtNgay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct2)
    End Sub
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function
    Private Sub V_GetColumn()
        EditTag.GetColumn(DetailGRV, "Tag")
    End Sub
#End Region
#Region "Handler..."
    Private Sub V_AddHandler()
        AddHandler CmdLoadData.Click, AddressOf V_LoadDatabase
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler BtnPrint.Click, AddressOf V_Print
        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        'Ma_Kho
        AddHandler CmdFiter_Kho.Click, AddressOf V_Filter_Kho
        'Ma_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        'Tk_Vt
        AddHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        AddHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        'Nh_Vt1
        RemoveHandler TxtNh_vt1.CyberValiting, AddressOf V_Nh_Vt1
        RemoveHandler TxtNh_vt1.CyberLeave, AddressOf L_Nh_Vt1
        AddHandler TxtNh_vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_vt1.CyberLeave, AddressOf L_Nh_Vt1
        'Nh_Vt2
        RemoveHandler TxtNh_vt2.CyberValiting, AddressOf V_Nh_Vt2
        RemoveHandler TxtNh_vt2.CyberLeave, AddressOf L_Nh_Vt2
        AddHandler TxtNh_vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_vt2.CyberLeave, AddressOf L_Nh_Vt2
        'Nh_Vt3
        RemoveHandler TxtNh_vt3.CyberValiting, AddressOf V_Nh_Vt3
        RemoveHandler TxtNh_vt3.CyberLeave, AddressOf L_Nh_Vt3
        AddHandler TxtNh_vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_vt3.CyberLeave, AddressOf L_Nh_Vt3
    End Sub
#End Region
#Region "Loading..data"
    Private Sub V_LoadDatabase(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_CT1 As Date = TxtNgay_Ct1.Value
        Dim _Ngay_CT2 As Date = TxtNgay_Ct2.Value
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_INCD1_OUT", IIf(ChkIs_Dm.Checked, "1", "0") + "#" + TxtMa_Kho.Text + "#" + TxtMa_Vt.Text + "#" + _Ngay_CT1.ToString("yyyyMMdd") + "#" + _Ngay_CT2.ToString("yyyyMMdd") + "#" + TxtTk_Vt.Text + "#" + TxtNh_vt1.Text + "#" + TxtNh_vt2.Text + "#" + TxtNh_vt3.Text + "#" + cbbTinh_dc.SelectedValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        tbMaster.Clear()
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        Dt_Print = DsData.Tables(2)

        DvHeader = New DataView(tbHeader)
        DvMaster = New DataView(tbMaster)
        CyberFill.V_FillReports(DetailGRV, M_LAN, DvHeader, DvMaster)
        DetailGRV.GridControl.DataSource = DvMaster
        V_SetProperty()
    End Sub
    Private Sub V_SetProperty()
        Dim FixCol As Integer = Dt_Print.Rows(0).Item("ColFozen")
        If FixCol < DetailGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        For Each clm As DevExpress.XtraGrid.Columns.GridColumn In DetailGRV.Columns
            clm.OptionsFilter.AllowFilter = True
            clm.OptionsFilter.AllowAutoFilter = True
            clm.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next
        DetailGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
#End Region
#Region "Export"
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        _Title = _Title.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, DetailGRV, _Dv_Title, DvMaster, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DvMaster.Count
        If iRow < 0 Then Exit Sub
        Dim _Ma_In, _Loai_In As String

        Dim Frm As New FrmPrintVT
        Frm.Dt_Print = Dt_Print
        Frm.Preview = True

        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        _Ma_In = Frm.Ma_IN
        _Loai_In = Frm.Loai_IN
        '----------------------------------------------------------------------------------
        Dim Print As New DataSet
        Dim DsPrint As New DataSet
        Dim CyberPrint As New Cyber.Print.Sys
        Dim printsetting As New Windows.Forms.PrintDialog
        If Frm.Loai_IN = "PRINT" Then
            Dim result As Windows.Forms.DialogResult = printsetting.ShowDialog()
            If Not result.ToString.ToUpper.Trim = "OK".ToUpper.Trim Then
                Exit Sub
            End If
        End If

        '--> Lưu lại bảng dữ liệu
        tbMaster.AcceptChanges()
        Dim Dt_TemTmp As DataTable = tbMaster.Clone
        Dim DrTem As DataRow() = tbMaster.Select("Tag = '1'")

        For i As Integer = 0 To DrTem.Length - 1
            Dt_TemTmp.ImportRow(DrTem(i))
        Next
        Dt_TemTmp.AcceptChanges()

        CyberSmodb.V_CyberSaveToSQL(AppConn, Sysvar, M_User_Name, Dt_TemTmp, "INBARCODE", "M", "1=1")

        DsPrint = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintINCD1", _Ma_In + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Sysvar, M_LAN) Then
            DsPrint.Dispose()
            Exit Sub
        End If

        Dim M_Reports As String = "INBARCODE"
        Dim M_Title1 As String = "IN TEM"
        Dim M_Title2 As String = "IN TEM"
        Dim Loai_Tien As Boolean = True
        Dim Ngon_ngu As Boolean = True


        If DsPrint.Tables(0).Columns.Contains("Repo_Name") Then M_Reports = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then M_Title1 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then M_Title2 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim

        Print = New DataSet
        For j = 1 To DsPrint.Tables.Count - 1
            Print.Tables.Add(DsPrint.Tables(j).Copy)
        Next
        CyberPrint.CyberPrintReportcustomer(Nothing, printsetting, AppConn, Frm.Loai_IN, M_Reports, Print, M_Title1, M_Title2, Sysvar, Me.Para, M_Ma_Dvcs)
        '----------------------------------------------------------------------------------
        DsPrint.Dispose()
        CyberSmlib.FlushMemorySave()
    End Sub
#End Region
#Region "Select All"
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If DvMaster.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To DvMaster.Count - 1
            DvMaster.Item(i).BeginEdit()
            If _Type Then DvMaster.Item(i).Item("Tag") = True Else DvMaster.Item(i).Item("Tag") = "1"
            If DvMaster.Item(i).Item("Bold") = "1" Or DvMaster.Item(i).Item("Ton_Cuoi") = "0" Then DvMaster.Item(i).Item("Tag") = False
            DvMaster.Item(i).EndEdit()
            DetailGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If DvMaster.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To DvMaster.Count - 1
            DvMaster.Item(i).BeginEdit()
            If _Type Then DvMaster.Item(i).Item("Tag") = False Else DvMaster.Item(i).Item("Tag") = "0"
            DvMaster.Item(i).EndEdit()
            DetailGRV.UpdateCurrentRow()
        Next
    End Sub
#End Region
#Region "Color"
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If tbMaster.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = tbMaster.Columns("Bold").ColumnName
            Dim _categoryBold As String = DetailGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If tbMaster.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = tbMaster.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = DetailGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                '-------------
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If tbMaster.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = tbMaster.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = DetailGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If

        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, tbMaster, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#Region "Valid"
#Region "Filter Ma_Kho"
    Private Sub V_Filter_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Str As String
        _Str = CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListSelect", "DmKho#" & TxtMa_Kho.Text.Trim & "##" & M_Ma_Dvcs & "#" & M_User_Name, Lan)
        If _Str Is Nothing Then Exit Sub

        TxtMa_kho.Text = _Str
    End Sub
#End Region
#Region "Valid --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---Tk_Vt"
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Vt.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Vt.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Vt.Text = ""
            TxtTen_Tk_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt1.Text = "" Then
            txtten_nh_vt1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt1.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt1.Text = ""
            txtten_nh_vt1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt2.Text = "" Then
            txtten_nh_vt2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt2.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt2.Text = ""
            txtten_nh_vt2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt3.Text = "" Then
            txtten_nh_vt3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt3.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_vt3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_vt3.Text = ""
            txtten_nh_vt3.Text = ""
        End If
    End Sub
#End Region
#End Region
End Class
