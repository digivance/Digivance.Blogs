using Digivance.Blogs.Commands;
using Digivance.Blogs.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Blogs.Tests
{
    [TestFixture]
    public class InMemoryBlogArticleServiceTests
    {
        [Test]
        public async Task Can_Create_Blog_Article()
        {
            var service = new InMemoryBlogArticleService();

            var command = new CreateBlogArticle
            {
                AuthorId = 1,
                Title = "Sample Blog Article",
                Content = "This is the content of the blog article",
                SubTitle = "A sample subtitle"
            };

            var blogArticle = await service.CreateBlogArticleAsync(command);
            await service.DeleteBlogArticleAsync(blogArticle.Id);

            Assert.That(blogArticle.AuthorId, Is.EqualTo(command.AuthorId));
            Assert.That(blogArticle.Title, Is.EqualTo(command.Title));
            Assert.That(blogArticle.Content, Is.EqualTo(command.Content));
            Assert.That(blogArticle.SubTitle, Is.EqualTo(command.SubTitle));
        }

        [Test]
        public async Task Can_Delete_Blog_Article()
        {
            var service = new InMemoryBlogArticleService();

            var command = new CreateBlogArticle
            {
                AuthorId = 1,
                Title = "Sample Blog Article",
                Content = "This is the content of the blog article",
                SubTitle = "A sample subtitle"
            };

            var blogArticle = await service.CreateBlogArticleAsync(command);
            await service.DeleteBlogArticleAsync(blogArticle.Id);

            Assert.ThrowsAsync<Exception>(async () => await service.GetBlogArticleAsync(blogArticle.Id));
        }

        [Test]
        public async Task Can_Get_Blog_Article()
        {
            var service = new InMemoryBlogArticleService();

            var command = new CreateBlogArticle
            {
                AuthorId = 1,
                Title = "Sample Blog Article",
                Content = "This is the content of the blog article",
                SubTitle = "A sample subtitle"
            };

            var blogArticle = await service.CreateBlogArticleAsync(command);
            var readArticle = await service.GetBlogArticleAsync(blogArticle.Id);
            await service.DeleteBlogArticleAsync(blogArticle.Id);

            Assert.That(blogArticle.AuthorId, Is.EqualTo(readArticle.AuthorId));
            Assert.That(blogArticle.Title, Is.EqualTo(readArticle.Title));
            Assert.That(blogArticle.Content, Is.EqualTo(readArticle.Content));
            Assert.That(blogArticle.SubTitle, Is.EqualTo(readArticle.SubTitle));
        }

        [Test]
        public async Task Can_Update_Blog_Article()
        {
            var service = new InMemoryBlogArticleService();

            var createCommand = new CreateBlogArticle
            {
                AuthorId = 1,
                Title = "Sample Blog Article",
                Content = "This is the content of the blog article",
                SubTitle = "A sample subtitle"
            };

            var blogArticle = await service.CreateBlogArticleAsync(createCommand);

            var updateCommand = new UpdateBlogArticle
            {
                Id = blogArticle.Id,
                Title = "Updated Blog Article",
                Content = "This is the updated content",
                SubTitle = "Updated subtitle"
            };

            var readArticle = await service.UpdateBlogArticleAsync(updateCommand);
            await service.DeleteBlogArticleAsync(blogArticle.Id);

            Assert.That(readArticle.AuthorId, Is.EqualTo(blogArticle.AuthorId));
            Assert.That(readArticle.Title, Is.EqualTo(updateCommand.Title));
            Assert.That(readArticle.Content, Is.EqualTo(updateCommand.Content));
            Assert.That(readArticle.SubTitle, Is.EqualTo(updateCommand.SubTitle));
        }
    }
}
