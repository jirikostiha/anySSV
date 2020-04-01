namespace Wayout.Ssv.Cli.PowerShell
{
    using System.Management.Automation;

    //https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/import-csv?view=powershell-6  

    [Cmdlet(VerbsData.Import, "Ssv")]
    public class ImportSsvCommand : PSCmdlet
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
