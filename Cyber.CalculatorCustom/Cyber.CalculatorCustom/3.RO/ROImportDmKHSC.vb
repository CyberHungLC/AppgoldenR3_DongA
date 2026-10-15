Imports System.Data.SqlClient

Public Class ROImportDmKHSC
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader As New DataTable
    Dim DvMaster, DvHeader As New DataView

    Private Sub ROImportDmKHSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date

        Me.Save_OK = False
        V_Load()
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now
        TxtNgay_Ct2.Value = Now
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGetListDMKHSC", M_Ma_Dvcs & "#" & M_User_Name)
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        DvMaster = New DataView(tbMaster)
        DvHeader = New DataView(tbHeader)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler CmdSelectFile.Click, AddressOf V_SelectFile

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile
    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim dt As Date
        dt = TxtNgay_Ct1.Value
        dt = TxtNgay_Ct2.Value

        Dim _dtMaster As DataTable = tbMaster.Copy()

        If _dtMaster.Rows.Count < 1 Then
            Exit Sub
        End If

        Dim _MsgResult = MsgBox("Xác nhận import danh sách xe nhắc nhở?", vbOKCancel + vbCritical, M_CYBER_VER)
        If _MsgResult = MsgBoxResult.Ok Then
            V_XN(_dtMaster)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub V_XN(ByRef _DtDMKHSC As DataTable)
        If _DtDMKHSC.Columns.Contains("Ngay_HL") Then
            For i As Integer = 0 To _DtDMKHSC.Rows.Count - 1

                ' Kiểm tra Mã vật tư
                If _DtDMKHSC.Rows(i)("Ma_xe").ToString.Trim = "" Then
                    MsgBox("Dòng " & (i + 1).ToString() & " chưa nhập Mã Xe!",
                   MsgBoxStyle.Critical, M_CYBER_VER)
                    Exit Sub
                End If
            Next
        End If

        Dim DsSmsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.tmp_DMKHSC WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtSMSTmp As DataTable = DsSmsTmp.Tables(0).Copy
        DsSmsTmp.Dispose()
        CyberSmodb.SQLTbToTb(_DtDMKHSC, DtSMSTmp)
        Dim smKey As String = "" 'Đoạn này là điều kiện xoá
        Dim _ImportKey As String = Guid.NewGuid().ToString()

        If Not DtSMSTmp.Columns.Contains("ImportKey") Then
            DtSMSTmp.Columns.Add("ImportKey", GetType(String))
        End If

        For Each dr As DataRow In DtSMSTmp.Rows
            dr("ImportKey") = _ImportKey
        Next

        'CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtSMSTmp, "TmpToDmVtTonTT", "", smKey)
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtSMSTmp, "tmp_DMKHSC", "", smKey, False)

        Dim _Ngay_ct1 As DateTime = TxtNgay_Ct1.Value
        Dim _Ngay_ct2 As DateTime = TxtNgay_Ct2.Value

        Dim M_strParameterStore As String = _ImportKey & "#" & _Ngay_ct1.ToString("yyyyMMdd") & "#" & _Ngay_ct2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim

        Me.Tag = M_strParameterStore

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ImportDmKHSC", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            DsTmp.Dispose()
            Exit Sub
        Else
            Me.Save_OK = True
            DsTmp.Dispose()
        End If
        CyberSmlib.FlushMemorySave()
        Me.Close()

    End Sub

    Private Sub V_SelectFile(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, Master1GRV, tbMaster, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        tbMaster.Clear()
        For Each dr As DataRow In tbImport.Select("Ma_Xe <> ''")
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
End Class
