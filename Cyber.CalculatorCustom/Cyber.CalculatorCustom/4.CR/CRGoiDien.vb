Imports System.Windows.Forms
Public Class CRGoiDien
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim _Dien_thoai As String = "", _Stt_Rec As String = "", _Ten_KH As String = "", _Ipphone As String = "", _Url_Call As String = "", _Domain As String = "", _Access_key As String = ""
    Private Sub CRCG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
        'M_Ma_get = Me.Para(M_VT_PARA + 2).Trim
        _Dien_thoai = Me.Para(M_VT_PARA + 2).Trim

        _Ten_KH = Me.Para(M_VT_PARA + 3).Trim
        _Stt_Rec = Me.Para(M_VT_PARA + 6).Trim
        If _Dien_thoai <> "" Then
            txtDien_thoai.Text = Replace(_Dien_thoai, " ", "", 1, -1)
        End If

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub

#Region "Load"
    Protected Sub V_Load()
        AddHandler ButtCall.Click, AddressOf V_Nhan
    End Sub
    Protected Sub V_Addhander()
        AddHandler Butt1.Click, AddressOf L_butt1
        AddHandler Butt2.Click, AddressOf L_butt2
        AddHandler Butt3.Click, AddressOf L_butt3
        AddHandler Butt4.Click, AddressOf L_butt4
        AddHandler Butt5.Click, AddressOf L_butt5
        AddHandler Butt6.Click, AddressOf L_butt6
        AddHandler Butt7.Click, AddressOf L_butt7
        AddHandler Butt8.Click, AddressOf L_butt8
        AddHandler Butt9.Click, AddressOf L_butt9
        AddHandler Butt0.Click, AddressOf L_butt0
        AddHandler ButtS.Click, AddressOf L_buttS
        AddHandler ButtT.Click, AddressOf L_buttT
        AddHandler ButtDel.Click, AddressOf L_buttdel
    End Sub
    'Private Sub CRCG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    'If Asc(e.KeyChar) = 48 Then L_butt0(sender, e)
    'If Asc(e.KeyChar) = 49 Then L_butt1(sender, e)
    'If Asc(e.KeyChar) = 50 Then L_butt2(sender, e)
    'If Asc(e.KeyChar) = 51 Then L_butt3(sender, e)
    'If Asc(e.KeyChar) = 52 Then L_butt4(sender, e)
    'If Asc(e.KeyChar) = 53 Then L_butt5(sender, e)
    'If Asc(e.KeyChar) = 54 Then L_butt6(sender, e)
    'If Asc(e.KeyChar) = 55 Then L_butt7(sender, e)
    'If Asc(e.KeyChar) = 56 Then L_butt8(sender, e)
    'If Asc(e.KeyChar) = 57 Then L_butt9(sender, e)
    'If Asc(e.KeyChar) = 46 Then L_buttdel(sender, e)
    'End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Gọi điện"
    Private Sub L_butt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "1"
    End Sub
    Private Sub L_butt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "2"
    End Sub
    Private Sub L_butt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "3"
    End Sub
    Private Sub L_butt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "4"
    End Sub
    Private Sub L_butt5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "5"
    End Sub
    Private Sub L_butt6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "6"
    End Sub
    Private Sub L_butt7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "7"
    End Sub
    Private Sub L_butt8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "8"
    End Sub
    Private Sub L_butt9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "9"
    End Sub
    Private Sub L_butt0(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "0"
    End Sub
    Private Sub L_buttS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "*"
    End Sub
    Private Sub L_buttT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = txtDien_thoai.Text + "#"
    End Sub
    Private Sub L_buttdel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDien_thoai.Text = ""
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtDien_thoai.Text.Trim = "" Then
            MsgBox("Bạn chưa nhập số điện thoại")
            Exit Sub
        End If


        Dim dsgetCuocgoi As DataSet
        dsgetCuocgoi = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CMSCuocGoi", txtDien_thoai.Text.Trim + "#" + _Ten_KH.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim + "#" + _Stt_Rec.Trim)
        If dsgetCuocgoi.Tables(0).Rows.Count < 1 Then Exit Sub

        _Dien_thoai = dsgetCuocgoi.Tables(0).Rows(0).Item("Dien_thoai")
        _Stt_Rec = dsgetCuocgoi.Tables(0).Rows(0).Item("Stt_Rec")
        _Ten_KH = dsgetCuocgoi.Tables(0).Rows(0).Item("Ten_KH")
        _Ipphone = dsgetCuocgoi.Tables(0).Rows(0).Item("Ipphone")
        _Url_Call = dsgetCuocgoi.Tables(0).Rows(0).Item("Url_Call")
        _Domain = dsgetCuocgoi.Tables(0).Rows(0).Item("Domain")
        _Access_key = dsgetCuocgoi.Tables(0).Rows(0).Item("Access_key")


        'Dim _sysCMS As New Cyber.CMSVNPT.Sys



        '_sysCMS.V_call(_Ten_KH, _Stt_Rec, _Dien_thoai, _Url_Call, _Domain, _Access_key, _Ipphone, M_User_Name.Trim, M_Ma_Dvcs.Trim)



        ' Gọi trên web
        'Dim URL As String = _sysCMS.V_URLCall(_Ten_KH, _Stt_Rec, _Dien_thoai, _Url_Call, _Domain, _Access_key, _Ipphone, M_User_Name.Trim, M_Ma_Dvcs.Trim)

        'Dim proc As New Process()
        'proc.StartInfo.UseShellExecute = True
        'proc.StartInfo.FileName = URL
        'proc.Start()


    End Sub

#End Region

End Class
