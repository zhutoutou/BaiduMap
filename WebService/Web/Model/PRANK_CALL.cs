using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 骚扰电话锁定信息
    /// </summary>
    [Serializable]
    public class PRANK_CALL
    {

        /// <summary>
        /// 流水号
        /// </summary>		
        private string _lsh;
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }
        /// <summary>
        /// 来电号码
        /// </summary>		
        private string _hm;
        public string HM
        {
            get { return _hm; }
            set { _hm = value; }
        }
        /// <summary>
        /// 标记时间
        /// </summary>		
        private DateTime _bjsj;
        public DateTime BJSJ
        {
            get { return _bjsj; }
            set { _bjsj = value; }
        }
        /// <summary>
        /// 是否锁定
        /// </summary>		
        private decimal _sfsd=0;
        public decimal SFSD
        {
            get { return _sfsd; }
            set { _sfsd = value; }
        }
        /// <summary>
        /// 锁定时间
        /// </summary>		
        private DateTime _sdsj;
        public DateTime SDSJ
        {
            get { return _sdsj; }
            set { _sdsj = value; }
        }
        /// <summary>
        /// 锁定时长。单位：min
        /// </summary>		
        private decimal _sdsc;
        public decimal SDSC
        {
            get { return _sdsc; }
            set { _sdsc = value; }
        }
        /// <summary>
        /// 锁定人
        /// </summary>		
        private string _sdr;
        public string SDR
        {
            get { return _sdr; }
            set { _sdr = value; }
        }
        /// <summary>
        /// 解锁标志
        /// </summary>		
        private decimal _jsbz;
        public decimal JSBZ
        {
            get { return _jsbz; }
            set { _jsbz = value; }
        }
        /// <summary>
        /// 行政编码
        /// </summary>		
        private decimal _xzbm;
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }

    }
}