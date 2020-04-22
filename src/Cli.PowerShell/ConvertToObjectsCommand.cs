namespace Wayout.AnySsv.Cli.PowerShell
{
    using System.Collections.Generic;
    using System.Management.Automation;

    [Cmdlet(VerbsData.ConvertTo, "Ssv")]
    [Alias("ctssv")]
    public class ConvertToSsvCommand : Cmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public IEnumerable<object> Objects { get; set; }

        protected override void ProcessRecord()
        {
            //var objects = new DynamicObjectParser().Parse(Ssv);
            var ssv = new Ssv();
            WriteObject(ssv);
        }
    }
}
