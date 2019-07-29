using My_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Blog.Utilities
{
    public class DataUtilities
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IQueryable<BlogPost> IndexSearch(string searchStr)
        {
            var result = db.BlogPosts.Where(b => b.Published);
            if (searchStr != null)
            {
                result = result.Where(p => p.Title.Contains(searchStr) ||
                                      p.Body.Contains(searchStr) ||
                                      p.Comments.Any(c => c.Body.Contains(searchStr) ||
                                                     c.Author.FirstName.Contains(searchStr) ||
                                                     c.Author.LastName.Contains(searchStr) ||
                                                     c.Author.DisplayName.Contains(searchStr) ||
                                                     c.Author.Email.Contains(searchStr)));
            }
           
            return result.OrderByDescending(p => p.Created);
        }




    }
}