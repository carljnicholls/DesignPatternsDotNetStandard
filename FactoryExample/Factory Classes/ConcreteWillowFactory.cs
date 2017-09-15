using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public class ConcreteWillowFactory : ForestFactory
    {
        public override Tree GetTree(double height, DateTime datePlanted)
        {
            return new WillowTree(height, datePlanted); 
        }
    }
}
