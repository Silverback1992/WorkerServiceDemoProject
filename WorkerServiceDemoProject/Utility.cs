using System;
using System.Collections.Generic;
using System.Text;
using WorkerServiceDemoProject.Models;

namespace WorkerServiceDemoProject
{
    public static class Utility
    {
        public static void Log(string msg, string lvl)
        {
            var log = new GoogleCheck()
            {
                Date = DateTime.Now,
                LogMessages = msg,
                LogLevel = lvl
            };

            using (var ctx = new TestingContext())
            {
                ctx.GoogleChecks.Add(log);
                ctx.SaveChanges();
            }
        }
    }
}
