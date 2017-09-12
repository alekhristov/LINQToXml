using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TEST.Service
{
    public class Values
    {
        [XmlAttribute("Language")]
        public string LanguageCode { get; set; }

        [XmlText()]
        public string LocalizationImplementation { get; set; }
    }
}