using System;
using System.Collections.Generic;

namespace ArticleBlog.Data.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseData { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
