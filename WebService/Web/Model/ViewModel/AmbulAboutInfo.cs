using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 插入出车信息返回信息
    /// </summary>
    public class AmbulAboutInfo
    {

        List<SP_GET_AMBUL_OUTD_INFO> _ambullist = new List<SP_GET_AMBUL_OUTD_INFO>();
        /// <summary>
        /// 出车信息
        /// </summary>
        public List<SP_GET_AMBUL_OUTD_INFO> Ambullist
        {
            get { return _ambullist; }
            set { _ambullist = value; }
        }

        V_SJLB _sjlb = new V_SJLB();
        /// <summary>
        /// 事件列表
        /// </summary>
        public V_SJLB Sjlb
        {
            get { return _sjlb; }
            set { _sjlb = value; }
        }
    }
}