using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Adapter
{
    public class XmlToJsonAdapter<T> : IJsonParser<T>
    {
        public string ConvertToJson(T obj)
        {
            IJsonParser<T> jsonParser = new JsonParser<T>();
            return jsonParser.ConvertToJson(data);

        }

        public T Parse(string data)
        {
            IXmlParser<T> xmlParser = new XmlParser<T>();
            return xmlParser.Parse(data);
        }
    }
}
