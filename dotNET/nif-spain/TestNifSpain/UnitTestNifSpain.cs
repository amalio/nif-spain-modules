using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using nif_spain;
using NUnit.Framework;



namespace TestNifSpain
{
    [TestFixture]
    public class UnitTestNifSpain
    {
        private NifSpain nifSpain;

        [SetUp]
        public void SetUp()
        {
            nifSpain = new NifSpain();
        }

        [Test]
        public void TestGetLetter()
        {
            Assert.AreEqual('B', nifSpain.GetLetter(12332358));
            Assert.AreEqual('B', nifSpain.GetLetter("12332358"));
            Assert.AreEqual('L', nifSpain.GetLetter(12311919));
        }

        [Test]
        public void TestGetLetterException()
        {
            Assert.AreEqual('B', nifSpain.GetLetter(12332358));
            Assert.AreEqual('B', nifSpain.GetLetter("12332358"));
            Assert.AreEqual('L', nifSpain.GetLetter(12311919));
        }
    }
}
