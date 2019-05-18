using HackerNews.BusinessLogic.Services;
using HackerNews.Constants;
using HackerNews.DataAccess;
using HackerNews.DataAccess.DataModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    class CommentTest
    {
        ICommentService commentService;
        int itemId = 9224;

        [SetUp]
        public void Setup()
        {
            

            AppConstants appConstants = new AppConstants()
            {
                Setting = new Dictionary<string, string>()
                {
                    { "BASE_HN_URL_TOP", "https://hacker-news.firebaseio.com/v0/" },
                    { "BASE_HN_URL_ITEM", " https://hacker-news.firebaseio.com/v0/item/" }
                }
            };

            commentService = new CommentService(new RepositoryBank(appConstants));
        }
        
        [Test]
        public void TypeShouldShowComment()
        {
            CommentDto comment = commentService.GetItem(itemId);

            Assert.AreEqual(comment.Type.ToLower(), "comment");
        }
    }

}
