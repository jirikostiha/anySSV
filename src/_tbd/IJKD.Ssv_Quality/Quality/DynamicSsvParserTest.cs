namespace Wayout.Ssv.Quality
{
    using System.IO;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [DeploymentItem(@"data\", @"data\")]
    public class DynamicSsvParserTest
    {
        [TestMethod]
        public void ParseDataValidObject()
        {
            var file = Path.Combine(ContentHelper.RootDataFolder, "singletable-header-[1]-valid.ssv");
            var originalContent = File.ReadAllText(file);
            var parser = new DynamicObjectSsvParser();
            var objs = parser.ParseData(originalContent).ToArray();

            Assert.AreEqual(2, objs.Count());
        }
    }
}
