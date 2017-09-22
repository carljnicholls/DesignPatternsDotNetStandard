using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CompositeExample.Test
{
    [TestClass]
    public class CompositeCallPoolTests
    {
        [TestMethod]
        public void CompositeCallPoolCallBackLengthIsCorrect()
        {
            CompositeCallPool compositeCallPool = new CompositeCallPool();
            var expected = 3; 
            compositeCallPool.Add(new CallPool());
            compositeCallPool.Add(new CallPool());
            compositeCallPool.Add(new CallPool());

            var callPoolList = (List<string>) compositeCallPool.CallBack();
            var result = callPoolList.Count;

            Assert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void CompositeCallPoolCallBackFirstStringIsNotTheSameAsSecond()
        {
            CompositeCallPool compositeCallPool = new CompositeCallPool();
            compositeCallPool.Add(new CallPool());
            compositeCallPool.Add(new CallPool());

            var callPoolList = (List<string>)compositeCallPool.CallBack();
            var obj1 = callPoolList[0]; 
            var obj2 = callPoolList[1];

            Assert.AreNotEqual(obj1.ToString(), obj2.ToString()); 
        }
    }
}
