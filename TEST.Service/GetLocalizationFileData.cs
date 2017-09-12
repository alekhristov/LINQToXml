using System.Collections.Generic;

namespace TEST.Service
{
    public class GetLocalizationFileData
    {
        public List<string> ListOfSupportedLanguages { get; set; }

        public List<LocalizationKey> ListOfLocalizationKeys { get; set; }
    }
}