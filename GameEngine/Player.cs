using System;
using Raylib_cs;

namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        

        public override void Update()
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                body.x += 1;
            }

            body.y += 1;

            CheckForCollision();
        }

        public override void Draw()
        {
            Raylib.DrawRectangleRec(body, Color.DARKBLUE);
        }
    }
}
