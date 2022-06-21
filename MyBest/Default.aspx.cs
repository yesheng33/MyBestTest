using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Model.Model1 db = new Model.Model1();
            //List<Model.Employee> ep =  db.Employee.Where(item => item.Enable == true).ToList();
            DAL.DAL_Clinic dal = new DAL.DAL_Clinic();
            List<DAL.Model.Clinic> list = dal.Get_ALL_Clinic();



         }
    }
}