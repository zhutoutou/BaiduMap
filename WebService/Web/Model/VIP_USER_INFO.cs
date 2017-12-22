using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// VIP用户信息表
    /// </summary>
    [Serializable]
    public class VIP_USER_INFO
    {

        /// <summary>
        /// 用户ID
        /// </summary>		
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>		
        private string _mc;
        public string MC
        {
            get { return _mc; }
            set { _mc = value; }
        }
        /// <summary>
        /// 类型
        /// </summary>		
        private decimal _lx;
        public decimal LX
        {
            get { return _lx; }
            set { _lx = value; }
        }
        /// <summary>
        /// 级别
        /// </summary>		
        private decimal _jb;
        public decimal JB
        {
            get { return _jb; }
            set { _jb = value; }
        }
        /// <summary>
        /// 地址
        /// </summary>		
        private string _dz;
        public string DZ
        {
            get { return _dz; }
            set { _dz = value; }
        }
        /// <summary>
        /// 电话
        /// </summary>		
        private string _dh;
        public string DH
        {
            get { return _dh; }
            set { _dh = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>		
        private string _lxr;
        public string LXR
        {
            get { return _lxr; }
            set { _lxr = value; }
        }
        /// <summary>
        /// 联系人电话
        /// </summary>		
        private string _lxdh;
        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }

    }
}