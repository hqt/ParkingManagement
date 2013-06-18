using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class LostTicket
    {
        private int LostTicketId { get; set; }

        private int TicketId { get; set; }

        private DateTime date { get; set; }

        private String CustomerSsn { get; set; }

        public LostTicket(int lostTicketId, int ticketId, DateTime date, string customerSsn)
        {
            LostTicketId = lostTicketId;
            TicketId = ticketId;
            this.date = date;
            CustomerSsn = customerSsn;
        }
    }
}
