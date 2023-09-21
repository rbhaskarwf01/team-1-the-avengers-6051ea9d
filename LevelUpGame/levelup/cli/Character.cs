using Sharprompt;
using levelup;

public class Character{
    public static String DEFAULT_NAME = "Charlie";
    public string Name;
    public GameMap map;
    public Position position;
    public GameMap gameMap;

    public Character(){
        Name = DEFAULT_NAME;
    }

    public Character(string name){
        Name = name;
        gameMap = new GameMap();
    }

    public Character(string name, GameMap map){
        Name = name;
        gameMap = map;
    }

    public string getName(){
        return Name;
    }

    public void enterMap(GameMap gameMap){
        map = gameMap;
    }

    public Position getPosition(){
        return position;
    }

    public void move(GameController.DIRECTION direction){
        position = gameMap.calculatePosition(position, direction);
    }
}