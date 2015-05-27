using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpeedVST.App.Entities
{
    public class PluginBase
       {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Cat { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        public PluginBase(int id)
        {
            ID = id;
        }
        public PluginBase(string title, DateTime releasedate, string author, string cat, decimal price)
        {
            Title = title;
            ReleaseDate = releasedate;
            Author = author;
            Cat = cat;
            Price = price;
        }
        public PluginBase(int id, string title, DateTime releasedate, string author, string cat, decimal price)
         {
        ID = id;
        Title = title;
        ReleaseDate = releasedate;
        Author = author;
        Cat = cat;
        Price = price;
        }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var pluginBase = obj as PluginBase;
            return ID.Equals(pluginBase.ID) 
                && Title.Equals(pluginBase.Title) 
                && ReleaseDate.Equals(pluginBase.ReleaseDate)
                && Author.Equals(pluginBase.Author)
                && Cat.Equals(pluginBase.Cat)
                && Price.Equals(pluginBase.Price);

        }
    }
}