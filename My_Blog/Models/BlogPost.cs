using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Blog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; } // This URL will record the path of the media or image.
        public bool Published { get; set; } // This will only publish once the blog is completd.
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }

        // Virtual nav section
        public virtual ICollection<Comment> Comments { get; set; }

        public BlogPost() 
        {
            Comments = new HashSet<Comment>();
        }

    }
}