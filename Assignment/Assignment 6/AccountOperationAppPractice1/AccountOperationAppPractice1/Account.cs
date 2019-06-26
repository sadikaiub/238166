using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public double AccountNumber{ get; set; }
        public string CustomerName { get; set; }

        public double Balance { get; set; }
        public double Amount { get; set; }

        public double Deposit()
        {
           return Balance = Balance + Amount;
        }

        public double Withdraw()
        {
            return Balance = Balance - Withdraw();
        }

      
    }
}
