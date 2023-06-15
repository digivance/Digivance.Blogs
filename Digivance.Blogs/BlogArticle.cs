using Digivance.Core;
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
    public class BlogArticle : IBlogArticle, IAuditable
    {
        /// <inheritdoc />
        public int AuthorId { get; set; }

        /// <inheritdoc />
        public string Content { get; set; }

        /// <inheritdoc />
        public int CreatedById { get; set; }

        /// <inheritdoc />
        public DateTime CreatedDate { get; set; }

        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public int? ModifiedById { get; set; }

        /// <inheritdoc />
        public DateTime? ModifiedDate { get; set; }

        /// <inheritdoc />
        public string? SubTitle { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }
    }
}
