using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonExample.Test
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void SingletonObjectIsEqual()
        {
            var expected = Singleton.GetInstance();

            var result = Singleton.GetInstance();

            Assert.AreEqual(expected, result, "Singleton objects should be equal.");
        }

        [TestMethod]
        public void SingletonObjectCountVariableIsNotEqual()
        {
            var expected = Singleton.GetInstance()._Count;

            Singleton.GetInstance()._Count = 45;
            var result = Singleton.GetInstance()._Count;
            
            Assert.AreNotEqual(expected, result, "Singleton count parameter should not be equal.");
        }

        [TestMethod]
        public void SingletonObjectCountVariableCountsInstancesOfClass()
        {
            var expected = Singleton.GetInstance()._Count + 1;
            var result = Singleton.GetInstance()._Count;

            Assert.AreEqual(expected, result, "Singleton count variable should +1 for every time after intialisation. "); 
        }
    }
}
