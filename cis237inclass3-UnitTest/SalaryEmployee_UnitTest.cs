using System;
using cis237inclass3;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace cis237inclass3_UnitTest
{
    [TestClass] // these brackets are called declarations that give the compiler extra info
    public class SalaryEmployee_UnitTest
    {
        [TestMethod]
        public void LastNameFirstNameTest()
        {
            // Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);
            string expected = "Barnes, David";

            // Act 
            string actual = salaryEmployee.GetLastNameFirstName();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYearlySalaryTest()
        {
            // Arrange 
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);
            string expected = (250m * 52).ToString("c");

            // Act
            string actual = salaryEmployee.GetFormattedSalary();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalaryEmployeeTest()
        {
            string expectedFirstName = "David";
            string expectedLastName = "Barnes";
            decimal expectedSalary = 250m;

            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);

            Assert.AreEqual(expectedFirstName, salaryEmployee.FirstName);
            Assert.AreEqual(expectedLastName, salaryEmployee.LastName);
            Assert.AreEqual(expectedSalary * 52, salaryEmployee.Salary);
        }

    }
}
