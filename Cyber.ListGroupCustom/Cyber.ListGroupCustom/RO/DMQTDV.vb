Imports System.Data.SqlClient
Public Class DMQTDV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMQTDV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Txtma_ct.Focus()
        Txtten_ct.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_ct", "Dmct", "(Ma_ct = N'" + Txtma_ct.Text.Trim + "')", CyberSmlib)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'RemoveHandler TxtMa_mau_Nt.KeyPress, AddressOf TxtCodeError_KeyPress
        'AddHandler TxtMa_mau_Nt.KeyPress, AddressOf TxtCodeError_KeyPress
        RemoveHandler Txtma_ct.CyberValiting, AddressOf V_Ma_ct
        RemoveHandler Txtma_ct.CyberLeave, AddressOf L_Ma_ct
        AddHandler Txtma_ct.CyberValiting, AddressOf V_Ma_ct
        AddHandler Txtma_ct.CyberLeave, AddressOf L_Ma_ct
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Ma_ct"
    Private Sub V_Ma_ct(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_ct.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_ct", "Dmct", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ct(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_ct.Text = "" Then
            Txtten_ct.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_ct.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_ct.Text = DrReturn.Item("Ma_ct")
            Txtten_ct.Text = DrReturn.Item("Ten_ct")
        Else
            Txtma_ct.Text = ""
            Txtten_ct.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then Txtma_ct.Text = _Value
        If Txtma_ct.Text.ToString.Trim = "" Then
            MsgBox("Bạn chưa nhập loại chứng từ", MsgBoxStyle.Critical, oSysvar("M_cyber_ver"))
            Return
        End If

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
