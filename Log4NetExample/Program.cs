using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "App.config", Watch = true)]

namespace Log4NetExample
{
    class Program
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            log.Info("This is an info log");
            log.Error("This is my error");

            Console.ReadLine();
        }
    }
}
