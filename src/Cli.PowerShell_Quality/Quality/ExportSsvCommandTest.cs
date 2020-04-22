namespace Wayout.AnySsv.Cli.PowerShell.Quality
{
    using System;
    using System.IO;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wayout.AnySsv.Quality;

    [TestClass]
    public class ExportSsvCommandTest
    {
        [TestMethod]
        public void ExportSsv()
        {
            var ssv = SsvFactory.Create3ColumnsNDataLines(3);

            var cmdlet = new ExportSsvCommand()
            {
                Ssv = ssv,
                Delimiter = ";",
            };

            var results = cmdlet.Invoke().OfType<object>().ToList();
            Assert.AreEqual(0, results.Count);
        }
    }
}
