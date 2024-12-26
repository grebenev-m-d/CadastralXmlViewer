using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class AreaQuarter
    {
        [XmlElement("area")]
        public int Area { get; set; }

        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
