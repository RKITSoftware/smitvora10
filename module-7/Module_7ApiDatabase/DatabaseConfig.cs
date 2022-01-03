using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Module_7ApiDatabase
{
    public class DatabaseConfig
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["mysqlconnection"].ConnectionString.ToString();

    }
}