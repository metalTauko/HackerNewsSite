﻿using HackerNews.BusinessLogic.Services;
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
        IStoryService storyService;

        int itemId = 8863;

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

            storyService = new StoryService(new RepositoryBank(appConstants));
        }
              
        [Test]
        public void TypeShouldShowStory()
        {
           StoryDto story = storyService.GetItem(itemId);

            Assert.AreEqual(story.Type.ToLower(), "story");
        }

        [Test]
        public void TopStoriesCountMatch()
        {
            int assetCount = 8;
            int count = storyService.TopStories(assetCount).Count();
            Assert.AreEqual(count, assetCount);
        }
    }
}
