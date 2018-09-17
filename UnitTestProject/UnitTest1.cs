using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilPris()
        {
            //Arange
            var bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assort
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void BilK�ret�j()
        {
            //Arange
            var bil = new Bil();
            //Act
            string k�ret�j = bil.K�ret�j();
            //Assort
            Assert.AreEqual("Bil",k�ret�j);
        }
    }
}
