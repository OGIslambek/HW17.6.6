using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17._6._6.Accounts
{
    public class SalaryAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
