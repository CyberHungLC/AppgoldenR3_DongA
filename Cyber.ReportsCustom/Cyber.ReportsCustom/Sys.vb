Imports Cyber.Smreports
Imports System.Data.SqlClient
Public Class Sys
    Public oReportFormLib As Cyber.Smreports.FrmRepports_Banded
    Dim M_Para As String()
    Public M_Loai_BC As String = "VND"
    Public oSysVar As New Collection()
    Public M_strParameterStore As String = ""
    Public M_strFieldValue As String = ""
    Public M_strFieldName As String = ""
    Public M_Loai_DK_Loc As String = "0"
    Public Sub main()
        'Dim M_Para As String()
        'Dim abc As String
        'abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLSO1"
        'abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLCD1"
        'M_Para = abc.Trim.Split("#")
        'Initvao1(M_Para)
    End Sub
    Public Function V_GetFrmFilter(ByVal Cp_Name As String, ByVal status As String) As Cyber.From.FilterReport
        Dim _Return As Cyber.From.FilterReport = Nothing

        Select Case Cp_Name.ToString.Trim.ToUpper

            Case "CP_SYSTH1_BAN_LOC_TEN_THU_TUC_O_DAY".Trim.ToUpper
                '--CYBERSOFT Cho Phép bạn Hiệu chỉnh ở phần này
                _Return = New SysTH1
                'Gl----------------------------------------------------------------------------------------------------------------------------------
            Case "CP_FACTTSBK1".Trim.ToUpper
                _Return = New FACTTSBK1
            Case "CP_FAKKCTTS".Trim.ToUpper

                _Return = New FAKKCTTS
            Case "CP_FaBcKh".Trim.ToUpper, "CP_FaBcKh01".Trim.ToUpper
                _Return = New FaBcKh

            Case "CP_Tinhdaxuat1".Trim.ToUpper
                _Return = New Tinhdaxuat1
            Case "CP_GLPNL".Trim.ToUpper
                _Return = New GLPNL
            Case "CP_INTH1".Trim.ToUpper
                _Return = New INTH1
            Case "CP_GLSO1PHI".Trim.ToUpper
                _Return = New GLSO1PHI
            Case "CP_SOBK1".Trim.ToUpper
                _Return = New SOBK1
            Case "CP_INSD2_VAT".Trim.ToUpper
                _Return = New INSD2
            Case "CP_ARTTBK3".Trim.ToUpper
                _Return = New ARTTBK3
            Case "CP_ARSO1".Trim.ToUpper
                _Return = New ARSO1
            Case "CP_ARSO1T".Trim.ToUpper
                _Return = New ARSO1T
            Case "CP_ARTTBK1".Trim.ToUpper
                _Return = New ARTTBK1
            Case "CP_ARCD1".Trim.ToUpper
                _Return = New ARCD1

            Case "CP_GLCD1_BPPhi".Trim.ToUpper
                _Return = New GLCD1_BPPhi
            Case "CP_GLSO1".Trim.ToUpper
                _Return = New GLSO1
            Case "CP_GLSO1T".Trim.ToUpper
                _Return = New GLSO1T
            Case "CP_GLSO1B".Trim.ToUpper
                _Return = New GLSO1B
            Case "CP_GLTC1".Trim.ToUpper
                _Return = New GLTC1
            Case "CP_GLBK1".Trim.ToUpper
                _Return = New GLBK1
            Case "CP_GLTH1".Trim.ToUpper
                _Return = New GLTH1
     
            Case "CP_GLCD1".Trim.ToUpper
                _Return = New GLCD1
            Case "CP_GLthuebk21".Trim.ToUpper
                _Return = New GLThueBk21
            Case "CP_GLthuebk31".Trim.ToUpper
                _Return = New GLThueBk31
                '    'BE ------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_BESO1".Trim.ToUpper, "CP_BEXSO1".Trim.ToUpper
                '    _Return = New BESO1
                'Case "CP_BETH1".Trim.ToUpper, "CP_BEBK11".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BECD1".Trim.ToUpper, "CP_BEXCD1".Trim.ToUpper
                '    _Return = New BECD1
                'Case "CP_BEBK1"
                '    _Return = New BETH1
                'Case "CP_BEBK1".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BEXTH1".Trim.ToUpper, "CP_BEXBK1".Trim.ToUpper, "CP_BEXBK11".Trim.ToUpper, "CP_BEXBK12".Trim.ToUpper, "CP_BEBK12".Trim.ToUpper
                '    _Return = New BEXTH1
                'Case "CP_BECD2".Trim.ToUpper, "CP_BEXCD2".Trim.ToUpper
                '    _Return = New BECD2
                'Case "CP_BEKQKD_HDC".Trim.ToUpper, "CP_BEKQKD_HDC_DETAIL"
                '    _Return = New BEKQKD_HDC
                'Case "CP_BEKQKD_HDX".Trim.ToUpper, "CP_BEKQKD_HDX_DETAIL"
                '    _Return = New BEKQKD_HDX
                'Case "CP_BEKH6_HDX_HDC".Trim.ToUpper, "CP_BEKH6_HDX_HDC_DETAIL"
                '    _Return = New BEKH6_HDX_HDC
            Case "CP_BEGXKH".Trim.ToUpper
                _Return = New BEGXKH
            Case "CP_BEBCTN03".Trim.ToUpper
                _Return = New BEBCTN03
            Case "CP_BEPKDBC1".Trim.ToUpper
                _Return = New BEPKDBC1
            Case "CP_BEPKDBC3".Trim.ToUpper
                _Return = New BEPKDBC3
            Case "CP_BEDMHDBK1".Trim.ToUpper
                _Return = New BEDmHDBk1
            Case "CP_PTSLBX".Trim.ToUpper
                _Return = New PTSLBX
            Case "CP_BEKQTH1".Trim.ToUpper
                _Return = New BEKQTH1
            Case "CP_BETHKH".Trim.ToUpper
                _Return = New BETHKH
            Case "CP_BESD1".Trim.ToUpper
                _Return = New BESD1
            Case "CP_BEXTONKHODUKIEN".Trim.ToUpper
                _Return = New BEXTONKHODUKIEN
            Case "CP_BEDmHD02".Trim.ToUpper
                _Return = New BEDmHD02
            Case "CP_BECongNoHD".Trim.ToUpper
                _Return = New BECongNoHD
            Case "CP_BE_KH04".Trim.ToUpper
                _Return = New BE_KH04
            Case "CP_BC_LDXuat".Trim.ToUpper, "CP_BC_LDXuat".Trim.ToUpper
                _Return = New BC_LDXuat
            Case "CP_BE_KH05".Trim.ToUpper
                _Return = New BE_KH04
            Case "CP_BE_KH06".Trim.ToUpper
                _Return = New BE_KH06
            Case "CP_RO_05_Detail".Trim.ToUpper
                _Return = New RO_05
            Case "CP_RO_05".Trim.ToUpper
                _Return = New RO_05
            Case "CP_RO_DT02".Trim.ToUpper
                _Return = New RO_DT02
            Case "CP_BEPPKBK1".Trim.ToUpper.ToUpper
                _Return = New BEPPKBK1
            Case "CP_BE_KHBX".Trim.ToUpper
                _Return = New BE_KHBX
            Case "CP_BEHDCBK1".Trim.ToUpper
                _Return = New BEHDCBK1
            Case "CP_Ro_KPICVDV".Trim.ToUpper
                _Return = New Ro_KPICVDV
            Case "CP_BE_HDBX".Trim.ToUpper
                _Return = New BEDmHD02
            Case "CP_BE_HDBX_Detail".Trim.ToUpper
                _Return = New BEDmHD02
            Case "CP_BEGX".Trim.ToUpper
                _Return = New BEDmHD02
            Case "CP_BEGX_Detail".Trim.ToUpper
                _Return = New BEDmHD02
            Case "CP_BEKQTH2".Trim.ToUpper
                _Return = New BEKQTH2

            Case "CP_BCDXMBK1".Trim.ToUpper
                _Return = New BCDXMBK1
            Case "CP_BCDN3BK1".Trim.ToUpper
                _Return = New BCDN3BK1
            Case "CP_RODTKTV".Trim.ToUpper
                _Return = New RODTKTV
                ''RO ------------------------------------------------------------------------------------------------------------------------------
            Case "CP_RO_LH01".Trim.ToUpper, "CP_RO_LH01".Trim.ToUpper
                _Return = New RO_LH01
            Case "CP_RO_BCDV37".Trim.ToUpper, "CP_RO_BCDV37".Trim.ToUpper
                _Return = New RO_BCDV37
            Case "CP_RO_GTGT".Trim.ToUpper, "CP_RO_GTGT".Trim.ToUpper
                _Return = New RO_GTGT
            Case "CP_ROBH_BC02".Trim.ToUpper, "CP_ROBH_BC02".Trim.ToUpper
                _Return = New ROBH_BC02
            Case "CP_RO_TT01".Trim.ToUpper, "CP_RO_TT01".Trim.ToUpper
                _Return = New RO_TT01
            Case "CP_RO_BC_THMG".Trim.ToUpper, "CP_RO_BC_THMG2".Trim.ToUpper
                _Return = New RO_BC_THMG
            Case "CP_RO_HD06".Trim.ToUpper, "CP_RO_HD06".Trim.ToUpper
                _Return = New RO_HD06
            Case "CP_RO_HD04".Trim.ToUpper
                _Return = New RO_HD04
            Case "CP_RO_HD03".Trim.ToUpper, "CP_RO_HD03".Trim.ToUpper
                _Return = New RO_HD03
            Case "CP_RO_HD03_XanhSm".Trim.ToUpper
                _Return = New RO_HD03_XanhSm
            Case "CP_RO_HDS_KPI_TH_CNHD".Trim.ToUpper, "CP_RO_HDS_KPI_TH_CNHD".Trim.ToUpper
                _Return = New RO_HDS_KPI_TH_CNHD
            Case "CP_RO_DT05".Trim.ToUpper, "CP_RO_DT05".Trim.ToUpper
                _Return = New RO_DT05
            Case "CP_INBK1".Trim.ToUpper, "CP_INBK1".Trim.ToUpper
                _Return = New INBK1
            Case "CP_INCD1".Trim.ToUpper
                _Return = New INCD1
            Case "CP_INSO1".Trim.ToUpper
                _Return = New INSo1
            Case "CP_INSD2".Trim.ToUpper
                _Return = New INSD2
            Case "CP_INSD3".Trim.ToUpper
                _Return = New INSD3
            Case "CP_SysBK1POD".Trim.ToUpper, "CP_SysBK1POD".Trim.ToUpper
                _Return = New SysBK1POD
            Case "CP_RO_X04".Trim.ToUpper, "CP_RO_X04".Trim.ToUpper
                _Return = New RO_X04
            Case "CP_RO_KTV_BK1".Trim.ToUpper, "CP_RO_KTV_BK1".Trim.ToUpper
                _Return = New RO_KTV_BK1
            Case "CP_RO_X09".Trim.ToUpper, "CP_RO_X09".Trim.ToUpper
                _Return = New RO_X09
            Case "CP_ROBCDV01_TH".Trim.ToUpper, "CP_ROBCDV01_TH".Trim.ToUpper
                _Return = New ROBCDV01_TH
            Case "CP_ROBCDV01_LuyKe".Trim.ToUpper, "CP_ROBCDV01_LuyKe".Trim.ToUpper
                _Return = New ROBCDV01_LuyKe
            Case "CP_RO_BC_BBH".Trim.ToUpper, "CP_RO_BC_BBH".Trim.ToUpper
                _Return = New RO_BC_BBH
            Case "CP_RO_HD03Detail".Trim.ToUpper, "CP_RO_HD03Detail".Trim.ToUpper
                _Return = New RO_HD03Detail
            Case "CP_RO_BC_THXuat_RO".Trim.ToUpper, "CP_RO_BC_THXuat_RO".Trim.ToUpper
                _Return = New RO_BC_THXuat_RO
            Case "CP_RO_BC_YCDatVT_RO".Trim.ToUpper
                _Return = New RO_BC_YCDatVT_RO
            Case "CP_ROBCDTDV_TO".Trim.ToUpper, "CP_ROBCDTDV_TO_SCC".Trim.ToUpper
                _Return = New ROBCDTDV_To
            Case "CP_ROBCDTDV_TO_SDS".Trim.ToUpper
                _Return = New ROBCDTDV_ToSDS
            Case "CP_RO_COUPON_HANG".Trim.ToUpper
                _Return = New RO_COUPON_HANG
            Case "CP_RO_DD01".Trim.ToUpper
                _Return = New RO_DD01
            Case "CP_RO_01".Trim.ToUpper
                _Return = New RO_01
            Case "CP_INVTANLYSIS".Trim.ToUpper
                _Return = New INVTANLYSIS
            Case "CP_RO_BCDV42".Trim.ToUpper
                _Return = New RO_BCDV42
            Case "CP_BC_CNBH".Trim.ToUpper
                _Return = New BC_CNBH
            Case "CP_RO_02".Trim.ToUpper
                _Return = New RO_02
            Case "CP_RO_VR01".Trim.ToUpper
                _Return = New RO_VR01
            Case "CP_RO_VR03".Trim.ToUpper
                _Return = New RO_VR03

            Case "CP_BC_DSDLHDV".Trim.ToUpper
                _Return = New BC_DSDLHDV
            Case "CP_RO_W_NonBBH".Trim.ToUpper
                _Return = New RO_W_NonBBH
            Case "CP_RO_04".Trim.ToUpper
                _Return = New RO_04
            Case "CP_RO_DT01".Trim.ToUpper
                _Return = New RO_DT01
            Case "CP_RO_01_Ngay".Trim.ToUpper
                _Return = New RO_01_Ngay
            Case "CP_Ro_KPICVDV".Trim.ToUpper
                _Return = New Ro_KPICVDV
            Case "CP_BC_HLGiaVT".Trim.ToUpper
                _Return = New BC_HLGiaVT
            Case "CP_RO_DT03".Trim.ToUpper
                _Return = New RO_DT03
            Case "CP_RO_03".Trim.ToUpper
                _Return = New RO_03
            Case "CP_BC_QLXeTon".Trim.ToUpper
                _Return = New BC_QLXeTon
            Case "CP_BC_QLXPICK".Trim.ToUpper
                _Return = New BCXuatPick
            Case "CP_BC_PhieuHS".Trim.ToUpper
                _Return = New BC_PhieuHS
            Case "CP_RO_HD05".Trim.ToUpper
                _Return = New RO_HD05
            Case "CP_RO_HD01".Trim.ToUpper, "CP_RO_HD02".Trim.ToUpper
                _Return = New RO_HD01
            Case "CP_YCDat_Hang".Trim.ToUpper
                _Return = New YCDat_Hang
            Case "CP_RODTKTV_Detail".Trim.ToUpper
                _Return = New RODTKTV_Detail
                '2. Thong_ke
            Case "CP_RO_VR02".Trim.ToUpper
                _Return = New RO_VR02
                '3.Lenh
            Case "CP_RO_09".Trim.ToUpper
                _Return = New RO_09
            Case "CP_RO_BKVTPTSC".Trim.ToUpper
                _Return = New RO_BKVTPTSC
                '4.Thanh_Toan
            Case "CP_RO_TT02".Trim.ToUpper
                _Return = New RO_TT02
            Case "CP_BC_HDKhac_Detail".Trim.ToUpper
                _Return = New BC_HDKhac_Detail
                '5.Doanh_Thu
            Case "CP_RO_DD02".Trim.ToUpper
                _Return = New RO_DD02
                '------------------------------------------------------Bảo hiểm -----------------------------------------------------------------
            Case "CP_BCRO_BH06_Detail".Trim.ToUpper, "CP_BCRO_BH06_Detail".Trim.ToUpper
                _Return = New BCRO_BH06
            Case "CP_ROSSPXRO".Trim.ToUpper, "CP_ROSSPXRO".Trim.ToUpper
                _Return = New ROSSPXRO

            Case "CP_BC_AnChiBH".Trim.ToUpper, "CP_BC_AnChiBH".Trim.ToUpper
                _Return = New BC_AnChiBH
            Case "CP_BCRO_BH06".Trim.ToUpper, "CP_BCRO_BH06".Trim.ToUpper
                _Return = New BCRO_BH06
            Case "CP_BCXuatPick".Trim.ToUpper
                _Return = New BCXuatPick
                '------------------------------------------------CSKH--------------------------------------------------------

            Case "CP_CSKH024".Trim.ToUpper, "CP_CSKH024".Trim.ToUpper
                _Return = New CSKH024
            Case "CP_CRM_KQLH_Detail".Trim.ToUpper
                _Return = New CRM_KQLH_Detail
            Case "CP_BC_ZALOSMS".Trim.ToUpper
                _Return = New BC_ZALOSMS
            Case "CP_CRM_KQLH_TH".Trim.ToUpper
                _Return = New CRM_CS01
            Case "CP_CSKH070".Trim.ToUpper
                _Return = New CSKH70
            Case "CP_CSKH070TH".Trim.ToUpper
                _Return = New CSKH70
            Case "CP_BC_CRMNhac_BD".Trim.ToUpper
                _Return = New BC_CRMNhac_BD
            Case "CP_INCD2".Trim.ToUpper, "CP_INCD1_Lop".Trim.ToUpper
                _Return = New INCD1
            Case "CP_INCD1_VT".Trim.ToUpper
                _Return = New INCD1
            Case "CP_INCD1_KyGui".Trim.ToUpper
                _Return = New INCD1
            Case "CP_BangKe_HoaDon".Trim.ToUpper
                _Return = New BangKe_HoaDon
            Case "CP_ARTTBK3_HanTT".Trim.ToUpper
                _Return = New ARTTBK3
            Case "CP_ARTH1".Trim.ToUpper
                _Return = New ARTH1
            Case Else
                _Return = Nothing
        End Select
 

        V_GetFrmFilter = _Return
    End Function
    'Public Function Initvao(ByVal _Para As String()) As Boolean
    '    M_Para = _Para
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '    Dim K_Tmp As String = M_Para(1).Trim
    '    Dim K_System As String = M_Para(2).Trim
    '    Dim K_Repo As String = M_Para(3).Trim
    '    Dim K_Repo_Nt As String = M_Para(4).Trim
    '    Dim M_CYBER_VER As String = M_Para(5).Trim
    '    Dim M_User_Name As String = M_Para(6).Trim
    '    Dim M_Comment As String = M_Para(7).Trim
    '    Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '    Dim M_User_ID As String = M_Para(9).Trim
    '    Dim M_Menu_ID0 As String = M_Para(10).Trim
    '    Dim M_Bar As String = M_Para(11).Trim
    '    Dim M_Bar2 As String = M_Para(12).Trim
    '    Dim M_LAN As String = M_Para(13).Trim
    '    Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '    Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim FrmFilter As Cyber.From.FilterReport
    '    FrmFilter = V_GetFrmFilter(M_Cp_Name, "1")

    '    Dim CyberSmLib As New Cyber.SmLib.Sys
    '    Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '    oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.Para = M_Para
    '    FrmFilter.sysvar = oSysVar
    '    FrmFilter.AppConn = Appconn
    '    FrmFilter.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    M_Loai_BC = IIf(M_LAN = "V", "VND", "NT")
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.ShowDialog()
    '    If Not FrmFilter.is_continue Then Return False
    '    M_Loai_DK_Loc = "0"
    '    M_strParameterStore = FrmFilter.Tag.ToString
    '    V_Loaddata(M_Cp_Name, M_strParameterStore, oReportFormLib, "1", M_Loai_DK_Loc, FrmFilter)
    '    Return True
    'End Function
    'Private Sub V_Loaddata(ByVal sCp_name As String, ByVal strParastore As String, ByVal oReportFormLib As Cyber.Smreports.FrmRepports_Banded, ByVal loadtype As String, ByVal Loai_DK_Loc As String, Optional ByVal FrmFilter As Form = Nothing)
    '    oReportFormLib = New Cyber.Smreports.FrmRepports_Banded
    '    If FrmFilter Is Nothing Then oReportFormLib.FrmFilter = Nothing Else oReportFormLib.FrmFilter = FrmFilter
    '    oReportFormLib.SysVar = oSysVar
    '    oReportFormLib.Para = M_Para
    '    oReportFormLib.Loai_BC = M_Loai_BC
    '    oReportFormLib.Cp_name = sCp_name
    '    oReportFormLib.strParastore = strParastore
    '    oReportFormLib.strFieldValue = M_strFieldValue
    '    oReportFormLib.strFieldName = M_strFieldName
    '    oReportFormLib.Ma_Dvcs = M_Para(14).Trim ' M_Ma_Dvcs
    '    oReportFormLib.User_name = M_Para(6).Trim ' M_User_Name
    '    oReportFormLib.Loai_DK_Loc = Loai_DK_Loc
    '    oReportFormLib.Lan = M_Para(13).Trim ' M_LAN
    '    AddHandler oReportFormLib.DetailReport, AddressOf V_Detail
    '    AddHandler oReportFormLib.QuickDetailReport, AddressOf V_QuickDetail
    '    oReportFormLib.ShowDialog()
    'End Sub
    '#Region "Detail Reports"
    '    Sub V_Detail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameDetail As String, ByVal strParasource As String, ByVal strParasourceDetail As String, ByVal DrvDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        If DrvDetail Is Nothing Then Exit Sub
    '        If cpname.Trim = "" Or cpnameDetail.Trim = "" Then Exit Sub
    '        Dim oReportFrm As New Cyber.Smreports.FrmRepports_Banded
    '        Dim frm As Cyber.From.FilterReport
    '        frm = V_GetFrmFilter(cpnameDetail, "0")
    '        Dim _ParaNew As String() = V_GetPara(cpnameDetail, M_Para, strParasource)
    '        Dim _ParaOld As String() = M_Para
    '        M_Para = _ParaNew
    '        '--------------------------------------------------------------------------------------------------------------------
    '        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '        Dim K_Tmp As String = M_Para(1).Trim
    '        Dim K_System As String = M_Para(2).Trim
    '        Dim K_Repo As String = M_Para(3).Trim
    '        Dim K_Repo_Nt As String = M_Para(4).Trim
    '        Dim M_CYBER_VER As String = M_Para(5).Trim
    '        Dim M_User_Name As String = M_Para(6).Trim
    '        Dim M_Comment As String = M_Para(7).Trim
    '        Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '        Dim M_User_ID As String = M_Para(9).Trim
    '        Dim M_Menu_ID0 As String = M_Para(10).Trim
    '        Dim M_Bar As String = M_Para(11).Trim
    '        Dim M_Bar2 As String = M_Para(12).Trim
    '        Dim M_LAN As String = M_Para(13).Trim
    '        Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '        Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '        '--------------------------------------------------------------------------------------------------------------------

    '        If Not frm Is Nothing Then
    '            frm.Tag = strParasourceDetail
    '            frm.Para = M_Para
    '            frm.sysvar = oSysVar
    '            Dim CyberSmLib As New Cyber.SmLib.Sys
    '            Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '            'Dim oSysVar As New Collection()
    '            oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '            frm.AppConn = Appconn
    '            frm.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '        End If
    '        V_Loaddata(cpnameDetail, strParasourceDetail, oReportFrm, "1", Loai_DK_Loc, frm)
    '        M_Para = _ParaOld
    '    End Sub
    '    Sub V_QuickDetail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameQDetail As String, ByVal strParasource As String, ByVal strParasourceQDetail As String, ByVal DrvQDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        V_Detail(sender, e, cpname, cpnameQDetail, strParasource, strParasourceQDetail, DrvQDetail, Loai_DK_Loc)
    '    End Sub
    '#End Region
#Region "Add On F8/F9/F10/F11/F12"
    Public Function V_F8(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String) As Boolean
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F9(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F10(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F11(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F12(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
#End Region
#Region "Support"
    Public Sub V_LoadLoai_BC(ByVal chkVND As CheckBox, ByVal chkNT As CheckBox, Optional ByVal _LAN As String = "V")
        If _LAN.Trim = "V" Then
            chkVND.Checked = True
            chkNT.Checked = False
        Else
            chkVND.Checked = False
            chkNT.Checked = True
        End If
    End Sub
    Public Function GetLoai_BC(ByVal chkVND As CheckBox) As String
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function GetLoai_BC(ByVal chkVND As CheckBox, ByVal chk2 As CheckBox) As String
        If chkVND.Checked And chk2.Checked Then Return ""
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing) As DataTable
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _Ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_SysGetGD", _Ma_Ct)
        V_GetMaGD = _Ds.Tables(0).Copy
        _Ds.Dispose()
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, ByVal _Cbb As ComboBox, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing) As DataTable
        Dim _Dt As DataTable = V_GetMaGD(_App, _Ma_Ct, CyberSmlib)
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        CyberFill.V_FillComBoxDefaul(_Cbb, _Dt, "Ma_GD", "ten_GD")
    End Function
    Public Function V_GetValueCombox(ByVal _Cbb As ComboBox) As String
        Dim _Return As String = ""
        Try
            _Return = _Cbb.SelectedValue.ToString.Trim
        Catch ex As Exception
            _Return = ""
        End Try
        V_GetValueCombox = _Return
    End Function
#End Region
End Class

