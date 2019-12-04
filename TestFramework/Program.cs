using NUnitLite;
using System;
using System.Linq;
using System.Reflection;
using TestFramework.Core.Driver;

namespace TestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start working...");
            EnvironmentSettings.CurrentBrowser = args[0];
            var testRunner = new AutoRun(Assembly.GetExecutingAssembly());
            testRunner.Execute(null);
        }

        private static Assembly GetAssemblyByName(string name)
        {
            return AppDomain.CurrentDomain.GetAssemblies().
                   SingleOrDefault(assembly => assembly.GetName().Name == name);
        }
    }
}