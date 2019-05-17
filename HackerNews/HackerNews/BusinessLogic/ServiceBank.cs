using HackerNews.BusinessLogic.Services;
using HackerNews.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.BusinessLogic
{
    public class ServiceBank : IServiceBank
    {
       

        public ServiceBank( IStoryService storyService, ICommentService sommentService)
        {
            StoryService = storyService;
            CommentService = sommentService;
        }

        public IStoryService StoryService { get; }
        public ICommentService CommentService { get; }
    }
}
