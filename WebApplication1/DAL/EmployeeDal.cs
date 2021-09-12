using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDal
    {
        public static List<int> getEmployeeId()
        {
            try
            {
                using (DBprojectEntities DB = new DBprojectEntities())
                {
                    //s => s.first_name + " " + s.last_name
                    Console.WriteLine(DB.Employee.ToList().Select(s => s.ID).ToList());
                    return DB.Employee.ToList().Select(s => s.ID).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static EmployeeCommon getEmployeeById(int id)
        {
            try
            {
                using (DBprojectEntities DB = new DBprojectEntities())
                {
                    //s => s.first_name + " " + s.last_name
                    var emp = DB.Employee.ToList().Where(s => s.ID == id).FirstOrDefault();
                    return emp.ConvertToCommon(emp);
                    //  return emp.Select(emp => emp.ConvertToCommon(e).ToList()
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static EmployeeCommon addEmployee(EmployeeCommon employeeCommon)
        {
            try
            {
                using (DBprojectEntities DB = new DBprojectEntities())
                {
                    //s => s.first_name + " " + s.last_name
                    DB.Employee.Add(Employee.ConvertFromCommon(employeeCommon));
                    DB.SaveChanges();
                    var emp = DB.Employee.ToList().Last();
                    return emp.ConvertToCommon(emp);
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
