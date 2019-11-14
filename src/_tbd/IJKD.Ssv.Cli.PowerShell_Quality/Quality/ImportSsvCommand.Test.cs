namespace Wayout.Ssv.Cli.PowerShell.Quality
{
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [DeploymentItem(@"data\", @"data\")]
    public class ImportSsvCommandTest
    {
        //https://github.com/PowerShell/PowerShell/issues/2108

        [TestMethod]
        public void ImportSsv()
        {
            var file = Path.Combine(ContentHelper.RootDataFolder, "multitable-[1]-valid.ssv");
            var originalContent = File.ReadAllLines(file);

            //var config = RunspaceConfiguration.Create();
            //PSSnapInException warning;
            //config.AddPSSnapIn("LuifITPSSnapin", out warning);



            var myRunSpace = RunspaceFactory.CreateRunspace();
            myRunSpace.Open();
            Pipeline cmd = myRunSpace.CreatePipeline($"import-ssv {file}");
            Collection<PSObject> resultObject = cmd.Invoke();

            var ssv = resultObject[0].ImmediateBaseObject as IJKD.Ssv;
            Assert.IsNotNull(ssv);
            
            SsvAssertHelper.AssertSsvEqualsContentLines(ssv, originalContent);
        }
    }
}
