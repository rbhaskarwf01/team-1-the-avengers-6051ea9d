// using System;
// using System.Drawing;
// using levelup;

// namespace levelup{
// public class GameMap
// {
//     public int Dimension { get; } = 10;
//     public Position[,] Positions { get; }

//     public GameMap()
//     {
//         Positions = new Position[Dimension, Dimension];
//     }

// public Position[,] getPositions(){
//     return gameMap;
//     }
//     public int getTotalPositions(){
//         return gameMap.Length;
//     }

//     public Position calculatePosition(Position position, GameController.DIRECTION direction)
//     {
//         var newPosition = new Position();
//         var newPoint = new Point();

//         switch (direction)
//         {
//             case GameController.DIRECTION.NORTH:
//                 newPoint = new Point(position.coordinates.X, position.coordinates.Y + 1);
//                 break;
//             // Handle other directions here
//         }

//         return IsPositionValid(newPoint) ? new Position(newPoint.X, newPoint.Y) : position;
//     }

//     public bool IsPositionValid(Point positioncoordinates)
//     {
//         return positioncoordinates.X >= 0 && positioncoordinates.Y >= 0 &&
//                positioncoordinates.X < Dimension && positioncoordinates.Y < Dimension;
//     }
// }
// }
