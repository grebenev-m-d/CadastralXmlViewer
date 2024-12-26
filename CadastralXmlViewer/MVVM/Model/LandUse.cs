using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class LandUse
    {
        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("value")]
        public string Value { get; set; }
    }
}
