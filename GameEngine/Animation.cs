using System.Numerics;
using System;
using Raylib_cs;

namespace GameEngine
{
    public class Animation
    { 
        
        Texture2D spriteSheet; //Reference texture to DrawTextureRec
        public Vector2 positionInWorld = new Vector2(100, 200); //A vector that decides where the Rec will be drawn in the world.
        public Rectangle frameSize = new Rectangle(0, 0, 16, 12); //The size of the part of the spritesheet that will be drawn.

        public int scale= 4; //The scale reference number

        public Animation(string spriteSheetpng) //The constructor that takes in a string variable of the spritesheet that will be used
        {
            Image sourceImg = Raylib.LoadImage(spriteSheetpng); //Uses the spritesheet string variable to create an Image.

            Raylib.ImageResizeNN(ref sourceImg, sourceImg.width*scale, sourceImg.height*scale); //Uses the scaling reference number to scale the Image
            frameSize.height = frameSize.height*scale; //These scales the framesize using the scaling reference to sclae it together with the Image
            frameSize.width = frameSize.width*scale;

            spriteSheet = Raylib.LoadTextureFromImage(sourceImg); //creates a drawable texture from the previously set spritesheet Image.
        }
        public void DrawAnimation() //Method that draws the rec
        {
            Raylib.DrawTextureRec(spriteSheet, frameSize, positionInWorld, Color.WHITE);//Uses the spritesheet texture, framesize, the postition in the world, and a color tho draw the correct frame 
        }
    }
}
