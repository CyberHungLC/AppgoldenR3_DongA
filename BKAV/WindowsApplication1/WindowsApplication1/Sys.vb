Imports HDBAKVV01.vn.ehoadon.wsdemo
Imports System.IO
Imports System.Text

Public Class Sys
    Dim webservice As vn.ehoadon.wsdemo.WSPublicEHoaDon
    'Dim webservice As vn.ehoadon.ws.WSPublicEHoaDon
    Dim remoteCommand As RemoteCommand
    Dim wsExecCommand As ExecCommandFunc
    Dim BkavPartnerGUID As String '= "fbace829-1378-451c-bc5c-2a439413b549"
    Dim BkavPartnerToken As String '= "a6RGaliPCBfHun2hxOVreVveD2peDUzk9P7MWc3kDwE=:LgOtI1ylbn5KutL93eiFjA=="
    Dim Mode As UInteger '= 6
    Public Sub New(ByVal _BkavPartnerGUID As String, ByVal _BkavPartnerToken As String, Optional ByVal _Mode As String = "6")
        BkavPartnerGUID = _BkavPartnerGUID
        BkavPartnerToken = _BkavPartnerToken
        Dim valueMode As Integer = Convert.ToInt32(_Mode)
        Mode = valueMode

        webservice = New WSPublicEHoaDon
        wsExecCommand = AddressOf webservice.ExecCommand
        remoteCommand = New RemoteCommand(wsExecCommand, BkavPartnerGUID, BkavPartnerToken, Mode)
    End Sub
    Public Function Tao_Hoa_Don100(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable
        msg = DoCreateInvoice(_DsData, sGUID, InvoiceNo, Datareturn, 100)
        If msg.Length > 0 Then
            Return Nothing
        Else
            Return Datareturn
        End If
    End Function
    Public Function Tao_Hoa_Don101(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable

        msg = DoCreateInvoice(_DsData, sGUID, InvoiceNo, Datareturn, 101)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Ky_Hoa_Don(ByVal strGuid As String) As String
        Dim msg As String = ""
        Dim result As Result = Nothing
        Return remoteCommand.TransferCommandAndProcessResult(205, strGuid, result)
    End Function
    Public Function Tao_Hoa_Don110(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable
        msg = DoCreateInvoice(_DsData, sGUID, InvoiceNo, Datareturn, 110)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Tao_Hoa_Don111(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable
        msg = DoCreateInvoice(_DsData, sGUID, InvoiceNo, Datareturn, 111)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Tao_Hoa_Don200(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable
        msg = DoCreateInvoice(_DsData, sGUID, InvoiceNo, Datareturn, 100)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Lay_Thong_Tin_HD800(ByVal sGUID As String, ByRef InvoiceNo As String, ByRef InvoiceSeri As String, ByRef msg As String) As String
        Dim objInvoice As InvoiceDataWS = Nothing
        msg = DoGetInfo(sGUID, objInvoice)
        If msg.Length > 0 Then Return msg
        InvoiceNo = objInvoice.Invoice.InvoiceNo
        InvoiceSeri = objInvoice.Invoice.InvoiceSerial
        Return ""
    End Function
    Public Function Thay_The_Hoa_don(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable = Nothing
        msg = DoReplaceInvoice(_DsData, Datareturn)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Dieu_chinh_Hoa_don(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable = Nothing
        msg = DoAdjustInvoice(_DsData, Datareturn)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Thay_The_Hoa_donInvoice(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable = Nothing
        msg = DoCreateInvoiceReplaceSetInvoiceNo(_DsData, Datareturn)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Dieu_chinh_Hoa_donInvoice(ByVal _DsData As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable = Nothing
        msg = DoCreateInvoiceAdjustSetInvoiceNo(_DsData, Datareturn)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Public Function Huy_Hoa_Don(ByVal strGuid As String) As String
        Dim msg As String = ""
        Dim listInvoiceDataWS As List(Of InvoiceDataWS) = New List(Of InvoiceDataWS)()
        Dim cinvoiceDataWS As InvoiceDataWS = New InvoiceDataWS()

        cinvoiceDataWS.Invoice = New InvoiceWS()
        Dim cguid As Guid = Guid.Empty
        msg = Convertor.StringToGuid(strGuid, cguid)
        If msg.Length > 0 Then Return "Giá trị không thể convert sang GUID"
        cinvoiceDataWS.Invoice.InvoiceGUID = cguid

        listInvoiceDataWS.Add(cinvoiceDataWS)
        Dim list As String = Nothing
        msg = Convertor.ObjectToString(Of List(Of InvoiceDataWS))(False, listInvoiceDataWS, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CancelInvoiceByInvoiceGUID, list, result)

        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status <> 0 Then Return invoiceResult.MessLog
        Next

        Return msg
    End Function
    Public Function Xoa_Hoa_Don(ByVal strGuid As String) As String

        Dim msg As String = ""
        Dim listInvoiceDataWS As List(Of InvoiceDataWS) = New List(Of InvoiceDataWS)()
        Dim invoiceDataWS As InvoiceDataWS = New InvoiceDataWS()

        invoiceDataWS.Invoice = New InvoiceWS()
        Dim guid As Guid = guid.Empty

        msg = Convertor.StringToGuid(strGuid, guid)

        If msg.Length > 0 Then Return "Giá trị không thể convert sang GUID"
        invoiceDataWS.Invoice.InvoiceGUID = guid

        listInvoiceDataWS.Add(invoiceDataWS)
        Dim list As String = Nothing
        msg = Convertor.ObjectToString(Of List(Of InvoiceDataWS))(False, listInvoiceDataWS, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.DeleteInvoiceByInvoiceGUID, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status <> 0 Then Return invoiceResult.MessLog
        Next
        Return msg
    End Function
    Private Function CancelInvoice(ByVal strGuid As String) As String
        Dim msg As String = ""
        Dim listInvoiceDataWS As List(Of InvoiceDataWS) = New List(Of InvoiceDataWS)()
        Dim invoiceDataWS As InvoiceDataWS = New InvoiceDataWS()

        invoiceDataWS.Invoice = New InvoiceWS()
        Dim guid As Guid = guid.Empty
        msg = Convertor.StringToGuid(strGuid, guid)
        If msg.Length > 0 Then Return "Giá trị không thể convert sang GUID"
        invoiceDataWS.Invoice.InvoiceGUID = guid

        listInvoiceDataWS.Add(invoiceDataWS)
        Dim list As String = Nothing
        msg = Convertor.ObjectToString(Of List(Of InvoiceDataWS))(False, listInvoiceDataWS, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CancelInvoiceByInvoiceGUID, list, result)

        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status <> 0 Then Return invoiceResult.MessLog
        Next
        Return msg
    End Function

 


    Private Function DoReplaceInvoice(ByRef DsSource As DataSet, ByRef Datareturn As DataTable) As String
        Datareturn = Nothing
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsSource, CommandType.CreateInvoiceReplace, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceReplace, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg

        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)
            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        Return msg
    End Function
    Private Function DoAdjustInvoice(ByRef DsSource As DataSet, ByRef Datareturn As DataTable) As String
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsSource, CommandType.CreateInvoiceAdjust, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceAdjust, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)

            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        Return msg
    End Function
    Private Function DoCreateInvoiceReplaceSetInvoiceNo(ByRef DsSource As DataSet, ByRef Datareturn As DataTable) As String
        Datareturn = Nothing
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsSource, CommandType.CreateInvoiceReplaceSetInvoiceNo, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceReplaceSetInvoiceNo, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg

        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)

            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        MsgBox(msg)
        Return msg
    End Function
    Private Function DoCreateInvoiceAdjustSetInvoiceNo(ByRef DsSource As DataSet, ByRef Datareturn As DataTable) As String
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsSource, CommandType.CreateInvoiceAdjustSetInvoiceNo, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.CreateInvoiceAdjustSetInvoiceNo, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)

            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        'MsgBox(list)
        Return msg
    End Function
    Private Function DoGetInfo(ByVal InvoiceGUID As String, ByRef invoiceDataWS As InvoiceDataWS) As String
        Dim msg As String = ""
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.GetInvoiceDataWS, InvoiceGUID, result)
        'MsgBox(result.Object.ToString)
        If msg.Length > 0 Then Return msg
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), invoiceDataWS)
        If msg.Length > 0 Then Return msg
        Return msg
    End Function
    Private Function DoCreateInvoice(ByRef DsSource As DataSet, ByRef sGUID As String, ByRef InvoiceNo As String, ByRef Datareturn As DataTable, ByVal iCommandType As Integer) As String
        Datareturn = Nothing
        Dim msg As String = ""
        sGUID = Nothing
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsSource, iCommandType, list)
        'Lấy log
        MsgBox(list)
        ' Test: Chạy chính thức thì khóa đoạn này
        'Return ""
        '---------------------------
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(iCommandType, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.[Object]), listInvoiceResult)
        If msg.Length > 0 Then Return msg

        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                sGUID = invoiceResult.InvoiceGUID.ToString()
                InvoiceNo = invoiceResult.InvoiceNo
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)
            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        Return msg
    End Function
    Private Function GetListInvoiceDataWS(ByRef DsSource As DataSet, ByVal commandType As Integer, ByRef list As String) As String
        list = Nothing
        Dim listInvoiceDataWS As List(Of InvoiceDataWS) = Nothing
        PrepareInvoiceData(DsSource, commandType, listInvoiceDataWS)
        Return Convertor.ObjectToString(Of List(Of InvoiceDataWS))(False, listInvoiceDataWS, list)
    End Function
    Private Sub PrepareInvoiceData(ByRef DsSource As DataSet, ByVal icommandType As Integer, ByRef listInvoiceDataWS As List(Of InvoiceDataWS))
        listInvoiceDataWS = New List(Of InvoiceDataWS)()
        ' Get PH
        Dim invoice As InvoiceWS = GetOneInvoiceWS(DsSource, icommandType)
        ' Get Ct
        Dim invoiceDetails As List(Of InvoiceDetailsWS) = New List(Of InvoiceDetailsWS)()
        Dim invoiceDetail As InvoiceDetailsWS = Nothing
        'If icommandType = CommandType.CreateInvoiceAdjust Then ' dieu chinh hoa don
        If icommandType = CommandType.CreateInvoiceAdjust Or icommandType = CommandType.CreateInvoiceAdjustSetInvoiceNo Then ' dieu chinh hoa don
            invoiceDetails = GetOneInvoiceDetailsWS(DsSource, True)
        Else
            invoiceDetails = GetOneInvoiceDetailsWS(DsSource)
            'invoiceDetails.Add(invoiceDetail)
        End If
        '==================================================================================
        Dim invoiceDataWS As InvoiceDataWS = New InvoiceDataWS()
        invoiceDataWS.Invoice = invoice
        invoiceDataWS.ListInvoiceDetailsWS = invoiceDetails
        invoiceDataWS.PartnerInvoiceID = 0 'Long.Parse(DateTime.Now.ToString("ddMMyyyy HH:mm:ss").Replace(" ", "").Replace(":", ""))
        invoiceDataWS.PartnerInvoiceStringID = DsSource.Tables(1).Rows(0)("stt_rec")
        listInvoiceDataWS.Add(invoiceDataWS)
    End Sub
    Private Function GetOneInvoiceWS(ByRef DsSource As DataSet, ByVal icommandType As Integer) As InvoiceWS
        Dim dtPh As DataTable = DsSource.Tables(1)
        Dim invoiceWS As InvoiceWS = New InvoiceWS()
        invoiceWS.InvoiceTypeID = 1
        invoiceWS.InvoiceDate = dtPh.Rows(0)("Ngay_Ct") 'DateTime.Now
        invoiceWS.BuyerName = dtPh.Rows(0)("Ten_Kh")
        invoiceWS.BuyerTaxCode = dtPh.Rows(0)("Ma_So_Thue")
        invoiceWS.CCCD = dtPh.Rows(0)("CCCD")
        invoiceWS.BuyerUnitName = dtPh.Rows(0)("Ten_KhVat")
        invoiceWS.BuyerAddress = dtPh.Rows(0)("Dia_ChiVat")
        invoiceWS.BuyerBankAccount = dtPh.Rows(0)("TK_NH")
        invoiceWS.PayMethodID = dtPh.Rows(0)("Ht_TT")
        invoiceWS.ReceiveTypeID = 3
        invoiceWS.ReceiverEmail = dtPh.Rows(0)("Email")
        invoiceWS.ReceiverMobile = dtPh.Rows(0)("Dien_Thoai")
        invoiceWS.ReceiverAddress = dtPh.Rows(0)("Dia_ChiVat")
        invoiceWS.ReceiverName = dtPh.Rows(0)("Ten_KhVat")
        invoiceWS.Note = dtPh.Rows(0)("Dien_Giai")
        invoiceWS.BillCode = ""
        invoiceWS.CurrencyID = dtPh.Rows(0)("Ma_Nt")
        invoiceWS.ExchangeRate = dtPh.Rows(0)("Ty_Gia")
        invoiceWS.InvoiceForm = dtPh.Rows(0)("InvoiceForm")
        invoiceWS.InvoiceSerial = dtPh.Rows(0)("InvoiceSerial")
        invoiceWS.InvoiceStatusID = 1
        invoiceWS.SignedDate = DateTime.Now

        Select Case icommandType
            Case CommandType.CreateInvoiceMT
                invoiceWS.InvoiceNo = 0
                'invoiceWS.InvoiceForm = ""
                'invoiceWS.InvoiceSerial = ""
                invoiceWS.InvoiceForm = dtPh.Rows(0)("InvoiceForm")
                invoiceWS.InvoiceSerial = dtPh.Rows(0)("InvoiceSerial")
            Case CommandType.CreateInvoiceTR
                invoiceWS.InvoiceNo = 0
                invoiceWS.InvoiceForm = dtPh.Rows(0)("InvoiceForm")
                invoiceWS.InvoiceSerial = dtPh.Rows(0)("InvoiceSerial")
            Case CommandType.CreateInvoiceWithFormSerial
                invoiceWS.InvoiceNo = 0
                invoiceWS.InvoiceForm = dtPh.Rows(0)("Mau_So")
                invoiceWS.InvoiceSerial = dtPh.Rows(0)("So_SeriHD")
            Case CommandType.CreateInvoiceWithFormSerialNo
                invoiceWS.InvoiceNo = 0 'dtPh.Rows(0)("So_Hd")
                invoiceWS.InvoiceForm = dtPh.Rows(0)("InvoiceForm")
                invoiceWS.InvoiceSerial = dtPh.Rows(0)("InvoiceSerial")

                'Case CommandType.CreateInvoiceReplace
                '    invoiceWS.InvoiceNo = 0
                '    invoiceWS.InvoiceForm = dtPh.Rows(0)("mau_so")
                '    invoiceWS.InvoiceSerial = dtPh.Rows(0)("so_seri")
                '    invoiceWS.OriginalInvoiceIdentify = "[" & dtPh.Rows(0)("mau_so_goc") & "]_[" & dtPh.Rows(0)("so_seri_goc") & "]_[" & dtPh.Rows(0)("So_ct_goc") & "]"
                'Case CommandType.CreateInvoiceAdjust
                '    invoiceWS.InvoiceNo = 0
                '    invoiceWS.InvoiceForm = dtPh.Rows(0)("mau_so")
                '    invoiceWS.InvoiceSerial = dtPh.Rows(0)("so_seri")
                '    invoiceWS.OriginalInvoiceIdentify = "[" & dtPh.Rows(0)("mau_so_goc") & "]_[" & dtPh.Rows(0)("so_seri_goc") & "]_[" & dtPh.Rows(0)("So_ct_goc") & "]"
            Case CommandType.UpdateInvoiceByInvoiceGUID

                Dim guid As Guid = guid.Empty
                Convertor.StringToGuid(dtPh.Rows(0)("InvoiceGUID"), guid)
                invoiceWS.InvoiceGUID = guid
                'Case CommandType.CreateInvoiceReplaceSetInvoiceNo
                '    invoiceWS.InvoiceNo = 0
                '    invoiceWS.InvoiceForm = dtPh.Rows(0)("mau_so")
                '    invoiceWS.InvoiceSerial = dtPh.Rows(0)("So_SeriHD")
                '    invoiceWS.OriginalInvoiceIdentify = "[" & dtPh.Rows(0)("mau_so_goc") & "]_[" & dtPh.Rows(0)("so_seri_goc") & "]_[" & dtPh.Rows(0)("So_ct_goc") & "]"
                'Case CommandType.CreateInvoiceAdjustSetInvoiceNo
                '    invoiceWS.InvoiceNo = 0
                '    invoiceWS.InvoiceForm = dtPh.Rows(0)("mau_so")
                '    invoiceWS.InvoiceSerial = dtPh.Rows(0)("so_seri")
                '    invoiceWS.OriginalInvoiceIdentify = "[" & dtPh.Rows(0)("mau_so_goc") & "]_[" & dtPh.Rows(0)("so_seri_goc") & "]_[" & dtPh.Rows(0)("So_ct_goc") & "]"

            Case Else
                invoiceWS.InvoiceNo = 0
                invoiceWS.InvoiceForm = dtPh.Rows(0)("Mau_So")
                invoiceWS.InvoiceSerial = dtPh.Rows(0)("So_SeriHD")
        End Select
        Return invoiceWS
    End Function
    Private Function GetOneInvoiceDetailsWS(ByRef DsSource As DataSet, ByVal isIncrease As Boolean) As List(Of InvoiceDetailsWS)
        Dim dtCt As DataTable = DsSource.Tables(2)
        Dim listinvoiceDetailsWS As New List(Of InvoiceDetailsWS)
        For Each dr As DataRow In dtCt.Rows
            Dim invoiceDetailsWS As InvoiceDetailsWS = New InvoiceDetailsWS()
            invoiceDetailsWS.Itemcode = dr("Ma_VT")
            invoiceDetailsWS.ItemName = dr("Ten_Vt")
            invoiceDetailsWS.UnitName = dr("Dvt")
            invoiceDetailsWS.Qty = dr("So_luong")
            invoiceDetailsWS.Price = dr("Gia_Nt2")
            invoiceDetailsWS.Amount = dr("Tien_Nt2")
            invoiceDetailsWS.TaxRateID = dr("TaxRateID")
            invoiceDetailsWS.TaxAmount = dr("Thue_Nt")
            invoiceDetailsWS.IsDiscount = IIf(dr("Is_CKTM") = "1", True, False)
            invoiceDetailsWS.UserDefineDetails = ""
            invoiceDetailsWS.IsIncrease = IIf(dr("DC_Giam") = "1", True, False)
            listinvoiceDetailsWS.Add(invoiceDetailsWS)
        Next
        Return listinvoiceDetailsWS
    End Function
    Private Function GetOneInvoiceDetailsWS(ByRef DsSource As DataSet) As List(Of InvoiceDetailsWS)
        Dim dtCt As DataTable = DsSource.Tables(2)
        Dim listinvoiceDetailsWS As New List(Of InvoiceDetailsWS)
        For Each dr As DataRow In dtCt.Rows
            Dim invoiceDetailsWS As New InvoiceDetailsWS()
            invoiceDetailsWS.Itemcode = dr("Ma_VT")
            invoiceDetailsWS.ItemName = dr("Ten_Vt")
            invoiceDetailsWS.UnitName = dr("Dvt")
            invoiceDetailsWS.Qty = dr("So_luong")
            invoiceDetailsWS.Price = dr("Gia_Nt2")
            invoiceDetailsWS.Amount = dr("Tien_Nt2")
            invoiceDetailsWS.TaxRateID = dr("TaxRateID")
            invoiceDetailsWS.TaxAmount = dr("Thue_Nt")
            invoiceDetailsWS.ItemTypeID = dr("ItemTypeID")
            invoiceDetailsWS.IsDiscount = IIf(dr("Is_CKTM") = "1", True, False)
            invoiceDetailsWS.UserDefineDetails = ""
            listinvoiceDetailsWS.Add(invoiceDetailsWS)
        Next

        Return listinvoiceDetailsWS
    End Function
    Public Function Cap_Nhap_thong_Tin_Hoa_Don(ByVal DsData As DataSet, ByRef msg As String) As DataTable
        Dim Datareturn As DataTable = Nothing
        msg = DoUpdateInvoice(DsData, Datareturn)
        If msg.Length > 0 Then
            Return Datareturn
        Else
            Return Datareturn
        End If
    End Function
    Private Function DoUpdateInvoice(ByVal DsData As DataSet, ByRef Datareturn As DataTable) As String
        Datareturn = Nothing
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetListInvoiceDataWS(DsData, CommandType.UpdateInvoiceByInvoiceGUID, list)
        'Lấy log
        'MsgBox(list)
        'Exit Function
        '-------------------

        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.UpdateInvoiceByInvoiceGUID, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        If msg.Length > 0 Then Return msg
        For Each invoiceResult As InvoiceResult In listInvoiceResult
            If invoiceResult.Status = 0 Then
                Datareturn = New DataTable
                Datareturn.Columns.Add("InvoiceForm")
                Datareturn.Columns.Add("InvoiceGUID")
                Datareturn.Columns.Add("InvoiceNo")
                Datareturn.Columns.Add("InvoiceSerial")
                Datareturn.Columns.Add("MessLog")
                Datareturn.Columns.Add("PartnerInvoiceID")
                Datareturn.Columns.Add("PartnerInvoiceStringID")
                Datareturn.Columns.Add("Status")
                Datareturn.Rows.Add(invoiceResult.InvoiceForm, invoiceResult.InvoiceGUID, invoiceResult.InvoiceNo, invoiceResult.InvoiceSerial, invoiceResult.MessLog, invoiceResult.PartnerInvoiceID, invoiceResult.PartnerInvoiceStringID, invoiceResult.Status)
            Else
                msg = msg & "; " & invoiceResult.MessLog
            End If
        Next
        Return msg
    End Function

    'Public Function Lay_LinkPDF(ByVal sGUID As String, ByRef InvoiceNo As String, ByRef InvoiceSeri As String, ByRef msg As String) As String
    '    Dim result As Result = Nothing
    '    Dim objInvoice As InvoiceDataWS = Nothing
    '    msg = DoGetInfo(sGUID, objInvoice)
    '    If msg.Length > 0 Then Return msg
    '    InvoiceNo = objInvoice.Invoice.InvoiceNo
    '    InvoiceSeri = objInvoice.Invoice.InvoiceSerial

    '    Dim commandObj As New Dictionary(Of String, Object)
    '    commandObj("PartnerInvoiceID") = objInvoice.PartnerInvoiceID
    '    commandObj("PartnerInvoiceStringID") = objInvoice.PartnerInvoiceStringID
    '    Dim lstCommand As New List(Of Object)
    '    lstCommand.Add(commandObj)
    '    MsgBox(objInvoice.PartnerInvoiceID)

    '    msg = remoteCommand.TransferCommandAndProcessResult(804, lstCommand, result)
    '    If msg.Length > 0 Then Return msg
    '    msg = result.MessLog
    '    Return msg
    'End Function
    Public Function Lay_LinkPDF(ByVal sGUID As String,
                              ByRef InvoiceNo As String,
                              ByRef InvoiceSeri As String,
                              ByRef msg As String) As String

        Dim result As Result = Nothing
        Dim objInvoice As InvoiceDataWS = Nothing

        ' 1. Lấy info hóa đơn
        msg = DoGetInfo(sGUID, objInvoice)
        If msg.Length > 0 Then Return ""

        InvoiceNo = objInvoice.Invoice.InvoiceNo
        InvoiceSeri = objInvoice.Invoice.InvoiceSerial

        ' 2. Tạo command
        Dim commandObj As New Dictionary(Of String, Object)
        commandObj("PartnerInvoiceID") = objInvoice.PartnerInvoiceID
        commandObj("PartnerInvoiceStringID") = objInvoice.PartnerInvoiceStringID

        Dim lstCommand As New List(Of Object)
        lstCommand.Add(commandObj)

        ' 3. Gọi API
        msg = remoteCommand.TransferCommandAndProcessResult(816, lstCommand, result)
        If msg.Length > 0 Then Return ""

        ' 4. Parse Object (QUAN TRỌNG NHẤT)
        If result Is Nothing OrElse result.Object Is Nothing Then
            Return ""
        End If

        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)

        If msg.Length > 0 OrElse listInvoiceResult Is Nothing OrElse listInvoiceResult.Count = 0 Then
            Return ""
        End If

        ' 5. Lấy link PDF
        Return listInvoiceResult(0).MessLog

    End Function
    Public Function ViewHoaDonPDF(ByVal domain As String, ByVal stt_rec As String)
        'Datareturn = Nothing
        Dim msg As String = ""
        Dim list As String = Nothing
        msg = GetViewInvoice(stt_rec, list)
        If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.GetInvoicePDF, list, result)
        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        'Dim link As String = domain + "/" + Uri.UnescapeDataString(listInvoiceResult(0).MessLog)
        Dim link As String = domain + "/" + stt_rec
        ViewPDfUrl(link)
        If msg.Length > 0 Then Return msg Else Return ""
    End Function
    Public Function GuiHoaDonEmail(ByVal domain As String, ByVal matracuu As String)
        'Datareturn = Nothing
        Dim msg As String = ""
        Dim list As String = Nothing
        'msg = EmailInvoice(matracuu, list)
        'If msg.Length > 0 Then Return msg
        Dim result As Result = Nothing
        msg = remoteCommand.TransferCommandAndProcessResult(CommandType.EmailInvoice, matracuu, result)

        If msg.Length > 0 Then Return msg
        Dim listInvoiceResult As List(Of InvoiceResult) = Nothing
        Dim logFolder As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs")
        If Not Directory.Exists(logFolder) Then
            Directory.CreateDirectory(logFolder)
        End If

        Dim fileName As String = DateTime.Now.ToString("yyyyMMdd") & ".txt"
        Dim filePath As String = Path.Combine(logFolder, fileName)

        msg = Convertor.StringToObject(False, Convert.ToString(result.Object), listInvoiceResult)
        File.AppendAllText(filePath, Convert.ToString(result.Object) & Environment.NewLine, Encoding.UTF8)
        'Dim link As String = domain + "\" + listInvoiceResult(0).MessLog
        'ViewPDfUrl(link)

        If msg.Length > 0 Then Return msg Else Return ""
    End Function
    Private Function GetViewInvoice(ByVal stt_rec As String, ByRef list As String)
        list = Nothing
        Dim listInvoice As New List(Of CommandObject)
        Dim obj As New CommandObject
        obj.PartnerInvoiceStringID = stt_rec
        listInvoice.Add(obj)
        Return Convertor.ObjectToString(Of List(Of CommandObject))(False, listInvoice, list)
    End Function
    Private Sub ViewPDfUrl(ByVal data As String)
        Dim frmView As New ViewPDF
        frmView.urlPDF = data
        frmView.ShowDialog()
    End Sub
    Private Sub ViewPDf(ByVal data As Byte())
        Dim frmView As New ViewPDF
        frmView.byteArr = data
        frmView.ShowDialog()
    End Sub
End Class