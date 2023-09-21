using Sharprompt;
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
}