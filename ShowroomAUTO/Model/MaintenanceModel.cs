using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomAUTO.Model
{
    internal class MaintenanceModel : IModel
    {
        public string maintenanceID { get; set; }
        public string nameCustomer { get; set; }
        public string vehicle { get; set; }

        public string details { get; set; }

        public string dateBD { get; set; }
        public string typeBD { get; set; }

        public string maintenanceStatus { get; set; }

        public string totalCost { get; set; }

        public string nameEmployee { get; set; }

        public string notes { get; set; }


        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(maintenanceID) || string.IsNullOrWhiteSpace(nameCustomer) || string.IsNullOrWhiteSpace(vehicle)
                || string.IsNullOrWhiteSpace(maintenanceStatus) || string.IsNullOrWhiteSpace(typeBD) || string.IsNullOrWhiteSpace(nameEmployee) )
            {
                return false;
            }

            return true;

        }
    }
}
