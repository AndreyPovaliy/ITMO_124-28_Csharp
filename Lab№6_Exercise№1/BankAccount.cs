using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Exercise_1

{

    using System;

    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        class BankAccount
        {
            public void Populate(long number, decimal balance)
            {
                accNo = number;
                accBal = balance;
                accType = AccountType.Checking;
            }

            public long Number()
            {
                return accNo;
            }

            public decimal Balance()
            {
                return accBal;
            }

            public string Type()
            {
                return accType.ToString();
            }

            private long accNo;
            private decimal accBal;
            private AccountType accType;
        }


        static BankAccount NewBankAccount()
        {

            BankAccount created = new BankAccount(); ;

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());



            //created.accNo = number;
            // created.accBal = balance;
            //created.accType = AccountType.Checking;
            created.Populate(number, balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.accNo);
            Console.WriteLine("Account balance is {0}", toWrite.accBal);
            Console.WriteLine("Account type is {0}", toWrite.accType.ToString());
        }


    }
}
