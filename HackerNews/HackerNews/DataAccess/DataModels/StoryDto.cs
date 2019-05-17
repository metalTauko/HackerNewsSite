using HackerNews.DataAccess.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.DataModels
{
    public class StoryDto : BaseContent
    {        
        public int Descendants { get; set; }
        public List<int> Kids { get; set; }
        public string Url { get; set; }
        public int Score { get; set; }
    }
}
