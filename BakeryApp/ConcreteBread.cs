using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp
{
    public class ConcreteBread : Bread
    {
        public ConcreteBread() { }

        public ConcreteBread(ConcreteBread prototype) : base(prototype) { }

        public override Bread Clone()
        {
            return new ConcreteBread(this);
        }
    }
}
