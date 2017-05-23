using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessAccessLayer
{
    public class HospitalService
    {
        HospitalDataAccess hospitalDataAccess = new HospitalDataAccess();

        public int Add(Hospital hospital)
        {
            return hospitalDataAccess.Add(hospital);
        }
        public int EditPhone(Hospital hospital)
        {
            return hospitalDataAccess.EditPhone(hospital);
        }
        public int EditName(Hospital hospital)
        {
            return hospitalDataAccess.EditName(hospital);
        }
        public int EditAddress(Hospital hospital)
        {
            return hospitalDataAccess.EditAddress(hospital);
        }
        public int EditArea(Hospital hospital)
        {
            return hospitalDataAccess.EditArea(hospital);
        }
        public int Delete(Hospital hospital)
        {
            return hospitalDataAccess.Delete(hospital);
        }
        public List<Hospital> GetAll()
        {
            return hospitalDataAccess.GetAll();
        }
        public List<Hospital> GetByArea(Hospital hospital)
        {
            return hospitalDataAccess.GetByArea(hospital);
        }
    }
}
