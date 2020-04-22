namespace Wayout.AnySsv.Cli.PowerShell
{
    using System.Management.Automation;

    [Cmdlet(VerbsData.ConvertFrom, "Ssv")]
    [Alias("cfssv")]
    public class ConvertFromSsvCommand : Cmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public Ssv Ssv { get; set; }

        protected override void ProcessRecord()
        {
            var objects = new DynamicObjectParser().Parse(Ssv);
            foreach (var obj in objects)
                WriteObject(obj);
        }
    }
}
