Public Class ROXPTFilter

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub ROXPTFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct2)

        V_Load()
        AddHandler TxtSo_RO.Leave, AddressOf L_So_RO
        AddHandler ButtOK.Click, AddressOf V_Nhan
        'Ma_SMS
        AddHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_VT
        AddHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_VT
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
    Private Sub L_So_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = Now.Date
        TxtSo_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_RO.Text, "", M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True

        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_VT.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & Me.M_User_Name
        '-----------------------------------------------------------------------------
        Me.Tag = M_strParameterStore
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub

#Region "Valid --- Ma_VT"
    Private Sub V_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_VT.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_VT", "DMVT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_VT.Text = "" Then
            TxtTen_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_VT.Text = DrReturn.Item("Ma_VT")
            TxtTen_VT.Text = DrReturn.Item("Ten_VT")
        Else
            TxtMa_VT.Text = ""
            TxtTen_VT.Text = ""
        End If
    End Sub
#End Region
End Class
