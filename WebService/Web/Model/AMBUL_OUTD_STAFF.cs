using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///出车人员记录表
    /// </summary>
    [Serializable]
    public class AMBUL_OUTD_STAFF
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

        private decimal _ccxh;

        /// <summary>
        /// 出车序号
        /// </summary>	
        public decimal CCXH
        {
            get { return _ccxh; }
            set { _ccxh = value; }
        }

        private string _id;

        /// <summary>
        /// 人员ID
        /// </summary>	
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _clid;

        /// <summary>
        /// 车辆ID
        /// </summary>	
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }
        decimal _xzbm;
        /// <summary>
        /// 行政编码
        /// </summary>	
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }

        private decimal _lx;

        /// <summary>
        /// 人员类型。标识随车人员类型，司机1，医生2，护士3，担架工4
        /// </summary>	
        public decimal LX
        {
            get { return _lx; }
            set { _lx = value; }
        }

        private decimal _flag;

        /// <summary>
        /// 无效标识。标识该条记录是否无效，默认0 有效，1 是无效
        /// </summary>	
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private DateTime _create_time;

        /// <summary>
        /// 创建时间
        /// </summary>	
        public DateTime CREATE_TIME
        {
            get { return _create_time; }
            set { _create_time = value; }
        }

        private DateTime _last_modify_time;

        /// <summary>
        /// 最后更新时间
        /// </summary>	
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modify_time; }
            set { _last_modify_time = value; }
        }

    }
}