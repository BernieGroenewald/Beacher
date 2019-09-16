using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beacher
{
    public static class GlobalStatic
    {
        private static string _ConnectionString = "";
        private static string _ServerName = "";
        private static string _DBType = "";
        private static string _DefaultUploadPath = @"c:\";

        public static string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        public static string ServerName
        {
            get { return _ServerName; }
            set { _ServerName = value; }
        }

        public static string DBType
        {
            get { return _DBType; }
            set { _DBType = value; }
        }

        public static string DefaultUploadPath
        {
            get { return _DefaultUploadPath; }
            set { _DefaultUploadPath = value; }
        }
    }
}
