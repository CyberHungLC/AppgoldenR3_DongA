Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports System.Security.Cryptography
Public Delegate Function ExecCommandFunc(ByVal BkavPartnerGUID As String, ByVal EncryptedCommandData As String) As String
Public Class SecurityData

    Public Shared Function Encrypt_Aes(ByVal Base64Plaintext As String, ByVal Base64Key_IV As String, ByRef Base64Result As String) As String
        Dim array As Byte() = Nothing
        Return Encrypt_Aes(Base64Plaintext, Base64Key_IV, False, Base64Result, array)
    End Function

    Public Shared Function Encrypt_Aes(ByVal Base64Plaintext As String, ByVal Base64Key_IV As String, ByRef Result As Byte()) As String
        Dim text As String = Nothing
        Return Encrypt_Aes(Base64Plaintext, Base64Key_IV, False, text, Result)
    End Function

    Public Shared Function Encrypt_Aes(ByVal Plaintext As Byte(), ByVal Base64Key_IV As String, ByRef Base64Result As String) As String
        Dim array As Byte() = Nothing
        Return Encrypt_Aes(Plaintext, Base64Key_IV, True, Base64Result, array)
    End Function

    Public Shared Function Encrypt_Aes(ByVal Plaintext As Byte(), ByVal Base64Key_IV As String, ByRef Result As Byte()) As String
        Dim text As String = Nothing
        Return Encrypt_Aes(Plaintext, Base64Key_IV, False, text, Result)
    End Function

    Private Shared Function Encrypt_Aes(ByVal Plaintext As Object, ByVal Base64Key_IV As String, ByVal IsOutString As Boolean, ByRef Result_Base64string As String, ByRef Result_bytes As Byte()) As String
        Dim result As String = ""
        Result_Base64string = Nothing
        Result_bytes = Nothing
        If Plaintext Is Nothing Then
            Return "Plaintext is null"
        End If

        If Base64Key_IV Is Nothing OrElse Base64Key_IV.Length <= 0 Then
            Return "Base64Key_IV is null or empty"
        End If

        Dim array As String() = Base64Key_IV.Split(":"c)
        Try
            Result_bytes = Encrypt_Aes(Plaintext, Convert.FromBase64String(array(0)), Convert.FromBase64String(array(1)))
            If IsOutString Then
                Result_Base64string = Convert.ToBase64String(Result_bytes)
            End If
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return result
    End Function

    Private Shared Function Encrypt_Aes(ByVal Plaintext As Object, ByVal Key As Byte(), ByVal IV As Byte()) As Byte()
        If Plaintext Is Nothing Then
            Throw New ArgumentNullException("Data")
        End If

        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If

        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("IV")
        End If

        Using aes As System.Security.Cryptography.RijndaelManaged = Rijndael.Create()
            aes.Key = Key
            aes.IV = IV
            Dim transform As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
            Using memoryStream As MemoryStream = New MemoryStream()
                Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Write)
                    If TypeOf Plaintext Is Byte() Then
                        Dim array As Byte() = TryCast(Plaintext, Byte())
                        cryptoStream.Write(array, 0, array.Length)
                        cryptoStream.Close()
                    Else
                        Using streamWriter As StreamWriter = New StreamWriter(cryptoStream)
                            streamWriter.Write(Plaintext)
                        End Using
                    End If

                    Return memoryStream.ToArray()
                End Using
            End Using
        End Using
    End Function

    Public Shared Function Decrypt_Aes(ByVal Base64CipherText As String, ByVal Base64Key_IV As String, ByRef result As String) As String
        Dim array As Byte() = Nothing
        Return Decrypt_Aes(Base64CipherText, Base64Key_IV, False, result, array)
    End Function

    Public Shared Function Decrypt_Aes(ByVal Base64CipherText As String, ByVal Base64Key_IV As String, ByRef result As Byte()) As String
        Dim text As String = Nothing
        Return Decrypt_Aes(Base64CipherText, Base64Key_IV, False, text, result)
    End Function

    Public Shared Function Decrypt_Aes(ByVal CipherText As Byte(), ByVal Base64Key_IV As String, ByRef result As String) As String
        Dim array As Byte() = Nothing
        Return Decrypt_Aes(CipherText, Base64Key_IV, True, result, array)
    End Function

    Public Shared Function Decrypt_Aes(ByVal CipherText As Byte(), ByVal Base64Key_IV As String, ByRef result As Byte()) As String
        Dim text As String = Nothing
        Return Decrypt_Aes(CipherText, Base64Key_IV, False, text, result)
    End Function

    Private Shared Function Decrypt_Aes(ByVal CipherText As Object, ByVal Base64Key_IV As String, ByVal isOutString As Boolean, ByRef result_string As String, ByRef result_bytes As Byte()) As String
        Dim result As String = ""
        result_string = Nothing
        result_bytes = Nothing
        If CipherText Is Nothing Then
            Return "CipherText is null"
        End If

        If Base64Key_IV Is Nothing OrElse Base64Key_IV.Length <= 0 Then
            Return "Base64Key_IV is null or empty"
        End If

        Dim array As String() = Base64Key_IV.Split(":"c)
        If array Is Nothing OrElse array.Length <> 2 Then
            Return "Base64Key_IV is invalid"
        End If

        Try
            Dim array2 As Byte() = TryCast(CipherText, Byte())
            If array2 Is Nothing Then
                Dim text As String = TryCast(CipherText, String)
                If text Is Nothing Then
                    Return "CipherText is invalid"
                End If

                array2 = Convert.FromBase64String(text)
            End If

            DecryptStringFromBytes_Aes(array2, Convert.FromBase64String(array(0)), Convert.FromBase64String(array(1)), isOutString, result_string, result_bytes)
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return result
    End Function

    Private Shared Sub DecryptStringFromBytes_Aes(ByVal CipherText As Byte(), ByVal Key As Byte(), ByVal IV As Byte(), ByVal isOutString As Boolean, ByRef result_string As String, ByRef result_bytes As Byte())
        result_string = Nothing
        result_bytes = Nothing
        If CipherText Is Nothing OrElse CipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If

        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If

        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("IV")
        End If

        Using aes As System.Security.Cryptography.RijndaelManaged = Rijndael.Create() 'Aes = aes.Create()
            aes.Key = Key
            aes.IV = IV
            Dim transform As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
            If Not isOutString Then
                Using memoryStream As MemoryStream = New MemoryStream()
                    Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Write)
                        cryptoStream.Write(CipherText, 0, CipherText.Length)
                        cryptoStream.Close()
                        result_bytes = memoryStream.ToArray()
                    End Using
                End Using
            Else
                Using memoryStream As MemoryStream = New MemoryStream(CipherText)
                    Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Read)
                        Using streamReader As StreamReader = New StreamReader(cryptoStream)
                            result_string = streamReader.ReadToEnd()
                        End Using
                    End Using
                End Using
            End If
        End Using
    End Sub

    Public Shared Function Encrypt(ByVal enObject As Object, ByVal key As String, ByRef result As String) As String
        Return Encrypt(enObject, key, True, result)
    End Function

    Public Shared Function Encrypt(ByVal enObject As Object, ByVal key As String, ByVal useHashing As Boolean, ByRef result As String) As String
        result = Nothing
        Dim text As String = ""
        Try
            Dim bytes As Byte() = Convertor.ObjectToBytes(enObject)
            Return Encrypt(bytes, key, useHashing, result)
        Catch ex As Exception
            Return ex.ToString()
        End Try
    End Function

    Public Shared Function Encrypt(ByVal bytes As Byte(), ByVal key As String, ByVal useHashing As Boolean, ByRef result As String) As String
        result = Nothing
        Dim result2 As String = ""
        Try
            Dim key2 As Byte() = Nothing
            If useHashing Then
                Using mD5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                    key2 = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(key))
                    mD5CryptoServiceProvider.Clear()
                End Using
            Else
                key2 = Encoding.UTF8.GetBytes(key)
            End If

            Using tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                tripleDESCryptoServiceProvider.Key = key2
                tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
                tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7
                Using cryptoTransform As ICryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor()
                    Dim inArray As Byte() = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length)
                    tripleDESCryptoServiceProvider.Clear()
                    result = Convert.ToBase64String(inArray)
                End Using
            End Using
        Catch ex As Exception
            result2 = ex.ToString()
        End Try

        Return result2
    End Function

    Public Shared Function Decrypt(ByVal cipherString As String, ByVal key As String, ByRef result As Object) As String
        Return Decrypt(cipherString, key, True, result)
    End Function

    Public Shared Function Decrypt(ByVal cipherString As String, ByVal key As String, ByVal useHashing As Boolean, ByRef result As Object) As String
        Dim text As String = ""
        result = Nothing
        Try
            Dim bytes As Byte() = Nothing
            text = Decrypt(cipherString, key, useHashing, bytes)
            If text.Length > 0 Then
                Return text
            End If

            result = Convertor.BytesToObject(bytes)
        Catch ex As Exception
            text = ex.ToString()
        End Try

        Return text
    End Function

    Public Shared Function Decrypt(ByVal cipherString As String, ByVal key As String, ByVal useHashing As Boolean, ByRef result As Byte()) As String
        Dim result2 As String = ""
        result = Nothing
        Try
            Dim key2 As Byte() = Nothing
            If useHashing Then
                Using mD5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                    key2 = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(key))
                    mD5CryptoServiceProvider.Clear()
                End Using
            Else
                key2 = Encoding.UTF8.GetBytes(key)
            End If

            Using tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                tripleDESCryptoServiceProvider.Key = key2
                tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
                tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7
                Using cryptoTransform As ICryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor()
                    Dim array As Byte() = Convert.FromBase64String(cipherString)
                    result = cryptoTransform.TransformFinalBlock(array, 0, array.Length)
                    tripleDESCryptoServiceProvider.Clear()
                End Using
            End Using
        Catch ex As Exception
            result2 = ex.ToString()
        End Try

        Return result2
    End Function
End Class
Module Convertor
    Public Class Utf8StringWriter
        Inherits StringWriter
        Public ReadOnly Property Encoding As Encoding
            Get
                Return Encoding.UTF8
            End Get

        End Property
    End Class

    Function JsonToObject(Of T As Class)(ByVal data As Object, ByRef obj As T) As String
        obj = Nothing
        Try
            obj = JsonConvert.DeserializeObject(Of T)(Convert.ToString(data))
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return ""
    End Function

    Function ObjectToJson(ByVal obj As Object, ByRef value As String) As String
        value = ""
        Try
            value = JsonConvert.SerializeObject(obj)
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return ""
    End Function

    Function ObjectToXML(ByVal obj As Object, ByVal prefixXML As String, ByVal namespaceXML As String, ByRef xml As String) As String
        Dim result As String = ""
        xml = ""
        Try
            Using utf8StringWriter As Utf8StringWriter = New Utf8StringWriter()
                Using xmlWriter As XmlWriter = xmlWriter.Create(utf8StringWriter, New XmlWriterSettings With {.Indent = True})
                    xmlWriter.WriteStartDocument(True)
                    Dim xmlSerializerNamespaces As XmlSerializerNamespaces = New XmlSerializerNamespaces()
                    xmlSerializerNamespaces.Add(prefixXML, namespaceXML)
                    Dim xmlSerializer As XmlSerializer = New XmlSerializer(obj.[GetType]())
                    xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces)
                    xml = utf8StringWriter.ToString()
                End Using
            End Using
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function ObjectToXML(ByVal obj As Object, ByVal prefixXML As List(Of String), ByVal namespaceXML As List(Of String), ByRef xml As String) As String
        Dim result As String = ""
        xml = ""
        Try
            Using utf8StringWriter As Utf8StringWriter = New Utf8StringWriter()
                Using xmlWriter As XmlWriter = xmlWriter.Create(utf8StringWriter, New XmlWriterSettings With {.Indent = True})
                    xmlWriter.WriteStartDocument(True)
                    Dim xmlSerializerNamespaces As XmlSerializerNamespaces = New XmlSerializerNamespaces()
                    For i As Integer = 0 To prefixXML.Count - 1
                        xmlSerializerNamespaces.Add(prefixXML(i), namespaceXML(i))
                    Next

                    Dim xmlSerializer As XmlSerializer = New XmlSerializer(obj.[GetType]())
                    xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces)
                    xml = utf8StringWriter.ToString()
                End Using
            End Using
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function XMLToObject(Of T)(ByVal xml As String, ByRef obj As T) As String
        Dim result As String = ""
        obj = Nothing
        Try
            Using textReader As TextReader = New StringReader(xml)
                obj = CType(New XmlSerializer(GetType(T)).Deserialize(textReader), T)
            End Using
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function StringToObject(Of T As Class)(ByVal stringData As String, ByRef obj As T) As String
        Return StringToObject(False, stringData, obj)
    End Function

    Function StringToObject(Of T As Class)(ByVal isXML As Boolean, ByVal stringData As String, ByRef obj As T) As String
        Dim text As String = ""
        obj = Nothing
        If isXML Then
            Return XMLToObject(stringData, obj)
        End If

        Return JsonToObject(stringData, obj)
    End Function

    Function ObjectToString(Of T As Class)(ByVal objectData As T, ByRef value As String) As String
        Return ObjectToString(False, objectData, value)
    End Function

    Function ObjectToString(Of T As Class)(ByVal isXML As Boolean, ByVal objectData As T, ByRef value As String) As String
        Dim text As String = ""
        value = Nothing
        If isXML Then
            Return ObjectToXML(objectData, "", "", value)
        End If

        Return ObjectToJson(objectData, value)
    End Function

    Function ObjectToBase64String(ByVal obj As Object, ByRef value As String) As String
        Dim result As String = ""
        value = Nothing
        If obj Is Nothing Then
            Return "Error: Object is null @ObjectToBase64String"
        End If

        Try
            value = ObjectToBase64String(obj)
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function ObjectToBase64String(ByVal obj As Object) As String
        If TypeOf obj Is Byte() Then
            Return Convert.ToBase64String(CType(obj, Byte()))
        End If

        Return Convert.ToBase64String(ObjectToBytes(obj))
    End Function

    Function ObjectToBytes(ByVal obj As Object) As Byte()
        If obj Is Nothing Then
            Return Nothing
        End If

        Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
        Using memoryStream As MemoryStream = New MemoryStream()
            binaryFormatter.Serialize(memoryStream, obj)
            Return memoryStream.ToArray()
        End Using
    End Function

    Function Base64StringToObject(ByVal base64 As String, ByRef value As Byte()) As String
        Dim result As String = ""
        value = Nothing
        Try
            value = Convert.FromBase64String(base64)
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function Base64StringToObject(ByVal base64 As String, ByRef value As Object) As String
        Dim result As String = ""
        value = Nothing
        Try
            value = Base64StringToObject(base64)
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function Base64StringToObject(ByVal base64 As String) As Object
        Dim bytes As Byte() = Convert.FromBase64String(base64)
        Return BytesToObject(bytes)
    End Function

    Function BytesToObject(ByVal bytes As Byte()) As Object
        Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
        Using memoryStream As MemoryStream = New MemoryStream()
            memoryStream.Write(bytes, 0, bytes.Length)
            memoryStream.Seek(0L, SeekOrigin.Begin)
            Return binaryFormatter.Deserialize(memoryStream)
        End Using
    End Function

    Function StringToGuid(ByVal guid As String, ByRef value As Guid) As String
        Return ObjectToGuid(guid, value)
    End Function

    Function ObjectToGuid(ByVal sguid As Object, ByRef value As Guid) As String
        value = Guid.Empty
        Try
            value = New Guid(sguid.ToString())
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return ""
    End Function

    Function GetBytes(ByVal data As String, ByRef bytes As Byte()) As String
        Dim result As String = ""
        bytes = Nothing
        Try
            bytes = Encoding.UTF8.GetBytes(data)
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function GetString(ByVal bytes As Byte(), ByRef data As String) As String
        Dim result As String = ""
        data = Nothing
        Try
            data = Encoding.UTF8.GetString(bytes)
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Sub CopyTo(ByVal src As Stream, ByVal dest As Stream)
        Dim array As Byte() = New Byte(4095) {}
        Dim count As Integer
        While (__InlineAssignHelper(count, src.Read(array, 0, array.Length))) <> 0
            dest.Write(array, 0, count)
        End While
    End Sub

    Function Zip(ByVal str As String, ByRef zippedData As Byte()) As String
        Dim text As String = ""
        zippedData = Nothing
        Try
            If String.IsNullOrEmpty(str) Then
                Return "input string is null or empty"
            End If

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(str)
            Return Zip(bytes, zippedData)
        Catch ex As Exception
            Return ex.ToString()
        End Try
    End Function

    Function Zip(ByVal obj As Object, ByRef zippedData As Byte()) As String
        Dim text As String = ""
        zippedData = Nothing
        Try
            If obj Is Nothing Then
                Return "object is null"
            End If

            Dim data As Byte() = ObjectToBytes(obj)
            Return Zip(data, zippedData)
        Catch ex As Exception
            Return ex.ToString()
        End Try
    End Function

    Function Zip(ByVal data As Byte(), ByRef zippedData As Byte()) As String
        Dim result As String = ""
        zippedData = Nothing
        Try
            If data Is Nothing Then
                Return "data is null"
            End If

            Using src As MemoryStream = New MemoryStream(data)
                Using memoryStream As MemoryStream = New MemoryStream()
                    Using dest As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress)
                        CopyTo(src, dest)
                    End Using

                    zippedData = memoryStream.ToArray()
                End Using
            End Using
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    Function Unzip(ByVal bytes As Byte(), ByRef unzippedData As String) As String
        Dim text As String = ""
        unzippedData = Nothing
        Try
            Dim bytes2 As Byte() = Nothing
            text = Unzip(bytes, bytes2)
            If text.Length > 0 Then
                Return text
            End If

            unzippedData = Encoding.UTF8.GetString(bytes2)
        Catch ex As Exception
            text = ex.ToString()
        End Try

        Return text
    End Function

    Function Unzip(ByVal bytes As Byte(), ByRef obj As Object) As String
        Dim text As String = ""
        obj = Nothing
        Try
            Dim bytes2 As Byte() = Nothing
            text = Unzip(bytes, bytes2)
            If text.Length > 0 Then
                Return text
            End If

            obj = BytesToObject(bytes2)
        Catch ex As Exception
            text = ex.ToString()
        End Try

        Return text
    End Function

    Function Unzip(ByVal bytes As Byte(), ByRef unzippedBytes As Byte()) As String
        Dim result As String = ""
        unzippedBytes = Nothing
        Try
            Using stream As MemoryStream = New MemoryStream(bytes)
                Using memoryStream As MemoryStream = New MemoryStream()
                    Using src As GZipStream = New GZipStream(stream, CompressionMode.Decompress)
                        CopyTo(src, memoryStream)
                    End Using

                    unzippedBytes = memoryStream.ToArray()
                End Using
            End Using
        Catch ex As Exception
            result = ex.ToString()
        End Try

        Return result
    End Function

    <Obsolete("Please refactor code that uses this function, it is a simple work-around to simulate inline assignment in VB!")>
    Private Function __InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Module
<Serializable()>
Public Class Result

    Public Const Ok As Integer = 0

    Public Const [Error] As Integer = 1

    Public Property Status As Integer

    Public Property [Object] As Object

    Public ReadOnly Property ResultOk As Result
        Get
            Return GetResultOk(Nothing, False)
        End Get
    End Property

    Public ReadOnly Property isOk As Boolean
        Get
            Return Status = 0
        End Get
    End Property

    Public ReadOnly Property isError As Boolean
        Get
            Return Status = 1
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal Status As Integer, ByVal obj As Object, Optional ByVal ConvertToBase64 As Boolean = False)
        Me.Status = Status
        If ConvertToBase64 Then
            Dim hobject As String = Nothing
            Convertor.ObjectToBase64String(obj, hobject)
            [Object] = hobject
        Else
            [Object] = obj
        End If
    End Sub

    Public Shared Function GetResultOk(Optional ByVal obj As Object = Nothing, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(0, obj, ConvertToBase64)
    End Function

    Public Shared Function GetResultError(ByVal obj As Object) As Result
        Return New Result(1, obj, False)
    End Function

    Public Shared Function GetResult(ByVal Status As Integer, ByVal obj As Object, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(Status, obj, ConvertToBase64)
    End Function
End Class
Module ResultStatic
    Function ToResultOk(ByVal obj As Integer, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(0, obj, ConvertToBase64)
    End Function
    Function ToResultOk(ByVal obj As Single, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(0, obj, ConvertToBase64)
    End Function

    Function ToResultOk(ByVal obj As Double, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(0, obj, ConvertToBase64)
    End Function

    Function ToResultOk(Of T As Class)(ByVal obj As T, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(0, obj, ConvertToBase64)
    End Function

    Function ToResultError(Of T As Class)(ByVal obj As T, ByVal msgError As String) As Result
        Return New Result(1, msgError, False)
    End Function

    Function ToResultError(ByVal msgError As String) As Result
        Return New Result(1, msgError, False)
    End Function

    Function ToResult(Of T As Class)(ByVal obj As T, ByVal Status As Integer, Optional ByVal ConvertToBase64 As Boolean = False) As Result
        Return New Result(Status, obj, ConvertToBase64)
    End Function
End Module
<Serializable()>
Public Class CommandData

    Public Property CommandType As Integer

    Public Property CommandObject As Object

    Public Property CmdType As Integer

    Public Sub New()
        CommandType = 0
        CommandObject = Nothing
    End Sub

    Public Sub New(ByVal CommandType As Integer, ByVal CommandObject As Object)
        Me.CommandType = CommandType
        Me.CommandObject = CommandObject
    End Sub

    Public Shadows Function ToString() As String
        Return String.Format("CommandType: {0}; CommandObject: {1}", CommandType, If((CommandObject Is Nothing), "null", CommandObject.ToString()))
    End Function
End Class
Public Class RemoteCommand

    Public Const JSONMode As UInteger = 0UI

    Public Const XMLMode As UInteger = 1UI

    Public Const ZipMode As UInteger = 2UI

    Public Const EncryptMode As UInteger = 4UI

    Public Const EncryptModeV1 As UInteger = 8UI

    Public Const DefaultMode As UInteger = 6UI

    Public Const Mode_JSON_ZIP_ENCRYPT As UInteger = 6UI

    Public Const Mode_XML_ZIP_ENCRYPT As UInteger = 7UI

    Public Const Mode_JSON_ZIP_ENCRYPTV1 As UInteger = 10UI

    Public Const Mode_JSON As UInteger = 0UI

    Public Const Mode_XML As UInteger = 1UI

    Public ExecCommandFunc As ExecCommandFunc = Nothing

    Public BkavPartnerGUID As String = Nothing

    Public BkavPartnerToken As String = Nothing

    Public Property Mode As UInteger

    Public ReadOnly Property IsXMLMode As Boolean
        Get
            Return (Mode And 1) = 1
        End Get
    End Property

    Public ReadOnly Property IsZipMode As Boolean
        Get
            Return (Mode And 2) = 2
        End Get
    End Property

    Public ReadOnly Property IsEncryptMode As Boolean
        Get
            Return (Mode And 4) = 4
        End Get
    End Property

    Public ReadOnly Property IsEncryptModeV1 As Boolean
        Get
            Return (Mode And 8) = 8
        End Get
    End Property

    Public Sub New(ByVal ExecCommandFunc As ExecCommandFunc, ByVal BkavPartnerGUID As String, ByVal BkavPartnerToken As String, Optional ByVal Mode As UInteger = 6UI)
        Me.ExecCommandFunc = ExecCommandFunc
        Me.BkavPartnerGUID = BkavPartnerGUID
        Me.BkavPartnerToken = BkavPartnerToken
        Me.Mode = Mode
    End Sub

    Public Sub SetXMLMode(ByVal isXMLMode As Boolean)
        If isXMLMode Then
            Mode = Mode Or 1UI
        Else
            Mode = Mode And 4294967294UI
        End If
    End Sub

    Public Function TransferCommandAndProcessResult(ByVal CommandType As Integer, ByVal CommandObject As Object, ByRef result As Result) As String
        Dim commandData As CommandData = New CommandData(CommandType, CommandObject)
        Return TransferCommandAndProcessResult(commandData, result)
    End Function

    Public Function TransferCommandAndProcessResult(Of T As Class)(ByVal CommandType As Integer, ByVal CommandObject As Object, ByRef typedObject As T) As String
        Dim commandData As CommandData = New CommandData(CommandType, CommandObject)
        Return TransferCommandAndProcessResult(commandData, typedObject)
    End Function

    Public Function TransferCommandAndProcessResult(ByVal CommandData As CommandData, ByRef result As Result) As String
        Dim text As String = ""
        text = TransferCommand(CommandData, result)
        If text.Length > 0 Then
            Return text
        End If

        If result Is Nothing Then
            Return "result là null"
        End If

        If result.[Object] Is Nothing Then
            Return "result.Object là null. Status: " & result.Status
        End If

        If result.Status <> 0 Then
            text = Convert.ToString(result.[Object])
            Return text & ". Status: " & result.Status
        End If


        Return text
    End Function

    Public Function TransferCommandAndProcessResult(Of T As Class)(ByVal CommandData As CommandData, ByRef typedObject As T) As String
        Dim text As String = ""
        typedObject = Nothing
        Dim result As Result = Nothing
        text = TransferCommandAndProcessResult(CommandData, result)
        If text.Length > 0 Then
            Return text
        End If

        Return Convertor.StringToObject(IsXMLMode, result.[Object].ToString(), typedObject)
    End Function

    Public Function TransferCommand(ByVal CommandData As CommandData, ByRef result As Result) As String
        Try

            Dim text As String = ""
            result = Nothing
            If ExecCommandFunc Is Nothing Then
                Return "ExecCommandFunc is null"
            End If

            Dim text2 As String = Nothing
            text = Convertor.ObjectToString(IsXMLMode, CommandData, text2)
            If text.Length > 0 Then
                Return text
            End If

            Dim array As Byte() = Nothing
            text = (If((Not IsZipMode), Convertor.GetBytes(text2, array), Convertor.Zip(text2, array)))
            If text.Length > 0 Then
                Return text
            End If

            Dim obj As Byte() = Nothing
            Dim text3 As String = Nothing
            If Not IsEncryptMode AndAlso Not IsEncryptModeV1 Then
                obj = array
            Else
                If IsEncryptMode Then
                    text = SecurityData.Encrypt_Aes(array, BkavPartnerToken, obj)
                Else
                    SecurityData.Encrypt(array, BkavPartnerToken, True, text3)
                End If

                If text.Length > 0 Then
                    Return text
                End If
            End If

            If Not IsEncryptModeV1 Then
                text = Convertor.ObjectToBase64String(obj, text3)
                If text.Length > 0 OrElse text3 Is Nothing Then
                    Return text
                End If
            End If

            Try
                text3 = ExecCommandFunc(BkavPartnerGUID, text3)
            Catch ex As Exception
                Return ex.ToString()
            End Try

            If text3 Is Nothing Then
                Return "Dữ liệu nhận về từ Webservice là null"
            End If

            Dim array2 As Byte() = Nothing
            text = Convertor.Base64StringToObject(text3, array2)
            If text.Length > 0 Then
                Return text3
            End If

            If array2 Is Nothing Then
                Return "Dữ liệu nhận về từ Webservice là null"
            End If

            array = Nothing
            If Not IsEncryptMode AndAlso Not IsEncryptModeV1 Then
                array = array2
            Else
                text = (If((Not IsEncryptMode), SecurityData.Decrypt(text3, BkavPartnerToken, True, array), SecurityData.Decrypt_Aes(array2, BkavPartnerToken, array)))
                If text.Length > 0 Then
                    Return text
                End If

                If array Is Nothing Then
                    Return "Không giải mã (decrypt) được dữ liệu"
                End If
            End If

            text2 = Nothing
            text = (If((Not IsZipMode), Convertor.GetString(array, text2), Convertor.Unzip(array, text2)))
            If text.Length > 0 Then
                Return text
            End If

            If text2 Is Nothing Then
                Return "strCommandData sau giải mã là null"
            End If
            'MsgBox(text2)
            text = Convertor.StringToObject(IsXMLMode, text2, result)
            If text.Length > 0 Then
                Return text
            End If

            Return text

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
'==================================================================================================
Public Class Constants
    Public Const BkavPartnerGUID As String = "529210e1-8609-4bc1-9ed8-dfa2b69d2078"
    Public Const BkavPartnerToken As String = "6fkBkfI4j+Qk6cd+rTGb320UPnjFxpblnyvVClowLxc=:SYJRvK68kIsIfDnhxtDhIA=="
    Public Const Mode As UInteger = 6
End Class
Module mTaxRateID

    Public Const Khong As Integer = 1

    Public Const Nam As Integer = 2

    Public Const Muoi As Integer = 3

    Public Const KhongChiuThue As Integer = 4

    Public Const KhongKeKhaiThue As Integer = 5

    Public Const Khac As Integer = 6
End Module
Module CommandType

    Public Const Undefined As Integer = 0

    Public Const CreateInvoiceMT As Integer = 100

    Public Const CreateInvoiceTR As Integer = 101

    Public Const CreateInvoiceWithFormSerial As Integer = 110

    Public Const CreateInvoiceWithFormSerialNo As Integer = 111

    Public Const CreateInvoiceReplace As Integer = 120

    Public Const CreateInvoiceAdjust As Integer = 121

    Public Const CreateInvoiceReplaceSetInvoiceNo As Integer = 123

    Public Const CreateInvoiceAdjustSetInvoiceNo As Integer = 124

    Public Const UpdateInvoiceByPartnerInvoiceID As Integer = 200

    Public Const UpdateInvoiceByInvoiceGUID As Integer = 204

    Public Const CancelInvoiceByInvoiceGUID As Integer = 201

    Public Const CancelInvoiceByPartnerInvoiceID As Integer = 202

    Public Const DeleteInvoiceByPartnerInvoiceID As Integer = 301

    Public Const DeleteInvoiceByInvoiceGUID As Integer = 303

    Public Const UploadFile As Integer = 500

    Public Const ViewInvoice As Integer = 600

    Public Const ViewInvoiceConversion As Integer = 601

    Public Const GetInvoiceDataWS As Integer = 800

    Public Const GetInvoiceStatusID As Integer = 801

    Public Const GetInvoiceHistory As Integer = 802

    Public Const GetInvoiceLink As Integer = 804

    Public Const GetInvoicePDF As Integer = 816

    Public Const EmailInvoice As Integer = 901

    Public Const CreateAccount As Integer = 902

    Public Const UpdateAccount As Integer = 903

    Public Const GetUnitInforByTaxCode As Integer = 904

    Public Const GetRunTypeInfo As Integer = 1000

    Public Const GetDLLContent As Integer = 1001
End Module
<Serializable()>
Public Class InvoiceResult

    Public Property PartnerInvoiceID As Long

    Public Property PartnerInvoiceStringID As String

    Public Property InvoiceGUID As Guid

    Public Property InvoiceForm As String

    Public Property InvoiceSerial As String

    Public Property InvoiceNo As Integer

    Public Property Status As Integer

    Public Property MessLog As String
End Class
<Serializable()>
Public Class InvoiceDataWS

    Public Property Invoice As InvoiceWS

    Public Property ListInvoiceDetailsWS As List(Of InvoiceDetailsWS)

    Public Property ListInvoiceAttachFileWS As List(Of InvoiceAttachFileWS)

    Public Property PartnerInvoiceID As Long

    Public Property PartnerInvoiceStringID As String

    Public Sub New()

        Invoice = New InvoiceWS()
        ListInvoiceDetailsWS = New List(Of InvoiceDetailsWS)()
        ListInvoiceAttachFileWS = New List(Of InvoiceAttachFileWS)()
        PartnerInvoiceID = 0
        PartnerInvoiceStringID = Nothing
    End Sub
End Class
<Serializable()>
Public Class InvoiceWS

    Public Property InvoiceTypeID As Integer

    Public Property InvoiceDate As DateTime

    Public Property BuyerName As String

    Public Property BuyerTaxCode As String

    Public Property CCCD As String

    Public Property BuyerUnitName As String

    Public Property BuyerAddress As String

    Public Property BuyerBankAccount As String

    Public Property PayMethodID As Integer

    Public Property ReceiveTypeID As Integer

    Public Property ReceiverEmail As String

    Public Property ReceiverMobile As String

    Public Property ReceiverAddress As String

    Public Property ReceiverName As String

    Public Property Note As String

    Public Property UserDefine As String = ""

    Public Property BillCode As String

    Public Property CurrencyID As String

    Public Property ExchangeRate As Double

    Public Property InvoiceGUID As Guid

    Public Property InvoiceStatusID As Integer

    Public Property InvoiceForm As String

    Public Property InvoiceSerial As String

    Public Property InvoiceNo As Integer

    Public Property InvoiceCode As String

    Public Property SignedDate As DateTime

    Public Property TypeCreateInvoice As Integer

    Public Property OriginalInvoiceIdentify As String
    Public Property MTC As String
End Class
<Serializable()>
Public Class InvoiceDetailsWS

    Public Sub New()
        Itemcode = ""
        UnitName = ""
        Qty = 0
        Price = 0
        Amount = 0
        TaxRateID = mTaxRateID.Muoi
        TaxAmount = 0
        IsDiscount = False
    End Sub
    Public Property Itemcode As String
    Public Property ItemName As String

    Public Property UnitName As String

    Public Property Qty As Double

    Public Property Price As Double

    Public Property Amount As Double

    Public Property TaxRateID As Integer

    Public Property TaxAmount As Double

    Public Property IsDiscount As Boolean
    Public Property ItemTypeID As String

    Public Property UserDefineDetails As String

    Public Property IsIncrease As Object
End Class
<Serializable()>
Public Class InvoiceAttachFileWS

    Public Property FileName As String

    Public Property FileExtension As String

    Public Property FileContent As String

    Public Sub New()
        FileName = ""
        FileExtension = ""
        FileContent = ""
    End Sub
End Class
<Serializable()>
Public Class HistoryLog

    Public Property CreateDate As DateTime

    Public Property ID As Long

    Public Property IP As String

    Public Property LogContent As String

    Public Property ObjectGUID As Guid

    Public Property UserID As Integer
End Class
<Serializable()>
Public Class BusinessInfo

    Public Property MaSoThue As String

    Public Property TenChinhThuc As String

    Public Property DiaChiGiaoDichChinh As String

    Public Property DiaChiGiaoDichPhu As String

    Public Property TrangThaiHoatDong As String
End Class
<Serializable()>
Public Class DllInfo

    Public Property RunType As Integer

    Public Property ClassName As String

    Public Property DLLName As String

    Public Property Code As String

    Public Property DLLContent As Byte()
End Class
<Serializable()>
Public Class CreateAccountInfoFromPartner

    Public Sub New()
        UnitName = ""
        UnitAddress = ""
        UnitPersonRepresent = ""
        UnitPersonRepresentPosition = ""
        UnitEmail = ""
        UnitPhone = ""
        TaxCode = ""
        BankAccount = ""
        BankName = ""
        TaxDepartmentID = 0
        BrandName = ""
        DomainCheckInvoice = ""
    End Sub

    Public Property TaxCode As String

    Public Property UnitName As String

    Public Property UnitAddress As String

    Public Property TaxDepartmentID As Integer

    Public Property UnitPersonRepresent As String

    Public Property UnitPersonRepresentPosition As String

    Public Property UnitEmail As String

    Public Property UnitPhone As String

    Public Property BankAccount As String

    Public Property BankName As String

    Public Property BrandName As String

    Public Property DomainCheckInvoice As String
End Class
<Serializable()>
Public Class AccountResult

    Public Property AccountGUID As Guid

    Public Property Account As String

    Public Property Password As String

    Public Property NumberInvoice As Integer

    Public Property NumberMSG As Integer
End Class


<Serializable()>
Public Class CommandObject

    Public Property PartnerInvoiceStringID As String

End Class
