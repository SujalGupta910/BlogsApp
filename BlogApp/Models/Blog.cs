using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public String BlogHeading { get; set; }
        public String BlogContent { get; set; }
        public Blog()
        {

        }
    }
}