using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AssemblyInit
    {
        [AssemblyInitialize]
        public static void TestMethod1(TestContext tc)
        {
            Console.WriteLine("Assembly Init");
        }

        [TestMethod]
        [TestCategory("Weekly"), TestCategory("Weekly")]
        public void AssemblyMethod()
        {
            Console.WriteLine("Assembly method");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("Assembly Cleanup");
        }
    }
}
