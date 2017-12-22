using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class Report_Ambul
    {
        string _ccdw;
        public string CCDW
        {
            get { return _ccdw; }
            set { _ccdw = value; }
        }
        string _ys;
        public string YS
        {
            get { return _ys; }
            set { _ys = value; }
        }
        string _hs;
        public string HS
        {
            get { return _hs; }
            set { _hs = value; }
        }
        string _sj;
        public string SJ
        {
            get { return _sj; }
            set { _sj = value; }
        }
        DateTime _ddsj;
        public DateTime DDSJ
        {
            get { return _ddsj; }
            set { _ddsj = value; }
        }
        DateTime _ccsj;
        public DateTime CCSJ
        {
            get { return _ccsj; }
            set { _ccsj = value; }
        }
    }

    public class Report
    {
        private string _sjh;

        /// <summary>
        /// 事件号
        /// </summary>	
        public string SJH
        {
            get { return _sjh; }
            set { _sjh = value; }
        }

        private string _sglxsm;

        /// <summary>
        /// 事故类型说明
        /// </summary>	
        public string SGLXSM
        {
            get { return _sglxsm; }
            set { _sglxsm = value; }
        }


        private string _sjmc;

        /// <summary>
        /// 事件名称
        /// </summary>	
        public string SJMC
        {
            get { return _sjmc; }
            set { _sjmc = value; }
        }

        private decimal _swrs;

        /// <summary>
        /// 死亡人数
        /// </summary>	
        public decimal SWRS
        {
            get { return _swrs; }
            set { _swrs = value; }
        }

        private decimal _ssrs;

        /// <summary>
        /// 受伤人数
        /// </summary>	
        public decimal SSRS
        {
            get { return _ssrs; }
            set { _ssrs = value; }
        }

        private decimal _szrs;

        /// <summary>
        /// 失踪人数
        /// </summary>	
        public decimal SZRS
        {
            get { return _szrs; }
            set { _szrs = value; }
        }

        private string _sqcbfx;

        /// <summary>
        /// 伤情分析
        /// </summary>	
        public string SQCBFX
        {
            get { return _sqcbfx; }
            set { _sqcbfx = value; }
        }

        private string _sbbm1;

        /// <summary>
        /// 上报部门一
        /// </summary>	
        public string SBBM1
        {
            get { return _sbbm1; }
            set { _sbbm1 = value; }
        }

        private string _fshm1;

        /// <summary>
        /// 上报部门一电话
        /// </summary>	
        public string FSHM1
        {
            get { return _fshm1; }
            set { _fshm1 = value; }
        }

        private DateTime _sbsj1;

        /// <summary>
        /// 上报部门一时间
        /// </summary>	
        public DateTime SBSJ1
        {
            get { return _sbsj1; }
            set { _sbsj1 = value; }
        }

        private string _sbbm2;

        /// <summary>
        /// 上报部门二
        /// </summary>	
        public string SBBM2
        {
            get { return _sbbm2; }
            set { _sbbm2 = value; }
        }

        private string _fshm2;

        /// <summary>
        /// 上报部门二号码
        /// </summary>	
        public string FSHM2
        {
            get { return _fshm2; }
            set { _fshm2 = value; }
        }

        private DateTime _sbsj2;

        /// <summary>
        /// 上报部门二时间
        /// </summary>	
        public DateTime SBSJ2
        {
            get { return _sbsj2; }
            set { _sbsj2 = value; }
        }

        private string _sbbm3;

        /// <summary>
        /// 上报部门三
        /// </summary>	
        public string SBBM3
        {
            get { return _sbbm3; }
            set { _sbbm3 = value; }
        }

        private string _fshm3;

        /// <summary>
        /// 上报部门三电话
        /// </summary>	
        public string FSHM3
        {
            get { return _fshm3; }
            set { _fshm3 = value; }
        }

        private DateTime _sbsj3;

        /// <summary>
        /// 上报部门三时间
        /// </summary>	
        public DateTime SBSJ3
        {
            get { return _sbsj3; }
            set { _sbsj3 = value; }
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
        private string _ddy;

        /// <summary>
        /// 调度员
        /// </summary>	
        public string DDY
        {
            get { return _ddy; }
            set { _ddy = value; }
        }
        private string _hjzlxsm;

        /// <summary>
        /// 呼叫者类型说明
        /// </summary>	
        public string HJZLXSM
        {
            get { return _hjzlxsm; }
            set { _hjzlxsm = value; }
        }
        private decimal _hzrs;

        /// <summary>
        /// 患者人数
        /// </summary>	
        public decimal HZRS
        {
            get { return _hzrs; }
            set { _hzrs = value; }
        }
        private string _lxdh;

        /// <summary>
        /// 联系电话
        /// </summary>	
        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }
        private string _hjqysm;

        /// <summary>
        /// 呼叫区域说明
        /// </summary>	
        public string HJQYSM
        {
            get { return _hjqysm; }
            set { _hjqysm = value; }
        }
        private string _xcdz;

        /// <summary>
        /// 现场地址
        /// </summary>	
        public string XCDZ
        {
            get { return _xcdz; }
            set { _xcdz = value; }
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

    public class Marjor_Report
    {

        Report _report = new Report();
        /// <summary>
        /// 上报信息
        /// </summary>
        public Report ReportInfo
        {
            get { return _report; }
            set { _report = value; }
        }
       

        List<Report_Ambul> _ccdwlist = new List<Report_Ambul>();
        /// <summary>
        /// 出车信息列表
        /// </summary>
        public List<Report_Ambul> CCXX
        {
            get { return _ccdwlist; }
            set { _ccdwlist = value; }
        }

        List<HZXXINfo> _hzxxlist = new List<HZXXINfo>();
        /// <summary>
        /// 患者信息列表
        /// </summary>
        public List<HZXXINfo> HZXX
        {
            get { return _hzxxlist; }
            set { _hzxxlist = value; }
        }
    }
}