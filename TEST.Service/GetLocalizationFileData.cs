using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST.Service
{
    public class GetLocalizationFileData
    {
        public List<string> ListOfSupportedLanguages { get; set; }

        public List<LocalizationKey> ListOfLocalizationKeys { get; set; }
    }
}