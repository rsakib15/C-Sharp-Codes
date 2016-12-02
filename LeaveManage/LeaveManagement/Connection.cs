using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Leave
{
    class Connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID=LeaveManage;Password=123456;");
   
    
    }
}
