using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///黑名单列表视图实体
    /// <summary>
    [Serializable]
    public class V_BLACK_LIST
    {
        private string _tel;

        /// <summary>
        /// 锁定号码
        /// </summary>	
        public string TEL
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private string _station;

        /// <summary>
        /// 锁定的分机号
        /// </summary>	
        public string Station
        {
            get { return _station; }
            set { _station = value; }
        }


        private decimal _locktimespan;

        /// <summary>
        /// 锁定时长
        /// </summary>	
        public  decimal LOCKTIMESPAN
        {
            get { return _locktimespan; }
            set { _locktimespan = value; }
        }

    }
}