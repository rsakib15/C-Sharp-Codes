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
    public class RestaurantDataAccess
    {
        public int Add(Restaurant restaurant)
        {
            string query = string.Format("INSERT INTO Restaurant VALUES({0}, '{1}', '{2}','{3}','{4}')", restaurant.Id, restaurant.Name, restaurant.Address, restaurant.Phone, restaurant.Area);
            return DataAccess.ExecuteQuery(query);
        }
        public int EditPhone(Restaurant restaurant)
        {
            string query = string.Format("Update Restaurant set Phone='" + restaurant.Phone + "' where id=" + (restaurant.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditName(Restaurant restaurant)
        {
            string query = string.Format("Update Restaurant set Name='" + restaurant.Name + "' where id=" + (restaurant.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditAddress(Restaurant restaurant)
        {
            string query = string.Format("Update restaurant set Address='" + restaurant.Address + "' where id=" + (restaurant.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int EditArea(Restaurant restaurant)
        {
            string query = string.Format("Update restaurant set Area='" + restaurant.Area + "' where id=" + (restaurant.Id).ToString());
            return DataAccess.ExecuteQuery(query);
        }
        public int Delete(Restaurant restaurant)
        {
            string query = string.Format("Delete from restaurant where id=" + restaurant.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Restaurant> GetAll()
        {
            string query = "SELECT * FROM restaurant";
            SqlDataReader reader = DataAccess.GetData(query);

            Restaurant restaurant = null;
            List<Restaurant> restaurantList = new List<Restaurant>();
            while (reader.Read())
            {
                restaurant = new Restaurant();
                restaurant.Id = Convert.ToInt32(reader["Id"]);
                restaurant.Name = reader["Name"].ToString();
                restaurant.Address = reader["Address"].ToString();
                restaurant.Phone = reader["Phone"].ToString();
                restaurant.Area = reader["Area"].ToString();

                restaurantList.Add(restaurant);
            }
            return restaurantList;
        }
        public List<Restaurant> GetByArea(Restaurant restaurant1)
        {
            string query = "SELECT id, name,address, phone FROM restaurant WHERE area='" + restaurant1.Area + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();
            List<Restaurant> restaurantList = new List<Restaurant>();
            Restaurant restaurant = null;

            while (reader.Read() == true)
            {
                restaurant = new Restaurant();
                restaurant.Id = Convert.ToInt32(reader["Id"]);
                restaurant.Name = reader["Name"].ToString();
                restaurant.Address = reader["Address"].ToString();
                restaurant.Phone = reader["Phone"].ToString();
                restaurantList.Add(restaurant);
            }
            return restaurantList;
        }
    }
}



