using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs.Commands
{
    /// <summary>
    /// A command object containing all of the necessary fields to create a new
    /// Blog Article.
    /// </summary>
    public class CreateBlogArticle : IBlogArticle
    {
        /// <inheritdoc />
        public int AuthorId { get; set; }

        /// <inheritdoc />
        public string Content { get; set; }

        /// <inheritdoc />
        public string? SubTitle { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }
    }

}

