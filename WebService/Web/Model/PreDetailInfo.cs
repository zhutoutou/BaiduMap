using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 预受理详情信息
    /// </summary>
    public class PreDetailInfo
    {
        bool _isvip = false;
        /// <summary>
        /// 是否是vip用户
        /// </summary>
        public bool isvip
        {
            get { return _isvip; }
            set { _isvip = value; }
        }
        VIP_USER_INFO _vip_user_info = new VIP_USER_INFO();
        /// <summary>
        /// VIP用户信息
        /// </summary>
        public VIP_USER_INFO vip_user_info
        {
            get { return _vip_user_info; }
            set { _vip_user_info = value; }
        }
        SP_GET_OBLIGATE_ACCEPT_INFO _call_accept_info = new SP_GET_OBLIGATE_ACCEPT_INFO();
        /// <summary>
        /// 电话受理详情
        /// </summary>
        public SP_GET_OBLIGATE_ACCEPT_INFO call_accept_info
        {
            get { return _call_accept_info; }
            set { _call_accept_info = value; }
        }
        P_PRES_ACCEPT_INFO _last_accept_info = new P_PRES_ACCEPT_INFO();
        /// <summary>
        /// 上一次的受理信息
        /// </summary>
        public P_PRES_ACCEPT_INFO last_accept_info
        {
            get { return _last_accept_info; }
            set { _last_accept_info = value; }
        }
    }
}