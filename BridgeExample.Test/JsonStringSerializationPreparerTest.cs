using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeExample.Abstraction;
using System.Collections.Generic;

namespace BridgeExample.Test
{
    [TestClass]
    public class JsonStringSerializationPreparerTest
    {
        [TestMethod]
        public void JsonStringSerializationPreparer()
        {
            AbstractStringSerializationPreparer prep = new AbstractStringSerializationPreparer(new JsonStringSerializationPreparer());
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "first_name" , "dave" },
                { "last_name" , "davey" }
            };
            var list = new List<Dictionary<string, string>>() { dictionary, dictionary }; 

            var expected = "{\"first_name\" : \"dave\" , \"last_name\" : \"davey\" }, {\"first_name\" : \"dave\" , \"last_name\" : \"davey\" };";
            var result = prep.PrepareToCallSerializeObject(list);

            Assert.AreEqual(expected, result); 
        }
    }
}
