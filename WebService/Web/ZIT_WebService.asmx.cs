using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Web.Model;

namespace Web
{
    /// <summary>
    /// ZIT_WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ZIT_WebService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_CODE_HJYY()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_CODE_HJYY>> dpsj_list = new DataResult<List<V_CODE_HJYY>>();
                dpsj_list.resultData = (List<V_CODE_HJYY>)InfoBll.Instance.Get_V_CODE_HJYY();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CODE_HJYY>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_CODE_HJYY>> dpsj_list = new DataResult<List<V_CODE_HJYY>>();
                dpsj_list.resultData = null;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<V_CODE_HJYY>>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_ReasonList()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_Reason>> dpsj_list = new DataResult<List<V_Reason>>();
                dpsj_list.resultData = (List<V_Reason>)InfoBll.Instance.Get_ReasonList();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_Reason>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_Reason>> dpsj_list = new DataResult<List<V_Reason>>();
                dpsj_list.resultData = null;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<V_Reason>>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_V_CALLID_CACHE()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_CALLID_CACHE>> cllb_list = new DataResult<List<V_CALLID_CACHE>>();
                cllb_list.resultData = (List<V_CALLID_CACHE>)InfoBll.Instance.SP_GET_V_CALLID_CACHE();
                cllb_list.msg = "成功";
                cllb_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CALLID_CACHE>>>(cllb_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_CALLID_CACHE>> cllb_list = new DataResult<List<V_CALLID_CACHE>>();
                cllb_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CALLID_CACHE>>>(cllb_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_CLLB_INFO()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_CLLB>> cllb_list = new DataResult<List<V_CLLB>>();
                cllb_list.resultData = (List<V_CLLB>)InfoBll.Instance.Get_All_CLLB_INFO();
                cllb_list.msg = "成功";
                cllb_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CLLB>>>(cllb_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_CLLB>> cllb_list = new DataResult<List<V_CLLB>>();
                cllb_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CLLB>>>(cllb_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_CALL_INFO_BY_DATE_OR_Caller(string starttime, string endtime, string zjhm, string bjhm)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<CALL_INFO>> cllb_list = new DataResult<List<CALL_INFO>>();
                cllb_list.resultData = (List<CALL_INFO>)InfoBll.Instance.Get_CALL_INFO_BY_DATE_OR_Caller(starttime, endtime, zjhm, bjhm);
                cllb_list.msg = "成功";
                cllb_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<CALL_INFO>>>(cllb_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<CALL_INFO>> cllb_list = new DataResult<List<CALL_INFO>>();
                cllb_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<CALL_INFO>>>(cllb_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_ORG_INFO()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<SYS_ORG_INFO>> cllb_list = new DataResult<List<SYS_ORG_INFO>>();
                cllb_list.resultData = (List<SYS_ORG_INFO>)InfoBll.Instance.Get_All_V_ORG_INFO();
                cllb_list.msg = "成功";
                cllb_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_ORG_INFO>>>(cllb_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SYS_ORG_INFO>> cllb_list = new DataResult<List<SYS_ORG_INFO>>();
                cllb_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_ORG_INFO>>>(cllb_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_CLLB_INFO_BY_IDS(string czdhs)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<CLLB_STATUS>> cllb_list = new DataResult<List<CLLB_STATUS>>();
                cllb_list.resultData = (List<CLLB_STATUS>)InfoBll.Instance.Get_CLLB_INFO_BY_IDS(czdhs);
                cllb_list.msg = "成功";
                cllb_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<CLLB_STATUS>>>(cllb_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<CLLB_STATUS>> cllb_list = new DataResult<List<CLLB_STATUS>>();
                cllb_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<CLLB_STATUS>>>(cllb_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_SLJS_INFO()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_SLJS>> sljs_list = new DataResult<List<V_SLJS>>();
                sljs_list.resultData = (List<V_SLJS>)InfoBll.Instance.Get_All_SLJS_INFO();
                sljs_list.msg = "成功";
                sljs_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SLJS>>>(sljs_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_SLJS>> sljs_list = new DataResult<List<V_SLJS>>();
                sljs_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SLJS>>>(sljs_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_DPSJ_INFO()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_DPSJ>> dpsj_list = new DataResult<List<V_DPSJ>>();
                dpsj_list.resultData = (List<V_DPSJ>)InfoBll.Instance.Get_All_DPSJ_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_DPSJ>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_DPSJ>> dpsj_list = new DataResult<List<V_DPSJ>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_DPSJ>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_CALL_INFO_BY_DATE(string starttime, string endtime, string ddyid)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_CALLINFO>> dpsj_list = new DataResult<List<V_CALLINFO>>();
                dpsj_list.resultData = (List<V_CALLINFO>)InfoBll.Instance.Get_CALL_INFO_BY_DATE(starttime, endtime, ddyid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CALLINFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_CALLINFO>> dpsj_list = new DataResult<List<V_CALLINFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CALLINFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_SJLB_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_SJLB>> dpsj_list = new DataResult<List<V_SJLB>>();
                dpsj_list.resultData = (List<V_SJLB>)InfoBll.Instance.Get_All_V_SJLB_INFO_BY_DATE(starttime, endtime);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SJLB>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_SJLB>> dpsj_list = new DataResult<List<V_SJLB>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SJLB>>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_AMBUL_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = (List<SP_GET_AMBUL_OUTD_INFO>)InfoBll.Instance.Get_AMBUL_INFO_BY_DATE(starttime, endtime);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (List<P_PRES_ACCEPT_INFO>)InfoBll.Instance.Get_ACCEPT_INFO_BY_DATE(starttime, endtime);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_SJLB_INFO()
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<List<V_SJLB>> dpsj_list = new DataResult<List<V_SJLB>>();
                dpsj_list.resultData = (List<V_SJLB>)InfoBll.Instance.Get_All_V_SJLB_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SJLB>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_SJLB>> dpsj_list = new DataResult<List<V_SJLB>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_SJLB>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_SJLB_INFO_BY_ID(string sjh)
        {
            try
            {
                Context.Response.ContentType = "application/json";
                DataResult<EventAboutInfo> dpsj_list = new DataResult<EventAboutInfo>();
                dpsj_list.resultData = (EventAboutInfo)InfoBll.Instance.Get_All_V_SJLB_INFO_BY_ID(sjh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<EventAboutInfo>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<EventAboutInfo> dpsj_list = new DataResult<EventAboutInfo>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<EventAboutInfo>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_YGZAmbulInfoBYLSH(string lsh,string ccxh)
        {
            try
            {
                DataResult<YGZAmbulInfo> dpsj_list = new DataResult<YGZAmbulInfo>();
                dpsj_list.resultData = InfoBll.Instance.GET_YGZAmbulInfoBYLSH(lsh,ccxh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<YGZAmbulInfo>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<YGZAmbulInfo> dpsj_list = new DataResult<YGZAmbulInfo>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<YGZAmbulInfo>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_YGZAmbulInfo(string hospitalid, string hospitalname)
        {
            try
            {
                DataResult<List<YGZAmbulInfo>> dpsj_list = new DataResult<List<YGZAmbulInfo>>();
                dpsj_list.resultData = (List<YGZAmbulInfo>)InfoBll.Instance.GET_YGZAmbulInfo(hospitalid, hospitalname);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<YGZAmbulInfo>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<YGZAmbulInfo>> dpsj_list = new DataResult<List<YGZAmbulInfo>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<YGZAmbulInfo>>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_SYS_EMT_INFO(string clid)
        {
            try
            {
                DataResult<List<SYS_EMT_INFO>> dpsj_list = new DataResult<List<SYS_EMT_INFO>>();
                dpsj_list.resultData = (List<SYS_EMT_INFO>)InfoBll.Instance.GET_SYS_EMT_INFO(clid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_EMT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SYS_EMT_INFO>> dpsj_list = new DataResult<List<SYS_EMT_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_EMT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_SP_PRES_ACCEPT_INFO_BY_DATE(string starttime, string endtime)
        {
            try
            {
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (List<P_PRES_ACCEPT_INFO>)InfoBll.Instance.GET_SP_PRES_ACCEPT_INFO_BY_DATE(starttime, endtime);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_SP_PRES_ACCEPT_INFO_BY_LSH(string lsh)
        {
            try
            {
                DataResult<P_PRES_ACCEPT_INFO> dpsj_list = new DataResult<P_PRES_ACCEPT_INFO>();
                dpsj_list.resultData = InfoBll.Instance.GET_SP_PRES_ACCEPT_INFO_BY_LSH(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<P_PRES_ACCEPT_INFO>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<P_PRES_ACCEPT_INFO> dpsj_list = new DataResult<P_PRES_ACCEPT_INFO>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<P_PRES_ACCEPT_INFO>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_SP_PRES_ACCEPT_INFO(string lsh)
        {
            try
            {
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (List<P_PRES_ACCEPT_INFO>)InfoBll.Instance.GET_SP_PRES_ACCEPT_INFO(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<List<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_CALL_INFO_BY_HCLSH(string sjh, string hclsh)
        {
            try
            {
                DataResult<List<SP_GET_EVENT_CALL_INFO>> dpsj_list = new DataResult<List<SP_GET_EVENT_CALL_INFO>>();
                dpsj_list.resultData = (List<SP_GET_EVENT_CALL_INFO>)InfoBll.Instance.Get_CALL_INFO_BY_HCLSH(sjh, hclsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_EVENT_CALL_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SP_GET_EVENT_CALL_INFO>> dpsj_list = new DataResult<List<SP_GET_EVENT_CALL_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_EVENT_CALL_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_OBLIGATE_ACCEPT_INFO(string nZJHM)
        {
            try
            {
                DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>> dpsj_list = new DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>>();
                dpsj_list.resultData = (List<SP_GET_OBLIGATE_ACCEPT_INFO>)InfoBll.Instance.SP_GET_OBLIGATE_ACCEPT_INFO(nZJHM);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>> dpsj_list = new DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_OBLIGATE_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_EVENT_BELONG_BY_SJH(string sjh)
        {
            try
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = (List<V_EVENT_BELONG>)InfoBll.Instance.Get_V_EVENT_BELONG_BY_SJH(sjh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_EVENT_BELONG()
        {
            try
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = (List<V_EVENT_BELONG>)InfoBll.Instance.Get_V_EVENT_BELONG();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_MEMBER_MAJOR_ACCIDENT_INFO()
        {
            try
            {
                DataResult<List<V_MEMBER_INFO>> dpsj_list = new DataResult<List<V_MEMBER_INFO>>();
                dpsj_list.resultData = (List<V_MEMBER_INFO>)InfoBll.Instance.Get_V_MEMBER_MAJOR_ACCIDENT_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_MEMBER_INFO>> dpsj_list = new DataResult<List<V_MEMBER_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_MEMBER_INFO()
        {
            try
            {
                DataResult<List<V_MEMBER_INFO>> dpsj_list = new DataResult<List<V_MEMBER_INFO>>();
                dpsj_list.resultData = (List<V_MEMBER_INFO>)InfoBll.Instance.Get_V_MEMBER_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_MEMBER_INFO>> dpsj_list = new DataResult<List<V_MEMBER_INFO>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Marjor_Report_BY_LSH(string lsh)
        {
            try
            {
                DataResult<Marjor_Report> dpsj_list = new DataResult<Marjor_Report>();
                dpsj_list.resultData = (Marjor_Report)InfoBll.Instance.Get_Marjor_Report_BY_LSH(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<Marjor_Report>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<Marjor_Report> dpsj_list = new DataResult<Marjor_Report>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<Marjor_Report>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_MAJOR_ACCIDENT_BY_SJH(string sjh)
        {
            try
            {
                DataResult<V_MAJOR_ACCIDENT> dpsj_list = new DataResult<V_MAJOR_ACCIDENT>();
                dpsj_list.resultData = (V_MAJOR_ACCIDENT)InfoBll.Instance.Get_V_MAJOR_ACCIDENT_BY_SJH(sjh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<V_MAJOR_ACCIDENT>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<V_MAJOR_ACCIDENT> dpsj_list = new DataResult<V_MAJOR_ACCIDENT>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<V_MAJOR_ACCIDENT>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_MAJOR_ACCIDENT()
        {
            try
            {
                DataResult<List<V_MAJOR_ACCIDENT>> dpsj_list = new DataResult<List<V_MAJOR_ACCIDENT>>();
                dpsj_list.resultData = (List<V_MAJOR_ACCIDENT>)InfoBll.Instance.Get_V_MAJOR_ACCIDENT();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MAJOR_ACCIDENT>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_MAJOR_ACCIDENT>> dpsj_list = new DataResult<List<V_MAJOR_ACCIDENT>>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<List<V_MAJOR_ACCIDENT>>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_YWDDQ(string strFZID)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = InfoBll.Instance.SP_GET_FZ_YWDDQ(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Check_Sys_Member_Info(string id, string password)
        {
            try
            {
                DataResult<List<SYS_MEMBER_INFO>> dpsj_list = new DataResult<List<SYS_MEMBER_INFO>>();
                dpsj_list.resultData = (List<SYS_MEMBER_INFO>)InfoBll.Instance.Check_Sys_Member_Info(id, password);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SYS_MEMBER_INFO>> dpsj_list = new DataResult<List<SYS_MEMBER_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<SYS_MEMBER_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_ALL_V_CLXQXX()
        {
            try
            {
                DataResult<List<V_CLXQXX>> dpsj_list = new DataResult<List<V_CLXQXX>>();
                dpsj_list.resultData = (List<V_CLXQXX>)InfoBll.Instance.Get_ALL_V_CLXQXX();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CLXQXX>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_CLXQXX>> dpsj_list = new DataResult<List<V_CLXQXX>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_CLXQXX>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_V_NOTICE_INFO(string publiser)
        {
            try
            {
                DataResult<List<V_NOTICE_INFO>> dpsj_list = new DataResult<List<V_NOTICE_INFO>>();
                dpsj_list.resultData = (List<V_NOTICE_INFO>)InfoBll.Instance.SP_GET_V_NOTICE_INFO(publiser);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_NOTICE_INFO>> dpsj_list = new DataResult<List<V_NOTICE_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(dpsj_list);
                return result;
            }

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_RP_INFO()
        {
            try
            {
                DataResult<List<V_RP_INFO>> dpsj_list = new DataResult<List<V_RP_INFO>>();
                dpsj_list.resultData = (List<V_RP_INFO>)InfoBll.Instance.Get_V_RP_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_RP_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_RP_INFO>> dpsj_list = new DataResult<List<V_RP_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_RP_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_ORG_PHONE()
        {
            try
            {
                DataResult<List<V_Phone_Number>> dpsj_list = new DataResult<List<V_Phone_Number>>();
                dpsj_list.resultData = (List<V_Phone_Number>)InfoBll.Instance.Get_ORG_PHONE();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_Phone_Number>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_Phone_Number>> dpsj_list = new DataResult<List<V_Phone_Number>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_Phone_Number>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GETALL_V_NOTICE_INFO()
        {
            try
            {
                DataResult<List<V_NOTICE_INFO>> dpsj_list = new DataResult<List<V_NOTICE_INFO>>();
                dpsj_list.resultData = (List<V_NOTICE_INFO>)InfoBll.Instance.SP_GET_V_NOTICE_INFO("");
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_NOTICE_INFO>> dpsj_list = new DataResult<List<V_NOTICE_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_V_BLACK_LIST_INFO()
        {
            try
            {
                DataResult<List<V_BLACK_LIST>> dpsj_list = new DataResult<List<V_BLACK_LIST>>();
                dpsj_list.resultData = (List<V_BLACK_LIST>)InfoBll.Instance.Get_All_V_BLACK_LIST_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_BLACK_LIST>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_BLACK_LIST>> dpsj_list = new DataResult<List<V_BLACK_LIST>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_BLACK_LIST>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_All_PCJS_INFO()
        {
            try
            {
                DataResult<List<V_PCJS>> dpsj_list = new DataResult<List<V_PCJS>>();
                dpsj_list.resultData = (List<V_PCJS>)InfoBll.Instance.Get_All_PCJS_INFO();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_PCJS>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_PCJS>> dpsj_list = new DataResult<List<V_PCJS>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_PCJS>>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_ALL_V_CLXQXX_ById(string clid)
        {
            try
            {
                DataResult<V_CLXQXX> dpsj_list = new DataResult<V_CLXQXX>();
                dpsj_list.resultData = (V_CLXQXX)InfoBll.Instance.Get_ALL_V_CLXQXX_ById(clid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<V_CLXQXX>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<V_CLXQXX> dpsj_list = new DataResult<V_CLXQXX>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<V_CLXQXX>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_V_RPJK()
        {
            try
            {
                DataResult<List<V_RPJK>> dpsj_list = new DataResult<List<V_RPJK>>();
                dpsj_list.resultData = (List<V_RPJK>)InfoBll.Instance.Get_V_RPJK();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_RPJK>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_RPJK>> dpsj_list = new DataResult<List<V_RPJK>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<V_RPJK>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Update_Staff(string lx, string lsh, string ccxh, string oldid, string newid)
        {
            try
            {
                bool result = InfoBll.Instance.Update_Staff(lx, lsh, ccxh, oldid, newid);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Update_CallInfo_Hclsh(string calllsh, string hclsh)
        {
            try
            {
                bool result = InfoBll.Instance.Update_CallInfo_Hclsh(calllsh, hclsh);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 更新呼叫记录表信息
        /// </summary>
        /// <param name="info">呼叫记录信息</param>
        /// <returns></returns>
        [WebMethod(Description = "更新呼叫记录表信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_CALL_INFO(string info)
        {
            try
            {
                CALL_INFO param = JosnHelper.DeserializeObject<CALL_INFO>(info);
                bool result = InfoBll.Instance.SP_UPDATE_CALL_INFO(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateTakeHospital(string lsh, string swdd, string swyy, string clid, string sllx)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "lsh：" + lsh + ",swdd：" + swdd + ",swyy：" + swyy + ",sllx：" + sllx, new LogUtility.RunningPlace("ZIT_WebService", "UpdateTakeHospital"), "车载送往地址更改");
                bool result = InfoBll.Instance.UpdateTakeHospital(lsh, swdd, swyy, clid, sllx);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 更新骚扰电弧信息表
        /// </summary>
        /// <param name="info">骚扰记录</param>
        /// <returns></returns>
        [WebMethod(Description = "更新骚扰电话信息表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_PRNAK_CALL(string info)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, info, new LogUtility.RunningPlace("OracleHelper", "SP_UPDATE_PRNAK_CALL"), "DB");
                SP_UPDATE_PRNAK_CALL param = JosnHelper.DeserializeObject<SP_UPDATE_PRNAK_CALL>(info);
                param.SDJSSJ = DateTime.Now;
                bool result = InfoBll.Instance.SP_UPDATE_PRNAK_CALL(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }


        /// <summary>
        /// SP_UPDATE_AMBUL_TRAC
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethod(Description = "SP_UPDATE_AMBUL_TRAC")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_AMBUL_TRAC(string info)
        {
            try
            {
                AMBUL_TRAC param = JosnHelper.DeserializeObject<AMBUL_TRAC>(info);
                bool result = InfoBll.Instance.SP_UPDATE_AMBUL_TRAC(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 更新多方通话记录表
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethod(Description = "SP_UPDATE_CALL_INFO_MULTIPLE")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_CALL_INFO_MULTIPLE(string info)
        {
            try
            {
                SP_UPDATE_CALL_INFO_MULTIPLE param = JosnHelper.DeserializeObject<SP_UPDATE_CALL_INFO_MULTIPLE>(info);
                bool result = InfoBll.Instance.SP_UPDATE_CALL_INFO_MULTIPLE(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 更新投诉信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethod(Description = "SP_UPDATE_COMPL_INFO")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_COMPL_INFO(string info)
        {
            try
            {
                SP_UPDATE_COMPL_INFO param = JosnHelper.DeserializeObject<SP_UPDATE_COMPL_INFO>(info);
                bool result = InfoBll.Instance.SP_UPDATE_COMPL_INFO(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_CANCLE_EVENT_BELONG(string sjh)
        {
            try
            {
                bool result = InfoBll.Instance.SP_CANCLE_EVENT_BELONG(sjh);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_MAJOR_ACCIDENT(string info)
        {
            try
            {
                SP_UPDATE_MAJOR_ACCIDENT param = JosnHelper.DeserializeObject<SP_UPDATE_MAJOR_ACCIDENT>(info);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = "成功";
                re.isSucceed = InfoBll.Instance.SP_UPDATE_MAJOR_ACCIDENT(param); ;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetDirectTelRec(string callid, string zjhm, string bjhm)
        {
            try
            {
                DataResult<List<CallFileInfo>> dpsj_list = new DataResult<List<CallFileInfo>>();
                dpsj_list.resultData = (List<CallFileInfo>)InfoBll.Instance.GetDirectTelRec(callid, zjhm, bjhm);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<CallFileInfo>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<CallFileInfo>> dpsj_list = new DataResult<List<CallFileInfo>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                string result = JosnHelper.SerializeObject<DataResult<List<CallFileInfo>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_ACCEPT_INFO(string info)
        {
            try
            {
                ACCEPT_INFO param = JosnHelper.DeserializeObject<ACCEPT_INFO>(info);
                DataResult<P_PRES_ACCEPT_INFO> re = new DataResult<P_PRES_ACCEPT_INFO>();
                re.resultData = InfoBll.Instance.SP_UPDATE_ACCEPT_INFO(param);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<P_PRES_ACCEPT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<P_PRES_ACCEPT_INFO> dpsj_list = new DataResult<P_PRES_ACCEPT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<P_PRES_ACCEPT_INFO>>(dpsj_list);
                return result;
            }
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_WXUserResponse(string info)
        {
            try
            {
                WXUserResponse param = JosnHelper.DeserializeObject<WXUserResponse>(info);
                bool result = InfoBll.Instance.SP_UPDATE_WXUserResponse(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }

        }

        //[WebMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public string SP_UPDATE_WXUserResponse(string info)
        //{
        //    try
        //    {
        //        WXUserResponse param = JosnHelper.DeserializeObject<WXUserResponse>(info);
        //        bool result = InfoBll.Instance.SP_UPDATE_WXUserResponse(param);
        //        DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
        //        re.msg = result ? "成功" : "失败";
        //        re.isSucceed = result;
        //        return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
        //    }
        //    catch (Exception e)
        //    {
        //        DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
        //        dpsj_list.resultData = null;
        //        dpsj_list.isSucceed = false;
        //        dpsj_list.msg = "失败--" + e.Message.ToString();
        //        string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
        //        return result;
        //    }

        //}


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateEventAcceptForFZCC(string lsh, string eventinfo)
        {
            try
            {
                EVENT_INFO param = JosnHelper.DeserializeObject<EVENT_INFO>(eventinfo);
                DataResult<Ambul_AcceptInfo> re = new DataResult<Ambul_AcceptInfo>();
                re.resultData = InfoBll.Instance.UpdateEventAcceptForFZCC(param, lsh);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(re);
            }
            catch (Exception e)
            {
                DataResult<Ambul_AcceptInfo> dpsj_list = new DataResult<Ambul_AcceptInfo>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAllInfoAboutLsh(string sjh, string lsh)
        {
            try
            {
                DataResult<Ambul_AcceptInfo> re = new DataResult<Ambul_AcceptInfo>();
                re.resultData = InfoBll.Instance.GetAllInfoAboutLsh(sjh, lsh);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(re);
            }
            catch (Exception e)
            {
                DataResult<Ambul_AcceptInfo> dpsj_list = new DataResult<Ambul_AcceptInfo>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_EVENT_INFO(string info)
        {
            try
            {
                EVENT_INFO param = JosnHelper.DeserializeObject<EVENT_INFO>(info);
                DataResult<V_SJLB> re = new DataResult<V_SJLB>();
                re.resultData = InfoBll.Instance.SP_UPDATE_EVENT_INFO(param);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<V_SJLB>>(re);
            }
            catch (Exception e)
            {
                DataResult<V_SJLB> dpsj_list = new DataResult<V_SJLB>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<V_SJLB>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 获取预受理详情
        /// </summary>
        /// <param name="info">主叫号码</param>
        /// <returns></returns>
        [WebMethod(Description = "获取预受理详情")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_PreDetailInfo(string zjhm)
        {
            try
            {
                DataResult<PreDetailInfo> dpsj_list = new DataResult<PreDetailInfo>();
                dpsj_list.resultData = InfoBll.Instance.Get_PreDetailInfo(zjhm);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<PreDetailInfo>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<PreDetailInfo> dpsj_list = new DataResult<PreDetailInfo>();
                dpsj_list.resultData = null;
                string result = JosnHelper.SerializeObject<DataResult<PreDetailInfo>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 分站拒绝任务
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "分站拒绝任务")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Station_Refuse(string strLSH, string ddxh, string qrr, string qrsj)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "strLSH:" + strLSH + ",ddxh:" + ddxh + ",qrr:" + qrr + ",qrsj:" + qrsj
                    , new LogUtility.RunningPlace("ZIT_Webservice", "Station_Refuse"), "分站拒绝任务");
                DataResult<bool> re = new DataResult<bool>();
                re.resultData = InfoBll.Instance.Station_Refuse(strLSH, ddxh, qrr, qrsj);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<bool>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<bool> dpsj_list = new DataResult<bool>();
                dpsj_list.resultData = true;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<bool>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 分站取消车辆
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "分站取消车辆")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Station_Cancle(string strLSH, string strCLID, string ccxh, string clzt, string qxpcsj, string qxyy, string iszxqxpc)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "strLSH:" + strLSH + ",strCLID:" + strCLID + ",ccxh:" + ccxh + ",clzt:" + clzt + ",qxpcsj:" + qxpcsj + ",qxyy:" + qxyy + ",iszxqxpc:" + iszxqxpc
                    , new LogUtility.RunningPlace("ZIT_Webservice", "Station_Cancle"), "分站取消车辆");
                DataResult<string> re = new DataResult<string>();
                re.resultData = InfoBll.Instance.Station_Cancle(strLSH, strCLID, ccxh, clzt, qxpcsj, qxyy, iszxqxpc);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<string>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = "";
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 分站派车
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "分站派车")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Station_InserAmbul(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string strSJH, string ddxh)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "strLSH:" + strLSH + ",strCLID:" + strCLID + ",strSZFZ:" + strSZFZ + ",nPCLX:" + nPCLX + ",dPCSJ:" + dPCSJ + ",strRPID:" + strRPID + ",strDDYID:" + strDDYID + ",strSJH:" + strSJH + ",ddxh:" + ddxh
                    , new LogUtility.RunningPlace("ZIT_Webservice", "Station_InserAmbul"), "分站派车");
                DataResult<string> re = new DataResult<string>();
                re.resultData = InfoBll.Instance.Station_InserAmbul(strLSH, strCLID, strSZFZ, nPCLX, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strRPID, strDDYID, strSJH, ddxh);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<string>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = "";
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 分站改派车辆
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "分站改派车辆")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Station_Modify(string lsh, string ccxh, string oldclid, string qxyy, string newclid, string szfzid, string rpid, string ddyid, string pcsj)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "strLSH:" + lsh + ",ccxh:" + ccxh + ",oldclid:" + oldclid + ",qxyy:" + qxyy + ",newclid:" + newclid + ",szfzid:" + szfzid + ",rpid:" + rpid + ",ddyid:" + ddyid + ",pcsj:" + pcsj
                    , new LogUtility.RunningPlace("ZIT_Webservice", "Station_Modify"), "分站改派车辆");
                DataResult<string> re = new DataResult<string>();
                re.resultData = InfoBll.Instance.Station_Modify(lsh, ccxh, oldclid, qxyy, newclid, szfzid, rpid, ddyid, pcsj);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<string>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = "";
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 取消派车
        /// </summary>
        /// <param name="info">出车信息</param>
        /// <returns></returns>
        [WebMethod(Description = "取消派车")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateCancleInfo(string info, string clzt)
        {
            try
            {

                AMBUL_OUTD_INFO param = JosnHelper.DeserializeObject<AMBUL_OUTD_INFO>(info);
                DataResult<Ambul_AcceptInfo> re = new DataResult<Ambul_AcceptInfo>();
                re.resultData = InfoBll.Instance.UpdateCancleAmbulInfo(param, clzt);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<Ambul_AcceptInfo> dpsj_list = new DataResult<Ambul_AcceptInfo>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(dpsj_list);
                return result;
            }
        }


        /// <summary>
        /// 更新出车信息表信息
        /// </summary>
        /// <param name="info">出车信息</param>
        /// <returns></returns>
        [WebMethod(Description = "更新出车信息表信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_AMBUL_OUTD_INFO(string info)
        {
            try
            {

                //LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + info, new LogUtility.RunningPlace("OracleHelper", "SP_UPDATE_AMBUL_OUTD_INFO"), "SP_UPDATE_AMBUL_OUTD_INFO");
                AMBUL_OUTD_INFO param = JosnHelper.DeserializeObject<AMBUL_OUTD_INFO>(info);
                //AMBUL_OUTD_INFO param = new AMBUL_OUTD_INFO() { LSH = "20170518370800000644", CLID = "10000", CCXH = 1, BZ = "1211", TSQK = 33 };
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> re = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                re.resultData = InfoBll.Instance.SP_UPDATE_AMBUL_OUTD_INFO(param);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_AMBUL_STATUS_DATE(string lsh, string clzt, string date, string ccxh, string czdh, string clid)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_AMBUL_STATUS_DATE(lsh, clzt, date, ccxh, czdh, clid);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "插入或更新车辆状态信息表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_AMBUL_STATUS_INFO(string info)
        {
            try
            {
                AMBUL_STATUS_INFO param = JosnHelper.DeserializeObject<AMBUL_STATUS_INFO>(info);
                bool result = InfoBll.Instance.SP_UPDATE_AMBUL_STATUS_INFO(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "更新远盟信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_INSERT_ACCEPT_YM(string info)
        {
            try
            {
                ACCEPT_YM param = JosnHelper.DeserializeObject<ACCEPT_YM>(info);
                bool result = InfoBll.Instance.SP_INSERT_ACCEPT_YM(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "更新远盟信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_ACCEPT_YM_INFO(string lsh, string orderid)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_ACCEPT_YM_INFO(lsh, orderid);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 插入或更新出车人员记录表
        /// </summary>
        /// <param name="info">出车信息</param>
        /// <returns></returns>
        [WebMethod(Description = "插入或更新出车人员记录表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_AMBUL_OUTD_STAFF(string info)
        {
            try
            {
                AMBUL_OUTD_STAFF param = JosnHelper.DeserializeObject<AMBUL_OUTD_STAFF>(info);
                bool result = InfoBll.Instance.SP_UPDATE_AMBUL_OUTD_STAFF(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 插入或更新自出受理记录表
        /// </summary>
        /// <param name="info">受理记录</param>
        /// <returns></returns>
        [WebMethod(Description = "插入或更新自出受理记录表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_DIRECT_ACCEPT_INFO_INFO(string info)
        {
            try
            {
                DIRECT_ACCEPT_INFO param = JosnHelper.DeserializeObject<DIRECT_ACCEPT_INFO>(info);
                bool result = InfoBll.Instance.SP_UPDATE_DIRECT_ACCEPT_INFO_INFO(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <returns></returns>
        [WebMethod(Description = " 结束多方通话，更新未记录挂机时间的通话记录   ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_CALL_MULTIPLE_END(string strLSH, string dGJSJ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_CALL_MULTIPLE_END(strLSH, dGJSJ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 取消派车
        /// </summary>
        /// <param name="strLSH"></param>
        /// <param name="strCLID"></param>
        /// <param name="nQXYY"></param>
        /// <returns></returns>
        [WebMethod(Description = "取消派车")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_CANCLED(string strLSH, string strCLID, string nQXYY, string nCLZT, string dQXPCSJ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_CANCLED(strLSH, strCLID, nQXYY, nCLZT, dQXPCSJ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// /改派车辆
        /// </summary>
        /// <param name="strNEWLSH"></param>
        /// <param name="strOLDCLID"></param>
        /// <param name="strOLDLSH"></param>
        /// <param name="nQXYY"></param>
        /// <param name="strNEWCLID"></param>
        /// <param name="strSZFZ"></param>
        /// <param name="strRPID"></param>
        /// <param name="strDDYID"></param>
        /// <returns></returns>
        [WebMethod(Description = "改派车辆")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_REASSIGNMENT(string strNEWLSH, string strOLDCLID, string strOLDLSH, string nQXYY, string strNEWCLID, string strSZFZ, string strRPID, string strDDYID, string strCLZT)
        {
            try
            {
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = InfoBll.Instance.SP_UPDATE_REASSIGNMENT(strNEWLSH, strOLDCLID, strOLDLSH, nQXYY, strNEWCLID, strSZFZ, strRPID, strDDYID, strCLZT);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<List<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 插入或更新转院受理记录表
        /// </summary>
        /// <param name="info">受理记录</param>
        /// <returns></returns>
        [WebMethod(Description = "插入或更新转院受理记录表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_TRANSPORT_ACCEPT(string info)
        {
            try
            {
                TRANSPORT_ACCEPT param = JosnHelper.DeserializeObject<TRANSPORT_ACCEPT>(info);
                bool result = InfoBll.Instance.SP_UPDATE_TRANSPORT_ACCEPT(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取患者信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Hzxx(string lsh)
        {
            try
            {
                DataResult<List<HZXXINfo>> dpsj_list = new DataResult<List<HZXXINfo>>();
                dpsj_list.resultData = InfoBll.Instance.Get_Hzxx(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<HZXXINfo>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<HZXXINfo>> dpsj_list = new DataResult<List<HZXXINfo>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<HZXXINfo>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "事件关联，传入事件号和关联ID，插入关联记录")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_EVENT_BELONG(string strSJH, string strB_ID)
        {
            try
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = InfoBll.Instance.SP_UPDATE_EVENT_BELONG(strSJH, strB_ID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<List<V_EVENT_BELONG>> dpsj_list = new DataResult<List<V_EVENT_BELONG>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<V_EVENT_BELONG>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "更新调度员上下班信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_RP_ONDUTY(string strDDYID, string strRPID, string dSBSJ, string dXBSJ, string strBZ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_RP_ONDUTY(strDDYID, strRPID, dSBSJ, dXBSJ, strBZ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "更新随车人员上下班信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateStaffOnduty(string strGH, string strTel, string nSXB, string dSJ)
        {
            try
            {
                List<V_STAFF_ONDUTY> result = InfoBll.Instance.UpdateStaffOnduty(strGH, strTel, nSXB, dSJ);
                DataResult<List<V_STAFF_ONDUTY>> re = new DataResult<List<V_STAFF_ONDUTY>>();
                re.msg ="成功";
                re.isSucceed = true;
                re.resultData = result;
                return JosnHelper.SerializeObject<DataResult<List<V_STAFF_ONDUTY>>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<List<V_STAFF_ONDUTY>> dpsj_list = new DataResult<List<V_STAFF_ONDUTY>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<List<V_STAFF_ONDUTY>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "更新随车人员上下班信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_STAFF_ONDUTY(string strGH, string strTel, string dSBSJ, string dXBSJ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_STAFF_ONDUTY(strGH, strTel, dSBSJ, dXBSJ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "电话关联，传入当前流水号，和关联目标事件号，置关联")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_CALL_GLLSH(string strLSH, string strSJH, string nHJLX)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_CALL_GLLSH(strLSH, strSJH, nHJLX);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "插入调度信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_INSERT_DISPATCH(string strLSH, string nDDLB, string nDDLX, string strDDFZ, string strDDCL, string strFBR, string strRPID)
        {
            try
            {
                DataResult<int> re = new DataResult<int>();
                re.resultData = InfoBll.Instance.SP_INSERT_DISPATCH(strLSH, nDDLB, nDDLX, strDDFZ, strDDCL, strFBR, strRPID);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<int>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<int> dpsj_list = new DataResult<int>();
                dpsj_list.resultData = 0;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<int>>(dpsj_list);
            }
        }

        [WebMethod(Description = "根据传入的事件号查看受理单信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_EVENT_ACCEPT_INFO(string strSJH)
        {
            try
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<P_PRES_ACCEPT_INFO>)InfoBll.Instance.SP_GET_EVENT_ACCEPT_INFO(strSJH);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_AMBUL_OUTD_STAFF_BY_LSH(string lsh)
        {
            try
            {
                DataResult<IList<AMBUL_OUTD_STAFF>> dpsj_list = new DataResult<IList<AMBUL_OUTD_STAFF>>();
                dpsj_list.resultData = (IList<AMBUL_OUTD_STAFF>)InfoBll.Instance.GET_AMBUL_OUTD_STAFF_BY_LSH(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<AMBUL_OUTD_STAFF>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<AMBUL_OUTD_STAFF>> dpsj_list = new DataResult<IList<AMBUL_OUTD_STAFF>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<AMBUL_OUTD_STAFF>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "根据传入的事件号获取出车信息表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_AMBUL_OUTD_INFO_BY_LSH(string strlsh)
        {
            try
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = (IList<SP_GET_AMBUL_OUTD_INFO>)InfoBll.Instance.GET_AMBUL_OUTD_INFO_BY_LSH(strlsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取远盟转单的受理信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_YM_RETURN(string lsh, string czdh, string orderid)
        {
            try
            {
                DataResult<IList<SP_GET_YM_RETURN>> dpsj_list = new DataResult<IList<SP_GET_YM_RETURN>>();
                dpsj_list.resultData = (IList<SP_GET_YM_RETURN>)InfoBll.Instance.SP_GET_YM_RETURN(lsh, czdh, orderid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_YM_RETURN>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_YM_RETURN>> dpsj_list = new DataResult<IList<SP_GET_YM_RETURN>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_YM_RETURN>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取远盟用户呼叫电话的受理信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_YM_CALLRETURN(string lsh, string czdh)
        {
            try
            {
                DataResult<IList<SP_GET_YM_CALLRETURN>> dpsj_list = new DataResult<IList<SP_GET_YM_CALLRETURN>>();
                dpsj_list.resultData = (IList<SP_GET_YM_CALLRETURN>)InfoBll.Instance.SP_GET_YM_CALLRETURN(lsh, czdh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_YM_CALLRETURN>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_YM_CALLRETURN>> dpsj_list = new DataResult<IList<SP_GET_YM_CALLRETURN>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_YM_CALLRETURN>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "根据传入的事件号获取出车信息表")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_AMBUL_OUTD_INFO_BY_SJH(string strSJH)
        {
            try
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = (IList<SP_GET_AMBUL_OUTD_INFO>)InfoBll.Instance.SP_GET_AMBUL_OUTD_INFO(strSJH);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取随车人员信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_V_STAFF_ONDUTY(string sfsb, string orgid)
        {
            try
            {
                DataResult<IList<V_STAFF_ONDUTY>> dpsj_list = new DataResult<IList<V_STAFF_ONDUTY>>();
                dpsj_list.resultData = (IList<V_STAFF_ONDUTY>)InfoBll.Instance.GET_V_STAFF_ONDUTY(sfsb, orgid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<V_STAFF_ONDUTY>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<V_STAFF_ONDUTY>> dpsj_list = new DataResult<IList<V_STAFF_ONDUTY>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<V_STAFF_ONDUTY>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取最近三天的出车信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_AMBUL_OUTD_INFO_ThreeDays()
        {
            try
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = (IList<SP_GET_AMBUL_OUTD_INFO>)InfoBll.Instance.GET_AMBUL_OUTD_INFO_ThreeDays();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_AMBUL_OUTD_INFO>> dpsj_list = new DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_AMBUL_OUTD_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "根据事件号获取对应的受理记录")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_V_ACCEPT_INFO_BY_SJH(string sjh)
        {
            try
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<P_PRES_ACCEPT_INFO>)InfoBll.Instance.GET_V_ACCEPT_INFO_BY_SJH(sjh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "根据主叫号码获取对应的受理记录")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_V_ACCEPT_INFO_BY_ZJHＭ(string zjhm)
        {
            try
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<P_PRES_ACCEPT_INFO>)InfoBll.Instance.GET_V_ACCEPT_INFO_BY_ZJHＭ(zjhm);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 检查是否是老年呼叫器用户
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "检查是否是老年呼叫器用户")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_VIP_INFO_BY_DH(string zjhm)
        {
            try
            {
                DataResult<VIP_USER_INFO> dpsj_list = new DataResult<VIP_USER_INFO>();
                dpsj_list.resultData = InfoBll.Instance.GET_VIP_INFO_BY_DH(zjhm);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<VIP_USER_INFO>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<VIP_USER_INFO> dpsj_list = new DataResult<VIP_USER_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<VIP_USER_INFO>>(dpsj_list);
                return result;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_WX(string lsh)
        {
            try
            {
                DataResult<WXUserResponse> dpsj_list = new DataResult<WXUserResponse>();
                dpsj_list.resultData = (WXUserResponse)InfoBll.Instance.Get_WX(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<WXUserResponse>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<WXUserResponse> dpsj_list = new DataResult<WXUserResponse>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<WXUserResponse>>(dpsj_list);
                return result;
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_V_ACCEPT_INFO_ThreeDays()
        {
            try
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<P_PRES_ACCEPT_INFO>)InfoBll.Instance.GET_V_ACCEPT_INFO_ThreeDays();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<P_PRES_ACCEPT_INFO>> dpsj_list = new DataResult<IList<P_PRES_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<P_PRES_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "传入分站ID，起止时间，查询该分站指定时间段内的受理单信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_ACCEPT_PERIOD(string strFZID, string start_TIME, string end_TIME)
        {
            try
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<FZ_ACCEPT_INFO>)InfoBll.Instance.SP_GET_FZ_ACCEPT_PERIOD(strFZID, start_TIME, end_TIME);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///传入分站ID，读取3天内的所有通知公告
        /// </summary>
        /// <param name="strFZID">分站ID</param>
        /// <returns></returns>
        [WebMethod(Description = "传入分站ID，读取3天内的所有通知公告")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_NOTICE(string strFZID)
        {
            try
            {
                DataResult<IList<FZ_NOTICE>> dpsj_list = new DataResult<IList<FZ_NOTICE>>();
                dpsj_list.resultData = (IList<FZ_NOTICE>)InfoBll.Instance.SP_GET_FZ_NOTICE(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_NOTICE>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_NOTICE>> dpsj_list = new DataResult<IList<FZ_NOTICE>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_NOTICE>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 传入事件号，查看电话录音等信息
        /// </summary>
        /// <param name="sjh">事件号</param>
        /// <returns></returns>
        [WebMethod(Description = "传入事件号，查看电话录音等信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_EVENT_CALL_INFO(string sjh)
        {
            try
            {
                DataResult<IList<SP_GET_EVENT_CALL_INFO>> dpsj_list = new DataResult<IList<SP_GET_EVENT_CALL_INFO>>();
                dpsj_list.resultData = (IList<SP_GET_EVENT_CALL_INFO>)InfoBll.Instance.SP_GET_EVENT_CALL_INFO(sjh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_EVENT_CALL_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_EVENT_CALL_INFO>> dpsj_list = new DataResult<IList<SP_GET_EVENT_CALL_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_EVENT_CALL_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 插入公告信息
        /// </summary>
        /// <param name="strLSH"></param>
        /// <param name="dFBSJ"></param>
        /// <param name="nYXQ"></param>
        /// <param name="nLX"></param>
        /// <param name="strFBNR"></param>
        /// <param name="strFBR"></param>
        /// <param name="nJSRLX"></param>
        /// <param name="strJSR"></param>
        /// <param name="nZT"></param>
        /// <returns></returns>
        [WebMethod(Description = "插入公告信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_INSERT_NOTICE_INFO(string strLSH, string dFBSJ, string nYXQ, string nLX, string strFBNR, string strFBR, string nJSRLX, string strJSR, string nZT)
        {
            try
            {
                DataResult<List<V_NOTICE_INFO>> re = new DataResult<List<V_NOTICE_INFO>>();
                re.resultData = InfoBll.Instance.SP_INSERT_NOTICE_INFO(strLSH, dFBSJ, nYXQ, nLX, strFBNR, strFBR, nJSRLX, strJSR, nZT);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<List<V_NOTICE_INFO>> dpsj_list = new DataResult<List<V_NOTICE_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<List<V_NOTICE_INFO>>>(dpsj_list);
            }
        }

        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="userid">工号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [WebMethod(Description = "更改密码")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UPDATE_PWD(string userid, string pwd)
        {
            try
            {
                bool result = InfoBll.Instance.UPDATE_PWD(userid, pwd);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
            }
        }

        /// <summary>
        ///插入短信内容
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <param name="dSJ">时间</param>
        /// <param name="strFSDX">发送对象</param>
        /// <param name="strNR">内容</param>
        /// <param name="strBZ">备注</param>
        /// <param name="strLX">类型</param>
        /// <returns></returns>
        [WebMethod(Description = "插入短信内容")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_SMS(string strLSH, string dSJ, string strFSDX, string strNR, string strBZ, string strLX)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_SMS(strLSH, dSJ, strFSDX, strNR, strBZ, strLX);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
            }
        }

        /// <summary>
        /// 获取最大流水号
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "获取最大流水号")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string FN_GETMAXLSH()
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = (string)InfoBll.Instance.FN_GETMAXLSH();
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }
        /// <summary>
        /// 根据流水号获取未完成的调度分站ID
        /// </summary>
        /// <param name="strLsh">流水号</param>
        /// <param name="strTel">车载电话号码</param>
        /// <returns></returns>
        [WebMethod(Description = " 根据流水号获取未完成的调度分站")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Dispatch_DDFZ(string strLsh)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = (string)InfoBll.Instance.Get_Dispatch_DDFZ(strLsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 获取车辆ID和序号
        /// </summary>
        /// <param name="strLsh">流水号</param>
        /// <param name="strTel">车载电话号码</param>
        /// <returns></returns>
        [WebMethod(Description = " 获取车辆ID和序号")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_CLIDXH(string strLsh, string strTel)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = (string)InfoBll.Instance.Get_CLIDXH(strLsh, strTel);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 根据关联流水号获取受理受理流水号（用于增援）
        /// </summary>
        /// <param name="strNewLsh">新的关联流水号</param>
        /// <returns></returns>
        [WebMethod(Description = "  根据关联流水号获取受理受理流水号（用于增援）")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string FN_GET_GLLSH(string strNewLsh)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = (string)InfoBll.Instance.FN_GET_GLLSH(strNewLsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 获取分站UUID
        /// </summary>
        /// <param name="ptel">车载电话号码</param>
        [WebMethod(Description = " 获取分站UUID")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string FN_GetFZUUIDByTel(string ptel)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = (string)InfoBll.Instance.FN_GetFZUUIDByTel(ptel);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }


        /// <summary>
        /// 根据传入的流水号获取相关信息(事件列表信息，出车信息、受理记录信息)
        /// </summary>
        /// <param name="lsh">流水号</param>
        /// <returns></returns>
        [WebMethod(Description = "根据传入的流水号获取相关信息(事件列表信息，出车信息、受理记录信息)")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_LshAbuotInfo_ByLsh(string lsh)
        {
            try
            {
                DataResult<LshAboutInfo> dpsj_list = new DataResult<LshAboutInfo>();
                dpsj_list.resultData = (LshAboutInfo)InfoBll.Instance.Get_LshAbuotInfo_ByLsh(lsh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<LshAboutInfo>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<LshAboutInfo> dpsj_list = new DataResult<LshAboutInfo>();
                dpsj_list.resultData = null;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<LshAboutInfo>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///插入或更新受理记录表,并返回受理相关信息
        /// </summary>
        /// <param name="info">受理信息</param>
        /// <returns></returns>
        [WebMethod(Description = "插入或更新受理记录表,并返回受理相关信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateAcceptInfo(string info, string clid)
        {
            try
            {
                DataResult<Ambul_AcceptInfo> resultinfo = new DataResult<Ambul_AcceptInfo>();
                ACCEPT_INFO param = JosnHelper.DeserializeObject<ACCEPT_INFO>(info);
                resultinfo.resultData = (Ambul_AcceptInfo)InfoBll.Instance.UpdateAcceptInfo(param, clid);
                resultinfo.msg = "成功";
                resultinfo.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(resultinfo);
            }
            catch (Exception e)
            {
                DataResult<Ambul_AcceptInfo> resultinfo = new DataResult<Ambul_AcceptInfo>();
                resultinfo.resultData = null;
                resultinfo.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(resultinfo);
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateEventInfo_And_Return_AboutInfo(string info)
        {
            try
            {
                DataResult<EventAboutInfo> resultinfo = new DataResult<EventAboutInfo>();
                EVENT_INFO param = JosnHelper.DeserializeObject<EVENT_INFO>(info);
                resultinfo.resultData = (EventAboutInfo)InfoBll.Instance.UpdateEventInfo_And_Return_AboutInfo(param);
                resultinfo.msg = "成功";
                resultinfo.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<EventAboutInfo>>(resultinfo);
            }
            catch (Exception e)
            {
                DataResult<EventAboutInfo> resultinfo = new DataResult<EventAboutInfo>();
                resultinfo.resultData = null;
                resultinfo.msg = "失败--" + e.Message.ToString();
                return JosnHelper.SerializeObject<DataResult<EventAboutInfo>>(resultinfo);
            }
        }

        /// <summary>
        /// 根据车辆ID和流水号获取出车信息和车辆详情信息
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "根据车辆ID和流水号获取出车信息和车辆详情信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GET_CCXX_CLXQ_INFO_BY_LSH_CLID(string lsh, string clid)
        {
            try
            {
                DataResult<CCXX_CLXQ_INFO> dpsj_list = new DataResult<CCXX_CLXQ_INFO>();
                dpsj_list.resultData = (CCXX_CLXQ_INFO)InfoBll.Instance.GET_CCXX_CLXQ_INFO_BY_LSH_CLID(lsh, clid);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<CCXX_CLXQ_INFO>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<CCXX_CLXQ_INFO> dpsj_list = new DataResult<CCXX_CLXQ_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<CCXX_CLXQ_INFO>>(dpsj_list);
                return result;
            }
        }
        [WebMethod(Description = "获取app的受理信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_APP_CCXX(string lsh, string ccxh)
        {
            try
            {
                DataResult<CCXX> dpsj_list = new DataResult<CCXX>();
                dpsj_list.resultData = InfoBll.Instance.SP_GET_APP_CCXX(lsh, ccxh);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<CCXX>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<CCXX> dpsj_list = new DataResult<CCXX>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<CCXX>>(dpsj_list);
                return result;
            }
        }
        [WebMethod(Description = "")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_ACCEPT_APP_QUALITY(string info)
        {
            try
            {
                QualityRespnose param = JosnHelper.DeserializeObject<QualityRespnose>(info);
                bool result = InfoBll.Instance.SP_UPDATE_ACCEPT_APP_QUALITY(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }


        [WebMethod(Description = "")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_ACCEPT_APP(string info)
        {
            try
            {
                receiveAPPSheet param = JosnHelper.DeserializeObject<receiveAPPSheet>(info);
                bool result = InfoBll.Instance.SP_UPDATE_ACCEPT_APP(param);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }
        #region 分站

        /// <summary>
        ///传入分站ID，查看分站所有车辆状态
        /// </summary>
        /// <param name="strFZID">分站id</param>
        [WebMethod(Description = "传入分站ID，查看分站所有车辆状态")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_CLZT(string strFZID)
        {
            try
            {
                DataResult<IList<FZ_BUS_INFO>> dpsj_list = new DataResult<IList<FZ_BUS_INFO>>();
                dpsj_list.resultData = (IList<FZ_BUS_INFO>)InfoBll.Instance.SP_GET_FZ_CLZT(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_BUS_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_BUS_INFO>> dpsj_list = new DataResult<IList<FZ_BUS_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_BUS_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///传入分站ID，查看3天内分站的调度单接车地址
        /// </summary>
        /// <param name="strFZID">分站id</param>
        [WebMethod(Description = "传入分站ID，查看3天内分站的调度单接车地址")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_JCDZ(string strFZID)
        {
            try
            {
                DataResult<IList<FZ_DISPATCH_INFO>> dpsj_list = new DataResult<IList<FZ_DISPATCH_INFO>>();
                dpsj_list.resultData = (IList<FZ_DISPATCH_INFO>)InfoBll.Instance.SP_GET_FZ_JCDZ(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_DISPATCH_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_DISPATCH_INFO>> dpsj_list = new DataResult<IList<FZ_DISPATCH_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_DISPATCH_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 传入流水号，更新调度信息
        /// </summary>
        /// <param name="strLSH">流水号</param>
        /// <returns></returns>
        [WebMethod(Description = "传入流水号，更新调度信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_FZ_DISPATCH(string strLSH, string nDDLX, string strQRR)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_FZ_DISPATCH(strLSH, nDDLX, strQRR);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 传入车辆ID，完成车辆等级更新
        /// </summary>
        /// <param name="strCLID">车辆id</param>
        /// <param name="nCLDJ">车辆等级</param>
        /// <returns></returns>
        [WebMethod(Description = "传入车辆ID，完成车辆等级更新")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_FZ_CLDJ(string strCLID, string nCLDJ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_FZ_CLDJ(strCLID, nCLDJ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }


        /// <summary>
        ///传入分站ID，查看3天内的受理单信息
        /// </summary>
        /// <param name="strFZID">分站id</param>
        [WebMethod(Description = "传入分站ID，查看3天内的受理单信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_ACCEPT_INFO(string strFZID)
        {
            try
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<FZ_ACCEPT_INFO>)InfoBll.Instance.SP_GET_FZ_ACCEPT_INFO(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///传入流水号，查看出车信息
        /// </summary>
        /// <param name="strFZID">分站id</param>
        [WebMethod(Description = "传入流水号，查看出车信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_CCXX(string strFZID)
        {
            try
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = (IList<FZ_ACCEPT_INFO>)InfoBll.Instance.SP_GET_FZ_CCXX(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<FZ_ACCEPT_INFO>> dpsj_list = new DataResult<IList<FZ_ACCEPT_INFO>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<FZ_ACCEPT_INFO>>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "获取远盟信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_ACCEPT_YM_INFO(string isgl)
        {
            try
            {
                DataResult<IList<ACCEPT_YM>> dpsj_list = new DataResult<IList<ACCEPT_YM>>();
                dpsj_list.resultData = (IList<ACCEPT_YM>)InfoBll.Instance.SP_GET_ACCEPT_YM_INFO(isgl);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<ACCEPT_YM>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<ACCEPT_YM>> dpsj_list = new DataResult<IList<ACCEPT_YM>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<ACCEPT_YM>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///传入电话号码，识别是否标记为骚扰电话过，上次标记时间和总次数
        /// </summary>
        /// <param name="hm">号码</param>
        [WebMethod(Description = "传入电话号码，识别是否标记为骚扰电话过，上次标记时间和总次数")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_PRANK_CALL_HIS(string hm)
        {
            try
            {
                DataResult<IList<SP_GET_PRANK_CALL_HIS>> dpsj_list = new DataResult<IList<SP_GET_PRANK_CALL_HIS>>();
                dpsj_list.resultData = (IList<SP_GET_PRANK_CALL_HIS>)InfoBll.Instance.SP_GET_PRANK_CALL_HIS(hm);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_PRANK_CALL_HIS>>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<IList<SP_GET_PRANK_CALL_HIS>> dpsj_list = new DataResult<IList<SP_GET_PRANK_CALL_HIS>>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<IList<SP_GET_PRANK_CALL_HIS>>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 传入车辆ID，完成取消派车的更新
        /// </summary>
        /// <param name="strCLID">车辆id</param>
        /// <param name="nQXYY">取消原因</param>
        /// <param name="nGPBZ">改派标识</param>
        /// <returns></returns>
        [WebMethod(Description = "传入车辆ID，完成取消派车的更新")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_UPDATE_FZ_CANCLED(string strCLID, string nQXYY, string nGPBZ)
        {
            try
            {
                bool result = InfoBll.Instance.SP_UPDATE_FZ_CANCLED(strCLID, nQXYY, nGPBZ);
                DataResult<RESULT_INFO> re = new DataResult<RESULT_INFO>();
                re.msg = result ? "成功" : "失败";
                re.isSucceed = result;
                return JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(re); ;
            }
            catch (Exception e)
            {
                DataResult<RESULT_INFO> dpsj_list = new DataResult<RESULT_INFO>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<RESULT_INFO>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 存储出车信息
        /// </summary>
        /// <param name="info">出车信息</param>
        /// <returns></returns>
        [WebMethod(Description = "存储出车信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_FZ_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string sjh, string swdd)
        {
            try
            {
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, strLSH + "-" + strCLID + "-" + strSZFZ + "-" + nPCLX + "-" + dPCSJ + "-" + strRPID + "-" + strDDYID + "-" + sjh + "-" + swdd, new LogUtility.RunningPlace("SP_FZ_INSERT_AMBUL_OUTD", "SP_FZ_INSERT_AMBUL_OUTD"), "分站插入出车");
                DataResult<bool> re = new DataResult<bool>();
                re.resultData = InfoBll.Instance.SP_FZ_INSERT_AMBUL_OUTD(strLSH, strCLID, strSZFZ, nPCLX, dPCSJ, strRPID, strDDYID, sjh, swdd);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<bool>>(re);
            }
            catch (Exception e)
            {
                DataResult<bool> dpsj_list = new DataResult<bool>();
                dpsj_list.resultData = false;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<bool>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        /// 存储出车信息
        /// </summary>
        /// <param name="info">出车信息</param>
        /// <returns></returns>
        [WebMethod(Description = "存储出车信息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_INSERT_AMBUL_OUTD(string strLSH, string strCLID, string strSZFZ, string nPCLX, string dPCSJ, string strRPID, string strDDYID, string sjh, string swdd)
        {
            try
            {
                DataResult<Ambul_AcceptInfo> re = new DataResult<Ambul_AcceptInfo>();
                re.resultData = InfoBll.Instance.SP_INSERT_AMBUL_OUTD(strLSH, strCLID, strSZFZ, nPCLX, dPCSJ, strRPID, strDDYID, sjh, swdd);
                re.msg = "成功";
                re.isSucceed = true;
                return JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(re);
            }
            catch (Exception e)
            {
                DataResult<Ambul_AcceptInfo> dpsj_list = new DataResult<Ambul_AcceptInfo>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<Ambul_AcceptInfo>>(dpsj_list);
                return result;
            }
        }

        [WebMethod(Description = "传入分站ID，查看分站是否有调度权，0是无，1是有")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string BatchInsert(string data)
        {
            try
            {
                DataResult<int> dpsj_list = new DataResult<int>();
                List<AMBUL_TRAC> lst = JosnHelper.DeserializeObject<List<AMBUL_TRAC>>(data);
                dpsj_list.resultData = InfoBll.Instance.BatchInsert(lst);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<int>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<int> dpsj_list = new DataResult<int>();
                dpsj_list.resultData = 0;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<int>>(dpsj_list);
                return result;
            }
        }

        /// <summary>
        ///传入分站ID，查看分站是否有调度权，0是无，1是有
        /// </summary>
        /// <param name="strFZID">分站id</param>
        [WebMethod(Description = "传入分站ID，查看分站是否有调度权，0是无，1是有")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SP_GET_FZ_LX(string strFZID)
        {
            try
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = InfoBll.Instance.SP_GET_FZ_LX(strFZID);
                dpsj_list.msg = "成功";
                dpsj_list.isSucceed = true;
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
            catch (Exception e)
            {
                DataResult<string> dpsj_list = new DataResult<string>();
                dpsj_list.resultData = null;
                dpsj_list.isSucceed = false;
                dpsj_list.msg = "失败--" + e.Message.ToString();
                string result = JosnHelper.SerializeObject<DataResult<string>>(dpsj_list);
                return result;
            }
        }
        #endregion
    }
}
