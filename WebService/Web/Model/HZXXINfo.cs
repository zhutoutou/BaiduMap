using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    [Serializable]

    public class HZXXINfo
    {
        string _name;
        /// <summary>
        /// 患者名
        /// </summary>
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        string _nl;
        /// <summary>
        /// 患者年龄
        /// </summary>
        public string NL
        {
            get { return _nl; }
            set { _nl = value; }
        }
        string _clmc;
        /// <summary>
        /// 车辆名称
        /// </summary>
        public string CLMC
        {
            get { return _clmc; }
            set { _clmc = value; }
        }
        string _fzmc;
        /// <summary>
        /// 分站名称
        /// </summary>
        public string FZMC
        {
            get { return _fzmc; }
            set { _fzmc = value; }
        }
        string _swdd;
        /// <summary>
        /// 送往地点（编码）
        /// </summary>
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
        }
        string _swyy;
        /// <summary>
        /// 送往地点（医院名）
        /// </summary>
        public string SWYY
        {
            get { return _swyy; }
            set { _swyy = value; }
        }
        string _lsh;
        /// <summary>
        /// 流水号
        /// </summary>
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }
        string _bqzd;
        /// <summary>
        /// 病情诊断
        /// </summary>
        public string BQZD
        {
            get { return _bqzd; }
            set { _bqzd = value; }
        }
        string _jzjg;
        /// <summary>
        /// 救治结果
        /// </summary>
        public string JZJG
        {
            get { return _jzjg; }
            set { _jzjg = value; }
        }
        string _bq;
        /// <summary>
        /// 病情
        /// </summary>
        public string BQ
        {
            get { return _bq; }
            set { _bq = value; }
        }
    }
}