Public Class FrmUpdateTienKHCK
    Public Property Tien_KH_CK() As Decimal
        Get
            Tien_KH_CK = M_Tien_kh_CK
        End Get
        Set(ByVal Value As Decimal)
            M_Tien_kh_CK = Value
        End Set
    End Property
    Dim M_Tien_kh_CK As Decimal = 0
    Private Sub FrmUpdateRoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtTien_KH_CK.Double = M_Tien_kh_CK
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        Me.Tien_KH_CK = TxtTien_KH_CK.Double
        M_Tien_kh_CK = TxtTien_KH_CK.Double
        'CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
