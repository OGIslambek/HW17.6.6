using HW17._6._6.Accounts;

namespace HW17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new SalaryAccount();
            account1.Balance = 1000.0;
            account1.CalculateInterest();

            var account2 = new SalaryAccount();
            account2.Balance = 10000.0;
            account2.CalculateInterest();
        }
    }
}
