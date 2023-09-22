// using NUnit.Framework;
// using System.Drawing;
// using levelup;

// namespace levelup
// {
//     [TestFixture]
//     public class GameMapTest
//     {
//         private GameMap testObj;

//         [SetUp]
//         public void SetUp()
//         {
//             testObj = new GameMap();
//         }

//         [Test]
//         public void GetPositions_Returns10x10Matrix()
//         {
//             // Arrange

//             // Act
//             var positions = testObj.GetPositions();

//             // Assert
//             Assert.IsNotNull(positions);
//             Assert.AreEqual(10, positions.GetLength(0));
//             Assert.AreEqual(10, positions.GetLength(1));
//         }

//         [Test]
//         public void GetTotalPositions_Returns100()
//         {
//             // Arrange

//             // Act
//             var totalPositions = testObj.GetTotalPositions();

//             // Assert
//             Assert.AreEqual(100, totalPositions);
//         }

//         [Test]
//         public void CalculatePosition_MovingNorthSuccessfully()
//         {
//             // Arrange
//             var startPosition = new Position(0, 0);

//             // Act
//             var calcPosition = testObj.CalculatePosition(startPosition, GameController.Direction.North);

//             // Assert
//             Assert.AreEqual(0, calcPosition.Coordinates.X);
//             Assert.AreEqual(1, calcPosition.Coordinates.Y);
//         }

//         [Test]
//         [TestCase(0, 0, true)]
//         [TestCase(5, 5, true)]
//         [TestCase(-1, 0, false)]
//         [TestCase(0, -1, false)]
//         [TestCase(10, 0, false)]
//         [TestCase(0, 10, false)]
//         public void IsPositionValid_ReturnsExpectedResult(int x, int y, bool expectedResult)
//         {
//             // Arrange
//             var point = new Point(x, y);

//             // Act
//             var isPositionValid = testObj.IsPositionValid(point);

//             // Assert
//             Assert.AreEqual(expectedResult, isPositionValid);
//         }
//     }
// }
