using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    [Serializable]
    public class FZ_NOTICE
    {
        private string _LSH;
        public string LSH
        {
            get
            {
                return _LSH;
            }
            set
            {
                _LSH = value;
            }
        }

        private decimal _XH;
        public decimal XH
        {
            get
            {
                return _XH;
            }
            set
            {
                _XH = value;
            }
        }

        private DateTime _ANC_TIME = DateTime.Now;
        public DateTime ANC_TIME
        {
            get
            {
                return _ANC_TIME;
            }
            set
            {
                _ANC_TIME = value;
            }
        }

        private string _INDATE;
        /// <summary>
        /// 有效期。单位：小时
        /// </summary>
        public string INDATE
        {
            get
            {
                return _INDATE;
            }
            set
            {
                _INDATE = value;
            }
        }


        private decimal _TYPE;
        /// <summary>
        /// 发布类型
        /// </summary>
        public decimal TYPE
        {
            get
            {
                return _TYPE;
            }
            set
            {
                _TYPE = value;
            }
        }

        private string _TYPENAME;
        /// <summary>
        /// 发布类型说明
        /// </summary>
        public string TYPENAME
        {
            get
            {
                return _TYPENAME;
            }
            set
            {
                _TYPENAME = value;
            }
        }

        private decimal _STATUS;
        /// <summary>
        /// 状态。标识公告是否已阅，0 否 1 是
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

        private decimal _RECEIVER_TYPE;
        /// <summary>
        /// 接收人类型。0 代表受理台，1 代表 分站 ，2 代表车辆
        /// </summary>
        public decimal RECEIVER_TYPE
        {
            get
            {
                return _RECEIVER_TYPE;
            }
            set
            {
                _RECEIVER_TYPE = value;
            }
        }

        private string _RECEIVER;
        /// <summary>
        /// 接收人
        /// </summary>
        public string RECEIVER
        {
            get
            {
                return _RECEIVER;
            }
            set
            {
                _RECEIVER = value;
            }
        }



        private DateTime _LAST_MODIFY_TIME;
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime LAST_MODIFY_TIME
        {
            get
            {
                return _LAST_MODIFY_TIME;
            }
            set
            {
                _LAST_MODIFY_TIME = value;
            }
        }

        private string _ANC_CONT = "";
        /// <summary>
        /// 发布内容
        /// </summary>
        public string ANC_CONT
        {
            get
            {
                return _ANC_CONT;
            }
            set
            {
                _ANC_CONT = value;
            }
        }

        private string _remark = "查看";
        /// <summary>
        /// 查看字段
        /// </summary>
        public string Remark
        {
            get
            {
                return _remark;
            }

            set
            {
                _remark = value;
            }
        }


        private string _FBR = "";
        /// <summary>
        /// 发布者
        /// </summary>
        public string FBR
        {
            get
            {
                return _FBR;
            }
            set
            {
                _FBR = value;
            }
        }

        private decimal _XZBM;
        /// <summary>
        /// 行政编码
        /// </summary>
        public decimal XZBM
        {
            get
            {
                return _XZBM;
            }
            set
            {
                _XZBM = value;
            }
        }

    }
}