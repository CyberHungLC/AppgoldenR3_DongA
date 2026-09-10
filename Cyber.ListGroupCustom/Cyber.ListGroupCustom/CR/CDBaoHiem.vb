Imports System.Windows.Forms
Public Class CDBaoHiem
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CDBaoHiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Xe)

        TxtNgay_BD.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        'TxtNam.Text = Me.Key_Nam.ToString
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_BD.Value = Now.Date()
            TxtNgay_KT.Value = Now.Date()
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_BH
        RemoveHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        RemoveHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH

        '-Ma_LHBH
        RemoveHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        RemoveHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_BH.Text = "" Then
            TxtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_BH")
            TxtTen_BH.Text = DrReturn.Item("Ten_BH")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_LHBH"
    Private Sub V_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_LHBH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_LHBH", "DmLHBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_LHBH.Text = "" Then
            TxtTen_LHBH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_LHBH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHBH.Text = DrReturn.Item("Ma_LHBH")
            TxtTen_LHBH.Text = DrReturn.Item("Ten_LHBH")
        Else
            TxtMa_LHBH.Text = ""
            TxtTen_LHBH.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Xe.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e)
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.V_Exit(sender, e)
    End Sub

    Private Sub Labdia_chivat_Click(sender As Object, e As EventArgs) Handles LabDia_chi.Click

    End Sub


#End Region
End Class
