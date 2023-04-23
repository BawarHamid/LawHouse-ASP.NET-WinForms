using ConsoleApplicationLawHouse.Database;
using ConsoleApplicationLawHouse.Forretningslogik;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LawHouse.Test
{
    [TestClass]
    public class Database_Test
    {
        [TestMethod]
        // Når man navner en test metode skal vi skrive metodensNavn_HvilkenScenario_ForventetResultat
        public void IsClientAlreadyCreatedNR_ClientHarSammeNr_ReturnsTrue()
        {

            // Arrange  her gøre vi  klarer objekter som skal bruge til vores test
            var d = new Database();

            //Act  her er hvor vi kalder metoden som skal testes

            var result = d.IsClientAlreadyCreatedNR(43765777);

            //Assert  her checker vi om resultet er det vi forventet
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsClientAlreadyCreatedNR_ClientIkkeHarSammeNr_ReturnsFalse()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsClientAlreadyCreatedNR(12121212);

            //Assert 
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsClientAlreadyCreatedA_ClientHarSammeAdresse_ReturnsTrue()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsClientAlreadyCreatedA("Lollandvej 9");

            //Assert 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsClientAlreadyCreatedA_ClientHarSammeAdresse_ReturnsFalse()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsClientAlreadyCreatedA("test");

            //Assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEmployCreatedE_MedarbejderFindesEmail_ReturnsTrue()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsEmployeeAlreadyCreatedE("Fahu0009@edu.dk");

            //Assert 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmployCreatedE_MedarbejderIkkeFindesEmail_ReturnsFalse()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsEmployeeAlreadyCreatedE("");

            //Assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEmployCreatedT_MedarbejderFindesTelefon_ReturnsTrue()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsEmployeeAlreadyCreatedT(88337463);

            //Assert 
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IsEmployCreatedT_MedarbejderIkkeFindesTelefon_ReturnsFalse()
        {

            // Arrange 
            var d = new Database();

            //Act  

            var result = d.IsEmployeeAlreadyCreatedT(121212);

            //Assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BeregnGaveafgift_IfItsToÆgtefelle_ReturnsZero()
        {

            // Arrange 
            var g = new Gaveafgift();
            var expected = 0;

            //Act  

            var actual = g.BeregnGaveafgift("Ægtefelle", 150000);

            //Assert 
           Assert.AreEqual(expected ,actual);
           
        }

        [TestMethod]
        public void BeregnGaveafgift_IfItsToCloseRelatives_ReturnsExpectedValue()
        {

            // Arrange 
            var g = new Gaveafgift();
            var expected = 12195;

            //Act  

            var actual = g.BeregnGaveafgift("Børn", 150000);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BeregnGaveafgift_IfItsToFurtherrelatives_ReturnsExpectedValue()
        {

            // Arrange 
            var g = new Gaveafgift();
            var expected = 29471.25;

            //Act  

            var actual = g.BeregnGaveafgift("Bedsteforældre", 150000);

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
