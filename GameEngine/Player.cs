using System;
using Raylib_cs;
using System.Numerics;


namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        private float jumpForce =200;

        public override void Update()
        {
            float deltaTime = Raylib.GetFrameTime();
            velocity.Y += gravity * 10 * deltaTime;
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                position.X += 4;
                
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                position.X -= 4;
                
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                velocity.Y = -jumpForce;
            }

            body.x = position.X;
            body.y += velocity.Y * deltaTime;
            
            CheckForCollision();

            position.Y = body.y;
            Level.camera.target = position + new Vector2(25, 25);
        }

        public override void Draw()
        {
            
            Raylib.DrawRectangleRec(body, Color.DARKBLUE);
            
        }
    }
}
