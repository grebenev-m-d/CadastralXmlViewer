using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class Params
    {
        [XmlElement("category")]
        public Category Category { get; set; }

        [XmlElement("permitted_use")]
        public PermittedUse PermittedUse { get; set; }
    }
}
