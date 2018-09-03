using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Commons
{
    public class Helper
    {
        public static bool CheckConnection(DbContext context)
        {
            try
            {
                context.Database.Connection.Open();
                context.Database.Connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public static Type GetMenuOrderByType(string str)
        {
            var subMenuOrderBy = str.Replace(" ", string.Empty);

            var menuOrderByPath = "DataLayer.Extensions.MenuOrderBy";

            return Type.GetType(string.Join(string.Empty, menuOrderByPath, subMenuOrderBy));
        }
        
    }
}
