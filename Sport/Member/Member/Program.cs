using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClubMember NewMember = new NormalMember();
            //ClubMember clubMember = new NormalMember("Excellence", "Hadassah", 1, 2018);

            //NormalMember mem_1 = new NormalMember("Special rate","Ethan", 10, 2008);
            //VIPMember mem_2 = new VIPMember("Annabel", 13, 2005);

            //mem_1.CalculateAnnualFee();
            //mem_2.CalculateAnnualFee();
            ClubMember[] newMember = new ClubMember[5];
            newMember[0] = new NormalMember("Excellence", "Hadassah", 1, 2018);
            newMember[1] = new NormalMember("Excellence", "Elkanah", 1, 2018);
            newMember[2] = new VIPMember("Mirabel", 1, 2018);
            newMember[3] = new NormalMember("Excellence", "Ethan", 1, 2018);
            newMember[4] = new VIPMember("Annabel", 1, 2018);

            foreach(ClubMember mem in newMember)
            {
                mem.CalculateAnnualFee();
                Console.WriteLine(mem.ToString());
            }


            point2D points = new point2D(3,-2);
            MyStruct myStruct = new MyStruct();
            point2d.PrintPoint();
            
            //Console.WriteLine(mem_1.ToString());
            //Console.WriteLine(mem_2.ToString());
            Console.ReadKey();
        }
    }
}
