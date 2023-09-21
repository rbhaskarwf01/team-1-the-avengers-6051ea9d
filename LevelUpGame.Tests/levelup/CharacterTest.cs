using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class CharacterTests
    {
        private Character? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        [Test]
        public void CanSetCharacterName(){
            var testChar = new Character("Susie");
            Assert.AreEqual("Susie", testChar.Name);
        }
        
        [Test]
        public void CanSetDefaultCharacterName(){
            var testChar = new Character();
            Assert.AreEqual("Charlie", testChar.Name);
        }

        [Test]
        public void GetNameReturnsName(){
            var testChar = new Character("John");
            var charName = testChar.getName();
            Assert.AreEqual("John", charName);
        }
        
        [Test]
        public void EnterMapSetsMap(){
            var testMap = new GameMap();

            testObj.enterMap(testMap);
            Assert.AreEqual(testMap, testObj.map);
        }

        [Test]
        public void GetPositionIsNotNull(){
            var testChar = new Character("Susie");
            testChar.position = new Position(1,2);
            var position = testChar.getPosition();
            Assert.IsNotNull(position);
        }

        [Test]
        public void MoveNorthMovesCharacterOnePositionNorth()
        {
            var gameMap = new GameMap();
            var testChar = new Character("John", gameMap);
            testChar.move(GameController.DIRECTION.NORTH);
            var newPosition = testChar.getPosition();
            Assert.AreEqual(0, newPosition.coordinates.X);
            Assert.AreEqual(1, newPosition.coordinates.Y);
        }
    }
}