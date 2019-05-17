using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.Base.Interface
{
    public interface IItemRepository<T> where T : class
    {
        T GetItem(int id);
    }

    public interface ITopItemRepository
    {
        IEnumerable<int> GetTopItems(string type);
    }
}
