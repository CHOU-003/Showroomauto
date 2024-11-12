using System;
using System.Threading.Tasks;

namespace ShowroomAUTO.Model
{
    internal class FinanceModel : IModel
    {
        public string financeID { get; set; }
        public string income { get; set; }
        public string expense { get; set; }


        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(financeID) || string.IsNullOrWhiteSpace(income) || string.IsNullOrWhiteSpace(expense))
            {
                return false;
            }

            return true;

        }
    }
}
