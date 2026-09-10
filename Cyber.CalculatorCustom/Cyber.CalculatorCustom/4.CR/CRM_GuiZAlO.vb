Imports System.Windows.Forms

Public Class CRM_GuiZalo
    Dim DrReturn As DataRow
    Dim DsData, DsLookup As DataSet
    Dim DtLoaiN As DataTable
    Dim DtLoaiCs As DataTable
    Dim M_Dien_Thoai As String = ""
    Public Property Dien_Thoai() As String
        Get
            Dien_Thoai = M_Dien_Thoai
        End Get
        Set(ByVal Value As String)
            M_Dien_Thoai = Value
        End Set
    End Property
    Dim M_Loai As String = "CR"
    Public Property Loai() As String
        Get
            Loai = M_Loai
        End Get
        Set(ByVal Value As String)
            M_Loai = Value
        End Set
    End Property
    Dim M_Ma_Loai As String = ""
    Public Property Ma_Loai() As String
        Get
            Ma_Loai = M_Ma_Loai
        End Get
        Set(ByVal Value As String)
            M_Ma_Loai = Value
        End Set
    End Property
    Dim M_Ma_SMS As String = ""
    Public Property Ma_SMS() As String
        Get
            Ma_SMS = M_Ma_SMS
        End Get
        Set(ByVal Value As String)
            M_Ma_SMS = Value
        End Set
    End Property
    Dim M_Ma_Get1 As String = ""
    Public Property Ma_Get1() As String
        Get
            Ma_Get1 = M_Ma_Get1
        End Get
        Set(ByVal Value As String)
            M_Ma_Get1 = Value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe() As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Private Sub CRM_SMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Addhander()
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler BtnLoc.Click, AddressOf V_Loc

        AddHandler TxtMa_SMS.CyberValiting, AddressOf V_Ma_SMS
        AddHandler TxtMa_SMS.CyberLeave, AddressOf L_Ma_SMS

        AddHandler TxtND1.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtND5.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_So_Tin_Nhan
        AddHandler TxtBody.TextChanged, AddressOf V_So_Tin_Nhan

        AddHandler TxtND1.TextChanged, AddressOf V_Ghep
        AddHandler TxtND5.TextChanged, AddressOf V_Ghep
        AddHandler TxtNoi_Dung.TextChanged, AddressOf V_Ghep

        AddHandler ChkM_Is_So_Ngay.CheckedChanged, AddressOf V_SetCheckbox
        AddHandler ChkM_Is_LoaiN.CheckedChanged, AddressOf V_SetCheckbox

        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2

        AddHandler TxtMa_ChienDich.CyberValiting, AddressOf V_Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberLeave, AddressOf L_Ma_ChienDich

        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll

        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler TxtSearch.TextChanged, AddressOf V_Search
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font)
    End Sub
    Private Sub V_Load()
        V_So_Tin_Nhan()

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct2)

        Me.CyberSmodb.GetValueToControler(Me)
        DtLoaiN = CreateTableLoaiN()
        CyberFill.V_FillComBoxDefaul(CbbM_LoaiN, DtLoaiN, "Ma_Ngay", "Ten_Ngay", "Ngam_Dinh")

        DtLoaiCs = CreateTableLoaiCs()
        CyberFill.V_FillComBoxDefaul(CbbLoai_Cs, DtLoaiCs, "CrmMa_Loai", "CrmTen_Loai", "Ngam_Dinh")

        Dim DtLoai As DataTable = CreateTableLoai()
        CyberFill.V_FillComBoxDefaul(CbbLoai, DtLoai, "Ma_Loai", "Ten_Loai", "Ngam_Dinh")

        V_SetCheckbox()
    End Sub
    Private Function CreateTableLoaiN() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_Ngay")
        _Return.Columns.Add("Ten_Ngay")
        _Return.Columns.Add("Ten_Ngay2")
        _Return.Columns.Add("Ngam_Dinh")
        Dim _Ma_Ngay As String = ""
        Dim _Default As String = "0"

        _Return.Rows.Add("", "--- Loại N", "select N Type", "0")
        For i As Integer = 1 To 24
            _Ma_Ngay = i.ToString.Trim
            If i = 8 Then _Default = 1 Else _Default = 0
            _Return.Rows.Add(_Ma_Ngay.ToString, "N" + _Ma_Ngay, "N" + _Ma_Ngay, _Default)
        Next
        CreateTableLoaiN = _Return
    End Function
    Private Function CreateTableLoaiCs() As DataTable
        Dim _LoaiCS As New DataTable
        _LoaiCS.Columns.Add("CrmMa_Loai")
        _LoaiCS.Columns.Add("CrmTen_Loai")
        _LoaiCS.Columns.Add("Ngam_Dinh")

        Dim _Loai_Cs As String = "....."
        _LoaiCS.Rows.Add("00", "", "1")
        _LoaiCS.Rows.Add("11", "Nhắc bảo dưỡng 1K", "0")
        _LoaiCS.Rows.Add("16", "Nhắc bảo dưỡng xe  ", "0")
        '_LoaiCS.Rows.Add("18", "Nhắc Noshow khách hàng bán xe", "0")
        _LoaiCS.Rows.Add("20", "Nhắc Noshow khách hàng dịch vụ ", "0")
        '_LoaiCS.Rows.Add("26", "Nhắc khách hàng tái tục báo hiểm", "0")
        _LoaiCS.Rows.Add("28", "Nhắc gia hạn bảo hành  ", "0")
        _LoaiCS.Rows.Add("66", "Liên hệ khách hàng theo chiến dịch  ", "0")
        '_LoaiCS.Rows.Add("68", "Chăm sóc khách hàng hảo hiểm", "0")
        CreateTableLoaiCs = _LoaiCS
    End Function
    Private Function CreateTableLoai() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_Loai")
        _Return.Columns.Add("Ten_Loai")
        _Return.Columns.Add("Ten_Loai2")
        _Return.Columns.Add("Ngam_Dinh")
        Dim _Ma_Loai As String = ""
        Dim _Default As String = "0"

        _Return.Rows.Add("", "Tất cả", "All", "1")
        _Return.Rows.Add("01", "Chưa gửi", "", "0")
        _Return.Rows.Add("02", "Đã gửi", "Sent", "0")
        CreateTableLoai = _Return
    End Function
#Region "Valid"
    Private Sub V_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_SMS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Template_ID", "DmZaloTemplate", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_SMS.Text = "" Then
            TxtTen_SMS.Text = ""
            TxtNoi_Dung.Text = ""
            TxtND1.Text = ""
            TxtND5.Text = ""
            TxtBody.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_SMS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SMS.Text = DrReturn.Item("Template_ID")
            TxtTen_SMS.Text = DrReturn.Item("Ten_Template")
            TxtId_Zalo.Text = DrReturn.Item("Id_Zalo")
            TxtNoi_Dung.Text = DrReturn.Item("Noi_Dung")
            'TxtND5.Text = DrReturn.Item("ND5")
            V_Ghep()
            V_So_Tin_Nhan()
        Else
            TxtMa_SMS.Text = ""
            TxtTen_SMS.Text = ""
            TxtId_Zalo.Text = ""
            TxtNoi_Dung.Text = ""
            'TxtND5.Text = ""
            V_Ghep()
            V_So_Tin_Nhan()
        End If
    End Sub
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Nh_Kx2", "DmNhKx", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            TxtNh_Kx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            TxtNh_Kx2.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_ChienDich.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_ChienDich", "DmChienDich", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_ChienDich.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ChienDich.Text = DrReturn.Item("Ma_ChienDich")
            TxtTen_ChienDich.Text = DrReturn.Item("Ten_ChienDich")
            V_SetCheckbox()
        Else
            TxtMa_ChienDich.Text = ""
            TxtTen_ChienDich.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = True Else Dv_Master.Item(i).Item("Tag") = "1"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub LoadFilter()
        Dt_Filter0 = New DataTable
        Dt_Filter1 = New DataTable

        Dt_Filter1.Columns.Add("Field_Name")
        Dt_Filter1.Columns.Add("Field_Type")

        Dt_Filter0.Columns.Add("Ma")
        Dt_Filter0.Columns.Add("Ten")
        Dt_Filter0.Columns.Add("Default")

        Dim _Field_Name As String = ""
        Dim _Field_Head As String = ""
        Dim _Field_Type As String = ""
        Dt_Filter0.Rows.Add("", "Tất cả", "0")

        For i As Integer = 1 To Dt_Head.Rows.Count - 1
            _Field_Name = Dt_Head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_Head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_Head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        Dv_Filter0 = New DataView(Dt_Filter0)
        Dv_Filter1 = New DataView(Dt_Filter1)
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0
        _FieldName = ComFilter.SelectedValue.ToString.Trim

        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, Dv_Filter1, _FieldName, _Value, "%")

        _Filter1 = "1=1"
        If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        MasterGRV.ActiveFilterString = _Filter
        MasterGRV.FocusedRowHandle = 0
    End Sub
#End Region
#Region "Tính toán"
    Private Sub V_So_Tin_Nhan()
        If TxtBody.Text = "" Then
            LabLeng.Text = 0
            LabSo_Tin_Nhan.Text = 0
            Return
        ElseIf TxtBody.Text <> "" Then
            Dim _len As Double = 0, _So_Tin As Double = 0
            _len = Len(TxtBody.Text)
            _So_Tin = _len \ 160 + 1
            LabLeng.Text = _len
            LabSo_Tin_Nhan.Text = _So_Tin & " TN"
        End If
    End Sub
    Private Sub V_Ghep()
        If TxtNoi_Dung.Text <> "" Then TxtBody.Text = TxtND1.Text & ". " & TxtNoi_Dung.Text & ". " & TxtND5.Text
    End Sub
#End Region
#Region "Set"
    Private Sub V_SetCheckbox()
        If TxtMa_ChienDich.Text = "" Then
            If ChkM_Is_So_Ngay.Checked = True Then
                TxtM_So_Ngay.Enabled = True
                CbbM_LoaiN.Enabled = False
                TxtM_So_Ngay.Text = 180
                CbbM_LoaiN.SelectedValue = ""
            ElseIf ChkM_Is_So_Ngay.Checked = False Then
                TxtM_So_Ngay.Enabled = False
                TxtM_So_Ngay.Text = 0
                CbbM_LoaiN.SelectedValue = "8"
                CbbM_LoaiN.Enabled = True
            End If
        Else
            TxtM_So_Ngay.Enabled = False
            CbbM_LoaiN.Enabled = False
            CbbM_LoaiN.SelectedValue = ""
            TxtM_So_Ngay.Text = 0
        End If
    End Sub
#End Region
    Dim Dt_Master, Dt_ColFrozen, Dt_Head, Dt_Filter0, Dt_Filter1 As DataTable
    Dim Dv_Master, Dv_head, Dv_Filter0, Dv_Filter1 As DataView
    Private Sub V_Loc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loc()
        If CbbLoai_Cs.SelectedValue = "00" Then
            MsgBox("Bạn chưa chọn loại nhắc chăm sóc", vbOKOnly + vbCritical, M_CYBER_VER)
            Exit Sub
        End If
        LoadFilter()
        DsData.Dispose()
    End Sub
    Private Sub V_Loc()
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Ma_Dvcs_Filter As String = M_Ma_Dvcs

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkM_Is_So_Ngay.Checked = True, "1", "0").ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtM_So_Ngay.Double.ToString
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkM_Is_LoaiN.Checked = True, "1", "0").ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbM_LoaiN.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbLoai_Cs.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#"
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        M_strParameterStore = M_strParameterStore & "#" & CbbLoai.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ChienDich.Text.Trim

        DsData = V_Loaddatavase("", M_strParameterStore)

        '---> Đổ dữ liệu vào grid
        Dt_Master = New DataTable
        Dt_Head = New DataTable
        If DsData.Tables.Count < 1 Then
            Exit Sub
        End If
        If DsData.Tables(1).Rows.Count < 1 Then
            Exit Sub
        End If
        Dim Dt_MasterTmp As DataTable = DsData.Tables(1).Copy
        Dim Tong As Integer = Dt_MasterTmp.Rows(0).Item("So_Luong")
        Dim Da_Gui As Integer = Dt_MasterTmp.Rows(0).Item("Is_SMSRequest")
        Dim Con_Lai As Integer = 0
        LabTong.Text = Tong
        Con_Lai = Tong - Da_Gui
        LabDa_Gui.Text = Da_Gui
        LabCon_Lai.Text = Con_Lai
        Dt_MasterTmp.Rows.RemoveAt(0)
        Dt_Master.Clear()
        Dt_Master = Dt_MasterTmp.Copy
        Dt_Head = DsData.Tables(3).Copy
        Dv_Master = New DataView(Dt_Master)
        Dv_head = New DataView(Dt_Head)
        CyberSupport.V_SetSortView(Dv_Master, Dt_ColFrozen)
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
    End Sub
    Private Function V_Loaddatavase(ByVal Status As String, ByVal M_strParameterStore As String) As DataSet
        Return CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMGuiSMS", M_strParameterStore)
    End Function
    Public M_Dt_Return As DataTable
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True

        If TxtMa_SMS.Text = "" Then
            MsgBox("Vui lòng chọn Template", vbOKOnly + vbCritical, M_CYBER_VER)
            Exit Sub
        End If
        Dim _Checked = New DataTable
        Dim dv As DataView = Dt_Master.DefaultView
        dv.RowFilter = "Tag = '1'"
        _Checked = dv.ToTable
        If _Checked.Rows.Count = 0 Then
            MsgBox("Vui lòng chọn ít nhất 1 dòng", vbOKOnly + vbCritical, M_CYBER_VER)
            Exit Sub
        End If


        Dim _dtMaster As DataTable = Dt_Master.Clone()
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            _dtMaster.ImportRow(Dt_Master.Rows(i))
        Next



        Dim _MsgResult = MsgBox("Bạn có chắc chắn muốn gửi tin nhắn?", MsgBoxStyle.OkCancel)
        If _MsgResult = MsgBoxResult.Ok Then
            V_Gui()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub V_Gui()

        Dim DsSmsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.SMSTempZalo WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtSMSTmp As DataTable = DsSmsTmp.Tables(0).Copy
        DsSmsTmp.Dispose()

        Dim DtSendSMS As DataTable
        Dim _Noi_Dung As String = TxtMa_ChienDich.Text.Trim.Replace("#", "%23")

        CyberSmodb.SQLTbToTb(Dt_Master, DtSMSTmp)
        Dim smKey As String = "1=1"
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtSMSTmp, "SMSTempZalo", "", smKey)

        Dim M_strParameterStore As String = TxtMa_SMS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtId_Zalo.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtND1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Noi_Dung
        M_strParameterStore = M_strParameterStore & "#" & TxtND5.Text
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim


        Me.Tag = M_strParameterStore

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_SaveZalo", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            DsTmp.Dispose()
            Exit Sub
        Else
            Me.M_Dt_Return = DsTmp.Tables(0).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
        End If
        CyberSmlib.FlushMemorySave()
        V_Loc()
    End Sub
End Class