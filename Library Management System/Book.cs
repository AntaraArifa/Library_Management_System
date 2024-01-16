using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book : IDisplayable, IBorrowable, IReservable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        private bool isBorrowed;
        private bool isReserved;

        public bool IsBorrowed
        {
            get { return isBorrowed; }
        }

        public bool IsReserved
        {
            get { return isReserved; }
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

        public void ReserveItem()
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine("Item reserved successfully.");
            }
            else
            {
                Console.WriteLine("Item cannot be reserved.");
            }
        }

        public void CancelReservation()
        {
            isReserved = false;
            Console.WriteLine("Reservation canceled.");
        }

        public string Display()
        {
            return $"Book: {Title} by {Author}, Borrowed: {IsBorrowed}, Reserved: {IsReserved}";
        }
    }



}
