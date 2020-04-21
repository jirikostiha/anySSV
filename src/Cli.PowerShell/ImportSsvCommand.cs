namespace Wayout.AnySsv.Cli.PowerShell
{
    using System.Management.Automation;

    //https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/import-csv?view=powershell-6  
    //https://www.hanselman.com/blog/TestingPowerShellScriptsWithNUnit.aspx

    [Cmdlet(VerbsData.Import, "AnySsv")]
    public class ImportSsvCommand : Cmdlet
    {
        [Parameter(Mandatory = true)]
        [Alias("lp")]
        [ValidateNotNullOrEmpty]
        public string LiteralPath { get; set; }

        [Parameter()]
        [Alias("d")]
        public string Delimiter { get; set; } = ";";

        [Parameter()]
        [Alias("cn")]
        public string[] ColumnNames { get; set; }

        protected override void ProcessRecord()
        {
            var ssv = Ssv.Load(LiteralPath, Delimiter);
            WriteObject(ssv);
        }
    }
}
