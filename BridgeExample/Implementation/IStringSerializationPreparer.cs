using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample.Implementation
{
    public interface IStringSerializationPreparer
    {
        //string PrepareToSerializeObject(IDictionary<string, string> values);
        //string PrepareToSerializeObject(IEnumerable<KeyValuePair<string, string>> values);
        string PrepareToSerializeObject(IEnumerable<IEnumerable<KeyValuePair<string, string>>> values);
    }
}
