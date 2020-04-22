namespace Wayout.AnySsv.Cli.PowerShell
{
    using System.IO;
    using System.Management.Automation;

    [Cmdlet(VerbsData.Export, "Ssv")]
    [Alias("essv")]
    public class ExportSsvCommand : Cmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public Ssv Ssv { get; set; }

        [Parameter(Mandatory = true)]
        [Alias("lp")]
        [ValidateNotNullOrEmpty]
        public string LiteralPath { get; set; }

        [Parameter()]
        [Alias("d")]
        public string Delimiter { get; set; } = ";";

        protected override void ProcessRecord()
        {
            var format = new SsvFormatter().Format(Ssv);
            File.WriteAllText(LiteralPath, format);
        }
    }
}
