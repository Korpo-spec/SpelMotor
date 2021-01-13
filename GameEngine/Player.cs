using System;
using Raylib_cs;
using System.Numerics;


namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        private float jumpForce =200;
        
        
        Animation anim = new Animation();

        public Player(){
            hitbox = new Rectangle(position.X,position.Y,50,50);
        }
        public override void Update()
        {
            float deltaTime = Raylib.GetFrameTime();
            velocity.Y += currentLevel.gravity * 10 * deltaTime;
            
            
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                hitbox.x += 4;
                position.X += 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                hitbox.x -= 4;
                position.X -= 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                velocity.Y = -jumpForce;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_L)){
                Level.LoadLevel("testLevel");
            }

            if(Raylib.IsKeyDown(KeyboardKey.KEY_E)){
                hitbox.x = 300;
                position.X = 300;
                hitbox.y = 600;
                position.Y = 600;
            }
            

            hitbox.x = position.X;
            hitbox.y += velocity.Y * deltaTime;
            
            CheckForCollision();

            position.Y = hitbox.y;
            Level.camera.target = position + new Vector2(25, 25);
            anim.positionInTexture = position;
            Console.WriteLine(position);
        }

        public override void Draw()
        {
            
            Raylib.DrawRectangleRec(hitbox, Color.DARKBLUE);
            //anim.DrawAnimation();
            
        }

        public void AddToInventory(Item item)
        {

        }

        public void RemoveFromInventory(int n)
        {

        }

        public void UseItem(int n)
        {
            
        }

        /*public string GetItemInfo(int n) 
        {
            return;
        }*/

        /*public int GetInventoryLength()
        {
            return;
        }*/
    }
}
