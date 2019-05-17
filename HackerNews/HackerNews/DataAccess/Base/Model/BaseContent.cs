using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.DataAccess.Base.Model
{
    public class BaseContent
    {

        public string By { get; set; }
        public int Id { get; set; }
        public int Time { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
