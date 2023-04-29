using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using help;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Program.pow(2));
        }
        [TestMethod]
        public void TestMethod2() 
        {
            Assert.AreNotEqual(4, Program.pow(3));
        }
        [TestMethod]
        public void TestMethod3() 
        {
            Assert.IsTrue(Program.trueFalse(2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(Program.trueFalse(3));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsNotNull(Program.nullOrNull(4));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsNull(Program.nullOrNull(7));
        }
        [TestMethod]
        public void TestMethod7() 
        {
            Assert.IsInstanceOfType(Program.pow(2), typeof(double));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsNotInstanceOfType(Program.pow(2), typeof(int));
        }
        [TestMethod]
        public void TestMethod9() 
        {
            StringAssert.Contains("miau", Program.srt());
        }
        //[TestMethod]
        //public void TestMethod10()
        //{
        //    CollectionAssert.DoesNotContain("gav", Program.srt());
        //}
        [TestMethod]
        public void TestMethod11()
        {
            
        }
    }
}
