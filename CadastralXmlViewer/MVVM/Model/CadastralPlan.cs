using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    [XmlRoot("extract_cadastral_plan_territory")]
    public class CadastralPlan
    {
        [XmlElement("details_statement")]
        public DetailsStatement DetailsStatement { get; set; }

        [XmlElement("details_request")]
        public DetailsRequest DetailsRequest { get; set; }

        [XmlArray("cadastral_blocks")]
        [XmlArrayItem("cadastral_block")]
        public List<CadastralBlock> CadastralBlocks { get; set; }
    }
}
