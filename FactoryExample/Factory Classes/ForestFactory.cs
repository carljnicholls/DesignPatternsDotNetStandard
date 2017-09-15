using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public abstract class ForestFactory
    {
        public abstract Tree GetTree(double height, DateTime datePlanted); 
    }
}
