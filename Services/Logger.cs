using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication117.Services
{
    public class Logger
    {
        public string LogToFile { get; set; } = "Logs/log.txt";

        public void WriteToLog(string text)
        {
            StreamWriter stream = new StreamWriter(LogToFile, true);
            stream.WriteLine(text);
            stream.Close();
        }

    }
}
