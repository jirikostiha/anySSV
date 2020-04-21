namespace Wayout.AnySsv.Cli.PowerShell.Quality
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Management.Automation;
    using System.Xml.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wayout.AnySsv.Quality;

    [TestClass]
    public class ImportSsvCommandTest
    {
        [TestMethod]
        public void ImportSsv()
        {
            var file = Path.Combine(ContentHelper.RootDataFolder, "singletable-header-colnames-[1]-valid.ssv");

            var cmdlet = new ImportSsvCommand()
            {
                LiteralPath = file,
                Delimiter = ";",
            };

            var results = cmdlet.Invoke().OfType<object>().ToList();
            Assert.IsInstanceOfType(results[0], typeof(Ssv));
            Assert.AreEqual(3, ((Ssv)results[0]).Lines.Count);
        }
    }

    /*
     *       [TestMethod]
        public void TestMethod1()
        {
            using (var ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
            {
                var cmdlet = new ImportSsvCommand()
                {
                    LiteralPath = "",
                    Delimiter = ";",
                };

                var results = cmdlet.Invoke().OfType<string>().ToList();

                
            }
        }
     * */

    //    using (var ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
    //    {
    //        ps
    //            //.AddCommand("Import-Module").AddArgument(@"g:\...\PowerDbg.psm1")
    //            .AddCommand(new CmdletInfo("Invoke-Download", typeof(InvokeDownloadPsCommand)))
    //            .AddParameter("Uri", @"https://ftp.gnu.org/gnu/octave/windows/octave-4.2.2-w64-installer.exe")
    //            .AddParameter("TargetPath", @"c:\temp\")
    //            .Invoke();
    //    }
    //}
}
