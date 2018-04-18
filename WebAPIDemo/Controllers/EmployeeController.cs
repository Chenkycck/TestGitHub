using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeService;

namespace WebAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (CKTestingEntities entities = new CKTestingEntities())
            {
                
                return entities.Employees.ToList();
            }
            
        }


    }
}
