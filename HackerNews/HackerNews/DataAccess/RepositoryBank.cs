using HackerNews.Constants;
using HackerNews.DataAccess.Base.Interface;
using HackerNews.DataAccess.DataModels;
using HackerNews.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess
{
    public sealed class RepositoryBank : IRepositoryBank
    {
        private IItemRepository<StoryDto> _storyRepository = null;
        private IItemRepository<CommentDto> _commentRepository = null;
        private ITopItemRepository _topItemRepository = null;

        private IAppConstants _appConstants;

        public RepositoryBank(IAppConstants appConstants)
        {
            _appConstants = appConstants;
        }
           

        public IItemRepository<StoryDto> StoryRepository
        {
            get
            {
                if (_storyRepository == null)
                {
                    _storyRepository = new StoryItemRepository(_appConstants);
                }

                return _storyRepository;
            }
        }


        public IItemRepository<CommentDto> CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                {
                    _commentRepository = new CommentItemRepository(_appConstants);
                }

                return _commentRepository;
            }
        }

        public ITopItemRepository TopItemRepository
        {
            get
            {
                if (_topItemRepository == null)
                {
                    _topItemRepository = new TopItemRepository(_appConstants);
                }

                return _topItemRepository;
            }
        }
    }
}
