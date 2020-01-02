using System;
using System.Collections.Generic;

namespace ArticleBlog.Data.Dto
{
    public class ArticleDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseData { get; set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
