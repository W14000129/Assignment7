using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using API.Models;
using System.Data.SqlClient;

namespace API
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
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials());
			});

			services.AddMvc();
			var connection = @"Server=(localdb)\MSSQLLocalDB;Database=CNotes3;Trusted_Connection=True;ConnectRetryCount=0";
			services.AddDbContext<EntitiesContext>(options => options.UseSqlServer(connection));
		    
		}

	//	public void CServices(IServiceCollection services)
	//	{
	//		services.AddMvc();
	//		var c = @"Driver={SQL Server Native Client 10.0};Server=den1.mssql3.gear.host;Database=notesapp;Uid=notesapp;Pwd=Jw9mjpip?-JK;";
	//		services.AddDbContext<EntitiesContext>(options => options.UseSqlServer(c));

	//	}




		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}

			else

			{

				app.UseExceptionHandler(" / Home/Error");

			}
			app.UseCors("CorsPolicy");

			app.UseMvc(routes =>

			{

				routes.MapRoute(

					name: "default",

					template: "{controller=Home}/{action=Index}/{id?}");

			});
		}
    }
}
