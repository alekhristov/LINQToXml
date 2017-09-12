using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TEST.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public GetLocalizationFileData GetCodesOfSupportedLanguages()
        {
            var projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            var getLocalizationFileData = new GetLocalizationFileData();

            var xdoc = XDocument.Load(projectDirectory + "\\Localization.xml");

            using (var fileStream = new FileStream(projectDirectory + "\\Localization.xml", FileMode.Open))
            {
                var xmlSerializer = new XmlSerializer(typeof(Localization));
                var localization = xmlSerializer.Deserialize(fileStream) as Localization;

                if (localization != null)
                {
                    getLocalizationFileData.ListOfSupportedLanguages = localization.LanguageCode.Select(l => l.Value).ToList();
                    getLocalizationFileData.ListOfLocalizationKeys = localization.LocalizationKey.ToList();
                }
            }

            return getLocalizationFileData;
        }

        //    public List<LocalizationKey> LocalizationKeys()
        //    {
        //        var projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

        //        var listOfLocalizationKeys = new List<LocalizationKey>();

        //        var xdoc = XDocument.Load(projectDirectory + "\\Localization.xml");

        //        using (var fileStream = new FileStream(projectDirectory + "\\Localization.xml", FileMode.Open))
        //        {
        //            var xmlSerializer = new XmlSerializer(typeof(Localization));
        //            var localization = xmlSerializer.Deserialize(fileStream) as Localization;

        //            if (localization != null)
        //            {
        //                listOfLocalizationKeys = localization.LanguageCode.Select(l => l.Value).ToList();
        //            }
        //        }

        //        return listOfLocalizationKeys;
        //    }
    }
}
