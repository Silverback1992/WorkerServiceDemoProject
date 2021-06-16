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
            //Looks like you can have your config file on Mars and still make this work
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: false);

            //IConfiguration config = builder.Build();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _connectionString = config.GetSection("ConnectionStrings").GetSection("DefaultConnectionString").Value;
        }
    }
}
