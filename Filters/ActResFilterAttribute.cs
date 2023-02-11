using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace WebApplication117.Filters
{
    public class ActResFilterAttribute : ActionFilterAttribute
    {
        public Stopwatch timer;

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            timer = Stopwatch.StartNew();

            await next();

            timer.Stop();
            var delta = timer.Elapsed;
            string infoAction = context.ActionDescriptor.DisplayName; 
            string info = $"{infoAction} action time is {delta}";
            StreamWriter stream = new StreamWriter("Logs/log.txt", true);
            stream.WriteLine(info);
            stream.Close();
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            timer.Stop(); 
            var delta = timer.Elapsed; 
            string infoAction = context.ActionDescriptor.DisplayName;
            string info = $"{infoAction} result time is {delta}";
            StreamWriter stream = new StreamWriter("Logs/log.txt", true);
            stream.WriteLine(info);
            stream.Close();
        }
    }
}