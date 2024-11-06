using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomAUTO.Model
{
    internal class EmployeeModel : IModel
    {
        public string employeeID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(employeeID) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                return false;
            }

            return true;

        }
    }
}
