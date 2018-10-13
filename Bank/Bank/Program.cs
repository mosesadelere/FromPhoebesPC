using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal startTime = Environment.TickCount;
            Users user = new Users();
           // user.User();
            user.printLine();

            user.Holder = "Ninolowo Baba Rasheed";
            user.Type = "Savings";
            user.Balance = 145875;
            user.Currency = "£";
            user.printLine();

            Sorting sort = new Sorting();
            int[] num = sort.Sort(10,4,87,2,0,5,58);
            sort.printLine(num);

            Cats firstCat = new Cats();
            // cat name can also be changed
            //firstCat.Name = "catty";
            firstCat.SayMiauuuu();

            Cats secondCat = new Cats("Puppo","grey");
            secondCat.SayMiauuuu();
            Console.WriteLine("Cat {0} is {1}", secondCat.Name, secondCat.Color);

            decimal endTime = Environment.TickCount;
            Console.WriteLine("It takes {0} sec to execute this.", (endTime - startTime) / 1000);

            Console.ReadLine();
        }
    }
}
