Public Class CDRO
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString

        If TxtTen_Tk.Text.Trim = "" Then TxtTen_Tk.Text = "" Else TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" & TxtTk.Text.Trim & "')", CyberSmlib)
        If TxtMa_Kh.Text.Trim.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_Kh = N'" & TxtMa_Kh.Text.Trim & "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" & TxtMa_Dvcs.Text.Trim & "')", CyberSmlib)
        TxtMa_NT.Properties.ReadOnly = True
        TxtTk.Focus()
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'Tk
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
        'Ma_Kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        'Ma_TT
        RemoveHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        RemoveHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT
        AddHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        AddHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT
       
        RemoveHandler TxtDu_No00.Leave, AddressOf V_L_Du_No00
        RemoveHandler TxtDu_No_Nt00.Leave, AddressOf V_L_Du_No_NT00
        AddHandler TxtDu_No00.Leave, AddressOf V_L_Du_No00
        AddHandler TxtDu_No_Nt00.Leave, AddressOf V_L_Du_No_NT00
        '---
        RemoveHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        RemoveHandler TxtDu_Co_Nt00.Leave, AddressOf V_L_Du_Co_NT00
        AddHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        AddHandler TxtDu_Co_Nt00.Leave, AddressOf V_L_Du_Co_NT00
        '---
        RemoveHandler TxtDu_No1.Leave, AddressOf V_L_Du_No1
        RemoveHandler TxtDu_No_Nt1.Leave, AddressOf V_L_Du_No_NT1
        AddHandler TxtDu_No1.Leave, AddressOf V_L_Du_No1
        AddHandler TxtDu_No_Nt1.Leave, AddressOf V_L_Du_No_NT1
        '---
        RemoveHandler TxtDu_Co1.Leave, AddressOf V_L_Du_Co1
        RemoveHandler TxtDu_Co_Nt1.Leave, AddressOf V_L_Du_Co_NT1
        AddHandler TxtDu_Co1.Leave, AddressOf V_L_Du_Co1
        AddHandler TxtDu_Co_Nt1.Leave, AddressOf V_L_Du_Co_NT1
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_L_Du_No00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_No00.Double <> 0 Then
            TxtDu_Co00.Double = 0
            TxtDu_Co_Nt00.Double = 0
            If So_Dau_Nam Then TxtDu_Co1.Double = 0
            If So_Dau_Nam Then TxtDu_Co_Nt1.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_Nt00.Double = TxtDu_No00.Double
        End If
        If So_Dau_Nam Then TxtDu_No1.Double = TxtDu_No00.Double
        If So_Dau_Nam Then TxtDu_No_Nt1.Double = TxtDu_No_Nt00.Double
    End Sub
    Private Sub V_L_Du_No_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_Nt00.Double = TxtDu_No00.Double
        End If

        If TxtDu_No_Nt00.Double <> 0 Then TxtDu_Co_Nt00.Double = 0
        If So_Dau_Nam Then TxtDu_No_Nt1.Double = TxtDu_No_Nt00.Double
        If So_Dau_Nam Then TxtDu_Co_Nt1.Double = TxtDu_Co_Nt00.Double
    End Sub
    Private Sub V_L_Du_Co00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_Co00.Double <> 0 Then
            TxtDu_No00.Double = 0
            TxtDu_No_Nt00.Double = 0
            If So_Dau_Nam Then TxtDu_No1.Double = 0
            If So_Dau_Nam Then TxtDu_No_Nt1.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_Nt00.Double = TxtDu_Co00.Double
        End If
        If So_Dau_Nam Then TxtDu_Co1.Double = TxtDu_Co00.Double
        If So_Dau_Nam Then TxtDu_Co_Nt1.Double = TxtDu_Co_Nt00.Double
    End Sub
    Private Sub V_L_Du_Co_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_Nt00.Double = TxtDu_Co00.Double
        End If
        If TxtDu_Co_Nt00.Double <> 0 Then TxtDu_No_Nt00.Double = 0
        If So_Dau_Nam Then TxtDu_No_Nt1.Double = TxtDu_No_Nt00.Double
        If So_Dau_Nam Then TxtDu_Co_Nt1.Double = TxtDu_Co_Nt00.Double
    End Sub
    Private Sub V_L_Du_No1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_No1.Double = TxtDu_No00.Double
    End Sub
    Private Sub V_L_Du_No_NT1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_No_Nt1.Double = TxtDu_No_Nt00.Double
    End Sub
    Private Sub V_L_Du_Co1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_Co1.Double = TxtDu_Co00.Double
    End Sub
    Private Sub V_L_Du_Co_NT1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_Co_Nt1.Double = TxtDu_Co_Nt00.Double
    End Sub
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTKCN", "Loai_Tk = N'1'", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK")
            TxtTen_Tk.Text = DrReturn.Item("Ten_TK")
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            If TxtMa_NT.Text.Trim = "" Then TxtTen_NT.Text = "" Else TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
            V_Reset()
        Else
            TxtTk.Text = ""
            TxtTen_Tk.Text = ""
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
    Private Sub V_Reset()
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_Nt00.Double = TxtDu_No00.Double
            TxtDu_Co_Nt00.Double = TxtDu_Co00.Double
            TxtDu_No_Nt1.Double = TxtDu_No1.Double
            TxtDu_Co_Nt1.Double = TxtDu_Co1.Double

            TxtDu_No_Nt00.InputMask = TxtDu_No00.InputMask.ToString.Trim
            TxtDu_Co_Nt00.InputMask = TxtDu_Co00.InputMask.ToString.Trim
            TxtDu_No_Nt1.InputMask = TxtDu_No1.InputMask.ToString.Trim
            TxtDu_Co_Nt1.InputMask = TxtDu_Co1.InputMask.ToString.Trim
        Else
            TxtDu_No_Nt00.InputMask = TxtDu_No_Nt00.Tag.ToString.Trim
            TxtDu_Co_Nt00.InputMask = TxtDu_Co_Nt00.Tag.ToString.Trim
            TxtDu_No_Nt1.InputMask = TxtDu_No_Nt1.Tag.ToString.Trim
            TxtDu_Co_Nt1.InputMask = TxtDu_Co_Nt1.Tag.ToString.Trim

        End If
        TxtDu_No_Nt00.Refresh()
        TxtDu_Co_Nt00.Refresh()
        TxtDu_No_Nt1.Refresh()
        TxtDu_Co_Nt1.Refresh()
    End Sub
#End Region
#Region "Vali --- KH"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TT", "DMTT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TT.Text = DrReturn.Item("Ma_TT")
            TxtTen_Ma_TT.Text = DrReturn.Item("Ten_TT")
        Else
            TxtMa_TT.Text = ""
            TxtTen_Ma_TT.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
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