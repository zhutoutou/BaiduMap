using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Web.Model
{
    /// <summary>
    ///事件关联视图实体类
    /// </summary>
    [Serializable]
    public class V_EVENT_BELONG
    {
        private string _glid;

        /// <summary>
        /// GLID
        /// </summary>	
        public string GLID
        {
            get { return _glid; }
            set { _glid = value; }
        }

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

        private DateTime _scslsj;

        /// <summary>
        /// SCSLSJ
        /// </summary>	
        public DateTime SCSLSJ
        {
            get { return _scslsj; }
            set { _scslsj = value; }
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

    }
}

