Public Class ROTRAN
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtMa_CT, DtPostOld, DtPostNew As DataTable
    Dim _P1, _P2, _Stt_Rec As String
    Dim ProccessList As New Collection
    Private Sub ROTRAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        _P1 = Me.Para(Me.M_VT_PARA + 2).ToUpper.Trim
        _P2 = Me.Para(Me.M_VT_PARA + 3).ToUpper.Trim

        _P1 = _P1.Replace(" ", "")
        _P1 = _P1.Replace(",", "','")
        V_Load()

        AddHandler CmdFilter.Click, AddressOf V_Filter
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmbbMa_CT.SelectedValueChanged, AddressOf V_GetTT
        AddHandler TxtSo_Ro.Leave, AddressOf V_GetTT
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()       
    End Sub
    Private Sub V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Ct,Ten_Ct,Ten_Ct FROM dbo.Dmct WHERE Ma_CT IN ('" & _P1 & "')" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtMa_CT = DsTmp.Tables(0).Copy
        DsTmp = Nothing
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,ten_Post,ten_Post2 FROM dbo.DmPost WHERE (Ma_Ct = N'" & _P2 & "' AND Ma_Post >'1') ORDER BY Ma_Post" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtPostOld = DsTmp.Tables(0).Copy
        DtPostNew = DsTmp.Tables(0).Copy

        Dim _DsTTCP As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTTCP", M_Ma_Dvcs & "#" & Me.M_User_Name)
        Dim _DtTTCP As DataTable = _DsTTCP.Tables(0)

        CyberFill.V_FillComBoxValue(CmbbMa_CT, DtMa_CT, "Ma_CT", IIf(Me.Lan = "V", "Ten_Ct", "Ten_Ct"), _P2)
        CyberFill.V_FillComBoxDefaul(CmbbMa_PostOld, DtPostOld, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
        CyberFill.V_FillComBoxDefaul(CmbbMa_PostNew, DtPostNew, "Ma_Post", IIf(Me.Lan = "V", "Ten_Post", "Ten_Post2"))
        CyberFill.V_FillComBoxDefaul(CbbMa_TTCP, _DtTTCP, "Ma_TTCP", IIf(Me.Lan = "V", "Ten_TTCP", "Ten_TTCP"), "Ngam_Dinh")

    End Sub
    Private Sub V_GetTT(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Ma_GD As String = "S"
        'If Me.Ma_CT.Trim.ToUpper = "HDP" Then _Ma_GD = "P"
        'If Me.Ma_CT.Trim.ToUpper = "HDM" Then _Ma_GD = "B"
        Dim _Dt As Date = Now.Date
        Dim _TTCP As String = CbbMa_TTCP.SelectedValue
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, CmbbMa_CT.SelectedValue, "S", "M", _Dt, TxtSo_Ro.Text, _TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

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
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROTRANLOC", CmbbMa_CT.SelectedValue.ToString.Trim & "#" & TxtSo_Ro.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Post As String = ""
        _Stt_Rec = ""
        _Post = DsTmp.Tables(0).Rows(0).Item("Ma_Post").ToString.Trim
        _Stt_Rec = DsTmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim

        Try
            CmbbMa_PostOld.SelectedValue = _Post
        Catch ex As Exception
        End Try
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
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text.Trim = "" Then
            MsgBox("Bạn chưa chọn số lệnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROTRAN", CmbbMa_CT.SelectedValue.ToString.Trim & "#" & TxtSo_Ro.Text.Trim & "#" & CmbbMa_PostNew.SelectedValue.ToString.Trim & "#" & TxtDien_Giai.Text.Trim.Replace("#", "") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar) Then
            CmbbMa_PostOld.SelectedValue = CmbbMa_PostNew.SelectedValue
        End If

        'Me.Save_OK = False

        'Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        'Me.Close()
    End Sub
End Class
