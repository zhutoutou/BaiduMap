using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///待派事件实体类
    /// <summary>
    [Serializable]
    public class V_DPSJ
    {

        private string _sjh;

        /// <summary>
        /// SJH
        /// </summary>	
        public string SJH
        {
            get { return _sjh; }
            set { _sjh = value; }
        }

        private string _lsh;

        /// <summary>
        /// LSH
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _rpid;

        /// <summary>
        /// RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }

        private string _rpname;

        /// <summary>
        /// RPNAME
        /// </summary>	
        public string RPNAME
        {
            get { return _rpname; }
            set { _rpname = value; }
        }

        private string _jcdz;

        /// <summary>
        /// 接车地址
        /// </summary>	
        public string JCDZ
        {
            get { return _jcdz; }
            set { _jcdz = value; }
        }

        private DateTime _dpsj;

        /// <summary>
        /// 待派时间
        /// </summary>	
        public DateTime DPSJ
        {
            get { return _dpsj; }
            set { _dpsj = value; }
        }

        private string _ddyid;

        /// <summary>
        /// 调度员id
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }

        private decimal _sjlx;

        /// <summary>
        /// 事件类型
        /// </summary>	
        public decimal SJLX
        {
            get { return _sjlx; }
            set { _sjlx = value; }
        }

    }
}