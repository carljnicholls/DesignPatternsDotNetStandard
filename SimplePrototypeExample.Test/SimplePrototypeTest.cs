using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePrototypeExample.Test
{
    [TestClass]
    public class SimplePrototypeTest
    {
        [TestMethod]
        public void ConcretePrototypeIdParamsSingleConstructor_DoNotMatch()
        {
            SimplePrototype expectedOne = null;
            SimplePrototype expectedTwo = null;

            expectedOne = new SimpleConcretePrototypeOne("id");
            expectedTwo = new SimpleConcretePrototypeTwo("id");

            Assert.AreNotEqual(expectedOne._Id, expectedTwo._Id, "Concrete implementations id param should not be equal.");
        }

        [TestMethod]
        public void ConcretePrototypeNameParamSingleConstructor_ShouldBeStringEmptyIfNotSpecified()
        {
            SimplePrototype result= null;
            var expected = string.Empty; 

            result = new SimpleConcretePrototypeOne("id");
            
            Assert.AreEqual(expected, result._Name, "Concrete implementations _name param should be string.empty.");
        }

        [TestMethod]
        public void ConcretePrototypeOneNameParam_ShouldBeSetInConcreteConstructor()
        {
            SimplePrototype result = null;
            var expected = "concrete prototype one";

            result = new SimpleConcretePrototypeOne("id", "concrete prototype");

            Assert.AreEqual(expected, result._Name, "Concrete implementations _name param should be the same as result.");
        }

        [TestMethod]
        public void ConcretePrototypeTwoNameParam_ShouldBeSetInConcreteConstructor()
        {
            SimplePrototype result = null;
            var expected = "concrete prototype two";

            result = new SimpleConcretePrototypeTwo("id", "concrete prototype");

            Assert.AreEqual(expected, result._Name, "Concrete implementations _name param should be the same as result.");
        }

        [TestMethod]
        public void ConcretePrototypeOneIdParam_ShouldBeSetInBaseConstructor_NameParam_ShouldBeSetInConcreteConstructor()
        {
            SimplePrototype result = null;
            var expected = "id";
            var expected2 = "concrete prototype one";

            result = new SimpleConcretePrototypeOne("id", "concrete prototype");

            Assert.AreEqual(expected, result._Id, "Concrete implementation of _id param in dual constructor should be the same as base class.");
            Assert.AreEqual(expected2, result._Name, "Concrete implementations _name param in dual constructor should be implemented in concrete class.");
        }
    }
}
