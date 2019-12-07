using NUnitLite;
using System;
using System.Reflection;
using TestFramework.Core.Settings;

namespace TestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start working...");
            EnvironmentSettings.CurrentBrowser = args[0];
            EnvironmentSettings.CurrentConfiguration = args[1];
            var testRunner = new AutoRun(Assembly.GetExecutingAssembly());
            testRunner.Execute(null);
        }
    }
}