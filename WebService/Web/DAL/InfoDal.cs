using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using Web.Model;
using System.Linq;

namespace Web
{
    public class InfoDal
    {
        /// <summary>
        /// 获取录音文件地址
        /// </summary>
        /// <param name="callid"></param>
        /// <param name="zjhm"></param>
        /// <param name="bjhm"></param>
        /// <returns></returns>
        public static List<CallFileInfo> GetDirectTelRec(string callid, string zjhm, string bjhm)
        {
            try
            {
                return OracleHelper.ExecuteList_rec<CallFileInfo>("select filename,recserverid  from t_recvocinfo where  callid='" + callid + "'", CommandType.Text, null);
                //object path = OracleHelper.GetSingle("select filename from t_recvocinfo where Callerid ='" + zjhm + "' and calledid ='" + bjhm + "' and callid='" + callid + "'", "1");
            }
            catch (System.Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取黑名单集合
        /// </summary>
        /// <returns></returns>
        public static IList<V_BLACK_LIST> Get_All_V_BLACK_LIST_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_BLACK_LIST>("select * from V_BLACK_LIST", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据车辆ID集合获取车辆列表信息
        /// </summary>
        /// <param name="czdhs"></param>
        /// <returns></returns>
        public static List<CLLB_STATUS> Get_CLLB_INFO_BY_IDS(string czdhs)
        {
            try
            {
                if (string.IsNullOrEmpty(czdhs))
                {
                    return OracleHelper.ExecuteList<CLLB_STATUS>("select CLZT,CLZTSM,CZDH from V_CLLB", CommandType.Text, null);
                }
                else
                {
                    string[] czdh = czdhs.Split('|');
                    StringBuilder sql = new StringBuilder();
                    sql.Append("select CLZT,CLZTSM,CZDH from V_CLLB where CZDH in (");
                    for (int i = 0; i < czdh.Length; i++)
                    {
                        if (i == czdh.Length - 1)
                        {
                            sql.Append(czdh[i] + ")");
                        }
                        else
                        {
                            sql.Append(czdh[i] + ",");
                        }
                    }

                    return OracleHelper.ExecuteList<CLLB_STATUS>(sql.ToString(), CommandType.Text, null);
                }
            }
            catch (System.Exception e)
            {

                throw;
            }

        }

        /// <summary>
        /// 获取所有的字典表信息
        /// </summary>
        /// <returns></returns>
        public static IList<V_Reason> Get_ReasonList()
        {
            try
            {
                return OracleHelper.ExecuteList<V_Reason>("select * from V_SYS_REASONCODE ", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取所有的车辆信息
        /// </summary>
        /// <returns></returns>
        public static IList<V_CLLB> Get_All_CLLB_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_CLLB>("select * from V_CLLB order by clid", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                throw;
            }

        }
        public static IList<V_CODE_HJYY> Get_V_CODE_HJYY()
        {
            try
            {
                return OracleHelper.ExecuteList<V_CODE_HJYY>("select * from V_CODE_HJYY ", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取所有的组织机构信息
        /// </summary>
        /// <returns></returns>
        public static List<SYS_ORG_INFO> Get_All_V_ORG_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<SYS_ORG_INFO>("select * from V_ORG_INFO ", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                throw;
            }

        }

        /// <summary>
        /// 根据车辆ID获取信息
        /// </summary>
        /// <param name="clid"></param>
        /// <returns></returns>
        public static IList<V_CLLB> Get_All_CLLB_INFO_BY_CLID(string clid)
        {
            try
            {
                return OracleHelper.ExecuteList<V_CLLB>("select * from V_CLLB where CLID='" + clid + "'", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取所有的受理计时
        /// </summary>
        /// <returns></returns>
        public static IList<V_SLJS> Get_All_SLJS_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_SLJS>("select * from V_SLJS", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取所有的派车计时
        /// </summary>
        /// <returns></returns>
        public static IList<V_PCJS> Get_All_PCJS_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_PCJS>("select * from V_PCJS", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取所有的待派事件
        /// </summary>
        /// <returns></returns>
        public static IList<V_DPSJ> Get_All_DPSJ_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_DPSJ>("select * from V_DPSJ", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取该事件下的所有信息
        /// </summary>
        /// <param name="sjh"></param>
        /// <returns></returns>
        public static EventAboutInfo Get_All_V_SJLB_INFO_BY_ID(string sjh)
        {
            try
            {
                EventAboutInfo item = new EventAboutInfo();

                item.SjlbInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_ALL_SJLB where SJH='" + sjh + "'  order by SCLDSJ desc", CommandType.Text, null);
                if (item.SjlbInfo != null && !string.IsNullOrEmpty(item.SjlbInfo.SJH))
                {
                    item.Accept_List = OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from V_ALL_ACCEPT_INFO where SJH='" + sjh + "'", CommandType.Text, null);
                    item.Ambul_List = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_ALL_AMBUL_OUTD_INFO  where SJH='" + sjh + "'", CommandType.Text, null);
                    item.Result = true;
                }
                return item;
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取过去24小时内的事件信息
        /// </summary>
        /// <returns></returns>
        public static IList<V_SJLB> Get_All_V_SJLB_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_SJLB>("select * from V_SJLB order by SCLDSJ desc", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取某调度员获取时间段内的呼叫信息
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="ddyid"></param>
        /// <returns></returns>
        public static IList<V_CALLINFO> Get_CALL_INFO_BY_DATE(string starttime, string endtime, string ddyid)
        {
            try
            {
                return OracleHelper.ExecuteList<V_CALLINFO>("select * from V_CALLINFO where lyid is not null  and HJSJ  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
                //return OracleHelper.ExecuteList<V_CALLINFO>("select * from V_CALLINFO where lyid is not null and ddyid=" + ddyid + "  and HJSJ  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// 根据时间段获取出车信息
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <returns></returns>
        public static IList<SP_GET_AMBUL_OUTD_INFO> Get_AMBUL_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_ambul_outd_info where pcsj  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据时间段获取呼叫记录
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="zjhm"></param>
        /// <param name="bjhm"></param>
        /// <returns></returns>
        public static IList<CALL_INFO> Get_CALL_INFO_BY_DATE_OR_Caller(string starttime, string endtime, string zjhm, string bjhm)
        {
            try
            {
                List<CALL_INFO> lst = new List<CALL_INFO>();
                if (!string.IsNullOrEmpty(zjhm))
                {
                    lst = OracleHelper.ExecuteList<CALL_INFO>("select c.*,a.jcdz,a.bz  from CALL_INFO c left join accept_info a on c.lsh=a.lsh where zjhm='" + zjhm + "'", CommandType.Text, null);
                }
                else if (!string.IsNullOrEmpty(bjhm))
                {
                    lst = OracleHelper.ExecuteList<CALL_INFO>("select c.*,a.jcdz,a.bz  from CALL_INFO c left join accept_info a on c.lsh=a.lsh where bjhm='" + bjhm + "'", CommandType.Text, null);
                }
                else if (string.IsNullOrEmpty(zjhm) && string.IsNullOrEmpty(bjhm))
                {
                    lst = OracleHelper.ExecuteList<CALL_INFO>("select c.*,a.jcdz,a.bz  from CALL_INFO c left join accept_info a on c.lsh=a.lsh  where hjsj  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
                }
                return lst;
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取某流水号相关的所有呼叫记录
        /// </summary>
        /// <param name="sjh"></param>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static IList<SP_GET_EVENT_CALL_INFO> Get_CALL_INFO_BY_HCLSH(string sjh, string lsh)
        {
            try
            {
                List<SP_GET_EVENT_CALL_INFO> resulelst = new List<SP_GET_EVENT_CALL_INFO>();
                if (!string.IsNullOrEmpty(sjh))
                {
                    OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                    pram1.Value = (object)sjh ?? DBNull.Value;
                    OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                    pram2.Value = "";
                    pram2.Direction = ParameterDirection.Output;
                    OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                    pram3.Value = 0;
                    pram3.Direction = ParameterDirection.Output;
                    OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                    pram4.Value = "";
                    pram4.Direction = ParameterDirection.Output;
                    OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                    List<SP_GET_EVENT_CALL_INFO> lst1 = OracleHelper.ExecuteList<SP_GET_EVENT_CALL_INFO>("ZIT_RP_ACCEPT_PKG.SP_GET_EVENT_CALL_INFO", CommandType.StoredProcedure, pms);
                    resulelst.AddRange(lst1);
                }
                List<CALL_INFO> lst = OracleHelper.ExecuteList<CALL_INFO>("select * from CALL_INFO  where hclsh='" + lsh + "'", CommandType.Text, null);
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        SP_GET_EVENT_CALL_INFO item = new SP_GET_EVENT_CALL_INFO();
                        item.HJSJ = lst[i].HJSJ.Value;
                        item.HCBZ = lst[i].HCBZ;
                        item.HJFS = "呼出";
                        item.HJLX = "急救";
                        item.LYID = lst[i].LYID;
                        item.ZJHM = lst[i].ZJHM;
                        item.DDY = lst[i].DDYID;
                        item.BJHM = lst[i].BJHM;
                        if (!string.IsNullOrEmpty(lst[i].LYID))
                        {
                            resulelst.Add(item);
                        }
                    }
                }
                return resulelst;
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// 根据时间段获取受理信息
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> Get_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from V_ALL_ACCEPT_INFO where slsj  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据时间段获取事件信息
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <returns></returns>
        public static IList<V_SJLB> Get_All_V_SJLB_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                string sql = "SELECT SJH,  STATUS,    ZTSM,   SCLDSJ,   SCLDHM,  SCSLSJ, SCSLRPID,  RP, SCDDY, DDY,  SJLX,   SJLXSM,  SGLX, SGLXSM,  JCDZ as xcdz,   hcyy,      FLAG,"
          + "CREATE_TIME,"
          + "LAST_MODIFY_TIME,"
          + "XZBM,AmbulSum"
    + "  FROM (SELECT A.SJH,"
                 + " A.STATUS,"
                + "  (SELECT NAME"
                  + "   FROM SYS_CODE S"
                   + " WHERE S.CODE = A.STATUS AND S.TYPEID = 15)"
                   + "  ZTSM,"
                 + " A.SCLDSJ,"
                 + " A.SCLDHM,"
                 + " A.SCSLSJ,"
                 + " A.SCSLRPID,"
                  + "(SELECT F.NAME"
                     + " FROM SYS_RP_INFO F "
                    + "WHERE F.RPID = A.SCSLRPID)"
                  + "   RP,"
                 + " A.SCDDY,"
                 + " (SELECT M.NAME"
                   + "  FROM SYS_MEMBER_INFO M"
                   + " WHERE M.ID = A.SCDDY)"
                   + "  DDY,"
                 + " A.SJLX,"
                  + "(SELECT NAME"
                   + "  FROM SYS_CODE S "
                    + "WHERE S.CODE = A.SJLX AND S.TYPEID = 13)"
                    + " SJLXSM,"
                + "  B.SGLX,"
                 + " (SELECT NAME     FROM SYS_CODE S    WHERE S.CODE = B.SGLX AND S.TYPEID = 14)   SGLXSM,"
                 + " B.JCDZ,"
                 + "  B.Hjyybc hcyy,"
                 + " A.FLAG,"
                 + " A.CREATE_TIME,"
                 + " A.LAST_MODIFY_TIME,"
                  + "A.XZBM, (select count(*) from ambul_outd_info am where am.lsh=B.Lsh) as AmbulSum,"
                + "  ROW_NUMBER () OVER (PARTITION BY A.SJH ORDER BY B.SLSJ) RN "
             + " FROM EVENT_INFO A, ACCEPT_INFO B,ambul_outd_info C"
            + " WHERE A.SJH = B.SJH and B.Lsh=C.Lsh and "
           + "  B.slsj  between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and"
 + " to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')  )   R WHERE R.RN = 1";

                return OracleHelper.ExecuteList<V_SJLB>(sql, CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据ID获取设备信息
        /// </summary>
        /// <param name="clid"></param>
        /// <returns></returns>
        public static IList<SYS_EMT_INFO> GET_SYS_EMT_INFO(string clid)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strCLID", OracleType.VarChar);
                pram1.Value = (object)clid ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<SYS_EMT_INFO>("ZIT_TMG_PKG.SP_GET_EMT_INFO", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取时间段内的受理记录
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> GET_SP_PRES_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from v_all_accept_info where hjsj   between to_date('" + starttime + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + endtime + "','yyyy-mm-dd hh24:mi:ss')", CommandType.Text, null);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据流水号获取受理信息
        /// </summary>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static P_PRES_ACCEPT_INFO GET_SP_PRES_ACCEPT_INFO_BY_LSH(string lsh)
        {
            try
            {
                lsh = lsh.Split(':')[0];
                return OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_all_accept_info where lsh='" + lsh + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据流水号获取受理信息
        /// </summary>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> GET_SP_PRES_ACCEPT_INFO(string lsh)
        {
            try
            {
                lsh = lsh.Split(':')[0];
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from v_all_accept_info where lsh='" + lsh + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取未转单的远盟信息
        /// </summary>
        /// <param name="isgl"></param>
        /// <returns></returns>
        public static IList<ACCEPT_YM> SP_GET_ACCEPT_YM_INFO(string isgl)
        {
            try
            {
                if (isgl == "0")
                {
                    return OracleHelper.ExecuteList<ACCEPT_YM>("select * from ACCEPT_YM  where lsh is null", CommandType.Text, null);
                }
                else
                {
                    return OracleHelper.ExecuteList<ACCEPT_YM>("select * from ACCEPT_YM", CommandType.Text, null);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据事件号获取出车信息
        /// </summary>
        /// <param name="sjh"></param>
        /// <returns></returns>
        public static IList<SP_GET_AMBUL_OUTD_INFO> SP_GET_AMBUL_OUTD_INFO(string sjh)
        {
            try
            {
                return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_all_AMBUL_OUTD_INFO  where SJH='" + sjh + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据流水号获取随车人员
        /// </summary>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static IList<AMBUL_OUTD_STAFF> GET_AMBUL_OUTD_STAFF_BY_LSH(string lsh)
        {
            try
            {
                return OracleHelper.ExecuteList<AMBUL_OUTD_STAFF>("select * from AMBUL_OUTD_STAFF  where LSH='" + lsh + "' and flag=0", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<AMBUL_OUTD_STAFF>();
            }
        }

        /// <summary>
        /// 根据流水号获取出车信息
        /// </summary>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static IList<SP_GET_AMBUL_OUTD_INFO> GET_AMBUL_OUTD_INFO_BY_LSH(string lsh)
        {
            try
            {
                lsh = lsh.Split(':')[0];
                return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_all_AMBUL_OUTD_INFO  where LSH='" + lsh + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_AMBUL_OUTD_INFO>();
            }
        }

        /// <summary>
        /// 获取上班人员
        /// </summary>
        /// <param name="sfsb"></param>
        /// <param name="orgid"></param>
        /// <returns></returns>
        public static IList<V_STAFF_ONDUTY> GET_V_STAFF_ONDUTY(string sfsb, string orgid)
        {
            try
            {
                if (string.IsNullOrEmpty(orgid) && string.IsNullOrEmpty(sfsb))
                {
                    return OracleHelper.ExecuteList<V_STAFF_ONDUTY>("select * from V_STAFF_ONDUTY", CommandType.Text, null);
                }
                if (string.IsNullOrEmpty(orgid))
                {
                    return OracleHelper.ExecuteList<V_STAFF_ONDUTY>("select * from V_STAFF_ONDUTY where SFSB=" + sfsb, CommandType.Text, null);
                }
                else
                {
                    return OracleHelper.ExecuteList<V_STAFF_ONDUTY>("select * from V_STAFF_ONDUTY where SFSB=" + sfsb + " and org_id='" + orgid + "'", CommandType.Text, null);
                }
            }
            catch (System.Exception)
            {
                return new List<V_STAFF_ONDUTY>();
            }
        }

        /// <summary>
        /// 获取过去24小时出车信息
        /// </summary>
        /// <returns></returns>
        public static IList<SP_GET_AMBUL_OUTD_INFO> GET_AMBUL_OUTD_INFO_ThreeDays()
        {
            try
            {
                return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_AMBUL_OUTD_INFO", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_AMBUL_OUTD_INFO>();
            }
        }

        /// <summary>
        /// 根据事件号获取受理信息
        /// </summary>
        /// <param name="sjh"></param>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_BY_SJH(string sjh)
        {
            try
            {
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from V_ALL_ACCEPT_INFO where sjh='" + sjh + "' ", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<P_PRES_ACCEPT_INFO>();
            }
        }

        /// <summary>
        /// 根据电话获取是否是VIP
        /// </summary>
        /// <param name="zjhm"></param>
        /// <returns></returns>
        public static VIP_USER_INFO GET_VIP_INFO_BY_DH(string zjhm)
        {
            try
            {
                return OracleHelper.ExecuteEntity<VIP_USER_INFO>("select id,mc,lx,jb,dh,lxr,lxdh,dz from VIP_USER_INFO  where DH='" + zjhm + "' and lx=40", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new VIP_USER_INFO();
            }
        }

        /// <summary>
        /// 根据主叫号码获取最近的一次呼叫记录
        /// </summary>
        /// <param name="zjhm"></param>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_BY_ZJHＭ(string zjhm)
        {
            try
            {
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select a.* from call_info c, V_ALL_ACCEPT_INFO a where c.zjhm='" + zjhm + "' and c.lsh=a.lsh order by a.HJSJ desc", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<P_PRES_ACCEPT_INFO>();
            }
        }

        /// <summary>
        /// 获取微信呼叫信息
        /// </summary>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static WXUserResponse Get_WX(string lsh)
        {
            try
            {
                return OracleHelper.ExecuteEntity<WXUserResponse>("select * from accept_weixin where LSH='" + lsh + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new WXUserResponse();
            }
        }

        /// <summary>
        /// 获取过去24小时的受理信息
        /// </summary>
        /// <returns></returns>
        public static IList<P_PRES_ACCEPT_INFO> GET_V_ACCEPT_INFO_ThreeDays()
        {
            try
            {
                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from V_ACCEPT_INFO", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                return new List<P_PRES_ACCEPT_INFO>();
            }
        }

        /// <summary>
        /// 获取该分站是否有调度权
        /// </summary>
        /// <param name="strFZID"></param>
        /// <returns></returns>
        public static string SP_GET_FZ_YWDDQ(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = (object)strFZID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };
                string result = "";
                //List<RESULT_INFO2> list = OracleHelper.ExecuteList<RESULT_INFO2>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_YWDDQ", CommandType.StoredProcedure, pms);
                List<RESULT_INFO2> list = OracleHelper.ExecuteList<RESULT_INFO2>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_YWDDQ", CommandType.StoredProcedure, pms);
                if (list != null && list.Count > 0)
                {
                    result = list[0].YWDDQ.ToString();
                }
                return result;
            }
            catch (System.Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 查询分站某时间段内的受理信息
        /// </summary>
        /// <param name="strFZID"></param>
        /// <param name="start_TIME"></param>
        /// <param name="end_TIME"></param>
        /// <returns></returns>
        public static IList<FZ_ACCEPT_INFO> SP_GET_FZ_ACCEPT_PERIOD(string strFZID, string start_TIME, string end_TIME)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = (object)strFZID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("start_TIME", OracleType.DateTime);
                pram2.Value = (object)start_TIME ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("end_TIME", OracleType.DateTime);
                pram3.Value = (object)end_TIME ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("RESULT", OracleType.Cursor);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("nFLAG", OracleType.Number);
                pram5.Value = 0;
                pram5.Direction = ParameterDirection.Output;
                OracleParameter pram6 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram6.Value = "";
                pram6.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[6] { pram1, pram2, pram3, pram4, pram5, pram6 };

                return OracleHelper.ExecuteList<FZ_ACCEPT_INFO>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_ACCEPT_PERIOD", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<FZ_ACCEPT_INFO>();
            }
        }

        /// <summary>
        /// 查询某分站的通知
        /// </summary>
        /// <param name="strFZID"></param>
        /// <returns></returns>
        public static IList<FZ_NOTICE> SP_GET_FZ_NOTICE(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = (object)strFZID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<FZ_NOTICE>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_NOTICE", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<FZ_NOTICE>();
            }
        }

        /// <summary>
        /// 获取该事件的录音信息
        /// </summary>
        /// <param name="sjh"></param>
        /// <returns></returns>
        public static IList<SP_GET_EVENT_CALL_INFO> SP_GET_EVENT_CALL_INFO(string sjh)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)sjh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<SP_GET_EVENT_CALL_INFO>("ZIT_RP_ACCEPT_PKG.SP_GET_EVENT_CALL_INFO", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_EVENT_CALL_INFO>();
            }
        }

        /// <summary>
        /// 获取远盟的返回信息
        /// </summary>
        /// <param name="lsh"></param>
        /// <param name="czdh"></param>
        /// <returns></returns>
        public static IList<SP_GET_YM_CALLRETURN> SP_GET_YM_CALLRETURN(string lsh, string czdh)
        {
            try
            {
                if (!string.IsNullOrEmpty(lsh))
                {
                    lsh = lsh.Split(':')[0];
                }

                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)lsh ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strCZDH", OracleType.VarChar);
                pram5.Value = (object)czdh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("result", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[5] { pram1, pram5, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<SP_GET_YM_CALLRETURN>("ZIT_RP_ACCEPT_PKG.SP_GET_YM_CALLRETURN", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_YM_CALLRETURN>();
            }
        }

        public static IList<SP_GET_YM_RETURN> SP_GET_YM_RETURN(string lsh, string czdh, string orderid)
        {
            try
            {
                if (!string.IsNullOrEmpty(lsh))
                {
                    lsh = lsh.Split(':')[0];
                }
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)lsh ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strCZDH", OracleType.VarChar);
                pram5.Value = (object)czdh ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strORDERID", OracleType.VarChar);
                pram6.Value = (object)orderid ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("result", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[6] { pram1, pram5, pram6, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<SP_GET_YM_RETURN>("ZIT_RP_ACCEPT_PKG.SP_GET_YM_RETURN", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_YM_RETURN>();
            }
        }

        public static IList<SP_GET_OBLIGATE_ACCEPT_INFO> SP_GET_OBLIGATE_ACCEPT_INFO(string nZJHM)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strZJHM", OracleType.VarChar);
                pram1.Value = (object)nZJHM ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("result", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<SP_GET_OBLIGATE_ACCEPT_INFO>("ZIT_RP_ACCEPT_PKG.SP_GET_OBLIGATE_ACCEPT_INFO", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {
                return new List<SP_GET_OBLIGATE_ACCEPT_INFO>();
            }
        }

        public static IList<V_CALLID_CACHE> SP_GET_V_CALLID_CACHE()
        {
            try
            {
                return OracleHelper.ExecuteList<V_CALLID_CACHE>("select * from V_CALLID_CACHE ", CommandType.Text, null);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public static YGZAmbulInfo GET_YGZAmbulInfoBYLSH(string lsh, string ccxh)
        {
            try
            {
                string sql = " select * from  (select A.lsh,A.CCXH,A.clid,A.SZFZ FZID,(SELECT NAME FROM SYS_AMBUL_INFO AM  WHERE AM.CLID = A.CLID) CLMC,"
 + " (SELECT HM  FROM SYS_EMT_INFO M WHERE M.SZCL = B.CLID AND M.TYPE = 10) CZDH, A.Scsj,C.Jcdz,C.Hjyybc,A.swdd, "
 + "  ZIT_RP_COMMON_PKG.GET_SYS_CODE_NAME (C.HZXB, 28) HZXB, ZIT_RP_COMMON_PKG.GET_SYS_CODE_NAME (C.NL, 29) NL,"
                    + "ZIT_RP_COMMON_PKG.GET_OUTD_STAFF_PHONE(A.LSH,A.CCXH,40) YS,"
                     + " ZIT_RP_COMMON_PKG.GET_OUTD_STAFF_PHONE(A.LSH,A.CCXH,30) SJ,"
                      + "ZIT_RP_COMMON_PKG.GET_OUTD_STAFF_PHONE(A.LSH,A.CCXH,50) HS,"
                      + "C.LXR,C.LXDH,"
+ " C.Hzxm from"
+ " ambul_outd_info "
+ "A join ambul_status_info B on A.Clid=B.Clid join accept_info C on A.Lsh=C.lsh) where lsh='" + lsh + "' and CCXH = " + ccxh;
                return OracleHelper.ExecuteEntity<YGZAmbulInfo>(sql, CommandType.Text, null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<YGZAmbulInfo> GET_YGZAmbulInfo(string hospitalid, string hospitalname)
        {
            try
            {
                string sql = " select * from  (select A.lsh,A.clid,(SELECT NAME FROM SYS_AMBUL_INFO AM  WHERE AM.CLID = A.CLID) CLMC,"
 + " (SELECT HM  FROM SYS_EMT_INFO M WHERE M.SZCL = B.CLID AND M.TYPE = 10) CZDH, A.Scsj,C.Jcdz,C.Hjyybc,A.swdd, "
 + "  ZIT_RP_COMMON_PKG.GET_SYS_CODE_NAME (C.HZXB, 28) HZXB, ZIT_RP_COMMON_PKG.GET_SYS_CODE_NAME (C.NL, 29) NL,"
+ " C.Hzxm from"
+ "(select * from ambul_outd_info where scsj in (select max(scsj) scsj from ambul_outd_info  where swdd='" + hospitalid + "'"
+ "  or swdd='" + hospitalname + "' group by swdd)"
 + ")"
+ "A join ambul_status_info B on A.Clid=B.Clid and B.Status=31  join accept_info C on A.Lsh=C.lsh)";
                IList<YGZAmbulInfo> lst = OracleHelper.ExecuteList<YGZAmbulInfo>(sql, CommandType.Text, null);
                if (lst == null || lst.Count <= 0)
                {
                    return new List<YGZAmbulInfo>();
                }
                else
                {
                    return lst.Distinct(p => p.CLID).ToList();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<V_NOTICE_INFO> SP_GET_V_NOTICE_INFO(string publiser)
        {
            try
            {
                if (string.IsNullOrEmpty(publiser))
                {
                    return OracleHelper.ExecuteList<V_NOTICE_INFO>("select * from V_NOTICE_INFO ", CommandType.Text, null);
                }
                else
                {
                    return OracleHelper.ExecuteList<V_NOTICE_INFO>("select * from V_NOTICE_INFO where  PUBLISHER='" + publiser + "'", CommandType.Text, null);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 更新考勤信息
        /// </summary>
        /// <param name="lx"></param>
        /// <param name="lsh"></param>
        /// <param name="ccxh"></param>
        /// <param name="oldid"></param>
        /// <param name="newid"></param>
        /// <returns></returns>
        public static bool Update_Staff(string lx, string lsh, string ccxh, string oldid, string newid)
        {
            if (string.IsNullOrEmpty(oldid))
            {
                int rows = OracleHelper.ExecuteNonQuery("  INSERT INTO ambul_outd_staff (LSH,CCXH,ID, LX,FLAG,CREATE_TIME,LAST_MODIFY_TIME,XZBM) VALUES ('" + lsh + "'," + ccxh + ",'" + newid + "'," + lx + "," + 0 + ",to_date('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss'),to_date('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss'),0)", CommandType.Text, null);
                return (rows == 1) ? true : false;
            }
            else
            {
                int rows = OracleHelper.ExecuteNonQuery("update ambul_outd_staff set ID='" + newid + "' where lsh='" + lsh + "' and ccxh=" + ccxh + " and lx=" + lx + "  and ID='" + oldid + "'", CommandType.Text, null);
                return (rows == 1) ? true : false;
            }
        }

        /// <summary>
        /// 关联呼叫记录
        /// </summary>
        /// <param name="newlsh"></param>
        /// <param name="oldlsh"></param>
        /// <returns></returns>
        public static bool Update_CallInfo_Hclsh(string newlsh, string oldlsh)
        {
            if (oldlsh == "100")
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, newlsh.ToString(), new LogUtility.RunningPlace("", "Update_CallInfo_Hclsh"), "sss");
                int rows = 0;
                if (newlsh.Split(':').Length == 3)
                {
                    if (newlsh.Split(':')[2] == "呼入")
                    {

                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "update call_info set gllsh=(select A.lsh from accept_info A where A.Sjh='" + newlsh.Split(':')[1] + "')where lsh='" + newlsh.Split(':')[0] + "')", new LogUtility.RunningPlace("", "Update_CallInfo_Hclsh"), "sss");
                        rows = OracleHelper.ExecuteNonQuery("update call_info set gllsh=(select A.lsh from accept_info A where A.Sjh='" + newlsh.Split(':')[1] + "') where lsh='" + newlsh.Split(':')[0] + "'", CommandType.Text, null);
                    }
                    else
                    {
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "update call_info set hclsh=(select A.lsh from accept_info A where A.Sjh='" + newlsh.Split(':')[1] + "')where lsh='" + newlsh.Split(':')[0] + "')", new LogUtility.RunningPlace("", "Update_CallInfo_Hclsh"), "sss");

                        rows = OracleHelper.ExecuteNonQuery("update call_info set hclsh=(select A.lsh from accept_info A where A.Sjh='" + newlsh.Split(':')[1] + "') where lsh='" + newlsh.Split(':')[0] + "'", CommandType.Text, null);
                    }
                }
                //rows = OracleHelper.ExecuteNonQuery("update call_info set hclsh='" + newlsh.Split(':')[0] + "' where lsh=(select A.lsh from accept_info A where A.Sjh='" + newlsh.Split(':')[0] + "'", CommandType.Text, null);
                return (rows == 1) ? true : false;
            }
            else
            {
                int rows = OracleHelper.ExecuteNonQuery("update call_info set hclsh='" + oldlsh + "' where lsh='" + newlsh + "'", CommandType.Text, null);
                return (rows == 1) ? true : false;
            }
        }

        /// <summary>
        /// 更新呼叫记录
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static bool SP_UPDATE_CALL_INFO(CALL_INFO ext)
        {
            try
            {
                ext.LSH = ext.LSH.Split(':')[0];
                OracleParameter[] ops = new OracleParameter[24];
                ops[0] = new OracleParameter("strlsh", (object)ext.LSH ?? DBNull.Value);
                ops[1] = new OracleParameter("nhjlx", (object)ext.HJLX ?? DBNull.Value);
                ops[2] = new OracleParameter("strgllsh", (object)ext.GLLSH ?? DBNull.Value);
                ops[3] = new OracleParameter("nhcbz", (object)ext.HCBZ ?? DBNull.Value);
                ops[4] = new OracleParameter("nhjly", (object)ext.HJLY ?? DBNull.Value);
                ops[5] = new OracleParameter("dhjsj", ((object)ext.HJSJ) ?? DBNull.Value);
                ops[6] = new OracleParameter("strhzm", (object)ext.HZM ?? DBNull.Value);
                ops[7] = new OracleParameter("strzjdz", (object)ext.ZJDZ ?? DBNull.Value);
                ops[8] = new OracleParameter("strzjhm", (object)ext.ZJHM ?? DBNull.Value);

                ops[9] = new OracleParameter("strbjhm", (object)ext.BJHM ?? DBNull.Value);
                ops[10] = new OracleParameter("nsfjt", (object)ext.SFJT ?? DBNull.Value);
                ops[11] = new OracleParameter("nsfhb", (object)ext.SFHB ?? DBNull.Value);
                ops[12] = new OracleParameter("strrpid", (object)ext.RPID ?? DBNull.Value);

                ops[13] = new OracleParameter("strddyid", (object)ext.DDYID ?? DBNull.Value);
                ops[14] = new OracleParameter("dzjsj", (object)ext.ZJSJ ?? DBNull.Value);
                ops[15] = new OracleParameter("dgjsj", (object)ext.GJSJ ?? DBNull.Value);
                ops[16] = new OracleParameter("strlyid", (object)ext.LYID ?? DBNull.Value);

                ops[17] = new OracleParameter("ngps_x", (object)ext.GPS_X ?? DBNull.Value);
                ops[18] = new OracleParameter("ngps_y", (object)ext.GPS_Y ?? DBNull.Value);
                ops[19] = new OracleParameter("nxzbm", (object)ext.XZBM ?? DBNull.Value);
                ops[20] = new OracleParameter("dZLSJ", (object)ext.ZLSJ ?? DBNull.Value);
                ops[21] = new OracleParameter("strCALLID", (object)ext.CALLID ?? DBNull.Value);

                ops[1].DbType = DbType.VarNumeric;
                ops[3].DbType = DbType.VarNumeric;
                ops[4].DbType = DbType.VarNumeric;
                ops[5].DbType = DbType.DateTime;

                ops[10].DbType = DbType.VarNumeric;
                ops[11].DbType = DbType.VarNumeric;
                ops[14].DbType = DbType.DateTime;
                ops[15].DbType = DbType.DateTime;

                ops[17].DbType = DbType.VarNumeric;
                ops[18].DbType = DbType.VarNumeric;
                ops[19].DbType = DbType.VarNumeric;
                ops[20].DbType = DbType.DateTime;


                ops[22] = new OracleParameter("nflag", OracleType.Number);
                ops[23] = new OracleParameter("errmsg", OracleType.VarChar, 4000);

                ops[22].Direction = ParameterDirection.Output;
                ops[23].Direction = ParameterDirection.Output;

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CALL_INFO", CommandType.StoredProcedure, ops);
                if (ops[21].ToString() == "呼叫时间无效")
                {
                    LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, ext.HJSJ.ToString(), new LogUtility.RunningPlace("", ""), "呼叫时间无效");
                }
                return (rows == 1) ? true : false;
            }
            catch (System.Exception e)
            {
                LogUtility.DataLog.WriteError(e);
                return false;
            }
        }

        /// <summary>
        /// 更新重大事故
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool SP_UPDATE_MAJOR_ACCIDENT(SP_UPDATE_MAJOR_ACCIDENT info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nSGLXFL", OracleType.Number);
                pram2.Value = (object)info.SGLXFL ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nSJLX", OracleType.Number);
                pram3.Value = (object)info.SJLX ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nSJDJ", OracleType.Number);
                pram4.Value = (object)info.SJDJ ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strSJMC", OracleType.VarChar);
                pram5.Value = (object)info.SJMC ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram6.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strRPID", OracleType.VarChar);
                pram7.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nSSRS", OracleType.Number);
                pram8.Value = (object)info.SSRS ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nSWRS", OracleType.Number);
                pram9.Value = (object)info.SWRS ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nSZRS", OracleType.Number);
                pram10.Value = (object)info.SZRS ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("strSQCBFX", OracleType.VarChar);
                pram11.Value = (object)info.SQCBFX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strSBBM1", OracleType.VarChar);
                pram12.Value = (object)info.SBBM1 ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strFSHM1", OracleType.VarChar);
                pram13.Value = (object)info.FSHM1 ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("dSBSJ1", OracleType.DateTime);
                pram14.Value = (object)info.SBSJ1 ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strSBBM2", OracleType.VarChar);
                pram15.Value = (object)info.SBBM2 ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strFSHM2", OracleType.VarChar);
                pram16.Value = (object)info.FSHM2 ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("dSBSJ2", OracleType.DateTime);
                pram17.Value = (object)info.SBSJ2 ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("strSBBM3", OracleType.VarChar);
                pram18.Value = (object)info.SBBM3 ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strFSHM3", OracleType.VarChar);
                pram19.Value = (object)info.FSHM3 ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("dSBSJ3", OracleType.DateTime);
                pram20.Value = (object)info.SBSJ3 ?? DBNull.Value;

                OracleParameter pram21 = new OracleParameter("nFLAG", OracleType.Number);
                pram21.Value = 0;
                pram21.Direction = ParameterDirection.Output;
                OracleParameter pram22 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram22.Value = "";
                pram22.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[22] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram22};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_MAJOR_ACCIDENT", CommandType.StoredProcedure, pms);
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, JosnHelper.SerializeObject<SP_UPDATE_MAJOR_ACCIDENT>(info), new LogUtility.RunningPlace("", ""), "上报重大事故");
                if (rows == 1)
                {
                    OracleHelper.ExecuteNonQuery("update accept_info set sglx=20 where sjh='" + info.SJH + "'", CommandType.Text, null);
                }
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 更新受理信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static P_PRES_ACCEPT_INFO SP_UPDATE_ACCEPT_INFO(ACCEPT_INFO info)
        {
            try
            {
                //if (!string.IsNullOrEmpty(info.CZLY))
                //{
                //    string[] lys = info.CZLY.Split(':');
                //    if (lys.Length == 2 && lys[0] == "Event_Dis")
                //    {
                //        OracleHelper.ExecuteNonQuery("update ambul_outd_info set swdd='" + info.SWDD + "' where lsh='" + info.LSH + "' and clid='" + lys[1] + "'", CommandType.Text, null);
                //    }
                //}
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strRPID", OracleType.VarChar);
                pram2.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram3.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSJH", OracleType.VarChar);
                pram4.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nSLZT", OracleType.Number);
                pram6.Value = (object)info.SLZT ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nSLLY", OracleType.Number);
                pram7.Value = (object)info.SLLY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nSLLX", OracleType.Number);
                pram8.Value = (object)info.SLLX ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nHJZ", OracleType.Number);
                pram9.Value = (object)info.HJZ ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nHJZLX", OracleType.Number);
                pram10.Value = (object)info.HJZLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGLX", OracleType.Number);
                pram11.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nHJYYKB", OracleType.Number);
                pram12.Value = (object)info.HJYYKB ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("nHJYYZS", OracleType.Number);
                pram13.Value = (object)info.HJYYZS ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nHJYYZZ", OracleType.Number);
                pram14.Value = (object)info.HJYYZZ ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strHJYYBC", OracleType.VarChar);
                pram15.Value = (object)info.HJYYBC ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram16.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strJCDZ", OracleType.VarChar);
                pram17.Value = (object)info.JCDZ ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("nHJQY", OracleType.Number);
                pram18.Value = (object)info.HJQY ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strGXYY", OracleType.VarChar);
                pram19.Value = (object)info.GXYY ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strLXR", OracleType.VarChar);
                pram20.Value = (object)info.LXR ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("strLXDH", OracleType.VarChar);
                pram21.Value = (object)info.LXDH ?? DBNull.Value;
                OracleParameter pram38 = new OracleParameter("nHZRS", OracleType.Number);
                pram38.Value = (object)info.HZRS ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("strSWYY", OracleType.VarChar);
                pram22.Value = (object)info.SWYY ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("strSWDD", OracleType.VarChar);
                pram23.Value = (object)info.SWDD ?? DBNull.Value;
                OracleParameter pram24 = new OracleParameter("strHZXM", OracleType.VarChar);
                pram24.Value = (object)info.HZXM ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("nHZXB", OracleType.Number);
                pram25.Value = (object)info.HZXB ?? DBNull.Value;
                OracleParameter pram26 = new OracleParameter("nNL", OracleType.Number);
                pram26.Value = (object)info.NL ?? DBNull.Value;
                OracleParameter pram27 = new OracleParameter("nMZ", OracleType.Number);
                pram27.Value = (object)info.MZ ?? DBNull.Value;
                OracleParameter pram28 = new OracleParameter("nGJ", OracleType.Number);
                pram28.Value = (object)info.GJ ?? DBNull.Value;
                OracleParameter pram29 = new OracleParameter("nSQCD", OracleType.Number);
                pram29.Value = (object)info.SQCD ?? DBNull.Value;
                OracleParameter pram30 = new OracleParameter("nTSYQ", OracleType.Number);
                pram30.Value = (object)info.TSYQ ?? DBNull.Value;
                OracleParameter pram31 = new OracleParameter("nTQ", OracleType.Number);
                pram31.Value = (object)info.TQ ?? DBNull.Value;
                OracleParameter pram32 = new OracleParameter("nLK", OracleType.Number);
                pram32.Value = (object)info.LK ?? DBNull.Value;
                OracleParameter pram33 = new OracleParameter("strBZ", OracleType.VarChar);
                pram33.Value = (object)info.BZ ?? DBNull.Value;
                OracleParameter pram34 = new OracleParameter("nSFCS", OracleType.Number);
                pram34.Value = (object)info.SFCS ?? DBNull.Value;
                OracleParameter pram35 = new OracleParameter("nXZBM", OracleType.Number);
                pram35.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram45 = new OracleParameter("nZZLX", OracleType.Number);
                pram45.Value = (object)info.ZZLX ?? DBNull.Value;
                OracleParameter pram36 = new OracleParameter("nIS_CKOUT", OracleType.Number);
                pram36.Value = (object)info.IS_CKOUT ?? DBNull.Value;
                OracleParameter pram37 = new OracleParameter("strSZKS", OracleType.VarChar);
                pram37.Value = (object)info.SZKS ?? DBNull.Value;
                OracleParameter pram39 = new OracleParameter("strMQZD", OracleType.VarChar);
                pram39.Value = (object)info.MQZD ?? DBNull.Value;
                OracleParameter pram40 = new OracleParameter("strYBHGX", OracleType.VarChar);
                pram40.Value = (object)info.YBHGX ?? DBNull.Value;
                OracleParameter pram41 = new OracleParameter("strGCDF", OracleType.VarChar);
                pram41.Value = (object)info.GCDF ?? DBNull.Value;
                OracleParameter pram42 = new OracleParameter("strGCDFYJ", OracleType.VarChar);
                pram42.Value = (object)info.GCDFYJ ?? DBNull.Value;
                OracleParameter pram46 = new OracleParameter("strTSYQ", OracleType.VarChar);
                pram46.Value = (object)info.TSYQSM ?? DBNull.Value;
                OracleParameter pram43 = new OracleParameter("nFLAG", OracleType.Number);
                pram43.Value = 0;
                pram43.Direction = ParameterDirection.Output;
                OracleParameter pram44 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram44.Value = "";
                pram44.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[46] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram38,pram22
                , pram23, pram24, pram25, pram26, pram27, pram28, pram29, pram30, pram31
                , pram32, pram33, pram34, pram35, pram45, pram36, pram37, pram39, pram40, pram41, pram42, pram46, pram43, pram44};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_ACCEPT_INFO", CommandType.StoredProcedure, pms);
                P_PRES_ACCEPT_INFO item = new P_PRES_ACCEPT_INFO();
                if (rows == 1)
                {
                    if (info.HZRS >= 3)
                    {
                        OracleHelper.ExecuteNonQuery("update accept_info set sglx=20 where lsh='" + info.LSH + "'", CommandType.Text, null);
                    }
                }
                return item;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_WXUserResponse(WXUserResponse info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strXZBM", OracleType.VarChar);
                pram2.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strPHONE", OracleType.VarChar);
                pram3.Value = (object)info.Phone ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strWXSJLB", OracleType.VarChar);
                pram4.Value = (object)info.wxsjlb ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strGPS_X", OracleType.VarChar);
                pram5.Value = (object)info.longitude ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strGPS_Y", OracleType.VarChar);
                pram6.Value = (object)info.latitude ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strDZ", OracleType.VarChar);
                pram7.Value = (object)info.chineseLocation ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strNAME", OracleType.VarChar);
                pram8.Value = (object)info.name ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("strSEX", OracleType.VarChar);
                pram9.Value = (object)info.sex ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strID_NO", OracleType.VarChar);
                pram10.Value = (object)info.idcardNum ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("strAGE", OracleType.VarChar);
                pram11.Value = (object)info.age ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strADDRESS", OracleType.VarChar);
                pram12.Value = (object)info.address ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strNAME1", OracleType.VarChar);
                pram13.Value = (object)info.name1 ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("strMOBILE1", OracleType.VarChar);
                pram14.Value = (object)info.mobile1 ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strNAME2", OracleType.VarChar);
                pram15.Value = (object)info.name2 ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strMOBILE2", OracleType.VarChar);
                pram16.Value = (object)info.mobile2 ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strHEIGHT", OracleType.VarChar);
                pram17.Value = (object)info.height ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("strWEIGHT", OracleType.VarChar);
                pram18.Value = (object)info.weight ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strBLOODTYPE", OracleType.VarChar);
                pram19.Value = (object)info.bloodtype ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strDRUGS", OracleType.VarChar);
                pram20.Value = (object)info.drugs ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("strMEDICALHISTORY", OracleType.VarChar);
                pram21.Value = (object)info.medicalHistory ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("strALLERGIES", OracleType.VarChar);
                pram22.Value = (object)info.allergies ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("strREMARK", OracleType.VarChar);
                pram23.Value = (object)info.remark ?? DBNull.Value;

                OracleParameter pram24 = new OracleParameter("nFLAG", OracleType.Number);
                pram24.Value = 0;
                pram24.Direction = ParameterDirection.Output;
                OracleParameter pram25 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram25.Value = "";
                pram25.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[25] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21,pram22
                , pram23, pram24, pram25};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_ACCEPT_WEIXIN", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_DIRECT_ACCEPT_INFO_INFO(DIRECT_ACCEPT_INFO info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strRPID", OracleType.VarChar);
                pram2.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram3.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSJH", OracleType.VarChar);
                pram4.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nSLZT", OracleType.Number);
                pram6.Value = (object)info.SLZT ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nSLLY", OracleType.Number);
                pram7.Value = (object)info.SLLY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nSLLX", OracleType.Number);
                pram8.Value = (object)info.SLLX ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nHJZ", OracleType.Number);
                pram9.Value = (object)info.HJZ ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nHJZLX", OracleType.Number);
                pram10.Value = (object)info.HJZLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGLX", OracleType.Number);
                pram11.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nHJYYKB", OracleType.Number);
                pram12.Value = (object)info.HJYYKB ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("nHJYYZS", OracleType.Number);
                pram13.Value = (object)info.HJYYZS ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nHJYYZZ", OracleType.Number);
                pram14.Value = (object)info.HJYYZZ ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strHJYYBC", OracleType.VarChar);
                pram15.Value = (object)info.HJYYBC ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram16.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strJCDZ", OracleType.VarChar);
                pram17.Value = (object)info.JCDZ ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("nHJQY", OracleType.Number);
                pram18.Value = (object)info.HJQY ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strGXYY", OracleType.VarChar);
                pram19.Value = (object)info.GXYY ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strLXR", OracleType.VarChar);
                pram20.Value = (object)info.LXR ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("strLXDH", OracleType.VarChar);
                pram21.Value = (object)info.LXDH ?? DBNull.Value;
                OracleParameter pram38 = new OracleParameter("nHZRS", OracleType.Number);
                pram38.Value = (object)info.HZRS ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("strSWYY", OracleType.VarChar);
                pram22.Value = (object)info.SWYY ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("strSWDD", OracleType.VarChar);
                pram23.Value = (object)info.SWDD ?? DBNull.Value;
                OracleParameter pram24 = new OracleParameter("strHZXM", OracleType.VarChar);
                pram24.Value = (object)info.HZXM ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("nHZXB", OracleType.Number);
                pram25.Value = (object)info.HZXB ?? DBNull.Value;
                OracleParameter pram26 = new OracleParameter("nNL", OracleType.Number);
                pram26.Value = (object)info.NL ?? DBNull.Value;
                OracleParameter pram27 = new OracleParameter("nMZ", OracleType.Number);
                pram27.Value = (object)info.MZ ?? DBNull.Value;
                OracleParameter pram28 = new OracleParameter("nGJ", OracleType.Number);
                pram28.Value = (object)info.GJ ?? DBNull.Value;
                OracleParameter pram29 = new OracleParameter("nSQCD", OracleType.Number);
                pram29.Value = (object)info.SQCD ?? DBNull.Value;
                OracleParameter pram30 = new OracleParameter("nTSYQ", OracleType.Number);
                pram30.Value = (object)info.TSYQ ?? DBNull.Value;
                OracleParameter pram31 = new OracleParameter("nTQ", OracleType.Number);
                pram31.Value = (object)info.TQ ?? DBNull.Value;
                OracleParameter pram32 = new OracleParameter("nLK", OracleType.Number);
                pram32.Value = (object)info.LK ?? DBNull.Value;
                OracleParameter pram33 = new OracleParameter("strBZ", OracleType.VarChar);
                pram33.Value = (object)info.BZ ?? DBNull.Value;
                OracleParameter pram34 = new OracleParameter("nSFCS", OracleType.Number);
                pram34.Value = (object)info.SFCS ?? DBNull.Value;
                OracleParameter pram35 = new OracleParameter("nXZBM", OracleType.Number);
                pram35.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram36 = new OracleParameter("nFLAG", OracleType.Number);
                pram36.Value = 0;
                pram36.Direction = ParameterDirection.Output;
                OracleParameter pram37 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram37.Value = "";
                pram37.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[38] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram38,pram22
                , pram23, pram24, pram25, pram26, pram27, pram28, pram29, pram30, pram31
                , pram32, pram33, pram34, pram35, pram36, pram37};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_DIRECT_ACCEPT", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_COMPL_INFO(SP_UPDATE_COMPL_INFO info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strTSDH", OracleType.VarChar);
                pram2.Value = (object)info.TSDH ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strRPID", OracleType.VarChar);
                pram3.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram4.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strTSSJMS", OracleType.VarChar);
                pram6.Value = (object)info.TSSJMS ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nTSDX", OracleType.Number);
                pram7.Value = (object)info.TSDX ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nTSRYLX", OracleType.Number);
                pram8.Value = (object)info.TSRYLX ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("strTSFZID", OracleType.VarChar);
                pram9.Value = (object)info.TSFZID ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strQTTS", OracleType.VarChar);
                pram10.Value = (object)info.QTTS ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nTSLX", OracleType.Number);
                pram11.Value = (object)info.TSLX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strTSYY", OracleType.VarChar);
                pram12.Value = (object)info.TSYY ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strDXSBR1", OracleType.VarChar);
                pram13.Value = (object)info.DXSBR1 ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("strDXSBR2", OracleType.VarChar);
                pram14.Value = (object)info.DXSBR2 ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strDXSBR3", OracleType.VarChar);
                pram15.Value = (object)info.DXSBR3 ?? DBNull.Value;

                OracleParameter pram16 = new OracleParameter("nFLAG", OracleType.Number);
                pram16.Value = 0;
                pram16.Direction = ParameterDirection.Output;
                OracleParameter pram17 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram17.Value = "";
                pram17.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[17] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_COMPL_INFO", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_PRNAK_CALL(SP_UPDATE_PRNAK_CALL info)
        {
            try
            {
                if (info != null && info.LSH == "Clear")
                {
                    OracleHelper.ExecuteNonQuery("update PRANK_CALL set sfsd=0 ,sdjssj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss') where sfsd=1", CommandType.Text, null);
                    return true;
                }
                //info.LSH = info.LSH.Split(':')[0];
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strHM", OracleType.VarChar);
                pram2.Value = (object)info.HM ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dBJSJ", OracleType.DateTime);
                pram3.Value = (object)info.BJSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nSFSD", OracleType.Number);
                pram4.Value = (object)info.SFSD ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSDSJ", OracleType.DateTime);
                pram5.Value = (object)info.SDSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nSDSC", OracleType.Number);
                pram6.Value = (object)info.SDSC ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strSDR", OracleType.VarChar);
                pram7.Value = (object)info.SDR ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("dSDJSSJ", OracleType.DateTime);
                pram8.Value = (object)info.SDJSSJ ?? DBNull.Value;

                OracleParameter pram9 = new OracleParameter("nFLAG", OracleType.Number);
                pram9.Value = 0;
                pram9.Direction = ParameterDirection.Output;
                OracleParameter pram10 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram10.Value = "";
                pram10.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[10] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_PRNAK_CALL", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_CALL_INFO_MULTIPLE(SP_UPDATE_CALL_INFO_MULTIPLE info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("nBZ", OracleType.Number);
                pram1.Value = (object)info.nBZ ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strLSH", OracleType.VarChar);
                pram2.Value = (object)info.strLSH ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strZJHM", OracleType.VarChar);
                pram3.Value = (object)info.strZJHM ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strBJHM", OracleType.VarChar);
                pram4.Value = (object)info.strBJHM ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strGLLSH", OracleType.VarChar);
                pram5.Value = (object)info.strGLLSH ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nTHLX", OracleType.Number);
                pram6.Value = (object)info.nTHLX ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("dHJSJ", OracleType.DateTime);
                pram7.Value = (object)info.dHJSJ ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("dZJSJ", OracleType.DateTime);
                pram8.Value = (object)info.dZJSJ ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("dGJSJ", OracleType.DateTime);
                pram9.Value = (object)info.dGJSJ ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strLYID", OracleType.VarChar);
                pram10.Value = (object)info.strLYID ?? DBNull.Value;

                OracleParameter pram11 = new OracleParameter("nFLAG", OracleType.Number);
                pram11.Value = 0;
                pram11.Direction = ParameterDirection.Output;
                OracleParameter pram12 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram12.Value = "";
                pram12.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[12] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CALL_INFO_MULTIPLE", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_TRANSPORT_ACCEPT(TRANSPORT_ACCEPT info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strRPID", OracleType.VarChar);
                pram2.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram3.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSJH", OracleType.VarChar);
                pram4.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nSLZT", OracleType.Number);
                pram6.Value = (object)info.SLZT ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nSLLY", OracleType.Number);
                pram7.Value = (object)info.SLLY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nSLLX", OracleType.Number);
                pram8.Value = (object)info.SLLX ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nHJZLX", OracleType.Number);
                pram9.Value = (object)info.HJZLX ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strSZYY", OracleType.VarChar);
                pram10.Value = (object)info.SZYY ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nIS_CKOUT", OracleType.Number);
                pram11.Value = (object)info.IS_CKOUT ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strSZKS", OracleType.VarChar);
                pram12.Value = (object)info.SZKS ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strSZBS", OracleType.VarChar);
                pram13.Value = (object)info.SZBS ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("strMQZD", OracleType.VarChar);
                pram14.Value = (object)info.MQZD ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strYBHGX", OracleType.VarChar);
                pram15.Value = (object)info.YBHGX ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strZWYY", OracleType.VarChar);
                pram16.Value = (object)info.ZWYY ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strGCDF", OracleType.VarChar);
                pram17.Value = (object)info.GCDF ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("strGCDFYJ", OracleType.VarChar);
                pram18.Value = (object)info.GCDFYJ ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strHZXM", OracleType.VarChar);
                pram19.Value = (object)info.HZXM ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("nHZXB", OracleType.Number);
                pram20.Value = (object)info.HZXB ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("nNL", OracleType.Number);
                pram21.Value = (object)info.NL ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("nMZ", OracleType.Number);
                pram22.Value = (object)info.MZ ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("nGJ", OracleType.Number);
                pram23.Value = (object)info.GJ ?? DBNull.Value;
                OracleParameter pram24 = new OracleParameter("nTQ", OracleType.Number);
                pram24.Value = (object)info.TQ ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("nLK", OracleType.Number);
                pram25.Value = (object)info.LK ?? DBNull.Value;
                OracleParameter pram26 = new OracleParameter("strBZ", OracleType.VarChar);
                pram26.Value = (object)info.BZ ?? DBNull.Value;

                OracleParameter pram27 = new OracleParameter("nFLAG", OracleType.Number);
                pram27.Value = 0;
                pram27.Direction = ParameterDirection.Output;
                OracleParameter pram28 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram28.Value = "";
                pram28.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[28] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram22
                , pram23, pram24, pram25, pram26, pram27, pram28};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_TRANSPORT_ACCEPT", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取流水号的相关信息
        /// </summary>
        /// <param name="sjh"></param>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static Ambul_AcceptInfo GetAllInfoAboutLsh(string sjh, string lsh)
        {
            try
            {
                Ambul_AcceptInfo item = new Ambul_AcceptInfo();
                item.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_all_SJLB where SJH='" + sjh + "'", CommandType.Text, null);
                item.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_all_Accept_Info where LSH='" + lsh + "'", CommandType.Text, null);
                item.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + lsh + "'", CommandType.Text, null);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static bool SP_UPDATE_ACCEPT_APP_QUALITY(QualityRespnose info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.lsh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strQUALITYCOMMET", OracleType.VarChar);
                pram2.Value = (object)info.qualitycomment ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strREASON", OracleType.VarChar);
                pram3.Value = (object)info.reason ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strCASEID", OracleType.VarChar);
                pram4.Value = (object)info.caseid ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dCOMMENTTIME", OracleType.DateTime);
                pram5.Value = (object)info.commenttime.Value ?? DBNull.Value;

                OracleParameter pram6 = new OracleParameter("nFLAG", OracleType.Number);
                pram6.Value = 0;
                pram6.Direction = ParameterDirection.Output;
                OracleParameter pram7 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram7.Value = "";
                pram7.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[7] { pram1, pram2, pram3, pram4, pram5, pram6, pram7 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_ACCEPT_APP_QUALITY", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        //public static V_CLXQXX Get_ALL_V_CLXQXX_ById(string clid)
        //{
        //    try
        //    {
        //        return OracleHelper.ExecuteEntity<V_CLXQXX>("select * from V_CLXQXX where clid='" + clid + "'", CommandType.Text, null);
        //    }
        //    catch (System.Exception e)
        //    {
        //        return new V_CLXQXX();
        //    }
        //}
        public static CCXX SP_GET_APP_CCXX(string lsh, string ccxh)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)lsh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nCCXH", OracleType.Number);
                pram2.Value = (object)ccxh ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("RESULT", OracleType.Cursor);
                pram3.Value = "";
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("nFLAG", OracleType.Number);
                pram4.Value = 0;
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram5.Value = "";
                pram5.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[5] { pram1, pram2, pram3, pram4, pram5 };

                return OracleHelper.ExecuteEntity<CCXX>("ZIT_RP_ACCEPT_PKG.SP_GET_APP_CCXX", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static bool SP_UPDATE_ACCEPT_APP(receiveAPPSheet info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strCASEID", OracleType.VarChar, 1000);
                pram1.Value = (object)info.caseid ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strPHONE", OracleType.VarChar);
                pram2.Value = (object)info.phone ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strNAME", OracleType.VarChar);
                pram3.Value = (object)info.name ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nSEX", OracleType.VarChar);
                pram4.Value = (object)info.sex ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strBRITHDAY", OracleType.VarChar);
                pram5.Value = (object)info.brithday ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nHEIGHT", OracleType.VarChar);
                pram6.Value = (object)info.height ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nWEIGHT", OracleType.VarChar);
                pram7.Value = (object)info.weight ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strIDENTITYCARD", OracleType.VarChar);
                pram8.Value = (object)info.identitycard ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("strJD", OracleType.VarChar);
                pram9.Value = (object)info.jd ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strWD", OracleType.VarChar);
                pram10.Value = (object)info.wd ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("strADDRESS", OracleType.VarChar);
                pram11.Value = (object)info.address ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strMEDICALHISTORY", OracleType.VarChar);
                pram12.Value = (object)info.medicalhistory ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strCONTACTWAY1", OracleType.VarChar);
                pram13.Value = (object)info.contactway1 ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("strCONTACTWAY2", OracleType.VarChar);
                pram14.Value = (object)info.contactway2 ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strCONTACTWAY3", OracleType.VarChar);
                pram15.Value = (object)info.contactway3 ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strMEDICALINSURANCECARD", OracleType.VarChar);
                pram16.Value = (object)info.medicalinsurancecard ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strPROVINCE", OracleType.VarChar);
                pram17.Value = (object)info.province ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("strCITY", OracleType.VarChar);
                pram18.Value = (object)info.city ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strAREA", OracleType.VarChar);
                pram19.Value = (object)info.area ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strAREACODE", OracleType.VarChar);
                pram20.Value = (object)info.areacode ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("dCALLTIME", OracleType.DateTime);
                pram21.Value = (object)info.calltime.Value ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("nISSELF", OracleType.VarChar);
                pram22.Value = (object)info.isself ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("nXZBM", OracleType.VarChar);
                pram23.Value = (object)info.xzbm ?? DBNull.Value;
                OracleParameter pram24 = new OracleParameter("strLSH", OracleType.VarChar);
                pram24.Value = (object)info.lsh ?? DBNull.Value;

                OracleParameter pram25 = new OracleParameter("nFLAG", OracleType.Number);
                pram25.Value = 0;
                pram25.Direction = ParameterDirection.Output;
                OracleParameter pram26 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram26.Value = "";
                pram26.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[26] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21,pram22
                , pram23, pram24, pram25, pram26};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_ACCEPT_APP", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 中心更新事件受理信息，由分站插入出车信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="lsh"></param>
        /// <returns></returns>
        public static Ambul_AcceptInfo UpdateEventAcceptForFZCC(EVENT_INFO info, string lsh)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nSTATUS", OracleType.Number);
                pram2.Value = (object)info.STATUS ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dSCLDSJ", OracleType.DateTime);
                pram3.Value = (object)info.SCLDSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSCLDHM", OracleType.VarChar);
                pram4.Value = (object)info.SCLDHM ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSCSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SCSLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSCSLRPID", OracleType.VarChar);
                pram6.Value = (object)info.SCSLRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strSCDDY", OracleType.VarChar);
                pram7.Value = (object)info.SCDDY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strHCYY", OracleType.VarChar);
                pram8.Value = (object)info.HCYY ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nSJLX", OracleType.Number);
                pram9.Value = (object)info.SJLX ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nSGLX", OracleType.Number);
                pram10.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGDJ", OracleType.Number);
                pram11.Value = (object)info.SGDJ ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram12.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("mFLAG", OracleType.Number);
                pram13.Value = (object)info.FLAG ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nXZBM", OracleType.Number);
                pram14.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("nFLAG", OracleType.Number);
                pram15.Value = 0;
                pram15.Direction = ParameterDirection.Output;
                OracleParameter pram16 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram16.Value = "";
                pram16.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[16] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16};
                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_EVENT_INFO", CommandType.StoredProcedure, pms);
                Ambul_AcceptInfo item = new Ambul_AcceptInfo();
                if (!string.IsNullOrEmpty(lsh))
                {
                    OracleHelper.ExecuteNonQuery("update accept_info set sjh='" + info.SJH + "' , SLZT=1  where lsh='" + lsh + "' ", CommandType.Text, null);
                    item.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_all_Accept_Info where LSH='" + lsh + "'", CommandType.Text, null);
                    item.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + lsh + "'", CommandType.Text, null);
                }
                item.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_all_SJLB where SJH='" + info.SJH + "'", CommandType.Text, null);
                return item;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// 更新事件状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static V_SJLB SP_UPDATE_EVENT_INFO(EVENT_INFO info)
        {
            try
            {
                if (info.FLAG == 100)
                {
                    OracleHelper.ExecuteNonQuery("update EVENT_INFO set status=" + info.STATUS + "  where sjh='" + info.SJH + "'", CommandType.Text, null);
                    return OracleHelper.ExecuteEntity<V_SJLB>("select * from V_all_SJLB where SJH='" + info.SJH + "'", CommandType.Text, null);
                }

                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nSTATUS", OracleType.Number);
                pram2.Value = (object)info.STATUS ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dSCLDSJ", OracleType.DateTime);
                pram3.Value = (object)info.SCLDSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSCLDHM", OracleType.VarChar);
                pram4.Value = (object)info.SCLDHM ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSCSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SCSLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSCSLRPID", OracleType.VarChar);
                pram6.Value = (object)info.SCSLRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strSCDDY", OracleType.VarChar);
                pram7.Value = (object)info.SCDDY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strHCYY", OracleType.VarChar);
                pram8.Value = (object)info.HCYY ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nSJLX", OracleType.Number);
                pram9.Value = (object)info.SJLX ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nSGLX", OracleType.Number);
                pram10.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGDJ", OracleType.Number);
                pram11.Value = (object)info.SGDJ ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram12.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("mFLAG", OracleType.Number);
                pram13.Value = (object)info.FLAG ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nXZBM", OracleType.Number);
                pram14.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("nFLAG", OracleType.Number);
                pram15.Value = 0;
                pram15.Direction = ParameterDirection.Output;
                OracleParameter pram16 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram16.Value = "";
                pram16.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[16] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_EVENT_INFO", CommandType.StoredProcedure, pms);

                V_SJLB item = new V_SJLB();
                if (rows == 1)
                {
                    item = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_all_SJLB where SJH='" + info.SJH + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_AMBUL_TRAC(AMBUL_TRAC info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strCZHM", OracleType.VarChar, 4000);
                pram1.Value = (object)info.CZHM ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("dZHFSSJ", OracleType.DateTime);
                pram2.Value = (object)info.ZHFSSJ ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dDXDDSJ", OracleType.DateTime);
                pram3.Value = (object)info.DXDDSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nXSLC", OracleType.Number);
                pram4.Value = (object)info.XSLC ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("nSD", OracleType.Number);
                pram5.Value = (object)info.SD ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nFX", OracleType.Number);
                pram6.Value = (object)info.FX ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nGPS_X", OracleType.Number);
                pram7.Value = (object)info.GPS_X ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nGPS_Y", OracleType.Number);
                pram8.Value = (object)info.GPS_Y ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nGZXS", OracleType.Number);
                pram9.Value = (object)info.GZXS ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nKJXS", OracleType.Number);
                pram10.Value = (object)info.KJXS ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nBJ", OracleType.Number);
                pram11.Value = (object)info.BJ ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nTXZT", OracleType.Number);
                pram12.Value = (object)info.TXZT ?? DBNull.Value;

                OracleParameter pram13 = new OracleParameter("nFLAG", OracleType.Number);
                pram13.Value = 0;
                pram13.Direction = ParameterDirection.Output;
                OracleParameter pram14 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram14.Value = "";
                pram14.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[14] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_AMBUL_TRAC", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static bool SP_UPDATE_ACCEPT_YM_INFO(string lsh, string orderid)
        {
            int rows = OracleHelper.ExecuteNonQuery("update accept_ym set lsh='" + lsh + "' where orderid='" + orderid + "'", CommandType.Text, null);

            return (rows == 1) ? true : false;
        }

        public static bool SP_INSERT_ACCEPT_YM(ACCEPT_YM info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strORDERID", OracleType.VarChar, 3000);
                pram1.Value = (object)info.ORDERID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strXZBM", OracleType.VarChar);
                pram2.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strJOBNUM", OracleType.VarChar);
                pram3.Value = (object)info.JOBNUM ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strTELPHONE", OracleType.VarChar);
                pram4.Value = (object)info.TELPHONE ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strGPS_X", OracleType.VarChar);
                pram5.Value = (object)info.GPS_X ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strGPS_Y", OracleType.VarChar);
                pram6.Value = (object)info.GPS_Y ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strLOCATION", OracleType.VarChar);
                pram7.Value = (object)info.CHINESELOCATION ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strPERSONNUM", OracleType.VarChar);
                pram8.Value = (object)info.PERSONNUM ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("strNAME", OracleType.VarChar);
                pram9.Value = (object)info.NAME ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strNATIONALITY", OracleType.VarChar);
                pram10.Value = (object)info.NATIONALITY ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("strSEX", OracleType.VarChar);
                pram11.Value = (object)info.SEX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strCONNECTTEL", OracleType.VarChar);
                pram12.Value = (object)info.CONNECTTEL ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("strCONNECTOR", OracleType.VarChar);
                pram13.Value = (object)info.CONNECTOR ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("strVENAME", OracleType.VarChar);
                pram14.Value = (object)info.VENAME ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("strVEMODEL", OracleType.VarChar);
                pram25.Value = (object)info.VEMODEL ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strREMARK", OracleType.VarChar);
                pram15.Value = (object)info.REMARK ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("nFLAG", OracleType.Number);
                pram16.Value = 0;
                pram16.Direction = ParameterDirection.Output;
                OracleParameter pram17 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram17.Value = "";
                pram17.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[18] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram25, pram15, pram16, pram17};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_ACCEPT_YM", CommandType.StoredProcedure, pms);

                return (rows > 0) ? true : false;

            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static PreDetailInfo Get_PreDetailInfo(string zjhm)
        {
            try
            {
                PreDetailInfo item = new PreDetailInfo();
                List<P_PRES_ACCEPT_INFO> lst_ac = OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select a.* from call_info c, V_ALL_ACCEPT_INFO a where c.zjhm='" + zjhm + "' and c.lsh=a.lsh order by a.HJSJ desc", CommandType.Text, null);
                if (lst_ac != null && lst_ac.Count > 0)
                {
                    item.last_accept_info = lst_ac[0];
                }
                VIP_USER_INFO user_vip = OracleHelper.ExecuteEntity<VIP_USER_INFO>("select id,mc,lx,jb,dh,lxr,lxdh,dz from VIP_USER_INFO  where DH='" + zjhm + "' and lx=40", CommandType.Text, null);
                if (user_vip != null && !string.IsNullOrEmpty(user_vip.ID))
                {
                    item.isvip = true;
                    item.vip_user_info = user_vip;
                }
                IList<SP_GET_OBLIGATE_ACCEPT_INFO> obligate_ac = SP_GET_OBLIGATE_ACCEPT_INFO(zjhm);
                if (obligate_ac != null && obligate_ac.Count > 0)
                {
                    item.call_accept_info = obligate_ac[0];
                }
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool UpdateTakeHospital(string lsh, string swdd, string swyy, string clid, string sllx)
        {
            try
            {
                OracleHelper.ExecuteNonQuery("update ambul_outd_info set swdd='" + swdd + "' where lsh='" + lsh + "' and clid='" + clid + "'", CommandType.Text, null);
                OracleHelper.ExecuteNonQuery("update accept_info set swdd='" + swdd + "',swyy=" + swyy + " where lsh='" + lsh + "'", CommandType.Text, null);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// 分站改派自己的车辆
        /// </summary>
        /// <param name="lsh">流水号</param>
        /// <param name="ccxh">被改派车辆的出车序号</param>
        /// <param name="oldclid">被改派得车辆ID</param>
        /// <param name="qxyy">取消原因</param>
        /// <param name="newclid">新增的车辆ID</param>
        /// <param name="szfzid">分站ID</param>
        /// <param name="rpid">分站ID</param>
        /// <param name="ddyid">分站受理员ID</param>
        /// <param name="pcsj">新增的派车时间</param>
        /// <returns></returns>
        public static string Station_Modify(string lsh, string ccxh, string oldclid, string qxyy, string newclid, string szfzid, string rpid, string ddyid, string pcsj)
        {
            Ambul_AcceptInfo result = new Ambul_AcceptInfo();
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)lsh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nCCXH", OracleType.VarChar);
                pram2.Value = (object)ccxh ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strOLDCLID", OracleType.VarChar);
                pram3.Value = (object)oldclid ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nQXYY", OracleType.Number);
                pram4.Value = (object)qxyy ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strNEWCLID", OracleType.VarChar);
                pram5.Value = (object)newclid ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram6.Value = (object)szfzid ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strRPID", OracleType.VarChar);
                pram7.Value = (object)rpid ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram8.Value = (object)ddyid ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram9.Value = (object)DateTime.Now ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
                pram10.Value = (object)pcsj ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nFLAG", OracleType.Number);
                pram11.Value = 0;
                pram11.Direction = ParameterDirection.Output;
                OracleParameter pram12 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram12.Value = "";
                pram12.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[12] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_FZ_ACCEPT_PKG.SP_UPDATE_FZ_REASSIGNMENT", CommandType.StoredProcedure, pms);
                if (rows == 1)
                {
                    result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_all_AMBUL_OUTD_INFO  where LSH='" + lsh + "' ", CommandType.Text, null);
                    result.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_All_Accept_Info  where LSH='" + lsh + "' ", CommandType.Text, null);
                    OracleHelper.GetSingle("update dispatch_info set zt=1 ,qrsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qrr='" + rpid + "'  where lsh='" + lsh + "' and zt=0");
                }
                return JosnHelper.SerializeObject<Ambul_AcceptInfo>(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 分站取消派车
        /// </summary>
        /// <param name="strLSH">要取消的任务流水号</param>
        /// <param name="strCLID">要取消的车辆ID</param>
        /// <param name="ccxh">取消的出车序号</param>
        /// <param name="clzt">车辆状态</param>
        /// <param name="qxpcsj">取消派车时间</param>
        /// <param name="qxyy">取消原因</param>
        /// <param name="iszxqxpc">是否中心取消</param>
        /// <returns></returns>
        public static string Station_Cancle(string strLSH, string strCLID, string ccxh, string clzt, string qxpcsj, string qxyy, string iszxqxpc)
        {
            Ambul_AcceptInfo result = new Ambul_AcceptInfo();

            OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
            pram1.Value = (object)strLSH ?? DBNull.Value;
            OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
            pram2.Value = (object)strCLID ?? DBNull.Value;
            OracleParameter pram3 = new OracleParameter("nQXYY", OracleType.Number);
            pram3.Value = (object)qxyy ?? DBNull.Value;
            OracleParameter pram4 = new OracleParameter("nCLZT", OracleType.Number);
            pram4.Value = (object)clzt ?? DBNull.Value;
            OracleParameter pram5 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
            pram5.Value = (object)qxpcsj ?? DBNull.Value;
            OracleParameter pram6 = new OracleParameter("nISZXQXPC", OracleType.Number);
            pram6.Value = (object)iszxqxpc ?? DBNull.Value;
            OracleParameter pram7 = new OracleParameter("nCCXH", OracleType.Number);
            pram7.Value = (object)ccxh ?? DBNull.Value;
            OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
            pram8.Value = 0;
            pram8.Direction = ParameterDirection.Output;
            OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
            pram9.Value = "";
            pram9.Direction = ParameterDirection.Output;
            OracleParameter[] pms = new OracleParameter[9] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9 };

            int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CANCLED", CommandType.StoredProcedure, pms);
            if (qxyy == "32" || qxyy == "33" || qxyy == "34" || qxyy == "35" || qxyy == "36")
            {
                OracleHelper.ExecuteNonQuery("update ambul_outd_info set tsqk=" + qxyy + ",ISZXQXPC=0,SFQXPC=0,QXYY=0  where lsh='" + strLSH + "' and clid=" + strCLID, CommandType.Text, null);
            }
            else
            {
                if (ccxh == "0")
                {
                    OracleHelper.GetSingle("update ambul_outd_info set sfqxpc=1,iszxqxpc=1 ,qxpcsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qxyy=" + qxyy + "  where lsh='" + strLSH + "' and clid=" + strCLID);
                }
                else
                {
                    OracleHelper.GetSingle("update ambul_outd_info set sfqxpc=1,iszxqxpc=1 ,qxpcsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qxyy=" + qxyy + "  where lsh='" + strLSH + "' and ccxh=" + ccxh);
                }
            }
            OracleHelper.GetSingle("update dispatch_info set zt=1 ,qrsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss')  where lsh='" + strLSH + "' and zt=0");
            result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + strLSH + "'", CommandType.Text, null);
            result.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_All_Accept_Info  where LSH='" + strLSH + "' ", CommandType.Text, null);

            return JosnHelper.SerializeObject<Ambul_AcceptInfo>(result);
        }

        /// <summary>
        /// 分站拒绝任务
        /// </summary>
        /// <param name="strLSH">拒绝的任务流水号</param>
        /// <param name="ddxh">拒绝任务的调度序号</param>
        /// <param name="qrr">拒绝任务的调度员</param>
        /// <param name="qrsj">拒绝任务的时间</param>
        /// <returns></returns>
        public static bool Station_Refuse(string strLSH, string ddxh, string qrr, string qrsj)
        {
            try
            {
                OracleHelper.GetSingle("update dispatch_info set zt=2 ,qrsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qrr='" + qrr + "'  where lsh='" + strLSH + "' and ddxh=" + ddxh);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 分站增援派车
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <param name="strCLID">新增的车辆ID</param>
        /// <param name="strSZFZ">分站ID</param>
        /// <param name="nPCLX">派车类型</param>
        /// <param name="dPCSJ">派车时间</param>
        /// <param name="strRPID">分站ID</param>
        /// <param name="strDDYID">分站受理员ID</param>
        /// <param name="strSJH">该受理的事件号</param>
        /// <param name="ddxh">调度序号（如果自行增援可以传空，如果是中心转发的增援调度任务，传该调度序号）</param>
        /// <returns></returns>
        public static string Station_InserAmbul(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string strSJH, string ddxh)
        {
            try
            {
                Ambul_AcceptInfo result = new Ambul_AcceptInfo();
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 3000);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
                pram2.Value = (object)strCLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram3.Value = (object)strSZFZ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nPCLX", OracleType.Number);
                pram4.Value = (object)nPCLX ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram5.Value = (object)dPCSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strRPID", OracleType.VarChar);
                pram6.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram7.Value = (object)strDDYID ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strSJH", OracleType.VarChar);
                pram10.Value = (object)strSJH ?? DBNull.Value;

                OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
                pram8.Value = 0;
                pram8.Direction = ParameterDirection.Output;
                OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram9.Value = "";
                pram9.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[10] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_AMBUL_OUTD", CommandType.StoredProcedure, pms);
                if (rows == 1)
                {
                    result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + strLSH + "'", CommandType.Text, null);
                    result.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_All_Accept_Info where LSH='" + strLSH + "'", CommandType.Text, null);
                    if (result.AmbulInfoList != null && result.AmbulInfoList.Count > 0)
                    {
                        OracleHelper.ExecuteNonQuery("update event_info set status=0  where sjh='" + result.AmbulInfoList[0].SJH + "' ", CommandType.Text, null);
                        result.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from v_All_SJLB where sjh='" + result.AmbulInfoList[0].SJH + "'", CommandType.Text, null);
                    }
                    if (!string.IsNullOrEmpty(ddxh) && ddxh != "0")
                    {
                        OracleHelper.GetSingle("update dispatch_info set zt=1 where lsh='" + strLSH + "' and ddxh=" + ddxh);
                    }
                    else
                    {
                        OracleHelper.GetSingle("update dispatch_info set zt=1 where lsh='" + strLSH + "' and zt=0");
                    }
                }
                return JosnHelper.SerializeObject<Ambul_AcceptInfo>(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 中心取消派车
        /// </summary>
        /// <param name="info"></param>
        /// <param name="clzt"></param>
        /// <returns></returns>
        public static Ambul_AcceptInfo UpdateCancleAmbulInfo(AMBUL_OUTD_INFO info, string clzt)
        {
            try
            {
                Ambul_AcceptInfo result = new Ambul_AcceptInfo();
                if (info.QXYY == 32 || info.QXYY == 33 || info.QXYY == 34 || info.QXYY == 35 || info.QXYY == 36)
                {
                    OracleHelper.ExecuteNonQuery("update ambul_outd_info set tsqk=" + info.QXYY + ",ISZXQXPC=0,SFQXPC=0,QXYY=0  where lsh='" + info.LSH + "' and clid=" + info.CLID, CommandType.Text, null);
                    result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + info.LSH + "'", CommandType.Text, null);
                    return result;
                }

                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
                pram2.Value = (object)info.CLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nQXYY", OracleType.Number);
                pram3.Value = (object)info.QXYY ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nCLZT", OracleType.Number);
                pram4.Value = (object)clzt ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
                pram5.Value = (object)info.QXPCSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nISZXQXPC", OracleType.Number);
                pram6.Value = (object)info.ISZXQXPC ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nCCXH", OracleType.Number);
                pram7.Value = (object)info.CCXH ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
                pram8.Value = 0;
                pram8.Direction = ParameterDirection.Output;
                OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram9.Value = "";
                pram9.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[9] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CANCLED", CommandType.StoredProcedure, pms);
                
                result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + info.LSH + "'", CommandType.Text, null);
                if (result.AmbulInfoList!=null && result.AmbulInfoList.Count>0)
                {
                    OracleHelper.ExecuteNonQuery("update event_info set status=0  where sjh='" + result.AmbulInfoList[0].SJH + "' ", CommandType.Text, null);
                    result.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from v_All_SJLB where sjh='" + result.AmbulInfoList[0].SJH + "'", CommandType.Text, null);
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 更新出车信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static List<SP_GET_AMBUL_OUTD_INFO> SP_UPDATE_AMBUL_OUTD_INFO(AMBUL_OUTD_INFO info)
        {
            try
            {
                if (info.CCXH == 0)
                {
                    OracleHelper.ExecuteNonQuery("update ambul_outd_info set bz='" + info.BZ + "' where lsh='" + info.LSH + "' and clid='" + info.CLID + "'", CommandType.Text, null);
                    return new List<SP_GET_AMBUL_OUTD_INFO>();
                }
                if (info.QXYY == 32 || info.QXYY == 33 || info.QXYY == 34 || info.QXYY == 35 || info.QXYY == 36)
                {
                    OracleHelper.ExecuteNonQuery("update ambul_outd_info set tsqk=" + info.QXYY + ",ISZXQXPC=0,SFQXPC=0,QXYY=0  where lsh='" + info.LSH + "' and clid=" + info.CLID, CommandType.Text, null);
                    return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_ALL_AMBUL_OUTD_INFO where LSH='" + info.LSH + "'", CommandType.Text, null);
                }
                else if (!string.IsNullOrEmpty(info.CLID) && info.CCXH != 0 && info.FLAG == 2)//出车信息修改
                {
                    int rows = 0;
                    if (!string.IsNullOrEmpty(info.SWDD) && info.SWDD != "0")
                    {
                        rows = OracleHelper.ExecuteNonQuery("update ambul_outd_info set bz='" + info.BZ + "',ISZXQXPC='" + Convert.ToInt32(info.ISZXQXPC) + "',SFQXPC='" + Convert.ToInt32(info.SFQXPC) + "',QXYY='" + Convert.ToInt32(info.QXYY) + "',SWDD='" + info.SWDD + "',PCLX='" + Convert.ToInt32(info.PCLX) + "',TSQK='" + Convert.ToInt32(info.TSQK) + "'   where lsh='" + info.LSH + "' and ccxh=" + Convert.ToInt32(info.CCXH), CommandType.Text, null);
                    }
                    else
                    {
                        rows = OracleHelper.ExecuteNonQuery("update ambul_outd_info set bz='" + info.BZ + "',ISZXQXPC='" + info.ISZXQXPC + "',SFQXPC='" + info.SFQXPC + "',QXYY='" + info.QXYY + "',PCLX='" + info.PCLX + "',TSQK='" + Convert.ToInt32(info.TSQK) + "'   where lsh='" + info.LSH + "' and ccxh=" + info.CCXH, CommandType.Text, null);
                    }
                    if (rows == 1)
                    {
                        OracleHelper.ExecuteNonQuery("update accept_info set slly='" + (((info.PCLX == 60)) ? 120 : 10) + " '   where lsh='" + info.LSH + "' ", CommandType.Text, null);
                    }
                    return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_ALL_AMBUL_OUTD_INFO where LSH='" + info.LSH + "'", CommandType.Text, null);
                }
                info.LSH = info.LSH.Split(':')[0];
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 3000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nCCXH", OracleType.Number);
                pram2.Value = (object)info.CCXH ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strCLID", OracleType.VarChar);
                pram3.Value = (object)info.CLID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram4.Value = (object)info.SZFZ ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("nPCLX", OracleType.Number);
                pram5.Value = (object)info.PCLX ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram6.Value = (object)info.PCSJ ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strRPID", OracleType.VarChar);
                pram7.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram8.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("mFLAG", OracleType.Number);
                pram9.Value = (object)info.FLAG ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nSFQXPC", OracleType.Number);
                pram10.Value = (object)info.SFQXPC ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nQXYY", OracleType.Number);
                pram11.Value = (object)info.QXYY ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nGPBZ", OracleType.Number);
                pram12.Value = (object)info.GPBZ ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("dCCSJ", OracleType.DateTime);
                pram13.Value = (object)info.CCSJ ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("dDDXCSJ", OracleType.DateTime);
                pram14.Value = (object)info.DDXCSJ ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("dDBRSBSJ", OracleType.DateTime);
                pram25.Value = (object)info.DBRSBSJ ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("dSCSJ", OracleType.DateTime);
                pram15.Value = (object)info.SCSJ ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("dSWSJ", OracleType.DateTime);
                pram16.Value = (object)info.SWSJ ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("dWCSJ", OracleType.DateTime);
                pram17.Value = (object)info.WCSJ ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("dFZSJ", OracleType.DateTime);
                pram18.Value = (object)info.FZSJ ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("nTSQK", OracleType.Number);
                pram19.Value = (object)info.TSQK ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strSWDD", OracleType.VarChar);
                pram20.Value = (object)info.SWDD ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("nXZBM", OracleType.Number);
                pram21.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram26 = new OracleParameter("strBZ", OracleType.VarChar);
                pram26.Value = (object)info.BZ ?? DBNull.Value;
                OracleParameter pram27 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
                pram27.Value = (object)info.QXPCSJ ?? DBNull.Value;
                OracleParameter pram28 = new OracleParameter("nISZXQXPC", OracleType.Number);
                pram28.Value = (object)info.ISZXQXPC ?? DBNull.Value;

                OracleParameter pram22 = new OracleParameter("rtn_CCXH", OracleType.Number);
                pram22.Value = 0;
                pram22.Direction = ParameterDirection.Output;
                OracleParameter pram23 = new OracleParameter("nFLAG", OracleType.Number);
                pram23.Value = 0;
                pram23.Direction = ParameterDirection.Output;
                OracleParameter pram24 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram24.Value = "";
                pram24.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[28] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram25, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram26, pram27, pram28, pram22, pram23, pram24};
                OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_AMBUL_OUTD_INFO", CommandType.StoredProcedure, pms);
                //if (info.TSQK != 0)
                //{
                //    LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + "update ambul_outd_info set sfqxpc=1,iszxqxpc=0 ,qxpcsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qxyy=60,TSQK='" + info.TSQK + "  where lsh='" + info.LSH + "' and clid=" + info.CLID, new LogUtility.RunningPlace("OracleHelper", "SP_UPDATE_AMBUL_OUTD_INFO"), "SP_UPDATE_AMBUL_OUTD_INFO");
                //    OracleHelper.ExecuteNonQuery("update ambul_outd_info set sfqxpc=1,iszxqxpc=0 ,qxpcsj=to_date('" + DateTime.Now.ToString() + "','yyyy-mm-dd hh24:mi:ss'),qxyy=60,TSQK='" + info.TSQK + "'  where lsh='" + info.LSH + "' and clid=" + info.CLID, CommandType.Text, null);
                //}
                return OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_ALL_AMBUL_OUTD_INFO where LSH='" + info.LSH + "'", CommandType.Text, null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_AMBUL_OUTD_STAFF(AMBUL_OUTD_STAFF info)
        {
            try
            {
                info.LSH = info.LSH.Split(':')[0];
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nCCXH", OracleType.Number);
                pram2.Value = (object)info.CCXH ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strCLID", OracleType.VarChar);
                pram3.Value = (object)info.CLID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("mFLAG", OracleType.Number);
                pram4.Value = (object)info.LX ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("nFLAG", OracleType.Number);
                pram5.Value = 0;
                pram5.Direction = ParameterDirection.Output;
                OracleParameter pram6 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram6.Value = "";
                pram6.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[6] { pram1, pram2, pram3, pram4, pram5, pram6 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_AMBUL_OUTD_STAFF", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_SMS(string strLSH, string dSJ, string strFSDX, string strNR, string strBZ, string strLX)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("dSJ", OracleType.DateTime);
                pram2.Value = (object)dSJ ?? DateTime.Now;
                OracleParameter pram3 = new OracleParameter("strFSDX", OracleType.VarChar);
                pram3.Value = (object)strFSDX ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strNR", OracleType.VarChar);
                pram4.Value = (object)strNR ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strBZ", OracleType.VarChar);
                pram5.Value = (object)strLX ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strLX", OracleType.VarChar);
                pram6.Value = (object)strLX ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nFLAG", OracleType.Number);
                pram7.Value = 0;
                pram7.Direction = ParameterDirection.Output;
                OracleParameter pram8 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram8.Value = "";
                pram8.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[8] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_SMS", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_CANCLE_EVENT_BELONG(string strSJH)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)strSJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nFLAG", OracleType.Number);
                pram2.Value = 0;
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram3.Value = "";
                pram3.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[3] { pram1, pram2, pram3 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_CANCLE_EVENT_BELONG", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_AMBUL_STATUS_INFO(AMBUL_STATUS_INFO info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strTEL", OracleType.VarChar);
                pram1.Value = (object)info.TEL ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strDQSZFZID", OracleType.VarChar);
                pram2.Value = (object)info.DQSZFZID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nCLDJ", OracleType.Number);
                pram3.Value = (object)info.CLDJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nSTATUS", OracleType.Number);
                pram4.Value = (object)info.STATUS ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("nZTDY", OracleType.Number);
                pram5.Value = (object)info.ZTDY ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSJID", OracleType.VarChar);
                pram6.Value = (object)info.SJID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strYSID", OracleType.VarChar);
                pram7.Value = (object)info.YSID ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strHSID", OracleType.VarChar);
                pram8.Value = (object)info.HSID ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("strDJGID", OracleType.VarChar);
                pram9.Value = (object)info.DJGID ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nGPS_X", OracleType.Number);
                pram10.Value = (object)info.GPS_X ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nGPS_Y", OracleType.Number);
                pram11.Value = (object)info.GPS_Y ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nCZSFZX", OracleType.Number);
                pram12.Value = (object)info.CZSFZX ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("nFLAG", OracleType.Number);
                pram13.Value = 0;
                pram13.Direction = ParameterDirection.Output;
                OracleParameter pram14 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram14.Value = "";
                pram14.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[14] { pram1, pram2, pram3, pram4, pram5, pram6, pram7 
                , pram8, pram9, pram10, pram11, pram12, pram13 ,pram14};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_AMBUL_STATUS_INFO", CommandType.StoredProcedure, pms);
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, info.LAST_MODIFY_TIME.ToString() + "-----" + info.TEL + "-----" + info.STATUS.ToString(), new LogUtility.RunningPlace("", "SP_UPDATE_AMBUL_STATUS_INFO"), "更改出车状态信息记录");
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_AMBUL_STATUS_DATE(string lsh, string clzt, string date, string ccxh, string czdh, string clid)
        {
            try
            {
                int rows = 0;
                string date_sql = "";
                switch (clzt)
                {
                    case "1":
                        date_sql = "CCSJ";
                        break;
                    case "2":
                        date_sql = "DDXCSJ";
                        break;
                    case "31":
                        date_sql = "SCSJ";
                        break;
                    case "4":
                        date_sql = "SWSJ";
                        break;
                    case "5":
                        date_sql = "WCSJ";
                        break;
                    case "0":
                        date_sql = "FZSJ";
                        break;
                    default:
                        break;
                }
                //更新出车时间
                rows = OracleHelper.ExecuteNonQuery("update ambul_outd_info set  " + date_sql + "=to_date('" + date + "','yyyy-mm-dd hh24:mi:ss')" + "  where lsh='" + lsh + "' and clid='" + clid + "' and ccxh=" + ccxh, CommandType.Text, null);
                rows = OracleHelper.ExecuteNonQuery("update ambul_status_info set  status='" + clzt + "' where clid='" + clid + "'", CommandType.Text, null);
                if (clzt == "5" || clzt == "6" || clzt == "0")
                {
                    OracleHelper.ExecuteNonQuery("update event_info set status =30  where sjh=(select sjh from accept_info where lsh='" + lsh + "')", CommandType.Text, null);
                }

                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool SP_UPDATE_RP_ONDUTY(string strDDYID, string strRPID, string dSBSJ, string dXBSJ, string strBZ)
        {
            try
            {
                if (!string.IsNullOrEmpty(dXBSJ))//下班
                {
                    int rows_ = OracleHelper.ExecuteNonQuery("update sys_rp_onduty set XBSJ" + "=to_date('" + dXBSJ + "','yyyy-mm-dd hh24:mi:ss')" + ",FLAG=1  where RPID='" + strRPID + "' and FLAG=0", CommandType.Text, null);
                    return (rows_ == 1) ? true : false;
                }
                if (string.IsNullOrEmpty(dXBSJ))//上班
                {
                    //将该受理台之前上班置为下班
                    OracleHelper.ExecuteNonQuery("update sys_rp_onduty set XBSJ" + "=to_date('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')" + ",FLAG=1  where RPID='" + strRPID + "' and FLAG=0", CommandType.Text, null);
                }
                OracleParameter pram1 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram1.Value = (object)strDDYID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strRPID", OracleType.VarChar);
                pram2.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dSBSJ", OracleType.DateTime);
                pram3.Value = (object)dSBSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("dXBSJ", OracleType.DateTime);
                pram4.Value = DBNull.Value;
                //pram4.Value = (object)dXBSJ ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strBZ", OracleType.VarChar);
                pram5.Value = (object)strBZ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nFLAG", OracleType.Number);
                pram6.Value = 0;
                pram6.Direction = ParameterDirection.Output;
                OracleParameter pram7 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram7.Value = "";
                pram7.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[7] { pram1, pram2, pram3, pram4, pram5, pram6, pram7 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_RP_ONDUTY", CommandType.StoredProcedure, pms);
                if (rows == 0)
                {
                    LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, strDDYID + "-" + strRPID + "-" + dSBSJ + "-" + dXBSJ + "-" + strBZ, new LogUtility.RunningPlace("", "SP_UPDATE_RP_ONDUTY( 更新调度员上下班信息)"), "InfoDal");
                }
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static List<V_STAFF_ONDUTY> UpdateStaffOnduty(string strGH, string strTel, string nSXB, string dSJ)
        {
            try
            {
                if (string.IsNullOrEmpty(dSJ))
                {
                    dSJ = DateTime.Now.ToString();
                }
                if (string.IsNullOrEmpty(nSXB))
                {
                    nSXB = "0";
                }
                OracleParameter pram1 = new OracleParameter("strGH", OracleType.VarChar);
                pram1.Value = (object)strGH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strHM", OracleType.VarChar);
                pram2.Value = (object)strTel ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nSXB", OracleType.Number);
                pram3.Value = (object)nSXB ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("dSJ", OracleType.DateTime);
                pram4.Value = (object)dSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nFLAG", OracleType.Number);
                pram6.Value = 0;
                pram6.Direction = ParameterDirection.Output;
                OracleParameter pram7 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram7.Value = "";
                pram7.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[6] { pram1, pram2, pram3, pram4, pram6, pram7 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_STAFF_ONDUTY", CommandType.StoredProcedure, pms);
                List<V_STAFF_ONDUTY> lst = new List<V_STAFF_ONDUTY>();
                lst = OracleHelper.ExecuteList<V_STAFF_ONDUTY>("select * from V_STAFF_ONDUTY  where CZHM='" + strTel + "'  and sfsb=0", CommandType.Text, null);
                return lst;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_STAFF_ONDUTY(string strGH, string strTel, string nSXB, string dSJ)
        {
            try
            {
                if (string.IsNullOrEmpty(dSJ))
                {
                    dSJ = DateTime.Now.ToString();
                }
                if (string.IsNullOrEmpty(nSXB))
                {
                    nSXB = "0";
                }
                OracleParameter pram1 = new OracleParameter("strGH", OracleType.VarChar);
                pram1.Value = (object)strGH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strHM", OracleType.VarChar);
                pram2.Value = (object)strTel ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nSXB", OracleType.Number);
                pram3.Value = (object)nSXB ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("dSJ", OracleType.DateTime);
                pram4.Value = (object)dSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nFLAG", OracleType.Number);
                pram6.Value = 0;
                pram6.Direction = ParameterDirection.Output;
                OracleParameter pram7 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram7.Value = "";
                pram7.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[6] { pram1, pram2, pram3, pram4, pram6, pram7 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_STAFF_ONDUTY", CommandType.StoredProcedure, pms);
                List<V_STAFF_ONDUTY> lst = new List<V_STAFF_ONDUTY>();

                //CLRYINFO result = OracleHelper.ExecuteEntity<CLRYINFO>("select a.SZCL as clid,b.type from  sys_emt_info a,sys_member_info b where a.HM='" + strTel + "' and b.id='" + strGH + "'", CommandType.Text, null);
                //if (dSBSJ == "0")//上班
                //{
                //    if (result != null)
                //    {
                //        if (result.type == 30)//司机
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set status=0,sjid='" + strGH + "'  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 40)//医生
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set  ysid='" + strGH + "'  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 50)//护士
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set hsid='" + strGH + "'  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 60)//担架工
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set djgid='" + strGH + "'  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        OracleHelper.ExecuteNonQuery("update sys_staff_onduty set  flag=1  where gh='" + strGH + "' and flag=0", CommandType.Text, null);
                //        object maxid = OracleHelper.GetSingle("select max(id) from SYS_STAFF_ONDUTY where gh='" + strGH + "'");
                //        if (maxid != null)
                //        {
                //            OracleHelper.ExecuteNonQuery("update sys_staff_onduty set  flag=0  where gh='" + strGH + "' and id='" + maxid.ToString() + "'", CommandType.Text, null);
                //        }
                //    }
                //}
                //else
                //{
                //    if (result != null)
                //    {
                //        if (result.type == 30)//司机
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set status=7,sjid=''  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 40)//医生
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set  ysid=''  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 50)//护士
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set hsid=''  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        else if (result.type == 60)//担架工
                //        {
                //            OracleHelper.ExecuteNonQuery("update ambul_status_info set djgid=''  where clid='" + result.clid + "'", CommandType.Text, null);
                //        }
                //        OracleHelper.ExecuteNonQuery("update sys_staff_onduty set  flag=1  where gh='" + strGH + "' ", CommandType.Text, null);
                //    }
                //}
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_CALL_GLLSH(string strLSH, string strSJH, string nHJLX)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strSJH", OracleType.VarChar);
                pram2.Value = (object)strSJH ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nHJLX", OracleType.Number);
                pram3.Value = (object)nHJLX ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nFLAG", OracleType.Number);
                pram4.Value = 0;
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram5.Value = "";
                pram5.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[5] { pram1, pram2, pram3, pram4, pram5 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CALL_GLLSH", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static List<V_NOTICE_INFO> SP_INSERT_NOTICE_INFO(string strLSH, string dFBSJ, string nYXQ, string nLX, string strFBNR, string strFBR, string nJSRLX, string strJSR, string nZT)
        {
            try
            {
                if (string.IsNullOrEmpty(strLSH))
                {
                    strLSH = DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString().PadLeft(4, '0');
                }
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("dFBSJ", OracleType.DateTime);
                pram2.Value = (object)dFBSJ ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nYXQ", OracleType.Number);
                pram3.Value = (object)nYXQ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nLX", OracleType.Number);
                pram4.Value = (object)nLX ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strFBNR", OracleType.VarChar);
                pram5.Value = (object)strFBNR ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strFBR", OracleType.VarChar);
                pram6.Value = (object)strFBR ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nJSRLX", OracleType.Number);
                pram7.Value = (object)nJSRLX ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strJSR", OracleType.VarChar);
                pram8.Value = (object)strJSR ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nZT", OracleType.Number);
                pram9.Value = (object)nZT ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nFLAG", OracleType.Number);
                pram10.Value = 0;
                pram10.Direction = ParameterDirection.Output;
                OracleParameter pram11 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram11.Value = "";
                pram11.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[11] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_NOTICE_INFO", CommandType.StoredProcedure, pms);
                List<V_NOTICE_INFO> item = new List<V_NOTICE_INFO>();
                if (rows == 1)
                {
                    item = OracleHelper.ExecuteList<V_NOTICE_INFO>("select * from V_NOTICE_INFO where LSH ='" + strLSH + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception)
            {
                return new List<V_NOTICE_INFO>();
            }
        }
        public static bool UPDATE_PWD(string userid, string pwd)
        {
            try
            {

                int rows = OracleHelper.ExecuteNonQuery("update sys_member_info set PASSWORD='" + pwd + "' where ID='" + userid + "'", CommandType.Text, null);

                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static List<HZXXINfo> Get_Hzxx(string lsh)
        {
            try
            {
                List<HZXXINfo> item = new List<HZXXINfo>();

                item = OracleHelper.ExecuteList<HZXXINfo>("select * from V_HZXX where lsh='" + lsh + "'", CommandType.Text, null);
                return item;
            }
            catch (System.Exception)
            {
                return new List<HZXXINfo>();
            }
        }
        public static List<V_EVENT_BELONG> SP_UPDATE_EVENT_BELONG(string strSJH, string strB_ID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar, 4000);
                pram1.Value = (object)strSJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strB_ID", OracleType.VarChar);
                pram2.Value = (object)strB_ID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_EVENT_BELONG", CommandType.StoredProcedure, pms);
                List<V_EVENT_BELONG> item = new List<V_EVENT_BELONG>();
                if (rows == 1)
                {
                    item = OracleHelper.ExecuteList<V_EVENT_BELONG>("select * from V_EVENT_BELONG", CommandType.Text, null);
                    //item = OracleHelper.ExecuteList<V_EVENT_BELONG>("select * from V_EVENT_BELONG where GLID ='" + strB_ID + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception)
            {
                return new List<V_EVENT_BELONG>();
            }
        }

        ///// <summary>
        ///// 事件关联，传入事件号和关联ID，插入关联记录IList<V_EVENT_BELONG>
        ///// </summary>
        ///// <param name="strSJH">当前流水号</param>
        ///// <param name="strB_ID">目标事件号</param>
        ///// <returns></returns>
        //public static bool SP_UPDATE_EVENT_BELONG(string strSJH, string strB_ID)
        //{
        //    try
        //    {
        //        OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar, 4000);
        //        pram1.Value = (object)strSJH ?? DBNull.Value;
        //        OracleParameter pram2 = new OracleParameter("strB_ID", OracleType.VarChar);
        //        pram2.Value = (object)strB_ID ?? DBNull.Value;
        //        OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
        //        pram3.Value = 0;
        //        pram3.Direction = ParameterDirection.Output;
        //        OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
        //        pram4.Value = "";
        //        pram4.Direction = ParameterDirection.Output;
        //        OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

        //        int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_EVENT_BELONG", CommandType.StoredProcedure, pms);
        //        return (rows == 1) ? true : false;
        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}

        /// <summary>
        /// 中心直接改派车辆
        /// </summary>
        /// <param name="strNEWLSH"></param>
        /// <param name="strOLDCLID"></param>
        /// <param name="strOLDLSH"></param>
        /// <param name="nQXYY"></param>
        /// <param name="strNEWCLID"></param>
        /// <param name="strSZFZ"></param>
        /// <param name="strRPID"></param>
        /// <param name="strDDYID"></param>
        /// <param name="dQXPCSJ"></param>
        /// <returns></returns>
        public static List<SP_GET_AMBUL_OUTD_INFO> SP_UPDATE_REASSIGNMENT(string strNEWLSH, string strOLDCLID, string strOLDLSH, string nQXYY, string strNEWCLID, string strSZFZ, string strRPID, string strDDYID, string dQXPCSJ)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strNEWLSH", OracleType.VarChar);
                pram1.Value = (object)strNEWLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strOLDCLID", OracleType.VarChar);
                pram2.Value = (object)strOLDCLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strOLDLSH", OracleType.VarChar);
                pram3.Value = (object)strOLDLSH ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nQXYY", OracleType.Number);
                pram4.Value = (object)nQXYY ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strNEWCLID", OracleType.VarChar);
                pram5.Value = (object)strNEWCLID ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram6.Value = (object)strSZFZ ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strRPID", OracleType.VarChar);
                pram7.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram8.Value = (object)strDDYID ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram9.Value = (object)DateTime.Now ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
                pram12.Value = (object)dQXPCSJ ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nFLAG", OracleType.Number);
                pram10.Value = 0;
                pram10.Direction = ParameterDirection.Output;
                OracleParameter pram11 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram11.Value = "";
                pram11.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[12] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram12, pram10, pram11 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_REASSIGNMENT", CommandType.StoredProcedure, pms);
                List<SP_GET_AMBUL_OUTD_INFO> items = new List<SP_GET_AMBUL_OUTD_INFO>();
                if (rows == 1)
                {
                    items = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from V_AMBUL_OUTD_INFO  where LSH='" + strOLDLSH + "' ", CommandType.Text, null);
                }
                return items;
            }
            catch (System.Exception)
            {
                return new List<SP_GET_AMBUL_OUTD_INFO>();
            }
        }

        public static bool SP_UPDATE_CALL_MULTIPLE_END(string strLSH, string dGJSJ)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("dGJSJ", OracleType.DateTime);
                pram2.Value = (object)dGJSJ ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CALL_MULTIPLE_END", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 中心取消派车
        /// </summary>
        /// <param name="strLSH"></param>
        /// <param name="strCLID"></param>
        /// <param name="nQXYY"></param>
        /// <param name="nCLZT"></param>
        /// <param name="dQXPCSJ"></param>
        /// <returns></returns>
        public static bool SP_UPDATE_CANCLED(string strLSH, string strCLID, string nQXYY, string nCLZT, string dQXPCSJ)
        {
            try
            {
                if (!string.IsNullOrEmpty(nQXYY))
                {
                    string[] qxs = nQXYY.Split(':');
                    if (qxs.Length == 2)
                    {
                        nQXYY = qxs[0];
                        OracleHelper.ExecuteNonQuery("update ambul_outd_info set ISZXQXPC=" + qxs[1] + " where lsh='" + strLSH + "' and clid='" + strCLID + "'", CommandType.Text, null);
                    }
                }
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
                pram2.Value = (object)strCLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nQXYY", OracleType.Number);
                pram3.Value = (object)nQXYY ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nCLZT", OracleType.Number);
                pram6.Value = (object)nCLZT ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("dQXPCSJ", OracleType.DateTime);
                pram7.Value = (object)dQXPCSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nFLAG", OracleType.Number);
                pram4.Value = 0;
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram5.Value = "";
                pram5.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[7] { pram1, pram2, pram3, pram6, pram7, pram4, pram5 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_CANCLED", CommandType.StoredProcedure, pms);
                return (rows == 1) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<P_PRES_ACCEPT_INFO> SP_GET_EVENT_ACCEPT_INFO(string strSJH)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)strSJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("ZIT_RP_ACCEPT_PKG.SP_GET_EVENT_ACCEPT_INFO", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        public static IList<SYS_MEMBER_INFO> Check_Sys_Member_Info(string id, string password)
        {
            try
            {
                return OracleHelper.ExecuteList<SYS_MEMBER_INFO>(" select * FROM v_member_info  where ID='" + id + "' and PASSWORD='" + password + "'", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static Marjor_Report Get_Marjor_Report_BY_LSH(string lsh)
        {
            try
            {
                Marjor_Report item = new Marjor_Report();
                item.ReportInfo = OracleHelper.ExecuteEntity<Report>(" select * FROM V_MAJOR_ACCIDENT_REPORT where LSH='" + lsh + "'", CommandType.Text, null);
                if (item.ReportInfo != null && !string.IsNullOrEmpty(item.ReportInfo.SJH))
                {
                    item.HZXX = OracleHelper.ExecuteList<HZXXINfo>("select * from V_HZXX where lsh='" + lsh + "'", CommandType.Text, null);
                    item.CCXX = OracleHelper.ExecuteList<Report_Ambul>("select * from V_report_ambul where lsh='" + lsh + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception e)
            {
                return new Marjor_Report();
            }
        }

        public static V_MAJOR_ACCIDENT Get_V_MAJOR_ACCIDENT_BY_SJH(string sjh)
        {
            try
            {
                return OracleHelper.ExecuteEntity<V_MAJOR_ACCIDENT>(" select * FROM V_MAJOR_ACCIDENT where SJH='" + sjh + "'", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new V_MAJOR_ACCIDENT();
            }
        }

        public static IList<V_MAJOR_ACCIDENT> Get_V_MAJOR_ACCIDENT()
        {
            try
            {
                return OracleHelper.ExecuteList<V_MAJOR_ACCIDENT>(" select * FROM V_MAJOR_ACCIDENT", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_MAJOR_ACCIDENT>();
            }
        }

        public static IList<V_MEMBER_INFO> Get_V_MEMBER_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_MEMBER_INFO>(" select * FROM V_MEMBER_INFO", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_MEMBER_INFO>();
            }
        }

        public static IList<V_MEMBER_INFO> Get_V_MEMBER_MAJOR_ACCIDENT_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_MEMBER_INFO>(" select * FROM V_MEMBER_MAJOR_ACCIDENT", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_MEMBER_INFO>();
            }
        }

        public static IList<V_RP_INFO> Get_V_RP_INFO()
        {
            try
            {
                return OracleHelper.ExecuteList<V_RP_INFO>(" select * FROM V_RP_INFO", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_RP_INFO>();
            }
        }

        public static IList<V_Phone_Number> Get_ORG_PHONE()
        {
            try
            {
                return OracleHelper.ExecuteList<V_Phone_Number>(" select * FROM V_PHONE_NUMBER order by name ", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_Phone_Number>();
            }
        }

        public static IList<V_EVENT_BELONG> Get_V_EVENT_BELONG_BY_SJH(string sjh)
        {
            try
            {
                return OracleHelper.ExecuteList<V_EVENT_BELONG>("select * from V_EVENT_BELONG where glid =(select glid from V_EVENT_BELONG t where sjh='" + sjh + "')", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_EVENT_BELONG>();
            }
        }

        public static IList<V_EVENT_BELONG> Get_V_EVENT_BELONG()
        {
            try
            {
                return OracleHelper.ExecuteList<V_EVENT_BELONG>(" select * FROM V_EVENT_BELONG", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_EVENT_BELONG>();
            }
        }

        public static V_CLXQXX Get_ALL_V_CLXQXX_ById(string clid)
        {
            try
            {
                return OracleHelper.ExecuteEntity<V_CLXQXX>("select * from V_CLXQXX where clid='" + clid + "'", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new V_CLXQXX();
            }
        }

        public static IList<V_CLXQXX> Get_ALL_V_CLXQXX()
        {
            try
            {
                return OracleHelper.ExecuteList<V_CLXQXX>("select * from V_CLXQXX", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_CLXQXX>();
            }
        }

        public static IList<V_RPJK> Get_V_RPJK()
        {
            try
            {
                return OracleHelper.ExecuteList<V_RPJK>("select * from V_RPJK", CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                return new List<V_RPJK>();
            }
        }


        public static string FN_GETMAXLSH()
        {
            try
            {
                object result = OracleHelper.GetSingle("select  FN_GETMAXLSH from dual");
                return (result == null) ? "" : result.ToString();
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public static string Get_Dispatch_DDFZ(string strLsh)
        {
            try
            {
                object result = OracleHelper.GetSingle("select  ddfz  from dispatch_info where lsh='" + strLsh + "' and ZT=0 and rownum=1");
                return (result == null) ? "" : result.ToString();
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public static string Get_CLIDXH(string strLsh, string strTel)
        {
            try
            {

                strLsh = strLsh.Split(':')[0];
                object result = OracleHelper.GetSingle(string.Format("select  FN_GetCLIDXH('{0}','{1}') from dual", strLsh, strTel));
                return (result == null) ? "" : result.ToString();
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public static string FN_GET_GLLSH(string strNewLsh)
        {
            try
            {
                //object result = OracleHelper.GetSingle(string.Format("select  ZIT_RP_ACCEPT_PKG.FN_GET_GLLSH('{0}') from dual", strNewLsh));
                //return (result == null) ? "" : result.ToString();
                return strNewLsh;
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public static string FN_GetFZUUIDByTel(string ptel)
        {
            try
            {
                object result = OracleHelper.GetSingle(string.Format("select  FN_GetFZUUIDByTel('{0}') from dual", ptel));
                if (result != null)
                {

                }
                return (result == null) ? "" : result.ToString();
                //return OracleHelper.ExecuteEntity<string>(string.Format("select  FN_GetFZUUIDByTel('{0}') from dual", ptel), CommandType.Text, null);
            }
            catch (System.Exception e)
            {
                throw;
            }
        }


        public static Ambul_AcceptInfo UpdateAcceptInfo(ACCEPT_INFO info, string clid)
        {
            try
            {
                if (!string.IsNullOrEmpty(clid))
                {
                    OracleHelper.ExecuteNonQuery("update ambul_outd_info set swdd='" + info.SWDD + "' where lsh='" + info.LSH + "' and clid='" + clid + "'", CommandType.Text, null);
                }
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 1000);
                pram1.Value = (object)info.LSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strRPID", OracleType.VarChar);
                pram2.Value = (object)info.RPID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram3.Value = (object)info.DDYID ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSJH", OracleType.VarChar);
                pram4.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("nSLZT", OracleType.Number);
                pram6.Value = (object)info.SLZT ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("nSLLY", OracleType.Number);
                pram7.Value = (object)info.SLLY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nSLLX", OracleType.Number);
                pram8.Value = (object)info.SLLX ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nHJZ", OracleType.Number);
                pram9.Value = (object)info.HJZ ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nHJZLX", OracleType.Number);
                pram10.Value = (object)info.HJZLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGLX", OracleType.Number);
                pram11.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("nHJYYKB", OracleType.Number);
                pram12.Value = (object)info.HJYYKB ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("nHJYYZS", OracleType.Number);
                pram13.Value = (object)info.HJYYZS ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nHJYYZZ", OracleType.Number);
                pram14.Value = (object)info.HJYYZZ ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("strHJYYBC", OracleType.VarChar);
                pram15.Value = (object)info.HJYYBC ?? DBNull.Value;
                OracleParameter pram16 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram16.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram17 = new OracleParameter("strJCDZ", OracleType.VarChar);
                pram17.Value = (object)info.JCDZ ?? DBNull.Value;
                OracleParameter pram18 = new OracleParameter("nHJQY", OracleType.Number);
                pram18.Value = (object)info.HJQY ?? DBNull.Value;
                OracleParameter pram19 = new OracleParameter("strGXYY", OracleType.VarChar);
                pram19.Value = (object)info.GXYY ?? DBNull.Value;
                OracleParameter pram20 = new OracleParameter("strLXR", OracleType.VarChar);
                pram20.Value = (object)info.LXR ?? DBNull.Value;
                OracleParameter pram21 = new OracleParameter("strLXDH", OracleType.VarChar);
                pram21.Value = (object)info.LXDH ?? DBNull.Value;
                OracleParameter pram38 = new OracleParameter("nHZRS", OracleType.Number);
                pram38.Value = (object)info.HZRS ?? DBNull.Value;
                OracleParameter pram22 = new OracleParameter("strSWYY", OracleType.VarChar);
                pram22.Value = (object)info.SWYY ?? DBNull.Value;
                OracleParameter pram23 = new OracleParameter("strSWDD", OracleType.VarChar);
                pram23.Value = (object)info.SWDD ?? DBNull.Value;
                OracleParameter pram24 = new OracleParameter("strHZXM", OracleType.VarChar);
                pram24.Value = (object)info.HZXM ?? DBNull.Value;
                OracleParameter pram25 = new OracleParameter("nHZXB", OracleType.Number);
                pram25.Value = (object)info.HZXB ?? DBNull.Value;
                OracleParameter pram26 = new OracleParameter("nNL", OracleType.Number);
                pram26.Value = (object)info.NL ?? DBNull.Value;
                OracleParameter pram27 = new OracleParameter("nMZ", OracleType.Number);
                pram27.Value = (object)info.MZ ?? DBNull.Value;
                OracleParameter pram28 = new OracleParameter("nGJ", OracleType.Number);
                pram28.Value = (object)info.GJ ?? DBNull.Value;
                OracleParameter pram29 = new OracleParameter("nSQCD", OracleType.Number);
                pram29.Value = (object)info.SQCD ?? DBNull.Value;
                OracleParameter pram30 = new OracleParameter("nTSYQ", OracleType.Number);
                pram30.Value = (object)info.TSYQ ?? DBNull.Value;
                OracleParameter pram31 = new OracleParameter("nTQ", OracleType.Number);
                pram31.Value = (object)info.TQ ?? DBNull.Value;
                OracleParameter pram32 = new OracleParameter("nLK", OracleType.Number);
                pram32.Value = (object)info.LK ?? DBNull.Value;
                OracleParameter pram33 = new OracleParameter("strBZ", OracleType.VarChar);
                pram33.Value = (object)info.BZ ?? DBNull.Value;
                OracleParameter pram34 = new OracleParameter("nSFCS", OracleType.Number);
                pram34.Value = (object)info.SFCS ?? DBNull.Value;
                OracleParameter pram35 = new OracleParameter("nXZBM", OracleType.Number);
                pram35.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram45 = new OracleParameter("nZZLX", OracleType.Number);
                pram45.Value = (object)info.ZZLX ?? DBNull.Value;
                OracleParameter pram36 = new OracleParameter("nIS_CKOUT", OracleType.Number);
                pram36.Value = (object)info.IS_CKOUT ?? DBNull.Value;
                OracleParameter pram37 = new OracleParameter("strSZKS", OracleType.VarChar);
                pram37.Value = (object)info.SZKS ?? DBNull.Value;
                OracleParameter pram39 = new OracleParameter("strMQZD", OracleType.VarChar);
                pram39.Value = (object)info.MQZD ?? DBNull.Value;
                OracleParameter pram40 = new OracleParameter("strYBHGX", OracleType.VarChar);
                pram40.Value = (object)info.YBHGX ?? DBNull.Value;
                OracleParameter pram41 = new OracleParameter("strGCDF", OracleType.VarChar);
                pram41.Value = (object)info.GCDF ?? DBNull.Value;
                OracleParameter pram42 = new OracleParameter("strGCDFYJ", OracleType.VarChar);
                pram42.Value = (object)info.GCDFYJ ?? DBNull.Value;
                OracleParameter pram46 = new OracleParameter("strTSYQ", OracleType.VarChar);
                pram46.Value = (object)info.TSYQSM ?? DBNull.Value;
                OracleParameter pram43 = new OracleParameter("nFLAG", OracleType.Number);
                pram43.Value = 0;
                pram43.Direction = ParameterDirection.Output;
                OracleParameter pram44 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram44.Value = "";
                pram44.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[46] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16, pram17, pram18, pram19, pram20, pram21, pram38,pram22
                , pram23, pram24, pram25, pram26, pram27, pram28, pram29, pram30, pram31
                , pram32, pram33, pram34, pram35, pram45, pram36, pram37, pram39, pram40, pram41, pram42, pram46, pram43, pram44};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_ACCEPT_INFO", CommandType.StoredProcedure, pms);
                Ambul_AcceptInfo result = new Ambul_AcceptInfo();
                if (rows > 0)
                {
                    result.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from v_all_Accept_Info where LSH='" + info.LSH + "'", CommandType.Text, null);
                    result.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from v_all_Ambul_Outd_Info where LSH='" + info.LSH + "'", CommandType.Text, null);
                    result.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_all_SJLB where SJH='" + info.SJH + "'", CommandType.Text, null);
                    if (info.HZRS >= 3)
                    {
                        OracleHelper.ExecuteNonQuery("update accept_info set sglx=20 where lsh='" + info.LSH + "'", CommandType.Text, null);
                    }
                }
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static EventAboutInfo UpdateEventInfo_And_Return_AboutInfo(EVENT_INFO info)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strSJH", OracleType.VarChar);
                pram1.Value = (object)info.SJH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nSTATUS", OracleType.Number);
                pram2.Value = (object)info.STATUS ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("dSCLDSJ", OracleType.DateTime);
                pram3.Value = (object)info.SCLDSJ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strSCLDHM", OracleType.VarChar);
                pram4.Value = (object)info.SCLDHM ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dSCSLSJ", OracleType.DateTime);
                pram5.Value = (object)info.SCSLSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strSCSLRPID", OracleType.VarChar);
                pram6.Value = (object)info.SCSLRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strSCDDY", OracleType.VarChar);
                pram7.Value = (object)info.SCDDY ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("strHCYY", OracleType.VarChar);
                pram8.Value = (object)info.HCYY ?? DBNull.Value;
                OracleParameter pram9 = new OracleParameter("nSJLX", OracleType.Number);
                pram9.Value = (object)info.SJLX ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("nSGLX", OracleType.Number);
                pram10.Value = (object)info.SGLX ?? DBNull.Value;
                OracleParameter pram11 = new OracleParameter("nSGDJ", OracleType.Number);
                pram11.Value = (object)info.SGDJ ?? DBNull.Value;
                OracleParameter pram12 = new OracleParameter("strXCDZ", OracleType.VarChar);
                pram12.Value = (object)info.XCDZ ?? DBNull.Value;
                OracleParameter pram13 = new OracleParameter("mFLAG", OracleType.Number);
                pram13.Value = (object)info.FLAG ?? DBNull.Value;
                OracleParameter pram14 = new OracleParameter("nXZBM", OracleType.Number);
                pram14.Value = (object)info.XZBM ?? DBNull.Value;
                OracleParameter pram15 = new OracleParameter("nFLAG", OracleType.Number);
                pram15.Value = 0;
                pram15.Direction = ParameterDirection.Output;
                OracleParameter pram16 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram16.Value = "";
                pram16.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[16] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10, pram11, pram12, pram13
                , pram14, pram15, pram16};

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_UPDATE_EVENT_INFO", CommandType.StoredProcedure, pms);
                EventAboutInfo result = new EventAboutInfo() { EventInfo = info };
                if (rows == 1)
                {
                    result.SjlbInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from V_SJLB where SJH='" + info.SJH + "'", CommandType.Text, null);
                    result.Result = true;
                }
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static CCXX_CLXQ_INFO GET_CCXX_CLXQ_INFO_BY_LSH_CLID(string lsh, string clid)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                StringBuilder clsql = new StringBuilder();
                sql.Append("select * from V_all_AMBUL_OUTD_INFO where ");
                clsql.Append("select * from V_CLXQXX where ");
                if (string.IsNullOrEmpty(lsh))
                {
                    sql.Append("LSH is null");
                }
                else
                {
                    sql.Append("LSH='" + lsh + "'");
                }
                if (string.IsNullOrEmpty(clid))
                {
                    sql.Append(" and CLID is null");
                    clsql.Append(" CLID is null");
                }
                else
                {
                    sql.Append("and CLID='" + clid + "'");
                    clsql.Append("CLID='" + clid + "'");
                }
                CCXX_CLXQ_INFO result = new CCXX_CLXQ_INFO();
                result.Ambul_Info_List = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>(sql.ToString(), CommandType.Text, null);
                result.Clxq = OracleHelper.ExecuteEntity<V_CLXQXX>(clsql.ToString(), CommandType.Text, null);
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static LshAboutInfo Get_LshAbuotInfo_ByLsh(string lsh)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)lsh ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };
                LshAboutInfo item = new LshAboutInfo();
                item.Accept_list = OracleHelper.ExecuteList<P_PRES_ACCEPT_INFO>("select * from  V_ACCEPT_INFO  where LSH='" + lsh + "'", CommandType.Text, null);
                item.Ambul_outd_info_list = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select *  from V_AMBUL_OUTD_INFO  where LSH='" + lsh + "'", CommandType.Text, null);
                if (item.Accept_list != null && item.Accept_list.Count > 0)
                {
                    item.Sjlb_List = OracleHelper.ExecuteList<V_SJLB>("select *  from V_SJLB  where SJH='" + item.Accept_list[0].SJH + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        #region 分站

        public static IList<FZ_BUS_INFO> SP_GET_FZ_CLZT(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = strFZID;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<FZ_BUS_INFO>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_CLZT", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<FZ_DISPATCH_INFO> SP_GET_FZ_JCDZ(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = strFZID;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<FZ_DISPATCH_INFO>("zit_fz_accept_pkg.SP_GET_FZ_JCDZ", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 插入调度表
        /// </summary>
        /// <param name="strLSH"></param>
        /// <param name="nDDLB"></param>
        /// <param name="nDDLX"></param>
        /// <param name="strDDFZ"></param>
        /// <param name="strDDCL"></param>
        /// <param name="strFBR"></param>
        /// <param name="strRPID"></param>
        /// <returns></returns>
        public static int SP_INSERT_DISPATCH(string strLSH, string nDDLB, string nDDLX, string strDDFZ, string strDDCL, string strFBR, string strRPID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nDDLB", OracleType.Number);
                pram2.Value = (object)nDDLB ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nDDLX", OracleType.Number);
                pram3.Value = (object)nDDLX ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("strDDFZ", OracleType.VarChar);
                pram4.Value = (object)strDDFZ ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("strDDCL", OracleType.VarChar);
                pram5.Value = (object)strDDCL ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strFBR", OracleType.VarChar);
                pram6.Value = (object)strFBR ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strRPID", OracleType.VarChar);
                pram7.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
                pram8.Value = 0;
                pram8.Direction = ParameterDirection.Output;
                OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram9.Value = "";
                pram9.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[9] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_DISPATCH", CommandType.StoredProcedure, pms);
                if (rows > 0)
                {
                    object result = OracleHelper.GetSingle("select  count(*)  from dispatch_info where lsh='" + strLSH + "'");
                    return Convert.ToInt32(result.ToString());
                }
                return rows;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_FZ_DISPATCH(string strLSH, string nDDLX, string strQRR)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nDDLX", OracleType.Number);
                pram2.Value = (object)nDDLX ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strQRR", OracleType.VarChar);
                pram3.Value = (object)strQRR ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nFLAG", OracleType.Number);
                pram4.Value = 0;
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram5.Value = "";
                pram5.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[5] { pram1, pram2, pram3, pram4, pram5 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_FZ_ACCEPT_PKG.SP_UPDATE_FZ_DISPATCH", CommandType.StoredProcedure, pms);
                return (rows > 0) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_FZ_CLDJ(string strCLID, string nCLDJ)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strCLID", OracleType.VarChar);
                pram1.Value = (object)strCLID ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("nCLDJ", OracleType.Number);
                pram2.Value = (object)nCLDJ ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_FZ_ACCEPT_PKG.SP_UPDATE_FZ_CLDJ", CommandType.StoredProcedure, pms);
                return (rows > 0) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<SP_GET_PRANK_CALL_HIS> SP_GET_PRANK_CALL_HIS(string strHM)
        {
            try
            {
                List<SP_GET_PRANK_CALL_HIS> call_list = new List<SP_GET_PRANK_CALL_HIS>();
                if (!string.IsNullOrEmpty(strHM))
                {
                    List<PRANK_CALL> list = OracleHelper.ExecuteList<PRANK_CALL>("select * from PRANK_CALL  where HM='" + strHM + "' order by bjsj desc", CommandType.Text, null);
                    if (list != null && list.Count > 0)
                    {
                        SP_GET_PRANK_CALL_HIS item = new SP_GET_PRANK_CALL_HIS();
                        item.V_BJCS = list.Count.ToString();
                        item.V_SCBJSJ = list[0].SDSJ;
                        item.PhoneNumber = strHM;
                        item.V_SDSC = list[0].SDSC.ToString();
                        item.IsLock = list[0].SFSD.ToString();
                        call_list.Add(item);
                    }
                }
                else
                {
                    List<PRANK_CALL> list = OracleHelper.ExecuteList<PRANK_CALL>("select * from PRANK_CALL  order by bjsj desc", CommandType.Text, null);
                    if (list != null && list.Count > 0)
                    {
                        IEnumerable<IGrouping<string, PRANK_CALL>> query = list.GroupBy(p => p.HM);
                        foreach (IGrouping<string, PRANK_CALL> info in query)
                        {
                            List<PRANK_CALL> sl = info.ToList<PRANK_CALL>();//分组后的集合
                            foreach (PRANK_CALL item2 in sl)
                            {
                                SP_GET_PRANK_CALL_HIS item = new SP_GET_PRANK_CALL_HIS();
                                item.V_BJCS = sl.Count.ToString();
                                item.V_SCBJSJ = item2.BJSJ;
                                item.PhoneNumber = item2.HM;
                                item.V_SDSC = Convert.ToInt32(item2.SDSC).ToString();
                                item.IsLock = Convert.ToInt32(item2.SFSD).ToString();
                                TimeSpan span = (DateTime.Now.Subtract(item2.SDSJ));
                                if (span.TotalSeconds < Convert.ToDouble(item2.SDSC))
                                {
                                    call_list.Add(item);
                                }
                                break;
                            }
                        }
                    }
                }
                return call_list;
                //OracleParameter pram1 = new OracleParameter("strHM", OracleType.VarChar);
                //pram1.Value = strHM;
                //OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                //pram2.Value = "";
                //pram2.Direction = ParameterDirection.Output;
                //OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                //pram3.Value = 0;
                //pram3.Direction = ParameterDirection.Output;
                //OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                //pram4.Value = "";
                //pram4.Direction = ParameterDirection.Output;
                //OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };
                //return OracleHelper.ExecuteList<SP_GET_PRANK_CALL_HIS>("ZIT_RP_ACCEPT_PKG.SP_GET_PRANK_CALL_HIS", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static IList<FZ_ACCEPT_INFO> SP_GET_FZ_ACCEPT_INFO(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = strFZID;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };
                return OracleHelper.ExecuteList<FZ_ACCEPT_INFO>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_ACCEPT_INFO", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static IList<FZ_ACCEPT_INFO> SP_GET_FZ_CCXX(string strLSH)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteList<FZ_ACCEPT_INFO>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_CCXX    ", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static bool SP_UPDATE_FZ_CANCLED(string strCLID, string nQXYY, string nGPBZ)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strCLID", OracleType.VarChar);
                pram1.Value = strCLID;
                OracleParameter pram2 = new OracleParameter("nQXYY", OracleType.Number);
                pram2.Value = nQXYY;
                OracleParameter pram3 = new OracleParameter("nGPBZ", OracleType.Number);
                pram3.Value = nGPBZ;
                OracleParameter pram4 = new OracleParameter("nFLAG", OracleType.Number);
                pram4.Value = 0;
                pram4.Direction = ParameterDirection.Output;
                OracleParameter pram5 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram5.Value = "";
                pram5.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[5] { pram1, pram2, pram3, pram4, pram5 };
                int rows = OracleHelper.ExecuteNonQuery("ZIT_FZ_ACCEPT_PKG.SP_UPDATE_FZ_CANCLED", CommandType.StoredProcedure, pms);
                return (rows > 0) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static Ambul_AcceptInfo SP_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string strSJH, string swdd)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 3000);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
                pram2.Value = (object)strCLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram3.Value = (object)strSZFZ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nPCLX", OracleType.Number);
                pram4.Value = (object)nPCLX ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram5.Value = (object)dPCSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strRPID", OracleType.VarChar);
                pram6.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram7.Value = (object)strDDYID ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strSJH", OracleType.VarChar);
                pram10.Value = (object)strSJH ?? DBNull.Value;

                OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
                pram8.Value = 0;
                pram8.Direction = ParameterDirection.Output;
                OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram9.Value = "";
                pram9.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[10] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_AMBUL_OUTD", CommandType.StoredProcedure, pms);
                Ambul_AcceptInfo item = new Ambul_AcceptInfo();
                if (rows == 1)
                {
                    if (!string.IsNullOrEmpty(strCLID) && !string.IsNullOrEmpty(swdd))
                    {
                        string[] cls = strCLID.Split(',');
                        for (int i = 0; i < cls.Length; i++)
                        {
                            OracleHelper.ExecuteNonQuery("update ambul_outd_info set swdd='" + swdd + "' where lsh='" + strLSH + "' and clid='" + cls[i] + "'", CommandType.Text, null);
                        }
                    }
                    OracleHelper.ExecuteNonQuery("update EVENT_INFO set status=0  where sjh='" + strSJH + "'", CommandType.Text, null);


                    item.AmbulInfoList = OracleHelper.ExecuteList<SP_GET_AMBUL_OUTD_INFO>("select * from  V_ALL_AMBUL_OUTD_INFO where lsh='" + strLSH + "'", CommandType.Text, null);
                    item.EventInfo = OracleHelper.ExecuteEntity<V_SJLB>("select * from  V_all_SJLB where sjh='" + strSJH + "'", CommandType.Text, null);
                    item.Acceptlnfo = OracleHelper.ExecuteEntity<P_PRES_ACCEPT_INFO>("select * from  v_All_Accept_Info where lsh='" + strLSH + "'", CommandType.Text, null);
                }
                return item;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public static bool SP_FZ_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string strSJH, string swdd)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strLSH", OracleType.VarChar, 3000);
                pram1.Value = (object)strLSH ?? DBNull.Value;
                OracleParameter pram2 = new OracleParameter("strCLID", OracleType.VarChar);
                pram2.Value = (object)strCLID ?? DBNull.Value;
                OracleParameter pram3 = new OracleParameter("strSZFZ", OracleType.VarChar);
                pram3.Value = (object)strSZFZ ?? DBNull.Value;
                OracleParameter pram4 = new OracleParameter("nPCLX", OracleType.Number);
                pram4.Value = (object)nPCLX ?? DBNull.Value;
                OracleParameter pram5 = new OracleParameter("dPCSJ", OracleType.DateTime);
                pram5.Value = (object)dPCSJ ?? DBNull.Value;
                OracleParameter pram6 = new OracleParameter("strRPID", OracleType.VarChar);
                pram6.Value = (object)strRPID ?? DBNull.Value;
                OracleParameter pram7 = new OracleParameter("strDDYID", OracleType.VarChar);
                pram7.Value = (object)strDDYID ?? DBNull.Value;
                OracleParameter pram10 = new OracleParameter("strSJH", OracleType.VarChar);
                pram10.Value = (object)strSJH ?? DBNull.Value;

                OracleParameter pram8 = new OracleParameter("nFLAG", OracleType.Number);
                pram8.Value = 0;
                pram8.Direction = ParameterDirection.Output;
                OracleParameter pram9 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram9.Value = "";
                pram9.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[10] { pram1, pram2, pram3, pram4, pram5, pram6, pram7, pram8, pram9, pram10 };

                int rows = OracleHelper.ExecuteNonQuery("ZIT_RP_ACCEPT_PKG.SP_INSERT_AMBUL_OUTD", CommandType.StoredProcedure, pms);
                if (rows == 1)
                {
                    if (!string.IsNullOrEmpty(strCLID) && !string.IsNullOrEmpty(swdd))
                    {
                        string[] cls = strCLID.Split(',');
                        for (int i = 0; i < cls.Length; i++)
                        {
                            OracleHelper.ExecuteNonQuery("update ambul_outd_info set swdd='" + swdd + "' where lsh='" + strLSH + "' and clid='" + cls[i] + "'", CommandType.Text, null);
                        }
                        object discount = OracleHelper.GetSingle("select count(*) from dispatch_info where ddfz='" + strSZFZ + "' and lsh='" + strLSH + "'");
                        if (discount != null)
                        {
                            for (int i = 1; i < Convert.ToInt32(discount) + 1; i++)
                            {
                                if (cls.Length > i - 1)//
                                {
                                    OracleHelper.GetSingle("update dispatch_info set clid='" + cls[i - 1] + "' where lsh='" + strLSH + "'and ddfz='" + strSZFZ + "' and ddxh=" + i);
                                }
                            }
                        }
                    }
                    OracleHelper.ExecuteNonQuery("update EVENT_INFO set status=0  where sjh='" + strSJH + "'", CommandType.Text, null);
                }
                return (rows == 1) ? true : false; ;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public static string SP_GET_FZ_LX(string strFZID)
        {
            try
            {
                OracleParameter pram1 = new OracleParameter("strFZID", OracleType.VarChar);
                pram1.Value = strFZID;
                OracleParameter pram2 = new OracleParameter("RESULT", OracleType.Cursor);
                pram2.Value = "";
                pram2.Direction = ParameterDirection.Output;
                OracleParameter pram3 = new OracleParameter("nFLAG", OracleType.Number);
                pram3.Value = 0;
                pram3.Direction = ParameterDirection.Output;
                OracleParameter pram4 = new OracleParameter("errMSG", OracleType.VarChar, 4000);
                pram4.Value = "";
                pram4.Direction = ParameterDirection.Output;
                OracleParameter[] pms = new OracleParameter[4] { pram1, pram2, pram3, pram4 };

                return OracleHelper.ExecuteEntity<string>("ZIT_FZ_ACCEPT_PKG.SP_GET_FZ_LX", CommandType.StoredProcedure, pms);
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 批量处理轨迹数据
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static int BatchInsert(List<AMBUL_TRAC> lst)
        {
            try
            {
                List<AMBUL_TRAC> lst_ = lst.OrderByDescending(p => p.ZHFSSJ).Distinct(p => p.CZHM).ToList();
                if (lst_ != null && lst_.Count > 0)
                {
                    StringBuilder params_ = new StringBuilder();
                    for (int i = 0; i < lst_.Count; i++)
                    {
                        params_.Append("  clid=( select clid from V_clxqxx a where a.czdh='" + lst_[i].CZHM + "') or");
                    }
                    if (!string.IsNullOrEmpty(params_.ToString()))
                    {
                        OracleHelper.ExecuteNonQuery("delete NB120GPS.AMBUL_TRAC  where " + params_.ToString().Substring(0, params_.Length - 2), CommandType.Text, null);
                    }

                    List<AMBUL_TRAC> lst_split2 = new List<AMBUL_TRAC>();
                    for (int j = lst_.Count - 1; j >= 0; j--)
                    {
                        lst_split2.Add(lst_[j]);
                        if (lst_split2.Count == 20)
                        {
                            OracleHelper.BatchInsert2(lst_split2);
                            lst_split2.Clear();
                        }
                        if (j == 0 && lst_split2.Count > 0)
                        {
                            OracleHelper.BatchInsert2(lst_split2);
                            lst_split2.Clear();
                        }
                    }
                }

                List<AMBUL_TRAC> lst_split = new List<AMBUL_TRAC>();
                for (int j = lst.Count - 1; j >= 0; j--)
                {
                    lst_split.Add(lst[j]);
                    if (lst_split.Count == 20)
                    {
                        OracleHelper.BatchInsert(lst_split);
                        lst_split.Clear();
                    }
                    if (j == 0 && lst_split.Count > 0)
                    {
                        OracleHelper.BatchInsert(lst_split);
                        lst_split.Clear();
                    }
                }

                //Dictionary<string, object[]> datas = new Dictionary<string, object[]>();
                //int len = lst.Count;
                //object[] clids = new object[len];
                //object[] clzts = new object[len];
                //object[] zhfssj = new object[len];
                //object[] dxddsj = new object[len];
                //object[] xslcs = new object[len];
                //object[] sds = new object[len];
                //object[] fxs = new object[len];
                //object[] gps_xs = new object[len];
                //object[] gps_ys = new object[len];
                //object[] lsh = new object[len];
                //object[] gzxss = new object[len];
                //object[] kjxss = new object[len];
                //object[] bjs = new object[len];
                //object[] txzts = new object[len];

                //for (int j = 0; j < lst.Count; j++)
                //{
                //    clids[j] = lst[j].CZHM;
                //    clzts[j] = 0;
                //    zhfssj[j] = lst[j].ZHFSSJ;
                //    dxddsj[j] = lst[j].DXDDSJ;
                //    xslcs[j] = lst[j].XSLC;
                //    sds[j] = lst[j].SD;
                //    fxs[j] = lst[j].FX;
                //    gps_xs[j] = lst[j].GPS_X;
                //    gps_ys[j] = lst[j].GPS_Y;
                //    lsh[j] = lst[j].LSH;
                //    gzxss[j] = lst[j].GZXS;
                //    kjxss[j] = lst[j].KJXS;
                //    bjs[j] = lst[j].BJ;
                //    txzts[j] = lst[j].TXZT;
                //}

                //datas.Add("CLID", clids);
                //datas.Add("CLZT", clzts);
                //datas.Add("ZHFSSJ", zhfssj);
                //datas.Add("DXDDSJ", dxddsj);
                //datas.Add("XSLC", xslcs);
                //datas.Add("SD", sds);
                //datas.Add("FX", fxs);
                //datas.Add("GPS_X", gps_xs);
                //datas.Add("GPS_Y", gps_ys);
                //datas.Add("LSH", lsh);
                //datas.Add("GZXS", gzxss);
                //datas.Add("KJXS", kjxss);
                //datas.Add("BJ", bjs);
                //datas.Add("TXZT", txzts);
                return 0;
                //DbHelperOra.BatchInsert("NB120GPS.AMBUL_TRAC", datas);
                //return DbHelperOra.BatchInsert("NB120GPS.AMBUL_TRAC_HIS", datas);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion
    }
}