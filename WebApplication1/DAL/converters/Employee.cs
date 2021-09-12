using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Employee
    {
        public EmployeeCommon ConvertToCommon(Employee employee)
        {
            EmployeeCommon employeeCommon = new EmployeeCommon();
            employeeCommon.ID = employee.ID;
            employeeCommon.NUMBER = employee.NUMBER;
            employeeCommon.FIRSTNAME = employee.FIRSTNAME;
            employeeCommon.LASTNAME = employee.LASTNAME;
            employeeCommon.STATUSS = employee.STATUSS;
            employeeCommon.DATESTART = employee.DATESTART;
            employeeCommon.CLASS = employee.CLASS;
            return employeeCommon;
        }
        //Employee.ConvertFromCommon(employeeCommon)
        //הוספתי static
        public static Employee ConvertFromCommon(EmployeeCommon employeeCommon)
        {
            Employee employee = new Employee();
            employee.ID = employeeCommon.ID;
            employee.NUMBER = employeeCommon.NUMBER;
            employee.FIRSTNAME = employeeCommon.FIRSTNAME;
            employee.LASTNAME = employeeCommon.LASTNAME;
            employee.STATUSS = employeeCommon.STATUSS;
            employee.DATESTART = employeeCommon.DATESTART;
            employee.CLASS = employeeCommon.CLASS;

            return employee;
        }
    }
}
