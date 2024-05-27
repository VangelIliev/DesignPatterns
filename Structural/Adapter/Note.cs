using System.Xml.Serialization;

namespace DesignPatterns.Structural.Adapter
{
    [Serializable, XmlRoot("note")]
    internal class Note
    {
        [XmlElement("to")]
        public string To { get; set; }

        [XmlElement("from")]
        public string From { get; set; }

        [XmlElement("heading")]

        public string Heading { get; set; }

        [XmlElement("body")]

        public string Body { get; set; }
    }
}
