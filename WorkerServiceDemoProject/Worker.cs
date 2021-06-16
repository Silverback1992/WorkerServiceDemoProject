using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WorkerServiceDemoProject.Models;

namespace WorkerServiceDemoProject
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            Utility.Log("Starting GoogleCheck service.", "Info");
            client = new HttpClient();
            return base.StartAsync(cancellationToken);  
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var result = await client.GetAsync("http://www.google.com/");

                if (result.IsSuccessStatusCode)
                    Utility.Log("Website is running.", "Info");
                else
                    Utility.Log("Google is down, run for your lives.", "Error");

                await Task.Delay(5000, stoppingToken);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            Utility.Log("Stopped GoogleCheck service.", "Info");
            return base.StopAsync(cancellationToken);   
        }
    }
}
