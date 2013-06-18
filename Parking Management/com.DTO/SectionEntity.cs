using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class SectionEntity
    {
        private int SectionEntityId { get; set; }

        private int EmployeeId { get; set; }

        private int SectionTimeId { get; set; }

        public SectionEntity(int sectionEntityId, int employeeId, int sectionTimeId)
        {
            SectionEntityId = sectionEntityId;
            EmployeeId = employeeId;
            SectionTimeId = sectionTimeId;
        }
    }
}
