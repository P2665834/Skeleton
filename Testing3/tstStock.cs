using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {

            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);

        }
    }
}
