using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverExample.Subject; 

namespace ObserverExample.Test
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void Observer_Register_UpdateTest()
        {
            var now = new DateTime();
            var site1 = new SiteRegister("site1", now, now.AddHours(5)); 
            var person1 = new Visitor("dave", now.AddHours(1));
            site1.Register(person1);

            var expected = "Register Name: " + site1.RegisterName + " Sign In Time: " + person1.SignInTime.ToShortTimeString();
            var result = person1.Update(site1); 

            Assert.AreEqual(expected, result);          
        }

        [TestMethod]
        public void Observer_Register_VisitorCount()
        {
            var now = new DateTime();
            var site1 = new SiteRegister("site1", now, now.AddHours(5));
            var person1 = new Visitor("dave", now.AddHours(1));
            var person2 = new Visitor("fred", now.AddHours(1));
            var person3 = new Visitor("barry", now.AddHours(1));

            site1.Register(person1);
            site1.Register(person2);
            site1.Register(person3);

            var expected = 3;
            var result = site1.PeopleList.Count;

            Assert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void Observer_UnRegister_VisitorCount()
        {
            var now = new DateTime();
            var site1 = new SiteRegister("site1", now, now.AddHours(5));
            var person1 = new Visitor("dave", now.AddHours(1));
            var person2 = new Visitor("fred", now.AddHours(1));
            var person3 = new Visitor("barry", now.AddHours(1));

            site1.Register(person1);
            site1.Register(person2);
            site1.Register(person3);
            site1.UnRegister(person1); 

            var expected = 2;
            var result = site1.PeopleList.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Observer_RegisterDifferentConcreteClasses_VisitorCount()
        {
            var now = new DateTime();
            var site1 = new SiteRegister("site1", now, now.AddHours(5));
            var person1 = new Visitor("dave", now.AddHours(1));
            var person2 = new StaffMember("fred", now.AddHours(1));
            var person3 = new Visitor("barry", now.AddHours(1));

            site1.Register(person1);
            site1.Register(person2);
            site1.Register(person3);

            var expected = 3;
            var result = site1.PeopleList.Count;

            Assert.AreEqual(expected, result);
        }
    }
}
