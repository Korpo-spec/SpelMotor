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
        

        public Level(){

        }

        public Level(string name){
            this.levelName = name;
        }

        public void LoadLevel(){
            GameObject.gameObjects.Clear();

            GameObject.gameObjects = gameObjectsInScene;
            
        }

        public void SaveLevel(){

            gameObjectsInScene = GameObject.gameObjects;
            string fileName = levelName+ ".xml";
            

        }
    }
}
