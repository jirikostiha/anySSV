namespace Wayout.Ssv
{
    using System.IO;

    //validace

    public class SsvComponent
    {
        public SsvComponent()
        {
        }

        //spise do komponenty
        public static Ssv Load(string filePath)
        {
            var content = File.ReadAllText(filePath);
            var parser = new SsvParser();
            return parser.Parse(content);
        }

        

       
    }
}
