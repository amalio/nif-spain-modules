using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using nif_spain;

namespace nif_spain_test
{
    [TestFixture]
    public class NifSpainTest
    {
        private NifSpain _nifSpain;

        [SetUp]
        public void SetUp()
        {
            _nifSpain = new NifSpain();
        }

        [Test]
        public void TestGetLetter()
        {
            NifSpain nifSpain = new NifSpain();
            Assert.AreEqual('B', _nifSpain.GetLetter(12332358));
            Assert.AreEqual('B', _nifSpain.GetLetter("12332358"));
            Assert.AreEqual('L', _nifSpain.GetLetter(12311919));
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetLetterException()
        {
            _nifSpain.GetLetter("12332358B");
        }
         

      
    }
}
