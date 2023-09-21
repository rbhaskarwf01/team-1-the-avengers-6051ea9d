using Sharprompt;
using System.Drawing;
using levelup;

public class GameMap{
    int Dimesion = 10;
    Position[,] gameMap;
    

    public GameMap(){
        gameMap = new Position[Dimesion,Dimesion];
    }
    public Position[,] getPositions(){
    return gameMap;
    }
    public int getTotalPositions(){
        return gameMap.Length;
    }
    public Position calculatePosition (Position position, GameController.DIRECTION direction){
        var NewPosition = new Position();
        var newpoint = new Point();

        switch (direction){
            case GameController.DIRECTION.NORTH:
                newpoint = new Point(position.coordinates.X,position.coordinates.Y +1);
                break;
        }

        if (isPositionValid(newpoint))
            return new Position(newpoint.X, newpoint.Y);
        return position;        
    }

    public bool isPositionValid(Point positionCoordinates){
        if(positionCoordinates.X < 0 || positionCoordinates.Y <0 || positionCoordinates.X >= Dimesion || positionCoordinates.Y >= Dimesion)
        return false;

        return true;
    }

}