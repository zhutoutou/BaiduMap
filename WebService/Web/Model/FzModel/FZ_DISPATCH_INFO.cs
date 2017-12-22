using System;

namespace Web.Model
{
    /// <summary>
    /// 调度信息标
    /// </summary>
    [Serializable]
    public class FZ_DISPATCH_INFO
    {
        decimal _ddxh;
        public decimal DDXH
        {
            get { return _ddxh; }
            set { _ddxh = value; }
        }

        private string _ddcl;
        /// <summary>
        /// 调度车辆
        /// </summary>		
        public string DDCL
        {
            get { return _ddcl; }
            set { _ddcl = value; }
        }

        private string _qqr;
        /// <summary>
        /// 确认人
        /// </summary>		
        public string QQR
        {
            get { return _qqr; }
            set { _qqr = value; }
        }

        private string _fbr;
        public string FBR
        {
            get { return _fbr; }
            set { _fbr = value; }
        }

        private string _rpid;
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }


        private string _lsh;
        /// <summary>
        /// 流水号
        /// </summary>		
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _ddfz;
        /// <summary>
        /// 调度分站
        /// </summary>		
        public string DDFZ
        {
            get { return _ddfz; }
            set { _ddfz = value; }
        }

        private decimal _ddlb;
        /// <summary>
        /// 调度类别
        /// </summary>		
        public decimal DDLB
        {
            get { return _ddlb; }
            set { _ddlb = value; }
        }

        private decimal _ddlx;
        /// <summary>
        /// 调度类型
        /// </summary>		
        public decimal DDLX
        {
            get { return _ddlx; }
            set { _ddlx = value; }
        }

        private decimal _zt = 1;
        /// <summary>
        /// 处理状态
        /// </summary>		
        public decimal ZT
        {
            get { return _zt; }
            set { _zt = value; }
        }

        private DateTime _fbsj;
        /// <summary>
        /// 发布时间
        /// </summary>		
        public DateTime FBSJ
        {
            get { return _fbsj; }
            set { _fbsj = value; }
        }
        private DateTime _qrsj;
        /// <summary>
        /// 确认时间
        /// </summary>		
        public DateTime QRSJ
        {
            get { return _qrsj; }
            set { _qrsj = value; }
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
