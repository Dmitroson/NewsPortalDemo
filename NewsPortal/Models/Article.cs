using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsPortal.Models
{
    public class Article
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
        }

        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? PubDate { get; set; }
        public virtual Image Image { get; set; }
        public virtual ISet<Comment> Comments { get; set; }
    }
}