namespace Wayout.Solution.Manipulation.Project.Cli.Powershell.Quality
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;
    using System.Security;

    [TestClass]
    public class WriteProjOutputPathPsCommandTest
    {
        // private Runspace myRunSpace;

        //[TestFixtureSetUp]
        //public void PSSetup()
        //{
        //    myRunSpace = RunspaceFactory.CreateRunspace();
        //    myRunSpace.Open();
        //    Pipeline cmd = myRunSpace.CreatePipeline(@"set-Location 'C:\dev\someproject");
        //    cmd.Invoke();
        //}

        [TestMethod]
        public void Scenario()
        {
            var runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();

            using (var ps = PowerShell.Create())
            {
                //ps.Runspace = runspace;
                //ps.Commands.AddCommand("Import-Module").AddArgument("AzureAD");
                //ps.Invoke();
                ps.Commands.Clear();
                ps.AddScript("write sddff");
                //ps.Invoke();
                var results = ps.Invoke();

            }



            //Pipeline cmd = myRunSpace.CreatePipeline("get-location");
            //Collection<PSObject> resultObject = cmd.Invoke();
            //string currDir = resultObject[0].ToString();
            //Assert.IsTrue(currDir == @"'C:\dev\someproject");

            //cmd = myRunSpace.CreatePipeline(@".\new-securestring.ps1 password");
            //resultObject = cmd.Invoke();
            //SecureString ss = (SecureString)resultObject[0].ImmediateBaseObject;
            //Assert.IsTrue(ss.Length == 8);

            //myRunSpace.SessionStateProxy.SetVariable("ss", ss);
            //cmd = myRunSpace.CreatePipeline(@".\getfrom-securestring.ps1 $ss");
            //resultObject = cmd.Invoke();
            //string clearText = (string)resultObject[0].ImmediateBaseObject;
            //Assert.IsTrue(clearText == "password");
        }
    }
}
