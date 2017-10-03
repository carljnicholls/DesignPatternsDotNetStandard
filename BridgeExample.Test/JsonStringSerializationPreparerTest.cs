using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeExample.Abstraction;
using BridgeExample.Implementation;
using System.Collections.Generic;

namespace BridgeExample.Test
{
    [TestClass]
    public class JsonStringSerializationPreparerTest
    {
        [TestMethod]
        public void BridgeJsonStringSerializationPreparer()
        {
            AbstractStringSerializationPreparer prep = new AbstractStringSerializationPreparer(new JsonStringSerializationPreparer());
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>()
            {
                { "first_name" , "dave" },
                { "last_name" , "davey" }
            };
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>()
            {
                { "first_name" , "fred" },
                { "last_name" , "fredrick" }
            };
            var list = new List<Dictionary<string, string>>() { dictionary1, dictionary2 }; 

            var expected = "{\"first_name\" : \"dave\" , \"last_name\" : \"davey\" }, {\"first_name\" : \"fred\" , \"last_name\" : \"fredrick\" };";
            var result = prep.PrepareToCallSerializeObject(list);

            Assert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void BridgeCsvStringSerializationPreparer()
        {
            AbstractStringSerializationPreparer prep = new AbstractStringSerializationPreparer(new CsvStringSerializationPreparer());
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>()
            {
                { "first_name" , "dave" },
                { "last_name" , "davey" }
            };
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>()
            {
                { "first_name" , "fred" },
                { "last_name" , "fredrick" }
            };
            var list = new List<Dictionary<string, string>>() { dictionary1, dictionary2 };

            var expected = "first_name,last_name\r\ndave,davey\r\nfred,fredrick";
            var result = prep.PrepareToCallSerializeObject(list);

            Assert.AreEqual(expected, result);
        }
    }
}
