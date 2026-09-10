Public Class DMPTCK
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtLoaiCT As New DataTable
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Kh.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL.Value = Now.Date
        End If

        TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Vt", "DmVt", "(Ma_Vt = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)
        If TxtMa_Kh.Text.Trim.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)
        DtLoaiCT = CreateLoaiCK()
        
        CyberFill.V_FillComBoxDefaul(CbbMa_LoaiCK, DtLoaiCT, "Ma_LoaiCK", "Ten_LoaiCK", "Default")
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_KH
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH

        RemoveHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"

#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KH.Text = "" Then
            TxtTen_KH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtPT_CK.Double = TxtPT_CK.Double
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
    Private Function CreateLoaiCK() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma_LoaiCK")
        _Return.Columns.Add("Ten_LoaiCK")
        _Return.Columns.Add("Ten_LoaiCK2")
        _Return.Columns.Add("Default")
        _Return.Rows.Add("01", "Chiết khấu theo khách hàng và xe ", "", "1")
        _Return.Rows.Add("02", "Chiết khấu theo khách hàng ", "", "1")
        CreateLoaiCK = _Return
    End Function
End Class
