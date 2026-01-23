using System.Numerics;
using Microsoft.VisualBasic.FileIO;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;

public class Player{

    private CircleShape shape;
    private float speed = 5f;

    public Player(float radius, Vector2f position){
        shape = new CircleShape(radius);
        shape.Position = position;
    }

    public void update(){

        if(Keyboard.IsKeyPressed(Keyboard.Key.A)){
            shape.Position += new Vector2f(-speed, 0);
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.W)){
            shape.Position += new Vector2f(0, -speed);
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.S)){
            shape.Position += new Vector2f(0, speed);
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.D)){
            shape.Position += new Vector2f(speed, 0);
        }
    }

    public void draw(RenderWindow window){
        window.Draw(shape);
    }

}