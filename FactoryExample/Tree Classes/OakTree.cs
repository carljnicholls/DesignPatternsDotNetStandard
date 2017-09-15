using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public class OakTree : Tree
    {
        public OakTree(double height, DateTime datePlanted) : base(height, datePlanted)
        {
            this._Species = Species.Oak;
        }
    }
}
