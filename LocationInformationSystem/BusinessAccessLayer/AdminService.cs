using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessAccessLayer
{
    public class AdminService
    {
        AdminDataAccess adminDataAccess = new AdminDataAccess();
        public List<Admin> GetAll()
        {
            return adminDataAccess.GetAll();
        }
    }
}
