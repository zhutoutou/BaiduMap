using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
   /// <summary>
    /// 根据电话号码获取受理详情
   /// </summary>
    public class SP_GET_OBLIGATE_ACCEPT_INFO
    {
        private DateTime _hjsj;
        /// <summary>
        /// 呼叫时间
        /// </summary>	
        public DateTime HJSJ
        {
            get { return _hjsj; }
            set { _hjsj = value; }
        }

        private string _hjlx;

        /// <summary>
        /// 呼叫类型
        /// </summary>	
        public string HJLX
        {
            get { return _hjlx; }
            set { _hjlx = value; }
        }

        private string _hjzt;

        /// <summary>
        /// 呼叫状态
        /// </summary>	
        public string HJZT
        {
            get { return _hjzt; }
            set { _hjzt = value; }
        }
        private decimal _zdyh;
        /// <summary>
        /// 是否是重点用户
        /// </summary>	
        public decimal ZDYH
        {
            get { return _zdyh; }
            set { _zdyh = value; }
        }
        private decimal _jb;
        /// <summary>
        /// 呼叫者类型
        /// </summary>	
        public decimal JB
        {
            get { return _jb; }
            set { _jb = value; }
        }  
        
        private string _jbmc;
        /// <summary>
        /// 职务名称
        /// </summary>	
        public string JBMC
        {
            get { return _jbmc; }
            set { _jbmc = value; }
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
        private string _bs;
        /// <summary>
        /// 病史
        /// </summary>	
        public string BS
        {
            get { return _bs; }
            set { _bs = value; }
        }
        private string _mc;
        /// <summary>
        /// 名称
        /// </summary>	
        public string MC
        {
            get { return _mc; }
            set { _mc = value; }
        }
        private string _dz;
        /// <summary>
        /// 地址
        /// </summary>	
        public string DZ
        {
            get { return _dz; }
            set { _dz = value; }
        }
        private string _zw;
        /// <summary>
        /// 职位
        /// </summary>	
        public string ZW
        {
            get { return _zw; }
            set { _zw = value; }
        }
    }
}