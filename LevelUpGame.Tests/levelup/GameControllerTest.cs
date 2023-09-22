using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }

        [Test]
        public void CreateCharacterInitializesStatus(){
            testObj.CreateCharacter("Susie");
            var status = testObj.GetStatus();
            Assert.AreEqual("Susie", status.characterName);
        }

        [Test]
        public void CreateCharacterWithEmptyCharacterNameInitializesDefaultCharacter(){
            testObj.CreateCharacter("");
            var status = testObj.GetStatus();
            Assert.AreEqual("Charlie", status.characterName);
        }
    }
}