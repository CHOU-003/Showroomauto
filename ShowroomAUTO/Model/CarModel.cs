using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ShowroomAUTO.Model
{
    internal class CarModel : IModel
    {
        public string carID { get; set; }
        public string brand { get; set; }
        public string model { get; set; }

        public string price { get; set; }

        public string status { get; set; }

        public string color { get; set; }


        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(carID) || string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model)
                || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(color))
            {
                return false;
            }

            return true;

        }
    }
}
