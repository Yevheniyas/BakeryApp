using System;
using System.Collections.Generic;

namespace BakeryApp
{
    public abstract class Bread
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public List<string> Additives { get; set; } = new List<string>();

        protected Bread() { }

        protected Bread(Bread prototype)
        {
            Name = prototype.Name;
            Weight = prototype.Weight;
            Additives = new List<string>(prototype.Additives);
        }

        public abstract Bread Clone();

        public override string ToString()
        {
            return $"Name: {Name}, Weight: {Weight}g, Additives: {string.Join(", ", Additives)}";
        }
    }
}