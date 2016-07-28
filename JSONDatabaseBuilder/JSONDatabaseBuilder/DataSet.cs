using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace JSONDatabaseBuilder
{
    public class DataSet
    {
        public DataSet(string s)
        {
            DataSet d = JsonConvert.DeserializeObject<DataSet>(s) as DataSet;
            motors = d.motors;
            arms = d.arms;
            blades = d.blades;
        }

        public DataSet()
        {
        }

        public List<WiperMotor> motors;
        public List<WiperArm> arms;
        public List<WiperBlade> blades;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
