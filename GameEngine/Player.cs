using System;
using Raylib_cs;
using System.Numerics;


namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here */

        private float jumpForce = 200; //A variable for how high the player can jump
        
        Animation anim; //A variable for storing the spritesheet for the player

        public Player() //Uses the above variable to turn the spritesheet png to the anim variable
        {
            string spriteSheetpng = "";
            anim = new Animation(spriteSheetpng);
            hitbox = new Rectangle(0,200 , 50 , 50);
        }

        public override void Update() //Overrides the Update method in gameobjects and fills it with controls and in world checks for the position, speed and collision of the player

        {
            float deltaTime = Raylib.GetFrameTime();// en delta time funktion
            velocity.Y += currentLevel.gravity * 10 * deltaTime;//sets velocity Y so that it simulates gravity
            
            
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))// checks what button is pressed and changes position of the player according to that
            {
                hitbox.x += 4;
                position.X += 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                hitbox.x -= 4;
                position.X -= 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))// if space is pressed make the character jump by setting the velocity.Y to negative
            {
                velocity.Y = -jumpForce;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_L)){//a test run to simulate level changes
                Level.LoadLevel("testLevel");
            }

            
            

            hitbox.x = position.X; //syncs the position and hitbox position
            hitbox.y += velocity.Y * deltaTime; // implements gravity
            
            CheckForCollision();//runs the script for checking collision

            position.Y = hitbox.y; //syncs the position and hitbox.Y
            Level.camera.target = position + new Vector2(25, 25);// makes the camera follow you

            anim.positionInWorld = position;// tests for the animation
            Console.WriteLine(position);

        }

        public override void Draw() //Overrides the GameObject draw method to draw the character into the scene
        {
            
            Raylib.DrawRectangleRec(hitbox, Color.DARKBLUE);//draws the character
            //anim.DrawAnimation();
            
        }

        public void AddToInventory(Item item) //Empty methods to add and remove items from the inventory, and to use items
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
