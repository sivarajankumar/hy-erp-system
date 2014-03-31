using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace Hy.Erp.system.Common
{
    public class FileHelper
    {
        public static bool DeleteFile(string path)
        {
            FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(path));
            if (file.Exists)
            {
                file.Delete();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


