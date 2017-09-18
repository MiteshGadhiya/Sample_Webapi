using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpRepository
    {
        Sample_WebAPIEntities objSample_WebAPIEntities;
        public EmpRepository()
        {
            objSample_WebAPIEntities = new Sample_WebAPIEntities();
        }
        public int? InsertEmp(string NAME)
        {
            ObjectParameter IsSaved = new ObjectParameter("IsSaved", typeof(int)); 
            objSample_WebAPIEntities.InsertEmp(NAME,IsSaved);
            return Convert.ToInt32(IsSaved.Value);
        }
        public List<GetAllEmps_Result> GetAllEmps()
        {
            return objSample_WebAPIEntities.GetAllEmps().ToList();
        }
    }
}
