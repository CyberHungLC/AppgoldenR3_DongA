Imports System.Windows.Forms
Public Class FrmSelect
#Region "AddProperty"
    Public Property CP_Name() As String
        Get
            CP_Name = M_CP_name
        End Get
        Set(ByVal Value As String)
            M_CP_name = Value
        End Set
    End Property
    Public Property Filter_Loc() As String
        Get
            Filter_Loc = M_Filter_Loc
        End Get
        Set(ByVal Value As String)
            M_Filter_Loc = Value
        End Set
    End Property
    Public Property Frm_Title() As String
        Get
            Frm_Title = M_Frm_Title
        End Get
        Set(ByVal Value As String)
            M_Frm_Title = Value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Ma_Ct = M_Ma_Ct
        End Get
        Set(ByVal Value As String)
            M_Ma_Ct = Value
        End Set
    End Property
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Public M_Mode As String = ""
    Public txtReturn As String
    Public M_XAC_THUC_DKHD As Integer = 0
    Public Ngay_ct As Date
#End Region
#Region "Khai báo biến"
    Public M_Stt_Rec, M_Ma_Ct, M_Frm_Title, M_Filter_Loc, M_CP_name As String
    Public DsData As DataSet
    Dim dtDetail, dtHeader As New DataTable
    Dim vdtDetail, vdtHeader As New DataView
    Dim EditTag As New Cyber.Fill.CyberColumnGridView
    Dim M_return As Integer = 0
    Dim Set_Width_Form As Integer = 0
    Dim Width_Form As Integer = 0
    Dim Str_Return As String = ""
#End Region
    Private Sub FrmSo_hopdong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_GetColumn()
        V_AddHandler()
        Me.Text = M_Frm_Title
        GetDefault()
        If Set_Width_Form = 1 Then
            Me.Width = Width_Form
        End If
    End Sub
#Region "Load..........."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        '
        If Not EditTag.Column Is Nothing Then AddHandler EditTag.EditColumn.EditValueChanged, AddressOf V_change_Tag
        '
    End Sub
    Private Sub V_GetColumn()
        EditTag.GetColumn(MasterGRV, "Tag")
    End Sub
    Private Sub V_Load()
        V_LoadDatabases("1", False)
        CyberFill.V_FillVoucherView(MasterGRV, M_LAN, vdtHeader, vdtDetail)
        Master.DataSource = vdtDetail
        '
    End Sub
    Private Sub GetDefault()

    End Sub
    Private Sub V_change_Tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        If vdtDetail.Item(iRow).Item("Tag") = 1 Then
            V_RemoveAll(iRow)
        End If
        vdtDetail.Table.AcceptChanges()
        txtReturn = ""
        For i = 0 To dtDetail.Rows.Count - 1
            If dtDetail.Columns.Contains("Tag") And dtDetail.Columns.Contains("Ma") Then
                If dtDetail.Rows(i).Item("Tag") = 1 Then
                    txtReturn = dtDetail.Rows(i).Item("Ma").ToString.Trim()
                    Exit For
                End If
            End If
        Next
        If txtReturn <> "" Then
            Me.Save_OK = True
            Me.Close()
        End If
    End Sub
    Private Sub V_RemoveAll(i_not As Integer)
        For iRow = 0 To dtDetail.Rows.Count - 1
            If dtDetail.Columns.Contains("Tag") And iRow <> i_not Then
                vdtDetail.Item(iRow).BeginEdit()
                vdtDetail.Item(iRow).Item("Tag") = 0
                vdtDetail.Item(iRow).EndEdit()
            End If
        Next
        vdtDetail.Table.AcceptChanges()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabases("0", True)
    End Sub
    Private Sub V_LoadDatabases(ByVal status As String, Excec As Boolean)
        Dim DsXemPX As DataSet
        If Excec = True Then
            DsXemPX = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_CP_name, M_Filter_Loc)
        Else
            DsXemPX = DsData
        End If
        If status.ToString.Trim = "1" Then
            dtDetail = New DataTable
            dtHeader = New DataTable
            dtDetail = DsXemPX.Tables(0).Copy
            dtHeader = DsXemPX.Tables(1).Copy
            vdtDetail = New DataView(dtDetail)
            vdtHeader = New DataView(dtHeader)

        Else
            dtDetail.Clear()
            For i As Integer = 0 To DsXemPX.Tables(0).Rows.Count - 1
                dtDetail.ImportRow(DsXemPX.Tables(0).Rows(i))
            Next
        End If
        If DsXemPX.Tables.Count > 2 Then
            If DsXemPX.Tables(2).Rows.Count > 0 Then
                If DsXemPX.Tables(2).Columns.Contains("M_return") Then
                    Integer.TryParse(DsXemPX.Tables(2).Rows(0).Item("M_return").ToString(), M_return)
                End If
                If DsXemPX.Tables(2).Columns.Contains("Set_Width_Form") Then
                    Integer.TryParse(DsXemPX.Tables(2).Rows(0).Item("Set_Width_Form").ToString(), Set_Width_Form)
                End If
                If DsXemPX.Tables(2).Columns.Contains("Width_Form") Then
                    Integer.TryParse(DsXemPX.Tables(2).Rows(0).Item("Width_Form").ToString(), Width_Form)
                End If
                If DsXemPX.Tables(2).Columns.Contains("Str_Return") Then
                    Str_Return = DsXemPX.Tables(2).Rows(0).Item("Str_Return")
                End If
            End If
            If M_return = 1 Then
                txtReturn = Str_Return
                Me.Save_OK = True
                Me.Close()
            End If
        End If
        'Dim M_return As Integer = 0
        'Dim Set_Width_Form As Integer = 0
        'Dim Width_Form As Integer = 0
        'Dim Str_Return As String = ""
        DsXemPX.Dispose()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To dtDetail.Rows.Count - 1
            If dtDetail.Columns.Contains("Tag") And dtDetail.Columns.Contains("Ma") Then
                If dtDetail.Rows(i).Item("Tag") = 1 Then
                    txtReturn = dtDetail.Rows(i).Item("Ma").ToString.Trim()
                    Exit For
                End If
            End If
        Next
        Me.Save_OK = True
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region ""
    Dim ProccessList As New Collection
    Private Function GetProcess(ByVal pPath As String, ByVal pParam As String, ByRef ReturnTo As Process) As Process
        ReturnTo = Process.Start(pPath, pParam)
        Return ReturnTo
    End Function
    Private Function ChkRightsVoucher(ByVal _Mode As String, ByVal _DT As Date, ByVal _ma_Post As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String) As Boolean
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_DT, _Mode, _ma_Post, _Stt_Rec, _Ma_Ct, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, Me.Sysvar, CyberSmlib)
    End Function
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
#End Region
#Region "Grid View..........."
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        'V_dangky
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, Nothing, True, True), True)
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, Nothing, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle(sender, e, MasterGRV, dtDetail, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", CyberColor)
    End Sub
#End Region
End Class
