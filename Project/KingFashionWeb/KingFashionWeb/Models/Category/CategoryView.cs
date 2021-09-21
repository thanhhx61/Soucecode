using System;
using System.Collections.Generic;
using System.Text;

namespace KingFashionWeb.Models.Category
{
    public class CategoryView
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        
    }
}
