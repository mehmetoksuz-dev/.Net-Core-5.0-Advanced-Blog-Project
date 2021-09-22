using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; } //string unutuldu burası bende datetime
        public bool BlogStatus { get; set; }

        public int CategoryID { get; set; } //rship
        public Category Category { get; set; } //rship

        public List<Comment> Comments { get; set; } //rship
    }
}
