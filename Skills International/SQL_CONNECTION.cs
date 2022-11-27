using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills_International
{
    internal class SQL_CONNECTION
    {
        //public string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;Allow User Variables=True;";Allow User Variables=True; Trusted_Connection=True;
        public string ConnectionString = @"data source=LAPTOP-SATORU\SQLEXPRESS;initial catalog=students;Integrated Security=true;";

        public string ERRORconnection = "Check your Connection!";
    }
}
