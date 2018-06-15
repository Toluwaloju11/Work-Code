using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void UnitTestOne()
        {
            Console.WriteLine("This is unit test 1");
        }
        [TestMethod]
        [TestCategory("Regression")]        
        public void UnitTestTwo()
        {
            Console.WriteLine("This is unit test 2");
        }
    }
}
