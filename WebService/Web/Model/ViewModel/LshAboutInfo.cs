using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 流水号相关信息
    /// </summary>
    public class LshAboutInfo
    {
        List<V_SJLB> _sjlb_list = new List<V_SJLB>();
        /// <summary>
        /// 事件列表
        /// </summary>
        public List<V_SJLB> Sjlb_List
        {
            get { return _sjlb_list; }
            set { _sjlb_list = value; }
        }
        List<P_PRES_ACCEPT_INFO> _accept_list = new List<P_PRES_ACCEPT_INFO>();
        /// <summary>
        /// 受理记录列表
        /// </summary>
        public List<P_PRES_ACCEPT_INFO> Accept_list
        {
            get { return _accept_list; }
            set { _accept_list = value; }
        }
        List<SP_GET_AMBUL_OUTD_INFO> _ambul_outd_info_list = new List<SP_GET_AMBUL_OUTD_INFO>();
        /// <summary>
        /// 出车记录列表
        /// </summary>
        public List<SP_GET_AMBUL_OUTD_INFO> Ambul_outd_info_list
        {
            get { return _ambul_outd_info_list; }
            set { _ambul_outd_info_list = value; }
        }
    }
}