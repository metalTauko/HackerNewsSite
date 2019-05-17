using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.Constants;

namespace HackerNews.DataAccess.Repositories
{
    public class TopItemRepository : AbstractITopItemsHNRepository
    {
        public TopItemRepository(IAppConstants appConstants) : base(appConstants)
        {
        }
    }
}
