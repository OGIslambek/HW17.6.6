using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17._6._6.Accounts
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public abstract void CalculateInterest();
    }
}
