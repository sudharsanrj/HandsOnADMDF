using NUnit.Framework;
using GenericMedicine;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace NUnitTestMedicine
{
    public class Tests
    {
        Program program = new Program();
        [SetUp]
        public void Setup()
        {
        }




        
        [Test]
        [TestCase("Dolo", "Dolo650", "Dolo","2/2/2030",20)]
        [TestCase("Remilyn", "Remilyn D", "Remilyn", "2/8/2025", 30)]
        


        public void CreateTest(string name,string genericMedicineName,string composition,DateTime expiryDate, double price)
        {
            


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);
           
        }
        [Test]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 20)]
        [TestCase("", "Dolo650", "Dolo", "2/2/2030", 20)]

        public void EmptyMedicineNameException(string name, string genericMedicineName, string composition, DateTime expiryDate, double price){
            try
            {


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);

            }
            catch (Exception e)
            {
                Assert.AreEqual("Medicine name cannot be empty. Please provide valid value", e.Message);

            }
        }
        [Test]
        [TestCase("Dolo", "", "Dolo", "2/2/2030", 20)]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 20)]


        public void EmptyGenericMedicineNameException(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            try
            {


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);

            }
            catch (Exception e)
            {
                Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", e.Message);

            }
        }

        [Test]
        [TestCase("Dolo", "Dolo650", "", "2/2/2030", 20)]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 20)]


        public void EmptyMedicineCompositionException(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            try
            {


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);

            }
            catch (Exception e)
            {
                Assert.AreEqual("Medicine composition cannot be empty. Please provide valid value", e.Message);

            }
        }
        [Test]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 0)]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 20)]



        public void IncorrectPriceException(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            try
            {


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);

            }
            catch (Exception e)
            {
                Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", e.Message);

            }
        }
        [Test]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2018", 20)]
        [TestCase("Dolo", "Dolo650", "Dolo", "2/2/2030", 20)]

        public void IncorrectExpiryDateException(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            try
            {


                var medCheck = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
                Assert.AreEqual(name, medCheck.Name);
                Assert.AreEqual(genericMedicineName, medCheck.GenericMedicineName);
                Assert.AreEqual(composition, medCheck.Composition);
                Assert.AreEqual(price, medCheck.PricePerStrip);

            }
            catch (Exception e)
            {
                Assert.AreEqual("Incorrect expiry date. Please provide valid value", e.Message);

            }
        }


        Medicine medicine = new Medicine
        {
            Name = "Dolo",
            GenericMedicineName = "Dolo650",
            Composition = "Dolo",
            ExpiryDate = Convert.ToDateTime("2/2/2030"),
            PricePerStrip = 20
        };




        //Test case for Create Carton Details
        [Test]
        [TestCase(5, "2/2/2022", "Mumbai")]

        public void NullObjectCheck(int MedicineStripCount, DateTime LaunchDate, string RetailerAddress)
        {
            Medicine medicine1 = null;
            var cartonCheck = program.CreateCartonDetail(MedicineStripCount, LaunchDate, RetailerAddress, medicine1);

            Assert.IsNull(cartonCheck);

        }
        [Test]
        [TestCase(5,"2/2/2022","Mumbai")]
    
        public void CreateTest2(int MedicineStripCount, DateTime LaunchDate,string RetailerAddress)
        {
           
                var cartonCheck = program.CreateCartonDetail(MedicineStripCount, LaunchDate, RetailerAddress, medicine);

                Assert.AreEqual(MedicineStripCount, cartonCheck.MedicineStripCount);
                Assert.AreEqual(LaunchDate, cartonCheck.LaunchDate);
                Assert.AreEqual(RetailerAddress, cartonCheck.RetailerAddress);

        }

        [Test]
        [TestCase(5, "2/2/2022", "Mumbai")]
        [TestCase(0,"2/3/2022","chennai")]

        public void CountException(int MedicineStripCount, DateTime LaunchDate, string RetailerAddress)
        {
            try
            {
                var cartonCheck = program.CreateCartonDetail(MedicineStripCount, LaunchDate, RetailerAddress, medicine);

                Assert.AreEqual(MedicineStripCount, cartonCheck.MedicineStripCount);
                Assert.AreEqual(LaunchDate, cartonCheck.LaunchDate);
                Assert.AreEqual(RetailerAddress, cartonCheck.RetailerAddress);
            }
            catch(Exception e)
            {
                Assert.AreEqual("Incorrect strip count. Please check", e.Message);
            }
        }

        [Test]
        [TestCase(5, "2/2/2020", "Mumbai")]
        [TestCase(2, "2/3/2025", "chennai")]

        public void DateException(int MedicineStripCount, DateTime LaunchDate, string RetailerAddress)
        {
            try
            {
                var cartonCheck = program.CreateCartonDetail(MedicineStripCount, LaunchDate, RetailerAddress, medicine);

                Assert.AreEqual(MedicineStripCount, cartonCheck.MedicineStripCount);
                Assert.AreEqual(LaunchDate, cartonCheck.LaunchDate);
                Assert.AreEqual(RetailerAddress, cartonCheck.RetailerAddress);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Incorrect launch date. Please provide valid value", e.Message);
            }
        }

        [Test]
        [TestCase(5, "2/2/2022", "Mumbai")]
        [TestCase(10, "8  /8/2021", "")]

        public void AddressException(int MedicineStripCount, DateTime LaunchDate, string RetailerAddress)
        {
           
            try
            {
                var cartonCheck = program.CreateCartonDetail(MedicineStripCount, LaunchDate, RetailerAddress, medicine);

                Assert.AreEqual(MedicineStripCount, cartonCheck.MedicineStripCount);
                Assert.AreEqual(LaunchDate, cartonCheck.LaunchDate);
                Assert.AreEqual(RetailerAddress, cartonCheck.RetailerAddress);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Incorrect retailer address. Please check", e.Message);
            }
        }


    }
}