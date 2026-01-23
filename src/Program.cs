using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace MeinSpiel;

class Program
{
    static void Main(string[] args)
    {

        Player player = new Player(10f, new Vector2f(300, 300));
        var mode = new VideoMode(1920, 1080);
        var window = new RenderWindow(mode, "Mein SFML Spiel auf Arch");

        
        window.SetFramerateLimit(60);

        
        window.Closed += (sender, e) => window.Close();

        
        while (window.IsOpen)
        {
           
            window.DispatchEvents();

            
            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                window.Close();
            }

            player.update();

            // B. Zeichnen (Render)
            window.Clear(); 
            player.draw(window);
            window.Display();         
        }
    }
}