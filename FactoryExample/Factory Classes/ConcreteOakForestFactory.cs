using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public class ConcreteOakForestFactory : ForestFactory
    {
        public override Tree GetTree(double height, DateTime datePlanted)
        {
            return new OakTree(height, datePlanted); 
        }
    }
}
