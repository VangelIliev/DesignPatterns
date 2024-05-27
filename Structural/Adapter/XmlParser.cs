using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Adapter
{
    public class XmlParser<T> : IXmlParser<T>
    {
        private readonly XmlSerializer _serializer;

        public XmlParser()
        {
            _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(typeof(T).Name.ToLower()));
        }

        public string ConvertToXml(T obj)
        {
            using StringWriter textWriter = new StringWriter();
            _serializer.Serialize(textWriter, obj);

            return textWriter.ToString();
        }

        public T Parse(string data)
        {
            using TextReader reader = new StringReader(data);
            return (T)_serializer.Deserialize(reader);
        }
    }
}
