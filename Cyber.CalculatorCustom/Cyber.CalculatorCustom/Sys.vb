Imports System.Data.SqlClient
Public Class Sys
    Public Function Initvao(ByVal M_Para As String()) As Boolean
        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        Dim M_CP_Name As String = M_Para(M_VT_PARA + 1).Trim
        Dim M_User_Name As String = M_Para(6).Trim
        Dim M_Lan As String = M_Para(13).Trim
        Dim M_Ma_Dvcs As String = M_Para(14).Trim
        Dim M_Bar As String = M_Para(11).Trim
        Dim M_Bar2 As String = M_Para(12).Trim
        Dim _Title As String = "Đang thực hiện: " + M_Bar
        Dim _Title2 As String = "Processing: " + M_Bar2
        '------------------------------------------------------------------------------------------------------
        If M_CP_Name = "TOI_DIEU_HUONG_SANG_BAN_CHUAN" Then Return False
        '------------------------------------------------------------------------------------------------------
        '--CYBERSOFT Cho Phép bạn Hiệu chỉnh ở phần này
        '------------------------------------------------------------------------------------------------------
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim CyberSupport As New Cyber.Support.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        Dim CyberSmlistSys As New Cyber.SmLists.Sys
        Dim CyberSmodb As New Cyber.Smodb.Sys
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim CyberLoading = New Cyber.Loading.Loading
        Dim Appconn As SqlConnection = CyberSmlib.GetConn()
        Dim oSysvar As Collection = CyberSmlib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
        M_CP_Name = M_CP_Name.Trim.ToUpper

        Dim Frm As Cyber.From.FrmCalculator
        Select Case M_CP_Name.ToUpper
            Case "CP_RODsLenh".ToUpper.Trim
                Frm = New RODsLenh
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.WindowState = Windows.Forms.FormWindowState.Maximized
                Frm.ShowDialog()
                Return True

            Case "CP_ROTRANLOC".ToUpper.Trim
                Frm = New ROTRAN
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                If Not Frm.Save_OK Then Return True

                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If

                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)
                Return True
            Case "CP_GLDuyetCT_Load".ToUpper.Trim
                Frm = New FrmDuyetCT
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                If Not Frm.Save_OK Then Return True

                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If

                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)
                Return True
            Case "CP_InGiaCost_Lop".ToUpper.ToString
                Frm = New InGiaCost_Lop
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                If Not Frm.Save_OK Then Return True

                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If

                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)

                Return True
            Case "CP_CRMQLLLLOAD".ToUpper.Trim
                Frm = New CRM_Loc
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                If Not Frm.Save_OK Then Return True
                '-------------
                Dim Frm1 As New CRM_Xem
                Frm1.strLoc = Frm.Tag.ToString.Trim
                '-------------
                Frm1.Lan = M_Lan
                Frm1.Para = M_Para
                Frm1.Sysvar = oSysvar
                Frm1.AppConn = Appconn
                Frm1.CyberSmlib = CyberSmlib
                Frm1.CyberSupport = CyberSupport
                Frm1.CyberFill = CyberFill
                Frm1.CyberSmlistSys = CyberSmlistSys
                Frm1.CyberSmodb = CyberSmodb
                Frm1.CyberExport = CyberEport
                Frm1.CyberVoucher = CyberVoucher
                Frm1.CyberLoading = CyberLoading
                Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

                Frm1.Key_Sub1 = Frm.Key_Sub1.ToString.Trim
                Frm1.Key_Sub2 = Frm.Key_Sub2.ToString.Trim
                Frm1.Key_Sub3 = Frm.Key_Sub3.ToString.Trim
                Frm1.Key_Sub4 = Frm.Key_Sub4.ToString.Trim
                Frm1.Key_Sub5 = Frm.Key_Sub5.ToString.Trim

                Frm1.ShowDialog()
                Return True
            Case "CP_ROIMPORTDMVT".ToUpper.ToString
                Frm = New RoimportDmVT
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "CP_UPDATEGIA2".ToUpper.ToString
                Frm = New RoUpdateGia
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True

            Case "CP_FrmNhapBaoHiem_Load".ToUpper.ToString
                Dim Frm2 As New FrmNhapBaoHiem
                Frm2.Lan = M_Lan
                Frm2.Para = M_Para
                Frm2.Sysvar = oSysvar
                Frm2.AppConn = Appconn
                Frm2.CyberSmlib = CyberSmlib
                Frm2.CyberSupport = CyberSupport
                Frm2.CyberFill = CyberFill
                Frm2.CyberSmlistSys = CyberSmlistSys
                Frm2.CyberSmodb = CyberSmodb
                Frm2.CyberExport = CyberEport
                Frm2.CyberVoucher = CyberVoucher
                Frm2.CyberLoading = CyberLoading
                Frm2.ShowDialog()
            Case "CP_ROXPT".ToUpper.Trim
                Frm = New ROXPT
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                Return True
            Case "CP_RoXacNhanLenh_Load".ToUpper.ToString
                Frm = New FrmXacNhan
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "CP_CopyGroup_Load".ToString.ToUpper
                Frm = New CopyGroup_Filter
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "Ro_History".ToUpper.Trim
                Frm = New Ro_History
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                Return True
            Case "CP_CrmSaveSMS".Trim.ToUpper
                Frm = New CRM_GuiSMSOld
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                If Not Frm.Save_OK Then Return True
            Case "CP_CrmSaveZalo".Trim.ToUpper
                Frm = New CRM_GuiZalo
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                If Not Frm.Save_OK Then Return True
            Case "CP_CRMSaveDmXe".Trim.ToUpper
                Dim Frm1 As New Crm_CapNhat
                Frm1.Lan = M_Lan
                Frm1.Para = M_Para
                Frm1.Sysvar = oSysvar
                Frm1.AppConn = Appconn
                Frm1.CyberSmlib = CyberSmlib
                Frm1.CyberSupport = CyberSupport
                Frm1.CyberFill = CyberFill
                Frm1.CyberSmlistSys = CyberSmlistSys
                Frm1.CyberSmodb = CyberSmodb
                Frm1.CyberExport = CyberEport
                Frm1.CyberVoucher = CyberVoucher
                Frm1.CyberLoading = CyberLoading
                Frm1.ShowDialog()
                Return True
            Case "CP_CMSCuocGoi".ToUpper.Trim

                Frm = New CRGoiDien
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                If Not Frm.Save_OK Then Return True

                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If

                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)
                Return True
            Case "CP_VTTraCuuTon".ToUpper.Trim
                Frm = New VTTraCuuTon
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                If Not Frm.Save_OK Then Return True

                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If

                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)
                Return True
                'Case "CP_VTTraCuuTon".ToUpper.ToString

                '    Frm = New VTTraCuuTon

            Case "CP_BEXEPXE"
                Dim Frm2 As New BEXEPXELOC
                Frm2.Lan = M_Lan
                Frm2.Para = M_Para
                Frm2.Sysvar = oSysvar
                Frm2.AppConn = Appconn
                Frm2.CyberSmlib = CyberSmlib
                Frm2.CyberSupport = CyberSupport
                Frm2.CyberFill = CyberFill
                Frm2.CyberSmlistSys = CyberSmlistSys
                Frm2.CyberSmodb = CyberSmodb
                Frm2.CyberExport = CyberEport
                Frm2.CyberVoucher = CyberVoucher
                Frm2.CyberLoading = CyberLoading
                Frm2.ShowDialog()
                If Not Frm2.Save_OK Then Return True

                CyberSmlib.FlushMemorySave()
                If Not Frm2.Save_OK Then Return True

                Dim M_strParameterStore As String = Frm2.Tag.ToString.Trim

                If M_strParameterStore.Trim = "" Then Return True
                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCalculator As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, M_strParameterStore)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

                Dim Frm1 As New BEXEPXE_XEM
                Frm1.strLoc = Frm2.Tag.ToString.Trim
                Frm1.Cp_Loc = M_CP_Name

                Frm1.Lan = M_Lan
                Frm1.Para = M_Para
                Frm1.Sysvar = oSysvar
                Frm1.AppConn = Appconn
                Frm1.CyberSmlib = CyberSmlib
                Frm1.CyberSupport = CyberSupport
                Frm1.CyberFill = CyberFill
                Frm1.CyberSmlistSys = CyberSmlistSys
                Frm1.CyberSmodb = CyberSmodb
                Frm1.CyberExport = CyberEport
                Frm1.CyberVoucher = CyberVoucher
                Frm1.CyberLoading = CyberLoading
                Frm1.DsDataLoc = DsCalculator
                Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

                Frm1.Key_Sub1 = Frm2.Key_Sub1.ToString.Trim
                Frm1.Key_Sub2 = Frm2.Key_Sub1.ToString.Trim

                Frm1.Ma_Kx = Frm2.Key_Sub1.ToString.Trim
                Frm1.Ma_Mau = Frm2.Key_Sub1.ToString.Trim
                Frm1.Thang1 = Frm2.Thang1.ToUpper.Trim
                Frm1.Thang2 = Frm2.Thang2.ToUpper.Trim
                Frm1.Nam1 = Frm2.Nam1.ToUpper.Trim
                Frm1.Nam2 = Frm2.Nam2.ToUpper.Trim
                Frm1.Nam = Frm2.Nam.ToUpper.Trim
                Frm1.Key_Sub3 = Frm2.Key_Sub3.ToUpper.Trim

                Frm1.ShowDialog()
                Return True
            Case "CP_ROIMPORTDMPK".ToUpper.ToString
                Frm = New RoimportDmPK
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "CP_RoUPDATEDmGIANC".ToUpper.ToString
                Frm = New RoUpdateGiaNC
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "CP_LOAAPPROVAL".ToUpper.Trim

                Frm = New LOA_Loc
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                If Not Frm.Save_OK Then Return True
                '-------------
                Dim Frm1 As New LOA_Xem
                Frm1.strLoc = Frm.Tag.ToString.Trim
                '-------------
                Frm1.Lan = M_Lan
                Frm1.Para = M_Para
                Frm1.Sysvar = oSysvar
                Frm1.AppConn = Appconn
                Frm1.CyberSmlib = CyberSmlib
                Frm1.CyberSupport = CyberSupport
                Frm1.CyberFill = CyberFill
                Frm1.CyberSmlistSys = CyberSmlistSys
                Frm1.CyberSmodb = CyberSmodb
                Frm1.CyberExport = CyberEport
                Frm1.CyberVoucher = CyberVoucher
                Frm1.CyberLoading = CyberLoading
                Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

                Frm1.Key_Sub1 = Frm.Key_Sub1.ToString.Trim
                Frm1.Key_Sub2 = Frm.Key_Sub2.ToString.Trim
                Frm1.Key_Sub3 = Frm.Key_Sub3.ToString.Trim
                Frm1.Key_Sub4 = Frm.Key_Sub4.ToString.Trim
                Frm1.Key_Sub5 = Frm.Key_Sub5.ToString.Trim

                Frm1.ShowDialog()
                Return True
            Case "CP_DOI_TVBH"
                Dim Frm2 As New Doi_TVBH
                Frm2.Lan = M_Lan
                Frm2.Para = M_Para
                Frm2.Sysvar = oSysvar
                Frm2.AppConn = Appconn
                Frm2.CyberSmlib = CyberSmlib
                Frm2.CyberSupport = CyberSupport
                Frm2.CyberFill = CyberFill
                Frm2.CyberSmlistSys = CyberSmlistSys
                Frm2.CyberSmodb = CyberSmodb
                Frm2.CyberExport = CyberEport
                Frm2.CyberVoucher = CyberVoucher
                Frm2.CyberLoading = CyberLoading
                Frm2.ShowDialog()
                If Not Frm2.Save_OK Then Return True
            Case "CP_Ro_XuatPick".ToUpper.ToString
                Frm = New QLXPick
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()

                Return True
            Case "CP_DoiTTHD_Loc".ToUpper.ToString
                Frm = New DoiTTHD
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                Return True
            Case "CP_INCD1_OUT".ToUpper.Trim
                Frm = New PrintINCD1
                Frm.Lan = M_Lan
                Frm.Para = M_Para
                Frm.Sysvar = oSysvar
                Frm.AppConn = Appconn
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = CyberEport
                Frm.CyberVoucher = CyberVoucher
                Frm.CyberLoading = CyberLoading
                Frm.ShowDialog()
                If Not Frm.Save_OK Then Return True
                Dim StrPr As String = Frm.Tag.ToString.Trim
                If StrPr.Trim = "" Then
                    Return True
                End If
                If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
                Dim DsCal As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, StrPr)
                If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
                CyberSupport.V_MsgChk(DsCal.Tables(0), oSysvar, M_Para(13).Trim)
                Return True
            Case Else
                Return False
        End Select
        CyberSmlib.FlushMemorySave()
        Return True
    End Function
    'Public Function GetFormCRM_F3(ByVal M_Loai As String, ByVal M_Ma_Loai As String, ByVal M_Ma_Ngay As String) As CRM_F3
    Public Function GetFormCRM_F3(ByVal M_Loai As String, ByVal M_Ma_Loai As String, ByVal M_Ma_Ngay As String) As ThangToThang
        'Dim _Return As CRM_F3 = Nothing
        ''_Return = New CRM_F3
        'Return _Return
        Return Nothing
    End Function

End Class
