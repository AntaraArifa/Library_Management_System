﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface IReservable
    {
        bool IsReserved { get; }
        void ReserveItem();
        void CancelReservation();
    }
}
