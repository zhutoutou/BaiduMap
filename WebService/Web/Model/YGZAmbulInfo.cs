using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class YGZAmbulInfo
    {
        private string _swdd;

        /// <summary>
        /// 送往地点
        /// </summary>	
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
        }

        private string _sj;

        /// <summary>
        /// 送往地点
        /// </summary>	
        public string SJ
        {
            get { return _sj; }
            set { _sj = value; }
        }


        private string _ys;

        /// <summary>
        /// 送往地点
        /// </summary>	
        public string YS
        {
            get { return _ys; }
            set { _ys = value; }
        }


        private string _hs;

        /// <summary>
        /// 送往地点
        /// </summary>	
        public string HS
        {
            get { return _hs; }
            set { _hs = value; }
        }

        private string _czdh;

        /// <summary>
        /// 车载电话
        /// </summary>	
        public string CZDH
        {
            get { return _czdh; }
            set { _czdh = value; }
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

        private string _lsh;

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
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

        private string _nl;
        /// <summary>
        /// 是否中心取消派车
        /// </summary>
        public string NL
        {
            get { return _nl; }
            set { _nl = value; }
        }

        private string _hzxb;
        /// <summary>
        /// 患者性别
        /// </summary>
        public string HZXB
        {
            get { return _hzxb; }
            set { _hzxb = value; }
        }

        private string _hzxm;
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string HZXM
        {
            get { return _hzxm; }
            set { _hzxm = value; }
        }

        private string _hjyybc;

        public string HJYYBC
        {
            get { return _hjyybc; }
            set { _hjyybc = value; }
        }

        private string _clmc;

        public string CLMC
        {
            get { return _clmc; }
            set { _clmc = value; }
        }

        private string _lxr;

        public string LXR
        {
            get { return _lxr; }
            set { _lxr = value; }
        }

        private string _lxdh;

        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }

        private string _szfz;

        public string FZID
        {
            get { return _szfz; }
            set { _szfz = value; }
        }

        private DateTime _scsj;

        /// <summary>
        /// 医院名称
        /// </summary>	
        public DateTime SCSJ
        {
            get { return _scsj; }
            set { _scsj = value; }
        }
    }
}