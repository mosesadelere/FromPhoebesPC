using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class NormalMember : ClubMember
    {
        public NormalMember()
        {
            Console.WriteLine("This is child constructor with no argument");
        }

        public NormalMember(string remark) : base("Elkanah",1,2018)
        {
            Console.WriteLine("This is child constructor with 3 arguments");
            Console.WriteLine("Remark = {0}", remark);
        }

        public NormalMember(string remark, string name, int memberID, int memberSince) 
            : base(name,memberID,memberSince)
        {
            Console.WriteLine("This is child constructor with 4 arguments");
            Console.WriteLine("Remark = {0}", remark);
        }

        public override void CalculateAnnualFee()
        {
            annualFee = fixedCharge + (12*30);
        }
        
    }
}
