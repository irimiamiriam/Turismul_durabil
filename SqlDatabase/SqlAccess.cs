using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_durabil.SqlDatabase
{
    class SqlAccess
    {
        public static string GetConnectionPath()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetTxtPath()
        {
            return ConfigurationManager.AppSettings["DatePlanificari"];
        }
    }

}
