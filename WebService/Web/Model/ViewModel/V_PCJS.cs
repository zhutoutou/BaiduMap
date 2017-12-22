using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///派车计时实体类
    /// <summary>
    [Serializable]
    public class V_PCJS
    {
        private string _ddyid;

        /// <summary>
        /// 调度员id
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
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

        private string _clid;

        /// <summary>
        /// 车辆id
        /// </summary>	
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }

        private string _name;

        /// <summary>
        /// 车辆名称
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _clztsm;

        /// <summary>
        /// 车辆状态说明
        /// </summary>	
        public string CLZTSM
        {
            get { return _clztsm; }
            set { _clztsm = value; }
        }

        private DateTime _pcsj;

        /// <summary>
        /// 派车时间
        /// </summary>	
        public DateTime PCSJ
        {
            get { return _pcsj; }
            set { _pcsj = value; }
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

    }
}