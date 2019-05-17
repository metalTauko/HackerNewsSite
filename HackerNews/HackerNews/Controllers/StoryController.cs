using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.BusinessLogic;
using HackerNews.DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerNews.Controllers
{
    [Route("api/[controller]")]
    public class StoryController : AbstractController
    {
        public StoryController(IServiceBank serviceBank) : base(serviceBank)
        {
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public StoryDto Get(int id)
        {
            return this._serviceBank.StoryService.GetItem(id);
        }

        [HttpGet]
        [Route("TopStories")]
        public IEnumerable<StoryDto> TopStories(int count)
        {
            return this._serviceBank.StoryService.TopStories(count);
        }
    }
}
