using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class LandRecord
    {
        [XmlElement("object")]
        public LandObject Object { get; set; }

        [XmlElement("params")]
        public Params Params { get; set; }
    }
}
