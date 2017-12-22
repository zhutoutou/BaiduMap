using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 事件相关信息
    /// </summary>
    public class EventAboutInfo
    {
        EVENT_INFO _eventinfo = new EVENT_INFO();
        /// <summary>
        /// 事件信息
        /// </summary>
        public EVENT_INFO EventInfo
        {
            get { return _eventinfo; }
            set { _eventinfo = value; }
        }

        V_SJLB _sjlbinfo = new V_SJLB();
        /// <summary>
        /// 事件列表信息
        /// </summary>
        public V_SJLB SjlbInfo
        {
            get { return _sjlbinfo; }
            set { _sjlbinfo = value; }
        }

        List<P_PRES_ACCEPT_INFO> _accept_list = new List<P_PRES_ACCEPT_INFO>();
        /// <summary>
        /// 该事件下对应的受理信息
        /// </summary>
        public List<P_PRES_ACCEPT_INFO> Accept_List
        {
            get { return _accept_list; }
            set { _accept_list = value; }
        }

        List<SP_GET_AMBUL_OUTD_INFO> _ambul_list = new List<SP_GET_AMBUL_OUTD_INFO>();
        /// <summary>
        /// 该事件下对应的出车信息
        /// </summary>
        public List<SP_GET_AMBUL_OUTD_INFO> Ambul_List
        {
            get { return _ambul_list; }
            set { _ambul_list = value; }
        }
        bool _result = false;
        /// <summary>
        /// 操作结果
        /// </summary>
        public bool Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}