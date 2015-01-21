using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string holderFirstName;
            string holderMiddleName;
            string holderLastName;
            decimal balance;
            string bankName;
            string IBAN;
            string BIC_Code;
            long creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;

            holderFirstName = "Cvetomir";
            holderMiddleName = "Dimitrov";
            holderLastName = "Stanev";
            balance = 1.33M;
            bankName = "Pireus";
            IBAN = "BG98743589655654";
            BIC_Code = "FDSKFD";
            creditCardNumber1 = 5345465687;
            creditCardNumber2 = 4328138438;
            creditCardNumber3 = 8865939234;

            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);
        }
    }
}
