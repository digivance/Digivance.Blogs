using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs
{
    /// <summary>
    /// Represents a blog article
    /// </summary>
    public interface IBlogArticle
    {

        /// <summary>
        /// The ID of the author associated with the blog article.
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// The Text content of the blog article.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The subtitle of the blog article.
        /// </summary>
        public string? SubTitle { get; set; }

        /// <summary>
        /// The title of the blog article.
        /// </summary>
        public string Title { get; set; }
    }
}
