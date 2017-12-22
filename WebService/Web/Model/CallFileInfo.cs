using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class CallFileInfo
    {
        string _filename = string.Empty;
        string _server = string.Empty;
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public string recserverid
        {
            get { return _server; }
            set { _server = value; }
        }
    }
}