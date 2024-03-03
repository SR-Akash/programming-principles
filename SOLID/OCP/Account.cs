using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    #region Without OCP
    public class Account
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public double CalculateInterest(string accountType)
        {
            if (accountType == "Saving")
            {
                return Balance * 0.3;
            }
            else
            {
                return Balance * 0.5;
            }
        }
    }
    #endregion

    #region Following OCP the Pre requicite is SRP
    public class AccountDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
    }

    public interface IAccount
    {
        public double CalculateInterest(AccountDetails account);
    }

    public class SavingAccount : IAccount
    {
        public double CalculateInterest(AccountDetails account)
        {
            return account.Balance * 0.3;
        }
    }

    public class OtherAccount : IAccount
    {
        public double CalculateInterest(AccountDetails account)
        {
            return account.Balance * 0.5;
        }
    }

    public class CurrentAccount : IAccount
    {
        public double CalculateInterest(AccountDetails account)
        {
            return account.Balance * 1;
        }
    }
    #endregion
}
