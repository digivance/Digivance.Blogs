using Digivance.Blogs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs.Services
{
    /// <summary>
    /// Very basic implementation of BlogArticleService in memory, note that the BlogArticles
    /// collection is static to support scoped dependency injection.
    /// </summary>
    public class InMemoryBlogArticleService : IBlogArticleService
    {
        /// <summary>
        /// The "database" of blog articles
        /// </summary>
        protected static List<BlogArticle> BlogArticles = new List<BlogArticle>();

        /// <inheritdoc />
        public Task<BlogArticle> CreateBlogArticleAsync(CreateBlogArticle command, CancellationToken cancellationToken = default)
        {
            var newBlogArticle = new BlogArticle
            {
                AuthorId = command.AuthorId,
                Content = command.Content,
                CreatedById = 0,
                CreatedDate = DateTime.UtcNow,
                SubTitle = command.SubTitle,
                Title = command.Title,
            };

            BlogArticles.Add(newBlogArticle);
            return Task.FromResult(newBlogArticle);
        }

        /// <inheritdoc />
        public Task DeleteBlogArticleAsync(int id, CancellationToken cancellationToken = default)
        {
            var existingBlogArticle = BlogArticles.FirstOrDefault(article => article.Id == id);
            if (existingBlogArticle != null)
                BlogArticles.Remove(existingBlogArticle);

            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<BlogArticle> GetBlogArticleAsync(int id, CancellationToken cancellationToken = default)
        {
            var existingBlogArticle = BlogArticles.FirstOrDefault(article => article.Id == id);
            if (existingBlogArticle == null)
                throw new Exception("Blog article not found");

            return Task.FromResult(existingBlogArticle);
        }

        /// <inheritdoc />
        public Task<BlogArticle> UpdateBlogArticleAsync(UpdateBlogArticle command, CancellationToken cancellationToken = default)
        {
            var existingBlogArticle = BlogArticles.FirstOrDefault(article => article.Id == command.Id);
            if (existingBlogArticle == null)
                throw new Exception("Blog article not found");

            existingBlogArticle.Content = command.Content;
            existingBlogArticle.ModifiedDate = DateTime.UtcNow;
            existingBlogArticle.SubTitle = command.SubTitle;
            existingBlogArticle.Title = command.Title;

            return Task.FromResult(existingBlogArticle);
        }
    }
}
