using HackerNews.BusinessLogic.Services;

namespace HackerNews.BusinessLogic
{
    public interface IServiceBank
    {
        ICommentService CommentService { get; }
        IStoryService StoryService { get; }
    }
}