using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessAccessLayer
{
    public class RestaurantService
    {
        RestaurantDataAccess restaurantDataAccess = new RestaurantDataAccess();

        public int Add(Restaurant restaurant)
        {
            return restaurantDataAccess.Add(restaurant);
        }
        public int EditPhone(Restaurant restaurant)
        {
            return restaurantDataAccess.EditPhone(restaurant);
        }
        public int EditName(Restaurant restaurant)
        {
            return restaurantDataAccess.EditName(restaurant);
        }
        public int EditAddress(Restaurant restaurant)
        {
            return restaurantDataAccess.EditAddress(restaurant);
        }
        public int EditArea(Restaurant restaurant)
        {
            return restaurantDataAccess.EditArea(restaurant);
        }
        public int Delete(Restaurant restaurant)
        {
            return restaurantDataAccess.Delete(restaurant);
        }
        public List<Restaurant> GetAll()
        {
            return restaurantDataAccess.GetAll();
        }
        public List<Restaurant> GetByArea(Restaurant restaurant)
        {
            return restaurantDataAccess.GetByArea(restaurant);
        }
    }
}
