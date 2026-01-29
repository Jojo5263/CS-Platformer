using System.Numerics;
using Microsoft.VisualBasic.FileIO;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;

public class Player{

    private CircleShape shape {get;set;}
    private float _speed; // Changed to a private field for internal use

    public Player(float radius, Vector2f position, float speed){ // Added speed parameter
        shape = new CircleShape(radius);
        shape.Position = position;
        _speed = speed; // Initialize the speed
    }

    public void Update(){

        if(Keyboard.IsKeyPressed(Keyboard.Key.A)){
            shape.Position += new Vector2f(-_speed, 0); // Use the initialized _speed
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.W)){
            shape.Position += new Vector2f(0, -_speed); // Use the initialized _speed
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.S)){
            shape.Position += new Vector2f(0, _speed); // Use the initialized _speed
        }

        if(Keyboard.IsKeyPressed(Keyboard.Key.D)){
            shape.Position += new Vector2f(_speed, 0); // Use the initialized _speed
        }
    }

    public void Draw(RenderWindow window){
        window.Draw(shape);
    }

    

}