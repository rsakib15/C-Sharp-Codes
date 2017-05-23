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
    public class HospitalDataAccess
    {
        public int Add(Hospital hospital)
        {
            string query = string.Format("INSERT INTO Hospital VALUES({0}, '{1}', '{2}','{3}','{4}')", hospital.Id, hospital.Name, hospital.Address, hospital.Phone, hospital.Area);
            return DataAccess.ExecuteQuery(query);
        }
        public int EditPhone(Hospital hospital)
        {
            string query = string.Format("Update Hospital set Phone='" + hospital.Phone + "' where id=" + (hospital.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditName(Hospital hospital)
        {
            string query = string.Format("Update Hospital set Name='" + hospital.Name + "' where id=" + (hospital.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditAddress(Hospital hospital)
        {
            string query = string.Format("Update Hospital set Address='" + hospital.Address + "' where id=" + (hospital.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditArea(Hospital hospital)
        {
            string query = string.Format("Update Hospital set Area='" + hospital.Area + "' where id=" + (hospital.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int Delete(Hospital hospital)
        {
            string query = string.Format("Delete from Hospital where id=" + hospital.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Hospital> GetAll()
        {
            string query = "SELECT * FROM Hospital";
            SqlDataReader reader = DataAccess.GetData(query);

            Hospital hospital = null;
            List<Hospital> hospitalList = new List<Hospital>();
            while (reader.Read())
            {
                hospital = new Hospital();
                hospital.Id = Convert.ToInt32(reader["Id"]);
                hospital.Name = reader["Name"].ToString();
                hospital.Address = reader["Address"].ToString();
                hospital.Phone = reader["Phone"].ToString();
                hospital.Area = reader["Area"].ToString();

                hospitalList.Add(hospital);
            }
            return hospitalList;
        }
        public List<Hospital> GetByArea(Hospital hospital1)
        {
            string query = "SELECT id, name,address, phone FROM Hospital WHERE area='" + hospital1.Area+"'";
            SqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();
            List<Hospital> hospitalList = new List<Hospital>();
            Hospital hospital = null;

            while (reader.Read() == true)
            {
                hospital = new Hospital();
                hospital.Id = Convert.ToInt32(reader["Id"]);
                hospital.Name = reader["Name"].ToString();
                hospital.Address = reader["Address"].ToString();
                hospital.Phone = reader["Phone"].ToString();
                hospitalList.Add(hospital);
            }
            return hospitalList;
        }
    }
}



