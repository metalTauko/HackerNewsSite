using HackerNews.Constants;
using HackerNews.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.Repositories
{
    public class CommentItemRepository : AbstractItemHNRepository<CommentDto>
    {
        public CommentItemRepository(IAppConstants appConstants) : base(appConstants)
        {
        }


    }
}
