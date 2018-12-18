using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GridExercise.Test
{
    [TestClass]
    public class ResultsTest
    {
        [TestMethod]
        public void TestInput1()
        {
            var dim = "5 5";
            var point = "1 2 N";
            var move = "LMLMLMLMM";

            var actual = Parser.ProcessInput(dim, point, move);
            var expected = "1 3 N";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput2()
        {
            var dim = "5 5";
            var point = "3 3 E";
            var move = "MMRMMRMRRM";

            var actual = Parser.ProcessInput(dim, point, move);
            var expected = "5 1 E";

            Assert.AreEqual(expected, actual);
        }
    }
}
