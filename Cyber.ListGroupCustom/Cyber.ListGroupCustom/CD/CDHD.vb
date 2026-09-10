Public Class CDHD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CDHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTK.Focus()
        TxtMa_NT.Properties.ReadOnly = True
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If TxtTen_Tk.Text.Trim = "" Then TxtTen_Tk.Text = "" Else TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If Not TxtTK.Text.Trim = "" Then TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If TxtMa_Nt.Text.Trim = "" Then Txtten_Nt.Text = "" Else Txtten_Nt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_Nt.Text.Trim + "')", CyberSmlib)
        If TxtMa_HD.Text.Trim = "" Then TxtTen_HD.Text = "" Else TxtTen_HD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HD", "DmHD", "(Ma_HD = N'" + TxtMa_HD.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'Ma_TD3
        RemoveHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_TD3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_TD3.CyberLeave, AddressOf L_Ma_TD3
        'Ma_HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        'Ma_Kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'TK
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        '---
        RemoveHandler TxtDu_No00.Leave, AddressOf V_L_Du_No00
        RemoveHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        AddHandler TxtDu_No00.Leave, AddressOf V_L_Du_No00
        AddHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        '---
        RemoveHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        RemoveHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
        AddHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        AddHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_L_Du_No00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_No00.Double <> 0 Then
            TxtDu_Co00.Double = 0
            TxtDu_Co_NT00.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_No00.Double
        End If
    End Sub
    Private Sub V_L_Du_No_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_No00.Double
        End If
        If TxtDu_No_NT00.Double <> 0 Then TxtDu_Co_NT00.Double = 0
    End Sub
    Private Sub V_L_Du_Co00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_Co00.Double <> 0 Then
            TxtDu_No00.Double = 0
            TxtDu_No_NT00.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        End If
    End Sub
    Private Sub V_L_Du_Co_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        End If
        If TxtDu_Co_NT00.Double <> 0 Then TxtDu_No_NT00.Double = 0
    End Sub
#Region "Vali --- TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TD3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_TD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_TD3.Text = DrReturn.Item("Ten_TD3")
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            'TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
        Else
            TxtMa_TD3.Text = ""
            TxtTen_TD3.Text = ""
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
            'TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- KH"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("TK")
            TxtTen_Tk.Text = DrReturn.Item("Ten_TK")
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            If TxtMa_NT.Text.Trim = "" Then TxtTen_NT.Text = "" Else TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
            V_Reset()
        Else
            TxtTK.Text = ""
            TxtTen_Tk.Text = ""
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
    Private Sub V_Reset()
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_No00.Double
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double

            TxtDu_No_NT00.InputMask = TxtDu_No00.InputMask.ToString.Trim
            TxtDu_Co_NT00.InputMask = TxtDu_Co00.InputMask.ToString.Trim
        Else
            TxtDu_No_NT00.InputMask = TxtDu_No_NT00.Tag.ToString.Trim
            TxtDu_Co_NT00.InputMask = TxtDu_Co_NT00.Tag.ToString.Trim

        End If
        TxtDu_No_NT00.Refresh()
        TxtDu_Co_NT00.Refresh()
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
