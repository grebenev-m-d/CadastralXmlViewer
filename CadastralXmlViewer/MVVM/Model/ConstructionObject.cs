using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class ConstructionObject
    {
        [XmlElement("common_data")]
        public CommonData CommonData { get; set; }

        [XmlElement("subtype")]
        public Subtype Subtype { get; set; }
    }
}