Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors

Public Class RoGioDongSon
#Region "Get or Set Property----------------------"
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Ma_xe() As String
        Get
            Return M_Ma_Xe
        End Get
        Set(ByVal value As String)
            M_Ma_Xe = value
        End Set
    End Property
    Public Property TG() As String
        Get
            Return M_TG
        End Get
        Set(ByVal value As String)
            M_TG = value
        End Set
    End Property
    Public Property Muc_SDS() As String
        Get
            Return M_Muc_SDS
        End Get
        Set(ByVal value As String)
            M_Muc_SDS = value
        End Set
    End Property
    Public Property Ngay_Ct() As Date
        Get
            Return M_Ngay_Ct
        End Get
        Set(ByVal value As Date)
            M_Ngay_Ct = value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Return M_Mode
        End Get
        Set(ByVal value As String)
            M_Mode = value
        End Set
    End Property
    Public Property _Ds_LoolUp() As DataSet
        Get
            _Ds_LoolUp = DsLookup
        End Get
        Set(ByVal Value As DataSet)
            DsLookup = Value
        End Set
    End Property
#End Region
#Region "Bien----------------------"
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_KH As String = ""
    Dim M_Ma_GD As String = "1"
    Dim M_Ma_Xe As String = ""
    Dim M_TG As String = ""
    Dim M_Muc_SDS As String = ""
    Dim M_Ngay_Ct As Date

    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable

    Dim DrReturn As DataRow
#End Region
    Private Sub RoGioDongSon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        V_GetColumn()
        V_AddHander()
        MasterGRV.OptionsBehavior.Editable = False
        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        ButtExit.Focus()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(MasterGRV, "tag")
    End Sub
    Private Sub V_AddHander()
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        CyberFill.V_GridviewRowCellStyle(MasterGRV)
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtNgay_Ct.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_ct
    End Sub
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
    Private Sub V_Load()
        M_Ngay_Ct = Now.Date
        TxtNgay_Ct.Value = Now.Date
        V_LoadDatabase("1")
    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim DsDongSon As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGioDongSon", M_Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Stt_rec.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsDongSon.Tables.Count < 2 Then
            DsDongSon.Dispose()
            Exit Sub
        End If
        For i = 0 To DsDongSon.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsDongSon.Tables(i))
        Next
        If Status = "1" Then
            Dt_Master = DsDongSon.Tables(0)
            Dt_head = DsDongSon.Tables(1)
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
        Else
            Dt_Master.Clear()
            CyberSmodb.SQLTbToTb(DsDongSon.Tables(0), Dt_Master)
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
#End Region
#Region "Tinh toan"
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Ngay_Ct = TxtNgay_ct.Value
        V_LoadDatabase("0")
    End Sub
    Private Sub V_Ngay_ct(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Ngay_Ct = TxtNgay_Ct.Value
        V_LoadDatabase("0")
    End Sub
#Region "Grid"
    Private Sub gridView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles MasterGRV.DoubleClick
        Dim ea As DevExpress.Utils.DXMouseEventArgs = TryCast(e, DevExpress.Utils.DXMouseEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
        If info.InRow OrElse info.InRowCell Then
            Dim colName As String = info.Column.FieldName
            Dim rowName As String = info.RowHandle
            M_TG = Dt_Master.Rows(rowName).Item("TG").ToString
            M_Ngay_Ct = Dt_Master.Rows(rowName).Item("Ngay_Ct")

            Dim DsTgUp As DataSet
            DsTgUp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGioDongSonSave", M_Ngay_Ct.ToString("yyyyMMdd") & "#" & M_TG.Trim & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            If Not CyberSupport.V_MsgChk(DsTgUp.Tables(0), Me.Sysvar, M_LAN) Then
                DsTgUp.Dispose()
                Exit Sub
            End If


            If colName.ToUpper <> "NGAY_CT" Then
                Dt_Master.Rows(rowName).BeginEdit()
                Dt_Master.Rows(rowName).Item(colName) = M_Ma_Xe
                Dt_Master.Rows(rowName).EndEdit()
                Dt_Master.AcceptChanges()
            End If

        End If
        Me.Save_OK = True
        Me.Close()
    End Sub
#End Region
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#End Region
End Class
