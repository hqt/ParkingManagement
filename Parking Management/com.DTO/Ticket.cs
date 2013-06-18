using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class Ticket
    {
        private int TicketId { get; set; }
        
        private DateTime TimeIn { get; set; }
        
        private DateTime TimeOut { get; set; }

        private int IdCard { get; set; }

        private int employeeID { get; set; }

        private byte[] FrontImage { get; set; }

        private byte[] BackImage { get; set; }

        private int MotorNameId { get; set; }

        private int PriceEntityId { get; set; }

        public Ticket(int priceEntityId, int motorNameId, byte[] backImage, byte[] frontImage, int employeeId, int idCard, DateTime timeOut, DateTime timeIn, int ticketId)
        {
            PriceEntityId = priceEntityId;
            MotorNameId = motorNameId;
            BackImage = backImage;
            FrontImage = frontImage;
            employeeID = employeeId;
            IdCard = idCard;
            TimeOut = timeOut;
            TimeIn = timeIn;
            TicketId = ticketId;
        }
    }

    }
}
