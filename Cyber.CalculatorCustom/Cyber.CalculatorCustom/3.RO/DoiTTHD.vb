Public Class DoiTTHD
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtMa_CT, DtPostOld, DtPostNew As DataTable
    Dim _P1, _P2, _Stt_Rec As String
    Dim _Ten_Hd As String
    Dim ProccessList As New Collection

#Region "Columns Edit"

#End Region
    Private Sub ROTRAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        _P1 = Me.Para(Me.M_VT_PARA + 2).ToUpper.Trim
        _P2 = Me.Para(Me.M_VT_PARA + 3).ToUpper.Trim

        _P1 = _P1.Replace(" ", "")
        _P1 = _P1.Replace(",", "','")
        V_Load()
        V_AddHandler()

        AddHandler CmdFilter.Click, AddressOf V_Filter
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmbbMa_CT.SelectedValueChanged, AddressOf V_GetTT
        AddHandler TxtSo_Ro.Leave, AddressOf V_GetTT
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()

    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Hd.CyberValiting, AddressOf V_Ma_Hd
        AddHandler TxtMa_Hd.CyberLeave, AddressOf L_Ma_Hd

        AddHandler TxtMa_Hd_New.CyberValiting, AddressOf V_Ma_Hd_New
        AddHandler TxtMa_Hd_New.CyberLeave, AddressOf L_Ma_Hd_New
    End Sub
    Private Sub V_AddHandler_Detail()

    End Sub

    Private Sub V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Ct,Ten_Ct,Ten_Ct FROM dbo.Dmct WHERE Ma_CT IN ('" & _P1 & "')" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtMa_CT = DsTmp.Tables(0).Copy
        DsTmp = Nothing
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,ten_Post,ten_Post2 FROM dbo.DmPost WHERE (Ma_Ct = N'" & _P2 & "' AND Ma_Post >'1') ORDER BY Ma_Post" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtPostOld = DsTmp.Tables(0).Copy
        DtPostNew = DsTmp.Tables(0).Copy

        CyberFill.V_FillComBoxValue(CmbbMa_CT, DtMa_CT, "Ma_CT", IIf(Me.Lan = "V", "Ten_Ct", "Ten_Ct"), _P2)
        'CyberFill.V_FillComBoxDefaul(CmbbMa_PostOld, DtPostOld, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
        'CyberFill.V_FillComBoxDefaul(CmbbMa_PostNew, DtPostNew, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
    End Sub
    Private Sub V_GetTT(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Ma_GD As String = "S"
        'If Me.Ma_CT.Trim.ToUpper = "HDP" Then _Ma_GD = "P"
        'If Me.Ma_CT.Trim.ToUpper = "HDM" Then _Ma_GD = "B"
        Dim _Dt As Date = Now.Date
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, CmbbMa_CT.SelectedValue, "S", "M", _Dt, TxtSo_Ro.Text, "", M_Ma_Dvcs, M_User_Name, CyberSmlib)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,ten_Post,ten_Post2 FROM dbo.DmPost WHERE (Ma_Ct = N'" & CmbbMa_CT.SelectedValue.ToString.Trim & "' AND Ma_Post >'1') ORDER BY Ma_Post" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim nCount As Integer
        nCount = DtPostOld.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            DtPostOld.Rows(i).Delete()
        Next
        DtPostOld.AcceptChanges()
        For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
            DtPostOld.ImportRow(DsTmp.Tables(0).Rows(i))
        Next
        DtPostOld.AcceptChanges()
        '---------------------------------------------
        nCount = DtPostNew.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            DtPostNew.Rows(i).Delete()
        Next
        DtPostNew.AcceptChanges()
        For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
            DtPostNew.ImportRow(DsTmp.Tables(0).Rows(i))
        Next
        DtPostNew.AcceptChanges()

        DsTmp = Nothing
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_DoiTTHD_LOC", CmbbMa_CT.SelectedValue.ToString.Trim & "#" & TxtSo_Ro.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Ma_HD As String = ""
        _Ten_Hd = ""
        _Ma_HD = DsTmp.Tables(0).Rows(0).Item("Ma_td3").ToString.Trim
        _Ten_Hd = DsTmp.Tables(0).Rows(0).Item("Ten_Td3").ToString.Trim

        Try
            TxtMa_Hd.Text = _Ma_HD
            TxtTen_Hd.Text = _Ten_Hd
        Catch ex As Exception
        End Try
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then
            DsTmp.Dispose()
            Exit Sub
        End If
    End Sub
    Private Sub V_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text.Trim = "" Then
            MsgBox("Bạn chưa chọn số lệnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If

        Dim _Ma_Ct As String = CmbbMa_CT.SelectedValue.ToString.Trim

        Dim strAddParar As String = "#" & _Ma_Ct & "###24#C#" & _Stt_Rec
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#Region "Vali --- Ma_Hd"
    Private Sub V_Ma_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hd.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Td3", "DmTd3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hd.Text = "" Then
            TxtTen_Hd.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hd.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hd.Text = DrReturn.Item("Ma_td3")
            TxtTen_Hd.Text = DrReturn.Item("Ten_td3")
        Else
            TxtMa_Hd.Text = ""
            TxtTen_Hd.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hd_New"
    Private Sub V_Ma_Hd_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hd_New.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Td3", "DmTd3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hd_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hd_New.Text = "" Then
            TxtTen_Hd_New.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hd_New.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hd_New.Text = DrReturn.Item("Ma_td3")
            TxtTen_Hd_New.Text = DrReturn.Item("Ten_td3")
        Else
            TxtMa_Hd_New.Text = ""
            TxtTen_Hd_New.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text.Trim = "" Then
            MsgBox("Bạn chưa chọn số lệnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_DoiTTHD", CmbbMa_CT.SelectedValue.ToString.Trim & "#" & TxtSo_Ro.Text.Trim & "#" & TxtMa_Hd.Text & "#" & TxtMa_Hd_New.Text & "#" & TxtDien_Giai.Text.Trim.Replace("#", "") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar) Then
            'CmbbMa_PostOld.SelectedValue = CmbbMa_PostNew.SelectedValue
        End If

        'Me.Save_OK = False

        'Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        'Me.Close()
    End Sub
End Class
