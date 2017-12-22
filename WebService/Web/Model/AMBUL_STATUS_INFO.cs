using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///车辆状态信息表。记录车辆当前状态和随车人员
    /// </summary>
    [Serializable]
    public class AMBUL_STATUS_INFO
    {


        private string _tel;

        /// <summary>
        /// 车载电话
        /// </summary>	
        public string TEL
        {
            get { return _tel; }
            set { _tel = value; }
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

        private string _dqszfzid;

        /// <summary>
        /// 当前所在分站。存储分站ORG_ID
        /// </summary>	
        public string DQSZFZID
        {
            get { return _dqszfzid; }
            set { _dqszfzid = value; }
        }

        private decimal _cldj;

        /// <summary>
        /// 车辆等级。存储车辆等级编码，一线、二线、备用等
        /// </summary>	
        public decimal CLDJ
        {
            get { return _cldj; }
            set { _cldj = value; }
        }

        private decimal _status;

        /// <summary>
        /// 车辆状态。存储车辆状态编码，是否可调用等
        /// </summary>	
        public decimal STATUS
        {
            get { return _status; }
            set { _status = value; }
        }

        private decimal _ztdy;

        /// <summary>
        /// 暂停调用原因。存储暂停调用原因编码
        /// </summary>	
        public decimal ZTDY
        {
            get { return _ztdy; }
            set { _ztdy = value; }
        }

        private string _sjid;

        /// <summary>
        /// 司机ID
        /// </summary>	
        public string SJID
        {
            get { return _sjid; }
            set { _sjid = value; }
        }

        private string _ysid;

        /// <summary>
        /// 医生ID
        /// </summary>	
        public string YSID
        {
            get { return _ysid; }
            set { _ysid = value; }
        }

        private string _hsid;

        /// <summary>
        /// 护士ID
        /// </summary>	
        public string HSID
        {
            get { return _hsid; }
            set { _hsid = value; }
        }

        private string _djgid;

        /// <summary>
        /// 担架工ID
        /// </summary>	
        public string DJGID
        {
            get { return _djgid; }
            set { _djgid = value; }
        }

        private decimal _gps_x;

        /// <summary>
        /// 经度
        /// </summary>	
        public decimal GPS_X
        {
            get { return _gps_x; }
            set { _gps_x = value; }
        }

        private decimal _gps_y;

        /// <summary>
        /// 纬度
        /// </summary>	
        public decimal GPS_Y
        {
            get { return _gps_y; }
            set { _gps_y = value; }
        }
        private decimal _CZSFZX = -1;

        /// <summary>
        /// 车载是否在线
        /// </summary>	
        public decimal CZSFZX
        {
            get { return _CZSFZX; }
            set { _CZSFZX = value; }
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