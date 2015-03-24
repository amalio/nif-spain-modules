using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nif_spain;

namespace TestNifSpain
{
    [TestClass]
    public class UnitTestNifSpain
    {
        [TestMethod]
        public void TestGetLetter()
        {
            NifSpain nifSpain = new NifSpain(); 

            Assert.AreEqual('B', nifSpain.GetLetter(12332358));
        }
    }
}
