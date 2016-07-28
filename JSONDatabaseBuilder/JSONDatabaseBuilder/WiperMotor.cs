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
        public string armType { get; set; }
        public string bladeType { get; set; }
    }
}
