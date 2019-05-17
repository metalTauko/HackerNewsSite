using System.Collections.Generic;
using HackerNews.DataAccess.DataModels;

namespace HackerNews.BusinessLogic.Services
{
    public interface IStoryService
    {
        StoryDto GetItem(int id);
        IEnumerable<StoryDto> TopStories(int count);
    }
}