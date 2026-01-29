using System.Collections.Generic;
using SFML.Graphics;

public class Level{

    public List<BorderWall> Walls = new List<BorderWall>();
    public void Update(){

    }

    public void Draw(RenderWindow window){
        
        foreach (var wall in Walls)
        {
            wall.Draw(window);
        }
    }
}