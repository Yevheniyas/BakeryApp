using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp
{
    public class BakeryDirector
    {
        private readonly BreadBuilder builder;

        public BakeryDirector(BreadBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildBasicBread()
        {
            builder.CreateNewBread();
            builder.SetName("Basic Bread");
            builder.SetWeight(500);
        }
        public void BuildSweetBread()
        {
            builder.CreateNewBread();
            builder.SetName("Sweet Bread");
            builder.SetWeight(300);
            builder.AddAdditive("Sugar");
            builder.AddAdditive("Vanilla");
        }
    }
}