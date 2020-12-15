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

        static Type[] extraTypes = {typeof(GameObject), typeof(Character), typeof(Player), typeof(Platform)};

        static XmlSerializer levelSerializer = new XmlSerializer (typeof(Level), extraTypes);

        public static bool changeLevel = false;
        

        public Level(){

        }

        public Level(string name){
            this.levelName = name;
        }

        public static void LoadLevel(string levelName2){
            
            using (FileStream file = File.Open(@"testLevel.xml", FileMode.OpenOrCreate))
            {
                
                GameObject.currentLevel = (Level) levelSerializer.Deserialize(file);
            }

            System.Console.WriteLine(GameObject.currentLevel.gameObjectsInScene.Count);
            
        }

        public void SaveLevel(){

           
            
            FileStream file = File.Open(@"testLevel2.xml", FileMode.OpenOrCreate);

            levelSerializer.Serialize(file, this);

            file.Close();
            

        }
    }
}
