using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Clinic
    {
        Model.DB db = new Model.DB();

        public List<Model.Clinic> Get_ALL_Clinic()
        {
            List<Model.Clinic> rv = db.Clinics.Where(item => item.Enable == true).ToList();
            return rv;
        }
    }
}
