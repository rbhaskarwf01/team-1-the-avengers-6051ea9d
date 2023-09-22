using System.Drawing;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Charlie";
        Character character;
        GameMap map;

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition,
            int moveCount
            );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Point(-1,-1);
            //TODO: Write a failing unit test that will force you to set this to the right number
            status.moveCount = -100;
        }

        // Pre-implemented to demonstrate ATDD
        // DONE: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                character = new Character(name);   
                this.status.characterName = character.Name;  
            }
            else
            {
                character = new Character(DEFAULT_CHARACTER_NAME);     
                this.status.characterName = character.Name;
            }
        }

        public void StartGame()
        {
            // DONE: Implement startGame - Should probably create positions and put the character on one
            // DONE: Should also update the game status?
            if(character == null)
                character = new Character("");

            map = new GameMap();
            character.enterMap(map);
            status.currentPosition = character.getPosition().coordinates;
            status.moveCount = 0;
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            character.move(directionToMove);
            status.currentPosition = character.getPosition().coordinates;
            status.moveCount++;
        }

        public void SetCharacterPosition(Point coordinates)
        {
            //TODO: IMPLEMENT THIS TO SET CHARACTERS CURRENT POSITION -- exists to be testable
            if(character == null)
                character = new Character();
                
            character.position.coordinates = coordinates;
        }

        public void SetCurrentMoveCount(int moveCount)
        {
            //TODO: IMPLEMENT THIS TO SET CURRENT MOVE COUNT -- exists to be testable
            status.moveCount = moveCount;
        }

        public int GetTotalPositions()
        {
            //TODO: IMPLEMENT THIS TO GET THE TOTAL POSITIONS FROM THE MAP -- exists to be testable
            return map.getTotalPositions();
        }


    }
}