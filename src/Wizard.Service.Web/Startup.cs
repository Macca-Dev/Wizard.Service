using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Wizard.Service.Libs.Mappers;
using Wizard.Service.Libs.Mappers.Impl;

namespace Wizard.Service
{
	public class Startup
	{
		public IConfigurationRoot Configuration { get; }

		public Startup(IHostingEnvironment env)
		{
			Configuration = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info { Title = "Wizard Service", Version = "v1" });
			});

			services.AddSingleton<IStableMapper, StableMapper>();
		}
		
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			app.UseMvc();
			
			app.UseSwagger();
			app.UseSwaggerUi(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});
		}
	}
}