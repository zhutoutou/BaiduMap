using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///车辆列表视图实体
    /// <summary>
    [Serializable]
    public class CLLB_STATUS
    {       
        private decimal _clzt;

        /// <summary>
        /// CLZT
        /// </summary>	
        public decimal CLZT
        {
            get { return _clzt; }
            set { _clzt = value; }
        }

        private string _clztsm;

        /// <summary>
        /// CLZTSM
        /// </summary>	
        public string CLZTSM
        {
            get { return _clztsm; }
            set { _clztsm = value; }
        }

        private string _czdh;
        /// <summary>
        /// 车载电话
        /// </summary>	
        public string CZDH
        {
            get { return _czdh; }
            set { _czdh = value; }
        }

    }
}