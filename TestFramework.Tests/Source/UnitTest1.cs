using NUnit.Framework;
using System.Threading;
using TestFramework.Areas._5element.Steps;

namespace TestFramework.Tests.Source
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Steps.InitBrowser();
            Thread.Sleep(1000);
            Steps.CloseBrowser();
            Assert.Pass();
        }
    }
}