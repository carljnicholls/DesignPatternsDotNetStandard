using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample.Abstraction
{
    public interface IAbstractStringSerializationPreparer
    {
        string PrepareToCallSerializeObject(IEnumerable<IEnumerable<KeyValuePair<string, string>>> values); 
    }
}
