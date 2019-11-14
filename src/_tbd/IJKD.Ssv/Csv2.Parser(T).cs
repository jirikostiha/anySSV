namespace IJKD.Perun.Conversion.ParsingAndFormating.Csv
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    //CSV (Comma-separated values) - SV reader/parser nebo char-sep-values

    public class Csv2Parser<T>
    {
        //vysledet v tomto pripade je pole objektu
		public object Parse(string format, object obj = null)
		{
            return Parse(format, null, (T)obj);
		}

        public T Parse(string format, IList<Tuple<string, PropertyInfo, object>> outExternalReferences = null, T obj = default(T))
        {
            //todo
            return obj;
        }
       


        //private T AssignValuesFromCsv(string[] propertyValues, List<string> headers)
        //{
        //    var obj = new T();
        //    var properties = obj.GetType().GetProperties().Where(d => d.Name.ToUpperInvariant() != "ID").ToArray();
        //    var upperHeaders = headers.Select(d => d.ToUpperInvariant()).ToList();
        //    for (var i = 0; i < properties.Length; i++)
        //    {
        //        var type = properties[i].PropertyType.Name;
        //        var index = !upperHeaders.IsNullOrEmpty() ? upperHeaders.IndexOf(properties[i].Name.ToUpperInvariant()) : i;
        //        if (index == -1) break;
        //        switch (type)
        //        {
        //            case "Int32":
        //                properties[i].SetValue(obj,
        //                    int.Parse(propertyValues[index]));
        //                break;
        //            default:
        //                properties[i].SetValue(obj, propertyValues[index]);
        //                break;
        //        }
        //    }
        //    return obj;
        //}
    }
}