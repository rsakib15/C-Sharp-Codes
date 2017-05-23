using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using BusinessAccessLayer;


namespace DataAccessLayer
{
    public class AdminDataAccess
    {
        public List<Admin> GetAll()
        {
            string query = "SELECT * FROM Admin";
            SqlDataReader reader = DataAccess.GetData(query);

            Admin admin = null;
            List<Admin> adminList = new List<Admin>();
            while (reader.Read())
            {
                admin = new Admin();
               
                admin.Name = reader["Name"].ToString();
                admin.Password = reader["Password"].ToString();
                

                adminList.Add(admin);
            }
            return adminList;
        }
    }
}
