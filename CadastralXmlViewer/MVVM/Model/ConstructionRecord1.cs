using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class ConstructionRecord
    {
        [XmlElement("object")]
        public ConstructionObject Object { get; set; }

        [XmlElement("params")]
        public ConstructionParams Params { get; set; }
    }
}