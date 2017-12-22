using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 骚扰电话实体类
    /// </summary>
    [Serializable]
    public class SP_UPDATE_PRNAK_CALL
    {
        private string _lsh;

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _HM;

        /// <summary>
        /// 号码
        /// </summary>	
        public string HM
        {
            get { return _HM; }
            set { _HM = value; }
        }

        private DateTime _BJSJ;

        /// <summary>
        /// 标记时间
        /// </summary>	
        public DateTime BJSJ
        {
            get { return _BJSJ; }
            set { _BJSJ = value; }
        }

        private DateTime _SDSJ;

        /// <summary>
        /// 锁定时间
        /// </summary>	
        public DateTime SDSJ
        {
            get { return _SDSJ; }
            set { _SDSJ = value; }
        }

        private DateTime _SDJSSJ;

        /// <summary>
        /// 解锁时间
        /// </summary>	
        public DateTime SDJSSJ
        {
            get { return _SDJSSJ; }
            set { _SDJSSJ = value; }
        }
        private decimal _SFSD;

        /// <summary>
        /// 是否锁定
        /// </summary>	
        public decimal SFSD
        {
            get { return _SFSD; }
            set { _SFSD = value; }
        }

        private decimal _SDSC;

        /// <summary>
        /// 锁定时长
        /// </summary>	
        public decimal SDSC
        {
            get { return _SDSC; }
            set { _SDSC = value; }
        }

        private string _SDR;

        /// <summary>
        /// 锁定人
        /// </summary>	
        public string SDR
        {
            get { return _SDR; }
            set { _SDR = value; }
        }
    }
}