using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class V_CALLID_CACHE
    {
        string _lsh = string.Empty;
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }
        string _callid = string.Empty;
        public string CALLID
        {
            get { return _callid; }
            set { _callid = value; }
        }
    }
}