using HackerNews.BusinessLogic.Services;
using HackerNews.Constants;
using HackerNews.DataAccess;
using HackerNews.DataAccess.DataModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest
{
  
    public class StoryServiceTest
    {
        IStoryService StoryService;

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

            StoryService = new StoryService(new RepositoryBank(appConstants));
        }

        [Test]
        public void TypeCheck()
        {
            StoryDto story = StoryService.GetItem(8863);

            Assert.AreEqual(typeof(StoryDto), story.GetType());
        }

        [Test]
        public void TypeShouldShowStory()
        {
           StoryDto story = StoryService.GetItem(8863);

            Assert.AreEqual(story.Type.ToLower(), "story");
        }

        [Test]
        public void TopStoriesCountMatch()
        {
            int assetCount = 8;
            int count = StoryService.TopStories(assetCount).Count();
            Assert.AreEqual(count, assetCount);
        }
    }
}
