using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorkerServiceDemoProject
{
    public static class ConfigManager
    {
        private static string _connectionString;
        public static string ConnectionString { get => _connectionString; }
        static ConfigManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            _connectionString = config.GetSection("ConnectionStrings").GetSection("DefaultConnectionString").Value;
        }
    }
}
