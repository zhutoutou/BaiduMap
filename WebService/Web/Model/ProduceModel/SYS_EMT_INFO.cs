using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.Model
{
    public class SYS_EMT_INFO
    {
        private string _ID;
        /// <summary>
        /// 设备ID
        /// </summary>
        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        private string _NAME;
        /// <summary>
        /// 设备名称
        /// </summary>
        public string NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                _NAME = value;
            }
        }

        private string _HM;
        /// <summary>
        /// 设备号码
        /// </summary>
        public string HM
        {
            get
            {
                return _HM;
            }
            set
            {
                _HM = value;
            }
        }

        private decimal _STATUS;
        /// <summary>
        /// 设备状态
        /// </summary>
        public decimal STATUS
        {
            get
            {
                return _STATUS;
            }
            set
            {
                _STATUS = value;
            }
        }
    }
}
