using System.Numerics;
using System;
using Raylib_cs;

namespace GameEngine
{
    public class Animation
    { 
        
        Texture2D spriteSheet;
        public Vector2 positionInTexture = new Vector2(100, 200);
        public Rectangle frameSize = new Rectangle(0, 0, 16, 12); 

        public int scale= 4;

        public Animation(){
            Image sourceImg = Raylib.LoadImage(@"AnimTest.png");

            Raylib.ImageResizeNN(ref sourceImg, sourceImg.width*scale, sourceImg.height*scale);
            frameSize.height = frameSize.height*scale;
            frameSize.width = frameSize.width*scale;

            spriteSheet = Raylib.LoadTextureFromImage(sourceImg);
        }
        public void DrawAnimation(/*Texture2D spriteSheet, Rectangle frameSize, Vector2 positionInTexture*/)
        {
            Raylib.DrawTextureRec(spriteSheet, frameSize, positionInTexture, Color.WHITE);
        }
    }
}
