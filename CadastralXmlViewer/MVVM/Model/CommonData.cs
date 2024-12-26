using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class CommonData
    {
        [XmlElement("type")]
        public Type Type { get; set; }

        [XmlElement("cad_number")]
        public string CadNumber { get; set; }
    }
}
