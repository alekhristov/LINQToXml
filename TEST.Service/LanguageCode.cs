using System.Xml.Serialization;

namespace TEST.Service
{
    public class LanguageCode
    {
        [XmlText]
        public string Value { get; set; }
    }
}