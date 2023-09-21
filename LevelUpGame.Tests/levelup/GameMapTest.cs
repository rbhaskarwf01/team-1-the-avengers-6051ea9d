using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void GetPositionReturns10x10Matrix() {
            var position = testObj.getPositions(); 
            Assert.IsNotNull(position);
            Assert.AreEqual(10,position.GetLength(0));
        }   
        [Test]
        public void GetTotalPositions() {
            var position = testObj.getPositions(); 
            Assert.IsNotNull(position);
            Assert.AreEqual(10,position.GetLength(0));
        }
    }
}