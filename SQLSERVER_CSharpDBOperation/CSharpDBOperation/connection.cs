using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CSharpDBOperation
{
    class connection
    {
        public SqlConnection thisConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=csharpdb;Integrated Security=SSPI");    
    }
}
