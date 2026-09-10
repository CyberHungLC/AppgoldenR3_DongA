Imports System.Text
Imports System.IO
Imports System.Net

Public Class ViewPDF
    Public Property strData As String
    Public Property byteArr As Byte()
    Public Property urlPDF As String

    Private Sub ViewPDF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim stream As New FileStream("..\..\Demo.pdf", FileMode.Open)
        'If byteArr Is Nothing Then
        '    byteArr = Convert.FromBase64String(strData)
        'End If
        'If byteArr Is Nothing Then
        '    MsgBox("Dữ liệu không có")
        '    Return
        'End If
        'Dim stream As MemoryStream = New MemoryStream(byteArr)
        'PdfViewer1.LoadDocument(stream)
        ServicePointManager.SecurityProtocol = CType(768, SecurityProtocolType) Or CType(3072, SecurityProtocolType)


        Using client As New WebClient
            Dim content As Byte() = client.DownloadData(urlPDF)
            Dim stream As MemoryStream = New MemoryStream(content)
            PdfViewer1.LoadDocument(stream)
        End Using
    End Sub
End Class