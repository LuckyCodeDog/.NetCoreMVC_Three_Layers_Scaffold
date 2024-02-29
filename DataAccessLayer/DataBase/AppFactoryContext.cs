using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataBase
{
    internal class AppFactoryContext
    {
        private static AppDbContext? appDbContext = null;
        public static AppDbContext AppDbContext()
        {

            Console.WriteLine("初始化db 了" +
                "");
            if (appDbContext == null)
            {
                //在 appsettings.json get config
                var configuration = new ConfigurationBuilder()
                .
                Add(new JsonConfigurationSource
                {
                    Path = "appsettings.json",
                    ReloadOnChange = true
                })
                .
                Build();

                var services = new ServiceCollection();
                //register AppDbContext
                services.AddDbContext<AppDbContext>(options =>

                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")),

                contextLifetime: ServiceLifetime.Singleton);

                var provider = services.BuildServiceProvider();
                Console.WriteLine(configuration.GetConnectionString("DefaultConnection"));
                appDbContext = provider.GetRequiredService<AppDbContext>();

                bool flag = appDbContext.Database.EnsureCreated();
                Console.WriteLine("db created " + flag);
            }
            return appDbContext;
        }
    }
}
