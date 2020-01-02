using ArticleBlog.Data;
using ArticleBlog.Data.Dto;
using ArticleBlog.Data.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArticleBlog.API.Repositories.ArticleRepo
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ArticleRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ArticleDTO> AddArticle(ArticleDTO articleDto)
        {
            await _context.Articles.AddAsync(_mapper.Map<Article>(articleDto));
            await SaveChanges();
            return articleDto;
        }

        public async Task<ArticleDTO> GetArticle(int Id)
        {
            var article = await _context.Articles.Include(s=>s.Comments).FirstOrDefaultAsync(s=>s.Id==Id);
            return _mapper.Map<ArticleDTO>(article);
        }

        public async Task<List<ArticleDTO>> GetArticles()
        {
            var articles = await _context.Articles.Include(s => s.Comments).ToListAsync();
            return _mapper.Map<List<ArticleDTO>>(articles);
        }

        public async Task RemoveArticle(int Id)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(s => s.Id == Id);
            _context.Remove(article);
            await SaveChanges();
        }

        public async Task<ArticleDTO> UpdateArticle(int Id, ArticleDTO articleDto)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(s => s.Id == Id);
            article = _mapper.Map<Article>(articleDto);
            _context.Articles.Update(article);
            await SaveChanges();
            return articleDto;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
