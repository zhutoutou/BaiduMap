using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Web.Model;

namespace Web
{
    public class InfoBll
    {
        #region 变量
        private static volatile InfoBll instance;
        private static object syncRoot = new Object();
        #endregion

        #region 自定义方法
        public static InfoBll Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new InfoBll();
                    }
                }
                return instance;
            }
        }

        public List<CallFileInfo> GetDirectTelRec(string callid, string zjhm, string bjhm)
        {
            return InfoDal.GetDirectTelRec(callid, zjhm, bjhm);
        }

        public string FN_GETMAXLSH()
        {
            return InfoDal.FN_GETMAXLSH();
        }

        public IList<V_CALLID_CACHE> SP_GET_V_CALLID_CACHE()
        {
            return InfoDal.SP_GET_V_CALLID_CACHE();
        }

        public IList<CALL_INFO> Get_CALL_INFO_BY_DATE_OR_Caller(string starttime, string endtime, string zjhm, string bjhm)
        {
            return InfoDal.Get_CALL_INFO_BY_DATE_OR_Caller(starttime, endtime, zjhm, bjhm);
        }
        public IList<V_BLACK_LIST> Get_All_V_BLACK_LIST_INFO()
        {
            return InfoDal.Get_All_V_BLACK_LIST_INFO();
        }

        public IList<V_RP_INFO> Get_V_RP_INFO()
        {
            return InfoDal.Get_V_RP_INFO();
        }

        public IList<V_Phone_Number> Get_ORG_PHONE()
        {
            return InfoDal.Get_ORG_PHONE();
        }

        public List<SYS_ORG_INFO> Get_All_V_ORG_INFO()
        {
            return InfoDal.Get_All_V_ORG_INFO();
        }

        public IList<V_CODE_HJYY> Get_V_CODE_HJYY()
        {
            return InfoDal.Get_V_CODE_HJYY();
        }

        public IList<V_Reason> Get_ReasonList()
        {
            return InfoDal.Get_ReasonList();
        }
        public IList<V_CLLB> Get_All_CLLB_INFO()
        {
            return InfoDal.Get_All_CLLB_INFO();
        }

        public List<CLLB_STATUS> Get_CLLB_INFO_BY_IDS(string czdhs)
        {
            return InfoDal.Get_CLLB_INFO_BY_IDS(czdhs);
        }

        public bool SP_UPDATE_MAJOR_ACCIDENT(SP_UPDATE_MAJOR_ACCIDENT info)
        {
            return InfoDal.SP_UPDATE_MAJOR_ACCIDENT(info);
        }

        public bool SP_UPDATE_AMBUL_TRAC(AMBUL_TRAC info)
        {
            return InfoDal.SP_UPDATE_AMBUL_TRAC(info);
        }

        public IList<V_SLJS> Get_All_SLJS_INFO()
        {
            return InfoDal.Get_All_SLJS_INFO();
        }

        public IList<V_PCJS> Get_All_PCJS_INFO()
        {
            return InfoDal.Get_All_PCJS_INFO();
        }
        /// <returns></returns>
        public IList<V_DPSJ> Get_All_DPSJ_INFO()
        {
            return InfoDal.Get_All_DPSJ_INFO();
        }

        public IList<V_SJLB> Get_All_V_SJLB_INFO()
        {
            return InfoDal.Get_All_V_SJLB_INFO();
        }

        public EventAboutInfo Get_All_V_SJLB_INFO_BY_ID(string sjh)
        {
            return InfoDal.Get_All_V_SJLB_INFO_BY_ID(sjh);
        }

        public IList<V_SJLB> Get_All_V_SJLB_INFO_BY_DATE(string starttime, string endtime)
        {
            return InfoDal.Get_All_V_SJLB_INFO_BY_DATE(starttime, endtime);
        }
        public IList<P_PRES_ACCEPT_INFO> Get_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            return InfoDal.Get_ACCEPT_INFO_BY_DATE(starttime, endtime);
        }
        public IList<SP_GET_AMBUL_OUTD_INFO> Get_AMBUL_INFO_BY_DATE(string starttime, string endtime)
        {
            return InfoDal.Get_AMBUL_INFO_BY_DATE(starttime, endtime);
        }

        public IList<V_CALLINFO> Get_CALL_INFO_BY_DATE(string starttime, string endtime, string ddyid)
        {
            return InfoDal.Get_CALL_INFO_BY_DATE(starttime, endtime, ddyid);
        }

        public IList<V_NOTICE_INFO> SP_GET_V_NOTICE_INFO(string publiser)
        {
            return InfoDal.SP_GET_V_NOTICE_INFO(publiser);
        }

        public YGZAmbulInfo GET_YGZAmbulInfoBYLSH(string lsh,string ccxh)
        {
            return InfoDal.GET_YGZAmbulInfoBYLSH(lsh, ccxh);
        }
        public IList<YGZAmbulInfo> GET_YGZAmbulInfo(string hospitalid, string hospitalname)
        {
            return InfoDal.GET_YGZAmbulInfo(hospitalid, hospitalname);
        }
        public IList<SYS_EMT_INFO> GET_SYS_EMT_INFO(string clid)
        {
            return InfoDal.GET_SYS_EMT_INFO(clid);
        }

        public IList<P_PRES_ACCEPT_INFO> GET_SP_PRES_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            return InfoDal.GET_SP_PRES_ACCEPT_INFO_BY_DATE(starttime, endtime);
        }

        public P_PRES_ACCEPT_INFO GET_SP_PRES_ACCEPT_INFO_BY_LSH(string lsh)
        {
            return InfoDal.GET_SP_PRES_ACCEPT_INFO_BY_LSH(lsh);
        }

        public IList<P_PRES_ACCEPT_INFO> GET_SP_PRES_ACCEPT_INFO(string lsh)
        {
            return InfoDal.GET_SP_PRES_ACCEPT_INFO(lsh);
        }

        public IList<SP_GET_OBLIGATE_ACCEPT_INFO> SP_GET_OBLIGATE_ACCEPT_INFO(string nZJHM)
        {
            return InfoDal.SP_GET_OBLIGATE_ACCEPT_INFO(nZJHM);
        }

        public IList<SP_GET_EVENT_CALL_INFO> Get_CALL_INFO_BY_HCLSH(string sjh, string hclsh)
        {
            return InfoDal.Get_CALL_INFO_BY_HCLSH(sjh, hclsh);
        }
        public bool Update_Staff(string lx, string lsh, string ccxh, string oldid, string newid)
        {
            return InfoDal.Update_Staff(lx, lsh, ccxh, oldid, newid);
        }
        /// <returns></returns>
        public bool Update_CallInfo_Hclsh(string calllsh, string hclsh)
        {
            return InfoDal.Update_CallInfo_Hclsh(calllsh, hclsh);
        }

        public bool SP_UPDATE_CALL_INFO(CALL_INFO info)
        {
            return InfoDal.SP_UPDATE_CALL_INFO(info);
        }

        public bool SP_UPDATE_WXUserResponse(WXUserResponse info)
        {
            return InfoDal.SP_UPDATE_WXUserResponse(info);
        }

        public P_PRES_ACCEPT_INFO SP_UPDATE_ACCEPT_INFO(ACCEPT_INFO info)
        {
            return InfoDal.SP_UPDATE_ACCEPT_INFO(info);
        }

        public Ambul_AcceptInfo UpdateEventAcceptForFZCC(EVENT_INFO info, string lsh)
        {
            return InfoDal.UpdateEventAcceptForFZCC(info, lsh);
        }

        public V_SJLB SP_UPDATE_EVENT_INFO(EVENT_INFO info)
        {
            return InfoDal.SP_UPDATE_EVENT_INFO(info);
        }

        public Ambul_AcceptInfo GetAllInfoAboutLsh(string sjh, string lsh)
        {
            return InfoDal.GetAllInfoAboutLsh(sjh,lsh);
        }
        public IList<V_RPJK> Get_V_RPJK()
        {
            return InfoDal.Get_V_RPJK();
        }

        public int SP_INSERT_DISPATCH(string strLSH, string nDDLB, string nDDLX, string strDDFZ, string strDDCL, string strFBR, string strRPID)
        {
            return InfoDal.SP_INSERT_DISPATCH(strLSH, nDDLB, nDDLX, strDDFZ, strDDCL, strFBR, strRPID);
        }
        public List<V_NOTICE_INFO> SP_INSERT_NOTICE_INFO(string strLSH, string dFBSJ, string nYXQ, string nLX, string strFBNR, string strFBR, string nJSRLX, string strJSR, string nZT)
        {
            return InfoDal.SP_INSERT_NOTICE_INFO(strLSH, dFBSJ, nYXQ, nLX, strFBNR, strFBR, nJSRLX, strJSR, nZT);
        }

        public PreDetailInfo Get_PreDetailInfo(string zjhm)
        {
            return InfoDal.Get_PreDetailInfo(zjhm);
        }

        public bool UpdateTakeHospital(string lsh, string swdd, string swyy, string clid, string sllx)
        {
            return InfoDal.UpdateTakeHospital(lsh, swdd, swyy, clid, sllx);
        }

        public string Station_Modify(string lsh, string ccxh, string oldclid, string qxyy, string newclid, string szfzid, string rpid, string ddyid, string pcsj)
        {
            return InfoDal.Station_Modify(lsh, ccxh, oldclid, qxyy, newclid, szfzid, rpid, ddyid, pcsj);
        }
        public string Station_InserAmbul(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string strSJH, string ddxh)
        {
            return InfoDal.Station_InserAmbul(strLSH, strCLID, strSZFZ, nPCLX, dPCSJ, strRPID, strDDYID, strSJH, ddxh);
        }

        public bool Station_Refuse(string strLSH, string ddxh, string qrr, string qrsj)
        {
            return InfoDal.Station_Refuse(strLSH, ddxh, qrr, qrsj);
        }

        public string Station_Cancle(string strLSH, string strCLID, string ccxh, string clzt, string qxpcsj, string qxyy, string iszxqxpc)
        {
            return InfoDal.Station_Cancle(strLSH, strCLID, ccxh, clzt, qxpcsj, qxyy, iszxqxpc);
        }

        public Ambul_AcceptInfo UpdateCancleAmbulInfo(AMBUL_OUTD_INFO info, string clzt)
        {
            return InfoDal.UpdateCancleAmbulInfo(info,clzt);
        }
        public List<SP_GET_AMBUL_OUTD_INFO> SP_UPDATE_AMBUL_OUTD_INFO(AMBUL_OUTD_INFO info)
        {
            return InfoDal.SP_UPDATE_AMBUL_OUTD_INFO(info);
        }

        public IList<SP_GET_PRANK_CALL_HIS> SP_GET_PRANK_CALL_HIS(string hm)
        {
            return InfoDal.SP_GET_PRANK_CALL_HIS(hm);
        }
        public IList<ACCEPT_YM> SP_GET_ACCEPT_YM_INFO(string isgl)
        {
            return InfoDal.SP_GET_ACCEPT_YM_INFO(isgl);
        }

        public bool SP_UPDATE_PRNAK_CALL(SP_UPDATE_PRNAK_CALL info)
        {
            return InfoDal.SP_UPDATE_PRNAK_CALL(info);
        }

        public string SP_GET_FZ_YWDDQ(string strFZID)
        {
            return InfoDal.SP_GET_FZ_YWDDQ(strFZID);
        }

        public bool SP_INSERT_ACCEPT_YM(ACCEPT_YM info)
        {
            return InfoDal.SP_INSERT_ACCEPT_YM(info);
        }

        public bool SP_UPDATE_ACCEPT_YM_INFO(string lsh, string orderid)
        {
            return InfoDal.SP_UPDATE_ACCEPT_YM_INFO(lsh, orderid);
        }

        public bool SP_UPDATE_AMBUL_OUTD_STAFF(AMBUL_OUTD_STAFF info)
        {
            return InfoDal.SP_UPDATE_AMBUL_OUTD_STAFF(info);
        }
        public bool SP_UPDATE_AMBUL_STATUS_DATE(string lsh, string clzt, string date, string ccxh, string czdh, string clid)
        {
            return InfoDal.SP_UPDATE_AMBUL_STATUS_DATE(lsh, clzt, date, ccxh, czdh, clid);
        }

        public bool SP_UPDATE_AMBUL_STATUS_INFO(AMBUL_STATUS_INFO info)
        {
            return InfoDal.SP_UPDATE_AMBUL_STATUS_INFO(info);
        }

        public bool SP_UPDATE_COMPL_INFO(SP_UPDATE_COMPL_INFO info)
        {
            return InfoDal.SP_UPDATE_COMPL_INFO(info);
        }

        public bool SP_UPDATE_CALL_INFO_MULTIPLE(SP_UPDATE_CALL_INFO_MULTIPLE info)
        {
            return InfoDal.SP_UPDATE_CALL_INFO_MULTIPLE(info);
        }

        public bool SP_UPDATE_RP_ONDUTY(string strDDYID, string strRPID, string dSBSJ, string dXBSJ, string strBZ)
        {
            return InfoDal.SP_UPDATE_RP_ONDUTY(strDDYID, strRPID, dSBSJ, dXBSJ, strBZ);
        }

        public List<V_STAFF_ONDUTY> UpdateStaffOnduty(string strGH, string strTel, string dSBSJ, string dXBSJ)
        {
            return InfoDal.UpdateStaffOnduty(strGH, strTel, dSBSJ, dXBSJ);
        }

        public bool SP_UPDATE_STAFF_ONDUTY(string strGH, string strTel, string dSBSJ, string dXBSJ)
        {
            return InfoDal.SP_UPDATE_STAFF_ONDUTY(strGH, strTel, dSBSJ, dXBSJ);
        }

        public bool SP_UPDATE_CALL_GLLSH(string strLSH, string strSJH, string nHJLX)
        {
            return InfoDal.SP_UPDATE_CALL_GLLSH(strLSH, strSJH, nHJLX);
        }

        public bool SP_UPDATE_SMS(string strLSH, string dSJ, string strFSDX, string strNR, string strBZ, string strLX)
        {
            return InfoDal.SP_UPDATE_SMS(strLSH, dSJ, strFSDX, strNR, strBZ, strLX);
        }

        public bool UPDATE_PWD(string userid, string pwd)
        {
            return InfoDal.UPDATE_PWD(userid, pwd);
        }

        public List<HZXXINfo> Get_Hzxx(string lsh)
        {
            return InfoDal.Get_Hzxx(lsh);
        }

        public List<V_EVENT_BELONG> SP_UPDATE_EVENT_BELONG(string strSJH, string strB_ID)
        {
            return InfoDal.SP_UPDATE_EVENT_BELONG(strSJH, strB_ID);
        }

        public IList<P_PRES_ACCEPT_INFO> SP_GET_EVENT_ACCEPT_INFO(string strSJH)
        {
            return InfoDal.SP_GET_EVENT_ACCEPT_INFO(strSJH);
        }

        public IList<SP_GET_AMBUL_OUTD_INFO> SP_GET_AMBUL_OUTD_INFO(string sjh)
        {
            return InfoDal.SP_GET_AMBUL_OUTD_INFO(sjh);
        }

        public IList<SP_GET_YM_RETURN> SP_GET_YM_RETURN(string lsh, string czdh, string orderid)
        {
            return InfoDal.SP_GET_YM_RETURN(lsh, czdh, orderid);
        }

        public IList<SP_GET_YM_CALLRETURN> SP_GET_YM_CALLRETURN(string lsh, string czdh)
        {
            return InfoDal.SP_GET_YM_CALLRETURN(lsh, czdh);
        }

        public IList<SP_GET_EVENT_CALL_INFO> SP_GET_EVENT_CALL_INFO(string sjh)
        {
            return InfoDal.SP_GET_EVENT_CALL_INFO(sjh);
        }

        public IList<SYS_MEMBER_INFO> Check_Sys_Member_Info(string id, string password)
        {
            try
            {
                return InfoDal.Check_Sys_Member_Info(id, password);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<V_EVENT_BELONG> Get_V_EVENT_BELONG_BY_SJH(string sjh)
        {
            return InfoDal.Get_V_EVENT_BELONG_BY_SJH(sjh);
        }

        public IList<V_EVENT_BELONG> Get_V_EVENT_BELONG()
        {
            return InfoDal.Get_V_EVENT_BELONG();
        }

        public IList<V_MEMBER_INFO> Get_V_MEMBER_INFO()
        {
            return InfoDal.Get_V_MEMBER_INFO();
        }

        public IList<V_MEMBER_INFO> Get_V_MEMBER_MAJOR_ACCIDENT_INFO()
        {
            return InfoDal.Get_V_MEMBER_MAJOR_ACCIDENT_INFO();
        }
        public bool SP_CANCLE_EVENT_BELONG(string strSJH)
        {
            return InfoDal.SP_CANCLE_EVENT_BELONG(strSJH);
        }

        public Marjor_Report Get_Marjor_Report_BY_LSH(string lsh)
        {
            return InfoDal.Get_Marjor_Report_BY_LSH(lsh);
        }

        public V_MAJOR_ACCIDENT Get_V_MAJOR_ACCIDENT_BY_SJH(string sjh)
        {
            return InfoDal.Get_V_MAJOR_ACCIDENT_BY_SJH(sjh);
        }

        public IList<V_MAJOR_ACCIDENT> Get_V_MAJOR_ACCIDENT()
        {
            return InfoDal.Get_V_MAJOR_ACCIDENT();
        }

        public IList<FZ_ACCEPT_INFO> SP_GET_FZ_ACCEPT_PERIOD(string strFZID, string start_TIME, string end_TIME)
        {
            return InfoDal.SP_GET_FZ_ACCEPT_PERIOD(strFZID, start_TIME, end_TIME);
        }
        public IList<FZ_NOTICE> SP_GET_FZ_NOTICE(string strFZID)
        {
            return InfoDal.SP_GET_FZ_NOTICE(strFZID);
        }

        public CCXX SP_GET_APP_CCXX(string lsh, string ccxh)
        {
            return InfoDal.SP_GET_APP_CCXX(lsh, ccxh);
        }
        public bool SP_UPDATE_ACCEPT_APP(receiveAPPSheet info)
        {
            return InfoDal.SP_UPDATE_ACCEPT_APP(info);
        }
        public bool SP_UPDATE_ACCEPT_APP_QUALITY(QualityRespnose info)
        {
            return InfoDal.SP_UPDATE_ACCEPT_APP_QUALITY(info);
        }
        public V_CLXQXX Get_ALL_V_CLXQXX_ById(string clid)
        {
            return InfoDal.Get_ALL_V_CLXQXX_ById(clid);
        }

        public IList<V_CLXQXX> Get_ALL_V_CLXQXX()
        {
            return InfoDal.Get_ALL_V_CLXQXX();
        }

        public string Get_Dispatch_DDFZ(string strLsh)
        {
            try
            {
                return InfoDal.Get_Dispatch_DDFZ(strLsh);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }
        public string Get_CLIDXH(string strLsh, string strTel)
        {
            try
            {
                return InfoDal.Get_CLIDXH(strLsh, strTel);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }
        public string FN_GET_GLLSH(string strNewLsh)
        {
            try
            {
                return InfoDal.FN_GET_GLLSH(strNewLsh);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public string FN_GetFZUUIDByTel(string ptel)
        {
            try
            {
                return InfoDal.FN_GetFZUUIDByTel(ptel);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public IList<AMBUL_OUTD_STAFF> GET_AMBUL_OUTD_STAFF_BY_LSH(string lsh)
        {
            try
            {
                return InfoDal.GET_AMBUL_OUTD_STAFF_BY_LSH(lsh);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public IList<SP_GET_AMBUL_OUTD_INFO> GET_AMBUL_OUTD_INFO_BY_LSH(string lsh)
        {
            try
            {
                return InfoDal.GET_AMBUL_OUTD_INFO_BY_LSH(lsh);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<V_STAFF_ONDUTY> GET_V_STAFF_ONDUTY(string sfsb, string orgid)
        {
            try
            {
                return InfoDal.GET_V_STAFF_ONDUTY(sfsb, orgid);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<SP_GET_AMBUL_OUTD_INFO> GET_AMBUL_OUTD_INFO_ThreeDays()
        {
            try
            {
                return InfoDal.GET_AMBUL_OUTD_INFO_ThreeDays();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_BY_SJH(string sjh)
        {
            try
            {
                return InfoDal.GET_V_ACCEPT_INFO_BY_SJH(sjh);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_BY_ZJHＭ(string zjhm)
        {
            try
            {
                return InfoDal.GET_V_ACCEPT_INFO_BY_ZJHＭ(zjhm);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public VIP_USER_INFO GET_VIP_INFO_BY_DH(string zjhm)
        {
            try
            {
                return InfoDal.GET_VIP_INFO_BY_DH(zjhm);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public WXUserResponse Get_WX(string lsh)
        {
            try
            {
                return InfoDal.Get_WX(lsh);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_ThreeDays()
        {
            try
            {
                return InfoDal.GET_V_ACCEPT_INFO_ThreeDays();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public Ambul_AcceptInfo UpdateAcceptInfo(ACCEPT_INFO info,string clid )
        {
            return InfoDal.UpdateAcceptInfo(info, clid);
        }

        public EventAboutInfo UpdateEventInfo_And_Return_AboutInfo(EVENT_INFO info)
        {
            return InfoDal.UpdateEventInfo_And_Return_AboutInfo(info);
        }

        public LshAboutInfo Get_LshAbuotInfo_ByLsh(string lsh)
        {
            return InfoDal.Get_LshAbuotInfo_ByLsh(lsh);
        }

        public CCXX_CLXQ_INFO GET_CCXX_CLXQ_INFO_BY_LSH_CLID(string lsh, string clid)
        {
            try
            {
                return InfoDal.GET_CCXX_CLXQ_INFO_BY_LSH_CLID(lsh, clid);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        #region 分站
        /// <summary>
        /// 传入分站ID，查看分站所有车辆状态
        /// </summary>
        /// <param name="strFZID">分站id</param>
        /// <returns></returns>
        public IList<FZ_BUS_INFO> SP_GET_FZ_CLZT(string strFZID)
        {
            return InfoDal.SP_GET_FZ_CLZT(strFZID);
        }
        /// <summary>
        /// 传入分站ID，查看3天内分站的调度单接车地址
        /// </summary>
        /// <param name="strFZID">分站id</param>
        /// <returns></returns>
        public IList<FZ_DISPATCH_INFO> SP_GET_FZ_JCDZ(string strFZID)
        {
            return InfoDal.SP_GET_FZ_JCDZ(strFZID);
        }

        /// <summary>
        /// 传入流水号，更新调度信息
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <param name="strDDLX">调度类型</param>
        /// <returns></returns>
        public bool SP_UPDATE_FZ_DISPATCH(string strLSH, string nDDLX, string strQRR)
        {
            return InfoDal.SP_UPDATE_FZ_DISPATCH(strLSH, nDDLX, strQRR);
        }

        /// <summary>
        /// 传入车辆ID，完成车辆等级更新
        /// </summary>
        /// <param name="strCLID">车辆id</param>
        /// <param name="nCLDJ">车辆等级</param>
        /// <returns></returns>
        public bool SP_UPDATE_FZ_CLDJ(string strCLID, string nCLDJ)
        {
            return InfoDal.SP_UPDATE_FZ_CLDJ(strCLID, nCLDJ);
        }


        /// <summary>
        /// 结束多方通话，更新未记录挂机时间的通话记录   
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <param name="dGJSJ">挂机时间</param>
        /// <returns></returns>
        public bool SP_UPDATE_CALL_MULTIPLE_END(string strLSH, string dGJSJ)
        {
            return InfoDal.SP_UPDATE_CALL_MULTIPLE_END(strLSH, dGJSJ);
        }


        /// <summary>
        /// 取消派车
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <param name="strCLID">传入车辆ID</param>
        /// <param name="nQXYY">传入取消派车原因编码</param>
        /// <param name="nQXYY">车辆状态</param>
        /// <param name="nQXYY">取消派车时间</param>
        /// <returns></returns>
        public bool SP_UPDATE_CANCLED(string strLSH, string strCLID, string nQXYY, string nCLZT, string dQXPCSJ)
        {
            return InfoDal.SP_UPDATE_CANCLED(strLSH, strCLID, nQXYY, nCLZT, dQXPCSJ);
        }

        /// <summary>
        /// 改派车辆
        /// </summary>
        /// <param name="strNEWLSH">呼入流水号</param>
        /// <param name="strOLDCLID">取消车辆ID</param>
        /// <param name="strOLDLSH">取消车辆流水号</param>
        /// <param name="nQXYY">取消派车原因</param>
        /// <param name="strNEWCLID">新派车辆ID</param>
        /// <param name="strSZFZ">新派车辆所在分站</param>
        /// <param name="strRPID">受理台id</param>
        /// <param name="strDDYID">调度员id</param>
        /// <returns></returns>
        public List<SP_GET_AMBUL_OUTD_INFO> SP_UPDATE_REASSIGNMENT(string strNEWLSH, string strOLDCLID, string strOLDLSH, string nQXYY, string strNEWCLID, string strSZFZ, string strRPID, string strDDYID, string strCLZT)
        {
            return InfoDal.SP_UPDATE_REASSIGNMENT(strNEWLSH, strOLDCLID, strOLDLSH, nQXYY, strNEWCLID, strSZFZ, strRPID, strDDYID, strCLZT);
        }

        /// <summary>
        /// 插入或更新自出受理记录表
        /// </summary>
        /// <param name="info">受理记录</param>
        /// <returns></returns>
        public bool SP_UPDATE_DIRECT_ACCEPT_INFO_INFO(DIRECT_ACCEPT_INFO info)
        {
            return InfoDal.SP_UPDATE_DIRECT_ACCEPT_INFO_INFO(info);
        }


        /// <summary>
        /// 插入或更新转院受理记录表
        /// </summary>
        /// <param name="info">受理记录</param>
        /// <returns></returns>
        public bool SP_UPDATE_TRANSPORT_ACCEPT(TRANSPORT_ACCEPT info)
        {
            return InfoDal.SP_UPDATE_TRANSPORT_ACCEPT(info);
        }

        /// <summary>
        /// 传入分站ID，查看3天内的受理单信息
        /// </summary>
        /// <param name="strFZID">分站id</param>
        /// <returns></returns>
        public IList<FZ_ACCEPT_INFO> SP_GET_FZ_ACCEPT_INFO(string strFZID)
        {
            return InfoDal.SP_GET_FZ_ACCEPT_INFO(strFZID);
        }

        /// <summary>
        /// 传入流水号，查看出车信息
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <returns></returns>
        public IList<FZ_ACCEPT_INFO> SP_GET_FZ_CCXX(string strLSH)
        {
            return InfoDal.SP_GET_FZ_CCXX(strLSH);
        }

        /// <summary>
        ///  传入车辆ID，完成取消派车的更新
        /// </summary>
        /// <param name="strCLID">车辆ID</param>
        /// <param name="nQXYY">取消派车原因编码</param>
        /// <param name="nGPBZ">改派标志</param>
        /// <returns></returns>
        public bool SP_UPDATE_FZ_CANCLED(string strCLID, string nQXYY, string nGPBZ)
        {
            return InfoDal.SP_UPDATE_FZ_CANCLED(strCLID, nQXYY, nGPBZ);
        }

        /// <summary>
        /// 分站存储出车信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool SP_FZ_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string sjh, string swdd)
        {
            return InfoDal.SP_FZ_INSERT_AMBUL_OUTD(strLSH, strCLID, strSZFZ, nPCLX, dPCSJ, strRPID, strDDYID, sjh, swdd);
        }

        /// <summary>
        /// 存储出车信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Ambul_AcceptInfo SP_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string sjh, string swdd)
        {
            return InfoDal.SP_INSERT_AMBUL_OUTD(strLSH, strCLID, strSZFZ, nPCLX, dPCSJ, strRPID, strDDYID, sjh, swdd);
        }

        /// <summary>
        /// 传入分站ID，查看分站是否有调度权，0是无，1是有
        /// </summary>
        /// <param name="strFZID">分站id</param>
        /// <returns></returns>
        public string SP_GET_FZ_LX(string strFZID)
        {
            return InfoDal.SP_GET_FZ_LX(strFZID);
        }

        public int BatchInsert(List<AMBUL_TRAC> lst)
        {
            return InfoDal.BatchInsert(lst);
        }
        #endregion
        #endregion
    }
}