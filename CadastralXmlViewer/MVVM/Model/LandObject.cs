using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class LandObject
    {
        [XmlElement("common_data")]
        public CommonData CommonData { get; set; }

        [XmlElement("subtype")]
        public Subtype Subtype { get; set; }
    }
}
