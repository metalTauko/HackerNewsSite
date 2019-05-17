using HackerNews.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.BusinessLogic.Services
{
    public abstract class BaseService
    {
        protected IRepositoryBank _repositoryBank;

        protected IServiceBank _serviceBank;

        public BaseService(IRepositoryBank repositoryBank)
        {
            _repositoryBank = repositoryBank;
        }
    }
}
