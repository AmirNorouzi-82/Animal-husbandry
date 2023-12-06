using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public abstract class Animal
    {
        public DateTime BirthDate { get; init;}
        static int MaxLife { get; } 
        public List<Environment> Environments { get; set; } 
        public float Weight { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
        public abstract float StressFactor();
        public abstract int Life();
        public abstract int TimeToDie();
        public abstract float KillPriority();
        public abstract int CostPerDay();
        public abstract int ValuePerDay();

    }
}
