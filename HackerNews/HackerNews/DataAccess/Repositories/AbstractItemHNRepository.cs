using HackerNews.Constants;
using HackerNews.DataAccess.Base.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.Repositories
{
    public abstract class AbstractItemHNRepository<T> : IItemRepository<T> where T : class
    {
        private string _url;
        private WebClient _client; 

      
        public AbstractItemHNRepository(IAppConstants appConstants)
        {
            _url = appConstants.Setting["BASE_HN_URL_ITEM"];
            _client = new WebClient();

        }
        public T GetItem(int id)
        {
            string data = DownloadString(id);
            return JsonConvert.DeserializeObject<T>(data);
        }

        protected string DownloadString(int id)
        {
            return _client.DownloadString(CompleteUrl(id));
        }

        protected string CompleteUrl(int id)
        {
            return _url + id + ".json";
        }
    }
}
