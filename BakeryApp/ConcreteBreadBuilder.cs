using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp
{
    public class ConcreteBreadBuilder : BreadBuilder
    {
        public override void SetName(string name)
        {
            bread.Name = name;
        }

        public override void SetWeight(double weight)
        {
            bread.Weight = weight;
        }

        public override void AddAdditive(string additive)
        {
            bread.Additives.Add(additive);
        }
    }
}
