using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TEST.Service
{
    [XmlRoot("Localization")]
    public class Localization
    {
        [XmlArray("SupportedLanguageCodes")]
        [XmlArrayItem("LanguageCode")]
        public LanguageCode[] LanguageCode { get; set; }

        [XmlArray("LocalizationKeys")]
        [XmlArrayItem("LocalizationKey")]
        public LocalizationKey[] LocalizationKey { get; set; }

    }
}