using ArticleBlog.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleBlog.API.Repositories.ArticleRepo
{
    public interface IArticleRepository
    {
        Task<List<ArticleDTO>> GetArticles();
        Task<ArticleDTO> GetArticle(int Id);
        Task<ArticleDTO> AddArticle(ArticleDTO articleDto);
        Task<ArticleDTO> UpdateArticle(int Id, ArticleDTO articleDto);
        Task RemoveArticle(int Id);
        Task SaveChanges();
    }
}
