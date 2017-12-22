using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 根据事件号获取录音信息
    /// </summary>
    public class SP_GET_EVENT_CALL_INFO
    {
        string _hjlx;
        /// <summary>
        /// 呼叫类型
        /// </summary>
        public string HJLX
        {
            get { return _hjlx; }
            set { _hjlx = value; }
        }

        string _bjhm = string.Empty;
        /// <summary>
        /// 被叫号码
        /// </summary>
        public string BJHM
        {
            get { return _bjhm; }
            set { _bjhm = value; }
        }
        string _zjhm = string.Empty;
        /// <summary>
        /// 主叫号码
        /// </summary>
        public string ZJHM
        {
            get { return _zjhm; }
            set { _zjhm = value; }
        }
        decimal _hcbz;
        /// <summary>
        /// 呼出标识(1:呼出，0：呼入)
        /// </summary>
        public decimal HCBZ
        {
            get { return _hcbz; }
            set { _hcbz = value; }
        }
        string _HJFS;
        /// <summary>
        /// 呼叫方式
        /// </summary>
        public string HJFS
        {
            get { return _HJFS; }
            set { _HJFS = value; }
        }
        string _DDY;
        /// <summary>
        /// 调度员
        /// </summary>
        public string DDY
        {
            get { return _DDY; }
            set { _DDY = value; }
        }
        DateTime _HJSJ;
        /// <summary>
        /// 呼叫时间
        /// </summary>
        public DateTime HJSJ
        {
            get { return _HJSJ; }
            set { _HJSJ = value; }
        }
        string _LYID;
        /// <summary>
        /// 录音ID
        /// </summary>
        public string LYID
        {
            get { return _LYID; }
            set { _LYID = value; }
        }
    }
}