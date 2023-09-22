using System;
using System.Drawing;

namespace levelup{
public class Position{
    public Point coordinates;

    public Position(){
        
    }

    public Position(int x, int y){
        coordinates = new Point(x, y);
    }
}
}