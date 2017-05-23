using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace CSharpDBOperation
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID=csharpdb;Password=csharpdb;");
    }
}
