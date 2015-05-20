using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpeedVST.App.models
{
    public class Pagination
    {
        public int AllPlugins { get; set; }
        public int PluginsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)AllPlugins / PluginsPerPage); }
        }
    }
}