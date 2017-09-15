using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public class WillowTree : Tree
    {
        public WillowTree(double height, DateTime age) : base(height, age)
        {
            _Species = Species.Willow;
        }
    }
}
