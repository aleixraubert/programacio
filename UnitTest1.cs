using Programacio;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaSquareDoesGood()
        {
            int baseSquare = 5, heightSquare = 4;

            int expected = 20;

            double actual = Ex23.Area(baseSquare, heightSquare);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaRectangleDoesGood()
        {
            int baseRectangle = 5, heightRectangle = 4;

            int expected = 20;

            double actual = Ex23.Area(baseRectangle, heightRectangle);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCircleDoesGood()
        {
            double radius = 5;

            double expected = 78.53981633974483;

            double actual = Ex23.Area(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaPentagonDoesGood()
        {
            int side = 5, apothem = 4;

            int expected = 50;

            double actual = Ex23.Area(side, apothem, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}