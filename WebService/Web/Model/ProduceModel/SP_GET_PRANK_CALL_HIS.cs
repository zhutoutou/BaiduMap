using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 传入电话号码，识别是否标记为骚扰电话过，上次标记时间和总次数
    /// </summary>
    [Serializable]
    public class SP_GET_PRANK_CALL_HIS
    {
        private DateTime _V_SCBJSJ;

        /// <summary>
        /// 最近标记时间
        /// </summary>	
        public DateTime V_SCBJSJ
        {
            get { return _V_SCBJSJ; }
            set { _V_SCBJSJ = value; }
        }

        private string _PhoneNumber;

        /// <summary>
        /// 标记号码
        /// </summary>	
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        private string _IsLock;

        /// <summary>
        /// 是否锁定
        /// </summary>	
        public string IsLock
        {
            get { return _IsLock; }
            set { _IsLock = value; }
        }
        private string _V_BJCS;

        /// <summary>
        /// 标记次数
        /// </summary>	
        public string V_BJCS
        {
            get { return _V_BJCS; }
            set { _V_BJCS = value; }
        }
        private string _V_SDSC;

        /// <summary>
        /// 锁定时长
        /// </summary>	
        public string V_SDSC
        {
            get { return _V_SDSC; }
            set { _V_SDSC = value; }
        }
    }
}