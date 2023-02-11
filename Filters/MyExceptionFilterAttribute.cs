using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using WebApplication117.Services;

namespace WebApplication117.Filters
{
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private Logger logger;
        public MyExceptionFilterAttribute(Logger log)
        {
            logger = log;
        }
        public override void OnException(ExceptionContext context)
        {
            string infoAction = context.ActionDescriptor.DisplayName;
            string infoStack = context.Exception.StackTrace;
            string infoException = context.Exception.Message;
            string info = $"Method {infoAction} cracked with {infoException}\n";
            info += infoStack;

            logger.WriteToLog(info);

            context.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
    }
}