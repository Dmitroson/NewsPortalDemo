using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsPortal.Models
{
    public class Image
    {
        public virtual int Id { get; set; }
        public virtual string UrlMini { get; set; }
        public virtual string UrlFullSize { get; set; }
        [Required]
        public virtual Article Article { get; set; }
    }
}