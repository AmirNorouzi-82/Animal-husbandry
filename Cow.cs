using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public class Cow : Animal, IComparable<Cow>, IEnumerable<CowParameter>
    {
        public DateTime BirthDate { get; init; }
        static int MaxLife { get; }
        public List<Environment> Environments { get; set; }
        public static int Number { get; set; }
        public List<CowParameter> CowParams { get; set; }
        public override float StressFactor()
        {
            return 0.5f;
        }

        public override int Life()
        {
            return  (DateTime.Now - BirthDate).Days;
        }

        public override int TimeToDie()
        {
            return Life()*24;
        }

        public override float KillPriority()
        {
            return 0.75f;
        }

        public override int CostPerDay()
        {
            return 10;
        }

        public override int ValuePerDay()
        {
            return 20;
        }
        public override string ToString()
        {
            return $"Cow:BirthDate={BirthDate}, MaxLife={MaxLife},Number={Number},Environments={string.Join("", Environments)}, CowParams={string.Join("", CowParams)}";
        }

        public int CompareTo(Cow? other)
        {
            return 0;
        }

        public IEnumerator<CowParameter> GetEnumerator()
        {
            return CowParams.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
