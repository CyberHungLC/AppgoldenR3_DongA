Public Class RoImportDmvt
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbdetail_Temp As New DataTable
    Dim DvMaster, DvHeader As New DataView
    Private Sub ROCLOSE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGetListDmVT", M_Ma_Dvcs & "#" & M_User_Name)
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        tbdetail_Temp = DsData.Tables(2)
        DvMaster = New DataView(tbMaster)
        DvHeader = New DataView(tbHeader)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        tbdetail_Temp.Clear()
        CyberSmodb.SQLTbToTb(tbMaster, tbdetail_Temp)


        Dim M_StrXML As String = ""
        M_StrXML = CyberSmodb.V_ConvertDataToXML({"DMVT"}, {tbdetail_Temp})


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoImportDmvt", M_StrXML & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        If DsTmp.Tables.Count > 0 Then
            If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
                DsTmp.Dispose()
                Exit Sub
            End If
        End If

        DsTmp.Dispose()

        MsgBox("Đã thực hiện xong", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_SelectFile(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, Master1GRV, tbMaster, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        For Each dr As DataRow In tbImport.Select("Ma_VT<>''")
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
End Class
