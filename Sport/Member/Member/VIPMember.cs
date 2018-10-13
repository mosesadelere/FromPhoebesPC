using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class VIPMember : ClubMember
    {
        public VIPMember(string name, int memberID, int memberSince) : 
            base(name, memberID, memberSince)
        {
            Console.WriteLine("This is child class with 3 arguments");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
