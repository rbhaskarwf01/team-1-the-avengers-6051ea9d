using NUnit.Framework;
using System.Drawing;
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
            
        }

        [Test]
        public void GetPositionReturns10x10Matrix() {
            var testObj = new GameMap();
            var position = testObj.getPositions(); 
            Assert.IsNotNull(position);
            Assert.AreEqual(10,position.GetLength(0));
        }   
        [Test]
        public void GetTotalPositions() {
            var testObj = new GameMap();
            var Totposition = testObj.getTotalPositions(); 
            Assert.IsNotNull(Totposition);
            Assert.AreEqual(100,Totposition);
        }
        [Test]
        public void GetCalculatePositionsMovingNorthSuccessfully() {
            var testObj = new GameMap();
            var startPosition = new Position(0,0);
            var calcposition = testObj.calculatePosition(startPosition,GameController.DIRECTION.NORTH); 
            Assert.AreEqual(0, calcposition.coordinates.X);
            Assert.AreEqual(1, calcposition.coordinates.Y);
        }
        [Test]
        public void isPositionValidReturnsTrueWithValidPoint() {
            var testObj = new GameMap();
            var startPoint = new Point(0,0);
            var isPositionValid = testObj.isPositionValid(startPoint);
            Assert.True(isPositionValid);
        }
        [Test]
        public void GetCalculatePositionsMovingSouthNegative() {
            var testObj = new GameMap();
            var startPosition = new Position(0,0);
            var calcposition = testObj.calculatePosition(startPosition,GameController.DIRECTION.SOUTH); 
            Assert.AreEqual(0, calcposition.coordinates.X);
            Assert.AreEqual(0, calcposition.coordinates.Y);
        }
        [Test]
        public void GetCalculatePositionsMovingEastSuccessfully() {
            var testObj = new GameMap();
            var startPosition = new Position(9,9);
            var calcposition = testObj.calculatePosition(startPosition,GameController.DIRECTION.EAST); 
            Assert.AreEqual(9, calcposition.coordinates.X);
            Assert.AreEqual(9, calcposition.coordinates.Y);
        }
        [Test]
        public void GetCalculatePositionsMovingWestNegative() {
            var testObj = new GameMap();
            var startPosition = new Position(0,9);
            var calcposition = testObj.calculatePosition(startPosition,GameController.DIRECTION.WEST); 
            Assert.AreEqual(0, calcposition.coordinates.X);
            Assert.AreEqual(9, calcposition.coordinates.Y);
        }
    }
}