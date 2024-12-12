using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp
{
    public abstract class BreadBuilder
    {
        protected Bread bread;

        public void CreateNewBread()
        {
            bread = new ConcreteBread();
        }

        public Bread GetBread()
        {
            return bread;
        }

        public abstract void SetName(string name);
        public abstract void SetWeight(double weight);
        public abstract void AddAdditive(string additive);
    }
}
