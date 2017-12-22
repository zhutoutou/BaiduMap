using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 受理相关信息
    /// </summary>
    public class AcceptAboutInfo
    {

        ACCEPT_INFO _accepiinfo = new ACCEPT_INFO();
        /// <summary>
        /// 受理信息
        /// </summary>
        public ACCEPT_INFO AcceptInfo
        {
            get { return _accepiinfo; }
            set { _accepiinfo = value; }
        }

        P_PRES_ACCEPT_INFO _pres_acceptinfo = new P_PRES_ACCEPT_INFO();
        /// <summary>
        /// 二次修改受理信息
        /// </summary>
        public P_PRES_ACCEPT_INFO Pres_AcceptInfo
        {
            get { return _pres_acceptinfo; }
            set { _pres_acceptinfo = value; }
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