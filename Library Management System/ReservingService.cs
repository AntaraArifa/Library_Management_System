using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    
    public class ReservingService : IReservable
    {
        private bool isReserved;

        public bool IsReserved
        {
            get { return isReserved; }
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
    }

}
