using Digivance.Blogs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs.Services
{
    /// <summary>
    /// Used to indicate a service object capable of handling Blog Article functionality.
    /// </summary>
    public interface IBlogArticleService
    {
        /// <summary>
        /// Create and persist a new blog article record, returns a model representing the newly created blog article.
        /// </summary>
        /// <param name="command">The CreateBlogArticle command to execute</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>BlogArticle model representing the newly created blog article</returns>
        public Task<BlogArticle> CreateBlogArticleAsync(CreateBlogArticle command, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a blog article from storage.
        /// </summary>
        /// <param name="id">Unique ID of the blog article to remove</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>Task to await</returns>
        public Task DeleteBlogArticleAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a blog article by its unique ID.
        /// </summary>
        /// <param name="id">Unique ID of the blog article to return</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>BlogArticle model representing the requested blog article</returns>
        public Task<BlogArticle> GetBlogArticleAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates and persists a blog article and returns a BlogArticle model representing the updated blog article.
        /// </summary>
        /// <param name="command">The UpdateBlogArticle command to execute</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>BlogArticle model representing the updated blog article</returns>
        public Task<BlogArticle> UpdateBlogArticleAsync(UpdateBlogArticle command, CancellationToken cancellationToken = default);
    }
}
