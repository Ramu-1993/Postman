using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi1.Models;

namespace webapi1.Controllers
{
    public class EmpController : ApiController
    { 
            [HttpGet]
            public List<Employee> GetEmployees()
            {
                EmpEntities employeeEntities2 = new EmpEntities();
                List<Employee> employeeTables = new List<Employee>();
                employeeTables = employeeEntities2.Employees.ToList();
                return employeeTables;
            }

            [HttpGet]
            public Employee GetEmployeeById(int id)
            {
                EmpEntities employeeEntities2 = new EmpEntities();
                Employee employeeTable = new Employee();
                employeeTable = employeeEntities2.Employees.Find(id);
                return employeeTable;


            }

            [HttpPost]

            public string CreateEmployee(Employee employee)
            {
                EmpEntities employeeEntities2 = new EmpEntities();

                employeeEntities2.Employees.Add(employee);
                employeeEntities2.SaveChanges();
                return "Employee record is inserted";


            }

            [HttpPut]

            public string UpdateEmployee(Employee employee)
            {
                EmpEntities employeeEntities2 = new EmpEntities();
            Employee emp = employeeEntities2.Employees.Find(employee.ID);
                emp.Name = employee.Name;
            emp.DepartmentID = employee.DepartmentID;
            emp.location = employee.location;
                employeeEntities2.SaveChanges();
                return "Employee record is updated";


            }

            [HttpDelete]

            public string DeleteEmployee(int id)
            {
                EmpEntities employeeEntities2 = new EmpEntities();
            Employee emp = employeeEntities2.Employees.Find(id);
                employeeEntities2.Employees.Remove(emp);
                employeeEntities2.SaveChanges();
                return "Employee record is updated";


            }




        }
    }