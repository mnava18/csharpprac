using DivideNum;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            //act
          int actual=  DivideNum.Program.doStuff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
