using HackerNews.Constants;
using HackerNews.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.Repositories
{
    public class StoryItemRepository : AbstractItemHNRepository<StoryDto>
    {
        public StoryItemRepository(IAppConstants appConstants) : base(appConstants)
        {
        }
    }
}
