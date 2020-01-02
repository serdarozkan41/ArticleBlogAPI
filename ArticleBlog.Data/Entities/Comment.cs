namespace ArticleBlog.Data.Entities
{
    public class Comment:BaseEntity
    {
        public string CommentText { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
