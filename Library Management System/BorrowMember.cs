using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BorrowMember : LibraryMember
    {
        public void BorrowItem(BookState item, IBorrowable service)
        {
            service.BorrowItem(); // Use the BorrowingService
            Console.WriteLine($"{MemberName} borrowed {item.Display()}");
        }

        public void ReturnItem(BookState item, IBorrowable service)
        {
            try
            {
                service.ReturnItem();
                Console.WriteLine($"{MemberName} returned {item.Display()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during return: {ex.Message}");
                // You can handle the exception as per your requirements
            }
        }

        public override void DisplayMemberInfo()
        {
            base.DisplayMemberInfo();
            Console.WriteLine("Borrow Member");
        }

        public override void AddMember(LibraryMember member)
        {
            // Additional logic for adding a member in BorrowMember
            Console.WriteLine($"Borrow Member {member.MemberName} added.");
        }
    }


}
