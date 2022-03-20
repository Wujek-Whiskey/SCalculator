using NUnit.Framework;
using SCalculator;

namespace SCalculator.UnitTest
{
    public class Tests
    {
        [TestCase ("x", 15, "x 15")]
        [TestCase ("y", 25, "y 25")]
        [TestCase ("z", 35, "z 35")]
        public void Added_Argument_Test(string setName, double setValue, string expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.AddArgument(setName, setValue);

            Assert.AreEqual(expectedResult, result);
        }
    }
}