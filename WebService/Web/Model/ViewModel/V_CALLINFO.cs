using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class V_CALLINFO
    {
        string _lsh = string.Empty;
        /// <summary>
        /// 流水号
        /// </summary>
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
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
        /// 呼出标识
        /// </summary>
        public decimal HCBZ
        {
            get { return _hcbz; }
            set { _hcbz = value; }
        }
        string _hjfs = string.Empty;
        public string HJFS
        {
            get { return _hjfs; }
            set { _hjfs = value; }
        }
        string _ddy = string.Empty;
        public string DDY
        {
            get { return _ddy; }
            set { _ddy = value; }
        }
        string _ddyid = string.Empty;
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }
        string _lyid = string.Empty;
        public string LYID
        {
            get { return _lyid; }
            set { _lyid = value; }
        }
        DateTime _hjsj = DateTime.Now;
        public DateTime HJSJ
        {
            get { return _hjsj; }
            set { _hjsj = value; }
        }
    }
}