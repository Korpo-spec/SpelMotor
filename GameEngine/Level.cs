using System;
using Raylib_cs;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GameEngine
{
    public class Level
    {
        public static Camera2D camera = new Camera2D();

        public string levelName;
        public List<GameObject> gameObjectsInScene = new List<GameObject>();

        public float gravity = 98f;
        

        public Level(){

        }

        public Level(string name){
            this.levelName = name;
        }

        public void LoadLevel(){
            
            
        }

        public void SaveLevel(){

            
            

        }
    }
}
