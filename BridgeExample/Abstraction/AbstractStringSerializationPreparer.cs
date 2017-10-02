using BridgeExample.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample.Abstraction
{
    public class AbstractStringSerializationPreparer : IAbstractStringSerializationPreparer
    {
        private IStringSerializationPreparer stringPreparer;

        public AbstractStringSerializationPreparer(IStringSerializationPreparer stringPreparer)
        {
            this.stringPreparer = stringPreparer;
        }

        public string PrepareToCallSerializeObject(IEnumerable<IEnumerable<KeyValuePair<string, string>>> values)
        {
            return stringPreparer.PrepareToSerializeObject(values);
        }
    }
}
