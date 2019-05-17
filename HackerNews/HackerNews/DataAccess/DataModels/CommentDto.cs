using HackerNews.DataAccess.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.DataModels
{
    public class CommentDto : BaseContent
    {
        public List<int> Kids { get; set; }

        public string Parent { get; set; }

        public string Text { get; set; }

    }
}
