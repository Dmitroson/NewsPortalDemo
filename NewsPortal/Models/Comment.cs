using Microsoft.AspNet.Identity.EntityFramework;
using NewsPortal.Models.ClassMap;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsPortal.Models
{
    public class Comment
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime? PubDate { get; set; }
        public virtual Article Article { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}