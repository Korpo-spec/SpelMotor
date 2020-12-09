using System;
using Raylib_cs;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GameEngine
{
    public class Item
    {
        public string name; //Den här ska nog inte vara public?

        public int price;

        public int quantity;

        public Image icon;

        public List<Item> items = new List<Item>();

        static XmlSerializer itemSerializer = new XmlSerializer (typeof (List<Item>));

        public void Serialize()
        {
            FileStream file = File.Open(@"items.xml", FileMode.OpenOrCreate);

            itemSerializer.Serialize(file, items);

            file.Close();
        }

        public void Deserialize()
        {
            using (FileStream file = File.Open(@"items.xml", FileMode.OpenOrCreate))
            {
                items = (List<Item>) itemSerializer.Deserialize(file);
            }
        }

        public Item()
        {
            items.Add(this);
            System.Console.WriteLine(items.Count);
        }

        /*public string GetInfo()
        {
            return;
        }*/

        public void Use(Character target) //Jag börjar med en klassisk HP-potion, som egentligen sen ska flyttas bort från item-klassen till en subklass. 
        {
            Character p1 = new Character();

            //p1.hp += 5;
        }

    }
}
