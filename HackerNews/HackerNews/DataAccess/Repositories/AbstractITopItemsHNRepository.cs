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
    public class AbstractITopItemsHNRepository : ITopItemRepository
    {
        private string _url;
        private WebClient _client;


        public AbstractITopItemsHNRepository(IAppConstants appConstants)
        {
            _url = appConstants.Setting["BASE_HN_URL_TOP"];
            _client = new WebClient();

        }

        
        protected string DownloadString(string type)
        {
            return _client.DownloadString(CompleteUrl(type));
        }

        protected string CompleteUrl(string type)
        {
            return _url + type + ".json";
        }

        public IEnumerable<int> GetTopItems(string type)
        {
            string data = DownloadString(type);

            return JsonConvert.DeserializeObject<IEnumerable<int>>(data);
        }
    }
}
