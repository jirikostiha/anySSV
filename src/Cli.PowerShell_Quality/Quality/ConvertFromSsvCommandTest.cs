namespace Wayout.AnySsv.Cli.PowerShell.Quality
{
    using System;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Management.Automation;
    using System.Xml.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wayout.AnySsv.Quality;

    [TestClass]
    public class ConvertFromSsvCommandTest
    {
        [TestMethod]
        public void ConvertFromObjects()
        {
            var ssv = SsvFactory.Create3ColumnsNDataLines(2);

            var cmdlet = new ConvertFromSsvCommand()
            {
                Ssv = ssv
            };

            var results = cmdlet.Invoke().OfType<object>().ToList();

            dynamic obj1 = results[0];
            Assert.IsInstanceOfType(obj1, typeof(ExpandoObject));
            Assert.AreEqual("a1", obj1.A);
        }
    }
}
