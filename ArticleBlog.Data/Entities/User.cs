namespace ArticleBlog.Data.Entities
{
    public class User:BaseEntity
    {
        public string LoginKey{ get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
