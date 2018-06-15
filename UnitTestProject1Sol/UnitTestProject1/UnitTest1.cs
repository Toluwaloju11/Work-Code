using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Console.WriteLine("This is the Class Init");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("This is the first method");
        }
        [TestMethod]
        [TestCategory("Weekly"), TestCategory("Weekly")]
        public void TestMethod2()
        {
            Console.WriteLine("This is the second method");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("This is the Class cleanup");
        }

    }
}
