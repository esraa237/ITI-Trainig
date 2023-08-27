using Third_version.Models;

namespace Third_version.BLL
{
    public class DepartmentBLL
    {

        ITIContext dp = new ITIContext();
        public List<Department> GetAll()
        {
            return dp.Departments.ToList();
        }
    }
}
