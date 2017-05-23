using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PharmacyDataAccess
    {
        public int Add(Pharmacy pharmacy)
        {
            string query = string.Format("INSERT INTO Pharmacy VALUES({0}, '{1}', '{2}','{3}','{4}')", pharmacy.Id, pharmacy.Name, pharmacy.Address, pharmacy.Phone, pharmacy.Area);
            return DataAccess.ExecuteQuery(query);
        }

        public int EditPhone(Pharmacy pharmacy)
        {
            string query = string.Format("Update Pharmacy set Phone='" + pharmacy.Phone + "' where id=" + (pharmacy.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditName(Pharmacy pharmacy)
        {
            string query = string.Format("Update Pharmacy set Name='" + pharmacy.Name + "' where id=" + (pharmacy.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditAddress(Pharmacy pharmacy)
        {
            string query = string.Format("Update Pharmacy set Address='" + pharmacy.Address + "' where id=" + (pharmacy.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditArea(Pharmacy pharmacy)
        {
            string query = string.Format("Update Pharmacy set Area='" + pharmacy.Area + "' where id=" + (pharmacy.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int Delete(Pharmacy pharmacy)
        {
            string query = string.Format("Delete from Pharmacy where id=" + pharmacy.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Pharmacy> GetAll()
        {
            string query = "SELECT * FROM Pharmacy";
            SqlDataReader reader = DataAccess.GetData(query);

            Pharmacy pharmacy = null;
            List<Pharmacy> pharmacyList = new List<Pharmacy>();
            while (reader.Read())
            {
                pharmacy = new Pharmacy();
                pharmacy.Id = Convert.ToInt32(reader["Id"]);
                pharmacy.Name = reader["Name"].ToString();
                pharmacy.Address = reader["Address"].ToString();
                pharmacy.Phone = reader["Phone"].ToString();
                pharmacy.Area = reader["Area"].ToString();

                pharmacyList.Add(pharmacy);
            }
            return pharmacyList;
        }

        public List<Pharmacy> GetByArea(Pharmacy pharmacy1)
        {
            string query = "SELECT id, name,address, phone FROM Pharmacy WHERE area='" + pharmacy1.Area + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();
            List<Pharmacy> pharmacyList = new List<Pharmacy>();
            Pharmacy pharmacy = null;

            while (reader.Read() == true)
            {
                pharmacy = new Pharmacy();
                pharmacy.Id = Convert.ToInt32(reader["Id"]);
                pharmacy.Name = reader["Name"].ToString();
                pharmacy.Address = reader["Address"].ToString();
                pharmacy.Phone = reader["Phone"].ToString();
                pharmacyList.Add(pharmacy);
            }
            return pharmacyList;
        }
    }
}
