using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bank
{
    class Users
    {
        private long balance;
        private string holder;
        private string types;
        private string currency;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        
        public long Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public string Holder
        {
            get
            {
                return this.holder;
            }
            set
            {
                this.holder = value;
            }
        }

        public string Currency
        {
            get
            {
                return this.currency;
            }

            set
            {
                this.currency = value;
            }

        }
        
        public string Type
        {
            get
            {
                return this.types;
            }

            set
            {
                this.types = value;
            }
        }
        // Constructor
        public Users()
        {
            Console.Write("Holder's name: ");
            holder = Console.ReadLine();
            Console.Write("Account type:(Current or Savings): ");
            types = Console.ReadLine();
            Console.Write("Balance: ");
            balance = long.Parse(Console.ReadLine());
            Console.Write("Currency:(£, $, €): ");
            currency = Console.ReadLine();
            
        }

        public Users(string holder, string types, long balance, string currency)
        {
            this.holder = holder;
            this.types = types;
            this.balance = balance;
            this.currency = currency;
        }
        protected string setAccount()
        {
            string userAccount = textInfo.ToTitleCase(holder) + " | " + types + " Account ";
            string money = " | Balance:"+ currency + balance;
            string longDetails = userAccount + money;

            return longDetails;
        }

        public void printLine()
        {
            Console.WriteLine(setAccount());
        }
    }
}
