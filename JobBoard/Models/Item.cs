using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Contact_Info { get; set; }

        private static List<Item> _instances = new List<Item> { };

        public Item(string title, string description, string contactInfo)
        {
            Title = title;
            Description = description;
            Contact_Info = contactInfo;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}