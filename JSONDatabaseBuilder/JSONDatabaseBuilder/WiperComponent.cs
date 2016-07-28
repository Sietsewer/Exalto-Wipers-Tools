using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONDatabaseBuilder
{
    public abstract class WiperComponent
    {
        public string artNr { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
    }
}
