using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public string AuthorId { get; set; }
        public string Body { get; set; }
        public DateTimeOffset Created { get; set; } // Tells the date and time this document was created.
        public DateTimeOffset? Updated { get; set; } // This means I don't have to have and updated date and time.
        public string UpdateReason { get; set; }

        // Virtual Navigation section
        public virtual BlogPost BlogPost { get; set; }
        public virtual ApplicationUser Author { get; set; }

    }
}