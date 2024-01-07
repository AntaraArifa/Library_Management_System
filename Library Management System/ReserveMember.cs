using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    public class ReserveMember : LibraryMember
    {
        public void ReserveItem(BookState item, IReservable service)
        {
            service.ReserveItem(); // Use the ReservingService
            Console.WriteLine($"{MemberName} reserved {item.Display()}");
        }

        public void CancelReservation(IReservable service)
        {
            service.CancelReservation();
            Console.WriteLine($"{MemberName}'s reservation for {((IDisplayable)service).Display()} canceled");
        }

        public override void DisplayMemberInfo()
        {
            base.DisplayMemberInfo();
            Console.WriteLine("Reserve Member");
        }

        public override void AddMember(LibraryMember member)
        {
            // Additional logic for adding a member in ReserveMember
            Console.WriteLine($"Reserve Member {member.MemberName} added.");
        }
    }


}
