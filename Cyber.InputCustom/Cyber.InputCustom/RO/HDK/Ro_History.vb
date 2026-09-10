Public Class Ro_History
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub CRM_Xem_Loc_CS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_AddHander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
#Region "Valid"

#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        If _Ma_Xe = "" Then
            MsgBox("Bạn chưa nhập biển số")
            Exit Sub

        End If

        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        'Me.Close()
    End Sub
End Class