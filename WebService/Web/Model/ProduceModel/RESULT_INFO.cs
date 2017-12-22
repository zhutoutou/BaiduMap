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
    public class RESULT_INFO
    {
        private decimal _nflag;
        /// <summary>
        /// 标识
        /// </summary>	
        public decimal FLAG
        {
            get { return _nflag; }
            set { _nflag = value; }
        }
        private string _errmsg;

        /// <summary>
        /// 错误信息
        /// </summary>	
        public string ERRMSG
        {
            get { return _errmsg; }
            set { _errmsg = value; }
        }
    }
}