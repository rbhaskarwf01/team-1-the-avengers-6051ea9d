using Sharprompt;
using levelup;

namespace levelup{
    public class FakeGameMap : GameMap{

        public FakeGameMap() : base(){
            
        }

        public Position calculatePosition(Position startingPosition, GameController.DIRECTION direction){
            return new Position(1,2);
        }
    }
}