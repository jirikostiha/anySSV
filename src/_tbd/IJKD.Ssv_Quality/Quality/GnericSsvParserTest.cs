namespace Wayout.Ssv.Quality
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GnericSsvParserTest
    {
        [TestMethod]
        public void ParseDataValid()
        {
            var sb = new StringBuilder();
            sb.AppendLine("A1;10;0.1");
            sb.AppendLine("A2;20;0.2");
            var originalContent = sb.ToString();
            var parser = new GenericObjectSsvParser<A>();
            parser.Map.Add(typeof(A), Tuple.Create("A", new List<string>() { "Name", "Num", "Real" }));
            var objs = parser.ParseData(originalContent).ToArray();

            Assert.AreEqual(2, objs.Count());
            Assert.AreEqual("A1", objs[0].Name);
            Assert.AreEqual(10, objs[0].Num);
            Assert.AreEqual(0.1, objs[0].Real);
            Assert.AreEqual("A1", objs[1].Name);
            Assert.AreEqual(20, objs[1].Num);
            Assert.AreEqual(0.2, objs[1].Real);
        }
    }

    internal class A
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public double Real { get; set; }
    }
}
