using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public class SheepParameter
    {
        public HealthParameter<int> TimeToStand { get; set; }
        public HealthParameter<int> TimeToDeal { get; set; }
        public HealthParameter<int> TimeToRelax { get; set; }
        public HealthParameter<int> NumberOfMeal { get; set; }
        public HealthParameter<int> NumberOfWoolProduction { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"TimeToStand:{TimeToStand}, TimeToDeal:{TimeToDeal}, TimeToRelax:{TimeToRelax},NumberOfMeal:{NumberOfMeal},NumberOfWoolProduction:{NumberOfWoolProduction}";

        }
    }
}
