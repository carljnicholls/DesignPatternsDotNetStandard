using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypeExample;

namespace PrototypeEzample.Test
{
    [TestClass]
    public class SimplePrototypeTest
    {
        [TestMethod]
        public void ConcretePrototypeIdParamsDoNotMatch()
        {
            SimplePrototype expectedOne = null;
            SimplePrototype expectedTwo = null;

            expectedOne = new SimpleConcretePrototypeOne("id");
            expectedTwo = new SimpleConcretePrototypeTwo("id");

            Assert.AreNotEqual(expectedOne._Id, expectedTwo._Id, "Concrete implementations id param should not be equal.");
        }

        [TestMethod]
        public void ConcretePrototypeNameParamsShouldBeStringEmptyIfNotSpecified()
        {
            SimplePrototype expectedOne = null;
            SimplePrototype expectedTwo = null;

            expectedOne = new SimpleConcretePrototypeOne("id");
            expectedTwo = new SimpleConcretePrototypeOne("id");

            Assert.AreEqual(expectedOne._Name, string.Empty, "Concrete implementations _name param should be string.empty.");
            Assert.AreEqual(expectedTwo._Name, string.Empty, "Concrete implementations _name param should be string.empty.");
        }
    }
}
