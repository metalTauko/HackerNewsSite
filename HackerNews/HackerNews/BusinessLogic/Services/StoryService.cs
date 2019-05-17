using HackerNews.DataAccess;
using HackerNews.DataAccess.Base.Interface;
using HackerNews.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.BusinessLogic.Services
{
    public class StoryService : BaseService, IStoryService
    {
        public StoryService(IRepositoryBank repositoryBank) : base(repositoryBank)
        {
        }

        public StoryDto GetItem(int id)
        {
            return _repositoryBank.StoryRepository.GetItem(id);
        }

        public IEnumerable<StoryDto> TopStories(int count)
        {
            IEnumerable<int> listTopStories = _repositoryBank.TopItemRepository.GetTopItems("topstories");

            foreach (int id in listTopStories.Take(count))
            {
                yield return GetItem(id);
            }
        }
    }
}
