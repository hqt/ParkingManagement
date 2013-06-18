using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class Section
    {
        private int SectionTimeId { get; set; }

        private DateTime StartTime { get; set; }

        private DateTime EndTime { get; set; }

        public Section(DateTime endTime, DateTime startTime, int sectionTimeId)
        {
            EndTime = endTime;
            StartTime = startTime;
            SectionTimeId = sectionTimeId;
        }
    }

}
