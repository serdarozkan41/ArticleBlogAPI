namespace ArticleBlog.Data
{
    public abstract class BaseResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
