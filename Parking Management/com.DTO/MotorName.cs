using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_Management.com.DTO
{
    class MotorName
    {
        private int MotornameId { get; set; }

        private String Name { get; set; }

        public MotorName(int motornameId, string name)
        {
            MotornameId = motornameId;
            Name = name;
        }
    }
    }
}
