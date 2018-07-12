using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wihajster.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}