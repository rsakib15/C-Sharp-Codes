using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class PharmacyService
    {
        PharmacyDataAccess pharmacyDataAccess = new PharmacyDataAccess();
        public int Add(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.Add(pharmacy);
        }

        public int EditPhone(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.EditPhone(pharmacy);
        }
        public int EditName(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.EditName(pharmacy);
        }
        public int EditAddress(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.EditAddress(pharmacy);
        }
        public int EditArea(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.EditArea(pharmacy);
        }
        public int Delete(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.Delete(pharmacy);
        }
        public List<Pharmacy> GetAll()
        {
            return pharmacyDataAccess.GetAll();
        }
        public List<Pharmacy> GetByArea(Pharmacy pharmacy)
        {
            return pharmacyDataAccess.GetByArea(pharmacy);
        }
    }
}
