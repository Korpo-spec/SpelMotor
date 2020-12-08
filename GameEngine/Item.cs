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
        public int price;

        public int quantity;

        public Image icon;

        public List<Item> items = new List<Item>();

        static XmlSerializer itemSerializer;

        public void Serialize()
        {
            itemSerializer = new XmlSerializer (typeof (List<Item>));

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
        }
        
    }

    
}
