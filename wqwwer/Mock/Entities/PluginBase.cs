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

        public PluginBase(int id, string title, DateTime releasedate, string author, string cat, decimal price = 1)
         {
        ID = id;
        Title = title;
        Author = author;
        Cat = cat;
        ReleaseDate = releasedate;
        Price = price;
        }
    }
}