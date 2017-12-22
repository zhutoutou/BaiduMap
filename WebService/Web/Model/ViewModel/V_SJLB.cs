using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///V_SJLB
    /// </summary>
    [Serializable]
    public class V_SJLB
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

        private decimal _status;

        /// <summary>
        /// STATUS
        /// </summary>	
        public decimal STATUS
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _ztsm;

        /// <summary>
        /// ZTSM
        /// </summary>	
        public string ZTSM
        {
            get { return _ztsm; }
            set { _ztsm = value; }
        }

        private DateTime _scldsj;

        /// <summary>
        /// SCLDSJ
        /// </summary>	
        public DateTime SCLDSJ
        {
            get { return _scldsj; }
            set { _scldsj = value; }
        }

        private string _scldhm;

        /// <summary>
        /// SCLDHM
        /// </summary>	
        public string SCLDHM
        {
            get { return _scldhm; }
            set { _scldhm = value; }
        }

        private DateTime _scslsj;

        /// <summary>
        /// SCSLSJ
        /// </summary>	
        public DateTime SCSLSJ
        {
            get { return _scslsj; }
            set { _scslsj = value; }
        }

        private string _scslrpid;

        /// <summary>
        /// SCSLRPID
        /// </summary>	
        public string SCSLRPID
        {
            get { return _scslrpid; }
            set { _scslrpid = value; }
        }

        private string _rp;

        /// <summary>
        /// RP
        /// </summary>	
        public string RP
        {
            get { return _rp; }
            set { _rp = value; }
        }

        private string _scddy;

        /// <summary>
        /// SCDDY
        /// </summary>	
        public string SCDDY
        {
            get { return _scddy; }
            set { _scddy = value; }
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

        private decimal _sjlx;

        /// <summary>
        /// SJLX
        /// </summary>	
        public decimal SJLX
        {
            get { return _sjlx; }
            set { _sjlx = value; }
        }

        private string _sjlxsm;

        /// <summary>
        /// SJLXSM
        /// </summary>	
        public string SJLXSM
        {
            get { return _sjlxsm; }
            set { _sjlxsm = value; }
        }

        private decimal _sglx;

        /// <summary>
        /// SGLX
        /// </summary>	
        public decimal SGLX
        {
            get { return _sglx; }
            set { _sglx = value; }
        }

        private string _sglxsm;

        /// <summary>
        /// SGLXSM
        /// </summary>	
        public string SGLXSM
        {
            get { return _sglxsm; }
            set { _sglxsm = value; }
        }

        private string _xcdz;

        /// <summary>
        /// XCDZ
        /// </summary>	
        public string XCDZ
        {
            get { return _xcdz; }
            set { _xcdz = value; }
        }

        private string _hcyy;

        /// <summary>
        /// HCYY
        /// </summary>	
        public string HCYY
        {
            get { return _hcyy; }
            set { _hcyy = value; }
        }

        private decimal _flag;

        /// <summary>
        /// FLAG
        /// </summary>	
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private DateTime _create_time;

        /// <summary>
        /// CREATE_TIME
        /// </summary>	
        public DateTime CREATE_TIME
        {
            get { return _create_time; }
            set { _create_time = value; }
        }

        private DateTime _last_modify_time;

        /// <summary>
        /// LAST_MODIFY_TIME
        /// </summary>	
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modify_time; }
            set { _last_modify_time = value; }
        }

        private decimal _xzbm;

        /// <summary>
        /// XZBM
        /// </summary>	
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }
        private decimal _ambulSum;

        /// <summary>
        /// 该事件的出车次数
        /// </summary>	
        public decimal AmbulSum
        {
            get { return _ambulSum; }
            set { _ambulSum = value; }
        }
    }
}