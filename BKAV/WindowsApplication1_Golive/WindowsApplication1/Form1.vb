Imports System.Data.SqlClient
Imports System.Xml.Serialization
Imports System.Xml
Imports RestSharp
Imports System.IO
Public Class Form1
    Dim appCon As New SqlConnection("Server=58.186.204.29,2268;Database=CyberAppGolden9R3_KimSonGroup_QT;User Id=cyber_kimson;Password=cyber37yg8787g@!@;")

    Private Sub V_TaoHoaDon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaoHoaDon.Click
        'Dim ERR As String = ""
        'Dim xml As String = ""
        'Dim dsXML As New DataSet
        'Dim ds As DataSet = SQLExcuteStoreProcedure(appCon, "CP_HD_ThaiSon", "T##", ERR)
        'Dim sys As New Sys
        'If sys.V_TaoHoaDon(ds.Tables(0), ds.Tables(1), ds.Tables(2), dsXML, ERR, True) = False Then
        '    MsgBox(ERR)
        'Else
        '    xml = V_ConvertDataToXML(dsXML)
        'End If
        'MsgBox(xml)
    End Sub
    Private Sub btnPhatHanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhatHanh.Click
        'Dim ERR As String = ""
        'Dim xml As String = ""
        'Dim dsXML As New DataSet
        'Dim ds As DataSet = SQLExcuteStoreProcedure(appCon, "CP_HD_ThaiSon", "X##", ERR)
        'Dim sys As New Sys
        'If sys.V_TaoHoaDonVaPhatHanh(ds.Tables(0), ds.Tables(1), ds.Tables(2), dsXML, ERR, True) = False Then
        '    MsgBox(ERR)
        '    Return
        'Else
        '    xml = V_ConvertDataToXML(dsXML)
        'End If
        ' '' THUR TUCH LUU
        'MsgBox(xml)
    End Sub
    Private Sub V_Preview(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim sys As New Sys("b5a01eb0-71d1-4711-b10e-f978e770eb5a", "ns5ChyGhANxEN4KBJwsPDFo8xlmOzNPU9zsNtOdOcwA=:qdChuQKXkTMylim1bv95nw==", 6)
        Dim msg As String = sys.ViewHoaDonPDF("https://demo.ehoadon.vn/", "A000000017HDE")
        If String.IsNullOrEmpty(msg) = False Then
            MsgBox(msg)
        End If
    End Sub
    Public Function V_ConvertDataToXML(ByVal _Tb_names As String(), ByVal _Ds() As DataTable, Optional ByRef ReplaceDauThang As String = "!~!$!~!") As String
        If ReplaceDauThang.Trim = "" Then ReplaceDauThang = "!~!$!~!"
        Dim Result As String = ""

        For i As Integer = 0 To _Tb_names.Length - 1
            If _Ds.Length < i Then Exit For
            Dim _Dt As DataTable = _Ds(i).Copy
            _Dt.TableName = _Tb_names(i).Trim.ToUpper
            For Each dr As DataRow In _Dt.Rows
                Result += "<" + _Dt.TableName + ">"
                For Each dc As DataColumn In _Dt.Columns
                    Select Case dc.DataType.Name.ToUpper
                        Case "DATETIME"
                            Dim dt As Date = dr(dc)
                            Result += "<" & dc.ColumnName.ToUpper.Trim & ">" & dt.ToString("o").Trim & "</" & dc.ColumnName.ToUpper.Trim & ">" 'MInhDC sửa lại 
                        Case "INT", "INTEGER"
                            Dim _int As Integer = dr(dc)
                            Result += "<" & dc.ColumnName.ToUpper & ">" & _int.ToString(Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Trim & "</" & dc.ColumnName.ToUpper & ">"
                        Case "DECIMAL", "DOUBLE", "LONG"
                            Dim _long As Double = dr(dc)
                            Result += "<" & dc.ColumnName.ToUpper & ">" & _long.ToString(Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Trim & "</" & dc.ColumnName.ToUpper & ">"

                        Case Else
                            Result += "<" & dc.ColumnName.ToUpper & "><![CDATA[" & dr(dc).ToString.Trim.Replace("#", ReplaceDauThang) & "]]></" & dc.ColumnName.ToUpper & ">"
                    End Select
                Next
                Result += "</" + _Dt.TableName + ">"
            Next

        Next

        Return Result
    End Function

    Public Function V_ConvertDataToXML(ByVal ds As DataSet, Optional ByRef ReplaceDauThang As String = "!~!$!~!") As String
        Dim _Tb_names As New List(Of String)
        Dim _Ds As New List(Of DataTable)
        For Each dt As DataTable In ds.Tables
            _Tb_names.Add(dt.TableName)
            _Ds.Add(dt.Copy)
        Next
        Return V_ConvertDataToXML(_Tb_names.ToArray, _Ds.ToArray, ReplaceDauThang)
    End Function
    Public Function V_Convert(ByVal row As DataRow) As Dictionary(Of String, Object)
        Dim dict As Dictionary(Of String, Object) = row.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(c) c.ColumnName, Function(c) row(c))
        Return dict
    End Function
#Region "SQL"
    Private Function SQLExcuteStoreProcedure(ByVal Appconn As SqlConnection, ByVal Cp_Name As String, ByVal SqlParameter As String, ByRef strerror As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim i As Integer
            Dim strSQL As String = ""
            Dim strValue As String = ""
            Dim OpenApp As Boolean = True
            If Not Appconn.State = ConnectionState.Open Then Appconn.Open()

            For i = 0 To SqlParameter.Split("#").Length - 1
                strValue = SqlParameter.Split("#")(i).Replace("'", "''")
                If strValue <> "" Then
                    strSQL = strSQL + ",N'" + strValue + "'"
                Else
                    strSQL = strSQL + ",''"
                End If
            Next
            strSQL = strSQL.Trim
            strSQL = IIf(strSQL.Length > 0, strSQL.Substring(1, strSQL.Length - 1), "")
            If Cp_Name.PadLeft(4).ToUpper.Trim <> "dbo.".ToUpper.Trim Then
                strSQL = "dbo." + Cp_Name.Trim + " " + strSQL
                strSQL = " EXECUTE " + strSQL.Trim
            Else
                strSQL = Cp_Name.Trim + " " + strSQL
                strSQL = " EXECUTE " + strSQL.Trim
            End If

            da = New SqlDataAdapter(strSQL, Appconn)
            da.SelectCommand.CommandTimeout = 0
            da.Fill(ds)
            Appconn.Close()
            da.Dispose()
            Return ds
        Catch ex As System.Exception
            strerror = ex.Message
            V_WriteLog(strerror)
            Return Nothing
        End Try
        Return Nothing
    End Function
    Private Sub V_WriteLog(ByVal mserror As String)
        Dim strpath As String = Application.StartupPath + "\Logo.txt"
        If IO.Directory.Exists(IO.Path.GetDirectoryName(strpath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(strpath))
        System.IO.File.AppendAllText(strpath, Now.ToString("dd/MM/yyyy HH:mm:ss") & " - " & " : " & mserror + Environment.NewLine)

    End Sub
#End Region

   
   
End Class

