using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestBil
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

        [TestMethod]
        public void BilNummerPladeMinderEndSyv()
        {
            //Arange
            var bil = new Bil();
            string TestPlade = "DF55200";
            //Act
            string Svar = bil.NummerPladeL�ser(TestPlade);
            //Assort
            Assert.AreEqual("Nummerplade er godtaget",Svar);
        }

        [TestMethod]
        public void BilNummerPladeMereEndSyv()
        {
            //Arange
            var bil = new Bil();
            string TestPlade = "DF552001";
            //Act
            string Svar = bil.NummerPladeL�ser(TestPlade);
            //Assort
            Assert.AreEqual("Fejl Nummerlade for lang", Svar);
        }
    }
}
