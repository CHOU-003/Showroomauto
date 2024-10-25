using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomAUTO.Model
{
    internal class CustomerModel : IModel
    {
        public string customerID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public string address { get; set; }
        public string status { get; set; }

        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(customerID) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone)
                || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(status))
            {
                return false;
            }

            return true;

        }
    }
}
