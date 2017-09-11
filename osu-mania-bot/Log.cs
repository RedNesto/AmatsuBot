using System;
using System.IO;

namespace Amatsu
{
    class Log
    {
        private static string _date {get; set;}

        public static void Init()
        {
            Console.WriteLine("Initialization started...");
            _date = DateTime.Now.ToShortDateString().Replace('.', '-').Replace('/', '-');
        }

        public static void Write(string thingToWrite)
        {
            Console.WriteLine(thingToWrite);
            File.AppendAllText(_date + "_logfile.log", $"{DateTime.Now}: {thingToWrite}\r\n");
        }

        public static void Report(string thingToWrite)
        {
            File.AppendAllText(_date + "_reportfile.log", $"{DateTime.Now}: {thingToWrite}\r\n");
        }
    }
}
