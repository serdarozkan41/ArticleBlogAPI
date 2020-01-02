namespace ArticleBlog.Data.Dto
{
    public class CommentDTO
    {
        public string CommentText { get; set; }
        public ArticleDTO Article { get; set; }
        public UserDTO User { get; set; }
    }
}
