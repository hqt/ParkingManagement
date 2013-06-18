using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class MotorType
    {
        private int MotorTypeId { get; set; }

        private String type { get; set; }

        public MotorType(int motorTypeId, string type)
        {
            MotorTypeId = motorTypeId;
            this.type = type;
        }
    }
}
