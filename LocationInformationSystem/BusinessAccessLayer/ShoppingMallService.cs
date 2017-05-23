using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class ShoppingMallService
    {
        ShoppingMallDataAccess shoppingMallDataAccess = new ShoppingMallDataAccess();
        public int Add(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.Add(shoppingMall);
        }

        public int EditPhone(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.EditPhone(shoppingMall);
        }
        public int EditName(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.EditName(shoppingMall);
        }
        public int EditAddress(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.EditAddress(shoppingMall);
        }
        public int EditArea(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.EditArea(shoppingMall);
        }
        public int Delete(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.Delete(shoppingMall);
        }
        public List<ShoppingMall> GetAll()
        {
            return shoppingMallDataAccess.GetAll();
        }
        public List<ShoppingMall> GetByArea(ShoppingMall shoppingMall)
        {
            return shoppingMallDataAccess.GetByArea(shoppingMall);
        }
    }
}
