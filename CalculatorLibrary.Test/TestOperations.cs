using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLibrary.Test
{
    [TestClass]
    public class TestOperations
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange 
            int num1 = 7;
            int num2 = 5;
            int expected = 12;

            //Act
            Operations op = new Operations();
            int actual = op.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubstract()
        {
            //Arrange 
            int num1 = 7;
            int num2 = 5;
            int expected = 2;

            //Act
            Operations op = new Operations();
            int actual = op.Substract(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiply()
        {
            //Arrange 
            int num1 = 7;
            int num2 = 5;
            int expected = 35;

            //Act
            Operations op = new Operations();
            int actual = op.Multipy(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
            //Arrange 
            int num1 = 10;
            int num2 = 5;
            int expected = 2;

            //Act
            Operations op = new Operations();
            int actual = op.Divide(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
