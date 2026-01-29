using System.Numerics;
using SFML.Graphics;
using SFML.System;

public class BorderWall{

    private RectangleShape shape = new RectangleShape();

    public BorderWall(Vector2f position, Vector2f size, Color color){
        shape.Position = position;
        shape.Size = size;
        shape.FillColor = color;
    }

    public void Update(){

    }

    public void Draw(RenderWindow window){
        window.Draw(shape);
    }   
}