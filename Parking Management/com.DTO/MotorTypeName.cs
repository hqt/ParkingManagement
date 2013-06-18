using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class MotorTypeName
    {
        private int MotortypeNameId { get; set; }

        private int MotorTypeId { get; set; }

        private int MotorNameId { get; set; }

        public MotorTypeName(int motortypeNameId, int motorTypeId, int motorNameId)
        {
            MotortypeNameId = motortypeNameId;
            MotorTypeId = motorTypeId;
            MotorNameId = motorNameId;
        }
    }
}
