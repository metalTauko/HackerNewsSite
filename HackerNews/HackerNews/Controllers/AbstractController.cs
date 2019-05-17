using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerNews.Controllers
{
   
    public class AbstractController : Controller
    {
        protected IServiceBank _serviceBank;

        public AbstractController(IServiceBank serviceBank)
        {
            _serviceBank = serviceBank;      
        }
    }
}