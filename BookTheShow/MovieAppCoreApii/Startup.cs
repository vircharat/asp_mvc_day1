using BookTheShowBLL.services;
using BookTheShowDAL;
using BookTheShowDAL.Repost;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCoreApii
{
    public class Startup
    {  //middle ware startup.cs file after main execution comes here all request comes here
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //TO ACCESS JSON WE NEED iconfiguration interface

        // This method gets called by the runtime. Use this method to add services to the container.
        //we need to add service(movie service)
        public void ConfigureServices(IServiceCollection services)//object builder class it will call when this function automatically called at runtime it creates object
        {
            string connectionStr = Configuration.GetConnectionString("sqlConnection");
            services.AddDbContext<MovieDBcontextv>(options=>options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title="Movie API",
                    Description="Movie Management System API",
                });
            });
            //services.AddTransient<MovieRepost, MovieRepost>();
            services.AddTransient<ImovieRepository, MovieRepost>();// interfacename  , movieservice class where we implemented that interface 
            services.AddTransient<MovieSevice, MovieSevice>();

           

            services.AddTransient<IshowTimeRepositry, ShowTimeRepost>();
            services.AddTransient<ShowTimeService, ShowTimeService>();

            services.AddTransient<ItheatreRepositry, TheatreeRepost>();
            services.AddTransient<TheatreService, TheatreService>();

            services.AddTransient<IbookingRepositry,BookingRepost>();
            services.AddTransient<BookingService,BookingService>();

            services.AddTransient<IuserRepositry,UserRepost>();
            services.AddTransient<UserService, UserService>();


            services.AddControllers();
      
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())  //BY DEFAULT DEVELOPMENT MODE 
            {
                app.UseDeveloperExceptionPage(); // UseDeveloperExceptionPage IS A MIDDLEWARE (INBUILT) use MENTIONED  is inbuilt middleware
            }
            app.UseSwagger();
            app.UseSwaggerUI(options => 
            options.SwaggerEndpoint("/swagger/v1/swagger.json","Movie API"));
            
            app.UseRouting(); // VALIDATION OF URL IT IS A MIDDLE WARE

            


            app.UseAuthorization(); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
        }
    }
}
