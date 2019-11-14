namespace Wayout.Ssv
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Generic object ssv parser.
    /// </summary>
    /// <typeparam name="T"> type of a parsed object </typeparam>
    public class GenericObjectSsvParser<T>
    {
        public IDictionary<Type, Tuple<string, List<string>>> Map { get; set; }

        //public IDictionary<string, IList<string>> PropertyMap { get; set; }

        //public IList<Tuple<string, Type, List<string>>> Map { get; set; }

        public GenericObjectSsvParser()
        {
            //TypeMap = new Dictionary<Type, string>();
            //PropertyMap = new Dictionary<string, IList<string>>();
            //Map = new List<Tuple<string, Type, List<string>>>();
            Map = new Dictionary<Type, Tuple<string, List<string>>>();
        }

        public IEnumerable<T> ParseData(string format)
        {
            var ssv = new SsvParser().Parse(format);
            return Parse(ssv);
        }

        public IEnumerable<T> Parse(Ssv format, Func<T> initialObjectProvider = null)
        {
            if (!Map.TryGetValue(typeof(T), out var tableMap))
            {
                if (!Map.TryGetValue(null, out tableMap))
                    throw new Exception();
            }

            var tableName = tableMap.Item1;
            var properties = tableMap.Item2;

            foreach (var line in format.GetTableData(tableName))
            {
                var obj = initialObjectProvider == null ? Activator.CreateInstance<T>() : initialObjectProvider();
                for (int i = 0; i < line.Values.Count; i++)
                {
                    if (i >= properties.Count)
                        break;
                    var propertyName = properties[i];
                    if (propertyName == null)
                        continue;
                    if (propertyName == string.Empty)
                    {
                        //take name from ssv
                        //todo
                    }
                    var propertyInfo = obj.GetType().GetProperty(propertyName);
                    var formattedValue = line.Values[i].Trim();
                    var formattedValueType = Convert.ChangeType(formattedValue, propertyInfo.PropertyType, CultureInfo.InvariantCulture);
                    propertyInfo.SetValue(obj, formattedValueType);
                }
                yield return obj;
            }
        }
    }
}
