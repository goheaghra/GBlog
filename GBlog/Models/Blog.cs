using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBlog.Models
{
    public class Blog
    {
        //test

        public virtual int BlogId { get; set; }
        
        [Required]
        public virtual string Title { get; set; }
        
        [AllowHtml]
        [Required]
        [DataType(DataType.MultilineText)]
        public virtual string Content { get; set; }

        public virtual DateTime CreatedOn { get; set; }
        
        public virtual DateTime ChangedOn { get; set; }
    }
}

