using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BaseData
    {
        [XmlArray("land_records")]
        [XmlArrayItem("land_record")]
        public List<LandRecord> LandRecords { get; set; }

        [XmlArray("build_records")]
        [XmlArrayItem("build_record")]
        public List<BuildRecord> BuildRecords { get; set; }

        [XmlArray("construction_records")]
        [XmlArrayItem("construction_record")]
        public List<ConstructionRecord> ConstructionRecords { get; set; }
    }
}
