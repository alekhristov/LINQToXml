using System.Xml.Serialization;

namespace TEST.Service
{
    public class LocalizationKey
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlElement("Value")]
        public Values[] Value { get; set; }
    }
}