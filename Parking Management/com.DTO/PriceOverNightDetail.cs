using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class PriceOverNightDetail
    {
        private int PornDetailId { get; set; }

        private int MotorTypeId { get; set; }

        private double InitializePrice { get; set; }

        public PriceOverNightDetail(int pornDetailId, int motorTypeId, double initializePrice)
        {
            PornDetailId = pornDetailId;
            MotorTypeId = motorTypeId;
            InitializePrice = initializePrice;
        }
    }
    }
}
