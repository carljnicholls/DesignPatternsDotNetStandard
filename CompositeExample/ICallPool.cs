using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExample
{
    /// <summary>
    /// define behaviour for Composite Objects 
    /// </summary>
    public interface ICallPool
    {
        IEnumerable<string> CallBack(); 
    }
}
