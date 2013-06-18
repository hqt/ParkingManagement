using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class PriceEntity
    {
        private int PriceEntityId { get; set; }

        private int TicketId { get; set; }

        private int PriceScheduleDetailId { get; set; }

        private int pornDetailId { get; set; }

        private double price { get; set; }

        private int NumOfDay { get; set; }

        private DateTime EffectiveDay { get; set; }

        public PriceEntity(int priceEntityId, int ticketId, int priceScheduleDetailId, int pornDetailId, double price, int numOfDay, DateTime effectiveDay)
        {
            PriceEntityId = priceEntityId;
            TicketId = ticketId;
            PriceScheduleDetailId = priceScheduleDetailId;
            this.pornDetailId = pornDetailId;
            this.price = price;
            NumOfDay = numOfDay;
            EffectiveDay = effectiveDay;
        }
    }
}
