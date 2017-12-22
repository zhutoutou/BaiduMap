using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Web.Model
{
    /// <summary>
    ///车辆轨迹表
    /// </summary>
    [Serializable]
    public class AMBUL_TRAC
    {
        private string _czhm="1";

        /// <summary>
        /// 车辆号码
        /// </summary>	
        public string CZHM
        {
            get { return _czhm; }
            set { _czhm = value; }
        }

        private DateTime _zhfssj=DateTime.Now;

        /// <summary>
        /// 最后发送时间
        /// </summary>	
        public DateTime ZHFSSJ
        {
            get { return _zhfssj; }
            set { _zhfssj = value; }
        }

        private DateTime _dxddsj=DateTime.Now;

        /// <summary>
        /// 短信到达时间
        /// </summary>	
        public DateTime DXDDSJ
        {
            get { return _dxddsj; }
            set { _dxddsj = value; }
        }

        private decimal _xslc=0;

        /// <summary>
        /// 行驶里程
        /// </summary>	
        public decimal XSLC
        {
            get { return _xslc; }
            set { _xslc = value; }
        }

        private decimal _sd=0;

        /// <summary>
        /// 速度
        /// </summary>	
        public decimal SD
        {
            get { return _sd; }
            set { _sd = value; }
        }

        private decimal _fx;

        /// <summary>
        /// 方向。以正北为0度,按顺时针旋转
        /// </summary>	
        public decimal FX
        {
            get { return _fx; }
            set { _fx = value; }
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

        private string _lsh="1";

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private decimal _gzxs;

        /// <summary>
        /// 跟踪星
        /// </summary>	
        public decimal GZXS
        {
            get { return _gzxs; }
            set { _gzxs = value; }
        }

        private decimal _kjxs;

        /// <summary>
        /// 可见星
        /// </summary>	
        public decimal KJXS
        {
            get { return _kjxs; }
            set { _kjxs = value; }
        }

        private decimal _bj;

        /// <summary>
        /// 报警。0:正常,1:报警
        /// </summary>	
        public decimal BJ
        {
            get { return _bj; }
            set { _bj = value; }
        }

        private decimal _txzt;

        /// <summary>
        /// 天线状态。0:正常,1:断路,2:短路
        /// </summary>	
        public decimal TXZT
        {
            get { return _txzt; }
            set { _txzt = value; }
        }

    }
}

