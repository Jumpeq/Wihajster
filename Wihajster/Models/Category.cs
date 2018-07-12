using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wihajster.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public string MainPicture { get; set; }
        public string Description { get; set; }
        public decimal Prize { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}