using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExample
{
    public interface ICallPool
    {
        IEnumerable<string> CallBack(); 
    }
}
