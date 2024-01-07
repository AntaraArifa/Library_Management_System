using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    // BorrowMember class
    public class BorrowMember : LibraryMember
    {
        public void BorrowItem(BookState item, IBorrowable service)
        {
            service.BorrowItem(); // Use the BorrowingService
            Console.WriteLine($"{MemberName} borrowed {item.Display()}");
        }

        public void ReturnItem(IBorrowable service)
        {
            service.ReturnItem();
            Console.WriteLine($"{MemberName} returned {((IDisplayable)service).Display()}");
        }

        public override void DisplayMemberInfo()
        {
            base.DisplayMemberInfo();
            Console.WriteLine("Borrow Member");
        }
    }


}
