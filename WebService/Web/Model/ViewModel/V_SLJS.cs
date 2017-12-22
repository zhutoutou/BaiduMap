using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///受理计时实体类
    /// <summary>
    [Serializable]
    public class V_SLJS
    {
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
        /// 受理台id
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

        private string _ddyid;

        /// <summary>
        /// DDYID
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }

        private string _ddy;

        /// <summary>
        /// DDY
        /// </summary>	
        public string DDY
        {
            get { return _ddy; }
            set { _ddy = value; }
        }

        private decimal _sllx;

        /// <summary>
        /// SLLX
        /// </summary>	
        public decimal SLLX
        {
            get { return _sllx; }
            set { _sllx = value; }
        }

        private string _sllxmc;

        /// <summary>
        /// SLLXMC
        /// </summary>	
        public string SLLXMC
        {
            get { return _sllxmc; }
            set { _sllxmc = value; }
        }

        private DateTime _slsj;

        /// <summary>
        /// SLSJ
        /// </summary>	
        public DateTime SLSJ
        {
            get { return _slsj; }
            set { _slsj = value; }
        }

        private string _jcdz;

        /// <summary>
        /// JCDZ
        /// </summary>	
        public string JCDZ
        {
            get { return _jcdz; }
            set { _jcdz = value; }
        }

    }
}