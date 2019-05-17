using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerNews.Constants
{
    public class AppConstants : IAppConstants
    {
        public Dictionary<string, string> Setting { get; set; }
    }
}
