using DotnetCoreStarter.Models;
using DotnetCoreStarter.Utilities.ActionFilters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreStarter
{
    public partial class Startup
    {
        public void ConfigureCORS(IServiceCollection services)
        {
            var corsConfig = new CorsAppSetting();
            Configuration.GetSection("CORS").Bind(corsConfig);

            if (corsConfig != null && corsConfig.AllowedUrls != null && corsConfig.AllowedUrls.Length > 0)
            {
                services.AddCors(options =>
                {
                    options.AddPolicy(AllowSpecificOrigins,
                    builder =>
                    {
                        foreach (var origin in corsConfig.AllowedUrls)
                        {
                            builder = builder.WithOrigins(origin);
                        }
                        builder.AllowAnyMethod()
                                .AllowAnyHeader();
                    });
                });
            }
        }
    }
}
