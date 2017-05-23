using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ShoppingMallDataAccess
    {
        public int Add(ShoppingMall shoppingMall)
        {
            string query = string.Format("INSERT INTO ShoppingMall VALUES({0}, '{1}', '{2}','{3}','{4}')", shoppingMall.Id, shoppingMall.Name, shoppingMall.Address, shoppingMall.Phone, shoppingMall.Area);
            return DataAccess.ExecuteQuery(query);
        }

        public int EditPhone(ShoppingMall shoppingMall)
        {
            string query = string.Format("Update ShoppingMall set Phone='" + shoppingMall.Phone + "' where id=" + (shoppingMall.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditName(ShoppingMall shoppingMall)
        {
            string query = string.Format("Update shoppingMall set Name='" + shoppingMall.Name + "' where id=" + (shoppingMall.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditAddress(ShoppingMall shoppingMall)
        {
            string query = string.Format("Update shoppingMall set Address='" + shoppingMall.Address + "' where id=" + (shoppingMall.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditArea(ShoppingMall shoppingMall)
        {
            string query = string.Format("Update shoppingMall set Area='" + shoppingMall.Area + "' where id=" + (shoppingMall.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int Delete(ShoppingMall shoppingMall)
        {
            string query = string.Format("Delete from ShoppingMall where id=" + shoppingMall.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public List<ShoppingMall> GetAll()
        {
            string query = "SELECT * FROM shoppingMall";
            SqlDataReader reader = DataAccess.GetData(query);

            ShoppingMall shoppingMall = null;
            List<ShoppingMall> shoppingMallList = new List<ShoppingMall>();
            while (reader.Read())
            {
                shoppingMall = new ShoppingMall();
                shoppingMall.Id = Convert.ToInt32(reader["Id"]);
                shoppingMall.Name = reader["Name"].ToString();
                shoppingMall.Address = reader["Address"].ToString();
                shoppingMall.Phone = reader["Phone"].ToString();
                shoppingMall.Area = reader["Area"].ToString();

                shoppingMallList.Add(shoppingMall);
            }
            return shoppingMallList;
        }

        public List<ShoppingMall> GetByArea(ShoppingMall shoppingMall1)
        {
            string query = "SELECT id, name,address, phone FROM shoppingMall WHERE area='" + shoppingMall1.Area + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();
            List<ShoppingMall> shoppingMallList = new List<ShoppingMall>();
            ShoppingMall shoppingMall = null;

            while (reader.Read() == true)
            {
                shoppingMall = new ShoppingMall();
                shoppingMall.Id = Convert.ToInt32(reader["Id"]);
                shoppingMall.Name = reader["Name"].ToString();
                shoppingMall.Address = reader["Address"].ToString();
                shoppingMall.Phone = reader["Phone"].ToString();
                shoppingMallList.Add(shoppingMall);
            }
            return shoppingMallList;
        }
    }
}
