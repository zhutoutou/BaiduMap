using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 投诉信息实体类
    /// </summary>
    [Serializable]
    public class SP_UPDATE_COMPL_INFO
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

        private string _RPID;

        /// <summary>
        /// RPID
        /// </summary>	
        public string RPID
        {
            get { return _RPID; }
            set { _RPID = value; }
        }

        private DateTime _SLSJ;

        /// <summary>
        /// SLSJ
        /// </summary>	
        public DateTime SLSJ
        {
            get { return _SLSJ; }
            set { _SLSJ = value; }
        }

        private string _DDYID;

        /// <summary>
        /// DDYID
        /// </summary>	
        public string DDYID
        {
            get { return _DDYID; }
            set { _DDYID = value; }
        }

        private string _TSSJMS;

        /// <summary>
        /// 投诉事件名称
        /// </summary>	
        public string TSSJMS
        {
            get { return _TSSJMS; }
            set { _TSSJMS = value; }
        }

        private decimal _TSDX;

        /// <summary>
        /// 投诉对象
        /// </summary>	
        public decimal TSDX
        {
            get { return _TSDX; }
            set { _TSDX = value; }
        }

        private decimal _TSRYLX;

        /// <summary>
        /// 投诉人员类型
        /// </summary>	
        public decimal TSRYLX
        {
            get { return _TSRYLX; }
            set { _TSRYLX = value; }
        }

        private decimal _TSFZID;

        /// <summary>
        /// 投诉分站ID
        /// </summary>	
        public decimal TSFZID
        {
            get { return _TSFZID; }
            set { _TSFZID = value; }
        }

        private string _QTTS;

        /// <summary>
        /// 其他投诉
        /// </summary>	
        public string QTTS
        {
            get { return _QTTS; }
            set { _QTTS = value; }
        }

        private decimal _TSLX;

        /// <summary>
        /// 投诉类型
        /// </summary>	
        public decimal TSLX
        {
            get { return _TSLX; }
            set { _TSLX = value; }
        }

        private string _TSYY;

        /// <summary>
        /// 投诉原因
        /// </summary>	
        public string TSYY
        {
            get { return _TSYY; }
            set { _TSYY = value; }
        }

        private string _TSDH;

        /// <summary>
        /// 投诉电话
        /// </summary>	
        public string TSDH
        {
            get { return _TSDH; }
            set { _TSDH = value; }
        }

        private string _DXSBR1;

        /// <summary>
        /// 短信上报人一
        /// </summary>	
        public string DXSBR1
        {
            get { return _DXSBR1; }
            set { _DXSBR1 = value; }
        }

        private string _DXSBR2;

        /// <summary>
        /// 短信上报人二
        /// </summary>	
        public string DXSBR2
        {
            get { return _DXSBR2; }
            set { _DXSBR2 = value; }
        }

        private string _DXSBR3;

        /// <summary>
        /// 短信上报人三
        /// </summary>	
        public string DXSBR3
        {
            get { return _DXSBR3; }
            set { _DXSBR3 = value; }
        }
    }
}