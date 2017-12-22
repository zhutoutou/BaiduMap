using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Web.Model
{
    /// <summary>
    ///重大事故
    /// </summary>
    [Serializable]
    public class SP_UPDATE_MAJOR_ACCIDENT
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

        private decimal _sglxfl;

        /// <summary>
        /// 事故类型分类
        /// </summary>	
        public decimal SGLXFL
        {
            get { return _sglxfl; }
            set { _sglxfl = value; }
        }

        private string _sglxflsm;

        /// <summary>
        /// 事故类型分类说明
        /// </summary>	
        public string SGLXFLSM
        {
            get { return _sglxflsm; }
            set { _sglxflsm = value; }
        }

        private string _rpid;

        /// <summary>
        /// 坐席ID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }

        private string _ddyid;

        /// <summary>
        /// 调度员ID
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }
        private decimal _sjlx;

        /// <summary>
        /// 事件类型
        /// </summary>	
        public decimal SJLX
        {
            get { return _sjlx; }
            set { _sjlx = value; }
        }

        private string _sjlxsm;

        /// <summary>
        /// 事件类型说明
        /// </summary>	
        public string SJLXSM
        {
            get { return _sjlxsm; }
            set { _sjlxsm = value; }
        }

        private decimal _sjdj;

        /// <summary>
        /// 事件等级
        /// </summary>	
        public decimal SJDJ
        {
            get { return _sjdj; }
            set { _sjdj = value; }
        }

        private string _sjdjsm;

        /// <summary>
        /// 事件等级说明
        /// </summary>	
        public string SJDJSM
        {
            get { return _sjdjsm; }
            set { _sjdjsm = value; }
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
        /// SQCBFX
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

    }
}

