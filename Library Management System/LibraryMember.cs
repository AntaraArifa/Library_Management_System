using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    public class LibraryMember
    {
        public string MemberName { get; set; }

        public virtual void DisplayMemberInfo()
        {
            Console.WriteLine($"Member: {MemberName}");
        }

        public virtual void AddMember(LibraryMember member)
        {
            // Implementation to add a member
            Console.WriteLine($"Member {member.MemberName} added.");
        }
    }


}
