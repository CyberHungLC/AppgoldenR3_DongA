Imports System.IO
Imports System.Windows.Forms
Imports System.Net
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack


Public Class DmKh
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private vTbTP, vTbQuan, vTbXa As DataView
    Private _Load_TP As Boolean = False
    Private Sub DmKh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        V_LoadTinh_Quan_Xa()
        V_Load()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Kh, TxtNh_Kh1, TxtNh_Kh2, TxtNh_Kh3, TxtNh_Kh4, TxtNh_Kh5)
        TxtMa_Kh.Focus()
    End Sub
#Region "LoadTinh_Quan_Xa"
    Private Sub V_LoadTinh_Quan_Xa()
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        TbTP = DsTb.Tables(0).Copy
        TbQuan = DsTb.Tables(1).Copy
        TbXa = DsTb.Tables(2).Copy

        vTbTP = New DataView(TbTP)
        vTbQuan = New DataView(TbQuan)
        vTbXa = New DataView(TbXa)

        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")
    End Sub
    Private Function GetTab(ByVal Tb_name As String, Optional ByVal Order As String = "1=1", Optional ByVal Key As String = "1=1") As DataTable
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetTable", Tb_name + "#" + Key + "#" + Order)
        GetTab = DsTb.Tables(0).Copy
    End Function
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP(False)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_xa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Xa(False)
    End Sub
    Private Sub V_Ma_TP(ByVal Load As Boolean)
        If Load Then
            CmbMa_TP.SelectedValue = TxtMa_TP.Text.Trim
        Else
            TxtMa_TP.Text = CmbMa_TP.SelectedValue.ToString.Trim
        End If
        vTbQuan.RowFilter = "Ma_Tp = '" & TxtMa_TP.Text.Trim & "'"
    End Sub
    Private Sub V_Ma_Quan(ByVal Load As Boolean)
        If Load Then
            CmbMa_Quan.SelectedValue = TxtMa_Quan.Text.Trim
        Else
            TxtMa_Quan.Text = CmbMa_Quan.SelectedValue.ToString.Trim
        End If
        vTbXa.RowFilter = "Ma_Quan = '" & TxtMa_Quan.Text.Trim() & "'"
    End Sub
    Private Sub V_Ma_Xa(ByVal Load As Boolean)
        If Load Then
            CmbMa_Xa.SelectedValue = TxtMA_Xa.Text.Trim
        Else
            TxtMA_Xa.Text = CmbMa_Xa.SelectedValue.ToString.Trim
        End If
    End Sub
#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_Kh1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kh1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kh2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kh2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kh3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kh3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kh4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Kh4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kh5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Kh5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub

    Protected Sub V_AddhanderMaster()

        AddHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress

        '---TInh thanh
        AddHandler CmbMa_TP.SelectedValueChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedValueChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        AddHandler CmbMa_Xa.SelectedValueChanged, AddressOf V_Ma_xa_SelectedIndexChanged


        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        '---Ten_KH

        RemoveHandler TxtTen_Kh.Leave, AddressOf V_TxtTen_kh
        RemoveHandler TxtDia_Chi.Leave, AddressOf V_TxtDia_Chi

        AddHandler TxtTen_Kh.Leave, AddressOf V_TxtTen_kh
        AddHandler TxtDia_Chi.Leave, AddressOf V_TxtDia_Chi

        '--KH1
        RemoveHandler TxtNh_Kh1.CyberValiting, AddressOf V_NH_KH1
        RemoveHandler TxtNh_Kh1.CyberLeave, AddressOf L_NH_KH1
        AddHandler TxtNh_Kh1.CyberValiting, AddressOf V_NH_KH1
        AddHandler TxtNh_Kh1.CyberLeave, AddressOf L_NH_KH1
        '--KH2
        RemoveHandler TxtNh_Kh2.CyberValiting, AddressOf V_NH_KH2
        RemoveHandler TxtNh_Kh2.CyberLeave, AddressOf L_NH_KH2
        AddHandler TxtNh_Kh2.CyberValiting, AddressOf V_NH_KH2
        AddHandler TxtNh_Kh2.CyberLeave, AddressOf L_NH_KH2
        '--KH3
        RemoveHandler TxtNh_Kh3.CyberValiting, AddressOf V_NH_KH3
        RemoveHandler TxtNh_Kh3.CyberLeave, AddressOf L_NH_KH3
        AddHandler TxtNh_Kh3.CyberValiting, AddressOf V_NH_KH3
        AddHandler TxtNh_Kh3.CyberLeave, AddressOf L_NH_KH3
        '--KH4
        RemoveHandler TxtNh_Kh4.CyberValiting, AddressOf V_NH_KH4
        RemoveHandler TxtNh_Kh4.CyberLeave, AddressOf L_NH_KH4
        AddHandler TxtNh_Kh4.CyberValiting, AddressOf V_NH_KH4
        AddHandler TxtNh_Kh4.CyberLeave, AddressOf L_NH_KH4
        '--KH5
        RemoveHandler TxtNh_Kh5.CyberValiting, AddressOf V_NH_KH5
        RemoveHandler TxtNh_Kh5.CyberLeave, AddressOf L_NH_KH5
        AddHandler TxtNh_Kh5.CyberValiting, AddressOf V_NH_KH5
        AddHandler TxtNh_Kh5.CyberLeave, AddressOf L_NH_KH5

        '--TK
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
        '--> Lấy thông tin mã số thuế
        AddHandler TxtMa_So_Thue.Leave, AddressOf V_LoadInfoVAT2
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Ten_KH,Dia_Chi"
    Private Sub V_TxtTen_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTen_KhVat.Text = IIf(TxtTen_KhVat.Text.Trim = "", TxtTen_Kh.Text, TxtTen_KhVat.Text)
    End Sub
    Private Sub V_TxtDia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtDia_ChiVat.Text = IIf(TxtDia_ChiVat.Text.Trim = "", TxtDia_Chi.Text, TxtDia_ChiVat.Text)
    End Sub
#End Region
#Region "Vali --- NH_KH1"
    Private Sub V_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kh1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kh1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH2"
    Private Sub V_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kh2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kh2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH3"
    Private Sub V_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kh3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kh3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH4"
    Private Sub V_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kh4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kh4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH5"
    Private Sub V_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kh5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kh5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kh5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kh5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTk.Text = DrReturn.Item("TK")
        If TxtTk.Text = "" Then Exit Sub
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        '--> Check Save
        Dim M_StrFieldValue As String = ""
        Dim M_StrFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_StrFieldName, M_StrFieldValue, "")
        Me.Tag_Field = M_StrFieldName
        Me.Tag_Value = M_StrFieldValue
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CheckSaveDmKh", Mode.Trim & "#" & M_StrFieldName & "#" & M_StrFieldValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Kh.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Lấy thông tin MST"
    Private Sub V_LoadInfoVAT()
        If TxtMa_so_thue.Text = "" Then Exit Sub
        'If TxtMa_so_thue.Text.Length < 10 Then Exit Sub
        'For i As Integer = 0 To TxtMa_so_thue.Text.Length - 1
        '    If IsNumeric(TxtMa_so_thue.Text.Substring(i, 1)) = False Then Exit Sub
        'Next

        Dim inStream As StreamReader
        Dim webRequest As Net.WebRequest
        Dim webresponse As Net.WebResponse
        Dim Wb1 As String = ""

        webRequest = Net.WebRequest.Create("https://infodoanhnghiep.com/tim-kiem/auto/" + TxtMa_So_Thue.Text + "/")

        'webRequest = Net.WebRequest.Create("https://www.tratencongty.com/search/" + TxtMa_So_Thue.Text)

        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream())
        Wb1 = inStream.ReadToEnd()
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.DocumentText = Wb1
        Ten(Wb1)


    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim divs = WebBrowser1.Document.Body.GetElementsByTagName("div")

        Dim i As Integer = 0
        Dim d As HtmlElement
        WebBrowser2.Refresh()
        For Each d In divs

            'If d.GetAttribute("className") = "search-results" Then
            '    WebBrowser2.DocumentText = d.InnerHtml
            '    i = i + 1

            'End If
            If d.GetAttribute("className") = "company-item" Then
                WebBrowser2.DocumentText = d.InnerHtml
                i = i + 1
            End If
        Next

        If i = 0 Then

            'WebBrowser2.DocumentText = "<p style=""color:RED;text-align:center;"">MÃ SỐ THUẾ KHÔNG TỒN TẠI</p>"
            'V_LoadInfoVAT2() '--Nếu không có thì gọi tiếp
        End If

        WebBrowser2.AllowNavigation = True
    End Sub
    Sub Ten(ByVal htmlContent As String)


        ' Sử dụng Regular Expression để tìm tên công ty
        Dim pattern As String = "<h3 class=""company-name""><a[^>]*>(.*?)</a></h3>"
        Dim match As Match = Regex.Match(htmlContent, pattern)

        ' Kiểm tra và in ra tên công ty
        If match.Success Then
            Dim companyName As String = match.Groups(1).Value.Trim()
            TxtTen_Kh.Text = companyName
        End If

        'Tìm địa chỉ
        pattern = "<p>\s*Địa chỉ:\s*(.*?)</p>"
        match = Regex.Match(htmlContent, pattern)


        ' Kiểm tra và in ra địa chỉ
        If match.Success Then
            Dim AddName As String = match.Groups(1).Value.Trim()
            TxtDia_Chi.Text = AddName
        End If
    End Sub
    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

        WebBrowser2.ScriptErrorsSuppressed = True
    End Sub
#End Region
    Private Sub V_LoadInfoVAT2()

        Net.ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True
        Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12 ' Đảm bảo sử dụng TLS 1.2


        Dim url As String = "https://thuvienphapluat.vn/ma-so-thue/tra-cuu-ma-so-thue-doanh-nghiep?timtheo=ma-so-thue&tukhoa=" + TxtMa_So_Thue.Text
        Dim request As HttpWebRequest = CType(webRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36"
        request.Referer = "https://thuvienphapluat.vn/"
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8"
        request.Headers.Add("Accept-Language", "en-US,en;q=0.9")
        ' Thêm CookieContainer để duy trì session nếu cần
        request.CookieContainer = New Net.CookieContainer()
        ' (Tùy chọn) Thêm Proxy nếu IP bị chặn
        'Dim proxy As New Net.WebProxy("http://yourproxy:port")
        'webRequest.Proxy = proxy

        Try
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Dim responseText As String = reader.ReadToEnd()
                'WebBrowser2.ScriptErrorsSuppressed = True
                'WebBrowser2.DocumentText = responseText
                GetTT2NameHTP(responseText)
            End Using
        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
        End Try
        WebBrowser2.AllowNavigation = True
    End Sub

    Private Sub V_LoadInfoVAT2_1(ByVal HTTP_Name As String)

        Dim url As String = "https://thuvienphapluat.vn" + HTTP_Name.Trim
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36"
        request.Referer = "https://thuvienphapluat.vn/"
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8"
        request.Headers.Add("Accept-Language", "en-US,en;q=0.9")

        ' Thêm CookieContainer để duy trì session nếu cần
        request.CookieContainer = New Net.CookieContainer()
        ' (Tùy chọn) Thêm Proxy nếu IP bị chặn
        'Dim proxy As New Net.WebProxy("http://yourproxy:port")
        'webRequest.Proxy = proxy

        Try
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Dim responseText As String = reader.ReadToEnd()
                WebBrowser2.ScriptErrorsSuppressed = True
                WebBrowser2.DocumentText = responseText
                GetTTCongTY(responseText)
            End Using
        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
        End Try
        WebBrowser2.AllowNavigation = True
    End Sub

    Sub GetTT2NameHTP(ByVal htmlContent As String)
        Dim doc As New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(htmlContent)
        ' Tìm phần tử chứa địa chỉ
        Dim linkNode = doc.DocumentNode.SelectSingleNode("//tr[contains(@class, 'item_mst')]//a[contains(@href, '/ma-so-thue/')]")

        If linkNode IsNot Nothing Then
            Dim href As String = linkNode.GetAttributeValue("href", "")
            V_LoadInfoVAT2_1(LTrim(RTrim(href)))
        End If

    End Sub
    Sub GetTTCongTY(ByVal htmlContent As String)
        Dim doc As New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(htmlContent)
        ' Tìm phần tử chứa địa chỉ
        Dim tenCongTyNode = doc.DocumentNode.SelectSingleNode("//span[@id='fill_TenDoanhNghiep']")

        Dim diaChiNode = doc.DocumentNode.SelectSingleNode("//span[@id='fill_DiaChiTruSo']")

        If tenCongTyNode IsNot Nothing AndAlso diaChiNode IsNot Nothing Then
            Dim name As String = tenCongTyNode.InnerText.Trim()
            Dim address As String = diaChiNode.InnerText.Trim()
            If TxtTen_Kh.Text = "" Then TxtTen_Kh.Text = name
            If TxtTen_KhVat.Text = "" Then TxtTen_KhVat.Text = name
            If TxtDia_Chi.Text = "" Then TxtDia_Chi.Text = address
            If TxtDia_ChiVat.Text = "" Then TxtDia_ChiVat.Text = address

        End If

    End Sub


End Class

