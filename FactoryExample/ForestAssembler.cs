using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    public class ForestAssembler
    {
        public Tree AssembleTree(ForestFactory factory, double height, DateTime datePlanted)
        {
            return factory.GetTree(height, datePlanted); 
        }
    }
}
