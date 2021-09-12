using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Employee_Presence
    {
        public Employee_PresenceCommon ConvertToCommon(Employee_Presence employee_Presence)
        {
            Employee_PresenceCommon employee_PresenceCommon = new Employee_PresenceCommon();
            employee_PresenceCommon.Employee_ID = employee_Presence.Employee_ID;
            employee_PresenceCommon.Entry_ = employee_Presence.Entry_;
            employee_PresenceCommon.Exit_ = employee_Presence.Exit_;
            employee_PresenceCommon.Date_ = employee_Presence.Date_;
            employee_PresenceCommon.Institution_Number = employee_Presence.Institution_Number;
            return employee_PresenceCommon;
        }

        public Employee_Presence ConvertFromCommon(Employee_PresenceCommon employee_PresenceCommon)
        {
            Employee_Presence employee_Presence = new Employee_Presence();
            employee_Presence.Employee_ID = employee_PresenceCommon.Employee_ID;
            employee_Presence.Entry_ = employee_PresenceCommon.Entry_;
            employee_Presence.Exit_ = employee_PresenceCommon.Exit_;
            employee_Presence.Date_ = employee_PresenceCommon.Date_;
            employee_Presence.Institution_Number = employee_PresenceCommon.Institution_Number;

            return employee_Presence;
        }
    }
}
