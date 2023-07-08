using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_7
{
    public class BankAccount
    {
        public string? Currency { get; set; }
        public string? Iban { get; set; }
        public decimal? Amount { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(string currency, string iban, decimal amount)
        {
            Currency = currency;
            Iban = iban;
            Amount = amount;
        }
    }
}
