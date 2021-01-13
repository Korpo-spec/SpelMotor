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
        public static Camera2D camera = new Camera2D();//level camera

        public string levelName;//name of the Level
        public List<GameObject> gameObjectsInScene = new List<GameObject>();//list of all objects in scene

        public float gravity = 98f;// the gravity of the current Level

        static Type[] extraTypes = {typeof(GameObject), typeof(Character), typeof(Player), typeof(Platform), typeof(Animation)};//all sorts of object that might appear as a subclass or in a subclass in gameobjectsInScene

        static XmlSerializer levelSerializer = new XmlSerializer (typeof(Level), extraTypes);//Serialiser for level and its subclasses
        public static bool changeLevel = false;//if true will change level in the end of next frame
        static string nextLevel;//name referens to next level
        
        

        public Level()//Only exsits so we can serialise and deserialise
        {

        }

        public Level(string name)//When the Level is created the first time and we want to name it
        {
            this.levelName = name;
        }

        public static void LoadLevel(string changeLevelTo)//Is possible to call for everywhere in the game and changes so that in the end of the frame it changes level
        {
            nextLevel = changeLevelTo;
            changeLevel = true;

        }

        /*

        LoadNextLevel() is called in the end of a frame if changeLevel is true

        When called it uses xml to serialize the data within the level and save it to a document so that we can load different levels. 
        When a level is loaded it changes the game objects list and thus changes the what we run and draw.

        */

        public static void LoadNextLevel()
        {

            string levelToLoad = nextLevel + ".xml";//lägger till .xml på filen så man bara behöver skriva namnet
            
            using (FileStream file = File.Open(levelToLoad, FileMode.OpenOrCreate))
            {
                
                GameObject.currentLevel = (Level) levelSerializer.Deserialize(file);//deserialiserar en fil
            }

            
            changeLevel = false;       //changes changeLevel back so that the method is not called every frame             
        }

        public void SaveLevel(string saveAs)//takes a filename as an input and serialises the current Level into a Level we can call upon/ a savegame
        {
            saveAs += ".xml";
           
            
            FileStream file = File.Open(saveAs, FileMode.OpenOrCreate);

            levelSerializer.Serialize(file, this);

            file.Close();
            

        }
    }
}
