using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TEST.Service
{
    public class LanguageCode
    {
        [XmlText]
        public string Value { get; set; }
    }
}