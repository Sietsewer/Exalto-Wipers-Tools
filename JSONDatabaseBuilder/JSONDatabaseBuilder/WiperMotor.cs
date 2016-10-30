using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONDatabaseBuilder
{
    public class WiperMotor : WiperComponent
    {
        public decimal armMax { get; set; }
        public decimal bladeMax { get; set; }
        public decimal hoh { get; set; }
        public decimal angleMax { get; set; }
        public decimal angleMin { get; set; }
        public decimal angleStep { get; set; }
        public string armType { get; set; }
        public string bladeType { get; set; }
    }
}
