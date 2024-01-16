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
            try
            {
                service.ReserveItem(); // Use the ReservingService
                Console.WriteLine($"{MemberName} reserved {item.Display()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during reservation: {ex.Message}");
                // You can handle the exception as per your requirements
            }
        }

        public void CancelReservation(BookState item, IReservable service)
        {
            try
            {
                service.CancelReservation();
                Console.WriteLine($"{MemberName}'s reservation for {item.Display()} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during reservation cancellation: {ex.Message}");
                // You can handle the exception as per your requirements
            }
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
