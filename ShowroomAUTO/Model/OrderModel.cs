using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShowroomAUTO.Model
{
    internal class OrderModel : IModel
    {
        public string orderID { get; set; }
        public string customer_id { get; set; }
        public string car_id { get; set; }
        public string employee_id { get; set; }
        public DateTime orderDate { get; set; }
        public decimal value { get; set; }

        public bool IsValidate()
        {
            // Kiểm tra nếu các trường dạng chuỗi rỗng hoặc chứa khoảng trắng
            if (string.IsNullOrWhiteSpace(orderID)
                || string.IsNullOrWhiteSpace(customer_id)
                || string.IsNullOrWhiteSpace(car_id)
                || string.IsNullOrWhiteSpace(employee_id))
            {
                return false;
            }

            // Kiểm tra nếu orderDate là giá trị mặc định
            if (orderDate == default(DateTime))
            {
                return false;
            }

            // Kiểm tra nếu value là số âm hoặc bằng 0
            if (value <= 0)
            {
                return false;
            }

            return true;
        }

    }

}
