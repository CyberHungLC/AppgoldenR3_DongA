Public Class DMHLGCTC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtLoaiCT As New DataTable
    Private Sub FDMHLGCTC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Cv.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL.Value = Now.Date
        End If

        TxtTen_Cv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Cv", "DmCv", "(Ma_Cv = N'" + TxtMa_Cv.Text.Trim + "')", CyberSmlib)
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKx", "(Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "' AND Loai_Nh = '1')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKx", "(Ma_Nh = N'" + TxtNh_KX2.Text.Trim + "' AND Loai_Nh = '2')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_Cv
        RemoveHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_Cv
        RemoveHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_Cv
        AddHandler TxtMa_Cv.CyberValiting, AddressOf V_Ma_Cv
        AddHandler TxtMa_Cv.CyberLeave, AddressOf L_Ma_Cv
        '-Ma_Kx
        RemoveHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        '-Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        '-Nh_Kx2
        RemoveHandler TxtNh_KX2.CyberValiting, AddressOf V_Nh_Kx2
        RemoveHandler TxtNh_KX2.CyberLeave, AddressOf L_Nh_Kx2
        AddHandler TxtNh_KX2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_KX2.CyberLeave, AddressOf L_Nh_Kx2

        RemoveHandler TxtMa_Cv.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Cv.KeyPress, AddressOf TxtCodeError_KeyPress
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Cv"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cv", "DmCv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Cv.Text = "" Then
            TxtTen_Cv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cv.Text = DrReturn.Item("Ma_Cv")
            TxtTen_Cv.Text = DrReturn.Item("Ten_Cv")
        Else
            TxtMa_Cv.Text = ""
            TxtTen_Cv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx2"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhKx", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KX2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KX2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtDon_Gia.Double = TxtDon_Gia.Double
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
