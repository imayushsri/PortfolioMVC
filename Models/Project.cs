using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Project
    {
        public string ImgPath { get; set; }
        public bool IsBlog { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GhLink { get; set; }
        public string DemoLink { get; set; }
    }
}