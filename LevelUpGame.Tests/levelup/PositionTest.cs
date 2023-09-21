using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

        [Test]
        public void IsPositionCreated()
        {
            Assert.IsNotNull(testObj.coordinates);
        }

        [Test]
        public void IsPositionCreatedWithCoordinates()
        {
            var positionWithCoords = new Position(3, 5);
            Assert.IsNotNull(positionWithCoords.coordinates);
            Assert.AreEqual(3, positionWithCoords.coordinates.X);
            Assert.AreEqual(5, positionWithCoords.coordinates.Y);
        }
    }
}