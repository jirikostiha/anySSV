namespace Wayout.AnySsv.Cli.PowerShell.Quality
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Management.Automation;
    using System.Xml.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wayout.AnySsv.Quality;

    [TestClass]
    public class ConvertToSsvCommandTest
    {
        [TestMethod]
        public void ConvertToObjects()
        {
            var objects = new List<object>();

            var cmdlet = new ConvertToSsvCommand()
            {
                Objects = objects
            };

            var results = cmdlet.Invoke().OfType<object>().ToList();

            Assert.IsInstanceOfType(results[0], typeof(Ssv));
            Assert.AreEqual(3, ((Ssv)results[0]).Lines.Count);
        }
    }
}
