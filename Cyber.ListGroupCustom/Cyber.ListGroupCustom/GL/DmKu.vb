Public Class DMKU
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim Dt_Detail, Dt_Head As DataTable
    Dim Dv_Detail, Dv_Head As DataView
    Private Sub DMKU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Ku, TxtNh_Ku1, TxtNh_Ku2, TxtNh_Ku3, TxtNh_Ku4, TxtNh_Ku5)
        TxtMa_Ku.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_Ku1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Ku1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Ku2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Ku2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Ku3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Ku3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Ku4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Ku4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Ku5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Ku5.Text.Trim + "')", CyberSmlib)

        If TxtMa_Kh.Text.Trim.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)
        If CmbLoai_LS.Text.Trim = "" Then CmbLoai_LS.SelectedValue = "1"
        If CmbKy_Tra.Text.Trim = "" Then CmbKy_Tra.SelectedValue = "1"
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterDmCTKu", TxtMa_Ku.Text.Trim & "#" & Me.Mode.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)       
        Dt_Detail = DsTmp.Tables(0).Copy
        Dt_Head = DsTmp.Tables(1).Copy
        Dv_Detail = New DataView(Dt_Detail)
        Dv_Head = New DataView(Dt_Head)
        CyberFill.V_FillVoucher(Master1GRV, M_LAN, Dv_Head, Dv_Detail, Nothing)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Ku.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Ku.KeyPress, AddressOf TxtCodeError_KeyPress

        'Nh_Ku1
        RemoveHandler TxtNh_Ku1.CyberValiting, AddressOf V_Nh_Ku1
        RemoveHandler TxtNh_Ku1.CyberLeave, AddressOf L_Nh_Ku1
        AddHandler TxtNh_Ku1.CyberValiting, AddressOf V_Nh_Ku1
        AddHandler TxtNh_Ku1.CyberLeave, AddressOf L_Nh_Ku1
        'Nh_Ku2
        RemoveHandler TxtNh_Ku2.CyberValiting, AddressOf V_Nh_Ku2
        RemoveHandler TxtNh_Ku2.CyberLeave, AddressOf L_Nh_Ku2
        AddHandler TxtNh_Ku2.CyberValiting, AddressOf V_Nh_Ku2
        AddHandler TxtNh_Ku2.CyberLeave, AddressOf L_Nh_Ku2
        'Nh_Ku3
        RemoveHandler TxtNh_Ku3.CyberValiting, AddressOf V_Nh_Ku3
        RemoveHandler TxtNh_Ku3.CyberLeave, AddressOf L_Nh_Ku3
        AddHandler TxtNh_Ku3.CyberValiting, AddressOf V_Nh_Ku3
        AddHandler TxtNh_Ku3.CyberLeave, AddressOf L_Nh_Ku3
        'Nh_Ku4
        RemoveHandler TxtNh_Ku4.CyberValiting, AddressOf V_Nh_Ku4
        RemoveHandler TxtNh_Ku4.CyberLeave, AddressOf L_Nh_Ku4
        AddHandler TxtNh_Ku4.CyberValiting, AddressOf V_Nh_Ku4
        AddHandler TxtNh_Ku4.CyberLeave, AddressOf L_Nh_Ku4
        'Nh_Ku5
        RemoveHandler TxtNh_Ku5.CyberValiting, AddressOf V_Nh_Ku5
        RemoveHandler TxtNh_Ku5.CyberLeave, AddressOf L_Nh_Ku5
        AddHandler TxtNh_Ku5.CyberValiting, AddressOf V_Nh_Ku5
        AddHandler TxtNh_Ku5.CyberLeave, AddressOf L_Nh_Ku5
        'Ma_kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'Ma_Nt
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT

        'So_KH              
        AddHandler TxtSo_KH.Leave, AddressOf L_So_KH
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtLoai_Ls As New DataTable
        Dim DtKy_Tra As New DataTable

        DtLoai_Ls.Columns.Add("Loai_Ls", GetType(String))
        DtLoai_Ls.Columns.Add("Ten", GetType(String))
        DtLoai_Ls.Columns.Add("Default", GetType(String))
        DtLoai_Ls.Rows.Add("1", IIf(M_LAN = "V", "Lãi suất theo năm", "Yearly interest rate"), "1")
        DtLoai_Ls.Rows.Add("2", IIf(M_LAN = "V", "Lãi suất theo quý", "Quarterly interest rates"), "0")
        DtLoai_Ls.Rows.Add("3", IIf(M_LAN = "V", "Lãi suất theo tháng", "Monthly interest rate"), "0")
        DtLoai_Ls.Rows.Add("4", IIf(M_LAN = "V", "Lãi suất theo tuần", "Weekly interest rate"), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbLoai_LS, DtLoai_Ls, "Loai_Ls", "Ten")

        DtKy_Tra.Columns.Add("Ky_Tra", GetType(String))
        DtKy_Tra.Columns.Add("Ten", GetType(String))
        DtKy_Tra.Columns.Add("Default", GetType(String))
        DtKy_Tra.Rows.Add("1", IIf(M_LAN = "V", "Trả gốc và Lãi theo năm", "Pay principal and interest by year"), "1")
        DtKy_Tra.Rows.Add("2", IIf(M_LAN = "V", "Trả gốc và Lãi theo quý", "Pay principal and interest quarterly"), "0")
        DtKy_Tra.Rows.Add("3", IIf(M_LAN = "V", "Trả gốc và Lãi theo tháng", "Pay principal and interest by month"), "0")
        DtKy_Tra.Rows.Add("4", IIf(M_LAN = "V", "Trả gốc và Lãi theo tuần", "Pay principal and interest by week"), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbKy_Tra, DtKy_Tra, "Ky_Tra", "Ten")
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Ku1"
    Private Sub V_Nh_Ku1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ku1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Ku1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ku1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ku1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ku1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Ku2"
    Private Sub V_Nh_Ku2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ku2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Ku2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ku2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ku2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ku2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Ku3"
    Private Sub V_Nh_Ku3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ku3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Ku3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ku3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ku3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ku3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Ku4"
    Private Sub V_Nh_Ku4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ku4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Ku4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ku4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ku4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ku4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Ku5"
    Private Sub V_Nh_Ku5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ku5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Ku5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ku5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ku5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ku5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_KH.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_NT"
    Private Sub V_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NT", "DmNT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            'TxtTen_NT.Text = DrReturn.Item("Ten_NT")
        Else
            TxtMa_NT.Text = ""
            'TxtTen_NT.Text = ""
        End If
    End Sub
#End Region
#Region "Valid L_So_KH"
    Private Sub L_So_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _DsDetail As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetSoKhungFromKH", Mode.Trim & "#" & TxtMa_Ku.Text.Trim & "#" & TxtSo_KH.Text.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        Dim nCount = _DsDetail.Tables.Count
        For i = 0 To nCount - 1
            CyberSmodb.SetNotNullTable(_DsDetail.Tables(i))
        Next

        If _DsDetail.Tables(nCount - 1).Rows(0).Item("Status").ToString.Trim = "N" Then
            If _DsDetail.Tables(nCount - 1).Rows(0).Item("Msg").ToString.Trim = "Y" Then
                MsgBox(_DsDetail.Tables(nCount - 1).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, oSysvar("M_Cyber_Ver"))
            End If
            _DsDetail.Dispose()
            Exit Sub
        End If

        If _DsDetail.Tables(0).Rows.Count < 1 Then
            _DsDetail.Dispose()
            Exit Sub
        End If
        Dt_Detail.Clear()

        CyberSmodb.SQLTbToTb(_DsDetail.Tables(0), Dt_Detail)
        UpdateList()
    End Sub
    Private Sub UpdateList()
        Dim nCount = Dt_Detail.Rows.Count
        If nCount < 0 Then Exit Sub

        Dim nT_Tien_NT As Decimal = 0
        For iRow As Integer = 0 To Dv_Detail.Count - 1
            nT_Tien_NT = nT_Tien_NT + Dv_Detail.Item(iRow).Item("Tien_NT")
        Next

        TxtTien.Double = nT_Tien_NT
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Ku.Text = _Value

        Dim Dstmpstruc As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "SELECT TOP 0 * FROM Dbo.DmCtKu WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim Dt_Master = Dstmpstruc.Tables(0).Copy

        Dim _Dr_Master As DataRow = Dt_Master.NewRow
        _Dr_Master.BeginEdit()
        CyberSmodb.SetValueBlankRow(_Dr_Master)
        CyberSmodb.AddValueToRow(_Dr_Master, Me)
        If Dt_Master.Columns.Contains("Ma_Dvcs") Then _Dr_Master.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _Dr_Master.EndEdit()
        Dt_Master.Rows.Add(_Dr_Master)
        Dt_Master.AcceptChanges()
        '---------------------------------------------------------------------
        Dim _StrXML As String = CyberSmodb.V_ConvertDataToXML({"DmKu", "DmCtKu"}, {Dt_Master, Dt_Detail})

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ChkSaveDmCtKu", Me.Mode + "#" + _StrXML + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), oSysvar, M_LAN) Then Exit Sub

        CyberSmodb.AddValueToRow(Me.DrNew, Me)

        'Tạo Stt_Rec0
        For i = 0 To Dt_Detail.Rows.Count - 1
            Dt_Detail.Rows(i).BeginEdit()
            Dt_Detail.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            Dt_Detail.Rows(i).Item("Ma_Ku") = TxtMa_Ku.Text.Trim
            Dt_Detail.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            Dt_Detail.Rows(i).EndEdit()
        Next

        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, Dt_Detail, "DmCtKu", Mode, "Ma_Ku = N'" + TxtMa_Ku.Text.Trim + "'")

        MyBase.V_Save(sender, e)
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
