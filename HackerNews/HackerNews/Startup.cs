using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.BusinessLogic;
using HackerNews.BusinessLogic.Services;
using HackerNews.Constants;
using HackerNews.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace HackerNews
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                             .AllowAnyMethod()
                             .AllowAnyHeader();
                });
            });

            services.AddMvc().AddJsonOptions(opt =>
            {
                opt.SerializerSettings.ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() };

            });

            AppConstants appConstants = new AppConstants()
            {
                Setting = new Dictionary<string, string>()
                {
                    { "BASE_HN_URL_TOP", "https://hacker-news.firebaseio.com/v0/" },
                    { "BASE_HN_URL_ITEM", " https://hacker-news.firebaseio.com/v0/item/" }
                }
            };

           
            services.AddTransient<IServiceBank, ServiceBank>();
            services.AddTransient<IRepositoryBank>(s => new RepositoryBank(appConstants));

            services.AddTransient<IStoryService, StoryService>();
            services.AddTransient<ICommentService, CommentService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseMvc();
        }
    }
}
