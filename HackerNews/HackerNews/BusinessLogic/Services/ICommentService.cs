using HackerNews.DataAccess.DataModels;

namespace HackerNews.BusinessLogic.Services
{
    public interface ICommentService
    {
        CommentDto GetItem(int id);
    }
}