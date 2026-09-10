Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmPrintVT
    Public Property Preview() As Boolean
        Get
            Preview = M_Preview
        End Get
        Set(ByVal Value As Boolean)
            M_Preview = Value
        End Set
    End Property
    Public Property Dt_Print() As DataTable
        Get
            Dt_Print = M_Dt_Print
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Print = Value
        End Set
    End Property
    Public Property Loai_IN() As String
        Get
            Loai_IN = M_Loai_IN
        End Get
        Set(ByVal Value As String)
            M_Loai_IN = Value
        End Set
    End Property
    Public Property Ma_IN() As String
        Get
            Ma_IN = M_Ma_IN
        End Get
        Set(ByVal Value As String)
            M_Ma_IN = Value
        End Set
    End Property
    Dim M_Preview As Boolean = True
    Dim M_Dt_Print As DataTable

    Dim M_Loai_IN As String = "1"
    Dim M_Ma_IN As String = "1"

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub FrmPrintBLuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdEditReport.Click, AddressOf V_EditReport
        AddHandler ButtExit.Click, AddressOf V_Exit

        Me.Text = "IN BẢNG LƯƠNG"
        If M_is_Admin Then CmdEditReport.Enabled = True Else CmdEditReport.Enabled = False
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Rad11.Checked = Not M_Preview
        Rad12.Checked = M_Preview
        CyberFill.V_FillComBoxDefaul(CmbMa_In, Dt_Print, "Ma_In", "Ten_In", "Ngam_Dinh")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Dim _Loai_IN As String = "1"
        If Rad11.Checked Then _Loai_IN = "PRINT" Else _Loai_IN = "PREVIEW"
        V_Nhan(_Loai_IN)
        Me.Close()
    End Sub
    Private Sub V_EditReport(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        V_Nhan("MODI")
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal _Loai_In As String)
        Me.Loai_IN = _Loai_In
        Me.Ma_IN = CmbMa_In.SelectedValue.ToString.Trim
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class
