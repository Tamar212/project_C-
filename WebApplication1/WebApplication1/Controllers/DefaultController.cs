
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Web.Mvc;
//using System.Collections.Generic;
//using System.Web.Http;
using System.Web.Http.Cors;
using Common;

namespace WebApplication1.Controllers
{
 
    public class EmployeeController : ApiController

    {
        // GET api/values
        [System.Web.Http.Route("api/Values/GetId2")]
        public List<int> GetId2()
        {
            // return BL.EmployeeBL.getEmployeeId().ToList();
            List<int> employeesId = EmployeeBL.getEmployeeId();
            return employeesId;
        }


        // GET: Employee
        

        public IHttpActionResult GetEmployeeById(int id)
        {
            try
            {
                EmployeeCommon employeesId = EmployeeBL.getEmployeeById(id);//שיניתי id
                return Ok(employeesId);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public IHttpActionResult GetEmployee()
        {
            try
            {
                int employeesId = EmployeeBL.getEmployeeId()[0];
                // return Json(employeesId);
                return Ok<string>("I am send by HTTP resonse");

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}