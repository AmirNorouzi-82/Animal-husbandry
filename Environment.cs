using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public class Environment
    {
        public HealthParamete TDS { get; set; }
        public HealthParamete Temp { get; set; }
        public HealthParamete Density { get; set; }
        public HealthParamete DB { get; set; }
        public HealthParamete AQI { get; set; }
        public HealthParamete OX { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"TDS:{TDS},Temp:{Temp}, Density:{Density}, DB:{DB},AQI:{AQI},OX:{OX},Date:{Date}";
        }



    }
}
