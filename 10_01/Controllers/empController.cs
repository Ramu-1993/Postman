using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using _10_01.Models;

namespace _10_01.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {
                // Disable ProxyCreation and LazyLoading to prevent serialization issues
                employeeEntities.Configuration.ProxyCreationEnabled = false;
                employeeEntities.Configuration.LazyLoadingEnabled = false;

                // Retrieve and return employees
                return employeeEntities.Employees.ToList();
            }
        }
    }

}