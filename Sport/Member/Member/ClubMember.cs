using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class ClubMember
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;
        protected const int fixedCharge = 100;

        public int AnnualFee
        {
            get
            {
                return this.annualFee;
            }
            set
            {
                this.annualFee = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }
        public int MemberSince
        {
            get { return this.memberSince; }
            set { this.memberSince = value; }
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
                "\nMember Since: " + MemberSince +
                "\nTotal Annual Fee: " + annualFee;
        }

        public ClubMember()
        {
            Console.WriteLine("This is parent constructor with no argument");
        }

        public ClubMember(string name, int pMemberId, int pMemberSince)
        {
            Console.WriteLine("This is parent constructor with 3 arguments");
            this.name = name;
            this.memberID = pMemberId;
            this.memberSince = pMemberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }
}
