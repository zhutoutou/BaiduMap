using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    [Serializable]
    public class TongJiInfo
    {
        decimal _callsum;
        /// <summary>
        /// 电话总数
        /// </summary>
        public decimal callsum
        {
            get { return _callsum; }
            set { _callsum = value; }
        }
        decimal _callsum_hr;
        /// <summary>
        /// 呼入电话总数
        /// </summary>
        public decimal callsum_hr
        {
            get { return _callsum_hr; }
            set { _callsum_hr = value; }
        }
        decimal _callsum_hc;
        /// <summary>
        /// 呼出电话总数
        /// </summary>
        public decimal callsum_hc
        {
            get { return _callsum_hc; }
            set { _callsum_hc = value; }
        }
        decimal _callsum_jt;
        /// <summary>
        /// 接听电话总数
        /// </summary>
        public decimal callsum_jt
        {
            get { return _callsum_jt; }
            set { _callsum_jt = value; }
        }
        decimal _callsum_wjt;
        /// <summary>
        /// 未接听电话总数
        /// </summary>
        public decimal callsum_wjt
        {
            get { return _callsum_wjt; }
            set { _callsum_wjt = value; }
        }
        decimal _acceptsum;
        /// <summary>
        /// 受理总数
        /// </summary>
        public decimal acceptsum
        {
            get { return _acceptsum; }
            set { _acceptsum = value; }
        }
        decimal _accep_amnul_tsum;
        /// <summary>
        /// 已出车受理总数
        /// </summary>
        public decimal accep_amnul_tsum
        {
            get { return _accep_amnul_tsum; }
            set { _accep_amnul_tsum = value; }
        }
        decimal _amnul_tsum;
        /// <summary>
        /// 出车总数
        /// </summary>
        public decimal amnul_tsum
        {
            get { return _amnul_tsum; }
            set { _amnul_tsum = value; }
        }
        decimal _yxamnul_tsum;
        /// <summary>
        /// 有效出车总数
        /// </summary>
        public decimal yxamnul_tsum
        {
            get { return _yxamnul_tsum; }
            set { _yxamnul_tsum = value; }
        }
        decimal _wxamnul_tsum;
        /// <summary>
        /// 无效出车总数
        /// </summary>
        public decimal wxamnul_tsum
        {
            get { return _wxamnul_tsum; }
            set { _wxamnul_tsum = value; }
        }
    }
}