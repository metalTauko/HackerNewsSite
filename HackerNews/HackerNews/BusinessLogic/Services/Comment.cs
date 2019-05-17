using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.DataAccess;
using HackerNews.DataAccess.DataModels;

namespace HackerNews.BusinessLogic.Services
{
    public class CommentService : BaseService, ICommentService
    {
        public CommentService(IRepositoryBank repositoryBank) : base(repositoryBank)
        {
        }

        public CommentDto GetItem(int id)
        {
            return _repositoryBank.CommentRepository.GetItem(id);
        }
    }
}
