namespace Wayout.Ssv.Quality
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [DeploymentItem(@"data\", @"data\")]
    public class SsvParserTest
    {
        [TestMethod]
        public void ParseAndFormatValidSingleTablesWithDataOnly()
        {
            var files = Directory.GetFiles(ContentHelper.RootDataFolder, "singletable-*data_only*[*]-valid.ssv");
            foreach (var file in files)
            {
                Console.Write(file);
                var originalContent = File.ReadAllLines(file);
                var parser = new SsvParser();
                var ssv = parser.Parse(originalContent);

                SsvAssertHelper.AssertSsvEqualsContentLines(ssv, originalContent);

                Console.WriteLine(" - ok");
            }
        }

        [TestMethod]
        public void ParseAndFormatValidSingleTablesWithTableName()
        {
            var files = Directory.GetFiles(ContentHelper.RootDataFolder, "singletable-*name*[*]-valid.ssv");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                var originalContent = File.ReadAllLines(file);
                var parser = new SsvParser();
                var ssv = parser.Parse(originalContent);

                SsvAssertHelper.AssertSsvEqualsContentLines(ssv, originalContent);

                Console.WriteLine(" - ok");
            }
        }

        [TestMethod]
        public void ParseAndFormatValidSingleTablesWithHeader()
        {
            var files = Directory.GetFiles(ContentHelper.RootDataFolder, "singletable-*header*[*]-valid.ssv");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                var originalContent = File.ReadAllLines(file);
                var parser = new SsvParser();
                var ssv = parser.Parse(originalContent);

                SsvAssertHelper.AssertSsvEqualsContentLines(ssv, originalContent);

                Console.WriteLine(" - ok");
            }
        }

        [TestMethod]
        public void ParseAndFormatValidMultiTables()
        {
            var files = Directory.GetFiles(ContentHelper.RootDataFolder, "multitable-*[*]-valid.ssv");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                var originalContent = File.ReadAllLines(file);
                var parser = new SsvParser();
                var ssv = parser.Parse(originalContent);

                SsvAssertHelper.AssertSsvEqualsContentLines(ssv, originalContent);

                Console.WriteLine(" - ok");
            }
        }
    }
}
