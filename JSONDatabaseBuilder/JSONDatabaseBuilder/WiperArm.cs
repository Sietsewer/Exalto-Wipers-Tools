using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONDatabaseBuilder
{
    public class WiperArm : WiperComponent
    {
        public string armType { get; set; }
        public decimal lengthMin { get; set; }
        public decimal lengthMax { get; set; }
        public decimal hoh { get; set; }
        public decimal bladeLengthMin { get; set; }
        public decimal bladeLengthMax { get; set; }
        public string bladeType { get; set; }
        public string applType { get; set; }
    }
}
