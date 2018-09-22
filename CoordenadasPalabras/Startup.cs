using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoordenadasPalabras.Models;
using Microsoft.EntityFrameworkCore;

namespace CoordenadasPalabras
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Connection strings
            //var connection = @"Server=W2K12-TEST\MSSQLSERVER;Database=CoordenadasPalabras.Db;Trusted_Connection=True;ConnectRetryCount=0";
            var connection = @"Data Source=DESKTOP-98T73T3;Initial Catalog=CoordenadasPalabras.Db;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
            services.AddDbContext<CrucigramaContext>
                (options => options.UseSqlServer(connection));
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
