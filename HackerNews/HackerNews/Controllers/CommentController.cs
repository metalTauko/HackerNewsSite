using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.BusinessLogic;
using HackerNews.DataAccess.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerNews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : AbstractController
    {
        public CommentController(IServiceBank serviceBank) : base(serviceBank)
        {
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public CommentDto Get(int id)
        {
            return this._serviceBank.CommentService.GetItem(id);
        }
    }
}