using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class PriceScheduleDetail
    {
        private int PriceScheduleDetailId { get; set; }

        private int DayOfWeek { get; set; }

        private int StartTime { get; set; }

        private int EndTime { get; set; }

        private int MotorTypeId { get; set; }

        private double InitializePrice { get; set; }

        private double PriceUnit { get; set; }

        public PriceScheduleDetail(int priceScheduleDetailId, int dayOfWeek, int startTime, int endTime, int motorTypeId, double initializePrice, double priceUnit)
        {
            PriceScheduleDetailId = priceScheduleDetailId;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            MotorTypeId = motorTypeId;
            InitializePrice = initializePrice;
            PriceUnit = priceUnit;
        }
    }

}
