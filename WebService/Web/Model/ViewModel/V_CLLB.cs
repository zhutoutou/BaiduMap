using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///车辆列表视图实体
    /// <summary>
    [Serializable]
    public class V_CLLB
    {

        private decimal _rn;

        /// <summary>
        /// RN
        /// </summary>	
        public decimal RN
        {
            get { return _rn; }
            set { _rn = value; }
        }

        private string _clid;

        /// <summary>
        /// 车辆id
        /// </summary>	
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }

        private decimal _is_fzcl;

        /// <summary>
        /// 是否是分站车辆
        /// </summary>	
        public decimal IS_FZCL
        {
            get { return _is_fzcl; }
            set { _is_fzcl = value; }
        }


        private string _rpid;

        /// <summary>
        /// 分站RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
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

        private string _rpname;

        /// <summary>
        /// 分站RPNAME
        /// </summary>	
        public string RPNAME
        {
            get { return _rpname; }
            set { _rpname = value; }
        }
        private decimal _ywddq;

        /// <summary>
        /// 是否是分站车辆
        /// </summary>	
        public decimal YWDDQ
        {
            get { return _ywddq; }
            set { _ywddq = value; }
        }

        private string _name;

        /// <summary>
        /// NAME
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private decimal _cldj;

        /// <summary>
        /// CLDJ
        /// </summary>	
        public decimal CLDJ
        {
            get { return _cldj; }
            set { _cldj = value; }
        }

        private string _cldjsm;

        /// <summary>
        /// CLDJSM
        /// </summary>	
        public string CLDJSM
        {
            get { return _cldjsm; }
            set { _cldjsm = value; }
        }

        private decimal _clzt;

        /// <summary>
        /// CLZT
        /// </summary>	
        public decimal CLZT
        {
            get { return _clzt; }
            set { _clzt = value; }
        }

        private string _clztsm;

        /// <summary>
        /// CLZTSM
        /// </summary>	
        public string CLZTSM
        {
            get { return _clztsm; }
            set { _clztsm = value; }
        }

        private string _szfzid;

        /// <summary>
        /// 所在分站id
        /// </summary>	
        public string SZFZID
        {
            get { return _szfzid; }
            set { _szfzid = value; }
        }

        private string _szfzmc;

        /// <summary>
        /// SZFZMC
        /// </summary>	
        public string SZFZMC
        {
            get { return _szfzmc; }
            set { _szfzmc = value; }
        }

        private DateTime _zhgxsj;

        /// <summary>
        /// ZHGXSJ
        /// </summary>	
        public DateTime ZHGXSJ
        {
            get { return _zhgxsj; }
            set { _zhgxsj = value; }
        }

        private string _ddyid;

        /// <summary>
        /// 调度员id
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
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

        private string _ysid;

        /// <summary>
        /// 医生id
        /// </summary>	
        public string YSID
        {
            get { return _ysid; }
            set { _ysid = value; }
        }

        private string _ys;

        /// <summary>
        /// 医生
        /// </summary>	
        public string YS
        {
            get { return _ys; }
            set { _ys = value; }
        }

        private string _sjid;

        /// <summary>
        /// 司机id
        /// </summary>	
        public string SJID
        {
            get { return _sjid; }
            set { _sjid = value; }
        }

        private string _sj;

        /// <summary>
        /// 司机
        /// </summary>	
        public string SJ
        {
            get { return _sj; }
            set { _sj = value; }
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

    }
}