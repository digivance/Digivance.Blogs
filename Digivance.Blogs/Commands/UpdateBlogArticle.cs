using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs.Commands
{
    /// <summary>
    /// A command object containing all of the fields necessary to update a Blog Article
    /// </summary>
    public class UpdateBlogArticle : IBlogArticle
    {
        /// <inheritdoc />
        public int AuthorId { get; set; }

        /// <inheritdoc />
        public string Content { get; set; }

        /// <summary>
        /// Unique id of the blog user is updating
        /// </summary>
        public string Id { get; set; }

        /// <inheritdoc />
        public string? SubTitle { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }
    }
}
