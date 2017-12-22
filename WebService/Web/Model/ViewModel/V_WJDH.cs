using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///未接电话视图实体
    /// <summary>
    [Serializable]
    public class V_WJDH
    {

        private string _lsh;

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _ldhm;

        /// <summary>
        /// 来电号码
        /// </summary>	
        public string LDHM
        {
            get { return _ldhm; }
            set { _ldhm = value; }
        }

        private DateTime _hjsj;

        /// <summary>
        /// 呼叫时间
        /// </summary>	
        public DateTime HJSJ
        {
            get { return _hjsj; }
            set { _hjsj = value; }
        }
    }
}