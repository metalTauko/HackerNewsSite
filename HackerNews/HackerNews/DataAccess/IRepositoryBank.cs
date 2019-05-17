using HackerNews.DataAccess.Base.Interface;
using HackerNews.DataAccess.DataModels;

namespace HackerNews.DataAccess
{
    public interface IRepositoryBank
    {
        IItemRepository<CommentDto> CommentRepository { get; }
        IItemRepository<StoryDto> StoryRepository { get; }
        ITopItemRepository TopItemRepository { get; }
    }
}