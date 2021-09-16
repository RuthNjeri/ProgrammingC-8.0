using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorld.Tests
{
    [TestClass] // An attribute, used by the Microsoft UnitTest framework
    public class WhenProgramRuns
    {
        private string _consoleOutput;

        [TestInitialize] // Test runner will execute this once for every test in the class, before the test runs
        public void Initialize()
        {
            var w = new System.IO.StringWriter();
            Console.SetOut(w);

            Program.Main(new string[0]);

            _consoleOutput = w.GetStringBuilder().ToString().Trim();

            

        }

        [TestMethod]// Tells the test runner which methods represents tests
        public void SaysHelloWorld()
        {
            Assert.AreEqual("Hello, world!", _consoleOutput);
        }
    }
}
