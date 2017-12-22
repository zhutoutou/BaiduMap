using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 执行存储过程的返回结果
    /// </summary>
    [Serializable]
    public class RESULT_INFO2
    {
        private decimal _YWDDQ;
        /// <summary>
        /// 标识
        /// </summary>	
        public decimal YWDDQ
        {
            get { return _YWDDQ; }
            set { _YWDDQ = value; }
        }
    }
}