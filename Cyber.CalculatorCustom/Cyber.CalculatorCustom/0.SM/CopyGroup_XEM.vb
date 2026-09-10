Imports System.Drawing
Imports System.Windows.Forms
Public Class CopyGroup_XEM
    Public Property strLoc() As String
        Get
            strLoc = M_strLoc
        End Get
        Set(ByVal Value As String)
            M_strLoc = Value
        End Set
    End Property
    Public Property Cp_Loc() As String
        Get
            Cp_Loc = M_Cp_Loc
        End Get
        Set(ByVal Value As String)
            M_Cp_Loc = Value
        End Set
    End Property
    Public Property Cp_Update() As String
        Get
            Cp_Update = M_Cp_Update
        End Get
        Set(ByVal Value As String)
            M_Cp_Update = Value
        End Set
    End Property
    Public Property Ma_DVCSLoc() As String
        Get
            Ma_DVCSLoc = M_Ma_DVCSLoc
        End Get
        Set(ByVal Value As String)
            M_Ma_DVCSLoc = Value
        End Set
    End Property
    Public Property DsDataLoc() As DataSet
        Get
            DsDataLoc = M_DsDataLoc
        End Get
        Set(ByVal Value As DataSet)
            M_DsDataLoc = Value
        End Set
    End Property
    Public Property Ma_Kx() As String
        Get
            Ma_Kx = M_MA_KX
        End Get
        Set(ByVal Value As String)
            M_MA_KX = Value
        End Set
    End Property
    Public Property Ma_Mau() As String
        Get
            Ma_Mau = M_MA_Mau
        End Get
        Set(ByVal Value As String)
            M_MA_Mau = Value
        End Set
    End Property
    Public M_Loai As String
    Dim ProccessList As New Collection
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc, M_Ma_DVCSLoc As String
    Dim M_MA_KX As String = ""
    Dim M_MA_Mau As String = ""


    Dim M_DsDataLoc As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_head, Dt_Master, Dt_Dmct, Dt_Filter1, Dt_Filter0 As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct, DV_Filter1, DV_Filter0 As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys

    Dim EditSo_Khung As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KH As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_KH As New Cyber.Fill.CyberColumnGridView
    Dim EditOng_Ba As New Cyber.Fill.CyberColumnGridView

    Dim EditTen_KX As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KX As New Cyber.Fill.CyberColumnGridView

    Dim M_Bar As String
    Dim M_Bar2 As String
    Dim _Tab_Boolean As Boolean = False
    Dim Dt_DmKx As DataTable
    Dim Dt_DmMau As DataTable

    Dim _Bold As Boolean = False
    Dim _BackColor As Boolean = False
    Dim _BackColor2 As Boolean = False
    Dim _Forecolor As Boolean = False
    Dim _FieldBold As String = ""
    Dim _FieldBackColor As String = ""
    Dim _FieldBackColor2 As String = ""
    Dim _FieldForecolor As String = ""
    Private Sub BEXEPXE_XEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim
        Me.Save_OK = False
        Me.Tag = ""
        V_Load()
        V_GetColorBold()
        V_FilldatatoGridview()
        V_GetColumn()
        V_AddHandler_Master()
        V_AddHandler_Detail()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        Dt_DmKx = CyberSmodb.OpenTable(AppConn, Nothing, "DmKx", "1", CyberSmlib)
        Dt_DmMau = CyberSmodb.OpenTable(AppConn, Nothing, "DmMauxe", "1", CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load data"
    Private Sub V_Load()
        Dt_Master = DsDataLoc.Tables(0).Copy
        Dt_Dmct = DsDataLoc.Tables(1).Copy
        Dt_head = DsDataLoc.Tables(2).Copy
        Dv_Master = New DataView(Dt_Master)
        Dv_Dmct = New DataView(Dt_Dmct)
        Dv_head = New DataView(Dt_head)
        DrDmct = Dt_Dmct.Rows(0)
        If Dv_Master.Table.Columns.Contains("Tag") Then _Tab_Boolean = True

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

        For i As Integer = 1 To Dt_head.Rows.Count - 1
            _Field_Name = Dt_head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        DV_Filter0 = New DataView(Dt_Filter0)
        DV_Filter1 = New DataView(Dt_Filter1)
    End Sub
    Private Sub V_GetColorBold()
        If Dt_Master.Columns.Contains("Backcolor") Then
            _BackColor = True
            _FieldBackColor = Dt_Master.Columns("Backcolor").ColumnName
        End If
        If Dt_Master.Columns.Contains("Backcolor2") Then
            _BackColor2 = True
            _FieldBackColor2 = Dt_Master.Columns("Backcolor2").ColumnName
        End If
        If Dt_Master.Columns.Contains("Forecolor") Then
            _Forecolor = True
            _FieldForecolor = Dt_Master.Columns("Forecolor").ColumnName
        End If

        If Dt_Master.Columns.Contains("Bold") Then
            _Bold = True
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
        End If
    End Sub
    Private Sub V_GetColumn()
        EditMa_KH.GetColumn(MasterGRV, "MA_KH")
        EditTen_KH.GetColumn(MasterGRV, "TEN_KH")
        EditOng_Ba.GetColumn(MasterGRV, "Ong_Ba")

        EditMa_KX.GetColumn(MasterGRV, "MA_KX")
        EditTen_KX.GetColumn(MasterGRV, "TEN_KX")
        'EditSo_Khung.GetColumn(MasterGRV, "So_Khung")
    End Sub
    Private Sub V_FilldatatoGridview()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Dim FixCol As Integer = -1
        Try
            FixCol = Dt_Dmct.Rows(0).Item("ColFrozen_Master")
        Catch ex As Exception
        End Try

        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_Loc, strLoc)
        CyberSmodb.SetNotNullTable(Dstmp.Tables(0))
        Dim nCount As Integer = Dt_Master.Rows.Count - 1
        For i = nCount To 0 Step -1
            Dt_Master.Rows(i).Delete()
        Next
        Dt_Master.AcceptChanges()
        For i = 0 To Dstmp.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(Dstmp.Tables(0).Rows(i))
        Next
        Dt_Master.AcceptChanges()
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler_Master()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        '--------------------------------------------------------------------------
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '--------------------------------------------------------------------------
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CmbbRefresh.Click, AddressOf V_Refresh
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler TxtSearch.TextChanged, AddressOf V_Search
        AddHandler CmbbCopy.Click, AddressOf V_CopyGroup
    End Sub
    Private Sub V_AddHandler_Detail()

    End Sub
    Private Sub V_PrintHDX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex

        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        If Not Dt_Master.Columns.Contains("Ma_CT") Then Return
        If Not Dt_Master.Columns.Contains("Stt_Rec") Then Return
        If Not Dt_Master.Columns.Contains("Stt_Rec0") Then Return

        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct")
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        CyberVoucher.V_PrintVoucherAll(AppConn, Sysvar, _Ma_Ct, _Stt_Rec, _Stt_Rec0, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
 
 
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
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
#End Region
#Region "Event - Nut Lenh"
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0

        _FieldName = ComFilter.SelectedValue.ToString.Trim
        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, DV_Filter1, _FieldName, _Value, "%")
        _Filter1 = "1=1"
        If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        MasterGRV.ActiveFilterString = _Filter
        MasterGRV.FocusedRowHandle = 0
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "Print "
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
#End Region
#Region "Event"
    Private Function FindRowHandleByRowObject(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Object) As Integer
        Dim I As Integer
        If Not row Is Nothing Then
            For I = 0 To view.DataRowCount - 1
                If row.Equals(view.GetRow(I)) Then
                    Return I
                End If
            Next
        End If
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
    End Function
    Private Function V_UpdateItem(ByVal Dv As DataView, ByVal iRow As Decimal, ByVal DrvUp As DataRowView) As DataRowView
        If iRow < 0 Then Return Nothing
        Dim iCol As Integer
        Dim _Fieldname As String
        Dim Drv As DataRowView
        Drv = Dv.Item(iRow)
        Drv.BeginEdit()
        For iCol = 0 To Dv.Table.Columns.Count - 1
            _Fieldname = Dv.Table.Columns(iCol).ColumnName
            If DrvUp.DataView.Table.Columns.Contains(_Fieldname) Then
                Drv.Item(_Fieldname) = DrvUp.Item(_Fieldname)
            End If
        Next
        Drv.EndEdit()
        Dv.Table.AcceptChanges()
        Return Drv
    End Function
    Dim icong As Integer = 1
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If _Bold Then
                Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
                If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
            End If
            If _BackColor Then
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If _BackColor2 Then
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If

            If _Forecolor Then
                Dim _categoryForeColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldForecolor).ToString.Trim
                e.Appearance.ForeColor = CyberColor.GetForeColor(_categoryForeColor)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If

    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()

          '-----------------------
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In các biên bản", "Refresh"), AddressOf V_PrintHDX, Shortcut.F10, Nothing, True, True)).BeginGroup = False

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub

    Private Function V_CopyGroup() As Boolean
        Dim _Return As Boolean
        '----------------------------------------------------------------------------
        Dim _StrSave As String = ""
        Dim _Field As String = ""
        For i As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Then

                _StrSave = _StrSave + ";INSERT GroupInforCopy SELECT N'" + Dv_Master.Item(i).Item("Tag").ToString.Trim.Replace("'", "''") + "',N'" + Dv_Master.Item(i).Item("Group").ToString.Trim.Replace("'", "''") + "'"
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item("Comment").ToString.Trim.Replace(",", ".") + "'" + ",N'" + Dv_Master.Item(i).Item("UnitsDefault").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'" + ",N'" + Dv_Master.Item(i).Item("Ten_New").ToString.Trim.Replace(",", ".") + "'"

            End If
   
        Next

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CopyGroup", Ma_DVCSLoc & "#" & _StrSave & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN)
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
#End Region
End Class
