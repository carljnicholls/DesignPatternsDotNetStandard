using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryExample; 

namespace FactoryExample.Test
{
    [TestClass]
    public class FactoryExampleTest
    {
        [TestMethod]
        public void FactoryObjectSpecieslVariableShouldMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999,12,1));
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (1999, 12, 1));

            var expected = tree._Species;
            var result = factoryTree._Species; 

            Assert.AreEqual(expected, result, 
                "Factory object Species variable should match constructor initiaised object");
        }

        [TestMethod]
        public void FactoryObjectSpeciesVariableShouldNotMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999, 12, 1));
            var factory = new ConcreteWillowFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (1999, 12, 1));

            var expected = tree._Species;
            var result = factoryTree._Species;

            Assert.AreNotEqual(expected, result,
                "Factory object Species variable should not match constructor initiaised object");
        }

        [TestMethod]
        public void FactoryObjectHeightVariableShouldMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999, 12, 1));
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (1999, 12, 1));

            var expected = tree._Height;
            var result = factoryTree._Height;

            Assert.AreEqual(expected, result,
                "Factory object Height variable should match constructor initiaised object");

        }

        [TestMethod]
        public void FactoryObjectHeightVariableShouldNotMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999, 12, 1));
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 4.4, new DateTime
                (1999, 12, 1));

            var expected = tree._Height;
            var result = factoryTree._Height;

            Assert.AreNotEqual(expected, result,
                "Factory object Height variable should not match constructor initiaised object");
        }

        [TestMethod]
        public void FactoryObjectDatePlantedVariableShouldMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999, 12, 1));
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (1999, 12, 1));

            var expected = tree._DatePlanted;
            var result = factoryTree._DatePlanted;

            Assert.AreEqual(expected, result,
                "Factory object DatePlanted variable should match constructor initiaised object");
        }

        [TestMethod]
        public void FactoryObjectDatePlantedVariableShouldNotMatchClassConstructorObject()
        {
            var tree = new OakTree(3.4, new DateTime
                (1999, 12, 1));
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (2000, 12, 1));

            var expected = tree._DatePlanted;
            var result = factoryTree._DatePlanted;

            Assert.AreNotEqual(expected, result,
                "Factory object DatePlanted variable should not match constructor initiaised object");
        }

        [TestMethod]
        public void FactoryObjectGetNumberOfRingsMethodShouldMatchClassConstructor()
        {
            var factory = new ConcreteOakForestFactory();
            var factoryTree = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (DateTime.Now.Year - 3, 12, 1));

            var expected = 3;
            var result = factoryTree.GetNumberOfRings();

            Assert.AreEqual(expected, result,
                "Factory object GetNumberOfRings should match count the number of whole years since planting.");
        }

        [TestMethod]
        public void FactoryObjectGetNumberOfRingsMethodShouldNotMatchClassConstructor()
        {
            var factory = new ConcreteOakForestFactory();
            var treeFactory = new ForestAssembler().AssembleTree(factory, 3.4, new DateTime
                (DateTime.Now.Year - 3, 12, 1));

            var expected = 0;
            var result = treeFactory.GetNumberOfRings();

            Assert.AreNotEqual(expected, result,
                "Factory object GetNumberOfRings should not match count the number of whole years since planting.");
        }

        [TestMethod]
        public void AssemblerObjectCanCreateDifferentTrees()
        {
            var treeFactory = new ForestAssembler();
            var oakTree = treeFactory.AssembleTree(new ConcreteOakForestFactory(), 3.4, new DateTime
                (1999, 12, 1)); 
            var willowTree = treeFactory.AssembleTree(new ConcreteWillowFactory(), 3.4, new DateTime
                (1999, 12, 1));

            var expected = oakTree._Species;
            var result = willowTree._Species;

            Assert.AreNotEqual(expected, result, "Assembly class should be able to use different factory classes.");
        }
    }
}
