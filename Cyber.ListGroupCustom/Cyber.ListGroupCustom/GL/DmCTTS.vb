Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class DmCTTS
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim fileData As Byte() = Nothing
    Private Sub DmCTTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_CTTS, TxtNh_CTTS1, TxtNh_CTTS2, TxtNh_CTTS3, TxtNh_CTTS4, TxtNh_CTTS5)
        V_DownLoadImage()
        TxtMa_CTTS.Focus()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_CTTS1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCTTS", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_CTTS1.Text.Trim + "')", CyberSmlib)
        If TxtNh_CTTS2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCTTS", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_CTTS2.Text.Trim + "')", CyberSmlib)
        If TxtNh_CTTS3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCTTS", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_CTTS3.Text.Trim + "')", CyberSmlib)
        If TxtNh_CTTS4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCTTS", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_CTTS4.Text.Trim + "')", CyberSmlib)
        If TxtNh_CTTS5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCTTS", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_CTTS5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Sub V_AddhanderMaster()
        'MyBase.V_Addhander()
        ''Image
        RemoveHandler CbbSelectImage.Click, AddressOf V_SelectImage
        AddHandler CbbSelectImage.Click, AddressOf V_SelectImage
        'Nh_CTTS1
        RemoveHandler TxtNh_CTTS1.CyberValiting, AddressOf V_Nh_CTTS1
        RemoveHandler TxtNh_CTTS1.CyberLeave, AddressOf L_Nh_CTTS1
        AddHandler TxtNh_CTTS1.CyberValiting, AddressOf V_Nh_CTTS1
        AddHandler TxtNh_CTTS1.CyberLeave, AddressOf L_Nh_CTTS1
        'Nh_CTTS2
        RemoveHandler TxtNh_CTTS2.CyberValiting, AddressOf V_Nh_CTTS2
        RemoveHandler TxtNh_CTTS2.CyberLeave, AddressOf L_Nh_CTTS2
        AddHandler TxtNh_CTTS2.CyberValiting, AddressOf V_Nh_CTTS2
        AddHandler TxtNh_CTTS2.CyberLeave, AddressOf L_Nh_CTTS2
        'Nh_CTTS3
        RemoveHandler TxtNh_CTTS3.CyberValiting, AddressOf V_Nh_CTTS3
        RemoveHandler TxtNh_CTTS3.CyberLeave, AddressOf L_Nh_CTTS3
        AddHandler TxtNh_CTTS3.CyberValiting, AddressOf V_Nh_CTTS3
        AddHandler TxtNh_CTTS3.CyberLeave, AddressOf L_Nh_CTTS3
        'Nh_CTTS4
        RemoveHandler TxtNh_CTTS4.CyberValiting, AddressOf V_Nh_CTTS4
        RemoveHandler TxtNh_CTTS4.CyberLeave, AddressOf L_Nh_CTTS4
        AddHandler TxtNh_CTTS4.CyberValiting, AddressOf V_Nh_CTTS4
        AddHandler TxtNh_CTTS4.CyberLeave, AddressOf L_Nh_CTTS4
        'Nh_CTTS5
        RemoveHandler TxtNh_CTTS5.CyberValiting, AddressOf V_Nh_CTTS5
        RemoveHandler TxtNh_CTTS5.CyberLeave, AddressOf L_Nh_CTTS5
        AddHandler TxtNh_CTTS5.CyberValiting, AddressOf V_Nh_CTTS5
        AddHandler TxtNh_CTTS5.CyberLeave, AddressOf L_Nh_CTTS5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Image"
    Private Sub V_SelectImage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenStatus As OpenFileDialog = CyberSupport.GetOpenFileDialog(False, "Image Files |(*.bmp;*.jpg;*.jpeg;*.GIF;*.png)")
        If (OpenStatus.ShowDialog = DialogResult.OK) Then
            Dim file As String
            For Each file In OpenStatus.FileNames
                'lay ra duoi mo rong vd: .doc or .pdf
                Dim file_Type As String = System.IO.Path.GetExtension(file)
                Dim file_Name As String = System.IO.Path.GetFileNameWithoutExtension(file)
                Dim Fullfile_Name As String = file
                Dim info As New FileInfo(file)
                Dim file_Size As Long = info.Length
                fileData = CyberSupport.ReadFileToBytes(Fullfile_Name)
                Try
                    'PictureImage.BackgroundImage = CyberSupport.ReadByteToImage(fileData)
                    PictureImage.Image = CyberSupport.ReadByteToImage(fileData)
                Catch ex As Exception
                End Try
            Next
        End If
    End Sub
    Public Function ReadFileDatabaseToFile(ByVal Appconn As SqlConnection, ByVal _Tb_Name As String, ByVal _Key As String, ByVal _Ma_Dvcs As String, ByVal _User_name As String,
                                            Optional ByVal _Field As String = "File_Bit", Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing) As Byte()
        Dim _Return As Byte() = Nothing
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "SELECT TOP 1 [" & _Field.Trim & "] FROM dbo.[" & _Tb_Name.Trim & "] WHERE " & _Key.Trim & "#" & _Ma_Dvcs & "#" & _User_name)
        If _DsTmp.Tables.Count < 0 Then Return Nothing
        If _DsTmp.Tables(0).Rows.Count < 1 Then Return Nothing
        If Not _DsTmp.Tables(0).Columns.Contains(_Field.Trim) Then Return Nothing Else _Field = _DsTmp.Tables(0).Columns(_Field.Trim).ColumnName

        Dim File_bit As Object
        Try
            File_bit = _DsTmp.Tables(0).Rows(0).Item(_Field)
            _Return = DirectCast(File_bit, Byte())
        Catch ex As Exception
        End Try
        ReadFileDatabaseToFile = _Return
    End Function
    Private Sub V_LoadImage()
        Dim DsImage As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRGetImageCTTS", TxtMa_CTTS.Text & "#" & M_Ma_Dvcs & M_User_Name)
    End Sub
#End Region
#Region "DownLoad And Attach Image"
    Private Sub V_DownLoadImage()
        PictureImage.Image = Nothing
        If Me.Mode = "S" Then
            Try
                'PictureImage.BackgroundImage = CyberSupport.ReadByteToImage(ReadFileDatabaseToFile(Appconn, "DmHsImage", "Ma_Hs =N'" + TxtMa_HS.Text.Trim + "'", M_Ma_Dvcs, M_User_Name, "File_Bit", CyberSmlib))
                PictureImage.Image = CyberSupport.ReadByteToImage(ReadFileDatabaseToFile(Appconn, "DmCTTSImage", "Ma_CTTS =N'" + TxtMa_CTTS.Text.Trim + "'", M_Ma_Dvcs, M_User_Name, "File_Bit", CyberSmlib))
            Catch ex As Exception
            End Try
        Else
            'PictureImage.BackgroundImage = Nothing
            PictureImage.Image = Nothing
        End If
    End Sub
    Private Sub V_SaveImage()
        Dim _ma_HsOld As String = ""
        If Me.Mode = "S" Then
            _ma_HsOld = Me.DrOld.Item("Ma_CTTS").ToString.Trim
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "DELETE FROM dbo.DmCTTSImage WHERE ma_Ctts =N'" + _ma_HsOld + "'#" & M_Ma_Dvcs & "#" & M_User_Name)
        End If
        CyberSupport.V_ImageToDataBase(Me, "CP_CRSaveImage", Me.PictureImage, M_Ma_Dvcs, M_User_Name, "DmCTTSImage", Me.Appconn, CyberSmodb, CyberSmlib)
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_CTTS1"
    Private Sub V_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CTTS1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CTTS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CTTS1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS2"
    Private Sub V_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CTTS2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CTTS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CTTS2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS3"
    Private Sub V_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CTTS3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CTTS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CTTS3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS4"
    Private Sub V_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CTTS4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_CTTS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CTTS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CTTS5"
    Private Sub V_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CTTS5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCTTS", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_CTTS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CTTS5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CTTS5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CTTS5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_CTTS.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        V_SaveImage()
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
