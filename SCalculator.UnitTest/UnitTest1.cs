using NUnit.Framework;

namespace SCalculator.UnitTest
{
    public class Tests
    {
        [TestCase ("x", 15, "x = 15")]
        [TestCase ("y", 25, "y = 25")]
        [TestCase ("z", 35, "z = 35")]
        public void Added_Argument_Test(string setName, double setValue, string expectedResult)
        {
            var scalculator = new SCalculator();

            var result = scalculator.AddArgument(setName, setValue);
            scalculator.ShowAllArguments();

            Assert.AreEqual(result, expectedResult);
        }
    }
}