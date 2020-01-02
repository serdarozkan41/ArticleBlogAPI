using ArticleBlog.Data.Dto;
using ArticleBlog.Data.Entities;
using AutoMapper;

namespace ArticleBlog.Data
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Article, ArticleDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            //CreateMap<UserDTO, User>();
            //CreateMap<ArticleDTO, Article>();
            //CreateMap<CommentDTO, Comment>();
        }
    }
}
