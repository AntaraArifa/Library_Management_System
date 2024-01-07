using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    
    public class BorrowingService : IBorrowable
    {
        private bool isBorrowed;

        public bool IsBorrowed
        {
            get { return isBorrowed; }
        }

        public void BorrowItem()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine("Item borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Item is not available for borrowing.");
            }
        }

        public void ReturnItem()
        {
            isBorrowed = false;
            Console.WriteLine("Item returned successfully.");
        }
    }

}
